using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7695BA8B)]
    class u7695ba8b_obj : CatalogueObject
    {
        public u7695ba8b_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u7695ba8b_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u7695ba8b_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}