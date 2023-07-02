using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB4882DEE)]
    class vehicle_engine_tuning_obj : CatalogueObject
    {
        public vehicle_engine_tuning_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_engine_tuning_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_engine_tuning_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7245E185)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x08)] public int field_8;
        [ProtoMember(0x09)] public int field_9;
        [ProtoMember(0x0A)] public int field_a;
        [ProtoMember(0x0B)] public int field_b;
    }
}