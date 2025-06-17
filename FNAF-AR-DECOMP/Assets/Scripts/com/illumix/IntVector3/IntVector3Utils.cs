using UnityEngine;

namespace com.illumix.IntVector3
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IntVector3Utils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Vector3 IntVectorToVertexPosition(com.illumix.IntVector3.IntVector3 intVertex, float resolution)
        {
            int val_1;
            int val_2;
            if(intVertex != null)
            {
                    val_1 = intVertex.<Item1>k__BackingField;
                val_2 = intVertex.<Item2>k__BackingField;
            }
            else
            {
                    val_1 = 11993091;
                val_2 = 1;
            }
            
            float val_1 = 1.199309E+07f;
            float val_2 = 1f;
            float val_3 = (float)intVertex.<Item3>k__BackingField;
            val_1 = val_1 * resolution;
            val_2 = val_2 * resolution;
            val_3 = val_3 * resolution;
            val_1 = val_1 * 0.5f;
            val_2 = val_2 * 0.5f;
            val_3 = val_3 * 0.5f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IntVector3Utils()
        {
        
        }
    
    }

}
