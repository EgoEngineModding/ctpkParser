using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3FA0246C)]
    class reset_process_attributes_obj : CatalogueObject
    {
        public reset_process_attributes_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<reset_process_attributes_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class reset_process_attributes_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public float field_6;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public float field_9;
        [ProtoMember(0x0A)] public bool field_a;
        [ProtoMember(0x0B)] public bool field_b;
    }
}