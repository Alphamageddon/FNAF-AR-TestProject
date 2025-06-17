using UnityEngine;

namespace GameUI.AppRestart
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AppRestarter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _events;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentDisplayType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _restartQueuedForMapReturn;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer events)
        {
            this._events = events;
            events.add_RequestRestartGlobally(value:  new System.Action(object:  this, method:  System.Void GameUI.AppRestart.AppRestarter::EventExposer_RequestRestartNow()));
            this._events.add_RequestRestartOnMapOnly(value:  new System.Action(object:  this, method:  System.Void GameUI.AppRestart.AppRestarter::EventExposer_RequestRestartOnMapOnly()));
            this._events.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void GameUI.AppRestart.AppRestarter::EventExposer_GameDisplayChange(TheGame.GameDisplayData args)));
            this._restartQueuedForMapReturn = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._events.remove_RequestRestartGlobally(value:  new System.Action(object:  this, method:  System.Void GameUI.AppRestart.AppRestarter::EventExposer_RequestRestartNow()));
            this._events.remove_RequestRestartOnMapOnly(value:  new System.Action(object:  this, method:  System.Void GameUI.AppRestart.AppRestarter::EventExposer_RequestRestartOnMapOnly()));
            this._events.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void GameUI.AppRestart.AppRestarter::EventExposer_GameDisplayChange(TheGame.GameDisplayData args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RequestRestartNow()
        {
            this.ShowBlockingErrorDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_RequestRestartOnMapOnly()
        {
            if(this._currentDisplayType != 0)
            {
                    this._restartQueuedForMapReturn = true;
                return;
            }
            
            this.ShowBlockingErrorDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_GameDisplayChange(TheGame.GameDisplayData args)
        {
            if(args != null)
            {
                    this._currentDisplayType = args.currentDisplay;
            }
            else
            {
                    this._currentDisplayType = 0.currentDisplay;
            }
            
            if(args.currentDisplay != 0)
            {
                    return;
            }
            
            if(this._restartQueuedForMapReturn == false)
            {
                    return;
            }
            
            this._restartQueuedForMapReturn = false;
            this.ShowBlockingErrorDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowBlockingErrorDialog()
        {
            var val_3;
            System.Action val_5;
            GameUI.GenericDialogData val_1 = new GameUI.GenericDialogData();
            if(val_1 != null)
            {
                    .title = "Something Went Wrong";
                .message = "There was an unrecoverable error.  Please close the app and try again.";
            }
            else
            {
                    mem[16] = "Something Went Wrong";
                mem[24] = "There was an unrecoverable error.  Please close the app and try again.";
            }
            
            .positiveButtonText = "Close Now";
            val_3 = null;
            val_3 = null;
            val_5 = AppRestarter.<>c.<>9__8_0;
            if(val_5 == null)
            {
                    System.Action val_2 = null;
                val_5 = val_2;
                val_2 = new System.Action(object:  AppRestarter.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AppRestarter.<>c::<ShowBlockingErrorDialog>b__8_0());
                AppRestarter.<>c.<>9__8_0 = val_5;
            }
            
            .positiveButtonAction = val_5;
            this._events.GenericDialogRequest(genericDialogData:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppRestarter()
        {
        
        }
    
    }

}
