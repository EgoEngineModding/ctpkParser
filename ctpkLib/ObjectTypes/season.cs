using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1B7B18AE)]
    class season_obj : CatalogueObject
    {
        public season_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<season_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class season_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x06)] public bool field_6;
        [ProtoMember(0x07)] public bool field_7;
        [ProtoMember(0x09)] public int field_9;
        [MappedString][ProtoMember(0x0C)] public uint field_c;
    }
}