using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkRTPCTrack : TrackAsset
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.RTPC Parameter;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount)
    {
        UnityEngine.Playables.ScriptPlayable<T> val_1 = UnityEngine.Playables.ScriptPlayable<AkRTPCPlayableBehaviour>.Create(graph:  new UnityEngine.Playables.PlayableGraph() {m_Handle = graph.m_Handle, m_Version = graph.m_Version}, inputCount:  inputCount);
        this.setPlayableProperties();
        return UnityEngine.Playables.ScriptPlayable<AkRTPCPlayableBehaviour>.op_Implicit(playable:  new UnityEngine.Playables.ScriptPlayable<T>() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = val_1.m_Handle.m_Handle, m_Version = val_1.m_Handle.m_Version}});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void setPlayableProperties()
    {
        var val_12;
        var val_13;
        var val_12 = 0;
        val_12 = val_12 + 1;
        System.Collections.Generic.IEnumerator<T> val_3 = this.GetClips().GetEnumerator();
        goto label_16;
        label_23:
        var val_13 = 0;
        val_13 = val_13 + 1;
        T val_5 = val_3.Current;
        UnityEngine.Object val_6 = val_5.asset;
        mem[64] = this.Parameter;
        mem[72] = val_5;
        label_16:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_23;
        }
        
        val_12 = 0;
        val_13 = 70;
        if(val_3 == null)
        {
            
        }
        else
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_3.Dispose();
        }
        
        if( == 70)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnValidate()
    {
        var val_14;
        var val_15;
        var val_14 = 0;
        val_14 = val_14 + 1;
        System.Collections.Generic.IEnumerator<T> val_3 = this.GetClips().GetEnumerator();
        goto label_6;
        label_23:
        var val_15 = 0;
        val_15 = val_15 + 1;
        UnityEngine.Object val_6 = val_3.Current.asset;
        mem2[0] = this.Parameter;
        label_6:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_3.MoveNext() == true)
        {
            goto label_23;
        }
        
        val_14 = 0;
        val_15 = 61;
        if(val_3 == null)
        {
            
        }
        else
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_3.Dispose();
        }
        
        if( == 61)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkRTPCTrack()
    {
    
    }

}
