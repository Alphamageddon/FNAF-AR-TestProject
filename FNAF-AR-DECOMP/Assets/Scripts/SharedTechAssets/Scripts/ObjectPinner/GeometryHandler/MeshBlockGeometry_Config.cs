using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.GeometryHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MeshBlockGeometry_Config : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject meshPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float resolution;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MeshBlockGeometry_Config()
        {
            this.resolution = 0.05f;
        }
    
    }

}
