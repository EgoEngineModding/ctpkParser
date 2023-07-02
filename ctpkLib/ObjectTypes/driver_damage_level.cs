using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x422AD946)]
    class driver_damage_level_obj : CatalogueObject
    {
        public driver_damage_level_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<driver_damage_level_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class driver_damage_level_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}