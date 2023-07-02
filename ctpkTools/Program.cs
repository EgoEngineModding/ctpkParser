using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ctpkLib;

namespace ctpkTools
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream ctpk = new FileStream(args[0], FileMode.Open);

            CTPKLib lib = new CTPKLib(ctpk);
            ctpk.Close();

            var file = new StreamReader(new FileStream("C:\\Users\\Luigi\\Downloads\\Strings\\dr.txt", FileMode.Open));

            List<string> strings = new List<string>();
            List<UInt32> printed = new List<uint>();
            string line;
            while ((line = file.ReadLine()) != null)
            {
            //    line = line.ToLowerInvariant();
                  strings.Add(line);
                  UInt32 hash = CTPKLib.MakeHash(Encoding.UTF8.GetBytes(line));

                if (printed.Contains(hash)) continue;
                if (lib.Objects.ObjectMap.ContainsKey(hash))
                {
                    Console.WriteLine(string.Format("{0}: {1:X8}", line, hash));
                    printed.Add(hash);
                }
            }
            file.Close();

            //foreach (var w in strings)
            //{
            //    if (w.EndsWith("s")) continue;

            //    string word = w + "s";
            //    UInt32 hash = CTPKLib.MakeHash(Encoding.UTF8.GetBytes(word));


            //    if (printed.Contains(hash)) continue;
            //    if (lib.Objects.ObjectMap.ContainsKey(hash))
            //    {
            //        Console.WriteLine(string.Format("{0}: {1:X8}", word, hash));
            //        printed.Add(hash);
            //    }
            //}

            Console.ReadKey();

        }

        /*private void AddNodes(CatalogueObject obj, ref File nodes)
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

                    if (refObj != null)
                        AddNodes(refObj, ref parent);
                }
                else
                {
                    nodes.Nodes.Add(string.Format("{0}: {1}", field.Name, field.GetValue(obj.Map)));
                }
            }
        }*/

        static int FindPattern(byte[] source, byte[] pattern, string mask, int index = 0, bool findNext = false)
        {
            if (pattern.Length != mask.Length)
                return -1;


            for (int i = findNext ? index + 1 : index; i < (source.Length - pattern.Length); i++)
            {
                bool found = true;
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (!match(source[i + j], pattern[j], mask[j]))
                    {
                        found = false;
                        break;
                    }
                }
                if (found) return i;

            }
            return -1;
        }

        static bool match(byte src, byte test, char mask)
        {
            if (mask == '?') return true;
            return src == test;
        }
    }
}
