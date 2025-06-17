using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class DeviceData.<>c__DisplayClass15_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.DEVICES_DATA.Types.ENTRY data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.ItemDefinition.Data.DataDefinitions.DeviceData <>4__this;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DeviceData.<>c__DisplayClass15_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <.ctor>b__0(Game.Localization.ILocalization localization)
    {
        string val_1 = this.data.DeviceName;
        Game.Localization.ILocalization val_7 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_8;
        }
        
        var val_5 = mem[null + 176];
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_7:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_6;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (mem[null + 286]))
        {
            goto label_7;
        }
        
        goto label_8;
        label_6:
        val_7 = val_7 + (((mem[null + 176] + 8)) << 4);
        label_8:
        this.<>4__this.Name = GetLocalizedString(localizedStringId:  val_1, originalString:  val_1);
        string val_3 = this.data.Description;
        Game.Localization.ILocalization val_10 = null;
        if((mem[null + 286]) == 0)
        {
            goto label_17;
        }
        
        var val_8 = mem[null + 176];
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_16:
        if(((mem[null + 176] + 8) + -8) == null)
        {
            goto label_15;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (mem[null + 286]))
        {
            goto label_16;
        }
        
        goto label_17;
        label_15:
        val_10 = val_10 + (((mem[null + 176] + 8)) << 4);
        label_17:
        this.<>4__this.Description = GetLocalizedString(localizedStringId:  val_3, originalString:  val_3);
    }

}
