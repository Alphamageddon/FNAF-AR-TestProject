using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileProviderOptions : ITileProviderOptions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.ITileProviderOptions RangeAroundCenterOptions(int northRange, int southRange, int eastRange, int westRange)
        {
            Mapbox.Unity.Map.RangeTileProviderOptions val_1 = new Mapbox.Unity.Map.RangeTileProviderOptions();
            if(val_1 != null)
            {
                    .west = westRange;
                .north = northRange;
                .east = eastRange;
            }
            else
            {
                    mem[16] = westRange;
                .north = northRange;
                mem[24] = eastRange;
            }
            
            .south = southRange;
            return (Mapbox.Unity.Map.ITileProviderOptions)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.ITileProviderOptions RangeAroundTransformOptions(UnityEngine.Transform tgtTransform, int visibleRange, int disposeRange)
        {
            Mapbox.Unity.Map.RangeAroundTransformTileProviderOptions val_1 = new Mapbox.Unity.Map.RangeAroundTransformTileProviderOptions();
            if(val_1 != null)
            {
                    .targetTransform = tgtTransform;
                .visibleBuffer = visibleRange;
            }
            else
            {
                    mem[16] = tgtTransform;
                mem[24] = visibleRange;
            }
            
            .disposeBuffer = disposeRange;
            return (Mapbox.Unity.Map.ITileProviderOptions)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Unity.Map.ITileProviderOptions CameraBoundsProviderOptions(UnityEngine.Camera camera, int visibleRange, int disposeRange)
        {
            Mapbox.Unity.Map.CameraBoundsTileProviderOptions val_1 = new Mapbox.Unity.Map.CameraBoundsTileProviderOptions();
            if(val_1 != null)
            {
                    .camera = camera;
                .visibleBuffer = visibleRange;
            }
            else
            {
                    mem[16] = camera;
                mem[24] = visibleRange;
            }
            
            .disposeBuffer = disposeRange;
            return (Mapbox.Unity.Map.ITileProviderOptions)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileProviderOptions()
        {
        
        }
    
    }

}
