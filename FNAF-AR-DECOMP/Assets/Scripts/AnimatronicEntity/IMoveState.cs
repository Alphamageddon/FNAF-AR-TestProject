using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IMoveState
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool DidMoveEntity(AnimatronicEntity.AnimatronicEntity entity, float delta); // 0
    
    }

}
