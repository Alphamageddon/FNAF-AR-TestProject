using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ResultStepConfig
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ResultStepConfig.Condition executionCondition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ResultStepConfig.StartMode startMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float delay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ResultStepConfig.Type executionType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string audioEventName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject gameObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool willTimeout;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float timeoutTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Ads.TapjoyAds.TapjoyVideoAdLauncher adLauncher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.NumberChanger numberChanger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.AssetDownloadConfirm assetDownloadConfirm;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AssetManagement.GameAssetManagementDomain gameAssetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.AssetBundleRequirementModule assetBundleRequirementModule;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultStepConfig()
        {
        
        }
    
    }

}
