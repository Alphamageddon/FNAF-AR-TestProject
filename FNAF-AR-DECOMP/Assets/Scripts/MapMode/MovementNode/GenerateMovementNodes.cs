using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GenerateMovementNodes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeDomain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<MapMode.MovementNode.LocationNode> _movementNodes;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenerateMovementNodes(MapMode.MovementNode.MovementNodeDomain domain)
        {
            this._domain = domain;
            this._movementNodes = domain.<container>k__BackingField._validMovementNodes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Generate()
        {
            var val_6;
            var val_11 = this;
            UnityEngine.Random.InitState(seed:  (int)UnityEngine.Time.time);
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            if(val_2 != null)
            {
                    val_2.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.nodesPerRing);
                val_2.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.nodesPerRing);
            }
            else
            {
                    val_2.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.nodesPerRing);
                val_2.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.nodesPerRing);
            }
            
            val_2.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.nodesPerRing);
            System.Collections.Generic.List<System.Single> val_3 = new System.Collections.Generic.List<System.Single>();
            val_3.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.movementNodeInnerRadius);
            val_3.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.movementNodeMiddleRadius);
            val_3.Add(item:  this._domain._movementNodeConfig.MovementNodeProximityTweaks.movementNodeOuterRadius);
            List.Enumerator<T> val_5 = this._domain._mapUtilities.GetNodesForAllRadii().GetEnumerator();
            label_16:
            if(((-1465071136) & 1) == 0)
            {
                goto label_15;
            }
            
            Mapbox.Utils.Vector2d val_8 = val_6.Min;
            this.TryAddMovementNode(positionLatLon:  new Mapbox.Utils.Vector2d() {x = val_8.x, y = val_8.y});
            goto label_16;
            label_15:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524616612320});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryAddMovementNode(Mapbox.Utils.Vector2d positionLatLon)
        {
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = positionLatLon.x, y = positionLatLon.y});
            this._movementNodes.Add(item:  MapMode.MovementNode.LocationNode.CreateNodeForMeters(type:  1, locationMeters:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, name:  ""));
        }
    
    }

}
