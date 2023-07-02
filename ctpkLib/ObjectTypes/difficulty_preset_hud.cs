using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA50C838A)]
    class difficulty_preset_hud_obj : CatalogueObject
    {
        public difficulty_preset_hud_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<difficulty_preset_hud_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class difficulty_preset_hud_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public bool field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}