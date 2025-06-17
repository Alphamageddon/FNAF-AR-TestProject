using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjDetectDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> objDetectAccepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter accepter)
        {
            this.objDetectAccepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter> accepters)
        {
            this.objDetectAccepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendDetectionUpdateEvent(string[] objects, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confidences)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.objDetectAccepters.Item[0].OnDetectionUpdateEvent(objects:  objects, minX:  minX, minY:  minY, maxX:  maxX, maxY:  maxY, confidences:  confidences);
            0 = 1;
            label_1:
            if(0 < this.objDetectAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendBeginDetectionEvent()
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.objDetectAccepters.Item[0].OnDetectionBeganEvent();
            0 = 1;
            label_1:
            if(0 < this.objDetectAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjDetectDispenser()
        {
            this.objDetectAccepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjDetectAccepter>();
        }
    
    }

}
