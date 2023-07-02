using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xDF94DB26)]
    class udf94db26_obj : CatalogueObject
    {
        public udf94db26_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<udf94db26_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class udf94db26_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xE18B738A)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x744671E9)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public float field_4;
    }
}