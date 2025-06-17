using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MovementPathGenerator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeDomain _domain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MovementPathGenerator(MapMode.MovementNode.MovementNodeDomain domain)
        {
            this._domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode GetNextPoint(MapMode.MovementNode.LocationNode start, MapMode.MovementNode.LocationNode end, float radius)
        {
            var val_4;
            var val_5;
            MapMode.MovementNode.LocationNode val_13;
            float val_13 = this._domain._movementNodeConfig.MovementNodeProximityTweaks.minWorkshopDistance;
            System.Collections.Generic.List<MapMode.MovementNode.LocationNode> val_1 = new System.Collections.Generic.List<MapMode.MovementNode.LocationNode>();
            MapMode.MovementNode.FallbackNode val_2 = new MapMode.MovementNode.FallbackNode();
            .<Node>k__BackingField = 0;
            .<Distance>k__BackingField = -2.2250738585072E-308;
            val_13 = val_13 + val_13;
            List.Enumerator<T> val_3 = this._domain.<container>k__BackingField._validMovementNodes.GetEnumerator();
            label_17:
            if(((-1464576480) & 1) == 0)
            {
                goto label_7;
            }
            
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            double val_7 = Mapbox.Utils.Vector2d.Distance(a:  new Mapbox.Utils.Vector2d() {x = end._positionMeters, y = V10.16B}, b:  new Mapbox.Utils.Vector2d() {x = val_6._emailDatas, y = val_6._emailIdsToBeDeletedOnServer});
            if((this.IsNextNodeValid(current:  end, previous:  start, nextNode:  val_6, radius:  radius)) == false)
            {
                goto label_17;
            }
            
            if(val_7 < 0)
            {
                    if(val_4 == 0)
            {
                goto label_12;
            }
            
            }
            
            if(((MapMode.MovementNode.FallbackNode)[1152921524617175712].<Distance>k__BackingField) <= val_7)
            {
                goto label_17;
            }
            
            .<Distance>k__BackingField = val_7;
            .<Node>k__BackingField = val_6;
            goto label_17;
            label_12:
            val_1.Add(item:  val_6);
            goto label_17;
            label_7:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524617106976});
            int val_11 = val_1.Count;
            if(val_11 <= 0)
            {
                goto label_29;
            }
            
            label_35:
            MapMode.MovementNode.LocationNode val_12 = val_11.SelectRandomProspect(prospects:  val_1);
            return val_13;
            label_29:
            val_13 = (MapMode.MovementNode.FallbackNode)[1152921524617175712].<Node>k__BackingField;
            if(val_13 != null)
            {
                    return val_13;
            }
            
            if((this._domain.<container>k__BackingField) != null)
            {
                goto label_35;
            }
            
            goto label_35;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode GetNextScavengePoint()
        {
            System.Collections.Generic.List<MapMode.MovementNode.LocationNode> val_10;
            MapMode.MovementNode.LocationNode val_11;
            System.Collections.Generic.List<MapMode.MovementNode.LocationNode> val_1 = null;
            val_10 = val_1;
            val_1 = new System.Collections.Generic.List<MapMode.MovementNode.LocationNode>();
            MapMode.MovementNode.FallbackNode val_2 = new MapMode.MovementNode.FallbackNode();
            .<Node>k__BackingField = 0;
            .<Distance>k__BackingField = -2.2250738585072E-308;
            System.Collections.Generic.List<MapMode.MovementNode.LocationNode> val_3 = this._domain.<container>k__BackingField.GetAllValidNodes();
            List.Enumerator<T> val_4 = val_3.GetEnumerator();
            label_6:
            if(((-1464349736) & 1) == 0)
            {
                goto label_4;
            }
            
            val_1.Add(item:  0.emailUIDataHandler);
            goto label_6;
            label_4:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524617333720});
            int val_8 = val_1.Count;
            if(val_8 <= 0)
            {
                goto label_13;
            }
            
            label_16:
            MapMode.MovementNode.LocationNode val_9 = val_8.SelectRandomProspect(prospects:  val_1);
            return val_11;
            label_13:
            val_11 = (MapMode.MovementNode.FallbackNode)[1152921524617381920].<Node>k__BackingField;
            val_10 = val_3;
            if(val_11 == null)
            {
                goto label_16;
            }
            
            return val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsNextNodeValid(MapMode.MovementNode.LocationNode current, MapMode.MovementNode.LocationNode previous, MapMode.MovementNode.LocationNode nextNode, float radius)
        {
            var val_4;
            if((System.String.op_Equality(a:  nextNode._id, b:  previous._id)) != true)
            {
                    if((this.ValidAngle(current:  current, node:  nextNode)) != false)
            {
                    val_4 = (~(this.IntersectsWithStalkingRadius(current:  current, node:  nextNode, radius:  radius))) & 1;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IntersectsWithStalkingRadius(MapMode.MovementNode.LocationNode current, MapMode.MovementNode.LocationNode node, float radius)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = node._positionMeters, y = V10.16B}, b:  new Mapbox.Utils.Vector2d() {x = current._positionMeters});
            Mapbox.Utils.Vector2d val_2 = this._domain._mapUtilities.GetPlayerPositionLatLon();
            Mapbox.Utils.Vector2d val_3 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, b:  new Mapbox.Utils.Vector2d() {x = current._positionMeters});
            double val_7 = val_4.x.magnitude;
            val_7 = (Mapbox.Utils.Mathd.Sin(d:  Mapbox.Utils.Vector2d.Angle(from:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, to:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y}))) * val_7;
            return (bool)(System.Math.Abs((float)val_7) < 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidAngle(MapMode.MovementNode.LocationNode current, MapMode.MovementNode.LocationNode node)
        {
            Mapbox.Utils.Vector2d val_1 = this._domain._mapUtilities.GetPlayerPositionLatLon();
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, b:  new Mapbox.Utils.Vector2d() {x = current._positionMeters});
            Mapbox.Utils.Vector2d val_4 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = node._positionMeters, y = val_3.y}, b:  new Mapbox.Utils.Vector2d() {x = current._positionMeters});
            return (bool)((Mapbox.Utils.Vector2d.Angle(from:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, to:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y})) < 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode SelectRandomProspect(System.Collections.Generic.List<MapMode.MovementNode.LocationNode> prospects)
        {
            State val_1 = UnityEngine.Random.state;
            UnityEngine.Random.InitState(seed:  TheGame.ServerTime.GetCurrentTime());
            UnityEngine.Random.state = new State() {s0 = val_1.s0, s1 = val_1.s1, s2 = val_1.s2, s3 = val_1.s3};
            return (MapMode.MovementNode.LocationNode)prospects.Item[UnityEngine.Random.Range(min:  0, max:  prospects.Count)];
        }
    
    }

}
