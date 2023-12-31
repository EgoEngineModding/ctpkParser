﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctpkLib
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Section : Attribute
    {
        private UInt32 _id;
        public Section(UInt32 id) { _id = id; }
        public UInt32 Id { get { return _id; } }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MappedString : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class MappedObject : Attribute
    {
        private Type _objType;
        private UInt32 _sectionId;
        public MappedObject(Type objType)
        { 
            _objType = objType;
            _sectionId = _objType.GetCustomAttribute<Section>(false)?.Id ?? 0;
        }
        
        public MappedObject(UInt32 objTypeId)
        {
            _sectionId = objTypeId;
            //_objType = Assembly.GetExecutingAssembly()
            // .GetTypes()
            // .Where(t => t.IsSubclassOf(typeof(CatalogueObject)) &&
            //        t.GetCustomAttribute<Section>(false)?.Id == objTypeId)
            // .FirstOrDefault();
        }

        public Type GetObjType()
        {
            if (_objType != null)
                return _objType;

            _objType = Assembly.GetExecutingAssembly()
             .GetTypes()
             .Where(t => t.IsSubclassOf(typeof(CatalogueObject)) &&
                    t.GetCustomAttribute<Section>(false)?.Id == _sectionId)
             .FirstOrDefault();

            return _objType;
        }

        public Type GetObjType(CTPKLib lib)
        {
            if (_objType != null)
                return _objType;

            _objType = lib.Objects.getSectionType(SectionId);
            return _objType;
        }

        public UInt32 SectionId { get { return _sectionId; } }
        //public Type ObjType { get { return _objType; } }
    }
}
