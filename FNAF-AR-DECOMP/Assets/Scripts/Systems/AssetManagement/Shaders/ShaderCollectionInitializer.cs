using UnityEngine;

namespace Systems.AssetManagement.Shaders
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShaderCollectionInitializer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <ShadersReady>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _bundleName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _shaderCollectionName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.IAssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _onFinished;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShadersReady { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ShadersReady()
        {
            return (bool)this.<ShadersReady>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ShadersReady(bool value)
        {
            this.<ShadersReady>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShaderCollectionInitializer(Systems.AssetManagement.Assets.IAssetCache assetCache, string bundleName, string shaderCollectionName, bool forceLoad, System.Action onFinished)
        {
            val_1 = new System.Object();
            this.<ShadersReady>k__BackingField = false;
            this._bundleName = val_1;
            this._shaderCollectionName = shaderCollectionName;
            this._assetCache = assetCache;
            this._onFinished = onFinished;
            if(forceLoad != false)
            {
                    this.LoadShaderCollection();
                return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            assetCache.DoesBundleContainAsset(bundleName:  string val_1 = bundleName, assetName:  shaderCollectionName, result:  new System.Action<System.Boolean>(object:  this, method:  System.Void Systems.AssetManagement.Shaders.ShaderCollectionInitializer::<.ctor>b__9_0(bool assetExists)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._assetCache = 0;
            this._onFinished = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadShaderCollection()
        {
            System.Action<UnityEngine.ShaderVariantCollection> val_1 = new System.Action<UnityEngine.ShaderVariantCollection>(object:  this, method:  System.Void Systems.AssetManagement.Shaders.ShaderCollectionInitializer::LoadSuccess(UnityEngine.ShaderVariantCollection shaderCollection));
            System.Action val_2 = new System.Action(object:  this, method:  System.Void Systems.AssetManagement.Shaders.ShaderCollectionInitializer::LoadFailure());
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(this._assetCache, typeof(public System.Void Systems.AssetManagement.Assets.IAssetCache::LoadAssetAsync<UnityEngine.ShaderVariantCollection>(string assetName, string bundleName, System.Action<T> onSuccess, System.Action onFailure).__il2cppRuntimeField_18), slot: 0) + 8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadSuccess(UnityEngine.ShaderVariantCollection shaderCollection)
        {
            shaderCollection.WarmUp();
            this.<ShadersReady>k__BackingField = true;
            if(this._onFinished != null)
            {
                    this._onFinished.Invoke();
            }
            
            this._onFinished = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadFailure()
        {
            null = null;
            string[] val_1 = new string[5];
            val_1[0] = "Cannot initialize shaders. Failed to load ShaderVariantCollection \'";
            val_1[1] = this._shaderCollectionName;
            val_1[2] = "\' from \'";
            val_1[3] = this._bundleName;
            val_1[4] = "\'";
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Shaders.ShaderCollectionInitializer.ClassName, functionName:  "LoadFailure", logString:  +val_1);
            if(this._onFinished != null)
            {
                    this._onFinished.Invoke();
            }
            
            this._onFinished = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NotifyFinished()
        {
            if(this._onFinished != null)
            {
                    this._onFinished.Invoke();
            }
            
            this._onFinished = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ShaderCollectionInitializer()
        {
            Systems.AssetManagement.Shaders.ShaderCollectionInitializer.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <.ctor>b__9_0(bool assetExists)
        {
            if(assetExists != false)
            {
                    this.LoadShaderCollection();
                return;
            }
            
            if(this._onFinished != null)
            {
                    this._onFinished.Invoke();
            }
            
            this._onFinished = 0;
        }
    
    }

}
