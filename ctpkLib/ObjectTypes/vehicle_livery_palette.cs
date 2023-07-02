using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE770A54D)]
    class vehicle_livery_palette_obj : CatalogueObject
    {
        public vehicle_livery_palette_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_livery_palette_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_livery_palette_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x3AA9AAFB)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x3AA9AAFB)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0x3AA9AAFB)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x3AA9AAFB)][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0D)] public uint field_d;
        [ProtoMember(0x0F)] public uint field_f;
        [ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x13)] public uint field_13;
        [ProtoMember(0x14)] public uint field_14;
    }
}