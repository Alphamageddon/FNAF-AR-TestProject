using UnityEngine;

namespace Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class QualitySetter : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int targetFrameRate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CameraSceneLookupTable _cameraSceneLookupTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _objectDetectionSetupDone;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Utilities.QualitySetter.QualityLevel _qualityLevel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            var val_12;
            var val_13;
            var val_14;
            float val_15;
            int val_16;
            var val_17;
            int val_18;
            QualityLevel val_2 = (UnityEngine.SystemInfo.systemMemorySize > 2047) ? (1 + 1) : 1;
            this._qualityLevel = val_2;
            if(val_2 == 2)
            {
                goto label_0;
            }
            
            if(val_2 != 1)
            {
                goto label_1;
            }
            
            val_12 = 1;
            val_13 = 0;
            goto label_2;
            label_0:
            val_13 = 2;
            val_12 = 1;
            label_2:
            UnityEngine.QualitySettings.SetQualityLevel(index:  2, applyExpensiveChanges:  true);
            label_1:
            if(UnityEngine.Screen.height >= 2001)
            {
                goto label_3;
            }
            
            val_14 = UnityEngine.Screen.height;
            float val_11 = (float)UnityEngine.Screen.width;
            if(val_14 >= 1501)
            {
                goto label_4;
            }
            
            val_15 = 0.7f;
            goto label_5;
            label_3:
            val_14 = UnityEngine.Screen.width;
            int val_8 = UnityEngine.Screen.height;
            var val_9 = (val_14 < 0) ? (val_14 + 1) : (val_14);
            val_9 = val_9 >> 1;
            val_16 = ((val_8 < 0) ? (val_8 + 1) : (val_8)) >> 1;
            val_17 = 1;
            val_18 = val_9;
            goto label_6;
            label_4:
            val_15 = 0.6f;
            label_5:
            val_11 = val_11 * val_15;
            val_15 = (float)UnityEngine.Screen.height * val_15;
            val_18 = (int)val_11;
            val_16 = (int)val_15;
            val_17 = 1;
            label_6:
            UnityEngine.Screen.SetResolution(width:  val_18, height:  val_16, fullscreen:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(UnityEngine.Application.targetFrameRate != this.targetFrameRate)
            {
                    UnityEngine.Application.targetFrameRate = this.targetFrameRate;
            }
            
            if(this._objectDetectionSetupDone == true)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._cameraSceneLookupTable)) == false)
            {
                    return;
            }
            
            if(this._qualityLevel == 1)
            {
                    DefaultNamespace.ObjectDetectionManager_Config val_3 = this._cameraSceneLookupTable.ObjectDetectionManagerConfig;
                val_3.enableObjDetect = false;
            }
            
            this._objectDetectionSetupDone = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public QualitySetter()
        {
            this.targetFrameRate = 30;
        }
    
    }

}
