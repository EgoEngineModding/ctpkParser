using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace ctpkLib.ObjectTypes
{
    [Section(0xE5117269)]
    public class LocaleMapObj : CatalogueObject
    {
        public LocaleMapObj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<LocaleMap>(new MemoryStream(Data));
        }

    }

    [ProtoContract]
    public class LocaleMap : ObjMap
    {
        [ProtoMember(1)] public int Id;
        [ProtoMember(2)] public uint ObjRef;
        [MappedString][ProtoMember(3)] public uint Str1;
        [MappedString][ProtoMember(4)] public uint Str2;
    }
}
