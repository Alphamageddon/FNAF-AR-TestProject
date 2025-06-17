using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SimpleTimer
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float Unset = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float endTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool started;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartTimer(float time)
    {
        this.started = true;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + time;
        this.endTime = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Reset()
    {
        this.endTime = 1f;
        this.started = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsExpired()
    {
        return (bool)(UnityEngine.Time.time >= this.endTime) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GetRemainingTime()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = this.endTime - val_1;
        return (float)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Started()
    {
        return (bool)this.started;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SimpleTimer()
    {
        this.endTime = 1f;
    }

}
