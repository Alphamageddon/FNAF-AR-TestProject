using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VectorFilterOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _selectedLayerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Filters.LayerFilter> filters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Filters.LayerFilterCombinerOperationType combinerType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorFilterOptions()
        {
            this.filters = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Filters.LayerFilter>();
            this.combinerType = 1;
        }
    
    }

}
