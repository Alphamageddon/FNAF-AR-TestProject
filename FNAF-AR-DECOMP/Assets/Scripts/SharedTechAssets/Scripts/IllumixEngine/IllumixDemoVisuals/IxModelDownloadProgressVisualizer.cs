using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxModelDownloadProgressVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject textObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int order;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> labelToOrder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, string> orderToLabel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> labelToProgress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, float> labelToModelSize;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.text = this.textObject.GetComponent<UnityEngine.UI.Text>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.add_UpdatedEvent(value:  new IxModelDownloadProgressDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxModelDownloadProgressVisualizer::IxModelDownloadProgressDelivererOnUpdatedEvent(string label, int bytesWritten, int totalBytesToWrite)));
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.add_CompletedEvent(value:  new IxModelDownloadProgressDeliverer.Complete(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxModelDownloadProgressVisualizer::IxModelDownloadProgressDelivererOnCompletedEvent(string label, bool didFail)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.add_UpdatedEvent(value:  new IxModelDownloadProgressDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxModelDownloadProgressVisualizer::IxModelDownloadProgressDelivererOnUpdatedEvent(string label, int bytesWritten, int totalBytesToWrite)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxModelDownloadProgressDelivererOnUpdatedEvent(string label, int bytesWritten, int totalBytesToWrite)
        {
            UnityEngine.UI.Text val_8;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_9;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_10;
            int val_11;
            string val_12;
            val_8 = this;
            val_9 = this.labelToOrder;
            if((val_9.ContainsKey(key:  label)) != false)
            {
                    val_10 = this.labelToProgress;
            }
            else
            {
                    this.labelToOrder.set_Item(key:  label, value:  this.order);
                this.orderToLabel.set_Item(key:  this.order, value:  label);
                val_10 = val_8;
                int val_8 = this.order;
                val_8 = val_8 + 1;
                this.order = val_8;
                this.labelToProgress.set_Item(key:  label, value:  0);
                val_9 = this.labelToModelSize;
                double val_9 = 1000000;
                val_9 = (double)totalBytesToWrite / val_9;
                val_9.set_Item(key:  label, value:  (float)val_9);
            }
            
            float val_10 = 100f;
            val_10 = (float)bytesWritten * val_10;
            val_10 = val_10 / (float)totalBytesToWrite;
            val_11 = (int)val_10;
            if(null.Item[label] == val_11)
            {
                    return;
            }
            
            null.set_Item(key:  label, value:  val_11);
            val_12 = "";
            if(this.order >= 1)
            {
                    do
            {
                string val_3 = this.orderToLabel.Item[0];
                int val_4 = null.Item[val_3];
                val_9 = val_4;
                val_11 = 0 + 1;
                val_12 = val_12 + System.String.Format(format:  "Model: {0} Percent Complete: {1:0} Size: {2:0.0}MB\n", arg0:  val_3, arg1:  val_4, arg2:  this.labelToModelSize.Item[val_3])(System.String.Format(format:  "Model: {0} Percent Complete: {1:0} Size: {2:0.0}MB\n", arg0:  val_3, arg1:  val_4, arg2:  this.labelToModelSize.Item[val_3]));
            }
            while(val_11 < this.order);
            
            }
            
            val_8 = this.text;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxModelDownloadProgressDelivererOnCompletedEvent(string label, bool didFail)
        {
            string val_1;
            string val_2;
            string val_3;
            if(didFail != false)
            {
                    val_1 = "IxDownloadProgViz";
                val_2 = "Complete";
                val_3 = "Loading failed!";
            }
            else
            {
                    val_1 = "IxDownloadProgViz";
                val_2 = "Complete";
                val_3 = "Loading complete!";
            }
            
            ConsoleLogger.LogError(className:  val_1, functionName:  val_2, logString:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxModelDownloadProgressVisualizer()
        {
            this.labelToOrder = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.orderToLabel = new System.Collections.Generic.Dictionary<System.Int32, System.String>();
            this.labelToProgress = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this.labelToModelSize = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        }
    
    }

}
