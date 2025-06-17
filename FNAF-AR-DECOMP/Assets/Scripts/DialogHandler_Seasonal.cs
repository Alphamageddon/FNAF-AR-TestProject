using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DialogHandler_Seasonal : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _restartDialogShowed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TheGame.GameDisplayData.DisplayType _currentDisplayType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Master.MasterDomain _masterDomain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Master.EventExposer _masterEventExposer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string DIALOG_TITLE = "ui_dialog_seasonal_restart_title";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string DIALOG_TEXT = "ui_dialog_seasonal_restart_text";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string DIALOG_OK = "ui_generic_ok";
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ShowSeasonalRestartDialog()
    {
        if(this._restartDialogShowed != true)
        {
                Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_10 = 0;
            val_10 = val_10 + 1;
            .title = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_seasonal_restart_title", originalString:  "ui_dialog_seasonal_restart_title");
            var val_11 = 0;
            val_11 = val_11 + 1;
            .message = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_dialog_seasonal_restart_text", originalString:  "ui_dialog_seasonal_restart_text");
            var val_12 = 0;
            val_12 = val_12 + 1;
            .positiveButtonText = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_generic_ok", originalString:  "ui_generic_ok");
            .positiveButtonAction = new System.Action(object:  this, method:  System.Void DialogHandler_Seasonal::ForceQuitApplication());
            this._masterDomain.eventExposer.GenericDialogRequest(genericDialogData:  new GameUI.GenericDialogData());
        }
        
        this._restartDialogShowed = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ForceQuitApplication()
    {
        UnityEngine.Application.Quit();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._masterDomain = Master.MasterDomain.GetDomain();
        this._restartDialogShowed = false;
        this._masterEventExposer = val_1.eventExposer;
        val_1.eventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void DialogHandler_Seasonal::GameDisplayChange(TheGame.GameDisplayData data)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GameDisplayChange(TheGame.GameDisplayData data)
    {
        this._currentDisplayType = data.currentDisplay;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this._masterDomain.AttackSequenceDomain.IsInEncounter() == true)
        {
                return;
        }
        
        if(this._currentDisplayType != 0)
        {
                return;
        }
        
        if(this._masterDomain.seasonalEventDomain.ShouldStartCheckingUpdate() == false)
        {
                return;
        }
        
        if(this._masterDomain.seasonalEventDomain.UpcomingUpdateExist() == false)
        {
                return;
        }
        
        if(this._masterDomain.seasonalEventDomain.WaitingForForceRestart() == true)
        {
                return;
        }
        
        if(this._masterDomain.seasonalEventDomain.ShouldUpdateSeasonalNow() == false)
        {
                return;
        }
        
        this.ShowSeasonalRestartDialog();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DialogHandler_Seasonal()
    {
    
    }

}
