using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMIDIPost : AkMIDIEvent
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uOffset { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn)
    {
        this = new System.Object();
        mem[1152921519334531376] = AkSoundEnginePINVOKE.CSharp_AkMIDIPost_SWIGUpcast(jarg1:  cPtr);
        mem[1152921519334531384] = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMIDIPost obj)
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
    internal override void setCPtr(IntPtr cPtr)
    {
        mem[1152921519334763568] = AkSoundEnginePINVOKE.CSharp_AkMIDIPost_SWIGUpcast(jarg1:  cPtr);
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Finalize()
    {
        this.Finalize();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Dispose()
    {
        bool val_1 = false;
        System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
        if((System.IntPtr.op_Inequality(value1:  this.swigCPtr, value2:  0)) != false)
        {
                if(true != 0)
        {
                mem[1152921519334987576] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkMIDIPost(jarg1:  this.swigCPtr);
        }
        
            this.swigCPtr = 0;
        }
        
        System.GC.SuppressFinalize(obj:  this);
        this.Dispose();
        if(val_1 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this);
        }
        
        if(91 == 91)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uOffset(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkMIDIPost_uOffset_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uOffset()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIPost_uOffset_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT PostOnEvent(uint in_eventID, UnityEngine.GameObject in_gameObjectID, uint in_uNumPosts)
    {
        ulong val_1 = AkSoundEngine.GetAkGameObjectID(gameObject:  in_gameObjectID);
        AkSoundEngine.PreGameObjectAPICall(gameObject:  in_gameObjectID, id:  val_1);
        return AkSoundEnginePINVOKE.CSharp_AkMIDIPost_PostOnEvent(jarg1:  this.swigCPtr, jarg2:  in_eventID, jarg3:  val_1, jarg4:  in_uNumPosts);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkMIDIPost other)
    {
        AkMIDIPost val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkMIDIPost_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMIDIPost_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMIDIPost()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkMIDIPost();
    }

}
