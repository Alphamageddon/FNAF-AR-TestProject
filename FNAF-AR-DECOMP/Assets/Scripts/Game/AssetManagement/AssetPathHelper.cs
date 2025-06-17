using UnityEngine;

namespace Game.AssetManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AssetPathHelper
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string FilePrefix = "file://";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string TableOfContentsSuffix = "_TOC";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string StreamingAssetsBundleRoot;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetPathRoot()
        {
            null = null;
            return System.IO.Path.Combine(path1:  Game.AssetManagement.AssetPathHelper.StreamingAssetsBundleRoot, path2:  "Android");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetPlatformStringToC()
        {
            return "Android" + "_TOC";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetPlatformString()
        {
            return "Android";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AssetPathHelper()
        {
            Game.AssetManagement.AssetPathHelper.StreamingAssetsBundleRoot = System.IO.Path.Combine(path1:  UnityEngine.Application.streamingAssetsPath, path2:  "AssetBundles");
        }
    
    }

}
