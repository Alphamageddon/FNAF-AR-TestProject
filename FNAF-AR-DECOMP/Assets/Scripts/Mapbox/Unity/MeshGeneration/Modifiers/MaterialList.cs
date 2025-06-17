using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MaterialList
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material[] Materials;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MaterialList()
        {
            this.Materials = new UnityEngine.Material[1];
        }
    
    }

}
