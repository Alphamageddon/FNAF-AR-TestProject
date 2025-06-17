using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SemanticHorizontalPlaneDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticHorizontalPlaneAccepter> _accepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticHorizontalPlaneAccepter accepter)
        {
            this._accepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticHorizontalPlaneAccepter> accepters)
        {
            this._accepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LabelTile(int id, UnityEngine.Vector2 key, string label, int label_id, float confidence)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].OnLabelTile(id:  id, key:  new UnityEngine.Vector2() {x = key.x, y = key.y}, label:  label, predId:  label_id, confidence:  confidence);
            0 = 1;
            label_1:
            if(0 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SemanticHorizontalPlaneDispenser()
        {
            this._accepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ISemanticHorizontalPlaneAccepter>();
        }
    
    }

}
