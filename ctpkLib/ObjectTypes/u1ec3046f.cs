using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1EC3046F)]
    class u1ec3046f_obj : CatalogueObject
    {
        public u1ec3046f_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u1ec3046f_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u1ec3046f_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}