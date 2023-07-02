using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xFAE70F72)]
    class ufae70f72_obj : CatalogueObject
    {
        public ufae70f72_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ufae70f72_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ufae70f72_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7245E185)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7B866981)][ProtoMember(0x03)] public uint field_3;
    }
}