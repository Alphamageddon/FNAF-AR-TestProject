using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AbstractMap : MonoBehaviour, IMap, IMapReadable, IMapWritable, IUnifiedMap
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initializeOnStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.MapOptions _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.ImageryLayer _imagery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.TerrainLayer _terrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.VectorLayer _vectorData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.AbstractTileProvider _tileProvider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> _currentExtent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.AbstractMapVisualizer _mapVisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float _unityTileSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int _initialZoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool _worldHeightFixed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.MapboxAccess _fileSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Utils.Vector2d _centerLatitudeLongitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Utils.Vector2d _centerMercator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float _worldRelativeScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _mapScaleFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnUpdated;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool InitializeOnStart { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapOptions Options { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImageryLayer ImageLayer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.TerrainLayer Terrain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorLayer VectorData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractTileProvider TileProvider { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> CurrentExtent { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMapVisualizer MapVisualizer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float UnityTileSize { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int AbsoluteZoom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitialZoom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d CenterLatitudeLongitude { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d CenterMercator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float WorldRelativeScale { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Zoom { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Root { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAccessTokenValid { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_InitializeOnStart()
        {
            return (bool)this._initializeOnStart;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_InitializeOnStart(bool value)
        {
            this._initializeOnStart = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapOptions get_Options()
        {
            return (Mapbox.Unity.Map.MapOptions)this._options;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Options(Mapbox.Unity.Map.MapOptions value)
        {
            this._options = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ImageryLayer get_ImageLayer()
        {
            return (Mapbox.Unity.Map.ImageryLayer)this._imagery;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.TerrainLayer get_Terrain()
        {
            return (Mapbox.Unity.Map.TerrainLayer)this._terrain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.VectorLayer get_VectorData()
        {
            return (Mapbox.Unity.Map.VectorLayer)this._vectorData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractTileProvider get_TileProvider()
        {
            return (Mapbox.Unity.Map.AbstractTileProvider)this._tileProvider;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TileProvider(Mapbox.Unity.Map.AbstractTileProvider value)
        {
            if(this._tileProvider != 0)
            {
                    this._tileProvider.remove_ExtentChanged(value:  new System.EventHandler<Mapbox.Unity.Map.ExtentArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.AbstractMap::OnMapExtentChanged(object sender, Mapbox.Unity.Map.ExtentArgs currentExtent)));
            }
            
            this._tileProvider = value;
            value.add_ExtentChanged(value:  new System.EventHandler<Mapbox.Unity.Map.ExtentArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.AbstractMap::OnMapExtentChanged(object sender, Mapbox.Unity.Map.ExtentArgs currentExtent)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> get_CurrentExtent()
        {
            return (System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>)this._currentExtent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TriggerTileRedrawForExtent(Mapbox.Unity.Map.ExtentArgs currentExtent)
        {
            var val_23;
            this._currentExtent = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>(collection:  currentExtent.activeTiles);
            this._mapVisualizer.State = 1;
            System.Collections.Generic.List<Mapbox.Map.UnwrappedTileId> val_2 = new System.Collections.Generic.List<Mapbox.Map.UnwrappedTileId>();
            Dictionary.Enumerator<TKey, TValue> val_3 = this._mapVisualizer._activeTiles.GetEnumerator();
            label_9:
            if(((-1976646416) & 1) == 0)
            {
                goto label_5;
            }
            
            if((this._currentExtent.Contains(item:  new Mapbox.Map.UnwrappedTileId() {Z = -1976646448, X = 268435459, Y = -1976683872})) == true)
            {
                goto label_9;
            }
            
            val_2.Add(item:  new Mapbox.Map.UnwrappedTileId() {Z = -1976646448, X = 268435459, Y = -1976683872});
            goto label_9;
            label_5:
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519810069744});
            List.Enumerator<T> val_12 = val_2.GetEnumerator();
            label_20:
            if(((-1976646480) & 1) == 0)
            {
                goto label_19;
            }
            
            goto label_20;
            label_19:
            val_23 = 0;
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519810069680});
            if(((174 == 0) ? 174 : 174) != 174)
            {
                goto label_24;
            }
            
            if(this._mapVisualizer._activeTiles != null)
            {
                goto label_28;
            }
            
            goto label_26;
            label_24:
            if( != 0)
            {
                    val_23 = 0;
            }
            
            if(this._mapVisualizer._activeTiles != null)
            {
                goto label_28;
            }
            
            label_26:
            label_28:
            Dictionary.Enumerator<TKey, TValue> val_15 = this._mapVisualizer._activeTiles.GetEnumerator();
            label_30:
            if(((-1976646416) & 1) == 0)
            {
                goto label_31;
            }
            
            goto label_30;
            label_31:
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519810069744});
            if(((230 == 0) ? 230 : 230) == 230)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_23 = 0;
            }
            
            }
            
            HashSet.Enumerator<T> val_20 = this._currentExtent.GetEnumerator();
            do
            {
                label_42:
                if(((-1976646544) & 1) == 0)
            {
                goto label_43;
            }
            
            }
            while((this._mapVisualizer._activeTiles.ContainsKey(key:  new Mapbox.Map.UnwrappedTileId() {Z = -1976646544, X = 268435459, Y = -1976665440})) == true);
            
            goto label_42;
            label_43:
            long val_22 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519810069616});
            if( == 0)
            {
                    return;
            }
            
            if(297 == 0)
            {
                    return;
            }
            
            if(297 == 297)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMapExtentChanged(object sender, Mapbox.Unity.Map.ExtentArgs currentExtent)
        {
            this.TriggerTileRedrawForExtent(currentExtent:  currentExtent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMapVisualizer get_MapVisualizer()
        {
            return (Mapbox.Unity.Map.AbstractMapVisualizer)this._mapVisualizer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MapVisualizer(Mapbox.Unity.Map.AbstractMapVisualizer value)
        {
            this._mapVisualizer = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_UnityTileSize()
        {
            return (float)this._unityTileSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_AbsoluteZoom()
        {
            return (int)null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_InitialZoom()
        {
            return (int)this._initialZoom;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_CenterLatitudeLongitude()
        {
            return new Mapbox.Utils.Vector2d() {x = this._centerLatitudeLongitude};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_CenterMercator()
        {
            return new Mapbox.Utils.Vector2d() {x = this._centerMercator};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_WorldRelativeScale()
        {
            return (float)this._worldRelativeScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Zoom()
        {
            if(this._options.locationOptions != null)
            {
                    return (float)this._options.locationOptions.zoom;
            }
            
            return (float)this._options.locationOptions.zoom;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetZoom(float zoom)
        {
            this._options.locationOptions.zoom = zoom;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform get_Root()
        {
            return this.transform;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isInitialized()
        {
            return (bool)this._isInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCenterMercator(Mapbox.Utils.Vector2d centerMercator)
        {
            this._centerMercator = centerMercator;
            mem[1152921519811772904] = centerMercator.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCenterLatitudeLongitude(Mapbox.Utils.Vector2d centerLatitudeLongitude)
        {
            this._options.locationOptions.latitudeLongitude = System.String.Format(format:  "{0}, {1}", arg0:  centerLatitudeLongitude.x, arg1:  centerLatitudeLongitude.y);
            this._centerLatitudeLongitude = centerLatitudeLongitude;
            mem[1152921519811905464] = centerLatitudeLongitude.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWorldRelativeScale(float scale)
        {
            this._worldRelativeScale = scale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsAccessTokenValid()
        {
            var val_7;
            Mapbox.Unity.MapboxAccess val_1 = Mapbox.Unity.MapboxAccess.Instance;
            if(Mapbox.Unity.MapboxAccess.Instance.Configuration == null)
            {
                goto label_2;
            }
            
            Mapbox.Unity.MapboxConfiguration val_5 = Mapbox.Unity.MapboxAccess.Instance.Configuration;
            if((System.String.IsNullOrEmpty(value:  val_5.AccessToken)) == false)
            {
                goto label_5;
            }
            
            label_2:
            val_7 = 0;
            return (bool)val_7;
            label_5:
            val_7 = 1;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnInitialized(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnInitialized, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnInitialized != 1152921519812323432);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnInitialized(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnInitialized, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnInitialized != 1152921519812460008);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdated != 1152921519812596592);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdated(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdated != 1152921519812733168);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            this._mapVisualizer = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.Map.MapVisualizer>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Start()
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "SetupAccess");
            if(this._initializeOnStart == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_2D8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.IEnumerator SetupAccess()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AbstractMap.<SetupAccess>d__71();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void SetUpMap()
        {
            Mapbox.Unity.Map.MapPlacementOptions val_15;
            var val_16;
            Mapbox.Unity.Map.MapScalingOptions val_17;
            var val_18;
            var val_19;
            var val_20;
            Mapbox.Unity.Map.ImageryLayer val_21;
            Mapbox.Unity.Map.TerrainLayer val_22;
            Mapbox.Unity.Map.VectorLayer val_23;
            if(this._options.placementOptions.placementType != 1)
            {
                    val_15 = this._options.placementOptions;
                val_16 = 1152921505118240768;
            }
            else
            {
                    val_15 = this._options.placementOptions;
                val_16 = 1152921505118294016;
            }
            
            if(val_15 == null)
            {
                goto label_15;
            }
            
            this._options.placementOptions.placementStrategy = new Mapbox.Unity.Map.MapPlacementAtLocationCenterStrategy();
            if(this._options.scalingOptions.scalingType == 1)
            {
                goto label_10;
            }
            
            if(this._options.scalingOptions.scalingType != 0)
            {
                goto label_11;
            }
            
            val_17 = this._options.scalingOptions;
            val_18 = 1152921505118081024;
            goto label_13;
            label_10:
            val_17 = this._options.scalingOptions;
            val_18 = 1152921505118134272;
            label_13:
            if(val_17 == null)
            {
                goto label_15;
            }
            
            this._options.scalingOptions.scalingStrategy = new Mapbox.Unity.Map.MapScalingAtUnityScaleStrategy();
            label_11:
            if(this._options.extentOptions.extentType != 3)
            {
                goto label_18;
            }
            
            this.TileProvider = this._tileProvider;
            goto label_19;
            label_18:
            Mapbox.Unity.Map.ITileProviderOptions val_3 = this._options.extentOptions.GetTileProviderOptions();
            if(this._options.extentOptions.extentType == 2)
            {
                goto label_24;
            }
            
            if(this._options.extentOptions.extentType == 1)
            {
                goto label_25;
            }
            
            if(this._options.extentOptions.extentType != 0)
            {
                goto label_26;
            }
            
            val_19 = this.gameObject;
            val_20 = 1152921519813305568;
            goto label_30;
            label_24:
            val_19 = this.gameObject;
            val_20 = 1152921519813310688;
            goto label_30;
            label_25:
            val_19 = this.gameObject;
            val_20 = 1152921519813315808;
            label_30:
            this.TileProvider = val_19.AddComponent<Mapbox.Unity.Map.RangeTileProvider>();
            label_26:
            label_19:
            val_21 = this._imagery;
            if(val_21 == null)
            {
                    Mapbox.Unity.Map.ImageryLayer val_8 = null;
                val_21 = val_8;
                val_8 = new Mapbox.Unity.Map.ImageryLayer();
                this._imagery = val_21;
            }
            
            val_8.Initialize();
            val_22 = this._terrain;
            if(val_22 == null)
            {
                    Mapbox.Unity.Map.TerrainLayer val_9 = null;
                val_22 = val_9;
                val_9 = new Mapbox.Unity.Map.TerrainLayer();
                this._terrain = val_22;
            }
            
            val_9.Initialize();
            val_23 = this._vectorData;
            if(val_23 == null)
            {
                    Mapbox.Unity.Map.VectorLayer val_10 = null;
                val_23 = val_10;
                val_10 = new Mapbox.Unity.Map.VectorLayer();
                this._vectorData = val_23;
            }
            
            val_10.Initialize();
            if(this._options.loadingTexture != 0)
            {
                    this._mapVisualizer._loadingTexture = this._options.loadingTexture;
            }
            
            if(this._options.tileMaterial != 0)
            {
                    this._mapVisualizer.TileMaterial = this._options.tileMaterial;
            }
            
            this._mapVisualizer.Factories = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory>();
            this._mapVisualizer.Factories.Add(item:  this._terrain._elevationFactory);
            this._mapVisualizer.Factories.Add(item:  this._imagery._imageFactory);
            this._mapVisualizer.Factories.Add(item:  this._vectorData.Factory);
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_2F8;
            label_15:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            UnityEngine.Object val_3 = 0;
            if(this._tileProvider != val_3)
            {
                    System.EventHandler<Mapbox.Unity.Map.ExtentArgs> val_2 = new System.EventHandler<Mapbox.Unity.Map.ExtentArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.AbstractMap::OnMapExtentChanged(object sender, Mapbox.Unity.Map.ExtentArgs currentExtent));
                val_3 = val_2;
                this._tileProvider.remove_ExtentChanged(value:  val_2);
            }
            
            if(this._mapVisualizer == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void InitializeMap(Mapbox.Unity.Map.MapOptions options)
        {
            var val_6;
            this._options = options;
            this._isInitialized = true;
            this._worldHeightFixed = false;
            this._fileSource = Mapbox.Unity.MapboxAccess.Instance;
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  options.locationOptions.latitudeLongitude);
            this._centerLatitudeLongitude = val_2;
            mem[1152921519814042168] = val_2.y;
            this._initialZoom = (int)options.locationOptions.zoom;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = public System.Void Mapbox.Unity.Map.IMapScalingStrategy::SetUpScaling(Mapbox.Unity.Map.AbstractMap map);
            options.scalingOptions.scalingStrategy.SetUpScaling(map:  this);
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = 0;
            options.placementOptions.placementStrategy.SetUpPlacement(map:  this);
            this.SendInitialized();
            if(this._tileProvider == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize(Mapbox.Utils.Vector2d latLon, int zoom)
        {
            Mapbox.Unity.Map.MapOptions val_4 = this._options;
            this._initializeOnStart = false;
            if(val_4 != null)
            {
                goto label_1;
            }
            
            Mapbox.Unity.Map.MapOptions val_1 = null;
            val_4 = val_1;
            val_1 = new Mapbox.Unity.Map.MapOptions();
            this._options = val_4;
            if(val_4 == null)
            {
                goto label_2;
            }
            
            label_1:
            (Mapbox.Unity.Map.MapOptions)[1152921519814280384].locationOptions.latitudeLongitude = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0},{1}", arg0:  latLon.x, arg1:  latLon.y);
            this._options.locationOptions.zoom = (float)zoom;
            return;
            label_2:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void UpdateMap()
        {
            float val_1 = this.Zoom;
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_348;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void UpdateMap(Mapbox.Utils.Vector2d latLon)
        {
            float val_1 = this.Zoom;
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_348;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void UpdateMap(float zoom)
        {
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_348;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void UpdateMap(Mapbox.Utils.Vector2d latLon, float zoom)
        {
            float val_16;
            var val_17;
            double val_18;
            double val_20;
            double val_21;
            var val_24;
            Mapbox.Unity.Map.AbstractMap val_26;
            float val_1 = this.Zoom;
            val_1 = val_1 - zoom;
            if(System.Math.Abs(val_1) > (1E-05f))
            {
                    this.SetZoom(zoom:  zoom);
                val_16 = this.Zoom - (float)this._initialZoom;
                var val_3 = (val_16 < 0) ? 1 : 0;
            }
            else
            {
                    val_17 = 0;
                val_16 = 0f;
            }
            
            if(latLon.x > 0f)
            {
                    val_18 = latLon.x;
                double val_4 = Mapbox.Utils.Mathd.Min(a:  val_18, b:  85.0511);
            }
            else
            {
                    val_18 = latLon.x;
            }
            
            val_20 = Mapbox.Utils.Mathd.Max(a:  val_18, b:  -85.0511);
            if(latLon.y > 0f)
            {
                    val_21 = latLon.y;
                double val_6 = Mapbox.Utils.Mathd.Min(a:  val_21, b:  180);
            }
            else
            {
                    val_21 = latLon.y;
            }
            
            Mapbox.Utils.Vector2d val_8 = new Mapbox.Utils.Vector2d(x:  val_20, y:  Mapbox.Utils.Mathd.Max(a:  val_21, b:  -180));
            this.SetCenterLatitudeLongitude(centerLatitudeLongitude:  new Mapbox.Utils.Vector2d() {x = val_8.x, y = val_8.y});
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_24 = public System.Void Mapbox.Unity.Map.IMapScalingStrategy::SetUpScaling(Mapbox.Unity.Map.AbstractMap map);
            this._options.scalingOptions.scalingStrategy.SetUpScaling(map:  this);
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_24 = 0;
            val_26 = this;
            this._options.placementOptions.placementStrategy.SetUpPlacement(map:  this);
            var val_11 = (System.Math.Abs(val_16) > (1E-05f)) ? 1 : 0;
            val_11 = val_17 | val_11;
            if(val_11 != 0)
            {
                    UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_16);
                this._mapScaleFactor = val_13;
                mem[1152921519814766200] = val_13.y;
                mem[1152921519814766204] = val_13.z;
                val_16 = this._mapScaleFactor;
                val_26 = 0;
                this.transform.localScale = new UnityEngine.Vector3() {x = val_16, y = val_12.x, z = val_12.y};
            }
            
            if(this.OnUpdated == null)
            {
                    return;
            }
            
            this.OnUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetMap()
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  this._options.locationOptions.latitudeLongitude);
            if(this._options.locationOptions == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void TileProvider_OnTileAdded(Mapbox.Map.UnwrappedTileId tileId)
        {
            object val_21;
            var val_22;
            val_21 = this;
            if(this._options.placementOptions.snapMapToZero == false)
            {
                goto label_3;
            }
            
            this._worldHeightFixed = true;
            tileId.Y = tileId.Y & 4294967295;
            val_22 = this._mapVisualizer;
            if(val_22.HeightDataState != 3)
            {
                goto label_6;
            }
            
            float val_2 = val_22.QueryHeightData(x:  0.5f, y:  0.5f);
            UnityEngine.Vector3 val_7 = this.transform.transform.position;
            UnityEngine.Vector3 val_10 = this.transform.transform.position;
            this.transform.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
            label_3:
            tileId.Y = tileId.Y & 4294967295;
            val_22 = ???;
            val_21 = ???;
            goto typeof(Mapbox.Unity.Map.AbstractMapVisualizer).__il2cppRuntimeField_198;
            label_6:
            val_22.add_OnHeightDataChanged(value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  val_21, method:  System.Void Mapbox.Unity.Map.AbstractMap::<TileProvider_OnTileAdded>b__81_0(Mapbox.Unity.MeshGeneration.Data.UnityTile s)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void TileProvider_OnTileRemoved(Mapbox.Map.UnwrappedTileId tileId)
        {
            tileId.Y = tileId.Y & 4294967295;
            goto typeof(Mapbox.Unity.Map.AbstractMapVisualizer).__il2cppRuntimeField_1A8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void TileProvider_OnTileRepositioned(Mapbox.Map.UnwrappedTileId tileId)
        {
            tileId.Y = tileId.Y & 4294967295;
            goto typeof(Mapbox.Unity.Map.AbstractMapVisualizer).__il2cppRuntimeField_1B8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SendInitialized()
        {
            this.OnInitialized.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GeoToWorldPositionXZ(Mapbox.Utils.Vector2d latitudeLongitude)
        {
            int val_2 = this._initialZoom - this.AbsoluteZoom;
            Mapbox.Utils.Vector2d val_4 = Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(latLong:  new Mapbox.Utils.Vector2d() {x = latitudeLongitude.x, y = latitudeLongitude.y}, refPoint:  new Mapbox.Utils.Vector2d() {x = this._centerMercator}, scale:  1f * this._worldRelativeScale);
            UnityEngine.Vector3 val_5 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y});
            UnityEngine.Transform val_6 = this.transform;
            if(val_6 != null)
            {
                    return val_6.TransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            }
            
            return val_6.TransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual float QueryElevationAtInternal(Mapbox.Utils.Vector2d latlong, out float tileScale)
        {
            var val_9;
            var val_22;
            double val_23;
            val_22 = 1152921519815809328;
            val_23 = latlong.y;
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_5 = 0;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(lat:  latlong.x, lon:  val_23);
            Mapbox.Map.UnwrappedTileId val_3 = Mapbox.Unity.Utilities.Conversions.LatitudeLongitudeToTileId(latitude:  latlong.x, longitude:  val_23, zoom:  (int)this.Zoom);
            if((this._mapVisualizer._activeTiles.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = val_3.Z, X = val_3.X, Y = val_3.Y & 4294967295}, value: out  val_5)) != false)
            {
                    tileScale = val_5.TileScale;
                Mapbox.Utils.RectD val_8 = val_5.Rect;
                val_22 = val_5;
                Mapbox.Utils.Vector2d val_13 = val_9.Min;
                Mapbox.Utils.Vector2d val_14 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = val_13.x, y = val_13.y});
                Mapbox.Utils.Vector2d val_15 = val_9.Max;
                val_23 = val_15.x;
                Mapbox.Utils.Vector2d val_16 = val_9.Min;
                Mapbox.Utils.Vector2d val_17 = val_9.Max;
                double val_18 = val_1.y - val_16.y;
                val_18 = val_18 / val_17.y;
                float val_20 = val_22.QueryHeightData(x:  (float)val_14.x / val_23, y:  (float)val_18);
                return 0f;
            }
            
            tileScale = 1f;
            return 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual UnityEngine.Vector3 GeoToWorldPosition(Mapbox.Utils.Vector2d latitudeLongitude, bool queryHeight = True)
        {
            UnityEngine.Vector3 val_1 = this.GeoToWorldPositionXZ(latitudeLongitude:  new Mapbox.Utils.Vector2d() {x = latitudeLongitude.x, y = latitudeLongitude.y});
            if(queryHeight == false)
            {
                    return new UnityEngine.Vector3() {x = val_1.x, y = latitudeLongitude.x, z = val_1.z};
            }
            
            return new UnityEngine.Vector3() {x = val_1.x, y = latitudeLongitude.x, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual Mapbox.Utils.Vector2d WorldToGeoPosition(UnityEngine.Vector3 realworldPoint)
        {
            int val_2 = this._initialZoom - this.AbsoluteZoom;
            UnityEngine.Vector3 val_4 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = realworldPoint.x, y = realworldPoint.y, z = realworldPoint.z});
            float val_5 = this._worldRelativeScale;
            val_5 = 1f * val_5;
            return Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, refPoint:  new Mapbox.Utils.Vector2d() {x = this._centerMercator}, scale:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float QueryElevationInUnityUnitsAt(Mapbox.Utils.Vector2d latlong)
        {
            return (float)latlong.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float QueryElevationInMetersAt(Mapbox.Utils.Vector2d latlong)
        {
            latlong.x = latlong.x / 1f;
            return (float)latlong.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLoadingTexture(UnityEngine.Texture2D loadingTexture)
        {
            this._options.loadingTexture = loadingTexture;
            this._mapVisualizer._loadingTexture = loadingTexture;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpawnPrefabAtGeoLocation(UnityEngine.GameObject prefab, Mapbox.Utils.Vector2d LatLon, System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> callback, bool scaleDownWithWorld = True, string locationItemName = "New Location")
        {
            Mapbox.Utils.Vector2d[] val_1 = new Mapbox.Utils.Vector2d[1];
            val_1[0] = LatLon;
            val_1[1] = LatLon.y;
            this.SpawnPrefabAtGeoLocation(prefab:  prefab, LatLon:  val_1, callback:  callback, scaleDownWithWorld:  scaleDownWithWorld, locationItemName:  locationItemName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpawnPrefabAtGeoLocation(UnityEngine.GameObject prefab, Mapbox.Utils.Vector2d[] LatLon, System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> callback, bool scaleDownWithWorld = True, string locationItemName = "New Location")
        {
            Mapbox.Unity.Map.SpawnPrefabOptions val_7;
            System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> val_8;
            string[] val_1 = new string[0];
            if(LatLon.Length < 1)
            {
                goto label_2;
            }
            
            label_11:
            string val_2 = LatLon[0] + ", " + LatLon[0];
            if(val_1 == null)
            {
                goto label_5;
            }
            
            if(val_2 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_2 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_1[0] = val_2;
            if((0 + 1) < LatLon.Length)
            {
                goto label_11;
            }
            
            label_2:
            Mapbox.Unity.Map.PrefabItemOptions val_4 = new Mapbox.Unity.Map.PrefabItemOptions();
            if(val_4 != null)
            {
                    .findByType = 2;
            }
            else
            {
                    mem[168] = 2;
            }
            
            mem[32] = locationItemName;
            Mapbox.Unity.Map.SpawnPrefabOptions val_5 = new Mapbox.Unity.Map.SpawnPrefabOptions();
            if(val_5 != null)
            {
                    .prefab = prefab;
            }
            else
            {
                    mem[16] = prefab;
            }
            
            .scaleDownWithWorld = scaleDownWithWorld;
            .spawnPrefabOptions = val_5;
            .coordinates = val_1;
            if(callback != null)
            {
                    val_8 = System.Delegate.Combine(a:  (Mapbox.Unity.Map.SpawnPrefabOptions)[1152921519816830848].AllPrefabsInstatiated, b:  callback);
                if((val_8 != null) && (null != null))
            {
                    val_8 = 0;
            }
            
                val_7 = (Mapbox.Unity.Map.PrefabItemOptions)[1152921519816826752].spawnPrefabOptions;
                (Mapbox.Unity.Map.PrefabItemOptions)[1152921519816826752].spawnPrefabOptions.AllPrefabsInstatiated = val_8;
            }
            
            this.CreatePrefabLayer(item:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpawnPrefabByCategory(UnityEngine.GameObject prefab, Mapbox.Unity.Map.LocationPrefabCategories categories = -1, int density = 30, System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> callback, bool scaleDownWithWorld = True, string locationItemName = "New Location")
        {
            System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> val_6 = callback;
            Mapbox.Unity.Map.PrefabItemOptions val_1 = new Mapbox.Unity.Map.PrefabItemOptions();
            if(val_1 != null)
            {
                    .findByType = 0;
                .categories = categories;
                .density = density;
            }
            else
            {
                    mem[168] = 0;
                .categories = categories;
                mem[192] = density;
            }
            
            mem2[0] = locationItemName;
            Mapbox.Unity.Map.SpawnPrefabOptions val_2 = new Mapbox.Unity.Map.SpawnPrefabOptions();
            if(val_2 != null)
            {
                    .prefab = prefab;
            }
            else
            {
                    mem[16] = prefab;
            }
            
            .scaleDownWithWorld = scaleDownWithWorld;
            .spawnPrefabOptions = val_2;
            if(val_6 != null)
            {
                    val_6 = System.Delegate.Combine(a:  (Mapbox.Unity.Map.SpawnPrefabOptions)[1152921519817016576].AllPrefabsInstatiated, b:  val_6 = callback);
                if((val_6 != null) && (null != null))
            {
                    val_6 = 0;
            }
            
                (Mapbox.Unity.Map.PrefabItemOptions)[1152921519817012480].spawnPrefabOptions.AllPrefabsInstatiated = val_6;
            }
            
            this.CreatePrefabLayer(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpawnPrefabByName(UnityEngine.GameObject prefab, string nameString, int density = 30, System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> callback, bool scaleDownWithWorld = True, string locationItemName = "New Location")
        {
            Mapbox.Unity.Map.PrefabItemOptions val_1 = new Mapbox.Unity.Map.PrefabItemOptions();
            if(val_1 != null)
            {
                    .nameString = nameString;
                .findByType = 1;
                .density = density;
            }
            else
            {
                    mem[168] = 1;
                mem[176] = nameString;
                mem[192] = density;
            }
            
            mem2[0] = locationItemName;
            Mapbox.Unity.Map.SpawnPrefabOptions val_2 = new Mapbox.Unity.Map.SpawnPrefabOptions();
            if(val_2 != null)
            {
                    .prefab = prefab;
            }
            else
            {
                    mem[16] = prefab;
            }
            
            .scaleDownWithWorld = scaleDownWithWorld;
            .spawnPrefabOptions = val_2;
            this.CreatePrefabLayer(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreatePrefabLayer(Mapbox.Unity.Map.PrefabItemOptions item)
        {
            string val_7;
            Mapbox.Unity.Map.VectorLayer val_8;
            val_7 = this._vectorData.LayerProperty;
            if(val_7.sourceType != 3)
            {
                    Mapbox.Unity.Map.VectorLayerProperties val_3 = this._vectorData.LayerProperty;
                val_7 = val_3.sourceOptions.layerSource.Id;
                Mapbox.Unity.Map.Style val_4 = Mapbox.Unity.Map.MapboxDefaultVector.GetParameters(defaultElevation:  1);
                if((val_7.Contains(value:  val_4.Id)) != false)
            {
                    val_8 = this._vectorData;
                if(val_8 == null)
            {
                    Mapbox.Unity.Map.VectorLayer val_6 = null;
                val_8 = val_6;
                val_6 = new Mapbox.Unity.Map.VectorLayer();
                this._vectorData = val_8;
            }
            
                val_6.AddLocationPrefabItem(prefabItem:  item);
                return;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "In order to place location prefabs please add \"mapbox.mapbox-streets-v7\" to the list of vector data sources");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AbstractMap()
        {
            var val_6;
            System.Action val_8;
            System.Action val_11;
            this._initializeOnStart = true;
            this._imagery = new Mapbox.Unity.Map.ImageryLayer();
            this._terrain = new Mapbox.Unity.Map.TerrainLayer();
            this._vectorData = new Mapbox.Unity.Map.VectorLayer();
            this._unityTileSize = 1f;
            val_6 = null;
            val_6 = null;
            val_8 = AbstractMap.<>c.<>9__97_0;
            if(val_8 == null)
            {
                    System.Action val_4 = null;
                val_8 = val_4;
                val_4 = new System.Action(object:  AbstractMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AbstractMap.<>c::<.ctor>b__97_0());
                val_6 = null;
                AbstractMap.<>c.<>9__97_0 = val_8;
            }
            
            this.OnInitialized = val_8;
            val_6 = null;
            val_11 = AbstractMap.<>c.<>9__97_1;
            if(val_11 == null)
            {
                    System.Action val_5 = null;
                val_11 = val_5;
                val_5 = new System.Action(object:  AbstractMap.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AbstractMap.<>c::<.ctor>b__97_1());
                AbstractMap.<>c.<>9__97_1 = val_11;
            }
            
            this.OnUpdated = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <TileProvider_OnTileAdded>b__81_0(Mapbox.Unity.MeshGeneration.Data.UnityTile s)
        {
            float val_1 = s.QueryHeightData(x:  0.5f, y:  0.5f);
            UnityEngine.Vector3 val_6 = this.transform.transform.position;
            UnityEngine.Vector3 val_9 = this.transform.transform.position;
            this.transform.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}
