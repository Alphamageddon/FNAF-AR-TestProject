using UnityEngine;

namespace Systems.Ads.TapjoyAds
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TapjoyManager : BaseTapjoyManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _tapjoyId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Systems.Ads.TapjoyAds.TapjoyPlacement> _placementLookup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyManager(Systems.Ads.TapjoyAds.TapjoyManagerCreationParams creationParams)
        {
            this._placementLookup = new System.Collections.Generic.Dictionary<System.String, Systems.Ads.TapjoyAds.TapjoyPlacement>();
            if((public System.Void System.Collections.Generic.Dictionary<System.String, Systems.Ads.TapjoyAds.TapjoyPlacement>::.ctor()) == 0)
            {
                    return;
            }
            
            TapjoyUnity.Tapjoy.add_OnConnectSuccess(value:  new Tapjoy.OnConnectSuccessHandler(object:  this, method:  typeof(Systems.Ads.TapjoyAds.TapjoyManager).__il2cppRuntimeField_1A0));
            TapjoyUnity.Tapjoy.add_OnConnectFailure(value:  new Tapjoy.OnConnectFailureHandler(object:  this, method:  typeof(Systems.Ads.TapjoyAds.TapjoyManager).__il2cppRuntimeField_1B0));
            TapjoyUnity.Tapjoy.SetDebugEnabled(enable:  false);
            this._tapjoyId = creationParams.UserId;
            TapjoyUnity.Tapjoy.Connect(sdkKey:  "lT7MNRdeTYOaKh7R8YCT2QECNujEyfzikFfpqElFcgvoDtoRG3QhHbFyJcD0");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Systems.Ads.TapjoyAds.ITapjoyPlacement GetPlacement(string placementName)
        {
            if((this._placementLookup.ContainsKey(key:  placementName)) == false)
            {
                    return 0;
            }
            
            if(this._placementLookup != null)
            {
                    return this._placementLookup.Item[placementName];
            }
            
            return this._placementLookup.Item[placementName];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void HandleConnection()
        {
            System.Char[] val_5;
            var val_6;
            TapjoyUnity.TJPlacement val_7;
            TapjoyUnity.Tapjoy.SetUserID(userId:  this._tapjoyId);
            char[] val_1 = new char[1];
            val_5 = val_1;
            val_5[0] = ',';
            val_6 = 0;
            goto label_7;
            label_14:
            val_5 = this._tapjoyId.Split(separator:  val_1)[0];
            val_7 = TapjoyUnity.TJPlacement.CreatePlacement(placementName:  val_5);
            if(val_7 != null)
            {
                    val_7 = this._placementLookup;
                val_7.Add(key:  val_5, value:  new Systems.Ads.TapjoyAds.TapjoyPlacement(placement:  val_7));
            }
            
            val_6 = 1;
            label_7:
            if(val_6 < val_2.Length)
            {
                goto label_14;
            }
        
        }
    
    }

}
