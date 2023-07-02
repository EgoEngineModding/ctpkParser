using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x01C2F3DE)]
    class u01c2f3de_obj : CatalogueObject
    {
        public u01c2f3de_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u01c2f3de_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u01c2f3de_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xDE3FDF63)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x01420DF3)][ProtoMember(0x03)] public uint field_3;
    }
}