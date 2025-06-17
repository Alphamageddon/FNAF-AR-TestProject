using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LeaderboardCellData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.Data.LeaderboardEntry leaderboardEntry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal bool isPlayer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LeaderboardCellData()
        {
        
        }
    
    }

}
