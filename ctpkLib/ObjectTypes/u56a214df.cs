using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x56A214DF)]
    class u56a214df_obj : CatalogueObject
    {
        public u56a214df_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u56a214df_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u56a214df_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
        [MappedString][ProtoMember(0x03)] public uint field_3;
        [MappedObject(0x601782C2)][ProtoMember(0x04)] public uint field_4;
    }
}