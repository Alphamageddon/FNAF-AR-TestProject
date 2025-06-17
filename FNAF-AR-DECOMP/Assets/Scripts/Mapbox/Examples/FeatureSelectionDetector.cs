using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureSelectionDetector : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.FeatureUiMarker _marker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.VectorEntity _feature;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnMouseUpAsButton()
        {
            this._marker.Show(selectedFeature:  this._feature);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Initialize(Mapbox.Examples.FeatureUiMarker marker, Mapbox.Unity.MeshGeneration.Data.VectorEntity ve)
        {
            this._marker = marker;
            this._feature = ve;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureSelectionDetector()
        {
        
        }
    
    }

}
