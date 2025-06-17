using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkMemBankLoader : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int WaitMs = 50;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string bankName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isLocalizedBank;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string m_bankPath;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public uint ms_bankID;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private IntPtr ms_pInMemoryBankPtr;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Runtime.InteropServices.GCHandle ms_pinnedArray;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest ms_www;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(this.isLocalizedBank != false)
        {
                this.LoadLocalizedBank(in_bankFilename:  this.bankName);
            return;
        }
        
        this.LoadNonLocalizedBank(in_bankFilename:  this.bankName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LoadNonLocalizedBank(string in_bankFilename)
    {
        this.m_bankPath = "file:///"("file:///") + System.IO.Path.Combine(path1:  AkBasePathGetter.GetPlatformBasePath(), path2:  in_bankFilename)(System.IO.Path.Combine(path1:  AkBasePathGetter.GetPlatformBasePath(), path2:  in_bankFilename));
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.LoadFile());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LoadLocalizedBank(string in_bankFilename)
    {
        this.m_bankPath = "file:///"("file:///") + System.IO.Path.Combine(path1:  System.IO.Path.Combine(path1:  AkBasePathGetter.GetPlatformBasePath(), path2:  AkSoundEngine.GetCurrentLanguage()), path2:  in_bankFilename)(System.IO.Path.Combine(path1:  System.IO.Path.Combine(path1:  AkBasePathGetter.GetPlatformBasePath(), path2:  AkSoundEngine.GetCurrentLanguage()), path2:  in_bankFilename));
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.LoadFile());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private uint AllocateAlignedBuffer(byte[] data)
    {
        var val_13;
        System.Runtime.InteropServices.GCHandle val_1 = System.Runtime.InteropServices.GCHandle.Alloc(value:  data, type:  3);
        this.ms_pinnedArray = val_1;
        this.ms_pInMemoryBankPtr = 1152921519446978480;
        if((this.ms_pInMemoryBankPtr.ToInt64() & 15) == 0)
        {
                return (uint)data.Length;
        }
        
        int val_4 = data.Length + 16;
        byte[] val_5 = new byte[0];
        System.Runtime.InteropServices.GCHandle val_6 = System.Runtime.InteropServices.GCHandle.Alloc(value:  val_5, type:  3);
        if((val_6.handle.emailUIDataHandler & 15) != null)
        {
                GameUI.EmailUIDataHandler val_12 = val_6.handle.emailUIDataHandler;
            val_12 = (val_12 + 15) & (-16);
            val_6.handle.emailUIDataHandler = val_12;
            val_13 = val_12 - val_6.handle.emailUIDataHandler;
        }
        else
        {
                val_13 = 0;
        }
        
        System.Array.Copy(sourceArray:  data, sourceIndex:  0, destinationArray:  val_5, destinationIndex:  0, length:  data.Length);
        mem[1152921519446978472] = val_6.handle;
        this.ms_pinnedArray = val_6;
        return (uint)data.Length;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator LoadFile()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AkMemBankLoader.<LoadFile>d__14();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DoLoadBank(string in_bankPath)
    {
        this.m_bankPath = in_bankPath;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.LoadFile());
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        if((System.IntPtr.op_Inequality(value1:  this.ms_pInMemoryBankPtr, value2:  0)) == false)
        {
                return;
        }
        
        if((AkSoundEngine.UnloadBank(in_bankID:  this.ms_bankID, in_pInMemoryBankPtr:  this.ms_pInMemoryBankPtr)) != 1)
        {
                return;
        }
        
        this = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMemBankLoader()
    {
        this.ms_pInMemoryBankPtr = 0;
        this.bankName = "";
    }

}
