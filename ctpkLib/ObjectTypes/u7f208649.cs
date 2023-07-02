using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7F208649)]
    class u7f208649_obj : CatalogueObject
    {
        public u7f208649_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u7f208649_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u7f208649_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [MappedObject(0x744671E9)][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xCEF1CCEC)][ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public bool field_a;
    }
}