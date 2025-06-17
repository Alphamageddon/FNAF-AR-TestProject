using UnityEngine;

namespace Game.PlayerStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IPlayerStatsDomain
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.PlayerStats.PlayerStatsContainer PlayerStats { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.PlayerStats.PlayerStatsContainer get_PlayerStats(); // 0
    
    }

}
