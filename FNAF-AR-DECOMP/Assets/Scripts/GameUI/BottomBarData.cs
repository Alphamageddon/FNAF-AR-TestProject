using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BottomBarData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject bottomBarParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject bottomBarCloseParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<HighlightToggle> bottomBarButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject cameraButtonPulse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Image cameraImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite cameraImageAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite cameraImageMain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float cameraAlertToggleTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BottomBarData()
        {
        
        }
    
    }

}
