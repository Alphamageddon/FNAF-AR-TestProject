using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TerrainLayer : ITerrainLayer, ILayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.ElevationLayerProperties _layerProperty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase _elevationFactory;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationLayerProperties LayerProperty { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLayerType LayerType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLayerActive { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LayerSource { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory Factory { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ElevationLayerProperties get_LayerProperty()
        {
            return (Mapbox.Unity.Map.ElevationLayerProperties)this._layerProperty;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLayerType get_LayerType()
        {
            return 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLayerActive()
        {
            return (bool)(this._layerProperty.sourceType != 2) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_LayerSource()
        {
            if(this._layerProperty.sourceOptions.layerSource != null)
            {
                    return (string)this._layerProperty.sourceOptions.layerSource.Id;
            }
            
            return (string)this._layerProperty.sourceOptions.layerSource.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TerrainLayer()
        {
            this._layerProperty = new Mapbox.Unity.Map.ElevationLayerProperties();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TerrainLayer(Mapbox.Unity.Map.ElevationLayerProperties properties)
        {
            this._layerProperty = new Mapbox.Unity.Map.ElevationLayerProperties();
            this._layerProperty = properties;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLayerSource(Mapbox.Unity.Map.ElevationSourceType terrainSource)
        {
            object val_6;
            if((terrainSource - 1) < 2)
            {
                    long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = terrainSource});
                val_6 = "Invalid style - trying to set "("Invalid style - trying to set ") + terrainSource.ToString() + " as default style!"(" as default style!");
                UnityEngine.Debug.LogWarning(message:  val_6);
                return;
            }
            
            this._layerProperty.sourceType = terrainSource;
            val_6 = Mapbox.Unity.Map.MapboxDefaultElevation.GetParameters(defaultElevation:  terrainSource);
            this._layerProperty.sourceOptions.layerSource = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLayerSource(string terrainSource)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  terrainSource);
            if(this._layerProperty == null)
            {
                goto label_1;
            }
            
            if(val_1 == false)
            {
                goto label_2;
            }
            
            label_6:
            this._layerProperty.sourceType = 2;
            this._layerProperty.elevationLayerType = 0;
            UnityEngine.Debug.LogWarning(message:  "Empty source - turning off terrain. ");
            return;
            label_1:
            if(val_1 == true)
            {
                goto label_6;
            }
            
            label_2:
            this._layerProperty.sourceType = 1;
            this._layerProperty.sourceOptions.layerSource.Id = terrainSource;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetTerrainOptions(Mapbox.Unity.Map.ElevationLayerType type, Mapbox.Unity.Map.ElevationRequiredOptions requiredOptions, Mapbox.Unity.Map.ElevationModificationOptions modificationOptions)
        {
            this._layerProperty.elevationLayerType = type;
            UnityEngine.Debug.Log(message:  "Terrain Type : "("Terrain Type : ") + this._layerProperty.elevationLayerType);
            if(requiredOptions != null)
            {
                    this._layerProperty.requiredOptions = requiredOptions;
            }
            
            if(modificationOptions == null)
            {
                    return;
            }
            
            this._layerProperty.modificationOptions = modificationOptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSideWalls(float wallHeight, UnityEngine.Material wallMaterial)
        {
            this._layerProperty.sideWallOptions.isActive = true;
            this._layerProperty.sideWallOptions.wallHeight = wallHeight;
            this._layerProperty.sideWallOptions.wallMaterial = wallMaterial;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddToUnityLayer(int layerId)
        {
            this._layerProperty.unityLayerOptions.addToLayer = true;
            this._layerProperty.unityLayerOptions.layerId = layerId;
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
            this._elevationFactory = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase>();
            if(this._layerProperty.elevationLayerType > 3)
            {
                goto label_2;
            }
            
            var val_7 = 52951948 + (this._layerProperty.elevationLayerType) << 2;
            val_7 = val_7 + 52951948;
            goto (52951948 + (this._layerProperty.elevationLayerType) << 2 + 52951948);
            label_13:
            this._elevationFactory.Strategy = ;
            label_2:
            this = ???;
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.TerrainFactoryBase).__il2cppRuntimeField_168;
            label_14:
            if((val_7 + 16 + 64 + 16) == 0)
            {
                goto label_8;
            }
            
            Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies.ElevatedTerrainWithSidesStrategy val_4 = new Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies.ElevatedTerrainWithSidesStrategy();
            if((val_7 + 24) != 0)
            {
                goto label_13;
            }
            
            goto label_14;
            label_8:
            Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies.ElevatedTerrainStrategy val_6 = new Mapbox.Unity.MeshGeneration.Factories.TerrainStrategies.ElevatedTerrainStrategy();
            if((val_7 + 24) != 0)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Remove()
        {
            .sourceType = 2;
            this._layerProperty = new Mapbox.Unity.Map.ElevationLayerProperties();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(Mapbox.Unity.Map.LayerProperties properties)
        {
            this.Initialize(properties:  properties);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory get_Factory()
        {
            return (Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory)this._elevationFactory;
        }
    
    }

}
