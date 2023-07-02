using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x5A983042)]
    class u5a983042_obj : CatalogueObject
    {
        public u5a983042_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u5a983042_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u5a983042_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xDE3FDF63)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x200FA625)][ProtoMember(0x03)] public uint field_3;
    }
}