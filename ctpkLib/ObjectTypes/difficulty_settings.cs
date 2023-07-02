using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x47B037A8)]
    class difficulty_settings_obj : CatalogueObject
    {
        public difficulty_settings_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<difficulty_settings_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class difficulty_settings_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x5AF71738)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public float field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
    }
}