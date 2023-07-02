using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4A074A17)]
    class u4a074a17_obj : CatalogueObject
    {
        public u4a074a17_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u4a074a17_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u4a074a17_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7245E185)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public float field_5;
        [MappedObject(0x2442A3BA)][ProtoMember(0x09)] public uint field_9;
    }
}