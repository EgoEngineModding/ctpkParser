using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x60A97D64)]
    class u60a97d64_obj : CatalogueObject
    {
        public u60a97d64_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u60a97d64_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u60a97d64_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}