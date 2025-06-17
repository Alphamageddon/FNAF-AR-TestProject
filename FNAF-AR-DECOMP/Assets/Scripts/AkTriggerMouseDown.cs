using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriggerMouseDown : AkTriggerBase
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnMouseDown()
    {
        if(this == null)
        {
                return;
        }
        
        this.Invoke(in_gameObject:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerMouseDown()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
