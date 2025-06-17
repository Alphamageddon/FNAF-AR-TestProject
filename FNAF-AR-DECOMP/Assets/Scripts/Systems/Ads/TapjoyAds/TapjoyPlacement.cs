using UnityEngine;

namespace Systems.Ads.TapjoyAds
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TapjoyPlacement : BaseTapjoyPlacement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly TapjoyUnity.TJPlacement _placement;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyPlacement(TapjoyUnity.TJPlacement placement)
        {
            this = new System.Object();
            this._placement = placement;
            TapjoyUnity.TJPlacement.add_OnRequestSuccess(value:  new TJPlacement.OnRequestSuccessHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::RequestSuccess(TapjoyUnity.TJPlacement placement)));
            TapjoyUnity.TJPlacement.add_OnRequestFailure(value:  new TJPlacement.OnRequestFailureHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::RequestFailure(TapjoyUnity.TJPlacement placement, string error)));
            TapjoyUnity.TJPlacement.add_OnContentReady(value:  new TJPlacement.OnContentReadyHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::ContentReady(TapjoyUnity.TJPlacement placement)));
            TapjoyUnity.TJPlacement.add_OnContentShow(value:  new TJPlacement.OnContentShowHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::ContentShow(TapjoyUnity.TJPlacement placement)));
            TapjoyUnity.TJPlacement.add_OnContentDismiss(value:  new TJPlacement.OnContentDismissHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::ContentDismiss(TapjoyUnity.TJPlacement placement)));
            TapjoyUnity.TJPlacement.add_OnClick(value:  new TJPlacement.OnClickHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::Click(TapjoyUnity.TJPlacement placement)));
            TapjoyUnity.TJPlacement.add_OnPurchaseRequest(value:  new TJPlacement.OnPurchaseRequestHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::PurchaseRequest(TapjoyUnity.TJPlacement placement, TapjoyUnity.TJActionRequest request, string productId)));
            TapjoyUnity.TJPlacement.add_OnRewardRequest(value:  new TJPlacement.OnRewardRequestHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::RewardRequest(TapjoyUnity.TJPlacement placement, TapjoyUnity.TJActionRequest request, string itemId, int quantity)));
            TapjoyUnity.TJPlacement.add_OnVideoStart(value:  new TJPlacement.OnVideoStartHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::VideoStart(TapjoyUnity.TJPlacement placement)));
            TapjoyUnity.TJPlacement.add_OnVideoError(value:  new TJPlacement.OnVideoErrorHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::VideoError(TapjoyUnity.TJPlacement placement, string error)));
            TapjoyUnity.TJPlacement.add_OnVideoComplete(value:  new TJPlacement.OnVideoCompleteHandler(object:  this, method:  System.Void Systems.Ads.TapjoyAds.TapjoyPlacement::VideoComplete(TapjoyUnity.TJPlacement placement)));
            this.RequestContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool IsPlacementReady()
        {
            if(this._placement != null)
            {
                    return this._placement.IsContentReady();
            }
            
            return this._placement.IsContentReady();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ShowContentFromPlacement()
        {
            this._placement.ShowContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void RequestContentFromPlacement()
        {
            this.RequestContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RequestContent()
        {
            this._placement.RequestContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RequestSuccess(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            this.RequestSuccess(placementName:  placement.GetName());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RequestFailure(TapjoyUnity.TJPlacement placement, string error)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            this.RequestFailure(placementName:  placement.GetName(), error:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ContentReady(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            this.ContentReady(placementName:  placement.GetName());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ContentShow(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            string val_1 = placement.GetName();
            val_1.ContentShow(placementName:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ContentDismiss(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            this.ContentDismiss(placementName:  placement.GetName());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Click(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            string val_1 = placement.GetName();
            val_1.Click(placementName:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PurchaseRequest(TapjoyUnity.TJPlacement placement, TapjoyUnity.TJActionRequest request, string productId)
        {
            string val_2;
            if(this._placement != placement)
            {
                    return;
            }
            
            if(request != null)
            {
                    val_2 = request.requestID;
            }
            else
            {
                    val_2 = 11993091;
            }
            
            0.PurchaseRequest(placementName:  placement.GetName(), requestId:  val_2, token:  request.token, productId:  productId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RewardRequest(TapjoyUnity.TJPlacement placement, TapjoyUnity.TJActionRequest request, string itemId, int quantity)
        {
            string val_2;
            if(this._placement != placement)
            {
                    return;
            }
            
            if(request != null)
            {
                    val_2 = request.requestID;
            }
            else
            {
                    val_2 = 11993091;
            }
            
            0.RewardRequest(placementName:  placement.GetName(), requestId:  val_2, token:  request.token, itemId:  itemId, quantity:  quantity);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VideoStart(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            string val_1 = placement.GetName();
            val_1.VideoStart(placementName:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VideoError(TapjoyUnity.TJPlacement placement, string error)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            this.VideoError(placementName:  placement.GetName(), error:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VideoComplete(TapjoyUnity.TJPlacement placement)
        {
            if(this._placement != placement)
            {
                    return;
            }
            
            this.VideoComplete(placementName:  placement.GetName());
        }
    
    }

}
