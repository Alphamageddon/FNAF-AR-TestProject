using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxObjDetectAdapter : IObjDetectAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxObjectDetectionAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxObjectDetectionAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDetectionUpdateEvent(string[] objects, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confidences)
        {
            var val_5;
            var val_6;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] val_2 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[0];
            if(objects.Length >= 1)
            {
                    System.String[] val_3 = objects[32];
                System.Single[] val_4 = minX[32];
                System.Single[] val_5 = minY[32];
                System.Single[] val_6 = maxX[32];
                var val_9 = 0;
                System.Single[] val_7 = maxY[32];
                System.Single[] val_8 = confidences[32];
                do
            {
                val_5 = 0;
                if(val_9 >= val_2.Length)
            {
                    val_5 = 0;
            }
            
                val_9 = val_9 + 1;
                mem2[0] = 0;
                val_2[32] = 0;
            }
            while((objects.Length & 4294967295) != val_9);
            
            }
            
            var val_12 = mem[1152921523182843296];
            if((mem[1152921523182843296] + 286) == 0)
            {
                goto label_18;
            }
            
            var val_10 = mem[1152921523182843296] + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_20:
            if(((mem[1152921523182843296] + 176 + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (mem[1152921523182843296] + 286))
            {
                goto label_20;
            }
            
            label_18:
            val_5 = 0;
            goto label_21;
            label_19:
            val_12 = val_12 + (((mem[1152921523182843296] + 176 + 8)) << 4);
            val_6 = val_12 + 296;
            label_21:
            mem[1152921523182843296].OnObjectDetectionUpdate(detections:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDetectionBeganEvent()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.OnObjectDetectionBegin();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxObjDetectAdapter()
        {
        
        }
    
    }

}
