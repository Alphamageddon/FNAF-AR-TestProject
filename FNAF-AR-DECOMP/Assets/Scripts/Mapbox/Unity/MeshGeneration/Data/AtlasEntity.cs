using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AtlasEntity
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Rect TextureRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MidFloorCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ColumnCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TopSectionRatio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BottomSectionRatio;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PreferredEdgeSectionLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float FirstFloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TopFloorHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float bottomOfTopUv;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float topOfMidUv;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float topOfBottomUv;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float midUvHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float WallToFloorRatio;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CalculateParameters()
        {
            float val_2 = this.TopSectionRatio;
            val_2 = S1 * val_2;
            val_2 = V0.16B - val_2;
            this.bottomOfTopUv = val_2;
            val_2 = val_2 * this.TopSectionRatio;
            val_2 = val_2 - val_2;
            this.topOfMidUv = val_2;
            float val_3 = this.BottomSectionRatio;
            val_3 = this.TopSectionRatio * val_3;
            val_3 = val_2 + val_3;
            this.topOfBottomUv = val_3;
            float val_4 = this.TopSectionRatio;
            val_4 = 1f - val_4;
            float val_1 = val_4 - this.BottomSectionRatio;
            val_3 = val_3 * val_1;
            this.midUvHeight = val_3;
            val_3 = val_3 / val_3;
            val_3 = val_1 * val_3;
            this.WallToFloorRatio = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AtlasEntity()
        {
            this.PreferredEdgeSectionLength = 10;
        }
    
    }

}
