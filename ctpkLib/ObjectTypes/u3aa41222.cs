using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x3AA41222)]
    class u3aa41222_obj : CatalogueObject
    {
        public u3aa41222_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u3aa41222_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u3aa41222_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x5A55B573)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [ProtoMember(0x04)] public int field_4;
        [ProtoMember(0x05)] public int field_5;
        [ProtoMember(0x06)] public int field_6;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x08)] public int field_8;
    }
}