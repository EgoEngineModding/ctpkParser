using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x39FFE76B)]
    class u39ffe76b_obj : CatalogueObject
    {
        public u39ffe76b_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u39ffe76b_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u39ffe76b_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [MappedString][ProtoMember(0x06)] public uint field_6;
    }
}