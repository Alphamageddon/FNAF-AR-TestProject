using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Modifiers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxStylesColorModifier : GameObjectModifier
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScriptablePalette m_scriptablePalette;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string _BASE_COLOR_NAME = "_BaseColor";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string _DETAIL_ONE_COLOR_NAME = "_DetailColor1";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string _DETAIL_TWO_COLOR_NAME = "_DetailColor2";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _baseColorId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _detailOneColorId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _detailTWoColorId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Initialize()
        {
            if(this.m_scriptablePalette == 0)
            {
                    return;
            }
            
            this._baseColorId = UnityEngine.Shader.PropertyToID(name:  "_BaseColor");
            this._detailOneColorId = UnityEngine.Shader.PropertyToID(name:  "_DetailColor1");
            this._detailTWoColorId = UnityEngine.Shader.PropertyToID(name:  "_DetailColor2");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color GetRandomColorFromPalette()
        {
            var val_3;
            UnityEngine.Color val_4;
            UnityEngine.Color val_5;
            UnityEngine.Color val_6;
            UnityEngine.Color val_7;
            ScriptablePalette val_8;
            val_3 = this;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            val_4 = val_1.r;
            val_5 = val_1.g;
            val_6 = val_1.b;
            val_7 = val_1.a;
            if(this.m_scriptablePalette.m_colors.Length == 0)
            {
                    return new UnityEngine.Color() {r = val_4, g = val_5, b = val_6, a = val_7};
            }
            
            val_8 = this.m_scriptablePalette;
            if(this.m_scriptablePalette != null)
            {
                goto label_3;
            }
            
            val_8 = this.m_scriptablePalette;
            if(val_8 == null)
            {
                goto label_4;
            }
            
            label_3:
            val_3 = (long)UnityEngine.Random.Range(min:  0, max:  this.m_scriptablePalette.m_colors.Length);
            val_4 = this.m_scriptablePalette.m_colors[val_3];
            val_5 = this.m_scriptablePalette.m_colors[val_3];
            val_6 = this.m_scriptablePalette.m_colors[val_3];
            val_7 = this.m_scriptablePalette.m_colors[val_3];
            return new UnityEngine.Color() {r = val_4, g = val_5, b = val_6, a = val_7};
            label_4:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void Run(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve, Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            UnityEngine.Color val_10;
            float val_11;
            float val_12;
            float val_13;
            UnityEngine.Color val_14;
            float val_15;
            float val_16;
            float val_17;
            if(this.m_scriptablePalette == 0)
            {
                    return;
            }
            
            UnityEngine.MaterialPropertyBlock val_2 = new UnityEngine.MaterialPropertyBlock();
            ve.MeshRenderer.GetPropertyBlock(properties:  val_2);
            if(this.m_scriptablePalette.m_setBaseColor_Override != false)
            {
                    if(this.m_scriptablePalette != null)
            {
                goto label_9;
            }
            
            }
            else
            {
                    UnityEngine.Color val_3 = this.GetRandomColorFromPalette();
            }
            
            label_9:
            if(this.m_scriptablePalette.m_setDetailColor1_Override != false)
            {
                    val_10 = this.m_scriptablePalette.m_detailColor1_Override;
            }
            else
            {
                    UnityEngine.Color val_4 = this.GetRandomColorFromPalette();
                val_10 = val_4.r;
                val_11 = val_4.g;
                val_12 = val_4.b;
                val_13 = val_4.a;
            }
            
            if(this.m_scriptablePalette.m_setDetailColor2_Override != false)
            {
                    val_14 = this.m_scriptablePalette.m_detailColor2_Override;
            }
            else
            {
                    UnityEngine.Color val_5 = this.GetRandomColorFromPalette();
                val_14 = val_5.r;
                val_15 = val_5.g;
                val_16 = val_5.b;
                val_17 = val_5.a;
            }
            
            val_2.SetColor(nameID:  this._baseColorId, value:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            val_2.SetColor(nameID:  this._detailOneColorId, value:  new UnityEngine.Color() {r = val_10, g = val_11, b = val_12, a = val_13});
            val_2.SetColor(nameID:  this._detailTWoColorId, value:  new UnityEngine.Color() {r = val_14, g = val_15, b = val_16, a = val_17});
            ve.MeshRenderer.SetPropertyBlock(properties:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxStylesColorModifier()
        {
            mem[1152921519693104280] = 1;
            val_1 = new UnityEngine.ScriptableObject();
        }
    
    }

}
