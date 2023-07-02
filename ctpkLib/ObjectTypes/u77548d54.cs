using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x77548D54)]
    class u77548d54_obj : CatalogueObject
    {
        public u77548d54_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u77548d54_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u77548d54_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public int field_3;
        [MappedObject(0x9FAFE808)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0x2E05BF50)][ProtoMember(0x06)] public uint field_6;
    }
}