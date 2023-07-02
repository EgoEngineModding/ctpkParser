using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x90655DB8)]
    class u90655db8_obj : CatalogueObject
    {
        public u90655db8_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u90655db8_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u90655db8_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public float field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}