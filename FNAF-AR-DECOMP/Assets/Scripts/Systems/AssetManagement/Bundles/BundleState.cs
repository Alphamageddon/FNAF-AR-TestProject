using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.CachedAssetBundle <Info>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <LocalUri>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ServerUri>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.LoadingStatus <Status>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.BundleLoadSuccess OnLoadSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.BundleLoadFailure OnLoadFailure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AssetBundle _bundle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _referenceCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _preventUnload;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.CachedAssetBundle Info { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LocalUri { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerUri { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.AssetManagement.Bundles.LoadingStatus Status { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.CachedAssetBundle get_Info()
        {
            UnityEngine.CachedAssetBundle val_0;
            val_0.m_Hash.m_u32_2 = ;
            val_0.m_Name = this.<Info>k__BackingField;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Info(UnityEngine.CachedAssetBundle value)
        {
            mem[1152921523424020928] = value.m_Hash.m_u32_2;
            this.<Info>k__BackingField = value.m_Name;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_LocalUri()
        {
            return (string)this.<LocalUri>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LocalUri(string value)
        {
            this.<LocalUri>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ServerUri()
        {
            return (string)this.<ServerUri>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ServerUri(string value)
        {
            this.<ServerUri>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.AssetManagement.Bundles.LoadingStatus get_Status()
        {
            return (Systems.AssetManagement.Bundles.LoadingStatus)this.<Status>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Status(Systems.AssetManagement.Bundles.LoadingStatus value)
        {
            this.<Status>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnLoadSuccess(Systems.AssetManagement.Bundles.BundleLoadSuccess value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoadSuccess, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoadSuccess != 1152921523424874544);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnLoadSuccess(Systems.AssetManagement.Bundles.BundleLoadSuccess value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoadSuccess, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoadSuccess != 1152921523425011120);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnLoadFailure(Systems.AssetManagement.Bundles.BundleLoadFailure value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoadFailure, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoadFailure != 1152921523425147704);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnLoadFailure(Systems.AssetManagement.Bundles.BundleLoadFailure value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoadFailure, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoadFailure != 1152921523425284280);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PreventBundleUnload()
        {
            this._preventUnload = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddBundleReference(Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure, out bool shouldLoad)
        {
            Systems.AssetManagement.Bundles.LoadingStatus val_2;
            int val_2 = this._referenceCount;
            val_2 = val_2 + 1;
            this._referenceCount = val_2;
            if((this.<Status>k__BackingField) == 2)
            {
                goto label_1;
            }
            
            if((this.<Status>k__BackingField) == 1)
            {
                goto label_2;
            }
            
            if((this.<Status>k__BackingField) != 0)
            {
                goto label_3;
            }
            
            val_2 = 1;
            this.<Status>k__BackingField = val_2;
            goto label_4;
            label_1:
            shouldLoad = false;
            if(onSuccess == null)
            {
                    return;
            }
            
            onSuccess.Invoke(info:  new UnityEngine.CachedAssetBundle() {m_Name = this.<Info>k__BackingField, m_Hash = new UnityEngine.Hash128() {m_u32_0 = this.<Info>k__BackingField, m_u32_1 = this.<Info>k__BackingField, m_u32_2 = this.<Status>k__BackingField, m_u32_3 = this.<Status>k__BackingField}}, bundle:  this._bundle);
            return;
            label_2:
            val_2 = false;
            label_4:
            shouldLoad = val_2;
            this.add_OnLoadSuccess(value:  onSuccess);
            this.add_OnLoadFailure(value:  onFailure);
            return;
            label_3:
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveBundleReference()
        {
            this._referenceCount = UnityEngine.Mathf.Max(a:  0, b:  this._referenceCount - 1);
            if((this.<Status>k__BackingField) < 2)
            {
                    return;
            }
            
            if((this.<Status>k__BackingField) == 2)
            {
                    if(this._preventUnload != false)
            {
                    return;
            }
            
                this.UnloadBundle();
                return;
            }
            
            System.ArgumentOutOfRangeException val_3 = new System.ArgumentOutOfRangeException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BundleLoadSuccess(UnityEngine.AssetBundle bundle)
        {
            var val_1 = this;
            mem[1152921523425820200] = 2;
            mem[1152921523425820224] = bundle;
            if(this.OnLoadSuccess != null)
            {
                    this.OnLoadSuccess.Invoke(info:  new UnityEngine.CachedAssetBundle() {m_Name = this.<Info>k__BackingField, m_Hash = new UnityEngine.Hash128() {m_u32_0 = this.<Info>k__BackingField, m_u32_1 = this.<Info>k__BackingField, m_u32_2 = 2}}, bundle:  bundle);
            }
            
            this.OnLoadSuccess = 0;
            mem[1152921523425820216] = 0;
            if(this._referenceCount != 0)
            {
                    return;
            }
            
            if(this._preventUnload != false)
            {
                    return;
            }
            
            this.UnloadBundle();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BundleLoadFailure()
        {
            var val_1 = this;
            this.<Status>k__BackingField = 0;
            if(this.OnLoadFailure != null)
            {
                    this.OnLoadFailure.Invoke(info:  new UnityEngine.CachedAssetBundle() {m_Name = this.<Info>k__BackingField, m_Hash = new UnityEngine.Hash128() {m_u32_0 = this.<Info>k__BackingField, m_u32_1 = this.<Info>k__BackingField, m_u32_2 = ???, m_u32_3 = ???}});
            }
            
            this.OnLoadSuccess = 0;
            this.OnLoadFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UnloadBundle()
        {
            this.<Status>k__BackingField = 0;
            if(this._bundle != 0)
            {
                    this._bundle.Unload(unloadAllLoadedObjects:  true);
            }
            
            this._bundle = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearCallbacks()
        {
            this.OnLoadSuccess = 0;
            this.OnLoadFailure = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(UnityEngine.CachedAssetBundle info, string localUri, string serverUri)
        {
            this.<LocalUri>k__BackingField = localUri;
            this.<ServerUri>k__BackingField = serverUri;
            this.<Status>k__BackingField = 0;
            this.<Info>k__BackingField = info.m_Name;
            mem[1152921523426317296] = info.m_Hash.m_u32_2;
            this._bundle = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._referenceCount = 0;
            this._preventUnload = false;
            this.OnLoadSuccess = 0;
            this.OnLoadFailure = 0;
            this.UnloadBundle();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleState()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static BundleState()
        {
            Systems.AssetManagement.Bundles.BundleState.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
