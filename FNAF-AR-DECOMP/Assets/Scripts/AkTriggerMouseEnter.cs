using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriggerMouseEnter : AkTriggerBase
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnMouseEnter()
    {
        if(this == null)
        {
                return;
        }
        
        this.Invoke(in_gameObject:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerMouseEnter()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
