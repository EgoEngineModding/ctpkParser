using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x58C67C7E)]
    class u58c67c7e_obj : CatalogueObject
    {
        public u58c67c7e_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u58c67c7e_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u58c67c7e_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}