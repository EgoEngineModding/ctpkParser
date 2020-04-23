using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x7245E185)]
    class VehicleObject : CatalogueObject
    {
        public VehicleObject(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<VehicleObjectMap>(new MemoryStream(Data));
        }
    }

    /* INCOMPLETE 
    [ProtoContract]
    public class VehicleObjectMap : ObjMap
    {
        [ProtoMember(1)] public int Id;
        [MappedObject(0xDCFD1E1)][ProtoMember(2)] public uint RaceType;
        [MappedObject(0x24F948D5)][ProtoMember(3)] public uint VehicleModel;
        [MappedObject(0xF68328FF)][ProtoMember(4)] public uint obj3;
        [MappedString] [ProtoMember(5)] public uint carId;
        [MappedString] [ProtoMember(0xD)] public uint type;
        [MappedString] [ProtoMember(0xE)] public uint str1;
        [MappedString] [ProtoMember(0xF)] public uint str2;
        [MappedString] [ProtoMember(0x10)] public uint str3;
        [MappedString] [ProtoMember(0x2C)] public uint str5;
        [MappedString] [ProtoMember(0x3A)] public uint str6;
        [MappedString] [ProtoMember(0x4F)] public uint str7;
        [MappedString] [ProtoMember(0x55)] public uint str8;
        //[ProtoMember(3)] public uint ;
        //[ProtoMember(4)] public uint ;
        //[ProtoMember(5)] public uint 
        //[ProtoMember(6)] public uint ;
        //[ProtoMember(7)] public uint ;
        //[ProtoMember(8)] public uint ;
        //[ProtoMember(9)] public uint ;
        //[ProtoMember(10)] public uint ;
    } */

    [ProtoContract]
    public class VehicleObjectMap : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x0DCFD1E1)] [ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x24F948D5)] [ProtoMember(0x03)] public uint field_3;
        [MappedObject(0xF68328FF)] [ProtoMember(0x04)] public uint field_4;
        [MappedString] [ProtoMember(0x05)] public uint field_5;
        [MappedObject(0x2442A3BA)] [ProtoMember(0x0B)] public uint field_b;
        [MappedObject(0x7D9F2630)] [ProtoMember(0x0C)] public uint field_c;
        [MappedString] [ProtoMember(0x0D)] public uint field_d;
        [MappedString] [ProtoMember(0x0E)] public uint field_e;
        [MappedString] [ProtoMember(0x0F)] public uint field_f;
        [MappedString] [ProtoMember(0x10)] public uint field_10;
        [ProtoMember(0x11)] public uint field_11;
        [ProtoMember(0x12)] public uint field_12;
        [ProtoMember(0x13)] public uint field_13;
        [ProtoMember(0x14)] public uint field_14;
        [ProtoMember(0x15)] public uint field_15;
        [ProtoMember(0x18)] public uint field_18;
        [ProtoMember(0x19)] public uint field_19;
        [ProtoMember(0x1A)] public uint field_1a;
        [ProtoMember(0x1D)] public bool field_1d;
        [ProtoMember(0x1E)] public bool field_1e;
        [ProtoMember(0x24)] public uint field_24;
        [ProtoMember(0x25)] public uint field_25;
        [ProtoMember(0x26)] public uint field_26;
        [MappedString] [ProtoMember(0x2C)] public uint field_2c;
        [ProtoMember(0x2D)] public bool field_2d;
        [ProtoMember(0x2E)] public bool field_2e;
        [ProtoMember(0x31)] public bool field_31;
        [ProtoMember(0x34)] public uint field_34;
        [ProtoMember(0x35)] public uint field_35;
        [ProtoMember(0x37)] public uint field_37;
        [ProtoMember(0x39)] public uint field_39;
        [MappedString] [ProtoMember(0x3A)] public uint field_3a;
        [ProtoMember(0x43)] public uint field_43;
        [ProtoMember(0x44)] public bool field_44;
        [ProtoMember(0x45)] public bool field_45;
        [MappedObject(0xF68328FF)] [ProtoMember(0x4A)] public uint field_4a;
        [MappedObject(0xA52DC1AF)] [ProtoMember(0x4B)] public uint field_4b;
        [MappedObject(0xFAE1141F)] [ProtoMember(0x4C)] public uint field_4c;
        [MappedString] [ProtoMember(0x4F)] public uint field_4f;
        [ProtoMember(0x50)] public bool field_50;
        [ProtoMember(0x51)] public bool field_51;
        [MappedObject(0x0084B2BF)] [ProtoMember(0x52)] public uint field_52;
        [ProtoMember(0x53)] public bool field_53;
        [ProtoMember(0x54)] public bool field_54;
        [MappedString] [ProtoMember(0x55)] public uint field_55;
        [ProtoMember(0x56)] public uint field_56;
        [ProtoMember(0x57)] public uint field_57;
        [ProtoMember(0x58)] public uint field_58;
        [ProtoMember(0x59)] public uint field_59;
        [ProtoMember(0x5A)] public uint field_5a;
        [MappedObject(0x10B1563C)] [ProtoMember(0x5B)] public uint field_5b;
        [ProtoMember(0x5D)] public uint field_5d;
        [ProtoMember(0x5E)] public uint field_5e;
        [ProtoMember(0x5F)] public bool field_5f;
    }
}
