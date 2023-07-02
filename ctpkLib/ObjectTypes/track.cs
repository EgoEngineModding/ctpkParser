using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1072479A)]
    class track_obj : CatalogueObject
    {
        public track_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<track_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class track_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xD8D448D1)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public float field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0B)] public uint field_b;
    }
}