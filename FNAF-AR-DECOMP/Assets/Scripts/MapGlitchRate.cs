using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MapGlitchRate : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float GlitchDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float DelayMinSeconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float DelayMaxSeconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float timer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float glitchTimer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool triggerGlitch;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Ibuprogames.VideoGlitchesAsset.VideoGlitchShift glitchScript;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.glitchTimer = this.GlitchDuration;
        this.timer = UnityEngine.Random.Range(min:  this.DelayMinSeconds, max:  this.DelayMaxSeconds);
        Ibuprogames.VideoGlitchesAsset.VideoGlitchShift val_2 = this.GetComponent<Ibuprogames.VideoGlitchesAsset.VideoGlitchShift>();
        this.glitchScript = val_2;
        if(val_2 != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "VideoGlitchShift Script not found!");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        Ibuprogames.VideoGlitchesAsset.VideoGlitchShift val_5;
        if(this.triggerGlitch != false)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.glitchTimer - val_1;
            this.glitchTimer = val_1;
            if(val_1 >= 0)
        {
                return;
        }
        
            this.triggerGlitch = false;
            val_5 = this.glitchScript;
            this.timer = UnityEngine.Random.Range(min:  this.DelayMinSeconds, max:  this.DelayMaxSeconds);
            if(val_5 != null)
        {
            goto label_3;
        }
        
        }
        else
        {
                float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.timer - val_3;
            this.timer = val_3;
            if(val_3 >= 0)
        {
                return;
        }
        
            val_5 = this.glitchScript;
            this.triggerGlitch = true;
            this.glitchTimer = this.GlitchDuration;
        }
        
        label_3:
        val_5.Strength = 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MapGlitchRate()
    {
        this.GlitchDuration = ;
        this.DelayMinSeconds = ;
        this.DelayMaxSeconds = 10f;
        this.timer = 10f;
    }

}
