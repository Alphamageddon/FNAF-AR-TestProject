using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DragableDirectionWaypoint : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform MoveTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 screenPoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 offset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Plane _yPlane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this._yPlane = 0;
            mem[1152921519848980748] = 0;
            mem[1152921519848980756] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMouseDrag()
        {
            float val_4;
            UnityEngine.Transform val_6;
            float val_7;
            val_6 = this;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_7 = val_2.x;
            UnityEngine.Ray val_3 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_7, y = val_2.y, z = val_2.z});
            if((this._yPlane & 1) == 0)
            {
                    return;
            }
            
            val_6 = this.MoveTarget;
            val_7 = 0f;
            val_6.position = new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_2.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DragableDirectionWaypoint()
        {
        
        }
    
    }

}
