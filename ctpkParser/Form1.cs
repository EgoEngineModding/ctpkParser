using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using ctpkLib;

namespace ctpkParser
{
    public partial class Form1 : Form
    {
        private CTPKLib lib;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Catalogue Files|*.ctpk";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            string path = ofd.FileName;

            FileStream fs = new FileStream(path, FileMode.Open);

            lib = new CTPKLib(fs);

            var nodes = catalogueView.Nodes;

            int i = 0;
            foreach (var sectionMap in lib.Objects.ObjectMap)
            {
                string nodeIdStr = sectionMap.Key.ToString("X08");

                string name = "nullObject";

                var objt = sectionMap.Value.FirstOrDefault();
                if (objt != null)
                {
                    name = objt.GetName();
                    
                }

                var node = nodes.Add(nodeIdStr, String.Format("{0,3:D} | {1} - {2} ({3})", i, nodeIdStr, name, sectionMap.Value.Count));
                foreach (var obj in sectionMap.Value)
                {
                    var objNode = node.Nodes.Add(string.Format("{0} - {1:X08}", obj.Id, obj.Offset));
                    AddNodes(obj, ref objNode, 0);
                }
                i++;
            }
        }

        private void AddNodes(CatalogueObject obj, ref TreeNode nodes, int depth)
        {
            var fields = obj.Map.GetType().GetFields();
            foreach (var field in fields)
            {
                bool isString = Attribute.IsDefined(field, typeof(MappedString));
                bool isObject = Attribute.IsDefined(field, typeof(MappedObject));
                


                if (isString)
                {
                    nodes.Nodes.Add(string.Format("{0}: {1}", field.Name, lib.Strings.StringMap[(uint)field.GetValue(obj.Map)]));
                }
                else if (isObject)
                {
                    MappedObject attr = field.GetCustomAttribute<MappedObject>();


                    UInt32 sectionId = attr.SectionId;
                    UInt32 objId = (uint)field.GetValue(obj.Map);
                    CatalogueObject refObj = lib.GetObject(sectionId, objId);

                    TreeNode parent = nodes.Nodes.Add(string.Format("{0}: {1} ({2})", field.Name, field.GetValue(obj.Map), refObj?.GetName() ?? lib.GetString(sectionId) ?? ""));

                    if (refObj != null && depth < 1)
                        AddNodes(refObj, ref parent, depth + 1);
                }
                else
                {
                    nodes.Nodes.Add(string.Format("{0}: {1}", field.Name, field.GetValue(obj.Map)));
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lib == null)
                return;

            var hash = lib.Strings.StringMap.FirstOrDefault(t => t.Value.StartsWith(textBox1.Text)).Key;
            var l = varint(hash);

            foreach (var s in lib.Objects.ObjectMap)
            {
                bool done = false;
                foreach (var obj in s.Value)
                {
                    if (new List<byte>(obj.Data).ContainsSequence(l))
                    {
                        done = true;
                        textBox2.Text = s.Key.ToString("X08");
                        break;
                    }

                }
                if (done) break;
            }
        }

        private List<byte> varint(UInt32 v)
        {
            List<Byte> l = new List<byte>();
            while (v > 0x7F)
            {
                byte temp = (byte)((v & 0x7F) | 0x80);
                v >>= 7;
                l.Add(temp);
            }
            l.Add((byte)v);
            return l;
        }
    }

    public static class ArrExtensions
    {
        public static bool ContainsSequence<T>(this IEnumerable<T> outer,
                                   IEnumerable<T> inner)
        {
            var innerCount = inner.Count();
            for (int i = 0; i < outer.Count() - innerCount; i++)
            {
                if (outer.Skip(i).Take(innerCount).SequenceEqual(inner))
                    return true;
            }

            return false;
        }
    }
}
