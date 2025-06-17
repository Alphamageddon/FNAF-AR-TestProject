using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class VectorLayer : IVectorDataLayer, ILayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.VectorLayerProperties _layerProperty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory _vectorTileFactory;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorLayerProperties LayerProperty { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLayerType LayerType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLayerActive { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LayerSource { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory Factory { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions> PointsOfInterestSublayerList { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorLayerProperties get_LayerProperty()
        {
            return (Mapbox.Unity.Map.VectorLayerProperties)this._layerProperty;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLayerType get_LayerType()
        {
            return 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLayerActive()
        {
            return (bool)(this._layerProperty._sourceType != 3) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_LayerSource()
        {
            if(this._layerProperty.sourceOptions != null)
            {
                    return this._layerProperty.sourceOptions.Id;
            }
            
            return this._layerProperty.sourceOptions.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLayerSource(Mapbox.Unity.Map.VectorSourceType vectorSource)
        {
            object val_6;
            if((vectorSource & 4294967294) == 2)
            {
                    long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = vectorSource});
                val_6 = "Invalid style - trying to set "("Invalid style - trying to set ") + vectorSource.ToString() + " as default style!"(" as default style!");
                UnityEngine.Debug.LogWarning(message:  val_6);
                return;
            }
            
            this._layerProperty.sourceType = vectorSource;
            val_6 = Mapbox.Unity.Map.MapboxDefaultVector.GetParameters(defaultElevation:  vectorSource);
            this._layerProperty.sourceOptions.layerSource = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLayerSource(string vectorSource)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  vectorSource);
            if(this._layerProperty == null)
            {
                goto label_1;
            }
            
            if(val_1 == false)
            {
                goto label_2;
            }
            
            label_5:
            this._layerProperty.sourceType = 3;
            UnityEngine.Debug.LogWarning(message:  "Empty source - turning off vector data. ");
            return;
            label_1:
            if(val_1 == true)
            {
                goto label_5;
            }
            
            label_2:
            this._layerProperty.sourceOptions.isActive = true;
            this._layerProperty._sourceType = 2;
            this._layerProperty.sourceOptions.Id = vectorSource;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddLayerSource(string vectorSource)
        {
            string val_8;
            if((System.String.IsNullOrEmpty(value:  vectorSource)) != false)
            {
                    UnityEngine.Debug.LogError(message:  "Empty source. Nothing was added to the list of data sources");
                return;
            }
            
            if((this._layerProperty.sourceOptions.Id.Contains(value:  vectorSource)) != false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this._layerProperty.sourceOptions.Id)) != false)
            {
                    val_8 = vectorSource;
            }
            else
            {
                    val_8 = this._layerProperty.sourceOptions.Id + "," + vectorSource;
            }
            
            this.SetLayerSource(vectorSource:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddVectorLayer(Mapbox.Unity.Map.VectorSubLayerProperties subLayerProperties)
        {
            if(this._layerProperty.vectorSubLayers == null)
            {
                    System.Collections.Generic.List<Mapbox.Unity.Map.VectorSubLayerProperties> val_1 = null;
                this._layerProperty = val_1;
                val_1 = new System.Collections.Generic.List<Mapbox.Unity.Map.VectorSubLayerProperties>();
                this._layerProperty.vectorSubLayers = this._layerProperty;
            }
            
            this._layerProperty.vectorSubLayers.Add(item:  subLayerProperties);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddLocationPrefabItem(Mapbox.Unity.Map.PrefabItemOptions prefabItem)
        {
            if(this._layerProperty.locationPrefabList == null)
            {
                    this._layerProperty.locationPrefabList = new System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions>();
            }
            
            if((this._layerProperty.locationPrefabList.Contains(item:  prefabItem)) != false)
            {
                    return;
            }
            
            this._layerProperty.locationPrefabList.Add(item:  prefabItem);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveVectorLayer(int index)
        {
            if(this._layerProperty.vectorSubLayers == null)
            {
                    return;
            }
            
            this._layerProperty.vectorSubLayers.RemoveAt(index:  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemovePrefabItem(int index)
        {
            if(this._layerProperty.locationPrefabList == null)
            {
                    return;
            }
            
            this._layerProperty.locationPrefabList.RemoveAt(index:  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(Mapbox.Unity.Map.LayerProperties properties)
        {
            Mapbox.Unity.Map.LayerProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._layerProperty = val_3;
            this.Initialize();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize()
        {
            Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory val_1 = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory>();
            this._vectorTileFactory = val_1;
            if(val_1 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Remove()
        {
            Mapbox.Unity.Map.VectorLayerProperties val_1 = new Mapbox.Unity.Map.VectorLayerProperties();
            val_1.sourceType = 3;
            this._layerProperty = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(Mapbox.Unity.Map.LayerProperties properties)
        {
            this.Initialize(properties:  properties);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory get_Factory()
        {
            return (Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory)this._vectorTileFactory;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions> get_PointsOfInterestSublayerList()
        {
            if(this._layerProperty != null)
            {
                    return (System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions>)this._layerProperty.locationPrefabList;
            }
            
            return (System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions>)this._layerProperty.locationPrefabList;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PointsOfInterestSublayerList(System.Collections.Generic.List<Mapbox.Unity.Map.PrefabItemOptions> value)
        {
            this._layerProperty.locationPrefabList = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorLayer()
        {
            this._layerProperty = new Mapbox.Unity.Map.VectorLayerProperties();
        }
    
    }

}
