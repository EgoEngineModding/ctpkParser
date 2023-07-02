using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x6F09B14D)]
    class u6f09b14d_obj : CatalogueObject
    {
        public u6f09b14d_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u6f09b14d_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u6f09b14d_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7604D91E)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x9F9E384A)][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [MappedString][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0xA5819819)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xA5819819)][ProtoMember(0x0A)] public uint field_a;
        [MappedObject(0xA5819819)][ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0xA5819819)][ProtoMember(0x0C)] public uint field_c;
        [MappedObject(0xA5819819)][ProtoMember(0x0D)] public uint field_d;
    }
}