using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8D56DCE9)]
    class reset_type_obj : CatalogueObject
    {
        public reset_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<reset_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class reset_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}