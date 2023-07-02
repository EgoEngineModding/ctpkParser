using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4E205D3B)]
    class event_news_location_obj : CatalogueObject
    {
        public event_news_location_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<event_news_location_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class event_news_location_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0xDE3FDF63)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x7604D91E)][ProtoMember(0x03)] public uint field_3;
    }
}