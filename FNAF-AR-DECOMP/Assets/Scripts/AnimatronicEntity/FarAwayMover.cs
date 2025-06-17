using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FarAwayMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected FarAwayMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FarAwayMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            AnimatronicEntity.MoveStateData val_1;
            float val_2;
            val_1 = animatronicEntity.<moveStateData>k__BackingField;
            if(val_1 != null)
            {
                    val_2 = animatronicEntity.<moveStateData>k__BackingField.<timeElapsed>k__BackingField;
            }
            else
            {
                    val_1 = 40;
                val_2 = 1.85775E-36f;
            }
            
            delta = val_2 + delta;
            mem[40] = delta;
            this.MoveEntityPositionTowardsNextNode(animatronicEntity:  animatronicEntity, delta:  delta);
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MoveEntityPositionTowardsNextNode(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            Mapbox.Unity.Map.AbstractMap val_4 = this._animatronicEntityDomain._map;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_4 = this._animatronicEntityDomain._map;
            if(val_4.isInitialized == false)
            {
                    return;
            }
            
            Mapbox.Utils.Vector2d val_3 = animatronicEntity.<moveStateData>k__BackingField.<endNode>k__BackingField.PositionLatLon;
            this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.LerpTowardsPoint(entity:  animatronicEntity, point:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y});
        }
    
    }

}
