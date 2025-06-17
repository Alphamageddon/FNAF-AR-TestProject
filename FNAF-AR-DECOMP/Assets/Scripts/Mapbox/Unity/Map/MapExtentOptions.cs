using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MapExtentOptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.MapExtentType extentType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.CameraBoundsTileProviderOptions cameraBoundsOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.RangeTileProviderOptions rangeAroundCenterOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.RangeAroundTransformTileProviderOptions rangeAroundTransformOptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapExtentOptions(Mapbox.Unity.Map.MapExtentType type)
        {
            this.cameraBoundsOptions = new Mapbox.Unity.Map.CameraBoundsTileProviderOptions();
            Mapbox.Unity.Map.RangeTileProviderOptions val_2 = null;
            .west = 1;
            .north = 0;
            .east = 1;
            .south = 0;
            val_2 = new Mapbox.Unity.Map.RangeTileProviderOptions();
            this.rangeAroundCenterOptions = val_2;
            this.rangeAroundTransformOptions = new Mapbox.Unity.Map.RangeAroundTransformTileProviderOptions();
            this.extentType = type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ITileProviderOptions GetTileProviderOptions()
        {
            Mapbox.Unity.Map.CameraBoundsTileProviderOptions val_2;
            Mapbox.Unity.Map.TileProviderOptions val_1 = null;
            val_2 = val_1;
            val_1 = new Mapbox.Unity.Map.TileProviderOptions();
            if(this.extentType == 2)
            {
                goto label_1;
            }
            
            if(this.extentType == 1)
            {
                goto label_2;
            }
            
            if(this.extentType != 0)
            {
                    return (Mapbox.Unity.Map.ITileProviderOptions)val_2;
            }
            
            val_2 = this.cameraBoundsOptions;
            return (Mapbox.Unity.Map.ITileProviderOptions)val_2;
            label_1:
            val_2 = this.rangeAroundTransformOptions;
            return (Mapbox.Unity.Map.ITileProviderOptions)val_2;
            label_2:
            val_2 = this.rangeAroundCenterOptions;
            return (Mapbox.Unity.Map.ITileProviderOptions)val_2;
        }
    
    }

}
