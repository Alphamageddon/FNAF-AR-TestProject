using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class AkRTPCPlayable : PlayableAsset, ITimelineClipAsset
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool overrideTrackObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.ExposedReference<UnityEngine.GameObject> RTPCObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool setRTPCGlobally;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRTPCPlayableBehaviour template;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AK.Wwise.RTPC <Parameter>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Timeline.TimelineClip <OwningClip>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.RTPC Parameter { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Timeline.TimelineClip OwningClip { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.clipCaps { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.RTPC get_Parameter()
    {
        return (AK.Wwise.RTPC)this.<Parameter>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Parameter(AK.Wwise.RTPC value)
    {
        this.<Parameter>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Timeline.TimelineClip get_OwningClip()
    {
        return (UnityEngine.Timeline.TimelineClip)this.<OwningClip>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_OwningClip(UnityEngine.Timeline.TimelineClip value)
    {
        this.<OwningClip>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps()
    {
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go)
    {
        UnityEngine.Playables.ScriptPlayable<T> val_1 = UnityEngine.Playables.ScriptPlayable<AkRTPCPlayableBehaviour>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version}, template:  this.template, inputCount:  0);
        IntPtr val_2 = val_1.m_Handle.m_Handle;
        this.InitializeBehavior(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version}, b: ref  val_2, owner:  go);
        UnityEngine.Playables.Playable val_3 = UnityEngine.Playables.ScriptPlayable<AkRTPCPlayableBehaviour>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_2, m_Version = val_1.m_Handle.m_Version}});
        return new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_3.m_Handle.m_Handle, m_Version = val_3.m_Handle.m_Version}};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void InitializeBehavior(UnityEngine.Playables.PlayableGraph graph, ref AkRTPCPlayableBehaviour b, UnityEngine.GameObject owner)
    {
        <overrideTrackObject>k__BackingField = this.overrideTrackObject;
        <setRTPCGlobally>k__BackingField = this.setRTPCGlobally;
        if(this.overrideTrackObject != false)
        {
                UnityEngine.IExposedPropertyTable val_1 = UnityEngine.Playables.PlayableGraph.GetResolver_Injected(_unity_self: ref  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version});
            owner = this.RTPCObject;
        }
        
        <rtpcObject>k__BackingField = owner;
        <parameter>k__BackingField = this.<Parameter>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRTPCPlayable()
    {
        this.template = new AkRTPCPlayableBehaviour();
    }

}
