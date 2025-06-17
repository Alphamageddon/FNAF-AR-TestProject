using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ModData.<>c__DisplayClass20_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.ItemDefinition.Data.DataDefinitions.ModCategory category;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.ItemDefinition.Data.DataDefinitions.ModData <>4__this;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ModData.<>c__DisplayClass20_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <GetModNameLocalized>b__0(Game.Localization.ILocalization localization)
    {
        string val_5;
        if(this.category <= 10)
        {
                val_5 = mem[66464768 + (this.category) << 3];
            val_5 = 66464768 + (this.category) << 3;
        }
        
        if(this.category != 0)
        {
                string val_1 = this.category.ToString();
        }
        else
        {
                string val_2 = this.category.ToString();
        }
        
        this.category = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = this.category});
        var val_6 = 0;
        val_6 = val_6 + 1;
        this.<>4__this.CategoryStringLocalized = localization.GetLocalizedString(localizedStringId:  val_5, originalString:  val_5);
    }

}
