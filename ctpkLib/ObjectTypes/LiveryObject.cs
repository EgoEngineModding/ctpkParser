using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0xC16A87DF)]
    class LiveryObject : CatalogueObject
    {
        public LiveryObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<LiveryObjectMap>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE */
    [ProtoContract]
    public class LiveryObjectMap : ObjMap
    {
        [ProtoMember(1)] public int Id;
        //[ProtoMember(2)] public uint obj1;
        [MappedObject(typeof(VehicleObject))][ProtoMember(3)] public uint Vehicle;
        [MappedString] [ProtoMember(4)] public uint LiveryId;
        [MappedString] [ProtoMember(5)] public uint LiverySlot;
        [MappedString] [ProtoMember(0x24)] public uint s3;
        //[MappedString] [ProtoMember(0xE)] public uint str1;
        //[MappedString] [ProtoMember(0xF)] public uint str2;
        //[MappedString] [ProtoMember(0x10)] public uint str3;
        //[MappedString] [ProtoMember(0x2C)] public uint str5;
        //[MappedString] [ProtoMember(0x3A)] public uint str6;
        //[MappedString] [ProtoMember(0x4F)] public uint str7;
        //[MappedString] [ProtoMember(0x55)] public uint str8;
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
