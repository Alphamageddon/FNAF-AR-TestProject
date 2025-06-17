using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopFinder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.GeoPositionObject.GeoPositionObjectDomain _geoPositionObjectDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected WorkshopFinder()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopFinder(MapMode.GeoPositionObject.GeoPositionObjectDomain geoPositionObjectDomain)
        {
            this._geoPositionObjectDomain = geoPositionObjectDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool DoesWorkshopExist()
        {
            return UnityEngine.Object.op_Inequality(x:  this._geoPositionObjectDomain.<container>k__BackingField.FindFirstOfType(entityType:  0), y:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
        
        }
    
    }

}
