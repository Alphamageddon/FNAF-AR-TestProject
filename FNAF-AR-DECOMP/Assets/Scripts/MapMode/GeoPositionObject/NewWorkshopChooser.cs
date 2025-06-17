using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NewWorkshopChooser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectDomain _geoPositionObjectDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int nextWorkshopToChoose;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected NewWorkshopChooser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NewWorkshopChooser(MapMode.GeoPositionObject.GeoPositionObjectDomain geoPositionObjectDomain)
        {
            this._geoPositionObjectDomain = geoPositionObjectDomain;
        }
    
    }

}
