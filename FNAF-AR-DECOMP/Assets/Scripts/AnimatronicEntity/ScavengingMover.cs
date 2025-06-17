using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScavengingMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected ScavengingMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScavengingMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            Mapbox.Unity.Map.AbstractMap val_4 = this._animatronicEntityDomain._map;
            if(val_4 != 0)
            {
                    val_4 = this._animatronicEntityDomain._map;
                if(val_4.isInitialized != false)
            {
                    val_4 = animatronicEntity.<scavengingData>k__BackingField.nextPoint;
                Mapbox.Utils.Vector2d val_3 = val_4.PositionMeters;
                this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.MoveTowardsPosition(entity:  animatronicEntity, positionMeters:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, delta:  delta);
            }
            
            }
            
            this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.UpdateDistanceToNextPoint(entity:  animatronicEntity);
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDistanceToNextPoint(AnimatronicEntity.AnimatronicEntity entity)
        {
            var val_4;
            AnimatronicEntity.ScavengingData val_5;
            if(entity != null)
            {
                    val_4 = entity;
                val_5 = entity.<scavengingData>k__BackingField;
            }
            else
            {
                    val_4 = 152;
                val_5 = 6486152;
            }
            
            Mapbox.Utils.Vector2d val_1 = 1027.PositionLatLon;
            Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = entity.<geoPositionData>k__BackingField.<geoPosition>k__BackingField, y = V8.16B}, b:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
            double val_3 = val_2.x.magnitude;
            if(val_5 != 0)
            {
                    return;
            }
        
        }
    
    }

}
