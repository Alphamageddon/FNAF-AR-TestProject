using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AddMonoBehavioursModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Modifiers.AddMonoBehavioursModifierType[] _types;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<string> _scripts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _tempId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this._scripts != null)
            {
                    return;
            }
            
            this._scripts = new System.Collections.Generic.HashSet<System.String>();
            this._tempId = System.String.alignConst;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.AddMonoBehavioursModifierType val_8;
            goto label_1;
            label_13:
            val_8 = this._types[0];
            string val_3 = ve.GameObject.GetInstanceID() + val_8.Type;
            this._tempId = val_3;
            if((this._scripts.Contains(item:  val_3)) != true)
            {
                    UnityEngine.Component val_6 = ve.GameObject.AddComponent(componentType:  val_8.Type);
                val_8 = this._scripts;
                bool val_7 = val_8.Add(item:  this._tempId);
            }
            
            0 = 1;
            label_1:
            if(0 < this._types.Length)
            {
                goto label_13;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddMonoBehavioursModifier()
        {
            mem[1152921519689155896] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
