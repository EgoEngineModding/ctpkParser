using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3D7AE65F)]
    class u3d7ae65f_obj : CatalogueObject
    {
        public u3d7ae65f_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u3d7ae65f_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u3d7ae65f_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xD1946D7C)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [ProtoMember(0x05)] public float field_5;
        [MappedString][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x08)] public float field_8;
    }
}