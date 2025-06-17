using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MovementNodeConfig : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeProximityTweaks MovementNodeProximityTweaks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double RelocateDistance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MovementNodeConfig()
        {
            this.RelocateDistance = 500;
        }
    
    }

}
