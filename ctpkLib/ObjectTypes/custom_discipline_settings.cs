using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7361DC53)]
    class custom_discipline_settings_obj : CatalogueObject
    {
        public custom_discipline_settings_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<custom_discipline_settings_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class custom_discipline_settings_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x8F3F87B0)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xE6A5B53C)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
    }
}