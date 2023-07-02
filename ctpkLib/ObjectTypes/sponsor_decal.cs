using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xFFA84151)]
    class sponsor_decal_obj : CatalogueObject
    {
        public sponsor_decal_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<sponsor_decal_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class sponsor_decal_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public bool field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0xA5819819)][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x08)] public bool field_8;
        [ProtoMember(0x09)] public uint field_9;
        [ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public uint field_c;
        [ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x1D)] public bool field_1d;
        [ProtoMember(0x24)] public bool field_24;
        [MappedString][ProtoMember(0x25)] public uint field_25;
    }
}