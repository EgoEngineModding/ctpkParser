using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB647903F)]
    class ub647903f_obj : CatalogueObject
    {
        public ub647903f_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ub647903f_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ub647903f_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}