using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class PlushSuitData.<>c__DisplayClass17_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ENTRY data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.ItemDefinition.Data.DataDefinitions.PlushSuitData <>4__this;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PlushSuitData.<>c__DisplayClass17_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <.ctor>b__0(Game.Localization.ILocalization localization)
    {
        if(this.data != null)
        {
                ANIMATRONICNAMES val_1 = this.data.AnimatronicNames;
            if(val_1 != null)
        {
                string val_2 = val_1.Default;
        }
        
        }
        
        string val_3 = (val_2 == null) ? "" : (val_2);
        Game.Localization.ILocalization val_7 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_9;
        }
        
        var val_5 = mem[null + 176];
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_8:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_7;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (mem[null + 286]))
        {
            goto label_8;
        }
        
        goto label_9;
        label_7:
        val_7 = val_7 + (((mem[null + 176] + 8)) << 4);
        label_9:
        this.<>4__this.<AnimatronicName>k__BackingField = GetLocalizedString(localizedStringId:  val_3, originalString:  val_3);
    }

}
