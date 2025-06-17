using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ItemDefinitions.<>c__DisplayClass25_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.EmailData emailData;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ItemDefinitions.<>c__DisplayClass25_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool <PredictEmailFolder>b__0(Game.ItemDefinition.Data.DataDefinitions.AlertInboxData x)
    {
        if((System.String.op_Equality(a:  x.eventBody.DisplayTextBody, b:  this.emailData.messageString)) == false)
        {
                return false;
        }
        
        if(this.emailData != null)
        {
                return System.String.op_Equality(a:  x.eventBody.DisplayTextSubject, b:  this.emailData.subjectString);
        }
        
        return System.String.op_Equality(a:  x.eventBody.DisplayTextSubject, b:  this.emailData.subjectString);
    }

}
