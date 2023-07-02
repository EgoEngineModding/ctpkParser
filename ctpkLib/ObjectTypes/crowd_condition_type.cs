using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x69F9460B)]
    class crowd_condition_type_obj : CatalogueObject
    {
        public crowd_condition_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<crowd_condition_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class crowd_condition_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}