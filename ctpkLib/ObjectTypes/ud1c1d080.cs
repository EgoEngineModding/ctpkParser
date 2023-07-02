using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD1C1D080)]
    class ud1c1d080_obj : CatalogueObject
    {
        public ud1c1d080_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ud1c1d080_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ud1c1d080_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x59B7D589)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xD0A4E79A)][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public uint field_7;
    }
}