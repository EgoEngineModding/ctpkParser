using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x200D9D17)]
    class game_mode_track_obj : CatalogueObject
    {
        public game_mode_track_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<game_mode_track_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class game_mode_track_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0E3953A3)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x03)] public uint field_3;
    }
}