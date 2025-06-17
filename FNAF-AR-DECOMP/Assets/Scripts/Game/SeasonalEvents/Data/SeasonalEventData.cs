using UnityEngine;

namespace Game.SeasonalEvents.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalEventData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EventID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SequentialRewardId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SequentialRewardsIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double NextRewardTimestamp;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalEventData()
        {
        
        }
    
    }

}
