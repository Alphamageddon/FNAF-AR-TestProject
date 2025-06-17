using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class HardGlitchTrigger : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool TriggerGlitch;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float DurationSeconds;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isDone;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float endChance;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_7;
        if(this.isDone == true)
        {
                return;
        }
        
        if(this.TriggerGlitch != false)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.DurationSeconds - val_1;
            this.DurationSeconds = val_1;
            val_7 = 1152921518894590768;
            GlitchFtue val_2 = this.GetComponent<GlitchFtue>();
            val_2.Chance = 45f;
            GlitchFtue val_3 = this.GetComponent<GlitchFtue>();
            val_3.FuntimeGlitchStrength = 1f;
            GlitchFtue val_4 = this.GetComponent<GlitchFtue>();
            val_4.EternalGlitchStrength = 1f;
        }
        
        if(this.DurationSeconds > 0f)
        {
                return;
        }
        
        GlitchFtue val_5 = this.GetComponent<GlitchFtue>();
        val_7 = this.endChance;
        val_5.Chance = val_7;
        if(this.isDone != true)
        {
                Master.MasterDomain val_6 = Master.MasterDomain.GetDomain();
            val_6.eventExposer.OnHardGlitchesEnded();
        }
        
        this.isDone = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void TriggerOn()
    {
        this.TriggerGlitch = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HardGlitchTrigger()
    {
        this.DurationSeconds = 10f;
        this.endChance = 100f;
    }

}
