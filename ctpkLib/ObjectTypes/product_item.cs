using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3BFA4094)]
    class product_item_obj : CatalogueObject
    {
        public product_item_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<product_item_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class product_item_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public int field_3;
    }
}