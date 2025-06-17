using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FarAwayChooser : IChooseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected FarAwayChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FarAwayChooser(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidChooseNewState(AnimatronicEntity.AnimatronicEntity animatronicEntity)
        {
            AnimatronicEntity.AnimatronicEntity val_4;
            var val_5;
            AnimatronicEntity.AnimatronicEntityConfig val_6;
            var val_7;
            val_4 = animatronicEntity;
            if(val_4 == null)
            {
                    val_5 = 0;
            }
            
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField) == null)
            {
                    val_5 = 0;
            }
            
            if(this._animatronicEntityDomain == null)
            {
                    val_5 = 0;
            }
            
            val_6 = this._animatronicEntityDomain._animatronicEntityConfig;
            if(val_6 == null)
            {
                    val_5 = 0;
            }
            
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) >= this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerTravelMode)
            {
                goto label_4;
            }
            
            val_6 = animatronicEntity.<moveStateData>k__BackingField;
            if(val_6 == null)
            {
                    val_5 = 0;
            }
            
            bool val_1 = this.ValidNode(node:  animatronicEntity.<moveStateData>k__BackingField.<startNode>k__BackingField);
            if(val_1 == false)
            {
                goto label_8;
            }
            
            bool val_2 = val_1.ValidNode(node:  animatronicEntity.<moveStateData>k__BackingField.<endNode>k__BackingField);
            if((val_2 == false) || ((val_2.FinishedMoving(moveData:  animatronicEntity.<moveStateData>k__BackingField)) == false))
            {
                goto label_8;
            }
            
            if((animatronicEntity.<moveStateData>k__BackingField.<nodeCounter>k__BackingField) >= (animatronicEntity.<moveStateData>k__BackingField.<maxNodes>k__BackingField))
            {
                goto label_9;
            }
            
            this.GetNextPoint(entity:  val_4);
            label_8:
            val_7 = 0;
            return (bool)val_7;
            label_4:
            val_4 = animatronicEntity.<stateData>k__BackingField;
            val_4.animatronicState = 14;
            label_13:
            val_7 = 1;
            return (bool)val_7;
            label_9:
            animatronicEntity.<moveStateData>k__BackingField.<timeElapsed>k__BackingField = 0f;
            animatronicEntity.<stateData>k__BackingField.animatronicState = 9;
            val_6.SetEndNode(newNode:  0);
            goto label_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidNode(MapMode.MovementNode.LocationNode node)
        {
            if(node == null)
            {
                    return false;
            }
            
            Mapbox.Utils.Vector2d val_1 = node.PositionMeters;
            Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.zero;
            if((Mapbox.Utils.Vector2d.op_Inequality(lhs:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, rhs:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y})) == false)
            {
                    return false;
            }
            
            Mapbox.Utils.Vector2d val_4 = node.PositionLatLon;
            Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.zero;
            return Mapbox.Utils.Vector2d.op_Inequality(lhs:  new Mapbox.Utils.Vector2d() {x = val_4.x, y = val_4.y}, rhs:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool FinishedMoving(AnimatronicEntity.MoveStateData moveData)
        {
            float val_2;
            if(moveData != null)
            {
                    val_2 = moveData.<timeElapsed>k__BackingField;
                return (bool)(val_2 >= (moveData.<nodeTravelTime>k__BackingField)) ? 1 : 0;
            }
            
            val_2 = 1.85775E-36f;
            return (bool)(val_2 >= (moveData.<nodeTravelTime>k__BackingField)) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetNextPoint(AnimatronicEntity.AnimatronicEntity entity)
        {
            var val_4;
            MapMode.MovementNode.LocationNode val_5;
            Game.Devices.DevicesDomain val_6;
            if((entity.<moveStateData>k__BackingField) != null)
            {
                    val_4 = entity.<moveStateData>k__BackingField;
                val_5 = entity.<moveStateData>k__BackingField.<startNode>k__BackingField;
            }
            else
            {
                    val_4 = 16;
                val_5 = 11993091;
            }
            
            mem[16] = entity.<moveStateData>k__BackingField.<endNode>k__BackingField;
            entity.<moveStateData>k__BackingField.SetEndNode(newNode:  this._animatronicEntityDomain._movementNodeDomain.GetNextPoint(start:  val_5, end:  entity.<moveStateData>k__BackingField.<endNode>k__BackingField, radius:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode));
            int val_4 = entity.<moveStateData>k__BackingField.<nodeCounter>k__BackingField;
            entity.<moveStateData>k__BackingField.<timeElapsed>k__BackingField = 0f;
            val_4 = val_4 + 1;
            entity.<moveStateData>k__BackingField.<nodeCounter>k__BackingField = val_4;
            Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            val_6 = val_2.devicesDomain;
            if(val_2.devicesDomain.AllPlayerDevices != null)
            {
                    val_6 = val_2.devicesDomain.AllPlayerDevices.active.Jammer;
                if(val_6.Count >= 1)
            {
                    int val_5 = entity.<moveStateData>k__BackingField.<nodeCounter>k__BackingField;
                val_5 = val_5 - 1;
                entity.<moveStateData>k__BackingField.<nodeCounter>k__BackingField = val_5;
            }
            
            }
            
            this._animatronicEntityDomain.<animatronicEntityUpdater>k__BackingField._shouldSave = true;
        }
    
    }

}
