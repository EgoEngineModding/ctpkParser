using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB2FD01AC)]
    class ub2fd01ac_obj : CatalogueObject
    {
        public ub2fd01ac_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ub2fd01ac_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ub2fd01ac_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}