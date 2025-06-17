using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkTriggerMouseExit : AkTriggerBase
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnMouseExit()
    {
        if(this == null)
        {
                return;
        }
        
        this.Invoke(in_gameObject:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkTriggerMouseExit()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
