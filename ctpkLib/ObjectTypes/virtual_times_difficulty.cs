using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8F94757F)]
    class virtual_times_difficulty_obj : CatalogueObject
    {
        public virtual_times_difficulty_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<virtual_times_difficulty_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class virtual_times_difficulty_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
    }
}