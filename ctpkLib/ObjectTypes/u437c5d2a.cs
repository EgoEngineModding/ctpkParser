using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x437C5D2A)]
    class u437c5d2a_obj : CatalogueObject
    {
        public u437c5d2a_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u437c5d2a_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u437c5d2a_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
    }
}