using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x883F8F09)]
    class u883f8f09_obj : CatalogueObject
    {
        public u883f8f09_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u883f8f09_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u883f8f09_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xDE3FDF63)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x3548220A)][ProtoMember(0x03)] public uint field_3;
    }
}