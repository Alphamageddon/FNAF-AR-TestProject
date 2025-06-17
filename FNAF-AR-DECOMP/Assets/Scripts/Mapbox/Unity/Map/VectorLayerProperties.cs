using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VectorLayerProperties : LayerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.TileJsonData tileJsonData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.VectorSourceType _sourceType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerSourceOptions sourceOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useOptimizedStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.Style optimizedStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerPerformanceOptions performanceOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.Map.VectorSubLayerProperties> vectorSubLayers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions> locationPrefabList;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorSourceType sourceType { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorSourceType get_sourceType()
        {
            return (Mapbox.Unity.Map.VectorSourceType)this._sourceType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_sourceType(Mapbox.Unity.Map.VectorSourceType value)
        {
            if(value != 2)
            {
                    Mapbox.Unity.Map.Style val_1 = Mapbox.Unity.Map.MapboxDefaultVector.GetParameters(defaultElevation:  value);
                this.sourceOptions.Id = val_1.Id;
            }
            
            this.sourceOptions.isActive = (value != 3) ? 1 : 0;
            this._sourceType = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorLayerProperties()
        {
            Mapbox.Unity.Map.Style val_7;
            this.tileJsonData = new Mapbox.Unity.Map.TileJsonData();
            this._sourceType = 1;
            Mapbox.Unity.Map.LayerSourceOptions val_2 = new Mapbox.Unity.Map.LayerSourceOptions();
            if(val_2 != null)
            {
                    .isActive = 1;
                val_7 = Mapbox.Unity.Map.MapboxDefaultVector.GetParameters(defaultElevation:  1);
            }
            else
            {
                    mem[16] = 1;
                val_7 = Mapbox.Unity.Map.MapboxDefaultVector.GetParameters(defaultElevation:  1);
            }
            
            .layerSource = val_7;
            this.sourceOptions = val_2;
            this.vectorSubLayers = new System.Collections.Generic.List<Mapbox.Unity.Map.VectorSubLayerProperties>();
            this.locationPrefabList = new System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions>();
        }
    
    }

}
