using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1B7B18AE)]
    class SeasonObj : CatalogueObject
    {
        public SeasonObj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<SeasonObjMap>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class SeasonObjMap : ObjMap
    {
        [ProtoMember(1)] public uint Id;
        [ProtoMember(2)] public uint unk1;
        [MappedString][ProtoMember(3)] public uint str1;
        [ProtoMember(4)] public uint unk3;
        [ProtoMember(6)] public uint unk4;
        [ProtoMember(7)] public uint unk5;
        [ProtoMember(9)] public uint unk6;
        [MappedString][ProtoMember(0xC)] public uint str2;
    }
}
