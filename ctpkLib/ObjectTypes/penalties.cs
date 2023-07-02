using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1C35364A)]
    class penalties_obj : CatalogueObject
    {
        public penalties_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<penalties_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class penalties_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x744671E9)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xEEC29F03)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
    }
}