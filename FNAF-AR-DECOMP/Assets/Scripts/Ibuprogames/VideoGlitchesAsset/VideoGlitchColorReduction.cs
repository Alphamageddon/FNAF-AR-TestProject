using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchColorReduction : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Ibuprogames.VideoGlitchesAsset.VideoGlitchColorReduction.Ditherings dithering;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int paletteSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int pixelation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D ditheringTexture;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variablePaletteSpace = "_PaletteSpace";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variablePixelation = "_Pixelation";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableDitheringTexture = "_DitheringTex";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordBayer4x4 = "DITHERING_BAYER4x4";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordBayer8x8 = "DITHERING_BAYER8x8";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string keywordNoise = "DITHERING_NOISE";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ibuprogames.VideoGlitchesAsset.VideoGlitchColorReduction.Ditherings Dithering { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PaletteSize { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Pixelation { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Ibuprogames.VideoGlitchesAsset.VideoGlitchColorReduction.Ditherings get_Dithering()
        {
            return (Ditherings)this.dithering;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Dithering(Ibuprogames.VideoGlitchesAsset.VideoGlitchColorReduction.Ditherings value)
        {
            this.dithering = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_PaletteSize()
        {
            return (int)this.paletteSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PaletteSize(int value)
        {
            this.paletteSize = value & (~(value >> 31));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Pixelation()
        {
            return (int)this.pixelation;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Pixelation(int value)
        {
            this.pixelation = (value > 1) ? value : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "Palette quantization and dithering.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void LoadCustomResources()
        {
            this.ditheringTexture = this.LoadTextureFromResources(texturePathFromResources:  "Textures/Bayer4x4");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.pixelation = 2;
            this.dithering = 0;
            this.paletteSize = 8;
            mem[1152921520033552160] = 998445679;
            mem[1152921520033552104] = 1065353216;
            mem[1152921520033552132] = 1065353216;
            mem[1152921520033552164] = 1;
            mem[1152921520033552116] = ;
            mem[1152921520033552168] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            string val_3;
            if(this.dithering == 0)
            {
                goto label_1;
            }
            
            if(this.dithering == 1)
            {
                goto label_2;
            }
            
            if(this.dithering != 2)
            {
                goto label_8;
            }
            
            val_3 = "DITHERING_NOISE";
            goto label_5;
            label_1:
            EnableKeyword(keyword:  "DITHERING_BAYER4x4");
            SetTexture(name:  "_DitheringTex", value:  this.ditheringTexture);
            goto label_8;
            label_2:
            val_3 = "DITHERING_BAYER8x8";
            label_5:
            EnableKeyword(keyword:  val_3);
            label_8:
            SetFloat(name:  "_Pixelation", value:  (float)this.pixelation);
            if(this.paletteSize < 1)
            {
                goto label_11;
            }
            
            if(!=0)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            SetFloat(name:  "_PaletteSpace", value:  1f / (float)this.paletteSize);
            return;
            label_11:
            if(!=0)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchColorReduction()
        {
            this.paletteSize = 10;
            this.pixelation = 2;
        }
    
    }

}
