using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x26B09DF8)]
    class u26b09df8_obj : CatalogueObject
    {
        public u26b09df8_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u26b09df8_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u26b09df8_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xCBF59178)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xE6A5B53C)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x08)] public int field_8;
    }
}