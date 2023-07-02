using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC3C8EA22)]
    class force_start_type_obj : CatalogueObject
    {
        public force_start_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<force_start_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class force_start_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0DCFD1E1)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xB0C02B14)][ProtoMember(0x03)] public uint field_3;
    }
}