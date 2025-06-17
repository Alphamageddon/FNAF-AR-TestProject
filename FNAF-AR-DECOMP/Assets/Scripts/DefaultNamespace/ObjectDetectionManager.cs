using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectDetectionManager : ITimeUpdateAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultNamespace.ObjectDetectionManager_Config Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetection_SROptions _srOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IModelDownloadStatus _modelDownloadStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<string> LABELS_TO_IGNORE;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isModelDownloaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Matrix4x4 _lastCameraWorldTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Matrix4x4 _lastCameraProjectionMatrix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _lastDepthFire;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _pendingResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initModel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(DefaultNamespace.ObjectDetectionManager_Config config, SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjDetectDispenser dispenser, SharedTechAssets.Scripts.IModelDownloadStatus modelDownloadStatus)
        {
            this.Config = config;
            this._dispenser = dispenser;
            this._isModelDownloaded = true;
            ._odm = this;
            this._srOptions = new DefaultNamespace.ObjectDetection_SROptions();
            this._modelDownloadStatus = modelDownloadStatus;
            SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
            if(val_2 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.AddOptionContainer(container:  this._srOptions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(val_1 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.RemoveOptionContainer(container:  this._srOptions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CoreMLFrameUpdated(int index, string[] strings, float[] floats, int floatsW, int floatsH, double[] depth, int w, int h)
        {
            var val_20;
            var val_21;
            var val_22;
            System.Single[] val_23;
            System.Single[] val_24;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(strings.Length >= 1)
            {
                    var val_21 = 0;
                val_20 = strings + 32;
                do
            {
                val_21 = public System.Boolean System.Collections.Generic.HashSet<System.String>::Contains(System.String item);
                if((this.LABELS_TO_IGNORE.Contains(item:  (strings + 32) + 0)) != true)
            {
                    val_21 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
                val_1.Add(item:  0);
            }
            
                val_21 = val_21 + 1;
            }
            while((strings.Length & 4294967295) != val_21);
            
            }
            
            int val_4 = val_1.Count;
            string[] val_5 = new string[0];
            float[] val_6 = new float[0];
            float[] val_7 = new float[0];
            float[] val_8 = new float[0];
            float[] val_9 = new float[0];
            float[] val_10 = new float[0];
            val_22 = 0;
            goto label_9;
            label_35:
            val_21 = public System.Int32 System.Collections.Generic.List<System.Int32>::get_Item(int index);
            int val_11 = val_1.Item[0];
            if(val_11 >= null)
            {
                    val_21 = 0;
            }
            
            var val_12 = 1152921505924375376 + (((long)(int)(val_11)) << 3);
            if(val_5 == null)
            {
                goto label_12;
            }
            
            if(((1152921505924375376 + ((long)(int)(val_11)) << 3) + 32) != 0)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            if(((1152921505924375376 + ((long)(int)(val_11)) << 3) + 32) == 0)
            {
                goto label_16;
            }
            
            label_13:
            if(((1152921505924375376 + ((long)(int)(val_11)) << 3) + 32) == 0)
            {
                    val_21 = 0;
            }
            
            label_16:
            if(val_22 >= val_5.Length)
            {
                    val_21 = 0;
            }
            
            val_5[0] = (1152921505924375376 + ((long)(int)(val_11)) << 3) + 32;
            var val_13 = (long)val_11 + ((long)val_11 << 2);
            if(val_13 >= floats.Length)
            {
                    val_21 = 0;
            }
            
            val_23 = val_6;
            if(val_23 == 0)
            {
                    val_23 = val_6;
            }
            
            if(val_22 >= mem[1152921524698819160])
            {
                    val_21 = 0;
                val_23 = val_6;
            }
            
            System.Single[] val_14 = val_23 + 0;
            mem2[0] = floats[(long)val_13];
            var val_15 = (long)val_13 + 3;
            if(val_15 >= floats.Length)
            {
                    val_21 = 0;
            }
            
            float val_23 = floats[(long)val_15];
            val_24 = val_7;
            if(val_24 == 0)
            {
                    val_24 = val_7;
            }
            
            val_23 = 1f - val_23;
            if(val_22 >= mem[1152921524698823256])
            {
                    val_21 = 0;
                val_24 = val_7;
            }
            
            System.Single[] val_16 = val_24 + 0;
            mem2[0] = val_23;
            var val_17 = (long)val_13 + 2;
            if(val_17 >= floats.Length)
            {
                    val_21 = 0;
            }
            
            if(val_22 >= val_8.Length)
            {
                    val_21 = 0;
            }
            
            val_8[0] = floats[(long)val_17];
            var val_18 = (long)val_13 + 1;
            val_20 = (long)val_18;
            if(val_18 >= floats.Length)
            {
                    val_21 = 0;
            }
            
            float val_25 = floats[val_20];
            val_25 = 1f - val_25;
            if(val_22 >= val_9.Length)
            {
                    val_21 = 0;
            }
            
            val_9[0] = val_25;
            var val_19 = (long)val_13 + 4;
            if(val_19 >= floats.Length)
            {
                    val_21 = 0;
            }
            
            if(val_22 >= val_10.Length)
            {
                    val_21 = 0;
            }
            
            val_22 = 1;
            val_10[0] = floats[(long)val_19];
            label_9:
            if(val_22 < val_1.Count)
            {
                goto label_35;
            }
            
            mem[1152921524698664280].SendDetectionUpdateEvent(objects:  val_5, minX:  val_6, minY:  val_7, maxX:  val_8, maxY:  val_9, confidences:  val_10);
            mem[1152921524698664456] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ObjDetectUpdated(string[] labels, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confs)
        {
            goto label_0;
            label_8:
            float val_2 = minY[0];
            mem2[0] = 1f - maxY[0];
            val_2 = 1f - val_2;
            0 = 1;
            mem2[0] = val_2;
            label_0:
            if(0 < labels.Length)
            {
                goto label_8;
            }
            
            this._dispenser.SendDetectionUpdateEvent(objects:  labels, minX:  minX, minY:  minY, maxX:  maxX, maxY:  maxY, confidences:  confs);
            this._pendingResponse = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TimeUpdateEvent()
        {
            if(this._isModelDownloaded != true)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                bool val_2 = this._modelDownloadStatus.HasBeenDownloaded();
                this._isModelDownloaded = val_2;
                if(val_2 == false)
            {
                    return;
            }
            
            }
            
            bool val_12 = this._pendingResponse;
            val_12 = val_12 + 3;
            var val_13 = ~val_12;
            val_13 = val_13 & 3;
            if(val_13 != 0)
            {
                    return;
            }
            
            System.DateTime val_4 = System.DateTime.UtcNow;
            long val_5 = val_4.dateData.Ticks;
            if(this.Config.enableObjDetect == false)
            {
                    return;
            }
            
            if((1844674407370955 - this._lastDepthFire) <= this.Config.updateFrequency)
            {
                    return;
            }
            
            this._pendingResponse = true;
            this._lastDepthFire = 1844674407370955;
            this._dispenser.SendBeginDetectionEvent();
            UnityCVManager_Android.Instance.SetupObjDetectCallback(callback:  new UnityCVManager_Android.ObjDetectUpdate(object:  this, method:  System.Void DefaultNamespace.ObjectDetectionManager::ObjDetectUpdated(string[] labels, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confs)));
            UnityCVManager_Android.Instance.AttemptObjDetectUpdate(useCPU:  (this.Config.useCPUOnly == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectDetectionManager()
        {
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(val_1 != null)
            {
                    val_1.Add(item:  "bed");
            }
            else
            {
                    val_1.Add(item:  "bed");
            }
            
            val_1.Add(item:  "toilet");
            if(val_1 != null)
            {
                    val_1.Add(item:  "skateboard");
            }
            else
            {
                    val_1.Add(item:  "skateboard");
            }
            
            val_1.Add(item:  "boat");
            if(val_1 != null)
            {
                    val_1.Add(item:  "bench");
            }
            else
            {
                    val_1.Add(item:  "bench");
            }
            
            val_1.Add(item:  "bear");
            if(val_1 != null)
            {
                    val_1.Add(item:  "sheep");
            }
            else
            {
                    val_1.Add(item:  "sheep");
            }
            
            val_1.Add(item:  "giraffe");
            if(val_1 != null)
            {
                    val_1.Add(item:  "zebra");
            }
            else
            {
                    val_1.Add(item:  "zebra");
            }
            
            val_1.Add(item:  "elephant");
            if(val_1 != null)
            {
                    val_1.Add(item:  "cow");
            }
            else
            {
                    val_1.Add(item:  "cow");
            }
            
            val_1.Add(item:  "aeroplane");
            this.LABELS_TO_IGNORE = new System.Collections.Generic.HashSet<System.String>(collection:  val_1);
            this._initModel = true;
        }
    
    }

}
