using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF68AF2AD)]
    class result_type_restrictions_obj : CatalogueObject
    {
        public result_type_restrictions_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<result_type_restrictions_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class result_type_restrictions_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x744671E9)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x436F7BF8)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [MappedObject(0x0E3953A3)][ProtoMember(0x05)] public uint field_5;
    }
}