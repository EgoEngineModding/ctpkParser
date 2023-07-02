using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x201BEA9C)]
    class entitlement_item_obj : CatalogueObject
    {
        public entitlement_item_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<entitlement_item_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class entitlement_item_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
        [ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public int field_7;
    }
}