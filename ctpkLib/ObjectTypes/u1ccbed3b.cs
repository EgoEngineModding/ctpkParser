using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1CCBED3B)]
    class u1ccbed3b_obj : CatalogueObject
    {
        public u1ccbed3b_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u1ccbed3b_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u1ccbed3b_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x03)] public uint field_3;
    }
}