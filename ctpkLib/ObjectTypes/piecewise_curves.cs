using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2011D9BA)]
    class piecewise_curves_obj : CatalogueObject
    {
        public piecewise_curves_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<piecewise_curves_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class piecewise_curves_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x1E09C62C)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x1E09C62C)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x1E09C62C)][ProtoMember(0x04)] public uint field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x1E09C62C)][ProtoMember(0x06)] public uint field_6;
        [MappedObject(0x1E09C62C)][ProtoMember(0x07)] public uint field_7;
    }
}