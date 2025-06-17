using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GeometryExtrusionOptions : ModifierProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _selectedLayerName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ExtrusionType extrusionType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ExtrusionGeometryType extrusionGeometryType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string propertyName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string propertyDescription;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float minimumHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float maximumHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float extrusionScaleFactor;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type ModifierType { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Type get_ModifierType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeometryExtrusionOptions()
        {
            this.propertyName = "height";
            this.extrusionScaleFactor = 1f;
            this.propertyDescription = "";
        }
    
    }

}
