using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF3C28C8A)]
    class reward_token_obj : CatalogueObject
    {
        public reward_token_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<reward_token_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class reward_token_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x744671E9)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x8B46BC8A)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xF315FF18)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x09)] public int field_9;
        [MappedObject(0x7245E185)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0xC16A87DF)][ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public bool field_c;
    }
}