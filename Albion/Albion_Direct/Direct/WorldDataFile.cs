////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Albion_Direct
{
    /* Internal type: al5 */
    public partial class WorldDataFile : DataFile
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private al5 _internal;
        
        #region Properties
        
        public al5 WorldDataFile_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public ClusterDescriptor GetCluster(string A_0) => _internal.id((string)A_0);
        public IEnumerable<ClusterDescriptor> GetClusters() => _internal.ie().Select(x =>(ClusterDescriptor)x);
        public ClusterExitDescriptor GetExit(string A_0) => _internal.ie((string)A_0);
        public TerritoryDescriptor GetTerritory(string A_0) => _internal.@if((string)A_0);
        
        #endregion
        
        #region Constructor
        
        public WorldDataFile(al5 instance) : base(instance)
        {
            _internal = instance;
        }
        
        static WorldDataFile()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator al5(WorldDataFile instance)
        {
            return instance._internal;
        }
        
        public static implicit operator WorldDataFile(al5 instance)
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
