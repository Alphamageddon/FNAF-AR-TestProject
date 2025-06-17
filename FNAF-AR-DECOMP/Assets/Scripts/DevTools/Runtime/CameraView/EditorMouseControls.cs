using UnityEngine;

namespace DevTools.Runtime.CameraView
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EditorMouseControls : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _camera;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Object.Destroy(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EditorMouseControls()
        {
        
        }
    
    }

}
