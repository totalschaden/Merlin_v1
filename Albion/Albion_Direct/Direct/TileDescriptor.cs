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

namespace Albion_Direct
{
    /* Internal type: afk */
    public partial class TileDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private afk _internal;
        
        #region Properties
        
        public afk TileDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public TileDescriptor(afk instance)
        {
            _internal = instance;
        }
        
        static TileDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator afk(TileDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator TileDescriptor(afk instance)
        {
            return new TileDescriptor(instance);
        }
        
        public static implicit operator bool(TileDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
