using UnityEngine;

namespace DevTools.Runtime.Animatronics.ModelViewer
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicModelViewer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static DevTools.Runtime.Animatronics.ModelViewer.ModelViewerConfig _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool <IsRunning>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DevTools.Runtime.Animatronics.ModelViewer.UIView _uiView;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsRunning { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsRunning()
        {
            null = null;
            return (bool)DevTools.Runtime.Animatronics.ModelViewer.AnimatronicModelViewer.<IsRunning>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void set_IsRunning(bool value)
        {
            null = null;
            DevTools.Runtime.Animatronics.ModelViewer.AnimatronicModelViewer.<IsRunning>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicModelViewer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimatronicModelViewer()
        {
            DevTools.Runtime.Animatronics.ModelViewer.AnimatronicModelViewer.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
