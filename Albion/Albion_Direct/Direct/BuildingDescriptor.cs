////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.11.357.115208-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Albion_Direct
{
    /* Internal type: cq */
    public partial class BuildingDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private cq _internal;
        
        #region Properties
        
        public cq BuildingDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public BuildingDescriptor(cq instance)
        {
            _internal = instance;
        }
        
        static BuildingDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator cq(BuildingDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator BuildingDescriptor(cq instance)
        {
            return new BuildingDescriptor(instance);
        }
        
        public static implicit operator bool(BuildingDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
