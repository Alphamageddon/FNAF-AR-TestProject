using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkEvent : AkDragDropTriggerHandler
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkActionOnEventType actionOnEventType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCurveInterpolation curveInterpolation;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool enableActionOnEvent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AK.Wwise.Event data;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool useCallbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<AkEvent.CallbackData> Callbacks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint playingId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject soundEmitterObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float transitionDuration;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkEventCallbackMsg EventCallbackMsg;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int eventIdInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private byte[] valueGuidInternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkEventCallbackData m_callbackDataInternal;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AK.Wwise.BaseType WwiseType { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int eventID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] valueGuid { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEventCallbackData m_callbackData { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override AK.Wwise.BaseType get_WwiseType()
    {
        return (AK.Wwise.BaseType)this.data;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        if(this.useCallbacks != false)
        {
                .sender = this.gameObject;
            this.EventCallbackMsg = new AkEventCallbackMsg();
        }
        
        this.Start();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
    {
        var val_3;
        this.EventCallbackMsg.type = in_type;
        this.EventCallbackMsg.info = in_info;
        val_3 = 0;
        goto label_3;
        label_7:
        this.Callbacks.Item[0].CallFunction(eventCallbackMsg:  this.EventCallbackMsg);
        val_3 = 1;
        label_3:
        if(val_3 < this.Callbacks.Count)
        {
            goto label_7;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void HandleEvent(UnityEngine.GameObject in_gameObject)
    {
        UnityEngine.Object val_12;
        var val_13;
        uint val_14;
        System.Collections.Generic.List<CallbackData> val_15;
        var val_16;
        val_12 = in_gameObject;
        if(true != 0)
        {
                if(val_12 != 0)
        {
            goto label_4;
        }
        
        }
        
        val_12 = this.gameObject;
        label_4:
        this.soundEmitterObject = val_12;
        if(this.enableActionOnEvent != false)
        {
                this.data.ExecuteAction(gameObject:  val_12, actionOnEventType:  this.actionOnEventType, transitionDuration:  (int)this.transitionDuration * 1000, curveInterpolation:  this.curveInterpolation);
            return;
        }
        
        if(this.useCallbacks == false)
        {
            goto label_22;
        }
        
        val_13 = 0;
        val_14 = 0;
        goto label_8;
        label_21:
        CallbackData val_4 = this.Callbacks.Item[0];
        if((UnityEngine.Object.op_Implicit(exists:  val_4.GameObject)) != false)
        {
                CallbackData val_6 = this.Callbacks.Item[0];
            if((System.String.IsNullOrEmpty(value:  val_6.FunctionName)) != true)
        {
                CallbackData val_8 = this.Callbacks.Item[0];
            val_14 = val_8.Flags.value | val_14;
        }
        
        }
        
        val_13 = 1;
        label_8:
        val_15 = this.Callbacks;
        if(val_13 < val_15.Count)
        {
            goto label_21;
        }
        
        if(val_14 == 0)
        {
            goto label_22;
        }
        
        val_15 = new AkCallbackManager.EventCallback();
        mem[1152921519435664688] = this;
        mem[1152921519435664696] = System.Void AkEvent::Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
        mem[1152921519435664672] = System.Void AkEvent::Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
        val_16 = this.data;
        uint val_10 = val_16.Post(gameObject:  val_12, flags:  val_14, callback:  new AkCallbackManager.EventCallback(), cookie:  0);
        goto label_24;
        label_22:
        val_14 = this.data;
        val_16 = val_14;
        label_24:
        this.playingId = val_16.Post(gameObject:  val_12);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Stop(int _transitionDuration)
    {
        this.Stop(_transitionDuration:  _transitionDuration, _curveInterpolation:  4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation)
    {
        this.data.ExecuteAction(gameObject:  this.soundEmitterObject, actionOnEventType:  0, transitionDuration:  _transitionDuration, curveInterpolation:  _curveInterpolation);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_eventID()
    {
        if(this.data == null)
        {
                return (int)this.data;
        }
        
        return this.data.Id;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public byte[] get_valueGuid()
    {
        UnityEngine.Object val_3;
        AK.Wwise.Event val_4;
        val_3 = this;
        val_4 = this.data;
        if(val_4 == null)
        {
                return (System.Byte[])val_4;
        }
        
        val_3 = val_4;
        val_4 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return (System.Byte[])val_4;
        }
        
        System.Guid val_2 = val_3.Guid;
        val_4;
        return (System.Byte[])val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEventCallbackData get_m_callbackData()
    {
        return (AkEventCallbackData)this.m_callbackDataInternal;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkEvent()
    {
        this.curveInterpolation = 4;
        this.data = new AK.Wwise.Event();
        this.Callbacks = new System.Collections.Generic.List<CallbackData>();
    }

}
