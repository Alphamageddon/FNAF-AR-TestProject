using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct TileInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 tileKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int planeId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileInfo(UnityEngine.Vector2 tileKey, int planeId)
        {
            mem[1152921523145628928] = tileKey.x;
            mem[1152921523145628932] = tileKey.y;
            mem[1152921523145628936] = planeId;
        }
    
    }

}
