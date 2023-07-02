using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x24F948D5)]
    class vehicle_model_obj : CatalogueObject
    {
        public vehicle_model_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_model_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_model_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xEE3BF852)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0C)] public bool field_c;
    }
}