using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class LoseFxTrigger : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchVHSNoise vhsNoise;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchNoiseDigital noiseDigital;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        this.vhsNoise.enabled = true;
        this.noiseDigital.enabled = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        this.vhsNoise.enabled = false;
        this.noiseDigital.enabled = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LoseFxTrigger()
    {
    
    }

}
