using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ImageryLayer : IImageryLayer, ILayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.ImageryLayerProperties _layerProperty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Factories.MapImageFactory _imageFactory;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImageryLayerProperties LayerProperty { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLayerType LayerType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLayerActive { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string LayerSource { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.MapImageFactory Factory { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImageryLayerProperties get_LayerProperty()
        {
            return (Mapbox.Unity.Map.ImageryLayerProperties)this._layerProperty;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapLayerType get_LayerType()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLayerActive()
        {
            return (bool)(this._layerProperty.sourceType != 7) ? 1 : 0;
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
        public void set_LayerSource(string value)
        {
            this._layerProperty.sourceOptions.layerSource.Id = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ImageryLayer()
        {
            this._layerProperty = new Mapbox.Unity.Map.ImageryLayerProperties();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ImageryLayer(Mapbox.Unity.Map.ImageryLayerProperties properties)
        {
            this._layerProperty = new Mapbox.Unity.Map.ImageryLayerProperties();
            this._layerProperty = properties;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLayerSource(Mapbox.Unity.Map.ImagerySourceType imageSource)
        {
            object val_6;
            if((imageSource & 4294967294) == 6)
            {
                    long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = imageSource});
                val_6 = "Invalid style - trying to set "("Invalid style - trying to set ") + imageSource.ToString() + " as default style!"(" as default style!");
                UnityEngine.Debug.LogWarning(message:  val_6);
                return;
            }
            
            this._layerProperty.sourceType = imageSource;
            val_6 = Mapbox.Unity.Map.MapboxDefaultImagery.GetParameters(defaultImagery:  imageSource);
            this._layerProperty.sourceOptions.layerSource = val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLayerSource(string imageSource)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  imageSource);
            if(this._layerProperty == null)
            {
                goto label_1;
            }
            
            if(val_1 == false)
            {
                goto label_2;
            }
            
            label_5:
            this._layerProperty.sourceType = 7;
            UnityEngine.Debug.LogWarning(message:  "Empty source - turning off imagery. ");
            return;
            label_1:
            if(val_1 == true)
            {
                goto label_5;
            }
            
            label_2:
            this._layerProperty.sourceType = 6;
            this._layerProperty.sourceOptions.layerSource.Id = imageSource;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetRasterOptions(Mapbox.Unity.Map.ImageryRasterOptions rasterOptions)
        {
            this._layerProperty.rasterOptions = rasterOptions;
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
            Mapbox.Unity.Map.ImageryLayerProperties val_3;
            if((this._layerProperty.sourceType == 6) || (this._layerProperty.sourceType == 7))
            {
                goto label_4;
            }
            
            val_3 = this._layerProperty;
            if(this._layerProperty != null)
            {
                goto label_5;
            }
            
            val_3 = this._layerProperty;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            label_5:
            this._layerProperty.sourceOptions.layerSource = Mapbox.Unity.Map.MapboxDefaultImagery.GetParameters(defaultImagery:  this._layerProperty.sourceType);
            label_4:
            Mapbox.Unity.MeshGeneration.Factories.MapImageFactory val_2 = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Factories.MapImageFactory>();
            this._imageFactory = val_2;
            if(val_2 != null)
            {
                goto typeof(Mapbox.Unity.MeshGeneration.Factories.MapImageFactory).__il2cppRuntimeField_168;
            }
            
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.MapImageFactory).__il2cppRuntimeField_168;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Remove()
        {
            .sourceType = 7;
            this._layerProperty = new Mapbox.Unity.Map.ImageryLayerProperties();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(Mapbox.Unity.Map.LayerProperties properties)
        {
            this.Initialize(properties:  properties);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Factories.MapImageFactory get_Factory()
        {
            return (Mapbox.Unity.MeshGeneration.Factories.MapImageFactory)this._imageFactory;
        }
    
    }

}
