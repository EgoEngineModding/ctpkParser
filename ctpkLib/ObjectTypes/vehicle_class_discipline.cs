using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF848713D)]
    class vehicle_class_discipline_obj : CatalogueObject
    {
        public vehicle_class_discipline_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_class_discipline_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_class_discipline_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x2442A3BA)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xD0A4E79A)][ProtoMember(0x05)] public uint field_5;
    }
}