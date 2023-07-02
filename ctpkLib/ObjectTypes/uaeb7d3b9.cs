using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xAEB7D3B9)]
    class uaeb7d3b9_obj : CatalogueObject
    {
        public uaeb7d3b9_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uaeb7d3b9_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uaeb7d3b9_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x04)] public bool field_4;
        [ProtoMember(0x05)] public int field_5;
        [MappedObject(0x1072479A)][ProtoMember(0x09)] public uint field_9;
        [MappedString][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public bool field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public bool field_d;
    }
}