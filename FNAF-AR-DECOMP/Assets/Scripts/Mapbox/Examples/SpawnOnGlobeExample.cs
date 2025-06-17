using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SpawnOnGlobeExample : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _locations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _spawnScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _markerPrefab;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            goto label_1;
            label_18:
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._markerPrefab);
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  this._locations[0]);
            Mapbox.Unity.Map.ElevationLayerProperties val_4 = this._map.Terrain.LayerProperty;
            UnityEngine.Vector3 val_6 = Mapbox.Unity.Utilities.Conversions.GeoToWorldGlobePosition(latLong:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, radius:  val_4.modificationOptions.earthRadius);
            val_1.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this._spawnScale);
            val_1.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            val_1.transform.SetParent(p:  this.transform);
            0 = 1;
            label_1:
            if(0 < this._locations.Length)
            {
                goto label_18;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SpawnOnGlobeExample()
        {
            this._spawnScale = 100f;
        }
    
    }

}
