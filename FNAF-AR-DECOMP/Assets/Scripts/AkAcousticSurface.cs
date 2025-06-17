using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAcousticSurface : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint textureID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint reflectorChannelMask { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string strName { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkAcousticSurface obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkAcousticSurface(jarg1:  this.swigCPtr);
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
    public AkAcousticSurface()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkAcousticSurface();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_textureID(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_textureID_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_textureID()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_textureID_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_reflectorChannelMask(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_reflectorChannelMask_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_reflectorChannelMask()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_reflectorChannelMask_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_strName(string value)
    {
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_strName_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_strName()
    {
        return AkSoundEngine.StringFromIntPtrString(ptr:  AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_strName_get(jarg1:  this.swigCPtr));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_Clear(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DeleteName()
    {
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_DeleteName(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkAcousticSurface other)
    {
        AkAcousticSurface val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkAcousticSurface_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }

}
