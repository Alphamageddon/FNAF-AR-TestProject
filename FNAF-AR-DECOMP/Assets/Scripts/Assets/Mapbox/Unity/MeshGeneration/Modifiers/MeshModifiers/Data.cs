using UnityEngine;

namespace Assets.Mapbox.Unity.MeshGeneration.Modifiers.MeshModifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Data
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<float> Vertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<int> Holes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Dim;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Data()
        {
            this.Holes = new System.Collections.Generic.List<System.Int32>();
            this.Dim = 2;
        }
    
    }

}
