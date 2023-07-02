using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7B866981)]
    class u7b866981_obj : CatalogueObject
    {
        public u7b866981_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u7b866981_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u7b866981_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public bool field_3;
    }
}