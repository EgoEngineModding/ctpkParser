using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF5730F65)]
    class uf5730f65_obj : CatalogueObject
    {
        public uf5730f65_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uf5730f65_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uf5730f65_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public float field_3;
    }
}