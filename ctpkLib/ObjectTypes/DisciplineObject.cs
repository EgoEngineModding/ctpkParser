using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x744671E9)]
    class DisciplineObject : CatalogueObject
    {
        public DisciplineObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<DisciplineObjectMap>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE */
    [ProtoContract]
    public class DisciplineObjectMap : ObjMap
    {
        [ProtoMember(1)] public long Id;
        [MappedString][ProtoMember(2)] public uint unk1;
        [MappedString][ProtoMember(3)] public uint unk2;
        [ProtoMember(4)] public uint unk3;
        [MappedString][ProtoMember(5)] public uint unk4;
        [ProtoMember(6)] public uint unk5;
        [ProtoMember(7)] public uint unk6;
        [ProtoMember(8)] public uint unk7;
        [ProtoMember(9)] public uint unk8;
    }
}