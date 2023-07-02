using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ctpkLib
{
    public class CatalogueObject
    {
        UInt32 _id;
        UInt32 _sectionId;
        UInt32 _length;
        byte[] _data;
        protected ObjMap _map;
        long _offset;
        CTPKLib _lib;

        public CatalogueObject(CTPKLib lib, UInt32 sectionId, BinaryReader r)
        {
            _lib = lib;
            _sectionId = sectionId;
            _offset = r.BaseStream.Position;
            _id = r.ReadUInt32();
            _length = r.ReadUInt32();
            
            _data = r.ReadBytes((int)_length);

            _map = new ObjMap();
        }

        public UInt32 Id   { get { return _id; } }
        public UInt32 SectionId { get { return _sectionId; } }
        public byte[] Data { get { return _data; } }
        public ObjMap Map { get { return _map; } }
        public long Offset { get { return _offset; } }
        public CTPKLib Lib { get { return _lib; } }

        public string GetName()
        {
               return Lib.GetString(SectionId) ?? this.GetType().Name;
        }

    }

    public class ObjMap
    {
    }


}
