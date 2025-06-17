using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Components
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextureSelector : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useSatelliteRoof;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _textureTop;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _textureSides;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.MeshGeneration.Data.UnityTile _tile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshRenderer _meshRenderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material[] _topTextures;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material[] _sideTextures;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, bool doTextureTop, bool useSatelliteRoof, UnityEngine.Material[] topTextures, bool doTextureSides, UnityEngine.Material[] sideTextures)
        {
            UnityEngine.Material[] val_20;
            UnityEngine.Material val_21;
            Mapbox.Unity.MeshGeneration.Data.UnityTile val_22;
            val_20 = topTextures;
            val_21 = this;
            this._useSatelliteRoof = useSatelliteRoof;
            this._textureTop = doTextureTop;
            this._textureSides = doTextureSides;
            this._tile = this.GetComponent<Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            UnityEngine.Transform val_5 = this.transform;
            val_22 = this._tile;
            goto label_1;
            label_10:
            val_22 = val_5.parent;
            if(val_22 == 0)
            {
                goto label_5;
            }
            
            val_22 = val_5.parent.GetComponent<Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            this._tile = val_22;
            label_1:
            if(val_22 == 0)
            {
                goto label_10;
            }
            
            label_5:
            this._topTextures = val_20;
            this._sideTextures = sideTextures;
            this._meshRenderer = this.GetComponent<UnityEngine.MeshRenderer>();
            if((this._textureSides == false) || (this._sideTextures.Length == 0))
            {
                goto label_13;
            }
            
            UnityEngine.Material[] val_12 = new UnityEngine.Material[2];
            val_20 = val_12;
            val_20[0] = this._topTextures[(long)UnityEngine.Random.Range(min:  0, max:  this._topTextures.Length)];
            val_22 = this._sideTextures;
            val_20[1] = val_22[(long)UnityEngine.Random.Range(min:  0, max:  this._sideTextures.Length)];
            if(this._meshRenderer != null)
            {
                goto label_37;
            }
            
            label_38:
            label_37:
            this._meshRenderer.materials = val_12;
            goto label_29;
            label_13:
            if(this._textureTop == false)
            {
                goto label_29;
            }
            
            new UnityEngine.Material[1][0] = this._topTextures[(long)UnityEngine.Random.Range(min:  0, max:  this._topTextures.Length)];
            if(this._meshRenderer != null)
            {
                goto label_37;
            }
            
            goto label_38;
            label_29:
            if(this._useSatelliteRoof == false)
            {
                    return;
            }
            
            val_20 = this._tile._rasterData;
            this._meshRenderer.materials[0].mainTexture = val_20;
            val_21 = this._meshRenderer.materials[0];
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_21.mainTextureScale = new UnityEngine.Vector2() {x = val_19.x, y = val_19.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextureSelector()
        {
        
        }
    
    }

}
