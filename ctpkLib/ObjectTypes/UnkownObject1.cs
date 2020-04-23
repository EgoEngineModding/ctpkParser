using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0xF500D10A)]
    class UnkownObject1 : CatalogueObject
    {
        public UnkownObject1(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<UnkownObject1Map>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE */
    [ProtoContract]
    public class UnkownObject1Map : ObjMap
    {
        [ProtoMember(1)] public long Id;
        [ProtoMember(2)] public ulong unkObj;
        [ProtoMember(3)] public ulong unkString;
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
