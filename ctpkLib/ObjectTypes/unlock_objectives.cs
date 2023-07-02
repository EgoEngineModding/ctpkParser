using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x8512E77E)]
    class unlock_objectives_obj : CatalogueObject
    {
        public unlock_objectives_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<unlock_objectives_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class unlock_objectives_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
    }
}