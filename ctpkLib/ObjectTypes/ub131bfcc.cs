using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xB131BFCC)]
    class ub131bfcc_obj : CatalogueObject
    {
        public ub131bfcc_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ub131bfcc_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ub131bfcc_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x200FA625)][ProtoMember(0x09)] public uint field_9;
        [MappedObject(0x58C67C7E)][ProtoMember(0x0A)] public uint field_a;
        [ProtoMember(0x0B)] public uint field_b;
        [ProtoMember(0x0C)] public bool field_c;
        [ProtoMember(0x0D)] public int field_d;
    }
}