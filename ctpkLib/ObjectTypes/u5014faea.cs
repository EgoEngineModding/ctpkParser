using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x5014FAEA)]
    class u5014faea_obj : CatalogueObject
    {
        public u5014faea_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u5014faea_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u5014faea_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [MappedObject(0x302FDBCE)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x302FDBCE)][ProtoMember(0x04)] public uint field_4;
    }
}