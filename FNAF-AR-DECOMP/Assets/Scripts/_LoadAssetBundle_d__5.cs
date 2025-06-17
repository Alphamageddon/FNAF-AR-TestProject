using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class BundleLoader.<LoadAssetBundle>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string uri;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Systems.AssetManagement.Bundles.BundleState state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Networking.UnityWebRequest <bundleRequest>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BundleLoader.<LoadAssetBundle>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        Systems.AssetManagement.Bundles.BundleState val_6;
        int val_7;
        if((this.<>1__state) == 0)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_25;
        }
        
        this.<>1__state = -3;
        if((this.<bundleRequest>5__2.isNetworkError) != true)
        {
                if((this.<bundleRequest>5__2.isHttpError) == false)
        {
            goto label_5;
        }
        
        }
        
        val_6 = this.state;
        this.state.<Status>k__BackingField = 0;
        if(this.state.OnLoadFailure != null)
        {
                this.state.OnLoadFailure.Invoke(info:  new UnityEngine.CachedAssetBundle() {m_Name = this.state.<Info>k__BackingField, m_Hash = new UnityEngine.Hash128() {m_u32_0 = this.state.<Info>k__BackingField, m_u32_1 = this.state.<Info>k__BackingField, m_u32_2 = 4294967293, m_u32_3 = 4294967295}});
        }
        
        this.state.OnLoadSuccess = 0;
        this.state.OnLoadFailure = 0;
        goto label_8;
        label_0:
        this.<>1__state = 0;
        UnityEngine.Networking.UnityWebRequest val_3 = UnityEngine.Networking.UnityWebRequestAssetBundle.GetAssetBundle(uri:  this.uri, cachedAssetBundle:  new UnityEngine.CachedAssetBundle() {m_Name = this.state.<Info>k__BackingField, m_Hash = new UnityEngine.Hash128() {m_u32_0 = this.state.<Info>k__BackingField, m_u32_1 = this.state.<Info>k__BackingField}}, crc:  0);
        this.<bundleRequest>5__2 = val_3;
        this.<>1__state = -3;
        this.<>2__current = val_3.SendWebRequest();
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_5:
        this.state.BundleLoadSuccess(bundle:  UnityEngine.Networking.DownloadHandlerAssetBundle.GetContent(www:  this.<bundleRequest>5__2));
        label_8:
        this.<>m__Finally1();
        val_7 = 0;
        this.<bundleRequest>5__2 = 0;
        return (bool)val_7;
        label_25:
        val_7 = 0;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<bundleRequest>5__2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.<bundleRequest>5__2.Dispose();
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
