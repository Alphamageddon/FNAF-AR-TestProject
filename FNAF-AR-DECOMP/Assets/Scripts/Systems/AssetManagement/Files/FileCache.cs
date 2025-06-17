using UnityEngine;

namespace Systems.AssetManagement.Files
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FileCache : AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache>, IFileCache
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Files.FileLoader _fileLoader;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.AssetManagement.Files.IFileCache GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.AssetManagement.Files.IFileCache get_GetPublicInterface()
        {
            return (Systems.AssetManagement.Files.IFileCache)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadFileFromPath(Systems.AssetManagement.Files.FileLoadSettings settings)
        {
            if(settings == null)
            {
                    return;
            }
            
            this._fileLoader.LoadFileFromPath(settings:  settings);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FileCache(UnityEngine.GameObject parent)
        {
            this._fileLoader = parent.AddComponent<Systems.AssetManagement.Files.FileLoader>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._fileLoader = 0;
        }
    
    }

}
