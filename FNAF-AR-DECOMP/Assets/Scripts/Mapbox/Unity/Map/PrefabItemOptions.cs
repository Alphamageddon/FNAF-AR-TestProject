using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PrefabItemOptions : VectorSubLayerProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Mapbox.Unity.Map.VectorPrimitiveType primitiveType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool combineMeshes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Mapbox.Unity.Map.ExtrusionType extrusionType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, string> layerNameFromFindByTypeDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, string> categoryPropertyFromFindByTypeDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, string> densityPropertyFromFindByTypeDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, string> namePropertyFromFindByTypeDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Mapbox.Unity.MeshGeneration.Modifiers.PositionTargetType _movePrefabFeaturePositionTo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Mapbox.Unity.MeshGeneration.Filters.LayerFilterCombinerOperationType _combinerType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.SpawnPrefabOptions spawnPrefabOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LocationPrefabFindBy findByType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LocationPrefabCategories categories;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string nameString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] coordinates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int density;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isActive { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool snapToTerrain { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string prefabItemName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> OnAllPrefabsInstantiated { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_isActive()
        {
            if(X19 != 0)
            {
                    return (bool)X19 + 24;
            }
            
            return (bool)X19 + 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_isActive(bool value)
        {
            mem2[0] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_snapToTerrain()
        {
            if(X19 != 0)
            {
                    return (bool)X19 + 56;
            }
            
            return (bool)X19 + 56;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_snapToTerrain(bool value)
        {
            mem2[0] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_prefabItemName()
        {
            if(X19 != 0)
            {
                    return (string)X19 + 32;
            }
            
            return (string)X19 + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_prefabItemName(string value)
        {
            mem2[0] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> get_OnAllPrefabsInstantiated()
        {
            if(this.spawnPrefabOptions != null)
            {
                    return (System.Action<System.Collections.Generic.List<UnityEngine.GameObject>>)this.spawnPrefabOptions.AllPrefabsInstatiated;
            }
            
            return (System.Action<System.Collections.Generic.List<UnityEngine.GameObject>>)this.spawnPrefabOptions.AllPrefabsInstatiated;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OnAllPrefabsInstantiated(System.Action<System.Collections.Generic.List<UnityEngine.GameObject>> value)
        {
            this.spawnPrefabOptions.AllPrefabsInstatiated = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PrefabItemOptions()
        {
            System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String> val_1 = new System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  2, value:  "");
            }
            else
            {
                    val_1.Add(key:  2, value:  "");
            }
            
            val_1.Add(key:  0, value:  "poi_label");
            val_1.Add(key:  1, value:  "poi_label");
            this.layerNameFromFindByTypeDictionary = val_1;
            System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String> val_2 = new System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String>();
            if(val_2 != null)
            {
                    val_2.Add(key:  2, value:  "");
            }
            else
            {
                    val_2.Add(key:  2, value:  "");
            }
            
            val_2.Add(key:  0, value:  "maki");
            val_2.Add(key:  1, value:  "name");
            this.categoryPropertyFromFindByTypeDictionary = val_2;
            System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String> val_3 = new System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String>();
            if(val_3 != null)
            {
                    val_3.Add(key:  2, value:  "");
            }
            else
            {
                    val_3.Add(key:  2, value:  "");
            }
            
            val_3.Add(key:  0, value:  "localrank");
            val_3.Add(key:  1, value:  "localrank");
            this.densityPropertyFromFindByTypeDictionary = val_3;
            System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String> val_4 = new System.Collections.Generic.Dictionary<Mapbox.Unity.Map.LocationPrefabFindBy, System.String>();
            if(val_4 != null)
            {
                    val_4.Add(key:  2, value:  "");
            }
            else
            {
                    val_4.Add(key:  2, value:  "");
            }
            
            val_4.Add(key:  0, value:  "");
            val_4.Add(key:  1, value:  "name");
            this.namePropertyFromFindByTypeDictionary = val_4;
            this._movePrefabFeaturePositionTo = 4294967297;
            this.density = 15;
            this.nameString = "Name";
        }
    
    }

}
