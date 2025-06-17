using UnityEngine;

namespace DevTools.Runtime.CameraView
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EditorSkyboxSetter : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Object.Destroy(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EditorSkyboxSetter()
        {
        
        }
    
    }

}
