using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3BE6AFF1)]
    class package_license_masks_obj : CatalogueObject
    {
        public package_license_masks_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<package_license_masks_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class package_license_masks_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [MappedObject(0xF2075A24)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public bool field_d;
    }
}