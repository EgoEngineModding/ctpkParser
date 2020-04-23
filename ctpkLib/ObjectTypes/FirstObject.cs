using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0x1F639765)]
    class FirstObject : CatalogueObject
    {
        public FirstObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<FirstObjectMap>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE */
    [ProtoContract]
    public class FirstObjectMap : ObjMap
    {
        [ProtoMember(1)] public int Id;
        [MappedString] [ProtoMember(2)] public uint str1;
        [MappedString] [ProtoMember(3)] public uint str2;
        [MappedString] [ProtoMember(4)] public uint str3;
        //[ProtoMember(5)] public uint 
        //[ProtoMember(6)] public uint ;
        //[ProtoMember(7)] public uint ;
        //[ProtoMember(8)] public uint ;
        //[ProtoMember(9)] public uint ;
        //[ProtoMember(10)] public uint ;
    }
}
