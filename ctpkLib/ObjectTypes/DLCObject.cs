using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib.ObjectTypes
{
    [Section(0x79B5C2C)] 
    class DLCObject : CatalogueObject
    {
        public DLCObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<DLCObjectMap>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class DLCObjectMap : ObjMap
    {
        [ProtoMember(1)] public int Id;
        [ProtoMember(8)] public uint u1;
        [MappedObject(typeof(VehicleObject))] [ProtoMember(9)] public uint Vehicle;
        [MappedObject(typeof(LiveryObject))] [ProtoMember(10)] public uint Livery;
        [MappedString] [ProtoMember(11)] public uint s1;
        [MappedString] [ProtoMember(12)] public uint s2;
        [ProtoMember(13)] public uint DLCId;
        [ProtoMember(14)] public uint u7;
        [MappedString] [ProtoMember(15)] public uint s3;
        //[ProtoMember(10)] public uint ;
    }
}
