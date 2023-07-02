using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x5507FFD7)]
    class location_conditions_obj : CatalogueObject
    {
        public location_conditions_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<location_conditions_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class location_conditions_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7604D91E)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x0B779432)][ProtoMember(0x06)] public uint field_6;
        [ProtoMember(0x07)] public int field_7;
        [ProtoMember(0x08)] public int field_8;
    }
}