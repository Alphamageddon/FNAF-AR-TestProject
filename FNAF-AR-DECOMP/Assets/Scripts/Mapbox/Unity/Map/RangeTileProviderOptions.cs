using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RangeTileProviderOptions : ITileProviderOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int west;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int north;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int east;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int south;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetOptions(int northRange, int southRange, int eastRange, int westRange)
        {
            this.west = westRange;
            this.north = northRange;
            this.east = eastRange;
            this.south = southRange;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeTileProviderOptions()
        {
            this.west = 1;
            this.north = 0;
            this.east = 1;
            this.south = 0;
        }
    
    }

}
