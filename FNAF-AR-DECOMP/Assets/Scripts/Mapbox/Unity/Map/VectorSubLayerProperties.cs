using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VectorSubLayerProperties : LayerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.CoreVectorLayerProperties coreOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorFilterOptions filterOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.GeometryExtrusionOptions extrusionOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ColliderOptions colliderOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.GeometryMaterialOptions materialOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerPerformanceOptions performanceOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool honorBuildingIdSetting;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool buildingsWithUniqueIds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Modifiers.PositionTargetType moveFeaturePositionTo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier> MeshModifiers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier> GoModifiers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.PresetFeatureType presetFeatureType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maskValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string selectedTypes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorSubLayerProperties()
        {
            this.coreOptions = new Mapbox.Unity.Map.CoreVectorLayerProperties();
            this.filterOptions = new Mapbox.Unity.Map.VectorFilterOptions();
            Mapbox.Unity.Map.GeometryExtrusionOptions val_3 = new Mapbox.Unity.Map.GeometryExtrusionOptions();
            if(val_3 != null)
            {
                    .extrusionType = 0;
                .propertyName = "height";
            }
            else
            {
                    mem[24] = 0;
                mem[32] = "height";
            }
            
            .extrusionGeometryType = 0;
            this.extrusionOptions = val_3;
            .colliderType = 0;
            this.colliderOptions = new Mapbox.Unity.Map.ColliderOptions();
            this.materialOptions = new Mapbox.Unity.Map.GeometryMaterialOptions();
            this.honorBuildingIdSetting = true;
            this.presetFeatureType = 4;
        }
    
    }

}
