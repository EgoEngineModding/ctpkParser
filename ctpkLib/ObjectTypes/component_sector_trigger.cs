using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xAC7C70DA)]
    class component_sector_trigger_obj : CatalogueObject
    {
        public component_sector_trigger_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<component_sector_trigger_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class component_sector_trigger_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
    }
}