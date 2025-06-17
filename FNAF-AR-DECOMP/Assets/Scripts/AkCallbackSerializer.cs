using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkCallbackSerializer : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkCallbackSerializer obj)
    {
        IntPtr val_1;
        if(obj != null)
        {
                val_1 = obj.swigCPtr;
            return (IntPtr)val_1;
        }
        
        val_1 = 0;
        return (IntPtr)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal virtual void setCPtr(IntPtr cPtr)
    {
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Dispose()
    {
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
        if((System.IntPtr.op_Inequality(value1:  this.swigCPtr, value2:  0)) != false)
        {
                if(this.swigCMemOwn != false)
        {
                this.swigCMemOwn = false;
            AkSoundEnginePINVOKE.CSharp_delete_AkCallbackSerializer(jarg1:  this.swigCPtr);
        }
        
            this.swigCPtr = 0;
        }
        
        System.GC.SuppressFinalize(obj:  this);
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this);
        }
        
        if(85 == 85)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT Init(IntPtr in_pMemory, uint in_uSize)
    {
        return AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_Init(jarg1:  in_pMemory, jarg2:  in_uSize);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Term()
    {
        AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_Term();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static IntPtr Lock()
    {
        return AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_Lock();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetLocalOutput(uint in_uErrorLevel)
    {
        AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_SetLocalOutput(jarg1:  in_uErrorLevel);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Unlock()
    {
        AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_Unlock();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie)
    {
        object val_3 = in_pCookie;
        if(val_3 == null)
        {
                return AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(jarg1:  in_bOtherAudioPlaying, jarg2:  val_3 = System.IntPtr.op_Explicit(value:  val_3 = in_pCookie));
        }
        
        return AkSoundEnginePINVOKE.CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(jarg1:  in_bOtherAudioPlaying, jarg2:  val_3);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkCallbackSerializer()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkCallbackSerializer();
    }

}
