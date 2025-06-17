using UnityEngine;

namespace Game.Server.NetworkAvailabilityCheckers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NetworkAvailabilityChecker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _dialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SimpleTimer _checkReconnectStatusDelayTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _loadingDone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _dialogVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool connectionStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DelayBeforeRecheck = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CONNECTION_LOST_MSG_KEY = "ui_dialog_connection_lost_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CONNECTION_LOST_TITLE_KEY = "ui_dialog_connection_lost_title";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLoadingDone()
        {
            this._loadingDone = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsServerAvailable()
        {
            var val_2;
            var val_4;
            val_2 = null;
            val_2 = null;
            if(Game.Server.ServerDomain.CurrentServer == 2)
            {
                goto label_3;
            }
            
            if(Game.Server.ServerDomain.CurrentServer != 1)
            {
                goto label_4;
            }
            
            return GameSparks.Core.GS.Available;
            label_3:
            var val_1 = (Game.Server.ServerDomain.AuthContext != 0) ? 1 : 0;
            return (bool)val_4;
            label_4:
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DelayOnFocus(bool isFocus)
        {
            if(isFocus == false)
            {
                    return;
            }
            
            this._checkReconnectStatusDelayTimer.StartTimer(time:  2f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatedConnection(bool connection)
        {
            this.connectionStatus = connection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnYes()
        {
            null = null;
            if(Game.Server.ServerDomain.CurrentServer == 1)
            {
                    GameSparks.Core.GS.Reconnect();
            }
            
            this._dialogVisible = false;
            this._checkReconnectStatusDelayTimer.StartTimer(time:  2f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool DelayTimerIsInProgress()
        {
            SimpleTimer val_3;
            var val_4;
            val_3 = this;
            if(this._checkReconnectStatusDelayTimer.Started() == false)
            {
                goto label_1;
            }
            
            if(this._checkReconnectStatusDelayTimer.IsExpired() == false)
            {
                goto label_3;
            }
            
            val_3 = this._checkReconnectStatusDelayTimer;
            val_3.Reset();
            label_1:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PopupDialogIfNecessary(string DebugMessage)
        {
            if(this._dialogVisible != false)
            {
                    return;
            }
            
            NetworkAvailabilityChecker.<>c__DisplayClass15_0 val_1 = new NetworkAvailabilityChecker.<>c__DisplayClass15_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                this._dialogVisible = true;
                .connectionMsg = "ui_dialog_connection_lost_message";
            }
            else
            {
                    mem[32] = this;
                this._dialogVisible = true;
                mem[16] = "ui_dialog_connection_lost_message";
            }
            
            .connectionTitleKey = "ui_dialog_connection_lost_title";
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void NetworkAvailabilityChecker.<>c__DisplayClass15_0::<PopupDialogIfNecessary>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NetworkAvailabilityChecker(Master.EventExposer eventExposer)
        {
            this.connectionStatus = true;
            this._eventExposer = eventExposer;
            eventExposer.add_LoadingDone(value:  new System.Action(object:  this, method:  System.Void Game.Server.NetworkAvailabilityCheckers.NetworkAvailabilityChecker::OnLoadingDone()));
            this._eventExposer.add_NetworkConnectionUpdated(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Game.Server.NetworkAvailabilityCheckers.NetworkAvailabilityChecker::UpdatedConnection(bool connection)));
            this._eventExposer.add_HandleApplicationFocus(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void Game.Server.NetworkAvailabilityCheckers.NetworkAvailabilityChecker::DelayOnFocus(bool isFocus)));
            this._checkReconnectStatusDelayTimer = new SimpleTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._loadingDone == false)
            {
                    return;
            }
            
            if(this.DelayTimerIsInProgress() != false)
            {
                    return;
            }
            
            UnityEngine.NetworkReachability val_2 = UnityEngine.Application.internetReachability;
            if((val_2 != 0) && (this.connectionStatus != false))
            {
                    if(val_2.IsServerAvailable() != false)
            {
                    if(this._dialogVisible == false)
            {
                    return;
            }
            
                this._eventExposer.OnNetworkDialogRequestRemoved();
                this._dialogVisible = false;
                return;
            }
            
            }
            
            this.PopupDialogIfNecessary(DebugMessage:  null);
        }
    
    }

}
