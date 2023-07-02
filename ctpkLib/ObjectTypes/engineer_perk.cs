using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC9BC8283)]
    class engineer_perk_obj : CatalogueObject
    {
        public engineer_perk_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<engineer_perk_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class engineer_perk_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xBD1FD432)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7C9C36B7)][ProtoMember(0x03)] public uint field_3;
    }
}