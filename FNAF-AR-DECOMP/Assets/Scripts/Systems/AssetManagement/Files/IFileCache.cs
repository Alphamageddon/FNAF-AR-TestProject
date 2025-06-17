using UnityEngine;

namespace Systems.AssetManagement.Files
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IFileCache
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LoadFileFromPath(Systems.AssetManagement.Files.FileLoadSettings settings); // 0
    
    }

}
