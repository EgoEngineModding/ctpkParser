using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1153FD2A)]
    class object_templates_obj : CatalogueObject
    {
        public object_templates_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<object_templates_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class object_templates_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x6C8E7404)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public bool field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public bool field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [ProtoMember(0x0B)] public bool field_b;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
        [MappedString][ProtoMember(0x0D)] public uint field_d;
    }
}