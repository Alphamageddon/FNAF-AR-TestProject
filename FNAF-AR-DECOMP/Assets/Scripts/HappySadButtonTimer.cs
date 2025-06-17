using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class HappySadButtonTimer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float disabledTimeInSeconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject happyButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject sadButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool enableButtonNow;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.sadButton.SetActive(value:  false);
        this.happyButton.SetActive(value:  false);
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
        this.sadButton.SetActive(value:  true);
        this.happyButton.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HappySadButtonTimer()
    {
        this.disabledTimeInSeconds = 6f;
    }

}
