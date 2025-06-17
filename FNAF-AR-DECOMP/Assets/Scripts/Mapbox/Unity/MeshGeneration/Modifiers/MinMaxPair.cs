using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MinMaxPair
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float min;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float max;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.MeshGeneration.Modifiers.MinMaxPair GetMinMaxHeight(System.Collections.Generic.List<UnityEngine.Vector3> vertices)
        {
            var val_6;
            int val_1 = vertices.Count;
            Mapbox.Unity.MeshGeneration.Modifiers.MinMaxPair val_2 = new Mapbox.Unity.MeshGeneration.Modifiers.MinMaxPair();
            if(val_2 != null)
            {
                    val_6 = val_2;
                .max = -3.402823E+38f;
            }
            else
            {
                    val_6 = val_2;
                .max = -3.402823E+38f;
            }
            
            .min = -1.175494E-38f;
            if(val_1 < 1)
            {
                    return val_2;
            }
            
            var val_6 = 0;
            do
            {
                UnityEngine.Vector3 val_3 = vertices.Item[0];
                UnityEngine.Vector3 val_4 = vertices.Item[0];
                if(val_3.y > .max)
            {
                    mem[1152921519703751572] = val_4.y;
            }
            else
            {
                    if(val_4.y < 0)
            {
                    UnityEngine.Vector3 val_5 = vertices.Item[0];
                .min = val_5.y;
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_1 != val_6);
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MinMaxPair()
        {
        
        }
    
    }

}
