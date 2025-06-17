using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MovementNodeUtilities
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int MAX_DEGREES = 360;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeDomain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeProximityTweaks _tweaks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2dBounds _baseBoundingBox;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds BaseBoundingBox { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds get_BaseBoundingBox()
        {
            Mapbox.Utils.Vector2dBounds val_0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MovementNodeUtilities(MapMode.MovementNode.MovementNodeDomain domain)
        {
            this._domain = domain;
            this._tweaks = domain._movementNodeConfig.MovementNodeProximityTweaks;
            this.InitBoundingBox();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitBoundingBox()
        {
            MapMode.MovementNode.MovementNodeProximityTweaks val_5;
            MapMode.MovementNode.MovementNodeProximityTweaks val_6;
            val_5 = this._tweaks;
            if(this._tweaks != null)
            {
                goto label_0;
            }
            
            val_5 = this._tweaks;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            label_0:
            Mapbox.Utils.Vector2d val_1 = new Mapbox.Utils.Vector2d(x:  (double)-this._tweaks.workshopMaxWestMeters, y:  (double)-this._tweaks.workshopMaxSouthMeters);
            val_6 = this._tweaks;
            if(this._tweaks != null)
            {
                goto label_2;
            }
            
            val_6 = this._tweaks;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            label_2:
            Mapbox.Utils.Vector2d val_2 = new Mapbox.Utils.Vector2d(x:  (double)this._tweaks.workshopMaxEastMeters, y:  (double)this._tweaks.workshopMaxNorthMeters);
            Mapbox.Utils.Vector2d val_3 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            this._baseBoundingBox = 0;
            mem[1152921524626263560] = 0;
            mem[1152921524626263576] = 0;
            return;
            label_3:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d GetRandomPointAroundPlayerForRadius(float radius)
        {
            Mapbox.Utils.Vector2d val_1 = this.GetPlayerPositionLatLon();
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_5 = new Mapbox.Utils.Vector2d(x:  (double)UnityEngine.Random.Range(min:  -1f, max:  1f), y:  (double)UnityEngine.Random.Range(min:  -1f, max:  1f));
            Mapbox.Utils.Vector2d val_6 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = (double)UnityEngine.Random.Range(min:  -1f, max:  1f), y = (double)UnityEngine.Random.Range(min:  -1f, max:  1f)}, d:  (double)radius);
            Mapbox.Utils.Vector2d val_7 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y});
            Mapbox.Utils.Vector2d val_8 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_7.x, y = val_7.y});
            return new Mapbox.Utils.Vector2d() {x = val_8.x, y = val_8.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Utils.Vector2d> GetNodesForAllRadii()
        {
            UnityEngine.Random.InitState(seed:  (int)UnityEngine.Time.time);
            System.Collections.Generic.List<Mapbox.Utils.Vector2d> val_2 = new System.Collections.Generic.List<Mapbox.Utils.Vector2d>();
            val_2.AddRange(collection:  this.GetNodesForRadius(radius:  this._tweaks.movementNodeOuterRadius));
            val_2.AddRange(collection:  this.GetNodesForRadius(radius:  this._tweaks.movementNodeMiddleRadius));
            val_2.AddRange(collection:  this.GetNodesForRadius(radius:  this._tweaks.movementNodeInnerRadius));
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Utils.Vector2d> GetNodesForRadius(float radius)
        {
            float val_15 = radius;
            System.Collections.Generic.List<Mapbox.Utils.Vector2d> val_1 = new System.Collections.Generic.List<Mapbox.Utils.Vector2d>();
            Mapbox.Utils.Vector2d val_2 = this.GetPlayerPositionLatLon();
            Mapbox.Utils.Vector2d val_3 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  val_15 = radius);
            if(this._tweaks.nodesPerRing < 1)
            {
                    return val_1;
            }
            
            var val_16 = 0;
            do
            {
                float val_15 = 0f;
                val_15 = ((float)360 / this._tweaks.nodesPerRing) * val_15;
                UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_15 + ((float)UnityEngine.Random.Range(min:  0, max:  104)));
                UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                Mapbox.Utils.Vector2d val_12 = new Mapbox.Utils.Vector2d(x:  (double)val_11.x, y:  (double)val_11.y);
                Mapbox.Utils.Vector2d val_13 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, b:  new Mapbox.Utils.Vector2d() {x = val_12.x, y = val_12.y});
                Mapbox.Utils.Vector2d val_14 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = val_13.x, y = val_13.y});
                val_15 = val_14.x;
                val_1.Add(item:  new Mapbox.Utils.Vector2d() {x = val_15, y = val_14.y});
                val_16 = val_16 + 1;
            }
            while(this._tweaks.nodesPerRing != val_16);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d GetPlayerPositionLatLon()
        {
            if(this._domain != null)
            {
                goto label_0;
            }
            
            this._domain = this._domain;
            if(this._domain == null)
            {
                goto label_1;
            }
            
            label_0:
            UnityEngine.Vector3 val_2 = this._domain._playerTarget.transform.position;
            if(this._domain._map != null)
            {
                goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_3A8;
            }
            
            goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_3A8;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d GetPlayerPositionMeters()
        {
            Mapbox.Utils.Vector2d val_1 = this.GetPlayerPositionLatLon();
            return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
        }
    
    }

}
