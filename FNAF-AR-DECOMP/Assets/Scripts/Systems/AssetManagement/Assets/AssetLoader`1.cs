using UnityEngine;

namespace Systems.AssetManagement.Assets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssetLoader<T> : IAssetLoader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _bundleName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _assetName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _assetPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<T> _successCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _failureCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.AssetManagement.Assets.IAssetLoader> _completeCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Load(Systems.AssetManagement.Bundles.IBundleCache bundleCache, string bundleName, string assetName)
        {
            mem[1152921523435537520] = bundleName;
            mem[1152921523435537528] = assetName;
            var val_4 = 0;
            val_4 = val_4 + 1;
            bundleCache.LoadAssetBundleAsync(bundleName:  bundleName, onSuccess:  new Systems.AssetManagement.Bundles.BundleLoadSuccess(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192), onFailure:  new Systems.AssetManagement.Bundles.BundleLoadFailure(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 8));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string ClassName(System.Type type)
        {
            if(type != null)
            {
                    return "Systems.AssetManagement.Assets.AssetLoader<"("Systems.AssetManagement.Assets.AssetLoader<") + type + ">"(">");
            }
            
            return "Systems.AssetManagement.Assets.AssetLoader<"("Systems.AssetManagement.Assets.AssetLoader<") + type + ">"(">");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BundleLoadSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle)
        {
            bundle.LoadAssetAsync(name:  69750784, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})).add_completed(value:  new System.Action<UnityEngine.AsyncOperation>(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 24));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BundleLoadFailure(UnityEngine.CachedAssetBundle info)
        {
            if(this == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetLoadFromBundleComplete(UnityEngine.AsyncOperation request)
        {
            var val_3;
            var val_4;
            if(request != null)
            {
                    val_3 = request.asset;
            }
            else
            {
                    val_3 = 0;
            }
            
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            val_4 = val_3;
            if(val_4 != 0)
            {
                goto label_6;
            }
            
            label_5:
            val_4 = 0;
            label_6:
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetLoadSuccess(T asset)
        {
            if(8152 != 0)
            {
                    8152.Invoke(obj:  this);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetLoadFailure()
        {
            if(8150 != 0)
            {
                    8150.Invoke();
            }
            
            if(8150 != 0)
            {
                    8150.Invoke(obj:  this);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetLoader<T>(System.Action<T> onSuccess, System.Action onFailure, System.Action<Systems.AssetManagement.Assets.IAssetLoader> onComplete)
        {
            mem[1152921523436454712] = onSuccess;
            mem[1152921523436454720] = onFailure;
            mem[1152921523436454728] = onComplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearCallbacks()
        {
            mem[1152921523436579008] = 0;
            mem[1152921523436579016] = 0;
            mem[1152921523436579000] = 0;
        }
    
    }

}
