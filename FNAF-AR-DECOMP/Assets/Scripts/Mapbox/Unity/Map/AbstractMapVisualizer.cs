using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AbstractMapVisualizer : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory> Factories;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _loadingTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material TileMaterial;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.IMapReadable _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, Mapbox.Unity.MeshGeneration.Data.UnityTile> _activeTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.Queue<Mapbox.Unity.MeshGeneration.Data.UnityTile> _inactiveTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.ModuleState _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, int> _tileProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Mapbox.Unity.Map.ModuleState> OnMapVisualizerStateChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.EventHandler<Mapbox.Map.TileErrorEventArgs> OnTileError;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ModuleState State { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.IMapReadable Map { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, Mapbox.Unity.MeshGeneration.Data.UnityTile> ActiveTiles { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ModuleState get_State()
        {
            return (Mapbox.Unity.Map.ModuleState)this._state;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void set_State(Mapbox.Unity.Map.ModuleState value)
        {
            if(this._state == value)
            {
                    return;
            }
            
            this._state = value;
            this.OnMapVisualizerStateChanged.Invoke(obj:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.IMapReadable get_Map()
        {
            return (Mapbox.Unity.Map.IMapReadable)this._map;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, Mapbox.Unity.MeshGeneration.Data.UnityTile> get_ActiveTiles()
        {
            return (System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, Mapbox.Unity.MeshGeneration.Data.UnityTile>)this._activeTiles;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMapVisualizerStateChanged(System.Action<Mapbox.Unity.Map.ModuleState> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMapVisualizerStateChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMapVisualizerStateChanged != 1152921519819627384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMapVisualizerStateChanged(System.Action<Mapbox.Unity.Map.ModuleState> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMapVisualizerStateChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMapVisualizerStateChanged != 1152921519819763960);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetLoadingTexture(UnityEngine.Texture2D loadingTexture)
        {
            this._loadingTexture = loadingTexture;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetTileMaterial(UnityEngine.Material tileMaterial)
        {
            this.TileMaterial = tileMaterial;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.UnityTile GetUnityTileFromUnwrappedTileId(Mapbox.Map.UnwrappedTileId tileId)
        {
            tileId.Y = tileId.Y & 4294967295;
            return this._activeTiles.Item[new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = tileId.Y}];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize(Mapbox.Unity.Map.IMapReadable map, Mapbox.Platform.IFileSource fileSource)
        {
            Mapbox.Platform.IFileSource val_14 = fileSource;
            this._map = map;
            this._tileProgress = new System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, System.Int32>();
            List.Enumerator<T> val_4 = System.Linq.Enumerable.ToList<Mapbox.Map.UnwrappedTileId>(source:  this._activeTiles.Keys).GetEnumerator();
            label_4:
            if(((-1966434352) & 1) == 0)
            {
                goto label_3;
            }
            
            goto label_4;
            label_3:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519820281808});
            this.State = 0;
            List.Enumerator<T> val_9 = this.Factories.GetEnumerator();
            label_18:
            if(((-1966434376) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_10 = 0.emailUIDataHandler;
            if(0 != val_10)
            {
                goto label_13;
            }
            
            UnityEngine.Debug.LogError(message:  "AbstractMapVisualizer: Factory is NULL");
            goto label_18;
            label_13:
            this.UnregisterEvents(factory:  val_10);
            this.RegisterEvents(factory:  val_10);
            goto label_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RegisterEvents(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory factory)
        {
            factory.add_OnTileError(value:  new System.EventHandler<Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.AbstractMapVisualizer::Factory_OnTileError(object sender, Mapbox.Map.TileErrorEventArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UnregisterEvents(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory factory)
        {
            factory.remove_OnTileError(value:  new System.EventHandler<Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.AbstractMapVisualizer::Factory_OnTileError(object sender, Mapbox.Map.TileErrorEventArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Destroy()
        {
            if(this.Factories != null)
            {
                    int val_1 = this.Factories.Count;
                this._counter = val_1;
                if(val_1 >= 1)
            {
                    var val_12 = 0;
                do
            {
                if(this.Factories.Item[0] != 0)
            {
                    this.UnregisterEvents(factory:  this.Factories.Item[0]);
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < this._counter);
            
            }
            
            }
            
            List.Enumerator<T> val_7 = System.Linq.Enumerable.ToList<Mapbox.Map.UnwrappedTileId>(source:  this._activeTiles.Keys).GetEnumerator();
            label_12:
            if(((-1965977488) & 1) == 0)
            {
                goto label_11;
            }
            
            goto label_12;
            label_11:
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519820738672});
            this._activeTiles.Clear();
            this._inactiveTiles.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void TileStateChanged(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, Mapbox.Unity.MeshGeneration.Data.UnityTile> val_31;
            var val_34;
            var val_35;
            Mapbox.Unity.Map.ModuleState val_36;
            if(tile.RasterDataState != 1)
            {
                    if(tile.RasterDataState != 3)
            {
                    if(tile.RasterDataState != 4)
            {
                goto label_6;
            }
            
            }
            
            }
            
            val_31 = 1;
            if(tile != null)
            {
                goto label_35;
            }
            
            label_36:
            label_35:
            if(tile.HeightDataState != 1)
            {
                    if(tile.HeightDataState != 3)
            {
                    if(tile.HeightDataState != 4)
            {
                goto label_12;
            }
            
            }
            
            }
            
            if(tile != null)
            {
                goto label_38;
            }
            
            label_39:
            label_38:
            if(tile.VectorDataState != 1)
            {
                    if(tile.VectorDataState != 3)
            {
                    if(tile.VectorDataState != 4)
            {
                goto label_18;
            }
            
            }
            
            }
            
            var val_33 = 1;
            label_41:
            val_33 = (1 & val_31) & val_33;
            if(val_33 == 0)
            {
                    return;
            }
            
            tile.TileState = 3;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_31 = this._activeTiles;
            if(this._map.CurrentExtent.Count != val_31.Count)
            {
                goto label_58;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            goto label_33;
            label_6:
            var val_16 = (tile.RasterDataState == 5) ? 1 : 0;
            if(tile != null)
            {
                goto label_35;
            }
            
            goto label_36;
            label_12:
            var val_18 = (tile.HeightDataState == 5) ? 1 : 0;
            if(tile != null)
            {
                goto label_38;
            }
            
            goto label_39;
            label_18:
            var val_20 = (tile.VectorDataState == 5) ? 1 : 0;
            goto label_41;
            label_33:
            HashSet.Enumerator<T> val_23 = this._map.CurrentExtent.GetEnumerator();
            val_34 = 1;
            goto label_43;
            label_50:
            val_31 = public Mapbox.Map.UnwrappedTileId HashSet.Enumerator<Mapbox.Map.UnwrappedTileId>::get_Current();
            if((val_34 & 1) == 0)
            {
                goto label_46;
            }
            
            val_31 = 2318301856;
            if((this._activeTiles.ContainsKey(key:  new Mapbox.Map.UnwrappedTileId() {Z = -1965732352, X = 268435459, Y = -1976665440})) == false)
            {
                goto label_46;
            }
            
            var val_29 = ((this._activeTiles.Item[new Mapbox.Map.UnwrappedTileId() {Z = -1965732352, X = 268435459, Y = -1976665440}].TileState) == 3) ? 1 : 0;
            goto label_49;
            label_46:
            val_35 = 0;
            label_49:
            label_43:
            if(((-1965732352) & 1) != 0)
            {
                goto label_50;
            }
            
            long val_31 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519820983808});
            if((((val_35 != 0) ? 1 : 0) & 1) != 0)
            {
                goto label_51;
            }
            
            goto label_58;
            label_51:
            val_36 = 2;
            goto label_59;
            label_58:
            val_36 = 1;
            label_59:
            this.State = val_36;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual Mapbox.Unity.MeshGeneration.Data.UnityTile LoadTile(Mapbox.Map.UnwrappedTileId tileId)
        {
            UnityEngine.Object val_18;
            Mapbox.Unity.Map.IMapReadable val_19;
            int val_24 = tileId.Y;
            if(this._inactiveTiles.Count >= 1)
            {
                    val_18 = this._inactiveTiles.Dequeue();
            }
            else
            {
                    val_18 = 0;
            }
            
            if(val_18 != 0)
            {
                goto label_7;
            }
            
            val_18 = new UnityEngine.GameObject().AddComponent<Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            val_18.MeshRenderer.material = this.TileMaterial;
            val_19 = this;
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_16;
            label_7:
            val_19 = this._map;
            goto label_17;
            label_16:
            val_18.transform.SetParent(parent:  this._map.Root, worldPositionStays:  false);
            label_17:
            var val_22 = 0;
            val_22 = val_22 + 1;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_24 = val_24 & 4294967295;
            val_18.Initialize(map:  this._map, tileId:  new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = val_24}, scale:  this._map.WorldRelativeScale, zoom:  this._map.AbsoluteZoom, loadingTexture:  this._loadingTexture);
            val_18.add_OnHeightDataChanged(value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  this, method:  typeof(Mapbox.Unity.Map.AbstractMapVisualizer).__il2cppRuntimeField_190));
            val_18.add_OnRasterDataChanged(value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  this, method:  typeof(Mapbox.Unity.Map.AbstractMapVisualizer).__il2cppRuntimeField_190));
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile> val_16 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  this, method:  typeof(Mapbox.Unity.Map.AbstractMapVisualizer).__il2cppRuntimeField_190);
            if(val_18 != null)
            {
                    val_18.add_OnVectorDataChanged(value:  val_16);
            }
            else
            {
                    0.add_OnVectorDataChanged(value:  val_16);
            }
            
            val_18.TileState = 2;
            this._activeTiles.Add(key:  new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = val_24}, value:  val_18);
            List.Enumerator<T> val_17 = this.Factories.GetEnumerator();
            label_38:
            if(((-1965448248) & 1) == 0)
            {
                goto label_36;
            }
            
            if(0.emailUIDataHandler != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_36:
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519821267912});
            return val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void DisposeTile(Mapbox.Map.UnwrappedTileId tileId)
        {
            int val_1 = tileId.Y & 4294967295;
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_2 = this._activeTiles.Item[new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = val_1}];
            List.Enumerator<T> val_3 = this.Factories.GetEnumerator();
            label_5:
            if(((-1965227640) & 1) == 0)
            {
                goto label_3;
            }
            
            if(0.emailUIDataHandler != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519821488520});
            val_2.Recycle();
            bool val_7 = this._activeTiles.Remove(key:  new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = val_1});
            this._inactiveTiles.Enqueue(item:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void RepositionTile(Mapbox.Map.UnwrappedTileId tileId)
        {
            int val_3 = tileId.Y;
            val_3 = val_3 & 4294967295;
            if((this._activeTiles.TryGetValue(key:  new Mapbox.Map.UnwrappedTileId() {Z = tileId.Z, X = tileId.X, Y = val_3}, value: out  0)) == false)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void PlaceTile(Mapbox.Map.UnwrappedTileId tileId, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.Map.IMapReadable map); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnTileError(System.EventHandler<Mapbox.Map.TileErrorEventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnTileError, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTileError != 1152921519821782064);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnTileError(System.EventHandler<Mapbox.Map.TileErrorEventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnTileError, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTileError != 1152921519821918640);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Factory_OnTileError(object sender, Mapbox.Map.TileErrorEventArgs e)
        {
            if(this.OnTileError == null)
            {
                    return;
            }
            
            this.OnTileError.Invoke(sender:  this, e:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AbstractMapVisualizer()
        {
            var val_4;
            System.Action<Mapbox.Unity.Map.ModuleState> val_6;
            this._activeTiles = new System.Collections.Generic.Dictionary<Mapbox.Map.UnwrappedTileId, Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            this._inactiveTiles = new System.Collections.Generic.Queue<Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            val_4 = null;
            val_4 = null;
            val_6 = AbstractMapVisualizer.<>c.<>9__35_0;
            if(val_6 == null)
            {
                    System.Action<Mapbox.Unity.Map.ModuleState> val_3 = null;
                val_6 = val_3;
                val_3 = new System.Action<Mapbox.Unity.Map.ModuleState>(object:  AbstractMapVisualizer.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AbstractMapVisualizer.<>c::<.ctor>b__35_0(Mapbox.Unity.Map.ModuleState <p0>));
                AbstractMapVisualizer.<>c.<>9__35_0 = val_6;
            }
            
            this.OnMapVisualizerStateChanged = val_6;
        }
    
    }

}
