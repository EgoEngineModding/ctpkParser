using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xBB511C98)]
    class vehicle_tier_obj : CatalogueObject
    {
        public vehicle_tier_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_tier_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_tier_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x05)] public bool field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x2442A3BA)][ProtoMember(0x07)] public uint field_7;
    }
}