using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x6C8E7404)]
    class object_base_templates_obj : CatalogueObject
    {
        public object_base_templates_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<object_base_templates_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class object_base_templates_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x1153FD2A)][ProtoMember(0x03)] public uint field_3;
    }
}