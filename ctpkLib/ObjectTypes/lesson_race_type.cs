using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB7EB70D4)]
    class lesson_race_type_obj : CatalogueObject
    {
        public lesson_race_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<lesson_race_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class lesson_race_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0B30DB19)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x0DCFD1E1)][ProtoMember(0x03)] public uint field_3;
    }
}