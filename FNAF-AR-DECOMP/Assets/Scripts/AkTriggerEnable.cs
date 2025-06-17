using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriggerEnable : AkTriggerBase
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        if(this == null)
        {
                return;
        }
        
        this.Invoke(in_gameObject:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerEnable()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
