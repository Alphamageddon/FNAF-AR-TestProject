using UnityEngine;

namespace Systems.Ads.TapjoyAds
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ITapjoyPlacement
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnRequestSuccess(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnRequestSuccess(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnRequestFailure(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnRequestFailure(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnContentReady(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnContentReady(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnContentDismiss(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnContentDismiss(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnVideoError(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnVideoError(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OnVideoComplete(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OnVideoComplete(System.Action value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsPlacementReady(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ShowContent(); // 0
    
    }

}
