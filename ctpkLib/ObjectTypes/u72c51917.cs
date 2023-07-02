using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x72C51917)]
    class u72c51917_obj : CatalogueObject
    {
        public u72c51917_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u72c51917_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u72c51917_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x6F09B14D)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
        [MappedString][ProtoMember(0x04)] public uint field_4;
    }
}