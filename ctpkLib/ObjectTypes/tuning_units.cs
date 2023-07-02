using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x60F1F18C)]
    class tuning_units_obj : CatalogueObject
    {
        public tuning_units_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<tuning_units_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class tuning_units_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}