using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1E09C62C)]
    class u1e09c62c_obj : CatalogueObject
    {
        public u1e09c62c_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u1e09c62c_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u1e09c62c_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x3D7AE65F)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}