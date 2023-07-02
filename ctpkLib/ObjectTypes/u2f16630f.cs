using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2F16630F)]
    class u2f16630f_obj : CatalogueObject
    {
        public u2f16630f_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u2f16630f_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u2f16630f_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xB2FD01AC)][ProtoMember(0x04)] public uint field_4;
    }
}