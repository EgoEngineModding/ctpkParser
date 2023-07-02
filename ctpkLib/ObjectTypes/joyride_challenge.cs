using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1FDD9A5D)]
    class joyride_challenge_obj : CatalogueObject
    {
        public joyride_challenge_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<joyride_challenge_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class joyride_challenge_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x744671E9)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xC16A87DF)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public int field_b;
        [ProtoMember(0x0C)] public int field_c;
        [ProtoMember(0x0D)] public int field_d;
    }
}