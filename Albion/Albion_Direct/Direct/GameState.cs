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

namespace Albion_Direct
{
    /* Internal type: aop */
    public enum GameState
    {
        Unknown = 0,
        LoggingIn = 1,
        Loading = 2,
        Playing = 3
    }
    
    public static class GameStateExtensions
    {
        public static aop ToInternal(this GameState instance)
        {
            return (aop)instance;
        }
        
        public static GameState ToWrapped(this aop instance)
        {
            return (GameState)instance;
        }
    }
}
