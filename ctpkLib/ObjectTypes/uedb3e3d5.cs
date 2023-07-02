using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEDB3E3D5)]
    class uedb3e3d5_obj : CatalogueObject
    {
        public uedb3e3d5_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uedb3e3d5_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uedb3e3d5_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
    }
}