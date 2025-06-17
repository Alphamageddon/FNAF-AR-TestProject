using UnityEngine;

namespace SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Boundary;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SupportedPlane(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            val_1 = new System.Object();
            this.Id = id;
            this.Boundary = val_1;
        }
    
    }

}
