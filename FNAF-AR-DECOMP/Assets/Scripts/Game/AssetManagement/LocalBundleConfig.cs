using UnityEngine;

namespace Game.AssetManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocalBundleConfig : ILocalBundleConfig
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLocalTableOfContentsPath()
        {
            return System.IO.Path.Combine(path1:  Game.AssetManagement.AssetPathHelper.GetPathRoot(), path2:  Game.AssetManagement.AssetPathHelper.GetPlatformStringToC());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLocalBundleUri(UnityEngine.CachedAssetBundle info)
        {
            return System.IO.Path.Combine(path1:  Game.AssetManagement.AssetPathHelper.GetPathRoot(), path2:  info.m_Name.emailUIDataHandler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocalBundleConfig()
        {
        
        }
    
    }

}
