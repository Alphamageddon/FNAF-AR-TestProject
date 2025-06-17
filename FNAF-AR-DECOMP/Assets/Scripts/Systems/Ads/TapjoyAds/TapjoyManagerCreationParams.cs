using UnityEngine;

namespace Systems.Ads.TapjoyAds
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TapjoyManagerCreationParams
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Ads.TapjoyAds.TapjoyConfig Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action ConnectedCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyManagerCreationParams()
        {
        
        }
    
    }

}
