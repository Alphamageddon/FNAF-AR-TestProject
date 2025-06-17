using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RangeAroundTransformTileProvider : AbstractTileProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.RangeAroundTransformTileProviderOptions _rangeTileProviderOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _initialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.UnwrappedTileId _currentTile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.UnwrappedTileId _cachedTile;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnInitialized()
        {
            var val_9;
            var val_11;
            if(true != 0)
            {
                    this._rangeTileProviderOptions = true;
                if(16824064 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "TransformTileProvider: No location marker transform specified.");
                UnityEngine.Object.Destroy(obj:  this);
            }
            else
            {
                    this._initialized = true;
            }
            
                mem[1152921519827549288] = 0;
                this._cachedTile = 0;
                System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> val_3 = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>();
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = 9;
                val_3.add_OnInitialized(value:  new System.Action(object:  this, method:  typeof(Mapbox.Unity.Map.RangeAroundTransformTileProvider).__il2cppRuntimeField_1F0));
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_11 = 11;
                val_3.add_OnUpdated(value:  new System.Action(object:  this, method:  typeof(Mapbox.Unity.Map.RangeAroundTransformTileProvider).__il2cppRuntimeField_1F0));
                return;
            }
            
            this._rangeTileProviderOptions = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UpdateTileExtent()
        {
            UnityEngine.Transform val_7;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(this._initialized == false)
            {
                    return;
            }
            
            static_value_04282010.Clear();
            val_7 = this._rangeTileProviderOptions.targetTransform;
            UnityEngine.Vector3 val_1 = val_7.localPosition;
            var val_10 = static_value_04282010;
            var val_7 = static_value_04282010 + 176;
            var val_8 = 0;
            val_7 = val_7 + 8;
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            Mapbox.Utils.Vector2d val_2 = static_value_04282010.WorldToGeoPosition(realworldPoint:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            var val_14 = static_value_04282010;
            var val_11 = static_value_04282010 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            Mapbox.Map.UnwrappedTileId val_4 = Mapbox.Map.TileCover.CoordinateToTileId(coord:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, zoom:  static_value_04282010.AbsoluteZoom);
            this._currentTile = val_4;
            mem[1152921519827702316] = val_4.Y;
            val_10 = this._cachedTile;
            if((1152921519827702308 & 1) != 0)
            {
                    return;
            }
            
            val_11 = static_value_04282010 - this._rangeTileProviderOptions.visibleBuffer;
            goto label_18;
            label_31:
            val_12 = this._rangeTileProviderOptions - this._rangeTileProviderOptions.visibleBuffer;
            goto label_20;
            label_29:
            var val_18 = X23;
            if((X23 + 286) == 0)
            {
                goto label_26;
            }
            
            var val_15 = X23 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_25:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_24;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (X23 + 286))
            {
                goto label_25;
            }
            
            goto label_26;
            label_24:
            var val_17 = val_15;
            val_17 = val_17 + 5;
            val_18 = val_18 + val_17;
            val_13 = val_18 + 296;
            label_26:
            int val_5 = X23.AbsoluteZoom;
            val_10 = 0;
            bool val_6 = this._rangeTileProviderOptions.targetTransform.Add(item:  new Mapbox.Map.UnwrappedTileId());
            val_12 = val_12 + 1;
            label_20:
            int val_19 = this._rangeTileProviderOptions.visibleBuffer;
            val_19 = val_19 + this._rangeTileProviderOptions.targetTransform;
            if(val_12 <= val_19)
            {
                goto label_29;
            }
            
            val_11 = val_11 + 1;
            label_18:
            int val_20 = this._rangeTileProviderOptions.visibleBuffer;
            val_20 = val_20 + val_12;
            if(val_11 <= val_20)
            {
                goto label_31;
            }
            
            this._cachedTile = this._currentTile;
            mem[1152921519827702328] = val_17;
            this.OnExtentChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Update()
        {
            if(this._rangeTileProviderOptions == null)
            {
                    return;
            }
            
            if(this._rangeTileProviderOptions.targetTransform == 0)
            {
                    return;
            }
            
            if(this._rangeTileProviderOptions.targetTransform.hasChanged == false)
            {
                    return;
            }
            
            this._rangeTileProviderOptions.targetTransform.hasChanged = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RangeAroundTransformTileProvider()
        {
        
        }
    
    }

}
