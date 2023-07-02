using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x2162F04E)]
    class career_championship_class_obj : CatalogueObject
    {
        public career_championship_class_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<career_championship_class_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class career_championship_class_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x7D9D4F19)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x2442A3BA)][ProtoMember(0x03)] public uint field_3;
        [ProtoMember(0x04)] public uint field_4;
        [ProtoMember(0x05)] public uint field_5;
    }
}