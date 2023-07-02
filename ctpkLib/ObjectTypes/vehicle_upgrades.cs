using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0D385F9F)]
    class vehicle_upgrades_obj : CatalogueObject
    {
        public vehicle_upgrades_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_upgrades_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_upgrades_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7245E185)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xAA64DA8D)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public int field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public float field_b;
    }
}