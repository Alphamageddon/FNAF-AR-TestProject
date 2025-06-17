using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SetLayerFromSettings : SRMonoBehaviour
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            SRF.SRFGameObjectExtensions.SetLayerRecursive(o:  this.gameObject, layer:  val_2._debugLayer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SetLayerFromSettings()
        {
        
        }
    
    }

}
