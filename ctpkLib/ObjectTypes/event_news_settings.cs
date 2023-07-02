using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0xEB206033)]
    class event_news_settings_obj : CatalogueObject
    {
        public event_news_settings_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<event_news_settings_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class event_news_settings_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public uint field_3;
    }
}