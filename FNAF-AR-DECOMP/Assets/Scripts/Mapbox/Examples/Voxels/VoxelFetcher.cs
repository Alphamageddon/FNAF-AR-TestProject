using UnityEngine;

namespace Mapbox.Examples.Voxels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VoxelFetcher : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Examples.Voxels.VoxelColorMapper[] _voxels;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject GetVoxelFromColor(UnityEngine.Color color)
        {
            UnityEngine.GameObject val_2;
            var val_3;
            Mapbox.Examples.Voxels.VoxelColorMapper val_2 = this._voxels[0];
            val_2 = this._voxels[0].Voxel;
            val_3 = 0;
            goto label_3;
            label_8:
            Mapbox.Examples.Voxels.VoxelColorMapper val_3 = this._voxels[0];
            if((Mapbox.Examples.Voxels.VoxelFetcher.GetDistanceBetweenColors(color1:  new UnityEngine.Color() {r = this._voxels[0x0][0].Color, g = color.g, b = color.b, a = color.a}, color2:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a})) < 0)
            {
                    val_2 = this._voxels[0x0][0].Voxel;
            }
            
            val_3 = 1;
            label_3:
            if(val_3 < this._voxels.Length)
            {
                goto label_8;
            }
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static float GetDistanceBetweenColors(UnityEngine.Color color1, UnityEngine.Color color2)
        {
            color1.r = color1.r - color2.r;
            color1.g = color1.g - color2.g;
            color1.b = color1.b - color2.b;
            color1.r = color1.r * color1.r;
            color1.g = color1.g * color1.g;
            color1.b = color1.b * color1.b;
            color1.r = color1.r + color1.g;
            color1.r = color1.b + color1.r;
            if(color1.g <= _TYPE_MAX_)
            {
                    return color1.g;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VoxelFetcher()
        {
        
        }
    
    }

}
