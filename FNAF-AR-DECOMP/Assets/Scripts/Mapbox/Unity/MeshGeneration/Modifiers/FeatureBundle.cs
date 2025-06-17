using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class FeatureBundle
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool active;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject prefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool scaleDownWithWorld;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> _prefabLocations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> _explicitlyBlockedFeatureIds;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureBundle()
        {
            this.scaleDownWithWorld = true;
            this._prefabLocations = new System.Collections.Generic.List<System.String>();
            this._explicitlyBlockedFeatureIds = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
