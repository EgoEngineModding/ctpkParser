using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF2AFA872)]
    class uf2afa872_obj : CatalogueObject
    {
        public uf2afa872_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uf2afa872_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uf2afa872_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}