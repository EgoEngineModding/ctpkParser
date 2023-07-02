using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3F5C5B41)]
    class u3f5c5b41_obj : CatalogueObject
    {
        public u3f5c5b41_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u3f5c5b41_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u3f5c5b41_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x2442A3BA)][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
    }
}