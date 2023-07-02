using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE9520A32)]
    class ue9520a32_obj : CatalogueObject
    {
        public ue9520a32_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ue9520a32_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ue9520a32_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xF96D6451)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD3F53B19)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
    }
}