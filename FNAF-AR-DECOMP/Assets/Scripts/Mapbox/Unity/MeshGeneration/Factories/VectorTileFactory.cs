using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorTileFactory : AbstractTileFactory
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>> _layerBuilder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.VectorLayerProperties _properties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected VectorDataFetcher DataFetcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>> _layerProgress;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MapId { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MapId()
        {
            if(this._properties.sourceOptions != null)
            {
                    return this._properties.sourceOptions.Id;
            }
            
            return this._properties.sourceOptions.Id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MapId(string value)
        {
            this._properties.sourceOptions.Id = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnInitialized()
        {
            var val_6;
            object val_35;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile> val_36;
            System.Delegate val_37;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs> val_38;
            val_35 = this;
            this._layerProgress = new System.Collections.Generic.Dictionary<Mapbox.Unity.MeshGeneration.Data.UnityTile, System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>>();
            this._layerBuilder = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>>();
            VectorDataFetcher val_3 = UnityEngine.ScriptableObject.CreateInstance<VectorDataFetcher>();
            this.DataFetcher = val_3;
            val_36 = System.Delegate.Combine(a:  val_3.DataRecieved, b:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory::OnVectorDataRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.VectorTile vectorTile)));
            if(val_3 == null)
            {
                goto label_2;
            }
            
            if(val_36 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_36 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_36 = 0;
            }
            
            label_6:
            val_3.DataRecieved = val_36;
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs> val_7 = null;
            val_37 = val_7;
            val_7 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Map.VectorTile, Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory::OnDataError(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.VectorTile vectorTile, Mapbox.Map.TileErrorEventArgs e));
            val_38 = System.Delegate.Combine(a:  this.DataFetcher.FetchingError, b:  val_7);
            if(this.DataFetcher == null)
            {
                goto label_8;
            }
            
            if(val_38 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_38 == null)
            {
                goto label_12;
            }
            
            label_9:
            if(null != null)
            {
                    val_38 = 0;
            }
            
            label_12:
            this.DataFetcher.FetchingError = val_38;
            List.Enumerator<T> val_9 = this._properties.locationPrefabList.GetEnumerator();
            label_35:
            if(((-2041894208) & 1) == 0)
            {
                goto label_15;
            }
            
            Mapbox.Unity.MeshGeneration.Interfaces.LocationPrefabsLayerVisualizer val_12 = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Interfaces.LocationPrefabsLayerVisualizer>();
            val_11._itemDefinitions = this._properties.performanceOptions;
            0.SetProperties(item:  val_6.emailUIDataHandler);
            if(val_12 == 0)
            {
                goto label_35;
            }
            
            if((this._layerBuilder.ContainsKey(key:  val_12)) == false)
            {
                goto label_29;
            }
            
            this._layerBuilder.Item[val_12].Add(item:  val_12);
            goto label_35;
            label_29:
            System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> val_20 = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>();
            null.Add(item:  val_12);
            this._layerBuilder.Add(key:  val_12, value:  null);
            goto label_35;
            label_15:
            long val_21 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519744821952});
            List.Enumerator<T> val_23 = this._properties.vectorSubLayers.GetEnumerator();
            label_84:
            if(((-2041894240) & 1) == 0)
            {
                goto label_64;
            }
            
            Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizer val_25 = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Interfaces.VectorLayerVisualizer>();
            val_24._itemDefinitions = this._properties.performanceOptions;
            0.SetProperties(properties:  val_6.emailUIDataHandler);
            if(val_25 == 0)
            {
                goto label_84;
            }
            
            if((this._layerBuilder.ContainsKey(key:  val_25)) == false)
            {
                goto label_78;
            }
            
            this._layerBuilder.Item[val_25].Add(item:  val_25);
            goto label_84;
            label_78:
            System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> val_32 = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>();
            null.Add(item:  val_25);
            this._layerBuilder.Add(key:  val_25, value:  null);
            goto label_84;
            label_64:
            long val_33 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519744821920});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetOptions(Mapbox.Unity.Map.LayerProperties options)
        {
            Mapbox.Unity.Map.LayerProperties val_3 = options;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._properties = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnRegistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.Map.LayerSourceOptions val_8;
            Mapbox.Unity.Map.VectorLayerProperties val_9;
            if((System.String.IsNullOrEmpty(value:  this.MapId)) == true)
            {
                goto label_4;
            }
            
            val_8 = this._properties.sourceOptions;
            if(this._properties.sourceOptions.isActive == false)
            {
                goto label_4;
            }
            
            val_8 = this._properties.vectorSubLayers.Count;
            if(this._properties.locationPrefabList.Count != val_8)
            {
                goto label_9;
            }
            
            label_4:
            tile.VectorDataState = 1;
            return;
            label_9:
            tile.VectorDataState = 2;
            bool val_5 = val_8.Add(item:  tile);
            val_9 = this._properties;
            if(this._properties != null)
            {
                goto label_14;
            }
            
            val_9 = this._properties;
            if(val_9 == null)
            {
                goto label_15;
            }
            
            label_14:
            this.DataFetcher.FetchVector(canonicalTileId:  new Mapbox.Map.CanonicalTileId() {Z = tile.<CanonicalTileId>k__BackingField, X = tile.<CanonicalTileId>k__BackingField, Y = this._properties.locationPrefabList}, mapid:  this.MapId, tile:  tile, useOptimizedStyle:  (this._properties.useOptimizedStyle == true) ? 1 : 0, style:  this._properties.optimizedStyle);
            return;
            label_15:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnErrorOccurred(Mapbox.Map.TileErrorEventArgs e)
        {
            this.OnErrorOccurred(e:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnUnregistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_8;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            if((this._layerProgress.ContainsKey(key:  tile)) != false)
            {
                    bool val_2 = this._layerProgress.Remove(key:  tile);
            }
            
            if((this._layerProgress.Contains(item:  tile)) != false)
            {
                    bool val_4 = this._layerProgress.Remove(item:  tile);
            }
            
            if(this._layerBuilder == null)
            {
                    return;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_6 = this._layerBuilder.Values.GetEnumerator();
            val_17 = 0;
            val_18 = 0;
            label_19:
            if(((-2041153328) & 1) == 0)
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_10 = val_8.emailUIDataHandler.GetEnumerator();
            label_13:
            if(((-2041153360) & 1) == 0)
            {
                goto label_11;
            }
            
            val_8.emailUIDataHandler.UnregisterTile(tile:  tile);
            goto label_13;
            label_11:
            val_19 = val_18;
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519745562800});
            if((((134 == 0) ? 134 : 134) == 134) || ( == 0))
            {
                goto label_19;
            }
            
            goto label_19;
            label_9:
            val_20 = 159;
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519745562832});
            if( == 0)
            {
                    return;
            }
            
            if(134 == 0)
            {
                    return;
            }
            
            if(134 == 159)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnPostProcess(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnVectorDataRecieved(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.VectorTile vectorTile)
        {
            if(tile == 0)
            {
                    return;
            }
            
            bool val_2 = Remove(item:  tile);
            if(tile._vectorDataState == 0)
            {
                    return;
            }
            
            tile.<VectorData>k__BackingField = vectorTile;
            if(tile._heightDataState != 2)
            {
                    if(tile._rasterDataState != 2)
            {
                goto label_8;
            }
            
            }
            
            tile.add_OnHeightDataChanged(value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory::DataChangedHandler(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)));
            tile.add_OnRasterDataChanged(value:  new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory::DataChangedHandler(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)));
            return;
            label_8:
            this.CreateMeshes(tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DataChangedHandler(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            if(tile._vectorDataState == 0)
            {
                    return;
            }
            
            if(tile._rasterDataState == 2)
            {
                    return;
            }
            
            if(tile._heightDataState == 2)
            {
                    return;
            }
            
            this.CreateMeshes(tile:  tile);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDataError(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Map.VectorTile vectorTile, Mapbox.Map.TileErrorEventArgs e)
        {
            var val_9;
            UnityEngine.Object val_10;
            val_9 = e;
            val_10 = tile;
            if(val_10 == 0)
            {
                    return;
            }
            
            bool val_2 = Remove(item:  val_10);
            if(tile._vectorDataState == 0)
            {
                    return;
            }
            
            tile.<VectorData>k__BackingField = 0;
            val_10.VectorDataState = 4;
            val_9 = ???;
            val_10 = ???;
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory).__il2cppRuntimeField_1F8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateMeshes(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            var val_12;
            var val_32;
            var val_48;
            var val_49;
            var val_50;
            var val_53;
            var val_54;
            var val_56;
            var val_58;
            var val_59;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>> val_60;
            var val_61;
            System.Collections.Generic.IEnumerator<T> val_3 = tile.<VectorData>k__BackingField.Data.LayerNames().GetEnumerator();
            val_48 = 1152921519745519216;
            val_49 = 1152921519745548912;
            val_50 = 0;
            label_55:
            var val_49 = 0;
            val_49 = val_49 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_10;
            }
            
            var val_50 = 0;
            val_50 = val_50 + 1;
            T val_7 = val_3.Current;
            if((this._layerBuilder.ContainsKey(key:  val_7)) == false)
            {
                goto label_55;
            }
            
            List.Enumerator<T> val_10 = this._layerBuilder.Item[val_7].GetEnumerator();
            label_36:
            val_53 = 1152921519745548912;
            if(((-2040275840) & 1) == 0)
            {
                goto label_20;
            }
            
            GameUI.EmailUIDataHandler val_13 = val_12.emailUIDataHandler;
            if(val_13._serverGameUIDataModel == null)
            {
                goto label_36;
            }
            
            if((this._layerProgress.ContainsKey(key:  tile)) != false)
            {
                    bool val_16 = this._layerProgress.Item[tile].Add(item:  val_13);
            }
            else
            {
                    System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> val_17 = new System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>();
                bool val_18 = null.Add(item:  val_13);
                this._layerProgress.Add(key:  tile, value:  null);
                if((this._layerProgress.Contains(item:  tile)) != true)
            {
                    bool val_20 = this._layerProgress.Add(item:  tile);
            }
            
            }
            
            Mapbox.VectorTile.VectorTileLayer val_22 = tile.<VectorData>k__BackingField.Data.GetLayer(layerName:  val_7);
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> val_23 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory::DecreaseProgressCounter(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase builder));
            goto label_36;
            label_20:
            val_54 = 0;
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519746440320});
            if((((246 == 0) ? 246 : 246) == 246) || ( == 0))
            {
                goto label_55;
            }
            
            goto label_55;
            label_10:
            val_56 = 269;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_51 = 0;
                val_51 = val_51 + 1;
                val_3.Dispose();
            }
            
            if(((246 == 0) ? 269 : 246) == 269)
            {
                    val_59 = 1152921519745537648;
                val_58 = 0;
            }
            else
            {
                    val_59 = 1152921519745537648;
            }
            
            val_60 = this._layerBuilder;
            if((val_60.ContainsKey(key:  "")) == false)
            {
                goto label_118;
            }
            
            val_60 = this._layerBuilder;
            List.Enumerator<T> val_30 = val_60.Item[""].GetEnumerator();
            label_96:
            if(((-2040275840) & 1) == 0)
            {
                goto label_77;
            }
            
            GameUI.EmailUIDataHandler val_33 = val_32.emailUIDataHandler;
            if(val_33._serverGameUIDataModel == null)
            {
                goto label_96;
            }
            
            if((this._layerProgress.ContainsKey(key:  tile)) != false)
            {
                    bool val_36 = this._layerProgress.Item[tile].Add(item:  val_33);
            }
            else
            {
                    System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> val_37 = new System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>();
                bool val_38 = null.Add(item:  val_33);
                this._layerProgress.Add(key:  tile, value:  null);
                if((this._layerProgress.Contains(item:  tile)) != true)
            {
                    bool val_40 = this._layerProgress.Add(item:  tile);
            }
            
            }
            
            Mapbox.VectorTile.VectorTileLayer val_45 = tile.<VectorData>k__BackingField.Data.GetLayer(layerName:  tile.<VectorData>k__BackingField.Data.LayerNames().Item[0]);
            System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> val_46 = new System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.VectorTileFactory::DecreaseProgressCounter(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase builder));
            goto label_96;
            label_77:
            val_61 = 0;
            val_58 = 511;
            long val_47 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519746440320});
            label_118:
            if((this._layerProgress.ContainsKey(key:  tile)) == true)
            {
                    return;
            }
            
            tile.VectorDataState = 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DecreaseProgressCounter(Mapbox.Unity.MeshGeneration.Data.UnityTile tile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase builder)
        {
            Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase val_10 = builder;
            if((this._layerProgress.ContainsKey(key:  tile)) == false)
            {
                    return;
            }
            
            if((this._layerProgress.Item[tile].Contains(item:  val_10 = builder)) != false)
            {
                    bool val_5 = this._layerProgress.Item[tile].Remove(item:  val_10);
            }
            
            val_10 = this._layerProgress.Item[tile];
            if(val_10.Count != 0)
            {
                    return;
            }
            
            bool val_8 = this._layerProgress.Remove(key:  tile);
            bool val_9 = this.Remove(item:  tile);
            tile.VectorDataState = 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTileFactory()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
