using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x768B4B7C)]
    class u768b4b7c_obj : CatalogueObject
    {
        public u768b4b7c_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u768b4b7c_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u768b4b7c_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xC09C7101)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xC09C7101)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xC09C7101)][ProtoMember(0x06)] public uint field_6;
        [MappedString][ProtoMember(0x07)] public uint field_7;
        [ProtoMember(0x09)] public bool field_9;
    }
}