using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF339BE46)]
    class uf339be46_obj : CatalogueObject
    {
        public uf339be46_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uf339be46_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uf339be46_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
    }
}