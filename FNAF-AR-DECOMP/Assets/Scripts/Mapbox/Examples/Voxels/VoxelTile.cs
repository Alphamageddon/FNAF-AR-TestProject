using UnityEngine;

namespace Mapbox.Examples.Voxels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class VoxelTile : MonoBehaviour, IObserver<Mapbox.Map.RasterTile>, IObserver<Mapbox.Map.RawPngRasterTile>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.ForwardGeocodeUserInput _geocodeInput;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _zoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _elevationMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _voxelDepthPadding;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _tileWidthInVoxels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.Voxels.VoxelFetcher _voxelFetcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _voxelBatchCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _styleUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.Map<Mapbox.Map.RasterTile> _raster;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.Map<Mapbox.Map.RawPngRasterTile> _elevation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _rasterTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _elevationTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.IFileSource _fileSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Examples.Voxels.VoxelData> _voxels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _instantiatedVoxels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _tileScale;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._geocodeInput.add_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Voxels.VoxelTile::GeocodeInput_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._geocodeInput)) == false)
            {
                    return;
            }
            
            this._geocodeInput.remove_OnGeocoderResponse(value:  new System.Action<Mapbox.Geocoding.ForwardGeocodeResponse>(object:  this, method:  System.Void Mapbox.Examples.Voxels.VoxelTile::GeocodeInput_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Mapbox.Unity.MapboxAccess val_1 = Mapbox.Unity.MapboxAccess.Instance;
            this._fileSource = val_1;
            this._raster = new Mapbox.Map.Map<Mapbox.Map.RasterTile>(fs:  val_1);
            this._elevation = new Mapbox.Map.Map<Mapbox.Map.RawPngRasterTile>(fs:  this._fileSource);
            if((System.String.IsNullOrEmpty(value:  this._styleUrl)) != true)
            {
                    this._raster.MapId = this._styleUrl;
            }
            
            this._elevation.MapId = "mapbox.terrain-rgb";
            this._elevation.Subscribe(observer:  this);
            this._raster.Subscribe(observer:  this);
            Mapbox.Utils.Vector2d val_5 = new Mapbox.Utils.Vector2d(x:  -50.98306, y:  -72.96639);
            this.FetchWorldData(coordinates:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GeocodeInput_OnGeocoderResponse(Mapbox.Geocoding.ForwardGeocodeResponse response)
        {
            this.Cleanup();
            this.FetchWorldData(coordinates:  new Mapbox.Utils.Vector2d() {x = this._geocodeInput._coordinate});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Cleanup()
        {
            System.Collections.Generic.List<UnityEngine.GameObject> val_5;
            this.StopAllCoroutines();
            this._rasterTexture = 0;
            this._elevationTexture = 0;
            this._voxels.Clear();
            val_5 = this._instantiatedVoxels;
            List.Enumerator<T> val_1 = val_5.GetEnumerator();
            label_6:
            if(((-1917976360) & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.Object.Destroy(obj:  0.emailUIDataHandler);
            goto label_6;
            label_3:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519868739800});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchWorldData(Mapbox.Utils.Vector2d coordinates)
        {
            float val_1 = Mapbox.Unity.Utilities.Conversions.GetTileScaleInMeters(latitude:  (float)coordinates.x, zoom:  this._zoom);
            float val_2 = 0.00390625f;
            val_2 = (float)this._tileWidthInVoxels * val_2;
            val_1 = val_2 / val_1;
            this._tileScale = val_1;
            this._raster.SetVector2dBoundsZoom(bounds:  new Mapbox.Utils.Vector2dBounds() {SouthWest = new Mapbox.Utils.Vector2d() {x = this._zoom, y = this._zoom}, NorthEast = new Mapbox.Utils.Vector2d() {x = this._zoom, y = this._zoom}}, zoom:  -1917855808);
            this._elevation.SetVector2dBoundsZoom(bounds:  new Mapbox.Utils.Vector2dBounds() {SouthWest = new Mapbox.Utils.Vector2d() {x = this._zoom, y = this._zoom}, NorthEast = new Mapbox.Utils.Vector2d() {x = this._zoom, y = this._zoom}}, zoom:  -1917850688);
            this._raster.Update();
            this._elevation.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNext(Mapbox.Map.RasterTile tile)
        {
            if(tile.HasError == true)
            {
                    return;
            }
            
            if(true != 4)
            {
                    if(true != 2)
            {
                    return;
            }
            
            }
            
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  2, height:  2);
            this._rasterTexture = val_2;
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  tile.data);
            Mapbox.Examples.Voxels.TextureScale.ThreadedScale(tex:  this._rasterTexture, newWidth:  this._tileWidthInVoxels, newHeight:  this._tileWidthInVoxels, useBilinear:  false);
            if(this.ShouldBuildWorld() == false)
            {
                    return;
            }
            
            this.BuildVoxelWorld();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnNext(Mapbox.Map.RawPngRasterTile tile)
        {
            if(tile.HasError == true)
            {
                    return;
            }
            
            if(true != 4)
            {
                    if(true != 2)
            {
                    return;
            }
            
            }
            
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  2, height:  2);
            this._elevationTexture = val_2;
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  2);
            Mapbox.Examples.Voxels.TextureScale.ThreadedScale(tex:  this._elevationTexture, newWidth:  this._tileWidthInVoxels, newHeight:  this._tileWidthInVoxels, useBilinear:  false);
            if(this.ShouldBuildWorld() == false)
            {
                    return;
            }
            
            this.BuildVoxelWorld();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldBuildWorld()
        {
            if(this._rasterTexture == 0)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  this._elevationTexture, y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildVoxelWorld()
        {
            int val_23;
            var val_27;
            var val_28;
            int val_29;
            Mapbox.Examples.Voxels.VoxelData val_30;
            var val_31;
            int val_1 = this._elevationTexture.width;
            int val_2 = this._elevationTexture.height;
            val_23 = ((val_1 < 0) ? (val_1 + 1) : (val_1)) >> 1;
            UnityEngine.Color val_6 = this._elevationTexture.GetPixel(x:  val_23, y:  ((val_2 < 0) ? (val_2 + 1) : (val_2)) >> 1);
            float val_22 = this._elevationMultiplier;
            val_22 = val_22 * this._tileScale;
            val_27 = 0;
            goto label_3;
            label_15:
            val_28 = 0;
            goto label_4;
            label_13:
            UnityEngine.Color val_8 = this._elevationTexture.GetPixel(x:  0, y:  0);
            float val_23 = this._elevationMultiplier;
            val_23 = val_23 * this._tileScale;
            val_29 = this._voxelDepthPadding;
            int val_24 = (int)Mapbox.Unity.Utilities.Conversions.GetRelativeHeightFromColor(color:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a}, relativeScale:  val_23);
            float val_10 = val_24 - ((int)Mapbox.Unity.Utilities.Conversions.GetRelativeHeightFromColor(color:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a}, relativeScale:  val_22));
            val_30 = val_27;
            UnityEngine.Color val_11 = this._rasterTexture.GetPixel(x:  0, y:  0);
            val_31 = val_29;
            val_31 = ~val_29;
            val_24 = val_10 + val_31;
            if(val_24 < val_10)
            {
                    do
            {
                float val_12 = val_10 + val_31;
                Mapbox.Examples.Voxels.VoxelData val_13 = null;
                val_29 = val_13;
                val_13 = new Mapbox.Examples.Voxels.VoxelData();
                .Position = 0;
                mem[1152921519869619352] = 0;
                .Prefab = this._voxelFetcher.GetVoxelFromColor(color:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
                val_30 = val_29;
                this._voxels.Add(item:  val_13);
                val_31 = val_31 + 1;
            }
            while(val_31 != 0);
            
            }
            
            val_28 = 1;
            label_4:
            val_23 = public System.Int32 UnityEngine.Texture::get_height();
            if(val_28 < this._rasterTexture.height)
            {
                goto label_13;
            }
            
            val_27 = 1;
            label_3:
            if(val_27 < this._rasterTexture.width)
            {
                goto label_15;
            }
            
            if(this._camera != 0)
            {
                    float val_25 = (float)this._tileWidthInVoxels;
                val_25 = val_25 * 0.5f;
                this._camera.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  this.BuildRoutine());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator BuildRoutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new VoxelTile.<BuildRoutine>d__27();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VoxelTile()
        {
            this._zoom = 17;
            this._elevationMultiplier = 1f;
            this._voxelDepthPadding = 1;
            this._voxelBatchCount = 100;
            this._voxels = new System.Collections.Generic.List<Mapbox.Examples.Voxels.VoxelData>();
            this._instantiatedVoxels = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <BuildRoutine>b__27_0(Mapbox.Examples.Voxels.VoxelData x)
        {
            UnityEngine.Vector3 val_2 = this._camera.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = x.Position, y = V11.16B, z = V12.16B});
            return (float)val_3.x;
        }
    
    }

}
