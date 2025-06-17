using UnityEngine;

namespace Systems.AssetManagement.Bundles.Config
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface ILocalBundleConfig
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetLocalTableOfContentsPath(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetLocalBundleUri(UnityEngine.CachedAssetBundle info); // 0
    
    }

}
