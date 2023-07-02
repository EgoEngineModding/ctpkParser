using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xFFD7FE2A)]
    class uffd7fe2a_obj : CatalogueObject
    {
        public uffd7fe2a_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uffd7fe2a_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uffd7fe2a_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xFFE17AB3)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}