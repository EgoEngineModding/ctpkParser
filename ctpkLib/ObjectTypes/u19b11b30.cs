using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x19B11B30)]
    class u19b11b30_obj : CatalogueObject
    {
        public u19b11b30_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u19b11b30_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u19b11b30_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public bool field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}