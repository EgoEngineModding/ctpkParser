using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x83A65708)]
    class u83a65708_obj : CatalogueObject
    {
        public u83a65708_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u83a65708_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u83a65708_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xC09C7101)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x4F12F227)][ProtoMember(0x03)] public uint field_3;
    }
}