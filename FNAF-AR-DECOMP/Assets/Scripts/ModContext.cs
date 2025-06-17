using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GatherModsForEquipping.ModContext
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.ItemDefinition.Data.DataDefinitions.ModData Mod;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool modEquippable;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool modSellable;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isEquipped;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int quantity;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GatherModsForEquipping.ModContext()
    {
        this.quantity = 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GatherModsForEquipping.ModContext(GameUI.Actions.GatherModsForEquipping.ModContext contextToCopy)
    {
        this.quantity = 1;
        if(contextToCopy != null)
        {
                this.Mod = contextToCopy.Mod;
            this.modEquippable = contextToCopy.modEquippable;
            this.modSellable = contextToCopy.modSellable;
            this.isEquipped = contextToCopy.isEquipped;
        }
        else
        {
                this.Mod = 11993091;
            this.modEquippable = false;
            this.modSellable = false;
            this.isEquipped = true;
        }
        
        this.quantity = contextToCopy.quantity;
    }

}
