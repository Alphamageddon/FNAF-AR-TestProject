using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkPlaylist : AkPlaylistArray
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn)
    {
        this = new System.Object();
        mem[1152921519347744560] = AkSoundEnginePINVOKE.CSharp_AkPlaylist_SWIGUpcast(jarg1:  cPtr);
        mem[1152921519347744568] = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkPlaylist obj)
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
        mem[1152921519347976752] = AkSoundEnginePINVOKE.CSharp_AkPlaylist_SWIGUpcast(jarg1:  cPtr);
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
                mem[1152921519348200760] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkPlaylist(jarg1:  this.swigCPtr);
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
    public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylist_Enqueue__SWIG_0(jarg1:  this.swigCPtr, jarg2:  in_audioNodeID, jarg3:  in_msDelay, jarg4:  in_pCustomInfo, jarg5:  in_cExternals, jarg6:  in_pExternalSources.GetBuffer());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylist_Enqueue__SWIG_1(jarg1:  this.swigCPtr, jarg2:  in_audioNodeID, jarg3:  in_msDelay, jarg4:  in_pCustomInfo, jarg5:  in_cExternals);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylist_Enqueue__SWIG_2(jarg1:  this.swigCPtr, jarg2:  in_audioNodeID, jarg3:  in_msDelay, jarg4:  in_pCustomInfo);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylist_Enqueue__SWIG_3(jarg1:  this.swigCPtr, jarg2:  in_audioNodeID, jarg3:  in_msDelay);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AKRESULT Enqueue(uint in_audioNodeID)
    {
        return AkSoundEnginePINVOKE.CSharp_AkPlaylist_Enqueue__SWIG_4(jarg1:  this.swigCPtr, jarg2:  in_audioNodeID);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPlaylist()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkPlaylist();
    }

}
