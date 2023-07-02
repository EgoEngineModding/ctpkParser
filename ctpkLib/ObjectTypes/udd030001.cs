using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xDD030001)]
    class udd030001_obj : CatalogueObject
    {
        public udd030001_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<udd030001_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class udd030001_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x07)] public uint field_7;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x08)] public uint field_8;
        [ProtoMember(0x09)] public bool field_9;
        [MappedObject(0x2442A3BA)][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
        [MappedObject(0xA170B822)][ProtoMember(0x10)] public uint field_10;
        [MappedObject(0x4F12F227)][ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x12)] public int field_12;
        [ProtoMember(0x13)] public bool field_13;
    }
}