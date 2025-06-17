using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkRTPCPlayableBehaviour : PlayableBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float RTPCValue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <setRTPCGlobally>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <overrideTrackObject>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject <rtpcObject>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AK.Wwise.RTPC <parameter>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool setRTPCGlobally { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool overrideTrackObject { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject rtpcObject { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AK.Wwise.RTPC parameter { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_setRTPCGlobally(bool value)
    {
        this.<setRTPCGlobally>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool get_setRTPCGlobally()
    {
        return (bool)this.<setRTPCGlobally>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_overrideTrackObject(bool value)
    {
        this.<overrideTrackObject>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool get_overrideTrackObject()
    {
        return (bool)this.<overrideTrackObject>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_rtpcObject(UnityEngine.GameObject value)
    {
        this.<rtpcObject>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject get_rtpcObject()
    {
        return (UnityEngine.GameObject)this.<rtpcObject>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_parameter(AK.Wwise.RTPC value)
    {
        this.<parameter>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AK.Wwise.RTPC get_parameter()
    {
        return (AK.Wwise.RTPC)this.<parameter>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData)
    {
        UnityEngine.Object val_4;
        if((this.<parameter>k__BackingField) != null)
        {
                if((this.<overrideTrackObject>k__BackingField) != true)
        {
                if(playerData != null)
        {
                var val_1 = (null == null) ? playerData : 0;
        }
        else
        {
                val_4 = 0;
        }
        
            if(val_4 != 0)
        {
                this.<rtpcObject>k__BackingField = val_4;
        }
        
        }
        
            if((this.<setRTPCGlobally>k__BackingField) != true)
        {
                if((this.<rtpcObject>k__BackingField) != 0)
        {
            goto label_11;
        }
        
        }
        
            this.<parameter>k__BackingField.SetGlobalValue(value:  this.RTPCValue);
        }
        
        label_14:
        this.ProcessFrame(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, info:  new UnityEngine.Playables.FrameData() {m_FrameID = info.m_FrameID, m_Weight = info.m_Weight, m_EffectiveParentSpeed = info.m_EffectiveParentSpeed, m_Output = new UnityEngine.Playables.PlayableOutput() {m_Handle = new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = info.m_Output.m_Handle.m_Handle}}}, playerData:  playerData);
        return;
        label_11:
        this.<parameter>k__BackingField.SetValue(gameObject:  this.<rtpcObject>k__BackingField, value:  this.RTPCValue);
        goto label_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRTPCPlayableBehaviour()
    {
    
    }

}
