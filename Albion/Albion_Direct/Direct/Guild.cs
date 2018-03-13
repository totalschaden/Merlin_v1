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
    /* Internal type: awx */
    public partial class Guild
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private awx _internal;
        
        #region Properties
        
        public awx Guild_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public GuildMember[] GetMembers() => _internal.ap().Select(x =>(GuildMember)x).ToArray();
        
        #endregion
        
        #region Constructor
        
        public Guild(awx instance)
        {
            _internal = instance;
        }
        
        static Guild()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator awx(Guild instance)
        {
            return instance._internal;
        }
        
        public static implicit operator Guild(awx instance)
        {
            return new Guild(instance);
        }
        
        public static implicit operator bool(Guild instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
