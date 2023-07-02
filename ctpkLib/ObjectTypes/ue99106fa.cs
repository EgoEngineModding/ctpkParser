using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE99106FA)]
    class ue99106fa_obj : CatalogueObject
    {
        public ue99106fa_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ue99106fa_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ue99106fa_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}