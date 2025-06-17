using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DirectionsFactory : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier[] MeshModifiers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material _material;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform[] _waypoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector3> _cachedWaypoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float UpdateFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Directions.Directions _directions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _counter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _directionsGO;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _recalculateNext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            if(this._map == 0)
            {
                    this._map = UnityEngine.Object.FindObjectOfType<Mapbox.Unity.Map.AbstractMap>();
            }
            
            this._directions = Mapbox.Unity.MapboxAccess.Instance.Directions;
            this._map.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.DirectionsFactory::Query()));
            this._map.add_OnUpdated(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.DirectionsFactory::Query()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            var val_5;
            var val_6;
            this._cachedWaypoints = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  this._waypoints.Length);
            val_5 = 0;
            goto label_2;
            label_7:
            UnityEngine.Vector3 val_2 = this._waypoints[0].position;
            this._cachedWaypoints.Add(item:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_5 = 1;
            label_2:
            if(val_5 < this._waypoints.Length)
            {
                goto label_7;
            }
            
            val_6 = 0;
            this._recalculateNext = false;
            goto label_8;
            label_12:
            Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier val_6 = this.MeshModifiers[0];
            val_6 = 1;
            label_8:
            if(val_6 < this.MeshModifiers.Length)
            {
                goto label_12;
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.QueryTimer());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDestroy()
        {
            this._map.remove_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.DirectionsFactory::Query()));
            this._map.remove_OnUpdated(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.DirectionsFactory::Query()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Query()
        {
            var val_9;
            Mapbox.Utils.Vector2d[] val_2 = new Mapbox.Utils.Vector2d[0];
            if(this._waypoints.Length >= 1)
            {
                    var val_10 = 0;
                do
            {
                Mapbox.Utils.Vector2d val_3 = this._map.CenterMercator;
                Mapbox.Utils.Vector2d val_5 = Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(t:  this._waypoints[val_10], refPoint:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, scale:  this._map.WorldRelativeScale);
                val_10 = val_10 + 1;
                mem2[0] = val_5.x;
                mem2[0] = val_5.y;
            }
            while((this._waypoints.Length & 4294967295) != val_10);
            
            }
            
            val_9 = null;
            val_9 = null;
            Mapbox.Directions.DirectionResource val_6 = new Mapbox.Directions.DirectionResource(coordinates:  val_2, profile:  Mapbox.Directions.RoutingProfile.Driving);
            val_6.Steps = new System.Nullable<System.Boolean>() {HasValue = false};
            Mapbox.Platform.IAsyncRequest val_8 = this._directions.Query(direction:  val_6, callback:  new System.Action<Mapbox.Directions.DirectionsResponse>(object:  this, method:  System.Void Mapbox.Unity.MeshGeneration.Factories.DirectionsFactory::HandleDirectionsResponse(Mapbox.Directions.DirectionsResponse response)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerator QueryTimer()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DirectionsFactory.<QueryTimer>d__14();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleDirectionsResponse(Mapbox.Directions.DirectionsResponse response)
        {
            var val_10;
            var val_29;
            var val_30;
            System.Func<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier, System.Boolean> val_32;
            val_29 = response;
            if(val_29 == null)
            {
                    return;
            }
            
            if(val_29.Routes == null)
            {
                    return;
            }
            
            if(val_29.Routes.Count < 1)
            {
                    return;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector3> val_5 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            List.Enumerator<T> val_9 = val_29.Routes.Item[0].Geometry.GetEnumerator();
            label_12:
            if(((-2047650832) & 1) == 0)
            {
                goto label_8;
            }
            
            Mapbox.Utils.Vector2d val_12 = val_10.Min;
            Mapbox.Utils.Vector2d val_13 = this._map.CenterMercator;
            Mapbox.Utils.Vector2d val_15 = Mapbox.Unity.Utilities.Conversions.GeoToWorldPosition(lat:  val_12.x, lon:  val_12.y, refPoint:  new Mapbox.Utils.Vector2d() {x = val_13.x, y = val_13.y}, scale:  this._map.WorldRelativeScale);
            UnityEngine.Vector3 val_16 = Mapbox.Unity.Utilities.VectorExtensions.ToVector3xz(v:  new Mapbox.Utils.Vector2d() {x = val_15.x, y = val_15.y});
            val_5.Add(item:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            goto label_12;
            label_8:
            long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519739065328});
            Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity val_19 = new Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity();
            (Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity)[1152921519739150448].Points.Add(item:  val_5);
            val_30 = null;
            val_30 = null;
            val_32 = DirectionsFactory.<>c.<>9__15_0;
            if(val_32 == null)
            {
                    System.Func<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier, System.Boolean> val_20 = null;
                val_32 = val_20;
                val_20 = new System.Func<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier, System.Boolean>(object:  DirectionsFactory.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DirectionsFactory.<>c::<HandleDirectionsResponse>b__15_0(Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier x));
                DirectionsFactory.<>c.<>9__15_0 = val_32;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            System.Collections.Generic.IEnumerator<T> val_23 = System.Linq.Enumerable.Where<Mapbox.Unity.MeshGeneration.Modifiers.MeshModifier>(source:  this.MeshModifiers, predicate:  val_20).GetEnumerator();
            label_46:
            var val_32 = 0;
            val_32 = val_32 + 1;
            if(val_23.MoveNext() == false)
            {
                goto label_38;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            float val_28 = this._map.WorldRelativeScale;
            if(val_23.Current != 0)
            {
                goto label_46;
            }
            
            goto label_46;
            label_38:
            val_29 = 0;
            if(val_23 == null)
            {
                
            }
            else
            {
                    var val_34 = 0;
                val_34 = val_34 + 1;
                val_23.Dispose();
            }
            
            UnityEngine.GameObject val_30 = this.CreateGameObject(data:  new Mapbox.Unity.MeshGeneration.Data.MeshData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject CreateGameObject(Mapbox.Unity.MeshGeneration.Data.MeshData data)
        {
            System.Collections.Generic.List<System.Int32> val_11;
            System.Collections.Generic.List<UnityEngine.Vector3> val_12;
            if(this._directionsGO != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this._directionsGO);
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "direction waypoint  entity");
            this._directionsGO = val_2;
            UnityEngine.Mesh val_4 = val_2.AddComponent<UnityEngine.MeshFilter>().mesh;
            val_11 = 1152921519699365760;
            int val_5 = data.Triangles.Count;
            if(val_4 != null)
            {
                    val_4.subMeshCount = val_5;
                val_12 = data.Vertices;
            }
            else
            {
                    0.subMeshCount = val_5;
                val_12 = data.Vertices;
            }
            
            val_4.SetVertices(inVertices:  val_12);
            int val_6 = data.Triangles.Count;
            this._counter = val_6;
            if(val_6 >= 1)
            {
                    var val_11 = 0;
                do
            {
                val_11 = data.Triangles.Item[0];
                val_4.SetTriangles(triangles:  val_11, submesh:  0);
                val_11 = val_11 + 1;
            }
            while(val_11 < this._counter);
            
            }
            
            int val_8 = data.UV.Count;
            this._counter = val_8;
            if(val_8 >= 1)
            {
                    var val_12 = 0;
                do
            {
                val_11 = data.UV.Item[0];
                val_4.SetUVs(channel:  0, uvs:  val_11);
                val_12 = val_12 + 1;
            }
            while(val_12 < this._counter);
            
            }
            
            val_4.RecalculateNormals();
            this._directionsGO.AddComponent<UnityEngine.MeshRenderer>().material = this._material;
            return (UnityEngine.GameObject)this._directionsGO;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DirectionsFactory()
        {
            this.UpdateFrequency = 2f;
        }
    
    }

}
