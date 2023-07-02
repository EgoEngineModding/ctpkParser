using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC2E3252C)]
    class finish_condition_obj : CatalogueObject
    {
        public finish_condition_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<finish_condition_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class finish_condition_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}