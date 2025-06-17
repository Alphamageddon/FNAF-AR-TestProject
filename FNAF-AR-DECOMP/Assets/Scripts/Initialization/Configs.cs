using UnityEngine;

namespace Initialization
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Configs : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityConfig _animatronicEntityConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.MovementNodeConfig _movementNodeConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectConfig _geoPositionObjectConfig;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityConfig AnimatronicEntityConfig { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeConfig MovementNodeConfig { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionObjectConfig GeoPositionObjectConfig { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityConfig get_AnimatronicEntityConfig()
        {
            return (AnimatronicEntity.AnimatronicEntityConfig)this._animatronicEntityConfig;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.MovementNodeConfig get_MovementNodeConfig()
        {
            return (MapMode.MovementNode.MovementNodeConfig)this._movementNodeConfig;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.GeoPositionObject.GeoPositionObjectConfig get_GeoPositionObjectConfig()
        {
            return (MapMode.GeoPositionObject.GeoPositionObjectConfig)this._geoPositionObjectConfig;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Configs()
        {
        
        }
    
    }

}
