using UnityEngine;

namespace Systems.Ads.TapjoyAds.BaseClasses
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseTapjoyPlacement : ITapjoyPlacement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnRequestSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnRequestFailure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnContentReady;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnContentDismiss;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnVideoError;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnVideoComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDownloading;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRequestSuccess(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRequestSuccess, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRequestSuccess != 1152921523466678000);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRequestSuccess(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRequestSuccess, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRequestSuccess != 1152921523466814576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRequestFailure(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRequestFailure, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRequestFailure != 1152921523466951160);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRequestFailure(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRequestFailure, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRequestFailure != 1152921523467087736);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnContentReady(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnContentReady, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnContentReady != 1152921523467224320);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnContentReady(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnContentReady, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnContentReady != 1152921523467360896);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnContentDismiss(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnContentDismiss, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnContentDismiss != 1152921523467497480);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnContentDismiss(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnContentDismiss, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnContentDismiss != 1152921523467634056);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnVideoError(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnVideoError, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnVideoError != 1152921523467770640);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnVideoError(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnVideoError, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnVideoError != 1152921523467907216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnVideoComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnVideoComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnVideoComplete != 1152921523468043800);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnVideoComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnVideoComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnVideoComplete != 1152921523468180376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowContent()
        {
            if((this & 1) != 0)
            {
                
            }
            else
            {
                    if(this._isDownloading != false)
            {
                    return;
            }
            
                this._isDownloading = true;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsPlacementReady(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void ShowContentFromPlacement(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void RequestContentFromPlacement(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void RequestSuccess(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnRequestSuccess(" + placementName + ")");
            this._isDownloading = false;
            if(this.OnRequestSuccess == null)
            {
                    return;
            }
            
            this.OnRequestSuccess.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void RequestFailure(string placementName, string error)
        {
            string[] val_1 = new string[5];
            val_1[0] = "BaseTapjoyPlacement.OnRequestFailure(";
            val_1[1] = placementName;
            val_1[2] = ", ";
            val_1[3] = error;
            val_1[4] = ")";
            UnityEngine.Debug.Log(message:  +val_1);
            this._isDownloading = false;
            if(this.OnRequestFailure == null)
            {
                    return;
            }
            
            this.OnRequestFailure.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void ContentReady(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnContentReady(" + placementName + ")");
            if(this.OnContentReady == null)
            {
                    return;
            }
            
            this.OnContentReady.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void ContentShow(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnContentShow(" + placementName + ")");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void ContentDismiss(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnContentDismiss(" + placementName + ")");
            if(this.OnContentDismiss == null)
            {
                    return;
            }
            
            this.OnContentDismiss.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Click(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnClick(" + placementName + ")");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void PurchaseRequest(string placementName, string requestId, string token, string productId)
        {
            string[] val_1 = new string[9];
            val_1[0] = "BaseTapjoyPlacement.OnPurchaseRequest(";
            val_1[1] = placementName;
            val_1[2] = ", ";
            val_1[3] = requestId;
            val_1[4] = ", ";
            val_1[5] = token;
            val_1[6] = ", ";
            val_1[7] = productId;
            val_1[8] = ")";
            UnityEngine.Debug.Log(message:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void RewardRequest(string placementName, string requestId, string token, string itemId, int quantity)
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(placementName != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(placementName == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = placementName;
            val_1[1] = requestId;
            val_1[2] = token;
            val_1[3] = itemId;
            val_1[4] = quantity;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "BaseTapjoyPlacement.OnRewardRequest({0}, {1}, {2}, {3}, {4})", args:  val_1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void VideoStart(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnVideoStart(" + placementName + ")");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void VideoError(string placementName, string error)
        {
            string[] val_1 = new string[5];
            val_1[0] = "BaseTapjoyPlacement.OnVideoError(";
            val_1[1] = placementName;
            val_1[2] = ", ";
            val_1[3] = error;
            val_1[4] = ")";
            UnityEngine.Debug.Log(message:  +val_1);
            if(this.OnVideoError == null)
            {
                    return;
            }
            
            this.OnVideoError.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void VideoComplete(string placementName)
        {
            UnityEngine.Debug.Log(message:  "BaseTapjoyPlacement.OnVideoComplete(" + placementName + ")");
            if(this.OnVideoComplete == null)
            {
                    return;
            }
            
            this.OnVideoComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseTapjoyPlacement()
        {
        
        }
    
    }

}
