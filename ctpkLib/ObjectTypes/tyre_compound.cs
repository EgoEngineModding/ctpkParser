using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x81163CCD)]
    class tyre_compound_obj : CatalogueObject
    {
        public tyre_compound_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<tyre_compound_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class tyre_compound_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x9F9E384A)][ProtoMember(0x05)] public uint field_5;
        [ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public float field_7;
        [ProtoMember(0x08)] public float field_8;
        [ProtoMember(0x09)] public uint field_9;
    }
}