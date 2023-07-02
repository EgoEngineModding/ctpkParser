using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x304D7F5A)]
    class handling_model_obj : CatalogueObject
    {
        public handling_model_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<handling_model_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class handling_model_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}