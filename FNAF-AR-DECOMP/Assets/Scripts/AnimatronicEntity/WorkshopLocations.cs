using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopLocations
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Utils.Vector2d> _workshopGeoPositions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<Mapbox.Utils.Vector2d> WorkshopGeoPositions { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<Mapbox.Utils.Vector2d> get_WorkshopGeoPositions()
        {
            return (System.Collections.Generic.IEnumerable<Mapbox.Utils.Vector2d>)this._workshopGeoPositions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopLocations(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._workshopGeoPositions = new System.Collections.Generic.List<Mapbox.Utils.Vector2d>();
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddWorkshopLocation(Mapbox.Utils.Vector2d workshopLocation)
        {
            this._workshopGeoPositions.Add(item:  new Mapbox.Utils.Vector2d() {x = workshopLocation.x, y = workshopLocation.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearWorkshopLocations()
        {
            this._workshopGeoPositions.Clear();
        }
    
    }

}
