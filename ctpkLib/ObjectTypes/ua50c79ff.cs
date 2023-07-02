using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA50C79FF)]
    class ua50c79ff_obj : CatalogueObject
    {
        public ua50c79ff_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ua50c79ff_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ua50c79ff_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public bool field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}