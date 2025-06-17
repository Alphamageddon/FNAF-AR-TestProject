using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAudioListener : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly AkAudioListener.DefaultListenerList defaultListeners;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ulong akGameObjectID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<AkGameObj> EmittersToStartListeningTo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<AkGameObj> EmittersToStopListeningTo;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isDefaultListener;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int listenerId;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkAudioListener.DefaultListenerList DefaultListeners { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AkAudioListener.DefaultListenerList get_DefaultListeners()
    {
        null = null;
        return (DefaultListenerList)AkAudioListener.defaultListeners;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartListeningToEmitter(AkGameObj emitter)
    {
        this.EmittersToStartListeningTo.Add(item:  emitter);
        bool val_1 = this.EmittersToStopListeningTo.Remove(item:  emitter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StopListeningToEmitter(AkGameObj emitter)
    {
        bool val_1 = this.EmittersToStartListeningTo.Remove(item:  emitter);
        this.EmittersToStopListeningTo.Add(item:  emitter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetIsDefaultListener(bool isDefault)
    {
        var val_5;
        var val_1 = (this.isDefaultListener == true) ? 1 : 0;
        val_1 = val_1 ^ isDefault;
        if(val_1 == false)
        {
                return;
        }
        
        this.isDefaultListener = isDefault;
        if(isDefault != false)
        {
                val_5 = AkAudioListener.DefaultListeners;
            if(val_5 != null)
        {
            goto typeof(AkAudioListener.DefaultListenerList).__il2cppRuntimeField_178;
        }
        
        }
        else
        {
                val_5 = AkAudioListener.DefaultListeners;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        AkGameObj val_1 = this.GetComponent<AkGameObj>();
        if((UnityEngine.Object.op_Implicit(exists:  val_1)) != false)
        {
                AKRESULT val_3 = val_1.Register();
        }
        
        this.akGameObjectID = AkSoundEngine.GetAkGameObjectID(gameObject:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        if(this.isDefaultListener == false)
        {
                return;
        }
        
        DefaultListenerList val_1 = AkAudioListener.DefaultListeners;
        this = ???;
        goto typeof(AkAudioListener.DefaultListenerList).__il2cppRuntimeField_168;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        if(this.isDefaultListener == false)
        {
                return;
        }
        
        DefaultListenerList val_1 = AkAudioListener.DefaultListeners;
        this = ???;
        goto typeof(AkAudioListener.DefaultListenerList).__il2cppRuntimeField_178;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_5;
        var val_6;
        val_5 = 0;
        goto label_1;
        label_6:
        AkGameObj val_1 = X21.Item[0];
        val_5 = 1;
        label_1:
        if(val_5 < this.EmittersToStartListeningTo.Count)
        {
            goto label_6;
        }
        
        this.EmittersToStartListeningTo.Clear();
        val_6 = 0;
        goto label_7;
        label_12:
        AkGameObj val_3 = this.EmittersToStartListeningTo.Item[0];
        val_6 = 1;
        label_7:
        if(val_6 < this.EmittersToStopListeningTo.Count)
        {
            goto label_12;
        }
        
        this.EmittersToStopListeningTo.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ulong GetAkGameObjectID()
    {
        return (ulong)this.akGameObjectID;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Migrate14()
    {
        UnityEngine.Debug.Log(message:  "WwiseUnity: AkAudioListener.Migrate14 for "("WwiseUnity: AkAudioListener.Migrate14 for ") + this.gameObject.name);
        this.isDefaultListener = (this.listenerId == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAudioListener()
    {
        this.akGameObjectID = 0;
        this.EmittersToStartListeningTo = new System.Collections.Generic.List<AkGameObj>();
        this.EmittersToStopListeningTo = new System.Collections.Generic.List<AkGameObj>();
        this.isDefaultListener = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkAudioListener()
    {
        AkAudioListener.defaultListeners = new AkAudioListener.DefaultListenerList();
    }

}
