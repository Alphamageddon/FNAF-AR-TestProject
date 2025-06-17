using UnityEngine;

namespace Mapbox.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PolygonUtils
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool PointInPolygon(Mapbox.VectorTile.Geometry.Point2d<float> coord, System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<float>>> poly)
        {
            var val_6;
            var val_12;
            InternalClipper.IntPoint val_1 = new InternalClipper.IntPoint(x:  (double)coord.Y, y:  (double)V1.16B);
            System.Collections.Generic.List<IntPoint> val_2 = new System.Collections.Generic.List<IntPoint>();
            List.Enumerator<T> val_4 = poly.Item[0].GetEnumerator();
            label_5:
            if(((-1842321120) & 1) == 0)
            {
                goto label_3;
            }
            
            val_6 = 0;
            InternalClipper.IntPoint val_7 = new InternalClipper.IntPoint(x:  (double)val_6, y:  (double)(double)V1.16B);
            val_2.Add(item:  new IntPoint() {X = val_7.X, Y = val_7.Y});
            goto label_5;
            label_3:
            val_12 = public System.Void List.Enumerator<Mapbox.VectorTile.Geometry.Point2d<System.Single>>::Dispose();
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519944395040});
            return (bool)((InternalClipper.Clipper.PointInPolygon(pt:  new IntPoint() {X = val_1.X, Y = val_1.Y}, path:  val_2)) == 1) ? 1 : 0;
        }
    
    }

}
