using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DelayGlitchScript : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float StartSecondsTimer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isDone;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        GlitchFtue val_1 = this.GetComponent<GlitchFtue>();
        val_1.Chance = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.isDone == true)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.StartSecondsTimer - val_1;
        this.StartSecondsTimer = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        GlitchFtue val_2 = this.GetComponent<GlitchFtue>();
        val_2.Chance = 10f;
        this.isDone = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DelayGlitchScript()
    {
        this.StartSecondsTimer = 10f;
    }

}
