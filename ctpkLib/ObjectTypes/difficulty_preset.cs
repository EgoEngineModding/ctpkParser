using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB6045CAA)]
    class difficulty_preset_obj : CatalogueObject
    {
        public difficulty_preset_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<difficulty_preset_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class difficulty_preset_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x47B037A8)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x5A55B573)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x18946F81)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x19B11B30)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xA50C635F)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xA50C6300)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0xA50C73F0)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xA50C91B7)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xE3A06203)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0x2BF04D82)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x4A9B42D3)][ProtoMember(0x0C)] public uint field_c;
        [MappedObject(0xA50C838A)][ProtoMember(0x0D)] public uint field_d;
        [MappedObject(0xA50CB442)][ProtoMember(0x0E)] public uint field_e;
        [MappedObject(0xA50C79FF)][ProtoMember(0x10)] public uint field_10;
        [MappedObject(0xA50CA12E)][ProtoMember(0x11)] public uint field_11;
    }
}