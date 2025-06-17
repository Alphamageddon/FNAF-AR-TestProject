using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class BlinkLight : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float blinkDuration;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.BlinkLed());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator BlinkLed()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new BlinkLight.<BlinkLed>d__2();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BlinkLight()
    {
        this.blinkDuration = 2f;
    }

}
