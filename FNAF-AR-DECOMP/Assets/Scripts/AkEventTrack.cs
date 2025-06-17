using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEventTrack : TrackAsset
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount)
    {
        var val_11;
        var val_13;
        var val_14;
        UnityEngine.Playables.ScriptPlayable<T> val_1 = UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version}, inputCount:  0);
        UnityEngine.Playables.PlayableExtensions.SetInputCount<UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>>(playable:  new UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_1.m_Handle.m_Handle, m_Version = val_1.m_Handle.m_Version}}, value:  inputCount);
        var val_12 = 0;
        val_12 = val_12 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = this.GetClips().GetEnumerator();
        goto label_8;
        label_23:
        var val_13 = 0;
        val_13 = val_13 + 1;
        T val_6 = val_4.Current;
        UnityEngine.Object val_7 = val_6.asset;
        if(val_7 != null)
        {
                val_11 = null;
        }
        
        val_11 = null;
        var val_8 = (((UnityEngine.Object.__il2cppRuntimeField_typeHierarchy + (AkEventPlayable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_11) ? (val_7) : 0;
        mem2[0] = val_6;
        label_8:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_4.MoveNext() == true)
        {
            goto label_23;
        }
        
        val_13 = 0;
        val_14 = 73;
        if(val_4 == null)
        {
                return UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_1.m_Handle.m_Handle, m_Version = val_1.m_Handle.m_Version}});
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_4.Dispose();
        return UnityEngine.Playables.ScriptPlayable<AkEventPlayableBehavior>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_1.m_Handle.m_Handle, m_Version = val_1.m_Handle.m_Version}});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEventTrack()
    {
    
    }

}
