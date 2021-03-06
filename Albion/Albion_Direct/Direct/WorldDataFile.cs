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
    /* Internal type: apv */
    public partial class WorldDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private apv _internal;
        
        #region Properties
        
        public apv WorldDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ClusterDescriptor GetCluster(string A_0) => _internal.i2((string)A_0);
        public IEnumerable<ClusterDescriptor> GetClusters() => _internal.i3().Select(x =>(ClusterDescriptor)x);
        public ClusterExitDescriptor GetExit(string A_0) => _internal.i3((string)A_0);
        public TerritoryDescriptor GetTerritory(string A_0) => _internal.i4((string)A_0);
        
        #endregion
        
        #region Constructor
        
        public WorldDataFile(apv instance) : base(instance)
        {
            _internal = instance;
        }
        
        static WorldDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator apv(WorldDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator WorldDataFile(apv instance)
        {
            return new WorldDataFile(instance);
        }
        
        public static implicit operator bool(WorldDataFile instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
