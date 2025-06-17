using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Accepters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBlockCoordAccepter
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnBlockUpdatedEvent(UnityEngine.Vector3 center, System.Collections.Generic.List<UnityEngine.Vector3> pointsToAdd, System.Collections.Generic.List<UnityEngine.Vector3> pointsToRemove); // 0
    
    }

}
