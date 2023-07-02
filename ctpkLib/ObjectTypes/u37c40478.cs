using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x37C40478)]
    class u37c40478_obj : CatalogueObject
    {
        public u37c40478_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u37c40478_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u37c40478_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}