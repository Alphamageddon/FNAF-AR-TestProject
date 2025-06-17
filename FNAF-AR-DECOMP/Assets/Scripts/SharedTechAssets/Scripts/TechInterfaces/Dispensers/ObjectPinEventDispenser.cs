using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectPinEventDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter> objectPinEventAccepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter accepter)
        {
            this.objectPinEventAccepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter> accepters)
        {
            this.objectPinEventAccepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendBeginEvent(int id, string label, float confidence)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.objectPinEventAccepters.Item[0].OnBeginEvent(predId:  id, label:  label, confidence:  confidence);
            0 = 1;
            label_1:
            if(0 < this.objectPinEventAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendEndEvent()
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.objectPinEventAccepters.Item[0].OnEndEvent();
            0 = 1;
            label_1:
            if(0 < this.objectPinEventAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectPinEventDispenser()
        {
            this.objectPinEventAccepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IObjectPinEventAccepter>();
        }
    
    }

}
