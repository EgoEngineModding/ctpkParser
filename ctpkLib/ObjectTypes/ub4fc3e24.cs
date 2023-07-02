using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB4FC3E24)]
    class ub4fc3e24_obj : CatalogueObject
    {
        public ub4fc3e24_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ub4fc3e24_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ub4fc3e24_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x2442A3BA)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7604D91E)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
        [MappedObject(0x7245E185)][ProtoMember(0x06)] public uint field_6;
    }
}