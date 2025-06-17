using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnityTile : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _rasterData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.VectorTile <VectorData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _heightTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float[] _heightData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _loadingTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Map.Tile> _tiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsRecycled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer _meshRenderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshFilter _meshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Collider _collider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.RectD <Rect>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <InitialZoom>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <CurrentZoom>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <TileScale>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.UnwrappedTileId <UnwrappedTileId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.CanonicalTileId <CanonicalTileId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _relativeScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Enums.TilePropertyState _rasterDataState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Enums.TilePropertyState _heightDataState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Enums.TilePropertyState _vectorDataState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Enums.TilePropertyState _tileState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> OnHeightDataChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> OnRasterDataChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> OnVectorDataChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.VectorTile VectorData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshRenderer MeshRenderer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter MeshFilter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Collider Collider { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.RectD Rect { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int InitialZoom { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CurrentZoom { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TileScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId UnwrappedTileId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId CanonicalTileId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState RasterDataState { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState HeightDataState { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState VectorDataState { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState TileState { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.VectorTile get_VectorData()
        {
            return (Mapbox.Map.VectorTile)this.<VectorData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_VectorData(Mapbox.Map.VectorTile value)
        {
            this.<VectorData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshRenderer get_MeshRenderer()
        {
            if(this._meshRenderer != 0)
            {
                    return (UnityEngine.MeshRenderer)this._meshRenderer;
            }
            
            UnityEngine.MeshRenderer val_2 = this.GetComponent<UnityEngine.MeshRenderer>();
            this._meshRenderer = val_2;
            if(val_2 != 0)
            {
                    return (UnityEngine.MeshRenderer)this._meshRenderer;
            }
            
            this._meshRenderer = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
            return (UnityEngine.MeshRenderer)this._meshRenderer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.MeshFilter get_MeshFilter()
        {
            if(this._meshFilter != 0)
            {
                    return (UnityEngine.MeshFilter)this._meshFilter;
            }
            
            UnityEngine.MeshFilter val_2 = this.GetComponent<UnityEngine.MeshFilter>();
            this._meshFilter = val_2;
            if(val_2 != 0)
            {
                    return (UnityEngine.MeshFilter)this._meshFilter;
            }
            
            this._meshFilter = this.gameObject.AddComponent<UnityEngine.MeshFilter>();
            return (UnityEngine.MeshFilter)this._meshFilter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Collider get_Collider()
        {
            UnityEngine.Collider val_3;
            if(this._collider == 0)
            {
                    this._collider = this.GetComponent<UnityEngine.Collider>();
                return val_3;
            }
            
            val_3 = this._collider;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.RectD get_Rect()
        {
            Mapbox.Utils.RectD val_0;
            val_0.<Center>k__BackingField.x = ;
            val_0.<Size>k__BackingField.x = ;
            val_0.<Max>k__BackingField.x = ;
            val_0.<Min>k__BackingField.x = this.<Rect>k__BackingField;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Rect(Mapbox.Utils.RectD value)
        {
            mem[1152921519762000664] = value.<Center>k__BackingField.x;
            mem[1152921519762000648] = value.<Size>k__BackingField.x;
            mem[1152921519762000632] = value.<Max>k__BackingField.x;
            this.<Rect>k__BackingField = value.<Min>k__BackingField.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_InitialZoom()
        {
            return (int)this.<InitialZoom>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_InitialZoom(int value)
        {
            this.<InitialZoom>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_CurrentZoom()
        {
            return (int)this.<CurrentZoom>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CurrentZoom(int value)
        {
            this.<CurrentZoom>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_TileScale()
        {
            return (float)this.<TileScale>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_TileScale(float value)
        {
            this.<TileScale>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId get_UnwrappedTileId()
        {
            return new Mapbox.Map.UnwrappedTileId() {Z = this.<UnwrappedTileId>k__BackingField, X = this.<UnwrappedTileId>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_UnwrappedTileId(Mapbox.Map.UnwrappedTileId value)
        {
            this.<UnwrappedTileId>k__BackingField = value;
            mem[1152921519762900780] = value.Y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId get_CanonicalTileId()
        {
            return new Mapbox.Map.CanonicalTileId() {Z = this.<CanonicalTileId>k__BackingField, X = this.<CanonicalTileId>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CanonicalTileId(Mapbox.Map.CanonicalTileId value)
        {
            this.<CanonicalTileId>k__BackingField = value;
            mem[1152921519763124792] = value.Y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState get_RasterDataState()
        {
            return (Mapbox.Unity.MeshGeneration.Enums.TilePropertyState)this._rasterDataState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_RasterDataState(Mapbox.Unity.MeshGeneration.Enums.TilePropertyState value)
        {
            if(this._rasterDataState == value)
            {
                    return;
            }
            
            this._rasterDataState = value;
            this.OnRasterDataChanged.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState get_HeightDataState()
        {
            return (Mapbox.Unity.MeshGeneration.Enums.TilePropertyState)this._heightDataState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_HeightDataState(Mapbox.Unity.MeshGeneration.Enums.TilePropertyState value)
        {
            if(this._heightDataState == value)
            {
                    return;
            }
            
            this._heightDataState = value;
            this.OnHeightDataChanged.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState get_VectorDataState()
        {
            return (Mapbox.Unity.MeshGeneration.Enums.TilePropertyState)this._vectorDataState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_VectorDataState(Mapbox.Unity.MeshGeneration.Enums.TilePropertyState value)
        {
            if(this._vectorDataState == value)
            {
                    return;
            }
            
            this._vectorDataState = value;
            this.OnVectorDataChanged.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Enums.TilePropertyState get_TileState()
        {
            return (Mapbox.Unity.MeshGeneration.Enums.TilePropertyState)this._tileState;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TileState(Mapbox.Unity.MeshGeneration.Enums.TilePropertyState value)
        {
            if(this._tileState == value)
            {
                    return;
            }
            
            this._tileState = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnHeightDataChanged(System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnHeightDataChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnHeightDataChanged != 1152921519764269008);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnHeightDataChanged(System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnHeightDataChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnHeightDataChanged != 1152921519764405584);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRasterDataChanged(System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRasterDataChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRasterDataChanged != 1152921519764542168);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRasterDataChanged(System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRasterDataChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRasterDataChanged != 1152921519764678744);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnVectorDataChanged(System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnVectorDataChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnVectorDataChanged != 1152921519764815328);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnVectorDataChanged(System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnVectorDataChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnVectorDataChanged != 1152921519764951904);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Initialize(Mapbox.Unity.Map.IMapReadable map, Mapbox.Map.UnwrappedTileId tileId, float scale, int zoom, UnityEngine.Texture2D loadingTexture)
        {
            var val_5;
            var val_6;
            var val_7;
            Mapbox.Utils.RectD val_8;
            this.<TileScale>k__BackingField = scale;
            var val_15 = 0;
            val_15 = val_15 + 1;
            Mapbox.Utils.Vector2d val_2 = map.CenterLatitudeLongitude;
            float val_16 = 0.01745329f;
            val_16 = (float)val_2.x * val_16;
            val_16 = 1f / val_16;
            this._relativeScale = val_16;
            Mapbox.Utils.RectD val_4 = Mapbox.Unity.Utilities.Conversions.TileBounds(unwrappedTileId:  new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = tileId.Y & 4294967295});
            mem[1152921519765100696] = val_5;
            mem[1152921519765100680] = val_6;
            mem[1152921519765100664] = val_7;
            this.<UnwrappedTileId>k__BackingField = tileId;
            mem[1152921519765100732] = tileId.Y;
            this.<Rect>k__BackingField = val_8;
            this.<CanonicalTileId>k__BackingField = tileId.Z;
            mem[1152921519765100744] = 0;
            this._loadingTexture = loadingTexture;
            if(this._isInitialized != true)
            {
                    this._isInitialized = true;
                this.<InitialZoom>k__BackingField = zoom;
            }
            
            this.<CurrentZoom>k__BackingField = zoom;
            var val_17 = 0;
            val_17 = val_17 + 1;
            int val_11 = map.InitialZoom - zoom;
            val_8 = 0;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.gameObject.SetActive(value:  true);
            this.IsRecycled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Recycle()
        {
            var val_10;
            var val_11;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_13;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_15;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_17;
            val_10 = 1152921504851574784;
            if((UnityEngine.Object.op_Implicit(exists:  this._loadingTexture)) != false)
            {
                    if(this.MeshRenderer != 0)
            {
                    val_10 = this.MeshRenderer.material;
                val_10.mainTexture = this._loadingTexture;
            }
            
            }
            
            this.gameObject.SetActive(value:  false);
            this.IsRecycled = true;
            this.RasterDataState = 0;
            this.HeightDataState = 0;
            this.VectorDataState = 0;
            if(this._tileState != 0)
            {
                    this._tileState = 0;
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = UnityTile.<>c.<>9__71_0;
            if(val_13 == null)
            {
                    System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_7 = null;
                val_13 = val_7;
                val_7 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  UnityTile.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnityTile.<>c::<Recycle>b__71_0(Mapbox.Unity.MeshGeneration.Data.UnityTile <p0>));
                val_11 = null;
                UnityTile.<>c.<>9__71_0 = val_13;
            }
            
            this.OnHeightDataChanged = val_13;
            val_11 = null;
            val_15 = UnityTile.<>c.<>9__71_1;
            if(val_15 == null)
            {
                    System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_8 = null;
                val_15 = val_8;
                val_8 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  UnityTile.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnityTile.<>c::<Recycle>b__71_1(Mapbox.Unity.MeshGeneration.Data.UnityTile <p0>));
                val_11 = null;
                UnityTile.<>c.<>9__71_1 = val_15;
            }
            
            this.OnRasterDataChanged = val_15;
            val_11 = null;
            val_17 = UnityTile.<>c.<>9__71_2;
            if(val_17 == null)
            {
                    System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_9 = null;
                val_17 = val_9;
                val_9 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  UnityTile.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnityTile.<>c::<Recycle>b__71_2(Mapbox.Unity.MeshGeneration.Data.UnityTile <p0>));
                UnityTile.<>c.<>9__71_2 = val_17;
            }
            
            this.OnVectorDataChanged = val_17;
            this.Cancel();
            this._tiles.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetHeightData(byte[] data, float heightMultiplier = 1, bool useRelative = False, bool addCollider = False)
        {
            UnityEngine.Texture2D val_14;
            float val_15;
            int val_16;
            if(this._heightDataState == 0)
            {
                    return;
            }
            
            if(this._heightTexture == 0)
            {
                    UnityEngine.Texture2D val_2 = null;
                val_14 = val_2;
                val_2 = new UnityEngine.Texture2D(width:  0, height:  0);
                this._heightTexture = val_14;
            }
            else
            {
                    val_14 = this._heightTexture;
            }
            
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_14, data:  data);
            bool val_5 = UnityEngine.ImageConversion.LoadImage(tex:  this._heightTexture, data:  0);
            if(this._heightData == null)
            {
                    this._heightData = new float[65536];
            }
            
            if(useRelative != false)
            {
                    val_15 = this._relativeScale;
            }
            else
            {
                    val_15 = 1f;
            }
            
            var val_23 = 0;
            var val_22 = 0;
            var val_21 = 0;
            do
            {
                var val_19 = 0;
                var val_20 = val_23;
                do
            {
                val_16 = val_4.Length;
                var val_8 = val_22 + val_19;
                if((val_8 + 1) >= val_16)
            {
                    val_16 = val_4.Length;
            }
            
                if((val_8 + 2) >= val_16)
            {
                    val_16 = val_4.Length;
            }
            
                var val_11 = val_22 + val_19;
                val_11 = val_11 + 3;
                float val_18 = Mapbox.Unity.Utilities.Conversions.GetAbsoluteHeightFromColor(r:  1.152922E+18f, g:  1f, b:  1f);
                val_18 = (val_15 * heightMultiplier) * val_18;
                val_19 = val_19 + 4;
                val_20 = val_20 + 1;
                this._heightData[val_22][val_19] = val_18;
            }
            while(val_19 != 1024);
            
                val_21 = val_21 + 1;
                val_22 = val_22 + 1024;
                val_23 = val_23 + 256;
            }
            while(val_21 != 256);
            
            if(addCollider != false)
            {
                    if((this.gameObject.GetComponent<UnityEngine.MeshCollider>()) == 0)
            {
                    UnityEngine.MeshCollider val_17 = this.gameObject.AddComponent<UnityEngine.MeshCollider>();
            }
            
            }
            
            this.HeightDataState = 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetRasterData(byte[] data, bool useMipMap, bool useCompression)
        {
            if(this._rasterDataState == 0)
            {
                    return;
            }
            
            if(this._rasterData == 0)
            {
                    UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  0, height:  0, textureFormat:  3, mipChain:  useMipMap);
                this._rasterData = val_3;
                val_3.wrapMode = 1;
            }
            
            bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  this._rasterData, data:  data);
            if(useCompression != false)
            {
                    this._rasterData.Compress(highQuality:  false);
            }
            
            this.MeshRenderer.material.mainTexture = this._rasterData;
            this.RasterDataState = 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetVectorData(Mapbox.Map.VectorTile vectorTile)
        {
            if(this._vectorDataState == 0)
            {
                    return;
            }
            
            this.<VectorData>k__BackingField = vectorTile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float QueryHeightData(float x, float y)
        {
            if(this._heightData == null)
            {
                    return 0f;
            }
            
            x = x * 256f;
            float val_5 = this._heightData[(long)((int)UnityEngine.Mathf.Clamp(value:  x, min:  0f, max:  255f)) + (((int)UnityEngine.Mathf.Clamp(value:  y * 256f, min:  0f, max:  255f)) << 8)];
            val_5 = val_5 * (this.<TileScale>k__BackingField);
            return 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLoadingTexture(UnityEngine.Texture2D texture)
        {
            this.MeshRenderer.material.mainTexture = texture;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D GetRasterData()
        {
            return (UnityEngine.Texture2D)this._rasterData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void AddTile(Mapbox.Map.Tile tile)
        {
            this._tiles.Add(item:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Cancel()
        {
            int val_1 = this._tiles.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this._tiles.Item[0].Cancel();
                val_3 = val_3 + 1;
            }
            while(val_1 != val_3);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            this.Cancel();
            if(this._heightTexture != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this._heightTexture);
            }
            
            if(this._rasterData == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this._rasterData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityTile()
        {
            var val_5;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_7;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_10;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_12;
            this._tiles = new System.Collections.Generic.List<Mapbox.Map.Tile>();
            this._tileState = 1;
            val_5 = null;
            val_5 = null;
            val_7 = UnityTile.<>c.<>9__81_0;
            if(val_7 == null)
            {
                    System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  UnityTile.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnityTile.<>c::<.ctor>b__81_0(Mapbox.Unity.MeshGeneration.Data.UnityTile <p0>));
                val_5 = null;
                UnityTile.<>c.<>9__81_0 = val_7;
            }
            
            this.OnHeightDataChanged = val_7;
            val_5 = null;
            val_10 = UnityTile.<>c.<>9__81_1;
            if(val_10 == null)
            {
                    System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  UnityTile.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnityTile.<>c::<.ctor>b__81_1(Mapbox.Unity.MeshGeneration.Data.UnityTile <p0>));
                val_5 = null;
                UnityTile.<>c.<>9__81_1 = val_10;
            }
            
            this.OnRasterDataChanged = val_10;
            val_5 = null;
            val_12 = UnityTile.<>c.<>9__81_2;
            if(val_12 == null)
            {
                    System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_4 = null;
                val_12 = val_4;
                val_4 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  UnityTile.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UnityTile.<>c::<.ctor>b__81_2(Mapbox.Unity.MeshGeneration.Data.UnityTile <p0>));
                UnityTile.<>c.<>9__81_2 = val_12;
            }
            
            this.OnVectorDataChanged = val_12;
        }
    
    }

}
