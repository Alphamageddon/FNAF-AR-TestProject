using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class OKButtonTimer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float disabledTimeInSeconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject okButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool enableButtonNow;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.okButton.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.enableButtonNow == true)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.disabledTimeInSeconds - val_1;
        this.disabledTimeInSeconds = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.enableButtonNow = true;
        this.okButton.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public OKButtonTimer()
    {
        this.disabledTimeInSeconds = 7f;
    }

}
