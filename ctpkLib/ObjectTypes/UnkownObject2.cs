using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0x4B802B77)]
    class UnkownObject2 : CatalogueObject
    {
        public UnkownObject2(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<UnkownObject2Map>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE */
    [ProtoContract]
    public class UnkownObject2Map : ObjMap
    {
        [ProtoMember(1)] public int Id;
        [MappedString][ProtoMember(2)] public uint s1;
        [MappedString][ProtoMember(3)] public uint s2;
        //[ProtoMember(3)] public uint ;
        //[ProtoMember(4)] public uint ;
        //[ProtoMember(5)] public uint 
        //[ProtoMember(6)] public uint ;
        //[ProtoMember(7)] public uint ;
        //[ProtoMember(8)] public uint ;
        //[ProtoMember(9)] public uint ;
        //[ProtoMember(10)] public uint ;
    }
}
