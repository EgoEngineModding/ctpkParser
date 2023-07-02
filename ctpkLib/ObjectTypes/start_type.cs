using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB0C02B14)]
    class start_type_obj : CatalogueObject
    {
        public start_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<start_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class start_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public bool field_3;
        [ProtoMember(0x04)] public bool field_4;
    }
}