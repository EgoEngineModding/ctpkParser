using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x155A543A)]
    class u155a543a_obj : CatalogueObject
    {
        public u155a543a_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u155a543a_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u155a543a_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
    }
}