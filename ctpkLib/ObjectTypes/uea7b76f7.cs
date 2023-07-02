using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEA7B76F7)]
    class uea7b76f7_obj : CatalogueObject
    {
        public uea7b76f7_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uea7b76f7_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uea7b76f7_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xC100FAB6)][ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x7CA1DC81)][ProtoMember(0x06)] public uint field_6;
    }
}