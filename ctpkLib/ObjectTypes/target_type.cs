using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x439D064D)]
    class target_type_obj : CatalogueObject
    {
        public target_type_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<target_type_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class target_type_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x24F83522)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public float field_9;
    }
}