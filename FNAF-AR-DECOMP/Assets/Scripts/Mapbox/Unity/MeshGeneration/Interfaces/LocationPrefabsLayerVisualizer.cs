using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Interfaces
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationPrefabsLayerVisualizer : VectorLayerVisualizer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int maxDensity;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetProperties(Mapbox.Unity.Map.PrefabItemOptions item)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier val_18;
            var val_19;
            bool val_20;
            string val_21;
            Mapbox.Unity.Map.LocationPrefabFindBy val_22;
            var val_23;
            val_19 = this;
            mem[1152921519722157520] = item;
            if(item != null)
            {
                    bool val_2 = item.isActive;
                mem[1152921519722157512] = val_2;
                mem[1152921519722157528] = val_2;
            }
            else
            {
                    mem[1152921519722157512] = 0.isActive;
                mem[1152921519722157528] = 4194311;
            }
            
            if(item.findByType == 0)
            {
                    if(item.categories == 0)
            {
                    return;
            }
            
            }
            
            if(item.spawnPrefabOptions.prefab == 0)
            {
                    UnityEngine.Debug.LogError(message:  "No prefab found. Please assign a prefab to spawn it on the map");
            }
            
            mem2[0] = item.primitiveType;
            .extrusionType = item.extrusionType;
            val_20 = item.combineMeshes;
            mem2[0] = new Mapbox.Unity.Map.GeometryExtrusionOptions();
            mem2[0] = val_20;
            mem2[0] = item._movePrefabFeaturePositionTo;
            string val_7 = "";
            if((item.layerNameFromFindByTypeDictionary.TryGetValue(key:  item.findByType, value: out  val_7)) != false)
            {
                    val_21 = val_7;
                if(item.layerNameFromFindByTypeDictionary == null)
            {
                    val_21 = val_7;
            }
            
                mem2[0] = val_7;
                this.Key = val_21;
            }
            
            val_22 = item.findByType;
            if(val_22 != 2)
            {
                    if(val_22 == 0)
            {
                    this.SetCategoryFilterOptions(item:  item);
                val_22 = item.findByType;
            }
            
                if(val_22 == 1)
            {
                    this.SetNameFilters(item:  item);
            }
            
                this.SetDensityFilters(item:  item);
            }
            
            if(val_22 != 0)
            {
                    return;
            }
            
            val_18 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Type val_10 = item.GetType();
            if((val_18 & 1) == 0)
            {
                    return;
            }
            
            val_18 = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Modifiers.PrefabModifier>();
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierStack val_12 = UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Modifiers.ModifierStack>();
            mem[1152921519722157552] = val_12;
            if(val_12 != null)
            {
                    val_23 = null;
            }
            
            val_23 = null;
            var val_14 = (((Mapbox.Unity.MeshGeneration.Modifiers.ModifierStack.__il2cppRuntimeField_typeHierarchy + Mapbox.Unity.MeshGeneration.Modifiers.ModifierStack.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_23) ? (val_12) : 0;
            mem2[0] = val_20;
            System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier> val_15 = new System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Modifiers.GameObjectModifier>();
            mem2[0] = val_15;
            val_15.Add(item:  val_18);
            if(item.snapToTerrain == false)
            {
                    return;
            }
            
            this.Add(item:  UnityEngine.ScriptableObject.CreateInstance<Mapbox.Unity.MeshGeneration.Modifiers.SnapTerrainModifier>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCategoryFilterOptions(Mapbox.Unity.Map.PrefabItemOptions item)
        {
            var val_8;
            System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String> val_20;
            string val_1 = "";
            if(item != null)
            {
                    val_20 = item.categoryPropertyFromFindByTypeDictionary;
            }
            else
            {
                    val_20 = 62590976;
            }
            
            if(item.findByType != 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<Mapbox.Unity.Map.LocationPrefabCategories> val_3 = val_20.TryGetValue(key:  item.findByType, value: out  val_1).GetSelectedCategoriesList(selectedCategories:  item.categories);
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_3.Count == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_6 = val_3.GetEnumerator();
            label_14:
            if(((-2064240672) & 1) == 0)
            {
                goto label_7;
            }
            
            System.Collections.Generic.List<System.String> val_10 = Mapbox.Unity.Map.LocationPrefabCategoryOptions.GetMakiListFromCategory(category:  val_8.region);
            if((System.String.IsNullOrEmpty(value:  "")) == false)
            {
                goto label_10;
            }
            
            string val_13 = System.String.Join(separator:  ",", value:  val_10.ToArray());
            goto label_14;
            label_10:
            string val_16 = "" + "," + System.String.Join(separator:  ",", value:  val_10.ToArray())(System.String.Join(separator:  ",", value:  val_10.ToArray()));
            goto label_14;
            label_7:
            long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519722475488});
            Mapbox.Unity.MeshGeneration.Filters.LayerFilter val_19 = new Mapbox.Unity.MeshGeneration.Filters.LayerFilter(filterOperation:  0);
            if(val_19 != null)
            {
                    .Key = val_1;
            }
            else
            {
                    mem[16] = val_1;
            }
            
            .PropertyValue = "";
            this.AddFilterToItem(item:  item, filter:  val_19);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDensityFilters(Mapbox.Unity.Map.PrefabItemOptions item)
        {
            int val_4;
            if(item.density >= this.maxDensity)
            {
                    return;
            }
            
            string val_1 = "";
            bool val_2 = item.densityPropertyFromFindByTypeDictionary.TryGetValue(key:  item.findByType, value: out  val_1);
            if(item.findByType > 1)
            {
                    return;
            }
            
            Mapbox.Unity.MeshGeneration.Filters.LayerFilter val_3 = new Mapbox.Unity.MeshGeneration.Filters.LayerFilter(filterOperation:  3);
            if(val_3 != null)
            {
                    .Key = val_1;
                val_4 = item.density;
            }
            else
            {
                    mem[16] = val_1;
                val_4 = item.density;
            }
            
            .Min = (float)val_4;
            this.AddFilterToItem(item:  item, filter:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetNameFilters(Mapbox.Unity.Map.PrefabItemOptions item)
        {
            string val_5;
            if((System.String.IsNullOrEmpty(value:  item.nameString)) == true)
            {
                    return;
            }
            
            string val_2 = "";
            bool val_3 = item.namePropertyFromFindByTypeDictionary.TryGetValue(key:  item.findByType, value: out  val_2);
            if(item.findByType != 1)
            {
                    return;
            }
            
            Mapbox.Unity.MeshGeneration.Filters.LayerFilter val_4 = new Mapbox.Unity.MeshGeneration.Filters.LayerFilter(filterOperation:  0);
            if(val_4 != null)
            {
                    .Key = val_2;
                val_5 = item.nameString;
            }
            else
            {
                    mem[16] = val_2;
                val_5 = item.nameString;
            }
            
            .PropertyValue = val_5;
            this.AddFilterToItem(item:  item, filter:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddFilterToItem(Mapbox.Unity.Map.PrefabItemOptions item, Mapbox.Unity.MeshGeneration.Filters.LayerFilter filter)
        {
            Mapbox.Unity.Map.VectorFilterOptions val_2;
            if(!=0)
            {
                goto label_2;
            }
            
            Mapbox.Unity.Map.VectorFilterOptions val_1 = null;
            val_2 = val_1;
            val_1 = new Mapbox.Unity.Map.VectorFilterOptions();
            mem2[0] = val_2;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            label_2:
            (Mapbox.Unity.Map.VectorFilterOptions)[1152921519723122864].filters.Add(item:  filter);
            filter.PropertyValue = item._combinerType;
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Unity.Map.LocationPrefabCategories> GetSelectedCategoriesList(Mapbox.Unity.Map.LocationPrefabCategories selectedCategories)
        {
            var val_15;
            var val_16;
            System.Collections.Generic.List<Mapbox.Unity.Map.LocationPrefabCategories> val_1 = new System.Collections.Generic.List<Mapbox.Unity.Map.LocationPrefabCategories>();
            if((selectedCategories + 1) < 2)
            {
                    return val_1;
            }
            
            System.Collections.IEnumerator val_5 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
            label_23:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_5.Current});
            if(((val_10 + 1) < 2) || ((val_10 & selectedCategories) == 0))
            {
                goto label_23;
            }
            
            val_1.Add(item:  val_10);
            goto label_23;
            label_12:
            val_15 = 0;
            val_16 = 101;
            if(val_5 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_5.Dispose();
            }
            
            if( == 101)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Create(Mapbox.VectorTile.VectorTileLayer layer, Mapbox.Unity.MeshGeneration.Data.UnityTile tile, System.Action<Mapbox.Unity.MeshGeneration.Data.UnityTile, Mapbox.Unity.MeshGeneration.Interfaces.LayerVisualizerBase> callback)
        {
            var val_3;
            var val_5;
            if(!=0)
            {
                    val_3 = null;
                val_5 = mem[static_value_04282000 + 200];
                val_5 = static_value_04282000 + 200;
            }
            
            val_3 = null;
            val_5 = mem[static_value_04282000 + 200];
            val_5 = static_value_04282000 + 200;
            var val_2 = (((static_value_04282000 + 200 + Mapbox.Unity.Map.PrefabItemOptions.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_3) ? 69738496 : 0;
            this.BuildFeatureFromLatLon(layer:  layer, tile:  tile);
            if(callback == null)
            {
                    return;
            }
            
            callback.Invoke(arg1:  tile, arg2:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildFeatureFromLatLon(Mapbox.VectorTile.VectorTileLayer layer, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_21;
            var val_22;
            var val_23;
            if(tile.TileState == 0)
            {
                    return;
            }
            
            val_21 = 1152921505117814784;
            if(!=0)
            {
                    val_22 = null;
            }
            
            val_22 = null;
            val_23 = 0;
            var val_2 = (((static_value_04282000 + 200 + (Mapbox.Unity.Map.PrefabItemOptions.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_22) ? 69738496 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationPrefabsLayerVisualizer()
        {
            this.maxDensity = 30;
            mem[1152921519723705896] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
