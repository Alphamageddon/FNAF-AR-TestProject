using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkCommonAdvancedSettings.SpatialAudioSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_DiffractionShadowAttenuationFactor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m_DiffractionShadowDegrees;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCommonAdvancedSettings.SpatialAudioSettings()
    {
        this.m_DiffractionShadowAttenuationFactor = 2f;
        this.m_DiffractionShadowDegrees = 30f;
    }

}
