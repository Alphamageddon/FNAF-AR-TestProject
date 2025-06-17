using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.ObjectTracking
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct TileUpdateInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int planeId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 tileKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isAdd;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileUpdateInfo(int planeId, UnityEngine.Vector2 tileKey, bool isAdd)
        {
            mem[1152921523073604608] = planeId;
            mem[1152921523073604612] = tileKey.x;
            mem[1152921523073604616] = tileKey.y;
            mem[1152921523073604620] = isAdd;
        }
    
    }

}
