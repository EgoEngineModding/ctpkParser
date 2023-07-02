using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x6A4EBDA1)]
    class tuning_advanced_component_obj : CatalogueObject
    {
        public tuning_advanced_component_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<tuning_advanced_component_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class tuning_advanced_component_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x90E7748D)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x60F1F18C)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public float field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
    }
}