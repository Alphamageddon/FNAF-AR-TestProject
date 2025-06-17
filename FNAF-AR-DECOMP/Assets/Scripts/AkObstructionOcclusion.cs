using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkObstructionOcclusion : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<AkAudioListener> listenersToRemove;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObstructionOcclusionValues;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected float fadeRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float fadeTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.LayerMask LayerMask;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float maxDistance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float refreshInterval;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float refreshTime;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void InitIntervalsAndFadeRates()
    {
        this.refreshTime = UnityEngine.Random.Range(min:  0f, max:  this.refreshInterval);
        float val_2 = 1f;
        val_2 = val_2 / this.fadeTime;
        this.fadeRate = val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void UpdateObstructionOcclusionValues(System.Collections.Generic.List<AkAudioListener> listenerList)
    {
        var val_9;
        var val_19;
        var val_20;
        val_19 = 0;
        goto label_1;
        label_8:
        if((X22.ContainsKey(key:  listenerList.Item[0])) != true)
        {
                this.ObstructionOcclusionValues.Add(key:  listenerList.Item[0], value:  new AkObstructionOcclusion.ObstructionOcclusionValue());
        }
        
        val_19 = 1;
        label_1:
        if(val_19 < listenerList.Count)
        {
            goto label_8;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_6 = this.ObstructionOcclusionValues.GetEnumerator();
        label_14:
        if((1956894400 & 1) == 0)
        {
            goto label_10;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_10 = val_9.trackableId;
        if((listenerList.Contains(item:  val_10.m_SubId1.System.IConvertible.ToUInt64(provider:  public AkAudioListener System.Collections.Generic.KeyValuePair<AkAudioListener, ObstructionOcclusionValue>::get_Key()))) == true)
        {
            goto label_14;
        }
        
        this.listenersToRemove.Add(item:  val_10.m_SubId1.System.IConvertible.ToUInt64(provider:  public AkAudioListener System.Collections.Generic.KeyValuePair<AkAudioListener, ObstructionOcclusionValue>::get_Key()));
        goto label_14;
        label_10:
        long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519448643264});
        val_20 = 0;
        goto label_22;
        label_26:
        bool val_17 = this.ObstructionOcclusionValues.Remove(key:  this.listenersToRemove.Item[0]);
        val_20 = 1;
        label_22:
        if(val_20 < this.listenersToRemove.Count)
        {
            goto label_26;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected void UpdateObstructionOcclusionValues(AkAudioListener listener)
    {
        var val_7;
        System.Collections.Generic.List<AkAudioListener> val_18;
        var val_19;
        var val_20;
        val_19 = 1152921504851574784;
        if((UnityEngine.Object.op_Implicit(exists:  listener)) == false)
        {
                return;
        }
        
        if((this.ObstructionOcclusionValues.ContainsKey(key:  listener)) != true)
        {
                this.ObstructionOcclusionValues.Add(key:  listener, value:  new AkObstructionOcclusion.ObstructionOcclusionValue());
        }
        
        Dictionary.Enumerator<TKey, TValue> val_4 = this.ObstructionOcclusionValues.GetEnumerator();
        label_13:
        if((1957100608 & 1) == 0)
        {
            goto label_8;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_8 = val_7.trackableId;
        if(listener == (val_8.m_SubId1.System.IConvertible.ToUInt64(provider:  public AkAudioListener System.Collections.Generic.KeyValuePair<AkAudioListener, ObstructionOcclusionValue>::get_Key())))
        {
            goto label_13;
        }
        
        this.listenersToRemove.Add(item:  val_8.m_SubId1.System.IConvertible.ToUInt64(provider:  public AkAudioListener System.Collections.Generic.KeyValuePair<AkAudioListener, ObstructionOcclusionValue>::get_Key()));
        goto label_13;
        label_8:
        long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519448849472});
        val_19 = 1152921519444179792;
        val_20 = 0;
        goto label_21;
        label_25:
        bool val_15 = this.ObstructionOcclusionValues.Remove(key:  this.listenersToRemove.Item[0]);
        val_20 = 1;
        label_21:
        val_18 = this.listenersToRemove;
        if(val_20 < val_18.Count)
        {
            goto label_25;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CastRays()
    {
        var val_4;
        float val_22;
        float val_23;
        val_22 = this.refreshInterval;
        if(this.refreshTime <= val_22)
        {
            goto label_37;
        }
        
        val_22 = this.refreshTime - val_22;
        this.refreshTime = val_22;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.ObstructionOcclusionValues.GetEnumerator();
        label_13:
        if((1957278080 & 1) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
        UnityEngine.Vector3 val_8 = val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public AkAudioListener System.Collections.Generic.KeyValuePair<AkAudioListener, ObstructionOcclusionValue>::get_Key()).transform.position;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        if((this.maxDistance <= 0f) || (val_11.x <= this.maxDistance))
        {
            goto label_10;
        }
        
        if(val_5.m_SubId1 == 0)
        {
            goto label_11;
        }
        
        val_23 = val_4;
        goto label_13;
        label_11:
        val_23 = 1.68059E-38f;
        goto label_13;
        label_10:
        UnityEngine.Vector3 val_13 = this.transform.position;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_11.x);
        var val_17 = ((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, direction:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, maxDistance:  val_11.x, layerMask:  this.LayerMask.value)) != true) ? 1f : 0f;
        if(val_5.m_SubId1 != 0)
        {
            goto label_13;
        }
        
        goto label_13;
        label_3:
        long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519449026944});
        label_37:
        float val_20 = UnityEngine.Time.deltaTime;
        val_20 = this.refreshTime + val_20;
        this.refreshTime = val_20;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract void UpdateObstructionOcclusionValuesForListeners(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected abstract void SetObstructionOcclusion(System.Collections.Generic.KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_6 = this;
        this.CastRays();
        Dictionary.Enumerator<TKey, TValue> val_1 = this.ObstructionOcclusionValues.GetEnumerator();
        do
        {
            label_5:
            if((1957418856 & 1) == 0)
        {
                return;
        }
        
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
        }
        while((val_2.m_SubId1.Update(fadeRate:  this.fadeRate)) == false);
        
        goto label_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkObstructionOcclusion()
    {
        this.listenersToRemove = new System.Collections.Generic.List<AkAudioListener>();
        this.ObstructionOcclusionValues = new System.Collections.Generic.Dictionary<AkAudioListener, ObstructionOcclusionValue>();
        this.fadeTime = 0.5f;
        UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        this.LayerMask = val_3;
        this.maxDistance = -1f;
        this.refreshInterval = 1f;
    }

}
