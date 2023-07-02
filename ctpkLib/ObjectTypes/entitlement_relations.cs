using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF3CFC2BE)]
    class entitlement_relations_obj : CatalogueObject
    {
        public entitlement_relations_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<entitlement_relations_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class entitlement_relations_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
    }
}