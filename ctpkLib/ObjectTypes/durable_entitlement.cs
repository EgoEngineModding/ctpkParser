using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x079B5C2C)]
    class durable_entitlement_obj : CatalogueObject
    {
        public durable_entitlement_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<durable_entitlement_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class durable_entitlement_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x1072479A)][ProtoMember(0x08)] public uint field_8;
        [MappedObject(0x7245E185)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0xC16A87DF)][ProtoMember(0x0A)] public uint field_a;
        [MappedString][ProtoMember(0x0B)] public uint field_b;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x0D)] public int field_d;
        [ProtoMember(0x0E)] public bool field_e;
        [MappedString][ProtoMember(0x0F)] public uint field_f;
    }
}