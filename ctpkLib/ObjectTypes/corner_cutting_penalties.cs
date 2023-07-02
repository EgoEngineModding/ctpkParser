using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD6EEE98F)]
    class corner_cutting_penalties_obj : CatalogueObject
    {
        public corner_cutting_penalties_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<corner_cutting_penalties_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class corner_cutting_penalties_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [MappedObject(0x155A543A)][ProtoMember(0x07)] public uint field_7;
    }
}