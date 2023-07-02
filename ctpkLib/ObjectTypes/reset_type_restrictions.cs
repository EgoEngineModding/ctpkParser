using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x56BBD731)]
    class reset_type_restrictions_obj : CatalogueObject
    {
        public reset_type_restrictions_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<reset_type_restrictions_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class reset_type_restrictions_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x8D56DCE9)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x3FA0246C)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public bool field_5;
    }
}