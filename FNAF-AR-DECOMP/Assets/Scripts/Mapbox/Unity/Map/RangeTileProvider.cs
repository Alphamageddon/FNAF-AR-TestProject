using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RangeTileProvider : AbstractTileProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.RangeTileProviderOptions _rangeTileProviderOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initialized;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnInitialized()
        {
            Mapbox.Unity.Map.RangeTileProviderOptions val_5;
            if(!=0)
            {
                    val_5 = 0;
            }
            else
            {
                    Mapbox.Unity.Map.RangeTileProviderOptions val_3 = null;
                val_5 = val_3;
                .west = 1;
                .north = 0;
                .east = 1;
                .south = 0;
                val_3 = new Mapbox.Unity.Map.RangeTileProviderOptions();
            }
            
            this._rangeTileProviderOptions = val_5;
            this._initialized = true;
            .west = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>();
            .north = 268435459;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UpdateTileExtent()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(this._initialized == false)
            {
                    return;
            }
            
            if(this._initialized == false)
            {
                    return;
            }
            
            static_value_04282010.Clear();
            var val_11 = static_value_04282010;
            var val_8 = static_value_04282010 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            Mapbox.Utils.Vector2d val_1 = static_value_04282010.CenterLatitudeLongitude;
            var val_15 = static_value_04282010;
            var val_12 = static_value_04282010 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            Mapbox.Map.UnwrappedTileId val_3 = Mapbox.Map.TileCover.CoordinateToTileId(coord:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, zoom:  static_value_04282010.AbsoluteZoom);
            int val_20 = val_3.Z;
            var val_19 = X23;
            if((X23 + 286) == 0)
            {
                goto label_20;
            }
            
            var val_16 = X23 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_19:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (X23 + 286))
            {
                goto label_19;
            }
            
            goto label_20;
            label_18:
            var val_18 = val_16;
            val_18 = val_18 + 5;
            val_19 = val_19 + val_18;
            val_12 = val_19 + 296;
            label_20:
            int val_4 = X23.AbsoluteZoom;
            val_20 = val_20 >> 32;
            val_13 = 0;
            bool val_5 = X22 + 16.Add(item:  new Mapbox.Map.UnwrappedTileId());
            val_14 = val_20 - this._rangeTileProviderOptions.west;
            goto label_23;
            label_36:
            val_15 = val_3.Y - this._rangeTileProviderOptions.north;
            goto label_25;
            label_34:
            var val_24 = X25;
            if((X25 + 286) == 0)
            {
                goto label_31;
            }
            
            var val_21 = X25 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_30:
            if(((X25 + 176 + 8) + -8) == null)
            {
                goto label_29;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (X25 + 286))
            {
                goto label_30;
            }
            
            goto label_31;
            label_29:
            var val_23 = val_21;
            val_23 = val_23 + 5;
            val_24 = val_24 + val_23;
            val_16 = val_24 + 296;
            label_31:
            int val_6 = X25.AbsoluteZoom;
            val_13 = 0;
            bool val_7 = X24 + 16.Add(item:  new Mapbox.Map.UnwrappedTileId());
            val_15 = val_15 + 1;
            label_25:
            int val_25 = this._rangeTileProviderOptions.south;
            val_25 = val_25 + val_3.Y;
            if(val_15 <= val_25)
            {
                goto label_34;
            }
            
            val_14 = val_14 + 1;
            label_23:
            int val_26 = this._rangeTileProviderOptions.east;
            val_26 = val_26 + val_20;
            if(val_14 <= val_26)
            {
                goto label_36;
            }
            
            this.OnExtentChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeTileProvider()
        {
        
        }
    
    }

}
