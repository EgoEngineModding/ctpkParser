using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2DDC4494)]
    class driver_default_vehicle_obj : CatalogueObject
    {
        public driver_default_vehicle_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<driver_default_vehicle_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class driver_default_vehicle_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xF96D6451)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x2442A3BA)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xC16A87DF)][ProtoMember(0x04)] public uint field_4;
    }
}