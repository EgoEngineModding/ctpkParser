using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC337BE46)]
    class product_obj : CatalogueObject
    {
        public product_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<product_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class product_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [MappedObject(0x3BFA4094)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public bool field_6;
    }
}