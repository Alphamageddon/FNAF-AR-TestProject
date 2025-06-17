using UnityEngine;

namespace SharedTechAssets.Scripts.BoundedPlaneHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BoundedPlane_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private BoundedPlaneManager _manager;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableHPlanes { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool EnableVPlanes { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BoundedPlane_SROptions(BoundedPlaneManager manager)
        {
            this._manager = manager;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableHPlanes()
        {
            if(this._manager != null)
            {
                    return (bool)this._manager.enableH;
            }
            
            return (bool)this._manager.enableH;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EnableHPlanes(bool value)
        {
            this._manager.enableH = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_EnableVPlanes()
        {
            if(this._manager != null)
            {
                    return (bool)this._manager.enableV;
            }
            
            return (bool)this._manager.enableV;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_EnableVPlanes(bool value)
        {
            this._manager.enableV = value;
        }
    
    }

}
