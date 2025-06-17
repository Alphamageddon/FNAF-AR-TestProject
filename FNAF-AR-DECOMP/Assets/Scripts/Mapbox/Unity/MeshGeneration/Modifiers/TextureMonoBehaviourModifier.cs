using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextureMonoBehaviourModifier : GameObjectModifier
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
            ve.GameObject.AddComponent<Mapbox.Unity.MeshGeneration.Components.TextureSelector>().Initialize(ve:  ve, doTextureTop:  (this._textureTop == true) ? 1 : 0, useSatelliteRoof:  (this._useSatelliteTexture == true) ? 1 : 0, topTextures:  this._topMaterials, doTextureSides:  (this._textureSides == true) ? 1 : 0, sideTextures:  this._sideMaterials);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextureMonoBehaviourModifier()
        {
            mem[1152921519698099672] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
