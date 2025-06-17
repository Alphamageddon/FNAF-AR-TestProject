using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorEntity
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject GameObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter MeshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Mesh Mesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshRenderer MeshRenderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity Feature;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Transform;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorEntity()
        {
        
        }
    
    }

}
