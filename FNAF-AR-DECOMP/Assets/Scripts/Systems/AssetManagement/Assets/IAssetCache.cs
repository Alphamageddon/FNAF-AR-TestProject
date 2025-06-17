using UnityEngine;

namespace Systems.AssetManagement.Assets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAssetCache
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void DoesBundleContainAsset(string bundleName, string assetName, System.Action<bool> result); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LoadAssetAsync<T>(string assetName, string bundleName, System.Action<T> onSuccess, System.Action onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ReleaseAsset(string bundleName, string assetName); // 0
    
    }

}
