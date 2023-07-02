using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3B693001)]
    class u3b693001_obj : CatalogueObject
    {
        public u3b693001_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u3b693001_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u3b693001_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x74EB862E)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [MappedObject(0xD1946D7C)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public float field_6;
    }
}