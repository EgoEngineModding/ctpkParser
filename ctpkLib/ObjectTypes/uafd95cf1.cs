using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xAFD95CF1)]
    class uafd95cf1_obj : CatalogueObject
    {
        public uafd95cf1_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uafd95cf1_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uafd95cf1_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public uint field_3;
    }
}