using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface BestStreakLeaderboardGetter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Setup(System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>> callback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetLeaderboard(); // 0
    
    }

}
