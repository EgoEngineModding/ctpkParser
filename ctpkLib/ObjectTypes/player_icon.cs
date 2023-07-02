using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x364B2D5A)]
    class player_icon_obj : CatalogueObject
    {
        public player_icon_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<player_icon_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class player_icon_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x03)] public uint field_3;
    }
}