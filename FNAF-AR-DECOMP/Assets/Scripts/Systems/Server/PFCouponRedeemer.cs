using UnityEngine;

namespace Systems.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PFCouponRedeemer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CATALOG_VERSION = "FazPass";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            this._eventExposer = eventExposer;
            eventExposer.add_RedeemCoupon(value:  new System.Action<System.String>(object:  this, method:  System.Void Systems.Server.PFCouponRedeemer::RedeemCoupon(string fazPass)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RedeemCoupon(string fazPass)
        {
            PlayFab.ClientModels.RedeemCouponRequest val_1 = new PlayFab.ClientModels.RedeemCouponRequest();
            if(val_1 != null)
            {
                    .CatalogVersion = "FazPass";
            }
            else
            {
                    mem[24] = "FazPass";
            }
            
            .CouponCode = fazPass;
            PlayFab.PlayFabClientAPI.RedeemCoupon(request:  val_1, resultCallback:  new System.Action<PlayFab.ClientModels.RedeemCouponResult>(object:  this, method:  System.Void Systems.Server.PFCouponRedeemer::PlayFab_ResultCallback(PlayFab.ClientModels.RedeemCouponResult obj)), errorCallback:  new System.Action<PlayFab.PlayFabError>(object:  this, method:  System.Void Systems.Server.PFCouponRedeemer::PlayFab_ErrorCallback(PlayFab.PlayFabError obj)), customData:  0, extraHeaders:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayFab_ResultCallback(PlayFab.ClientModels.RedeemCouponResult obj)
        {
            this._eventExposer.OnCouponRedeemed(didComplete:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayFab_ErrorCallback(PlayFab.PlayFabError obj)
        {
            this._eventExposer.OnCouponRedeemed(didComplete:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PFCouponRedeemer()
        {
        
        }
    
    }

}
