using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xD04B2572)]
    class ud04b2572_obj : CatalogueObject
    {
        public ud04b2572_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ud04b2572_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ud04b2572_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xB8E12AAA)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0xB131BFCC)][ProtoMember(0x05)] public uint field_5;
        [MappedObject(0xB131BFCC)][ProtoMember(0x06)] public uint field_6;
    }
}