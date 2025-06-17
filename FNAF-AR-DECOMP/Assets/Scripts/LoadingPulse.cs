using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class LoadingPulse : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float PulseSpeed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float timer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform LoadingFront;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform LoadingBack;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform LoadingShadow;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_11;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 * this.PulseSpeed;
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  UnityEngine.Mathf.PingPong(t:  val_1, length:  1f)));
        val_11 = (float)val_4;
        this.timer = val_11;
        if(val_4 == 0)
        {
                this.LoadingFront.gameObject.SetActive(value:  false);
            this.LoadingBack.gameObject.SetActive(value:  false);
            this.LoadingShadow.gameObject.SetActive(value:  false);
            val_11 = this.timer;
        }
        
        if(val_11 != 1f)
        {
                return;
        }
        
        this.LoadingFront.gameObject.SetActive(value:  true);
        this.LoadingBack.gameObject.SetActive(value:  true);
        this.LoadingShadow.gameObject.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LoadingPulse()
    {
        this.PulseSpeed = 1f;
    }

}
