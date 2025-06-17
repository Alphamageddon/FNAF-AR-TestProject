using UnityEngine;

namespace VLB_Samples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraToggleBeamVisibility : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.KeyCode m_KeyCode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_13;
            int val_14;
            if((UnityEngine.Input.GetKeyDown(key:  this.m_KeyCode)) == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_2 = this.GetComponent<UnityEngine.Camera>();
            VLB.Config val_3 = VLB.Config.Instance;
            int val_11 = val_3.geometryLayerID;
            val_11 = val_11 & 31;
            int val_4 = 1 << val_11;
            if(val_2 == null)
            {
                goto label_5;
            }
            
            val_13 = val_2.cullingMask;
            if((val_4 & (~val_2.cullingMask)) != 0)
            {
                goto label_6;
            }
            
            label_8:
            val_14 = val_13 & (~val_4);
            goto label_7;
            label_5:
            val_13 = val_2.cullingMask;
            if((val_4 & (~val_2.cullingMask)) == 0)
            {
                goto label_8;
            }
            
            label_6:
            val_14 = val_13 | val_4;
            label_7:
            val_2.cullingMask = val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraToggleBeamVisibility()
        {
            this.m_KeyCode = 32;
        }
    
    }

}
