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
    /* Internal type: att */
    public partial class SimpleItemProxy : ItemProxy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private att _internal;
        
        #region Properties
        
        public att SimpleItemProxy_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public SimpleItemProxy(att instance) : base(instance)
        {
            _internal = instance;
        }
        
        static SimpleItemProxy()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator att(SimpleItemProxy instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimpleItemProxy(att instance)
        {
            return new SimpleItemProxy(instance);
        }
        
        public static implicit operator bool(SimpleItemProxy instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
