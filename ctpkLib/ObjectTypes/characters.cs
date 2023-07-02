using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xCE37D645)]
    class characters_obj : CatalogueObject
    {
        public characters_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<characters_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class characters_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x06)] public bool field_6;
        [MappedObject(0x35EB3433)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public bool field_8;
        [MappedString][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public int field_b;
    }
}