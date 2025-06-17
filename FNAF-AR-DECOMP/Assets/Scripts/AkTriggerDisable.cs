using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriggerDisable : AkTriggerBase
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        if(this == null)
        {
                return;
        }
        
        this.Invoke(in_gameObject:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerDisable()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
