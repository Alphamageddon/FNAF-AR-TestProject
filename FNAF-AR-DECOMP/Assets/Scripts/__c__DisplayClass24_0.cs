using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class EmailSelectionHandler.<>c__DisplayClass24_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string id;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public EmailSelectionHandler.<>c__DisplayClass24_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool <DeleteFolder>b__0(GameUI.InboxCell x)
    {
        if((x.<emailData>k__BackingField.tags) != null)
        {
                return x.<emailData>k__BackingField.tags.Contains(item:  this.id);
        }
        
        return x.<emailData>k__BackingField.tags.Contains(item:  this.id);
    }

}
