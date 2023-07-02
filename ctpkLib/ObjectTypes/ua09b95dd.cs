using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xA09B95DD)]
    class ua09b95dd_obj : CatalogueObject
    {
        public ua09b95dd_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ua09b95dd_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ua09b95dd_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x5AF71738)][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x37C40478)][ProtoMember(0x04)] public uint field_4;
    }
}