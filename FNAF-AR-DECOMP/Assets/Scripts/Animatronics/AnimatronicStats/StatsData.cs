using UnityEngine;

namespace Animatronics.AnimatronicStats
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class StatsData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int CURRENT_VERSION = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int version;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numberOfOrders;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StatsData()
        {
            this.version = 1;
        }
    
    }

}
