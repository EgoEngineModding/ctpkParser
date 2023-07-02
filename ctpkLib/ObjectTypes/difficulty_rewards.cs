using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF36D6B2F)]
    class difficulty_rewards_obj : CatalogueObject
    {
        public difficulty_rewards_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<difficulty_rewards_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class difficulty_rewards_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedString][ProtoMember(0x02)] public uint field_2;
    }
}