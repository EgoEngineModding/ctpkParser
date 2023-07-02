using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7759A73B)]
    class vehicle_upgrade_milestone_obj : CatalogueObject
    {
        public vehicle_upgrade_milestone_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_upgrade_milestone_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_upgrade_milestone_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0D385F9F)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public float field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}