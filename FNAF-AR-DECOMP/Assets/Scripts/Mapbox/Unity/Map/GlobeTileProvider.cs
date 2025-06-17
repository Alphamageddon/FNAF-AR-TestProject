using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GlobeTileProvider : AbstractTileProvider
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnInitialized()
        {
            System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> val_1 = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>();
            if(!=0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UpdateTileExtent()
        {
            var val_6;
            var val_13;
            var val_16;
            val_13 = this;
            bool val_15 = static_value_04282000;
            var val_12 = static_value_04282000 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(AbsoluteZoom >= 6)
            {
                goto label_6;
            }
            
            Mapbox.Utils.Vector2dBounds val_2 = Mapbox.Utils.Vector2dBounds.World();
            bool val_19 = static_value_04282000;
            var val_16 = static_value_04282000 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            int val_3 = AbsoluteZoom;
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_4 = Mapbox.Map.TileCover.Get(bounds:  new Mapbox.Utils.Vector2dBounds() {SouthWest = new Mapbox.Utils.Vector2d() {x = val_3, y = val_3}, NorthEast = new Mapbox.Utils.Vector2d() {x = val_3, y = val_3}}, zoom:  0);
            HashSet.Enumerator<T> val_5 = val_4.GetEnumerator();
            label_16:
            if(((-1962921744) & 1) == 0)
            {
                goto label_13;
            }
            
            val_6 = 0;
            bool val_8 = val_4.Add(item:  new Mapbox.Map.UnwrappedTileId());
            goto label_16;
            label_13:
            val_16 = public System.Void HashSet.Enumerator<Mapbox.Map.CanonicalTileId>::Dispose();
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519823794416});
            return;
            label_6:
            System.Exception val_10 = null;
            val_13 = val_10;
            val_10 = new System.Exception(message:  "Too many tiles! Use a lower zoom level!");
            if(0 == 1)
            {
                    val_16 = public System.Void HashSet.Enumerator<Mapbox.Map.CanonicalTileId>::Dispose();
                long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519823794416});
                if(null == null)
            {
                    return;
            }
            
                val_16 = 0;
                return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GlobeTileProvider()
        {
        
        }
    
    }

}
