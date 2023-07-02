using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC1537146)]
    class event_news_discipline_obj : CatalogueObject
    {
        public event_news_discipline_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<event_news_discipline_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class event_news_discipline_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xDE3FDF63)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x744671E9)][ProtoMember(0x03)] public uint field_3;
    }
}