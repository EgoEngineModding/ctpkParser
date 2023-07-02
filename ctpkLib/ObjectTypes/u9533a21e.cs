using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x9533A21E)]
    class u9533a21e_obj : CatalogueObject
    {
        public u9533a21e_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u9533a21e_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u9533a21e_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
    }
}