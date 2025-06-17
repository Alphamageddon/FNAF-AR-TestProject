using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AstronautDirections : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Directions _directions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<System.Collections.Generic.List<UnityEngine.Vector3>> callback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._directions = Mapbox.Unity.MapboxAccess.Instance.Directions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Query(System.Action<System.Collections.Generic.List<UnityEngine.Vector3>> vecs, UnityEngine.Transform start, UnityEngine.Transform end, Mapbox.Unity.Map.AbstractMap map)
        {
            var val_11;
            if(this.callback == null)
            {
                    this.callback = vecs;
            }
            
            this._map = map;
            Mapbox.Utils.Vector2d[] val_1 = new Mapbox.Utils.Vector2d[2];
            Mapbox.Utils.Vector2d val_2 = this._map.CenterMercator;
            Mapbox.Utils.Vector2d val_4 = Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(t:  start, refPoint:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, scale:  this._map.WorldRelativeScale);
            val_1[0] = val_4;
            val_1[1] = val_4.y;
            Mapbox.Utils.Vector2d val_5 = this._map.CenterMercator;
            Mapbox.Utils.Vector2d val_7 = Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(t:  end, refPoint:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y}, scale:  this._map.WorldRelativeScale);
            val_1[2] = val_7;
            val_1[3] = val_7.y;
            val_11 = null;
            val_11 = null;
            Mapbox.Directions.DirectionResource val_8 = new Mapbox.Directions.DirectionResource(coordinates:  val_1, profile:  Mapbox.Directions.RoutingProfile.Walking);
            val_8.Steps = new System.Nullable<System.Boolean>() {HasValue = false};
            Mapbox.Platform.IAsyncRequest val_10 = this._directions.Query(direction:  val_8, callback:  new System.Action<Mapbox.Directions.DirectionsResponse>(object:  this, method:  System.Void Mapbox.Examples.AstronautDirections::HandleDirectionsResponse(Mapbox.Directions.DirectionsResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleDirectionsResponse(Mapbox.Directions.DirectionsResponse response)
        {
            var val_9;
            var val_19;
            System.Action<System.Collections.Generic.List<UnityEngine.Vector3>> val_20;
            val_19 = response;
            val_20 = this;
            if(val_19.Routes == null)
            {
                    return;
            }
            
            if(val_19.Routes.Count < 1)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3> val_4 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_19 = val_19.Routes.Item[0].Geometry;
            List.Enumerator<T> val_8 = val_19.GetEnumerator();
            label_14:
            if(((-1945051584) & 1) == 0)
            {
                goto label_22;
            }
            
            Mapbox.Utils.Vector2d val_11 = val_9.Min;
            Mapbox.Utils.Vector2d val_12 = this._map.CenterMercator;
            Mapbox.Utils.Vector2d val_14 = Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(lat:  val_11.x, lon:  val_11.y, refPoint:  new Mapbox.Utils.Vector2d() {x = val_12.x, y = val_12.y}, scale:  this._map.WorldRelativeScale);
            UnityEngine.Vector3 val_15 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_14.x, y = val_14.y});
            val_4.Add(item:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            goto label_14;
            label_22:
            val_20 = this.callback;
            val_20.Invoke(obj:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AstronautDirections()
        {
        
        }
    
    }

}
