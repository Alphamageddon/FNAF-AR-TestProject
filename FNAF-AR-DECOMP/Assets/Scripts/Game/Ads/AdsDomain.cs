using UnityEngine;

namespace Game.Ads
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AdsDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain _theGameDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Ads.TapjoyAds.TapjoyConfig _tapjoyConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Ads.AdProviderManager _adProviderManager;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Ads.TapjoyAds.ITapjoyManager _tapjoyManager;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsTapjoyEnabled { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsTapjoyEnabled()
        {
            if(this._tapjoyConfig == null)
            {
                    return false;
            }
            
            return (bool)(this._tapjoyConfig.IsEnabled == true) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AdsDomain(Game.MasterData.MasterDataDomain masterDataDomain, TheGame.Domain theGameDomain)
        {
            this._theGameDomain = theGameDomain;
            masterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Game.Ads.AdsDomain::ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY configData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Ads.TapjoyAds.ITapjoyPlacement GetTapjoyPlacement(string placementName)
        {
            if(this._tapjoyConfig == null)
            {
                    return 0;
            }
            
            if(this._tapjoyConfig.IsEnabled == false)
            {
                    return 0;
            }
            
            if(this._tapjoyManager == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._tapjoyManager.GetPlacement(placementName:  placementName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY configData)
        {
            var val_6;
            TAPJOY val_7;
            Systems.Ads.TapjoyAds.TapjoyConfig val_8;
            TAPJOY val_9;
            val_6 = configData;
            if(val_6 == null)
            {
                goto label_1;
            }
            
            ADS val_1 = val_6.Ads;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            TAPJOY val_2 = val_1.Tapjoy;
            val_7 = val_2;
            label_1:
            if(this == null)
            {
                goto label_3;
            }
            
            label_5:
            val_8 = val_2.GenerateTapjoyConfig(rawConfig:  val_7);
            goto label_4;
            label_2:
            val_9 = 0;
            if(this != null)
            {
                goto label_5;
            }
            
            label_3:
            val_8 = this.GenerateTapjoyConfig(rawConfig:  val_9);
            label_4:
            this._tapjoyConfig = val_8;
            this._adProviderManager = new Systems.Ads.AdProviderManager(tapjoyConfig:  val_8);
            this.StartTapjoy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartTapjoy()
        {
            if(this._tapjoyConfig == null)
            {
                    return;
            }
            
            if(this._tapjoyConfig.IsEnabled == false)
            {
                    return;
            }
            
            Server.LoginDomain val_1 = this._theGameDomain.loginDomain;
            var val_7 = 0;
            val_7 = val_7 + 1;
            this._adProviderManager.StartTapjoy(tapjoyUserId:  val_1.LoginController.userId + "_" + PlayFab.PlayFabSettings.TitleId, callback:  new System.Action<Systems.Ads.TapjoyAds.ITapjoyManager>(object:  this, method:  System.Void Game.Ads.AdsDomain::TapjoyConnected(Systems.Ads.TapjoyAds.ITapjoyManager tapjoyManager)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Ads.TapjoyAds.TapjoyConfig GenerateTapjoyConfig(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ADS.Types.TAPJOY rawConfig)
        {
            var val_5;
            int val_6;
            if(rawConfig != null)
            {
                    val_5 = rawConfig.IsEnabled;
                val_6 = rawConfig.EnabledPlacements;
                if(val_6 != null)
            {
                    return (Systems.Ads.TapjoyAds.TapjoyConfig)new Systems.Ads.TapjoyAds.TapjoyConfig(isEnabled:  false, enabledPlacements:  val_6 = System.String.alignConst);
            }
            
            }
            else
            {
                    val_5 = 0;
            }
            
            return (Systems.Ads.TapjoyAds.TapjoyConfig)new Systems.Ads.TapjoyAds.TapjoyConfig(isEnabled:  false, enabledPlacements:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TapjoyConnected(Systems.Ads.TapjoyAds.ITapjoyManager tapjoyManager)
        {
            this._tapjoyManager = tapjoyManager;
        }
    
    }

}
