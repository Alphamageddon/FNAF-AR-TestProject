using UnityEngine;

namespace Game.AssetManagement.Icons
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IIconLookup
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Sprite GetDefaultIcon(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract UnityEngine.Sprite GetIcon(Game.AssetManagement.Icons.IconGroup group, string name); // 0
    
    }

}
