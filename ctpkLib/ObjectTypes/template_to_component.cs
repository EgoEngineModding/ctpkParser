using ProtoBuf;
using System;
using System.IO;

namespace ctpkLib.ObjectTypes
{
    [Section(0x527BB855)]
    class template_to_component_obj : CatalogueObject
    {
        public template_to_component_obj(CTPKLib lib, UInt32 sectionId, BinaryReader r) : base(lib, sectionId, r)
        {
            _map = Serializer.Deserialize<template_to_component_obj_map>(new MemoryStream(Data));
        }
    }

    [ProtoContract]
    public class template_to_component_obj_map : ObjMap
    {
        [ProtoMember(0x01)] public uint field_1;
        [MappedObject(0x1153FD2A)][ProtoMember(0x02)] public uint field_2;
        [MappedObject(0x9827A18B)][ProtoMember(0x03)] public uint field_3;
    }
}