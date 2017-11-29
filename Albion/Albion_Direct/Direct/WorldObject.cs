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
    /* Internal type: aua */
    public partial class WorldObject : SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aua _internal;
        
        #region Properties
        
        public aua WorldObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public Point2 GetPosition() => _internal.h1();
        public float GetRotation() => _internal.h3();
        
        #endregion
        
        #region Constructor
        
        public WorldObject(aua instance) : base(instance)
        {
            _internal = instance;
        }
        
        static WorldObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aua(WorldObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator WorldObject(aua instance)
        {
            return new WorldObject(instance);
        }
        
        public static implicit operator bool(WorldObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
