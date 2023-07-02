using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x001D9F59)]
    class u001d9f59_obj : CatalogueObject
    {
        public u001d9f59_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<u001d9f59_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class u001d9f59_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public int field_2;
        [ProtoMember(0x03)] public int field_3;
        [ProtoMember(0x04)] public int field_4;
        [MappedString][ProtoMember(0x05)] public uint field_5;
    }
}