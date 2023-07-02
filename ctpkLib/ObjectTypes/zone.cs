using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7CA1DC81)]
    class zone_obj : CatalogueObject
    {
        public zone_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<zone_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class zone_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x6F09B14D)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public int field_4;
    }
}