using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriggerExit : AkTriggerBase
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject triggerObject;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnTriggerExit(UnityEngine.Collider in_other)
    {
        UnityEngine.GameObject val_6;
        UnityEngine.GameObject val_7;
        if(true == 0)
        {
                return;
        }
        
        val_6 = this.triggerObject;
        if(val_6 != 0)
        {
                val_7 = this.triggerObject;
            if(val_7 != in_other.gameObject)
        {
                return;
        }
        
        }
        
        this.Invoke(in_gameObject:  in_other.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerExit()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
