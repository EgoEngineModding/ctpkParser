using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8CA35408)]
    class lesson_layers_obj : CatalogueObject
    {
        public lesson_layers_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<lesson_layers_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class lesson_layers_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0B30DB19)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
    }
}