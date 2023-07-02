using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x9C40983F)]
    class lesson_triggers_obj : CatalogueObject
    {
        public lesson_triggers_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<lesson_triggers_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class lesson_triggers_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0B30DB19)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public float field_4;
        [MappedObject(0x304D7F5A)][ProtoMember(0x05)] public uint field_5;
    }
}