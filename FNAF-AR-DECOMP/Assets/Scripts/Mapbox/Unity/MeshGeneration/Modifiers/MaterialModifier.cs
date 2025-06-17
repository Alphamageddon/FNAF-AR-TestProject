using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MaterialModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.GeometryMaterialOptions _options;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void SetProperties(Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties properties)
        {
            Mapbox.Unity.MeshGeneration.Modifiers.ModifierProperties val_3 = properties;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this._options = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_9 = tile;
            if(this._options.materials == null)
            {
                goto label_2;
            }
            
            label_52:
            int val_3 = System.Math.Min(val1:  this._options.materials.Length, val2:  ve.MeshFilter.mesh.subMeshCount);
            UnityEngine.Material[] val_4 = new UnityEngine.Material[0];
            if(this._options.style != 6)
            {
                goto label_9;
            }
            
            if(val_3 < 1)
            {
                goto label_10;
            }
            
            var val_12 = 0;
            label_28:
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_9 = this._options.materials[val_12];
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_10 = this._options.materials[val_12];
            UnityEngine.Material val_11 = this._options.materials[0x0][0].Materials[(long)UnityEngine.Random.Range(min:  0, max:  this._options.materials[0x0][0].Materials.Length)];
            if(val_4 == null)
            {
                goto label_22;
            }
            
            if(val_11 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_11 == null)
            {
                goto label_26;
            }
            
            label_23:
            label_26:
            mem2[0] = val_11;
            val_12 = val_12 + 1;
            if(val_3 != val_12)
            {
                goto label_28;
            }
            
            goto label_53;
            label_9:
            if(val_3 < 1)
            {
                goto label_30;
            }
            
            var val_15 = 0;
            label_48:
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_13 = this._options.materials[val_15];
            Mapbox.Unity.MeshGeneration.Modifiers.MaterialList val_14 = this._options.materials[val_15];
            val_9 = this._options.materials[0x0][0].Materials[(long)UnityEngine.Random.Range(min:  0, max:  this._options.materials[0x0][0].Materials.Length)];
            if(val_4 == null)
            {
                goto label_42;
            }
            
            if(val_9 != null)
            {
                goto label_43;
            }
            
            goto label_46;
            label_42:
            if(val_9 == null)
            {
                goto label_46;
            }
            
            label_43:
            label_46:
            mem2[0] = val_9;
            val_15 = val_15 + 1;
            if(val_3 != val_15)
            {
                goto label_48;
            }
            
            label_30:
            label_60:
            ve.MeshRenderer.materials = val_4;
            return;
            label_2:
            if(ve != null)
            {
                goto label_52;
            }
            
            goto label_52;
            label_10:
            label_53:
            val_4[0].mainTexture = val_9.GetRasterData();
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_4[0].mainTextureScale = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            if(ve != null)
            {
                goto label_60;
            }
            
            goto label_60;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MaterialModifier()
        {
            mem[1152921519694292248] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
