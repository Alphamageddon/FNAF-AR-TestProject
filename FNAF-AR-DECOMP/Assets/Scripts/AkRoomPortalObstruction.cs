using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkRoomPortalObstruction : AkObstructionOcclusion
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkRoomPortal m_portal;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        mem[1152921519456213756] = UnityEngine.Random.Range(min:  0f, max:  null);
        float val_3 = 1f;
        val_3 = val_3 / S1;
        mem[1152921519456213736] = val_3;
        this.m_portal = this.GetComponent<AkRoomPortal>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void UpdateObstructionOcclusionValuesForListeners()
    {
        this.UpdateObstructionOcclusionValues(listener:  AkSpatialAudioListener.TheSpatialAudioListener);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void SetObstructionOcclusion(System.Collections.Generic.KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair)
    {
        if(this.m_portal.frontRoomID == this.m_portal.backRoomID)
        {
                return;
        }
        
        this = (long)this.m_portal.GetInstanceID();
        AKRESULT val_4 = AkSoundEngine.SetPortalObstructionAndOcclusion(in_PortalID:  this, in_fObstruction:  ???, in_fOcclusion:  0f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRoomPortalObstruction()
    {
    
    }

}
