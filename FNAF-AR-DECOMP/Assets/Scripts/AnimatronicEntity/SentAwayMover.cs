using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SentAwayMover : IMoveState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SentAwayMover()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SentAwayMover(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity animatronicEntity, float delta)
        {
            AnimatronicEntity.AnimatronicEntity val_2;
            var val_3;
            val_2 = animatronicEntity;
            this._animatronicEntityDomain.<MapMovementUtilities>k__BackingField.MoveInDirection(entity:  val_2, direction:  new Mapbox.Utils.Vector2d() {x = animatronicEntity.<SentAnimatronicData>k__BackingField.<direction>k__BackingField, y = V10.16B}, delta:  delta);
            if((animatronicEntity.<distanceFromPlayerData>k__BackingField._distance) > 0f)
            {
                    val_2 = animatronicEntity.<distanceFromPlayerData>k__BackingField;
                var val_1 = ((animatronicEntity.<distanceFromPlayerData>k__BackingField.<initialized>k__BackingField) == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
    
    }

}
