using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SpawnOnMap : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _locationStrings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d[] _locations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _spawnScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _markerPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _spawnedObjects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_7;
            this._locations = new Mapbox.Utils.Vector2d[0];
            this._spawnedObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
            val_7 = 0;
            goto label_2;
            label_18:
            Mapbox.Utils.Vector2d val_3 = Mapbox.Unity.Utilities.Conversions.StringToLatLon(s:  this._locationStrings[0]);
            this._locations[0] = val_3;
            this._locations[0] = val_3.y;
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._markerPrefab);
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = this._locations[0], y = this._locations[0], z = V2.16B};
            val_4.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._spawnedObjects.Add(item:  val_4);
            val_7 = 1;
            label_2:
            if(val_7 < this._locationStrings.Length)
            {
                goto label_18;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            int val_1 = this._spawnedObjects.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            var val_7 = 0;
            do
            {
                UnityEngine.GameObject val_2 = this._spawnedObjects.Item[0];
                val_2.transform.localPosition = new UnityEngine.Vector3() {x = this._locations[val_8], y = this._locations[val_8], z = V2.16B};
                val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_7 = val_7 + 1;
                val_8 = val_8 + 16;
            }
            while(val_1 != val_7);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SpawnOnMap()
        {
            this._spawnScale = 100f;
        }
    
    }

}
