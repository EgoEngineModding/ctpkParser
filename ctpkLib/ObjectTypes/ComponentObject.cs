using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0x9827A18B)]
    class ComponentObject : CatalogueObject
    {
        public ComponentObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<ComponentObjectMap>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class ComponentObjectMap : ObjMap
    {
        [ProtoMember(1)] public uint Id;
        [MappedString][ProtoMember(2)] public uint str1;
        [ProtoMember(3)] public uint unk1;
        [MappedString][ProtoMember(4)] public uint str2;
        [ProtoMember(5)] public uint unk2;
        //[ProtoMember(10)] public uint ;
    }
}
