using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib
{
    public class CatalogueStrings
    {

        UInt32 nStrings;
        Dictionary<UInt32, string> _stringMap = new Dictionary<uint, string>();

        public CatalogueStrings(BinaryReader r)
        {
            nStrings = r.ReadUInt32();

            for (int i = 0; i < nStrings; i++)
            {
                UInt32 s_len = r.ReadUInt32();
                byte[] b = r.ReadBytes((int)s_len);
                string s = Encoding.UTF8.GetString(b);
                UInt32 h = CTPKLib.MakeHash(b);

                if (_stringMap.ContainsKey(h))
                    throw new ArgumentException("Stringmap already contains current key!");

                _stringMap.Add(h, s);
            }

            return;
        }

        public void AddString(string str)
        {
            UInt32 h = CTPKLib.MakeHash(Encoding.UTF8.GetBytes(str));
            if (_stringMap.ContainsKey(h))
                return;

            _stringMap.Add(h, str);
        }

        public Dictionary<UInt32, string> StringMap { get { return _stringMap; } }
    }
}
