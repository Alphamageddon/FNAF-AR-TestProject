using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GeometryExtrusionWithAtlasOptions : ModifierProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.UvMapType texturingType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.AtlasInfo atlasInfo;
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
        public GeometryExtrusionWithAtlasOptions()
        {
            this.propertyName = "height";
            this.extrusionScaleFactor = 1f;
            this.propertyDescription = "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeometryExtrusionWithAtlasOptions(Mapbox.Unity.Map.GeometryExtrusionOptions extrusionOptions, Mapbox.Unity.Map.UVModifierOptions uvOptions)
        {
            this.propertyName = "height";
            this.extrusionScaleFactor = 1f;
            this.propertyDescription = "";
            val_1 = new Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties();
            if(extrusionOptions != null)
            {
                    this.extrusionType = extrusionOptions.extrusionType;
                this.extrusionGeometryType = extrusionOptions.extrusionGeometryType;
                this.propertyName = extrusionOptions.propertyName;
                this.minimumHeight = extrusionOptions.minimumHeight;
                this.maximumHeight = extrusionOptions.maximumHeight;
            }
            else
            {
                    this.extrusionType = 15026800;
                this.extrusionGeometryType = 0;
                this.propertyName = 64;
                this.minimumHeight = 0f;
                this.maximumHeight = 5.142877E-39f;
            }
            
            this.extrusionScaleFactor = extrusionOptions.extrusionScaleFactor;
            if(val_1 != null)
            {
                    this.texturingType = uvOptions.texturingType;
            }
            else
            {
                    this.texturingType = 1;
            }
            
            this.atlasInfo = uvOptions.atlasInfo;
        }
    
    }

}
