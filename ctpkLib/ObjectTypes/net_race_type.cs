using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE17685C7)]
    class net_race_type_obj : CatalogueObject
    {
        public net_race_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<net_race_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class net_race_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x0DCFD1E1)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x19)] public uint field_19;
    }
}