using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.GeometryHandler
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeometryToDataHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler> _objToAccepter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<UnityEngine.GameObject> _hitObjects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeometryToDataHandler()
        {
            this._objToAccepter = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler>();
            this._hitObjects = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddGO(UnityEngine.GameObject go, SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler accepter)
        {
            this._objToAccepter.set_Item(key:  go, value:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveGO(UnityEngine.GameObject go)
        {
            bool val_1 = this._objToAccepter.Remove(key:  go);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Redirect(System.Collections.Generic.List<UnityEngine.GameObject> goList, System.Collections.Generic.List<UnityEngine.RaycastHit> hits, string label, float confidence, int labelId)
        {
            var val_5;
            var val_6;
            var val_7;
            goto label_1;
            label_17:
            UnityEngine.GameObject val_1 = goList.Item[0];
            if((this._hitObjects.Contains(item:  val_1)) != true)
            {
                    bool val_3 = this._hitObjects.Add(item:  val_1);
                UnityEngine.RaycastHit val_4 = hits.Item[0];
                if((this._objToAccepter.ContainsKey(key:  val_1)) != false)
            {
                    SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler val_9 = this._objToAccepter.Item[val_1];
                if((SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.SemanticGeometryFilter.IsPinFiltered(handlerName:  val_9.name, label:  label)) != true)
            {
                    SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler val_11 = this._objToAccepter.Item[val_1];
                val_5 = val_7;
                val_6 = val_6;
                val_7 = val_7;
            }
            
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < goList.Count)
            {
                goto label_17;
            }
            
            this._hitObjects.Clear();
        }
    
    }

}
