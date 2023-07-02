using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2A87DA28)]
    class u2a87da28_obj : CatalogueObject
    {
        public u2a87da28_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u2a87da28_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u2a87da28_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x3F9C0E92)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x6F09B14D)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
    }
}