using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureBehaviourModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.GameObject, Mapbox.Unity.MeshGeneration.Components.FeatureBehaviour> _features;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Components.FeatureBehaviour _tempFeature;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this._features != null)
            {
                    return;
            }
            
            this._features = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, Mapbox.Unity.MeshGeneration.Components.FeatureBehaviour>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.GameObject val_4;
            Mapbox.Unity.MeshGeneration.Components.FeatureBehaviour val_5;
            if((this._features.ContainsKey(key:  ve.GameObject)) == false)
            {
                goto label_3;
            }
            
            val_4 = ve.GameObject;
            val_5 = this._features.Item[val_4];
            if(val_5 != null)
            {
                goto label_9;
            }
            
            goto label_6;
            label_3:
            val_4 = ve.GameObject.AddComponent<Mapbox.Unity.MeshGeneration.Components.FeatureBehaviour>();
            this._tempFeature = val_4;
            this._features.Add(key:  ve.GameObject, value:  val_4);
            val_5 = this._tempFeature;
            if(val_5 != null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_5.Initialize(ve:  ve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureBehaviourModifier()
        {
            mem[1152921519692055160] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
