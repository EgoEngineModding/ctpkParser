using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEB75CA23)]
    class ueb75ca23_obj : CatalogueObject
    {
        public ueb75ca23_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ueb75ca23_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ueb75ca23_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x6F09B14D)][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}