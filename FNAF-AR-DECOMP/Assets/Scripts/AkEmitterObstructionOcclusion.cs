using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEmitterObstructionOcclusion : AkObstructionOcclusion
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkGameObj m_gameObj;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        this.InitIntervalsAndFadeRates();
        this.m_gameObj = this.GetComponent<AkGameObj>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void UpdateObstructionOcclusionValuesForListeners()
    {
        if(AkRoom.IsSpatialAudioEnabled != false)
        {
                this.UpdateObstructionOcclusionValues(listener:  AkSpatialAudioListener.TheSpatialAudioListener);
            return;
        }
        
        if(this.m_gameObj.m_listeners.useDefaultListeners != false)
        {
                DefaultListenerList val_3 = AkAudioListener.DefaultListeners;
            this.UpdateObstructionOcclusionValues(listenerList:  null);
        }
        
        this.UpdateObstructionOcclusionValues(listenerList:  null);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void SetObstructionOcclusion(System.Collections.Generic.KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair)
    {
        UnityEngine.GameObject val_2 = this.gameObject;
        if(AkRoom.IsSpatialAudioEnabled != false)
        {
                AKRESULT val_3 = AkSoundEngine.SetEmitterObstructionAndOcclusion(in_gameObjectID:  val_2, in_fObstruction:  ???, in_fOcclusion:  0f);
            return;
        }
        
        AKRESULT val_6 = AkSoundEngine.SetObjectObstructionAndOcclusion(in_EmitterID:  val_2, in_ListenerID:  ObsOccPair.Value.emailUIDataHandler.gameObject, in_fObstructionLevel:  0f, in_fOcclusionLevel:  ???);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEmitterObstructionOcclusion()
    {
    
    }

}
