using UnityEngine;

namespace TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LeaderboardEntry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long rank;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long score;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string userId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string avatarId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LeaderboardEntry()
        {
        
        }
    
    }

}
