using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkRoomParams : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector Up { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector Front { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint ReverbAuxBus { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ReverbLevel { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float WallOcclusion { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float RoomGameObj_AuxSendLevelToSelf { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool RoomGameObj_KeepRegistered { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkRoomParams obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkRoomParams(jarg1:  this.swigCPtr);
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
    public AkRoomParams()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkRoomParams();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Up(AkVector value)
    {
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_Up_set(jarg1:  this.swigCPtr, jarg2:  AkVector.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector get_Up()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkRoomParams_Up_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkVector)val_4;
        }
        
        AkVector val_3 = null;
        val_4 = val_3;
        val_3 = new AkVector(cPtr:  val_1, cMemoryOwn:  false);
        return (AkVector)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Front(AkVector value)
    {
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_Front_set(jarg1:  this.swigCPtr, jarg2:  AkVector.getCPtr(obj:  value));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkVector get_Front()
    {
        var val_4;
        IntPtr val_1 = AkSoundEnginePINVOKE.CSharp_AkRoomParams_Front_get(jarg1:  this.swigCPtr);
        val_4 = 0;
        if((System.IntPtr.op_Equality(value1:  val_1, value2:  0)) == true)
        {
                return (AkVector)val_4;
        }
        
        AkVector val_3 = null;
        val_4 = val_3;
        val_3 = new AkVector(cPtr:  val_1, cMemoryOwn:  false);
        return (AkVector)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ReverbAuxBus(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbAuxBus_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_ReverbAuxBus()
    {
        return AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbAuxBus_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ReverbLevel(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbLevel_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_ReverbLevel()
    {
        return AkSoundEnginePINVOKE.CSharp_AkRoomParams_ReverbLevel_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_WallOcclusion(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_WallOcclusion_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_WallOcclusion()
    {
        return AkSoundEnginePINVOKE.CSharp_AkRoomParams_WallOcclusion_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RoomGameObj_AuxSendLevelToSelf(float value)
    {
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float get_RoomGameObj_AuxSendLevelToSelf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_RoomGameObj_KeepRegistered(bool value)
    {
        value = value;
        AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_RoomGameObj_KeepRegistered()
    {
        return AkSoundEnginePINVOKE.CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(jarg1:  this.swigCPtr);
    }

}
