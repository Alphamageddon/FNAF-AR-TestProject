using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShowMapStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Startup.StartupSequencer _parent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _gameDisplayChanger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.ShowMapStartupTask Setup(TheGame.GameDisplayChanger gameDisplayChanger, Master.EventExposer masterEvents)
        {
            this._gameDisplayChanger = gameDisplayChanger;
            this._masterEvents = masterEvents;
            return (Master.Startup.ShowMapStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._gameDisplayChanger = 0;
            this._masterEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "ShowMap";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._parent = parent;
            this._gameDisplayChanger.RequestDisplayChange(displayType:  0);
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            if(val_1._gameUIDomain.gameUIData.serverGameUIDataModel.featureFlagMap.IsStaySafeAllowed() != false)
            {
                    Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Master.Startup.ShowMapStartupTask::<Execute>b__8_0(Game.Localization.ILocalization localization)));
                return;
            }
            
            this._masterEvents.OnReachedMusicStartPoint();
            this._masterEvents.OnReachedPopulateExistingSeasonalReceiversPoint();
            this.OnYes();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnYes()
        {
            this._parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShowMapStartupTask()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Execute>b__8_0(Game.Localization.ILocalization localization)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_showmap_staysafe_title", originalString:  "Stay safe!");
            var val_10 = 0;
            val_10 = val_10 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_showmap_staysafe_message", originalString:  "Do not trespass while playing \'FNaF: Special Delivery\'.");
            var val_11 = 0;
            val_11 = val_11 + 1;
            GameUI.GenericDialogData val_7 = new GameUI.GenericDialogData();
            if(val_7 != null)
            {
                    .title = val_2;
                .message = val_4;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = val_4;
            }
            
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_showmap_staysafe_confirm", originalString:  "Confirm");
            .positiveButtonAction = new System.Action(object:  this, method:  public System.Void Master.Startup.ShowMapStartupTask::OnYes());
            this._masterEvents.GenericDialogRequest(genericDialogData:  val_7);
            this._masterEvents.OnReachedMusicStartPoint();
            this._masterEvents.OnReachedPopulateExistingSeasonalReceiversPoint();
        }
    
    }

}
