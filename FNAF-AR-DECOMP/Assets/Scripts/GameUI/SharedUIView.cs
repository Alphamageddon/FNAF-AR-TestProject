using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SharedUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Shared dialogHandler_Shared;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DialogHandler_Seasonal dialogHandler_Seasonal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button returnToMapButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject popDownPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI popDownTextTitleText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI popDownTextMessagesText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image popDownImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI popDownUnidentifiedOverlay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject inboxBadgeParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI inboxBadgeLabel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject storeBadgeParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject bottomBarParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject bottomBarCloseParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<HighlightToggle> bottomBarButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button cameraButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject cameraButtonPulse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image cameraImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite cameraImageAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float cameraAlertToggleTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ServerTimeOutDialogHandler _serverTimeOutDialogHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PopDownDispatcher _popDownDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PopDownDispatcherData _popDownDispatcherData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BottomBarHandler _bottomBarHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BottomBarData _bottomBarData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxBadgeActivator _inboxBadgeActivator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxBadgeBroker _inboxBadgeBroker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.InboxBadgeBrokerData _inboxBadgeBrokerData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreBadgeActivator _storeBadgeActivator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreBadgeBroker _storeBadgeBroker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.StoreBadgeController _storeBadgeController;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldReturnToMapBeVisible()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(true == 0)
            {
                    return false;
            }
            
            if(this._masterDomain.AttackSequenceDomain.IsEncounterPlayingOutro() != false)
            {
                    return false;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            return this._masterDomain.CameraEquipmentDomain.Mask.IsMaskFullyOff();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildData()
        {
            float val_2;
            this._popDownDispatcherData = this.popDownPanel;
            mem[1152921524946299256] = this.popDownTextTitleText;
            mem[1152921524946299272] = this.popDownImage;
            mem[1152921524946299288] = this.dialogHandler_Shared;
            GameUI.BottomBarData val_1 = new GameUI.BottomBarData();
            if(val_1 != null)
            {
                    .masterDomain = this._masterDomain;
                .bottomBarParent = this.bottomBarParent;
                .bottomBarCloseParent = this.bottomBarCloseParent;
                .bottomBarButtons = this.bottomBarButtons;
                .cameraButtonPulse = this.cameraButtonPulse;
                .cameraImage = this.cameraImage;
                .cameraImageAlert = this.cameraImageAlert;
                val_2 = this.cameraAlertToggleTime;
            }
            else
            {
                    mem[16] = this._masterDomain;
                mem[24] = this.bottomBarParent;
                mem[32] = this.bottomBarCloseParent;
                mem[40] = this.bottomBarButtons;
                mem[48] = this.cameraButtonPulse;
                mem[56] = this.cameraImage;
                mem[64] = this.cameraImageAlert;
                val_2 = this.cameraAlertToggleTime;
            }
            
            .cameraAlertToggleTime = val_2;
            this._bottomBarData = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildInboxBadgeBrokerData()
        {
            GameUI.InboxBadgeActivator val_2;
            GameUI.InboxBadgeBrokerData val_1 = new GameUI.InboxBadgeBrokerData();
            if(val_1 != null)
            {
                    .masterEvents = this._masterDomain.eventExposer;
                val_2 = this._inboxBadgeActivator;
            }
            else
            {
                    mem[16] = this._masterDomain.eventExposer;
                val_2 = this._inboxBadgeActivator;
            }
            
            .inboxBadgeActivator = val_2;
            .getInboxMessagesRequster = this._masterDomain.serverDomain.getInboxMessagesRequester;
            this._inboxBadgeBrokerData = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClosePopDown()
        {
            this._popDownDispatcher.ClosePopDown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this._masterEventExposer = val_1.eventExposer;
            this.BuildData();
            ._masterDomain = this._masterDomain;
            this._serverTimeOutDialogHandler = new GameUI.ServerTimeOutDialogHandler();
            GameUI.PopDownDispatcher val_3 = null;
            val_3 = new GameUI.PopDownDispatcher(masterDomain:  this._masterDomain, popDownDispatcherData:  new GameUI.PopDownDispatcherData() {popDownPanel = this._popDownDispatcherData, popDownTextTitleText = this._popDownDispatcherData, popDownTextMessagesText = ???, popDownImage = ???, popDownUnidentifiedOverlay = ???, dialogHandler_Shared = ???});
            this._popDownDispatcher = val_3;
            this._bottomBarHandler = new GameUI.BottomBarHandler(bottomBarData:  this._bottomBarData);
            this._inboxBadgeActivator = new GameUI.InboxBadgeActivator(inboxBadgeParent:  this.inboxBadgeParent, inboxBadgeLabel:  this.inboxBadgeLabel);
            this.BuildInboxBadgeBrokerData();
            this._inboxBadgeBroker = new GameUI.InboxBadgeBroker(inboxBadgeBrokerData:  this._inboxBadgeBrokerData);
            GameUI.StoreBadgeActivator val_7 = new GameUI.StoreBadgeActivator();
            ._badgeParent = this.storeBadgeParent;
            this._storeBadgeActivator = val_7;
            DefaultNamespace.StoreBadgeController val_8 = new DefaultNamespace.StoreBadgeController(activator:  val_7);
            this._storeBadgeController = val_8;
            this._storeBadgeBroker = new GameUI.StoreBadgeBroker(storeBadgeController:  val_8, eventExposer:  this._masterEventExposer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            TheGame.Domain val_1 = this._masterDomain.theGameDomain;
            if(val_1.GameActive == false)
            {
                    return;
            }
            
            this._popDownDispatcher.Update();
            this._bottomBarHandler.Update();
            this.returnToMapButton.gameObject.SetActive(value:  this.ShouldReturnToMapBeVisible());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            this._popDownDispatcher.LateUpdate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if(this._inboxBadgeBroker != null)
            {
                    this._inboxBadgeBroker.Teardown();
            }
            
            this._inboxBadgeBroker = 0;
            if(this._inboxBadgeActivator != null)
            {
                    this._inboxBadgeActivator.Teardown();
            }
            
            this._inboxBadgeActivator = 0;
            if(this._storeBadgeBroker != null)
            {
                    this._storeBadgeBroker.Teardown();
            }
            
            this._storeBadgeBroker = 0;
            if(this._storeBadgeActivator != null)
            {
                    this._storeBadgeActivator._badgeParent = 0;
            }
            
            this._storeBadgeActivator = 0;
            if(this._storeBadgeController != null)
            {
                    this._storeBadgeController.Teardown();
            }
            
            this._storeBadgeController = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedUIView()
        {
        
        }
    
    }

}
