using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF424531E)]
    class vehicle_livery_generic_setups_obj : CatalogueObject
    {
        public vehicle_livery_generic_setups_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_livery_generic_setups_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_livery_generic_setups_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x92F6A4D1)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xE770A54D)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xEDB3E3D5)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xEDB3E3D5)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0x9A4B0B66)][ProtoMember(0x0B)] public uint field_b;
    }
}