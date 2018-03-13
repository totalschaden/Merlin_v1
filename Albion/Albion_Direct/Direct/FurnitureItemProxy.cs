////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.357.113485-prod
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
    /* Internal type: aw9 */
    public partial class FurnitureItemProxy : DurableItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aw9 _internal;
        
        #region Properties
        
        public aw9 FurnitureItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public FurnitureItemProxy(aw9 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FurnitureItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aw9(FurnitureItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FurnitureItemProxy(aw9 instance)
        {
            return new FurnitureItemProxy(instance);
        }
        
        public static implicit operator bool(FurnitureItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
