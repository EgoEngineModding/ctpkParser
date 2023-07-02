using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x89E3D9BA)]
    class u89e3d9ba_obj : CatalogueObject
    {
        public u89e3d9ba_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u89e3d9ba_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u89e3d9ba_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x180BC35B)][ProtoMember(0x05)] public uint field_5;
    }
}