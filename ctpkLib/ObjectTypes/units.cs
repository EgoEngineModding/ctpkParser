using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x108252D8)]
    class units_obj : CatalogueObject
    {
        public units_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<units_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class units_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}