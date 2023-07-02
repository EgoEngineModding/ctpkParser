using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x071FBECC)]
    class joyride_challenge_layers_obj : CatalogueObject
    {
        public joyride_challenge_layers_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<joyride_challenge_layers_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class joyride_challenge_layers_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x1FDD9A5D)][ProtoMember(0x02)] public uint field_2;
        [ProtoMember(0x03)] public int field_3;
    }
}