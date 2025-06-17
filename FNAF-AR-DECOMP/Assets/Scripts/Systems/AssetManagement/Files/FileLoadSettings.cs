using UnityEngine;

namespace Systems.AssetManagement.Files
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FileLoadSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FilePath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<Systems.AssetManagement.Files.FileLoadSettings, byte[]> ByteLoadSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<Systems.AssetManagement.Files.FileLoadSettings, UnityEngine.Networking.DownloadHandler> FileLoadSuccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<Systems.AssetManagement.Files.FileLoadSettings> FileLoadFailure;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FileLoadSettings()
        {
        
        }
    
    }

}
