using System;
using System.Collections.Generic;
using System.IO;
using ProtoBuf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEE3BF852)]
    class ManufacturerObj : CatalogueObject
    {
        public ManufacturerObj(CTPKLib lib, uint sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ManufacturerObjMap>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ManufacturerObjMap : ObjMap
    {
        [ProtoMember(1)] public uint Id;
        [MappedString][ProtoMember(2)] public uint str1;
        [MappedObject(0xD8D448D1)][ProtoMember(4)] public uint obj1;
        [MappedString] [ProtoMember(5)] public uint str2;
    }
}
