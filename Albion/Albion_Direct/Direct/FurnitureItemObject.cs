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
    /* Internal type: ax6 */
    public partial class FurnitureItemObject : DurableItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private ax6 _internal;
        
        #region Properties
        
        public ax6 FurnitureItemObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureItemObject(ax6 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ax6(FurnitureItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureItemObject(ax6 instance)
        {
            return new FurnitureItemObject(instance);
        }
        
        public static implicit operator bool(FurnitureItemObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
