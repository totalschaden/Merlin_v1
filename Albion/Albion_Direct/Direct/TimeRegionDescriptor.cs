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
    /* Internal type: rf */
    public partial class TimeRegionDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private rf _internal;
        
        #region Properties
        
        public rf TimeRegionDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public TimeRegionDescriptor(rf instance)
        {
            _internal = instance;
        }
        
        static TimeRegionDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator rf(TimeRegionDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TimeRegionDescriptor(rf instance)
        {
            return new TimeRegionDescriptor(instance);
        }
        
        public static implicit operator bool(TimeRegionDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
