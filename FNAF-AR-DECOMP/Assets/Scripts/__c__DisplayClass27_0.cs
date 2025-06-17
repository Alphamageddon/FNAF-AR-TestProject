using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class DialogHandler_WorkshopModify.<>c__DisplayClass27_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.DialogHandler_WorkshopModify <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<GameUI.ModCell> ConfirmSellMod;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.ModCell modCell;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action <>9__1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action <>9__2;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DialogHandler_WorkshopModify.<>c__DisplayClass27_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ShowSellModDialog>b__0(Game.Localization.ILocalization localization)
    {
        System.Action val_9;
        var val_9 = 0;
        val_9 = val_9 + 1;
        if((this.<>9__1) == null)
        {
            goto label_7;
        }
        
        if((this.<>4__this.sellAlert) != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        PaperPlaneTools.Alert val_3 = this.<>4__this.sellAlert.SetPositiveButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_dialogs_confirm", originalString:  "ui_workshop_modify_dialogs_confirm"), handler:  this.<>9__1);
        var val_10 = 0;
        val_10 = val_10 + 1;
        goto label_13;
        label_7:
        this.<>9__1 = new System.Action(object:  this, method:  System.Void DialogHandler_WorkshopModify.<>c__DisplayClass27_0::<ShowSellModDialog>b__1());
        if((this.<>4__this.sellAlert) != null)
        {
            goto label_14;
        }
        
        goto label_15;
        label_13:
        PaperPlaneTools.Alert val_7 = this.<>4__this.sellAlert.SetNegativeButton(title:  localization.GetLocalizedString(localizedStringId:  "ui_workshop_dialogs_cancel", originalString:  "ui_workshop_dialogs_cancel"), handler:  0);
        val_9 = this.<>9__2;
        if(val_9 == null)
        {
                System.Action val_8 = null;
            val_9 = val_8;
            val_8 = new System.Action(object:  this, method:  System.Void DialogHandler_WorkshopModify.<>c__DisplayClass27_0::<ShowSellModDialog>b__2());
            this.<>9__2 = val_9;
        }
        
        Utilities.AlertUtilities.ShowAlertWithAndroidBackButtonAction(alert:  this.<>4__this.sellAlert, backButtonAction:  val_8);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ShowSellModDialog>b__1()
    {
        this.ConfirmSellMod.Invoke(obj:  this.modCell);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ShowSellModDialog>b__2()
    {
        this.<>4__this.sellAlert.Dismiss();
    }

}
