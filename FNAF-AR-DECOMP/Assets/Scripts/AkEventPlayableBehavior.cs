using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEventPlayableBehavior : PlayableBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float currentDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float currentDurationProportion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool eventIsPlaying;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool fadeinTriggered;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool fadeoutTriggered;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float previousEventStartTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const uint CallbackFlags = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkEventPlayableBehavior.Actions requiredActions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int scrubPlaybackLengthMs = 100;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.Event akEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eventDurationMax;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eventDurationMin;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float blendInDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float blendOutDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float easeInDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float easeOutDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCurveInterpolation blendInCurve;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCurveInterpolation blendOutCurve;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject eventObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool retriggerEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool StopEventAtClipEnd;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool overrideTrackEmitterObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float alph = 0.05;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
    {
        var val_3;
        var val_4;
        val_3 = in_type;
        if(val_3 != 8)
        {
                if(val_3 != 1)
        {
                return;
        }
        
            this.fadeoutTriggered = false;
            this.eventIsPlaying = false;
            this.fadeinTriggered = false;
            return;
        }
        
        if(in_info != null)
        {
                val_3 = 1152921505079209984;
            val_4 = null;
            val_4 = null;
            var val_1 = (((AkCallbackInfo.__il2cppRuntimeField_typeHierarchy + (AkDurationCallbackInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_4) ? in_info : 0;
        }
        
        float val_2 = 0.fEstimatedDuration;
        val_2 = val_2 * this.currentDurationProportion;
        val_2 = val_2 / 1000f;
        this.currentDuration = val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsScrubbing(UnityEngine.Playables.FrameData info)
    {
        return (bool)(1152921519437525520 == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
    {
        Actions val_4;
        this.PrepareFrame(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, info:  new UnityEngine.Playables.FrameData() {m_FrameID = info.m_FrameID, m_Weight = info.m_Weight, m_EffectiveParentSpeed = info.m_EffectiveParentSpeed, m_Output = new UnityEngine.Playables.PlayableOutput() {m_Handle = new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = info.m_Output.m_Handle.m_Handle}}});
        if(this.akEvent == null)
        {
                return;
        }
        
        if(((this.ShouldPlay(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}})) == false) || (info.m_FrameID != 0))
        {
            goto label_3;
        }
        
        this.requiredActions = this.requiredActions | 16;
        if(this.eventIsPlaying == true)
        {
                return;
        }
        
        val_4 = this.requiredActions | 25;
        goto label_5;
        label_3:
        if((this.eventIsPlaying == true) || ((this.requiredActions & 1) != 0))
        {
            goto label_7;
        }
        
        val_4 = this.requiredActions | 2;
        label_5:
        this.requiredActions = val_4;
        this.CheckForFadeInFadeOut(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        return;
        label_7:
        this.CheckForFadeOut(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, currentClipTime:  UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
    {
        Actions val_3;
        this.OnBehaviourPlay(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, info:  new UnityEngine.Playables.FrameData() {m_FrameID = info.m_FrameID, m_Weight = info.m_Weight, m_EffectiveParentSpeed = info.m_EffectiveParentSpeed, m_Output = new UnityEngine.Playables.PlayableOutput() {m_Handle = new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = info.m_Output.m_Handle.m_Handle}}});
        if(this.akEvent == null)
        {
                return;
        }
        
        if((this.ShouldPlay(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}})) == false)
        {
                return;
        }
        
        Actions val_3 = this.requiredActions;
        val_3 = val_3 | 1;
        this.requiredActions = val_3;
        if(info.m_FrameID == 0)
        {
            goto label_2;
        }
        
        if((this.GetProportionalTime(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}})) <= 0.05f)
        {
            goto label_3;
        }
        
        val_3 = 16;
        goto label_4;
        label_2:
        val_3 = 8;
        label_4:
        val_3 = this.requiredActions | val_3;
        this.requiredActions = val_3;
        label_3:
        this.CheckForFadeInFadeOut(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info)
    {
        this.OnBehaviourPause(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, info:  new UnityEngine.Playables.FrameData() {m_FrameID = info.m_FrameID, m_Weight = info.m_Weight, m_EffectiveParentSpeed = info.m_EffectiveParentSpeed, m_Output = new UnityEngine.Playables.PlayableOutput() {m_Handle = new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = info.m_Output.m_Handle.m_Handle}}});
        if(this.eventObject == 0)
        {
                return;
        }
        
        if(this.akEvent == null)
        {
                return;
        }
        
        if(this.StopEventAtClipEnd == false)
        {
                return;
        }
        
        this.StopEvent(transition:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData)
    {
        this.ProcessFrame(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, info:  new UnityEngine.Playables.FrameData() {m_FrameID = info.m_FrameID, m_Weight = info.m_Weight, m_EffectiveParentSpeed = info.m_EffectiveParentSpeed, m_Output = new UnityEngine.Playables.PlayableOutput() {m_Handle = new UnityEngine.Playables.PlayableOutputHandle() {m_Handle = info.m_Output.m_Handle.m_Handle}}}, playerData:  playerData = playerData);
        if(this.akEvent == null)
        {
                return;
        }
        
        if(this.overrideTrackEmitterObject != true)
        {
                if(playerData != null)
        {
                UnityEngine.Object val_1 = (null == null) ? (playerData) : 0;
        }
        
            if(val_1 != 0)
        {
                this.eventObject = val_1;
        }
        
        }
        
        if(this.eventObject == 0)
        {
                return;
        }
        
        if((this.requiredActions & 1) != 0)
        {
                if(this.PostEvent() != false)
        {
                this.currentDurationProportion = 1f;
            this.previousEventStartTime = 0f;
        }
        
        }
        
        if((this.requiredActions & 16) != 0)
        {
                float val_5 = this.SeekToTime(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        }
        
        if((this.retriggerEvent != false) && ((this.requiredActions & 2) != 0))
        {
                this.RetriggerEvent(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        }
        
        if((this.requiredActions & 8) != 0)
        {
                this.StopEvent(transition:  100);
        }
        
        if((this.fadeinTriggered != true) && ((this.requiredActions & 32) != 0))
        {
                this.TriggerFadeIn(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        }
        
        if((this.fadeoutTriggered != true) && ((this.requiredActions & 64) != 0))
        {
                this.TriggerFadeOut(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        }
        
        this.requiredActions = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool ShouldPlay(UnityEngine.Playables.Playable playable)
    {
        float val_5;
        var val_6;
        float val_7;
        double val_1 = UnityEngine.Playables.PlayableExtensions.GetPreviousTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        double val_2 = UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        val_5 = val_2;
        if(val_1 != 0f)
        {
            goto label_1;
        }
        
        val_2 = val_5 - val_1;
        if(System.Math.Abs(val_2) > 1)
        {
            goto label_4;
        }
        
        label_1:
        if(this.retriggerEvent == false)
        {
            goto label_5;
        }
        
        val_6 = 1;
        return (bool)(val_5 < 0) ? 1 : 0;
        label_4:
        val_6 = 0;
        return (bool)(val_5 < 0) ? 1 : 0;
        label_5:
        val_7 = this.eventDurationMax;
        if(val_7 == this.eventDurationMin)
        {
                if(this.eventDurationMin != (-1f))
        {
                return (bool)(val_5 < 0) ? 1 : 0;
        }
        
        }
        
        val_7 = this.currentDuration;
        val_5 = val_5 - (double)this.previousEventStartTime;
        if(val_7 != (-1f))
        {
                return (bool)(val_5 < 0) ? 1 : 0;
        }
        
        val_7 = (float)UnityEngine.Playables.PlayableExtensions.GetDuration<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        return (bool)(val_5 < 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CheckForFadeInFadeOut(UnityEngine.Playables.Playable playable)
    {
        double val_1 = UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        if(val_1 >= 0)
        {
                if(val_1 >= 0)
        {
            goto label_2;
        }
        
        }
        
        Actions val_2 = this.requiredActions;
        val_2 = val_2 | 32;
        this.requiredActions = val_2;
        label_2:
        this.CheckForFadeOut(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}, currentClipTime:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CheckForFadeOut(UnityEngine.Playables.Playable playable, double currentClipTime)
    {
        double val_1 = UnityEngine.Playables.PlayableExtensions.GetDuration<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        val_1 = val_1 - currentClipTime;
        if(val_1 > (double)this.blendOutDuration)
        {
                if(val_1 > (double)this.easeOutDuration)
        {
                return;
        }
        
        }
        
        Actions val_2 = this.requiredActions;
        val_2 = val_2 | 64;
        this.requiredActions = val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void TriggerFadeIn(UnityEngine.Playables.Playable playable)
    {
        double val_3 = UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        val_3 = ((double)UnityEngine.Mathf.Max(a:  this.easeInDuration, b:  this.blendInDuration)) - val_3;
        if(val_3 <= 0f)
        {
                return;
        }
        
        this.fadeinTriggered = true;
        this.akEvent.ExecuteAction(gameObject:  this.eventObject, actionOnEventType:  1, transitionDuration:  0, curveInterpolation:  this.blendOutCurve);
        double val_4 = 1000;
        val_4 = val_3 * val_4;
        this.akEvent.ExecuteAction(gameObject:  this.eventObject, actionOnEventType:  2, transitionDuration:  (int)val_4, curveInterpolation:  this.blendInCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void TriggerFadeOut(UnityEngine.Playables.Playable playable)
    {
        this.fadeoutTriggered = true;
        double val_3 = UnityEngine.Playables.PlayableExtensions.GetDuration<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        val_3 = val_3 - (UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}}));
        double val_4 = 1000;
        val_4 = val_3 * val_4;
        this.akEvent.ExecuteAction(gameObject:  this.eventObject, actionOnEventType:  0, transitionDuration:  (int)val_4, curveInterpolation:  this.blendOutCurve);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void StopEvent(int transition = 0)
    {
        if(this.eventIsPlaying == false)
        {
                return;
        }
        
        this.akEvent.ExecuteAction(gameObject:  this.eventObject, actionOnEventType:  0, transitionDuration:  transition, curveInterpolation:  4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool PostEvent()
    {
        this.fadeinTriggered = false;
        this.fadeoutTriggered = false;
        mem[1152921519439101744] = this;
        mem[1152921519439101752] = System.Void AkEventPlayableBehavior::CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
        mem[1152921519439101728] = System.Void AkEventPlayableBehavior::CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
        bool val_2 = ((this.akEvent.Post(gameObject:  this.eventObject, flags:  9, callback:  new AkCallbackManager.EventCallback(), cookie:  0)) != 0) ? 1 : 0;
        this.eventIsPlaying = val_2;
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PlayEvent()
    {
        if(this.PostEvent() == false)
        {
                return;
        }
        
        this.currentDurationProportion = 1f;
        this.previousEventStartTime = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RetriggerEvent(UnityEngine.Playables.Playable playable)
    {
        if(this.PostEvent() == false)
        {
                return;
        }
        
        float val_2 = this.SeekToTime(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        val_2 = 1f - val_2;
        this.currentDurationProportion = val_2;
        this.previousEventStartTime = (float)UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float GetProportionalTime(UnityEngine.Playables.Playable playable)
    {
        float val_4;
        float val_5;
        double val_1 = UnityEngine.Playables.PlayableExtensions.GetTime<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        if((this.eventDurationMax == this.eventDurationMin) && (this.eventDurationMin != (-1f)))
        {
                val_4 = this.eventDurationMax;
            val_5 = (float)val_1;
        }
        else
        {
                val_4 = this.currentDuration;
            if(val_4 == (-1f))
        {
                val_4 = (float)UnityEngine.Playables.PlayableExtensions.GetDuration<UnityEngine.Playables.Playable>(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        }
        
            val_5 = (float)val_1 - this.previousEventStartTime;
        }
        
        val_5 = val_5 / val_4;
        return (float)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float SeekToTime(UnityEngine.Playables.Playable playable)
    {
        UnityEngine.GameObject val_4;
        float val_5;
        val_4 = this;
        float val_1 = this.GetProportionalTime(playable:  new UnityEngine.Playables.Playable() {m_Handle = new UnityEngine.Playables.PlayableHandle() {m_Handle = playable.m_Handle.m_Handle, m_Version = playable.m_Handle.m_Version}});
        val_5 = 1f;
        if(val_1 >= val_5)
        {
                return val_5;
        }
        
        val_5 = val_1;
        if(this.eventIsPlaying == false)
        {
                return val_5;
        }
        
        val_4 = this.eventObject;
        AKRESULT val_3 = AkSoundEngine.SeekOnEvent(in_eventID:  this.akEvent.Id, in_gameObjectID:  val_4, in_fPercent:  val_5);
        return val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEventPlayableBehavior()
    {
        this.currentDuration = -1f;
        this.currentDurationProportion = 1f;
    }

}
