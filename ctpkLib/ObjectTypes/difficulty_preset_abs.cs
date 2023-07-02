using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA50C635F)]
    class difficulty_preset_abs_obj : CatalogueObject
    {
        public difficulty_preset_abs_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<difficulty_preset_abs_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class difficulty_preset_abs_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public float field_5;
    }
}