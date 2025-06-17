using UnityEngine;

namespace Systems.Ads.TapjoyAds.BaseClasses
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseTapjoyManager : ITapjoyManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Systems.Ads.TapjoyAds.TapjoyConfig TapjoyConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Action ConnectedCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseTapjoyManager(Systems.Ads.TapjoyAds.TapjoyManagerCreationParams creationParams)
        {
            if(creationParams != null)
            {
                    this.TapjoyConfig = creationParams.Config;
            }
            else
            {
                    this.TapjoyConfig = 15026800;
            }
            
            this.ConnectedCallback = creationParams.ConnectedCallback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Systems.Ads.TapjoyAds.ITapjoyPlacement GetPlacement(string placementName); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void HandleConnection(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void ConnectSuccess()
        {
            if(this.ConnectedCallback != null)
            {
                    this.ConnectedCallback.Invoke();
            }
            
            this.ConnectedCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void ConnectFailure()
        {
        
        }
    
    }

}
