using UnityEngine;

namespace Systems.Ads.TapjoyAds
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TapjoyConfig
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool IsEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string EnabledPlacements;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyConfig(bool isEnabled, string enabledPlacements)
        {
            val_1 = new System.Object();
            this.IsEnabled = isEnabled;
            this.EnabledPlacements = val_1;
        }
    
    }

}
