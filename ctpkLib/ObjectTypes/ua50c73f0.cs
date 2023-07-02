using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA50C73F0)]
    class ua50c73f0_obj : CatalogueObject
    {
        public ua50c73f0_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ua50c73f0_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ua50c73f0_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public bool field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}