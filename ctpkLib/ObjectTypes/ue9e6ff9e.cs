using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE9E6FF9E)]
    class ue9e6ff9e_obj : CatalogueObject
    {
        public ue9e6ff9e_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ue9e6ff9e_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ue9e6ff9e_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x6F09B14D)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
    }
}