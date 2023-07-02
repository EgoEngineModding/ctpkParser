using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib
{
    public class CTPKLib
    {
        UInt32 _stringOffset;
        UInt32 _objOffset;

        CatalogueStrings _strings;
        CatalogueObjects _objects;

        public CTPKLib(Stream stream)
        {
            BinaryReader r = new BinaryReader(stream);
            stream.Seek(12, SeekOrigin.Begin);

            _stringOffset = r.ReadUInt32();
            _objOffset = r.ReadUInt32();

            stream.Seek(_stringOffset, SeekOrigin.Begin);

            _strings = new CatalogueStrings(r);

            stream.Seek(_objOffset, SeekOrigin.Begin);
            _objects = new CatalogueObjects(this, r);

            return;
        }

        public string GetString(UInt32 hash)
        {
            string str;
            return Strings.StringMap.TryGetValue(hash, out str) ? str : null;
        }

        public CatalogueObject GetObject(UInt32 sectionId, UInt32 objectId)
        {
            return Objects.ObjectMap[sectionId].Where(o => o.Id == objectId).FirstOrDefault();
        }

        public CatalogueStrings Strings { get { return _strings; } }
        public CatalogueObjects Objects { get { return _objects; } }

        public static UInt32 MakeHash(byte[] data)
        {
            uint v = 0x1505;
            foreach (byte b in data)
            {
                sbyte sb = (sbyte)b;
                v = (uint)(((int)v * 33) + sb);
            }
            return v;
        }
    }
}
