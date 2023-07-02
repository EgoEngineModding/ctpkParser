using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x0B779432)]
    class stage_conditions_obj : CatalogueObject
    {
        public stage_conditions_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<stage_conditions_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class stage_conditions_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xB131BFCC)][ProtoMember(0x04)] public uint field_4;
        [MappedObject(0xC09C7101)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xA170B822)][ProtoMember(0x06)] public uint field_6;
    }
}