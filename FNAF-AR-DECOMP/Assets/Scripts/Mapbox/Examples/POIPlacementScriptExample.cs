using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class POIPlacementScriptExample : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.AbstractMap map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject prefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _prefabInstances;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.map.SpawnPrefabByCategory(prefab:  this.prefab, categories:  1, density:  10, callback:  new System.Action<System.Collections.Generic.List<UnityEngine.GameObject>>(object:  this, method:  System.Void Mapbox.Examples.POIPlacementScriptExample::HandlePrefabSpawned(System.Collections.Generic.List<UnityEngine.GameObject> instances)), scaleDownWithWorld:  true, locationItemName:  "SpawnFromScriptLayer");
            Mapbox.Utils.Vector2d val_2 = new Mapbox.Utils.Vector2d(x:  37.784179, y:  -122.401583);
            if(this.map != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandlePrefabSpawned(System.Collections.Generic.List<UnityEngine.GameObject> instances)
        {
            if(instances.Count < 1)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  instances.Item[0].name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public POIPlacementScriptExample()
        {
        
        }
    
    }

}
