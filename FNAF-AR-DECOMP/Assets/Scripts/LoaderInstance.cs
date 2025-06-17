using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class SeasonalAssetLoader.LoaderInstance
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry> _entries;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Systems.AssetManagement.Shaders.ShaderCollectionInitializer> _shaderCollectionInitializers;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action _onCompletion;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _remaining;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void add__onCompletion(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this._onCompletion, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this._onCompletion != 1152921525227936576);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void remove__onCompletion(System.Action value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this._onCompletion, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this._onCompletion != 1152921525228073152);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SeasonalAssetLoader.LoaderInstance(System.Collections.Generic.List<Game.SeasonalAssets.SeasonalAssetManifest.Entry> entries)
    {
        this._entries = entries;
        this._remaining = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddCompletionCallback(System.Action completionEvent)
    {
        this.add__onCompletion(value:  completionEvent);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void LoadAsync(Systems.AssetManagement.Assets.IAssetCache assetCache)
    {
        var val_20;
        System.Collections.Generic.HashSet<T> val_21;
        var val_22;
        object val_23;
        Entry val_24;
        Systems.AssetManagement.Assets.IAssetCache val_25;
        var val_27;
        var val_28;
        this._shaderCollectionInitializers = new System.Collections.Generic.List<Systems.AssetManagement.Shaders.ShaderCollectionInitializer>();
        val_20 = 1152921525227279200;
        this._remaining = this._entries.Count;
        System.Collections.Generic.HashSet<System.String> val_3 = null;
        val_21 = val_3;
        val_3 = new System.Collections.Generic.HashSet<System.String>();
        val_22 = 0;
        goto label_2;
        label_19:
        SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0 val_4 = null;
        val_23 = val_4;
        val_4 = new SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0();
        .<>4__this = this;
        .entry = this._entries.Item[0];
        if(val_5.asset != null)
        {
                this.OnAssetLoaded();
        }
        else
        {
                val_24 = (SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0)[1152921525228580384].entry;
            if(((SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0)[1152921525228580384].entry) == null)
        {
                val_24 = (SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0)[1152921525228580384].entry;
            if(val_24 == null)
        {
            goto label_28;
        }
        
        }
        
            System.Action<System.Object> val_6 = new System.Action<System.Object>(object:  val_4, method:  System.Void SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0::<LoadAsync>b__0(object obj));
            System.Action val_7 = new System.Action(object:  this, method:  System.Void SeasonalAssetLoader.LoaderInstance::<LoadAsync>b__8_1());
            val_25 = assetCache;
            if(val_25 == 0)
        {
                val_25 = assetCache;
        }
        
            var val_21 = val_25;
            if((assetCache + 286) != 0)
        {
                var val_19 = assetCache + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            do
        {
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
        }
        while(val_20 < (assetCache + 286));
        
        }
        
            val_20 = val_20;
            val_21 = val_21;
            bool val_8 = val_3.Add(item:  (SeasonalAssetLoader.LoaderInstance.<>c__DisplayClass8_0)[1152921525228580384].entry.assetBundle);
        }
        
        val_22 = 1;
        label_2:
        val_23 = this._entries;
        if(val_22 < val_23.Count)
        {
            goto label_19;
        }
        
        if(val_21 != 0)
        {
                this._remaining = val_3.Count + this._remaining;
        }
        else
        {
                this._remaining = val_3.Count + this._remaining;
        }
        
        HashSet.Enumerator<T> val_14 = val_3.GetEnumerator();
        label_24:
        if(((-853163576) & 1) == 0)
        {
            goto label_22;
        }
        
        new System.Action() = new System.Action(object:  this, method:  System.Void SeasonalAssetLoader.LoaderInstance::OnAssetLoaded());
        new Systems.AssetManagement.Shaders.ShaderCollectionInitializer() = new Systems.AssetManagement.Shaders.ShaderCollectionInitializer(assetCache:  assetCache, bundleName:  0.emailUIDataHandler, shaderCollectionName:  "PreWarmOnLoad", forceLoad:  false, onFinished:  new System.Action());
        this._shaderCollectionInitializers.Add(item:  new Systems.AssetManagement.Shaders.ShaderCollectionInitializer());
        goto label_24;
        label_22:
        val_27 = 0;
        val_28 = 1;
        goto label_25;
        label_28:
        if(val_22 != 1)
        {
            goto label_29;
        }
        
        val_27 = 1179403647;
        val_28 = 0;
        label_25:
        long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525228519880});
        if((val_28 & 1) != 0)
        {
                return;
        }
        
        if(val_27 == 0)
        {
                return;
        }
        
        return;
        label_29:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnAssetLoaded()
    {
        var val_3;
        int val_3 = this._remaining;
        val_3 = val_3 - 1;
        this._remaining = val_3;
        if(val_3 > 0)
        {
                return;
        }
        
        if(this._onCompletion != null)
        {
                this._onCompletion.Invoke();
        }
        
        val_3 = 0;
        goto label_3;
        label_7:
        this._shaderCollectionInitializers.Item[0].Teardown();
        val_3 = 1;
        label_3:
        if(val_3 < this._shaderCollectionInitializers.Count)
        {
            goto label_7;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <LoadAsync>b__8_1()
    {
        this.OnAssetLoaded();
    }

}
