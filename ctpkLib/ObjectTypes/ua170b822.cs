using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA170B822)]
    class ua170b822_obj : CatalogueObject
    {
        public ua170b822_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ua170b822_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ua170b822_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}