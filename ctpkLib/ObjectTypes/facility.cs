using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB756EAFA)]
    class facility_obj : CatalogueObject
    {
        public facility_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<facility_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class facility_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x2E05BF50)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xE25B9C9B)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x4F8D1697)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x09)] public int field_9;
        [ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x2E05BF50)][ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public uint field_d;
        [MappedObject(0xD58E5B7B)][ProtoMember(0x0F)] public uint field_f;
        [ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x11)] public bool field_11;
    }
}