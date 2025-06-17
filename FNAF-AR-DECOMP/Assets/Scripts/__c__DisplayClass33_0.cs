using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ModSelectionHandler.<>c__DisplayClass33_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string modId;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ModSelectionHandler.<>c__DisplayClass33_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool <DecrementModFromContextList>b__0(GameUI.Actions.GatherModsForEquipping.ModContext x)
    {
        if(x.Mod != null)
        {
                return System.String.op_Equality(a:  x.Mod.Id, b:  this.modId);
        }
        
        return System.String.op_Equality(a:  x.Mod.Id, b:  this.modId);
    }

}
