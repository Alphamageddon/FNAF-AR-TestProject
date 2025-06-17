using UnityEngine;

namespace Ibuprogames.VideoGlitchesAsset
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class VideoGlitchRGBDisplay : VideoGlitchBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int cellSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string variableCellSize = "_CellSize";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Size { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Size()
        {
            return (int)this.cellSize;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Size(int value)
        {
            this.cellSize = (value > 1) ? value : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return "RGB pixelated display.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void ResetDefaultValues()
        {
            this.cellSize = 2;
            mem[1152921520048133944] = 1065353216;
            mem[1152921520048133972] = 1065353216;
            mem[1152921520048134000] = 998445679;
            mem[1152921520048134004] = 1;
            mem[1152921520048133956] = ;
            mem[1152921520048134008] = 1065353216;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SendValuesToShader()
        {
            SetInt(name:  "_CellSize", value:  this.cellSize + (this.cellSize << 1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VideoGlitchRGBDisplay()
        {
            this.cellSize = 2;
        }
    
    }

}
