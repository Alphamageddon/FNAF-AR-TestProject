using UnityEngine;

namespace Mapbox.VectorTile.ExtensionMethods
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class VectorTileFeatureExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng>> GeometryAsWgs84(Mapbox.VectorTile.VectorTileFeature feature, ulong zoom, ulong tileColumn, ulong tileRow, System.Nullable<uint> clipBuffer)
        {
            System.Func<Mapbox.VectorTile.Geometry.Point2d<System.Int64>, Mapbox.VectorTile.Geometry.LatLng> val_11;
            VectorTileFeatureExtensions.<>c__DisplayClass0_0 val_1 = new VectorTileFeatureExtensions.<>c__DisplayClass0_0();
            if(val_1 != null)
            {
                    .zoom = zoom;
                .tileColumn = tileColumn;
                .tileRow = tileRow;
            }
            else
            {
                    mem[16] = zoom;
                mem[24] = tileColumn;
                mem[32] = tileRow;
            }
            
            .feature = feature;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng>> val_2 = new System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.LatLng>>();
            List.Enumerator<T> val_4 = (VectorTileFeatureExtensions.<>c__DisplayClass0_0)[1152921519927048576].feature.Geometry<System.Int64>(clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = clipBuffer.HasValue}, scale:  new System.Nullable<System.Single>() {HasValue = false}).GetEnumerator();
            label_9:
            if(((-1859715800) & 1) == 0)
            {
                    return val_2;
            }
            
            val_11 = (VectorTileFeatureExtensions.<>c__DisplayClass0_0)[1152921519927048576].<>9__0;
            if(val_11 == null)
            {
                    val_11 = null;
                val_11 = new System.Func<Mapbox.VectorTile.Geometry.Point2d<System.Int64>, Mapbox.VectorTile.Geometry.LatLng>(object:  val_1, method:  Mapbox.VectorTile.Geometry.LatLng VectorTileFeatureExtensions.<>c__DisplayClass0_0::<GeometryAsWgs84>b__0(Mapbox.VectorTile.Geometry.Point2d<long> g));
                .<>9__0 = val_11;
            }
            
            val_2.Add(item:  System.Linq.Enumerable.ToList<Mapbox.VectorTile.Geometry.LatLng>(source:  System.Linq.Enumerable.Select<Mapbox.VectorTile.Geometry.Point2d<System.Int64>, Mapbox.VectorTile.Geometry.LatLng>(source:  0.emailUIDataHandler, selector:  null)));
            goto label_9;
        }
    
    }

}
