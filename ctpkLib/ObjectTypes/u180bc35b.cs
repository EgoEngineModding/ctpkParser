using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x180BC35B)]
    class u180bc35b_obj : CatalogueObject
    {
        public u180bc35b_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u180bc35b_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u180bc35b_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}