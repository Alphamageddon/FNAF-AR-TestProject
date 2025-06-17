using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AssembleButtonsHandler.<>c__DisplayClass18_1
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TextMeshProUGUI text;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.AssembleButtonsHandler.<>c__DisplayClass18_0 CS$<>8__locals1;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AssembleButtonsHandler.<>c__DisplayClass18_1()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <SetModUnlockText>b__0(Game.Localization.ILocalization localization)
    {
        AssembleButtonsHandler.<>c__DisplayClass18_0 val_6;
        AssembleButtonsHandler.<>c__DisplayClass18_0 val_8;
        AssembleButtonsHandler.<>c__DisplayClass18_0 val_9;
        AssembleButtonsHandler.<>c__DisplayClass18_0 val_10;
        val_6 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_1;
        }
        
        val_6 = this.CS$<>8__locals1;
        if(val_6 == null)
        {
            goto label_21;
        }
        
        label_1:
        var val_7 = 0;
        val_7 = val_7 + 1;
        this.CS$<>8__locals1.<>4__this.maxStreakUnlockPrefixString = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_mod_button_max_streak_unlock", originalString:  this.CS$<>8__locals1.<>4__this.maxStreakUnlockPrefixString);
        val_8 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1.modUnlocks.Count) <= (this.CS$<>8__locals1.index))
        {
            goto label_13;
        }
        
        val_9 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_14;
        }
        
        val_9 = this.CS$<>8__locals1;
        if(val_9 == null)
        {
            goto label_21;
        }
        
        label_14:
        val_8 = this.CS$<>8__locals1.index;
        label_13:
        this.text.text = this.CS$<>8__locals1.<>4__this.maxStreakUnlockPrefixString(this.CS$<>8__locals1.<>4__this.maxStreakUnlockPrefixString) + this.CS$<>8__locals1.modUnlocks.Item[val_8].ToString()(this.CS$<>8__locals1.modUnlocks.Item[val_8].ToString());
        val_10 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) != null)
        {
            goto label_20;
        }
        
        val_10 = this.CS$<>8__locals1;
        if(val_10 == null)
        {
            goto label_21;
        }
        
        label_20:
        int val_8 = this.CS$<>8__locals1.index;
        val_8 = val_8 + 1;
        this.CS$<>8__locals1.index = val_8;
        return;
        label_21:
    }

}
