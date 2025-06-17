using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint playlistID { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uNumPlaylistItems { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uPlaylistSelection { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uPlaylistItemDone { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(jarg1:  cPtr);
        cMemoryOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj)
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
        this.setCPtr(cPtr:  AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(jarg1:  cPtr));
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
                mem[1152921519337484344] = 0;
            AkSoundEnginePINVOKE.CSharp_delete_AkMusicPlaylistCallbackInfo(jarg1:  this.swigCPtr);
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
    public uint get_playlistID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uNumPlaylistItems()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uPlaylistSelection()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uPlaylistItemDone()
    {
        return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMusicPlaylistCallbackInfo()
    {
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_new_AkMusicPlaylistCallbackInfo();
    }

}
