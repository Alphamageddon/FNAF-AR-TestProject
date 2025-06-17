using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkEvent.CallbackData
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.CallbackFlags Flags;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string FunctionName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject GameObject;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void CallFunction(AkEventCallbackMsg eventCallbackMsg)
    {
        AkCallbackType val_2 = eventCallbackMsg.type;
        uint val_2 = this.Flags.value;
        val_2 = val_2 & val_2;
        if(val_2 == 0)
        {
                return;
        }
        
        val_2 = this.GameObject;
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
        {
                return;
        }
        
        this.GameObject.SendMessage(methodName:  this.FunctionName, value:  eventCallbackMsg);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEvent.CallbackData()
    {
    
    }

}
