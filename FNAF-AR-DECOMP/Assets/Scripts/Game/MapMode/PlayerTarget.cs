using UnityEngine;

namespace Game.MapMode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayerTarget : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.SpriteRenderer profileIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _radioJammerFX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string className = "RecenterMapAroundPlayer";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Location.ILocationProvider _locationProvider;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider LocationProvider { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Location.ILocationProvider get_LocationProvider()
        {
            if(this._locationProvider != null)
            {
                    return val_2;
            }
            
            Mapbox.Unity.Location.ILocationProvider val_2 = Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider;
            this._locationProvider = val_2;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.map.add_OnUpdated(value:  new System.Action(object:  this, method:  System.Void Game.MapMode.PlayerTarget::MapManager_OnUpdated()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            this.UpdatePosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MapManager_OnUpdated()
        {
            this.UpdatePosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePosition()
        {
            float val_6;
            float val_7;
            Mapbox.Unity.Map.AbstractMap val_7 = this.map;
            if(val_7.isInitialized == false)
            {
                    return;
            }
            
            val_7 = this.transform;
            var val_8 = 0;
            val_8 = val_8 + 1;
            Mapbox.Unity.Location.Location val_5 = this.LocationProvider.CurrentLocation;
            val_7.localPosition = new UnityEngine.Vector3() {x = val_6, y = val_7, z = V2.16B};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SnapToCenterAroundPlayer()
        {
            var val_5;
            UnityEngine.Vector3 val_2 = this.transform.position;
            if(this.map != null)
            {
                    val_5 = this.map.InitialZoom;
            }
            else
            {
                    val_5 = 0.InitialZoom;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetProfileIcon(UnityEngine.Sprite icon)
        {
            this.profileIcon.sprite = icon;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowRadioJammer(bool show)
        {
            if(this._radioJammerFX.activeSelf ^ show == false)
            {
                    return;
            }
            
            this._radioJammerFX.SetActive(value:  show);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayerTarget()
        {
        
        }
    
    }

}
