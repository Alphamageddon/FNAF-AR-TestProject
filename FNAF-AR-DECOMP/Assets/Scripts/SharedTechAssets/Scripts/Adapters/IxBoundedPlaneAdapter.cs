using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxBoundedPlaneAdapter : IBoundedPlaneAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxBoundedPlaneAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxBoundedPlaneAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
        {
            int val_3;
            IllumixHorizontalBoundedPlane val_1 = null;
            val_3 = id;
            val_1 = new IllumixHorizontalBoundedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, updateKey:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            this._accepter.OnHorizontalBoundedPlaneAddEvent(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 0;
            this._accepter.GetHorizontalBoundedPlane(key:  id).UpdatePlane(boundary:  boundary, weightedHeight:  height);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 1;
            this._accepter.OnHorizontalBoundedPlaneUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnHorizontalBoundedPlaneRemove(int id)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.OnHorizontalBoundedPlaneRemoveEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            int val_3;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane val_1 = null;
            val_3 = id;
            val_1 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane(boundary:  boundary, initialCenter:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, updateKey:  val_3);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 3;
            this._accepter.OnVerticalBoundedPlaneAddEvent(plane:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane val_2 = this._accepter.GetVerticalBoundedPlane(key:  id);
            if(val_2 != null)
            {
                    val_4 = 0;
                val_2.UpdatePlane(boundary:  boundary);
            }
            else
            {
                    val_4 = 0;
                0.UpdatePlane(boundary:  boundary);
            }
            
            val_2.UpdateNormal(normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 4;
            this._accepter.OnVerticalBoundedPlaneUpdateEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnVerticalBoundedPlaneRemove(int id)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.OnVerticalBoundedPlaneRemoveEvent(key:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxBoundedPlaneAdapter()
        {
        
        }
    
    }

}
