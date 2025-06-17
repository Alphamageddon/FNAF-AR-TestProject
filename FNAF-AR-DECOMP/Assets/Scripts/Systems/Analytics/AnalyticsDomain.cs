using UnityEngine;

namespace Systems.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnalyticsDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.CameraEquipmentDomain _cameraEquipmentDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain _theGameDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Devices.DevicesDomain _devicesDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.IAnalyticsProxy _proxy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsVisualizerPresenter _visualizerPresenter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsHistory _analyticsHistory;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Analytics.AnalyticsSrOptions _analyticsSrOptions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BatteryCharge { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumExtraBatteriesUsed { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> PurchasedDevices { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CurrentFazTokens { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Analytics.IAnalyticsProxy Proxy { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_BatteryCharge()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this._cameraEquipmentDomain.Battery.Charge;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumExtraBatteriesUsed()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this._cameraEquipmentDomain.Battery.NumExtraBatteriesUsed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> get_PurchasedDevices()
        {
            if(this._devicesDomain.AllPlayerDevices != null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this._devicesDomain.AllPlayerDevices.purchased;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this._devicesDomain.AllPlayerDevices.purchased;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_CurrentFazTokens()
        {
            TheGame.CurrencyBank val_1 = this._theGameDomain.bank;
            if(val_1 != null)
            {
                    return val_1.GetCurrency(currencyName:  "FAZ_TOKENS");
            }
            
            return val_1.GetCurrency(currencyName:  "FAZ_TOKENS");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Analytics.IAnalyticsProxy get_Proxy()
        {
            return (Systems.Analytics.IAnalyticsProxy)this._proxy;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnalyticsDomain(Game.CameraEquipment.CameraEquipmentDomain cameraEquipmentDomain, TheGame.Domain theGameDomain, Game.Devices.DevicesDomain devicesDomain)
        {
            val_1 = new System.Object();
            this._cameraEquipmentDomain = cameraEquipmentDomain;
            this._theGameDomain = theGameDomain;
            this._devicesDomain = val_1;
            Systems.Analytics.AnalyticsCalls.Domain = this;
            this._proxy = new Systems.Analytics.AnalyticsProxyDummy();
            GameAnalyticsSDK.GameAnalytics.Initialize();
            Systems.Analytics.AnalyticsSrOptions val_3 = new Systems.Analytics.AnalyticsSrOptions();
            this._analyticsSrOptions = val_3;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Analytics", sectionMenuObject:  val_3, defaultToOn:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            Systems.Analytics.AnalyticsHistory val_1 = new Systems.Analytics.AnalyticsHistory();
            this._analyticsHistory = val_1;
            val_1.Setup();
            Systems.Analytics.IAnalyticsProxy[] val_2 = new Systems.Analytics.IAnalyticsProxy[3];
            Systems.Analytics.AnalyticsProxyFlurry val_3 = new Systems.Analytics.AnalyticsProxyFlurry();
            if(val_2 == null)
            {
                goto label_2;
            }
            
            if(val_3 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_3 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_2[0] = val_3;
            val_2[1] = new Systems.Analytics.AnalyticsProxyGameAnalytics();
            ._history = this._analyticsHistory;
            val_2[2] = new Systems.Analytics.AnalyticsProxyHistoryRecorder();
            ._targets = val_2;
            this._proxy = new Systems.Analytics.AnalyticsProxyRepeater();
            Systems.Analytics.AnalyticsVisualizerPresenter val_7 = new Systems.Analytics.AnalyticsVisualizerPresenter();
            this._visualizerPresenter = val_7;
            val_7.Setup(eventExposer:  eventExposer, history:  this._analyticsHistory);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._cameraEquipmentDomain = 0;
            this._devicesDomain = 0;
            this._visualizerPresenter.Teardown();
            this._visualizerPresenter = 0;
            this._analyticsHistory = 0;
        }
    
    }

}
