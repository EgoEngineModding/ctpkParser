using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF183AD33)]
    class uf183ad33_obj : CatalogueObject
    {
        public uf183ad33_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<uf183ad33_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class uf183ad33_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7604D91E)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x0B779432)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x0B779432)][ProtoMember(0x05)] public uint field_5;
    }
}