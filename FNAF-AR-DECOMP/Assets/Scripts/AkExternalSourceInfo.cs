using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkExternalSourceInfo : IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr swigCPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected bool swigCMemOwn;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint iExternalSrcCookie { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint idCodec { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string szFile { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr pInMemory { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint uiMemorySize { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint idFile { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn)
    {
        this.swigCMemOwn = cMemoryOwn;
        this.swigCPtr = cPtr;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static IntPtr getCPtr(AkExternalSourceInfo obj)
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
            AkSoundEnginePINVOKE.CSharp_delete_AkExternalSourceInfo(jarg1:  this.swigCPtr);
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
    public AkExternalSourceInfo()
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkExternalSourceInfo__SWIG_0();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkExternalSourceInfo__SWIG_1(jarg1:  in_pInMemory, jarg2:  in_uiMemorySize, jarg3:  in_iExternalSrcCookie, jarg4:  in_idCodec);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkExternalSourceInfo__SWIG_2(jarg1:  in_pszFileName, jarg2:  in_iExternalSrcCookie, jarg3:  in_idCodec);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec)
    {
        this.swigCMemOwn = true;
        this.swigCPtr = AkSoundEnginePINVOKE.CSharp_new_AkExternalSourceInfo__SWIG_3(jarg1:  in_idFile, jarg2:  in_iExternalSrcCookie, jarg3:  in_idCodec);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_Clear(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clone(AkExternalSourceInfo other)
    {
        AkExternalSourceInfo val_1 = other;
        if(val_1 != null)
        {
                val_1 = other.swigCPtr;
        }
        
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_Clone(jarg1:  this.swigCPtr, jarg2:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int GetSizeOf()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_GetSizeOf();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_iExternalSrcCookie(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_iExternalSrcCookie()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_idCodec(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_idCodec_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_idCodec()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_idCodec_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_szFile(string value)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_szFile_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_szFile()
    {
        return AkSoundEngine.StringFromIntPtrOSString(ptr:  AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_szFile_get(jarg1:  this.swigCPtr));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_pInMemory(IntPtr value)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_pInMemory_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IntPtr get_pInMemory()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_pInMemory_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_uiMemorySize(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_uiMemorySize_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_uiMemorySize()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_uiMemorySize_get(jarg1:  this.swigCPtr);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_idFile(uint value)
    {
        AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_idFile_set(jarg1:  this.swigCPtr, jarg2:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint get_idFile()
    {
        return AkSoundEnginePINVOKE.CSharp_AkExternalSourceInfo_idFile_get(jarg1:  this.swigCPtr);
    }

}
