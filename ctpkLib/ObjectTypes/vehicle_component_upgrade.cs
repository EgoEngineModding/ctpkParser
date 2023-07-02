using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB4C0949E)]
    class vehicle_component_upgrade_obj : CatalogueObject
    {
        public vehicle_component_upgrade_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_component_upgrade_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_component_upgrade_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7245E185)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public int field_7;
    }
}