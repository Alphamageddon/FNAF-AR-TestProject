using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SetFogParams : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Debug;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color FogColor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.FogMode Fog_Mode;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float FogDensity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool FogActive;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(this.FogActive == false)
        {
                return;
        }
        
        UnityEngine.RenderSettings.fog = true;
        UnityEngine.RenderSettings.fogColor = new UnityEngine.Color() {r = this.FogColor};
        UnityEngine.RenderSettings.fogMode = this.Fog_Mode;
        UnityEngine.RenderSettings.fogDensity = this.FogDensity;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.FogActive != true)
        {
                if(this.Debug == false)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.RenderSettings.fog = true;
        UnityEngine.RenderSettings.fogColor = new UnityEngine.Color() {r = this.FogColor};
        UnityEngine.RenderSettings.fogMode = this.Fog_Mode;
        UnityEngine.RenderSettings.fogDensity = this.FogDensity;
        label_2:
        UnityEngine.RenderSettings.fog = (this.FogActive == true) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SetFogParams()
    {
        this.Fog_Mode = 3;
        this.FogActive = true;
    }

}
