using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectInspectorModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, Mapbox.Examples.FeatureSelectionDetector> _detectors;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.FeatureUiMarker _marker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.FeatureSelectionDetector _tempDetector;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this._detectors == null)
            {
                    this._detectors = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, Mapbox.Examples.FeatureSelectionDetector>();
            }
            
            if(this._marker != 0)
            {
                    return;
            }
            
            System.Type[] val_3 = new System.Type[3];
            val_3[0] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_3[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_3[2] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Canvas val_8 = new UnityEngine.GameObject(name:  "InteractiveSelectionCanvas", components:  val_3).GetComponent<UnityEngine.Canvas>();
            val_8.renderMode = 0;
            UnityEngine.GameObject val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "selector"));
            val_10.transform.SetParent(p:  val_8.transform);
            this._marker = val_10.GetComponent<Mapbox.Examples.FeatureUiMarker>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Examples.FeatureUiMarker val_4;
            Mapbox.Examples.FeatureSelectionDetector val_5;
            if((this._detectors.ContainsKey(key:  ve.GameObject)) == false)
            {
                goto label_3;
            }
            
            val_4 = this._marker;
            val_5 = this._detectors.Item[ve.GameObject];
            if(val_5 != null)
            {
                goto label_9;
            }
            
            goto label_6;
            label_3:
            Mapbox.Examples.FeatureSelectionDetector val_3 = ve.GameObject.AddComponent<Mapbox.Examples.FeatureSelectionDetector>();
            this._tempDetector = val_3;
            this._detectors.Add(key:  ve.GameObject, value:  val_3);
            val_5 = this._tempDetector;
            val_4 = this._marker;
            if(val_5 != null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            this._tempDetector._marker = val_4;
            this._tempDetector._feature = ve;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectInspectorModifier()
        {
        
        }
    
    }

}
