using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0xdc28de75)]
    class EntitlementObject : CatalogueObject
    {
        public EntitlementObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<EntitlementObjectMap>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE */
    [ProtoContract]
    public class EntitlementObjectMap : ObjMap
    {
        [ProtoMember(1)] public int Id;
        [MappedString] [ProtoMember(2)] public uint unkString;
        [ProtoMember(3)] public uint unkval;
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
