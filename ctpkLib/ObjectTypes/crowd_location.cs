using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4ECC6C1C)]
    class crowd_location_obj : CatalogueObject
    {
        public crowd_location_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<crowd_location_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class crowd_location_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7604D91E)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x69F9460B)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xCE488105)][ProtoMember(0x05)] public uint field_5;
    }
}