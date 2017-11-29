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
    /* Internal type: aud */
    public partial class FightingObject : MovingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private aud _internal;
        
        #region Properties
        
        public aud FightingObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public FightingAttributes GetAttributes() => _internal.at();
        public ObservableRange<aef> GetEnergy() => _internal.w1();
        public ObservableRange<aef> GetHealth() => _internal.w0();
        public CharacterDescriptor GetCharacterDescriptor() => _internal.w8();
        public bool GetIsAttacking() => _internal.yw();
        public bool GetIsCasting() => _internal.ys();
        public bool GetIsDead() => _internal.jg();
        public bool GetIsChanneling() => _internal.yt();
        public bool GetIsIdle() => _internal.yr();
        public float GetLoad() => _internal.ji();
        public float GetLoadPercentage() => _internal.xb();
        public float GetLoadSpeedFactor() => _internal.xc();
        public float GetMaxLoad() => _internal.xa();
        public string GetName() => _internal.iu();
        public long GetTargetId() => _internal.w6();
        public a GetEventHandler<a>() where a: aue => (a)_internal.yi<a>();
        
        #endregion
        
        #region Constructor
        
        public FightingObject(aud instance) : base(instance)
        {
            _internal = instance;
        }
        
        static FightingObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator aud(FightingObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator FightingObject(aud instance)
        {
            return new FightingObject(instance);
        }
        
        public static implicit operator bool(FightingObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
