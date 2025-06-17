using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct PlayerEssenceData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double lastGlobalTrigger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double lastThreatTrigger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, double> lastCategoryTriggers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> counts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.Server.EssenceNodeEntry> nodes;
        
    
    }

}
