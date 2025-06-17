using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeResponseData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.Server.DailyChallengeEntry> Entries;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long ExpirationTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Complete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string State;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeResponseData()
        {
        
        }
    
    }

}
