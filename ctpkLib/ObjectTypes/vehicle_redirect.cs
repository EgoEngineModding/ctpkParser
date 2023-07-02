using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF21944B6)]
    class vehicle_redirect_obj : CatalogueObject
    {
        public vehicle_redirect_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<vehicle_redirect_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class vehicle_redirect_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7245E185)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7245E185)][ProtoMember(0x03)] public uint field_3;
    }
}