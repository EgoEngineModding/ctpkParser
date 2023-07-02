using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x41422076)]
    class ai_choreographer_mistake_mods_obj : CatalogueObject
    {
        public ai_choreographer_mistake_mods_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ai_choreographer_mistake_mods_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ai_choreographer_mistake_mods_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [ProtoMember(0x06)] public float field_6;
    }
}