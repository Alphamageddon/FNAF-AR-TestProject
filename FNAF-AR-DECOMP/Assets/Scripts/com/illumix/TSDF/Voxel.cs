using UnityEngine;

namespace com.illumix.TSDF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Voxel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float sdf;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float weight;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Voxel(float sdf, float weight)
        {
            this.sdf = sdf;
            this.weight = weight;
        }
    
    }

}
