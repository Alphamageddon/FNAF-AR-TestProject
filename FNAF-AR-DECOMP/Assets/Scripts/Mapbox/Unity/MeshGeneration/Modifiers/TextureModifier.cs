using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextureModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _textureTop;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useSatelliteTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material[] _topMaterials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _textureSides;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material[] _sideMaterials;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.Material val_10;
            UnityEngine.MeshRenderer val_11;
            val_10 = this;
            val_11 = ve.MeshRenderer;
            if((this._textureSides == false) || (this._sideMaterials.Length == 0))
            {
                goto label_4;
            }
            
            UnityEngine.Material[] val_1 = new UnityEngine.Material[2];
            val_1[0] = this._topMaterials[(long)UnityEngine.Random.Range(min:  0, max:  this._topMaterials.Length)];
            val_1[1] = this._sideMaterials[(long)UnityEngine.Random.Range(min:  0, max:  this._sideMaterials.Length)];
            if(val_11 != null)
            {
                goto label_28;
            }
            
            label_29:
            label_28:
            val_11.materials = val_1;
            goto label_20;
            label_4:
            if(this._textureTop == false)
            {
                goto label_20;
            }
            
            new UnityEngine.Material[1][0] = this._topMaterials[(long)UnityEngine.Random.Range(min:  0, max:  this._topMaterials.Length)];
            if(val_11 != null)
            {
                goto label_28;
            }
            
            goto label_29;
            label_20:
            if(this._useSatelliteTexture == false)
            {
                    return;
            }
            
            val_10 = val_11.materials[0];
            val_10.mainTexture = tile.GetRasterData();
            val_11 = val_11.materials[0];
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_11.mainTextureScale = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextureModifier()
        {
            mem[1152921519697694424] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
