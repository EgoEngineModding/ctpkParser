using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x836DA435)]
    class corner_cutting_time_penalty_obj : CatalogueObject
    {
        public corner_cutting_time_penalty_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<corner_cutting_time_penalty_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class corner_cutting_time_penalty_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public bool field_4;
    }
}