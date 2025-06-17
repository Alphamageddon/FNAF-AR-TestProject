using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class AkMemBankLoader.<LoadFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMemBankLoader <>4__this;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMemBankLoader.<LoadFile>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        uint val_10;
        int val_11;
        val_10 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_11;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_3;
        }
        
        UnityEngine.Networking.UnityWebRequest val_1 = UnityEngine.Networking.UnityWebRequest.Get(uri:  this.<>4__this.m_bankPath);
        this.<>4__this.ms_www = val_1;
        if(val_1 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        this.<>2__current = val_1.SendWebRequest();
        val_11 = 1;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        val_10 = this.<>4__this.AllocateAlignedBuffer(data:  this.<>4__this.ms_www.downloadHandler.data);
        AKRESULT val_7 = AkSoundEngine.LoadBank(in_pInMemoryBankPtr:  this.<>4__this.ms_pInMemoryBankPtr, in_uInMemoryBankSize:  val_10, out_bankID: out  this.<>4__this.ms_bankID);
        if(val_7 != 1)
        {
                val_10 = "WwiseUnity: AkMemBankLoader: bank loading failed with result "("WwiseUnity: AkMemBankLoader: bank loading failed with result ") + val_7;
            UnityEngine.Debug.LogError(message:  val_10);
        }
        
        label_11:
        val_11 = 0;
        return (bool)val_11;
        label_3:
        mem[72] = UnityEngine.Networking.UnityWebRequest.Get(uri:  69077560);
        if(mem[72] != 0)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
