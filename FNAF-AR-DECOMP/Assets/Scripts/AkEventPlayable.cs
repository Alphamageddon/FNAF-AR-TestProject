using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEventPlayable : PlayableAsset, ITimelineClipAsset
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.Event akEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkCurveInterpolation blendInCurve;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkCurveInterpolation blendOutCurve;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.ExposedReference<UnityEngine.GameObject> emitterObjectRef;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eventDurationMax;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eventDurationMin;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Timeline.TimelineClip owningClip;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool retriggerEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseWwiseEventDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool StopEventAtClipEnd;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.clipCaps { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps()
    {
        return 17;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner)
    {
        UnityEngine.Object val_13;
        AkCurveInterpolation val_14;
        UnityEngine.Playables.ScriptPlayable<T> val_1 = UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version}, inputCount:  0);
        UnityEngine.IExposedPropertyTable val_2 = UnityEngine.Playables.PlayableGraph.GetResolver_Injected(_unity_self: ref  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version});
        val_13 = this.emitterObjectRef;
        UnityEngine.Object val_4 = (val_13 != 0) ? owner : (val_13);
        if((val_4 != 0) && (this.akEvent != null))
        {
                val_13 = ;
            if(val_1.m_Handle.m_Handle != 0)
        {
                val_14 = this.blendOutCurve;
        }
        else
        {
                mem[40] = this.akEvent;
            mem[72] = this.blendInCurve;
            val_14 = this.blendOutCurve;
        }
        
            if(this.owningClip != null)
        {
                double val_6 = this.owningClip.easeInDuration;
            double val_7 = this.owningClip.easeOutDuration;
            double val_8 = this.owningClip.blendInDuration;
            double val_9 = this.owningClip.blendOutDuration;
        }
        
            bool val_11 = UnityEngine.Object.op_Inequality(x:  val_4, y:  0);
        }
        
        UnityEngine.Playables.Playable val_12 = UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_1.m_Handle.m_Handle, m_Version = val_1.m_Handle.m_Version}});
        return new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_12.m_Handle.m_Handle, m_Version = val_12.m_Handle.m_Version}};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEventPlayable()
    {
        this.akEvent = new AK.Wwise.Event();
        this.blendInCurve = 17179869188;
        this.eventDurationMax = -1f;
        this.eventDurationMin = -1f;
        this.UseWwiseEventDuration = true;
        this.StopEventAtClipEnd = true;
    }

}
