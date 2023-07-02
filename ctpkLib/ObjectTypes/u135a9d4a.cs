using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x135A9D4A)]
    class u135a9d4a_obj : CatalogueObject
    {
        public u135a9d4a_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u135a9d4a_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u135a9d4a_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xE18B738A)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x5AF71738)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
    }
}