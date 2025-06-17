using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LoadingUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _playerIdText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _versionAndBuildNumberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Loading _canvasController_Loading;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _countDownNumberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider _slider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string PERCENT_SIGN = "%";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float ONE_HUNDRED = 100;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePlayerID()
        {
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            this._playerIdText.text = val_2.playerProfile.userId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVersionNumber()
        {
            this._versionAndBuildNumberText.text = UnityEngine.Application.version;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateUI()
        {
            float val_4 = 100f;
            val_4 = this._canvasController_Loading.GetDisplayPercent() * val_4;
            this._countDownNumberText.text = UnityEngine.Mathf.RoundToInt(f:  val_4)(UnityEngine.Mathf.RoundToInt(f:  val_4)) + "%"("%");
            if(this._slider != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_1.eventExposer.SendPreloadEvent(preloadView:  this._canvasController_Loading, eventName:  "start");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdatePlayerID();
            this.UpdateVersionNumber();
            this.UpdateUI();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LoadingUIView()
        {
        
        }
    
    }

}
