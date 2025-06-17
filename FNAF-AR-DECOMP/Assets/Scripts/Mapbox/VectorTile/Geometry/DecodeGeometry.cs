using UnityEngine;

namespace Mapbox.VectorTile.Geometry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class DecodeGeometry
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<long>>> GetGeometry(ulong extent, Mapbox.VectorTile.Geometry.GeomType geomType, System.Collections.Generic.List<uint> geometryCommands, float scale = 1)
        {
            System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>> val_19;
            var val_20;
            int val_21;
            long val_22;
            var val_23;
            var val_24;
            var val_25;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_1 = 14851;
            val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>();
            System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>> val_2 = null;
            val_19 = val_2;
            val_2 = new System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>();
            int val_3 = geometryCommands.Count;
            if(val_3 < 1)
            {
                goto label_2;
            }
            
            long val_23 = 0;
            val_20 = 0;
            val_21 = 0;
            label_20:
            uint val_4 = geometryCommands.Item[0];
            uint val_5 = val_4 & 7;
            if((val_5 - 1) > 1)
            {
                goto label_4;
            }
            
            uint val_7 = val_4 >> 3;
            if(val_7 == 0)
            {
                goto label_17;
            }
            
            var val_24 = 1;
            do
            {
                if(geometryCommands != null)
            {
                    val_22 = geometryCommands.Item[val_21 + 1];
            }
            else
            {
                    val_22 = 0.Item[val_21 + 1];
            }
            
                val_21 = val_21 + 2;
                var val_21 = val_22;
                var val_22 = geometryCommands.Item[val_21];
                val_21 = (-(val_21 & 1)) ^ (val_21 >> 1);
                val_22 = (-(val_22 & 1)) ^ (val_22 >> 1);
                val_23 = val_21 + val_23;
                val_20 = val_22 + val_20;
                if((val_5 == 1) && (val_2.Count >= 1))
            {
                    val_23 = val_1;
                if(val_23 == 0)
            {
                    val_23 = val_1;
            }
            
                val_23.Add(item:  val_2);
                System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>> val_16 = null;
                val_19 = val_16;
                val_16 = new System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>();
            }
            
                val_16.Add(item:  new Mapbox.VectorTile.Geometry.Point2d<System.Int64>());
                val_24 = val_24 + 1;
            }
            while(1 < val_7);
            
            label_4:
            if(((geomType == 3) && (val_5 == 7)) && (val_16.Count >= 1))
            {
                    if(val_19 != null)
            {
                    Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_18 = val_16.Item[0];
                val_22 = val_18.Y;
                val_24 = 0;
            }
            else
            {
                    Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_19 = 0.Item[0];
                val_22 = val_19.Y;
                val_24 = 0;
            }
            
                val_16.Add(item:  new Mapbox.VectorTile.Geometry.Point2d<System.Int64>() {Y = val_22});
            }
            
            label_17:
            val_21 = val_21 + 1;
            if(val_21 < val_3)
            {
                goto label_20;
            }
            
            label_2:
            val_25 = val_1;
            if(val_16.Count < 1)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_25;
            }
            
            if(val_25 == 0)
            {
                    val_25 = val_1;
            }
            
            val_25.Add(item:  val_16);
            return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_25;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>> Scale<T>(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<long>>> inGeom, float scale = 1)
        {
            var val_2;
            var val_3;
            int val_6;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_41;
            val_32 = __RuntimeMethodHiddenParam + 48;
            List.Enumerator<T> val_1 = inGeom.GetEnumerator();
            val_33 = 0;
            val_34 = 0;
            label_71:
            if(((-1896240416) & 1) == 0)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_5 = val_3.emailUIDataHandler.GetEnumerator();
            label_33:
            if(((-1896240448) & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_8 = val_6.trackableId;
            float val_12 = (float)val_8.m_SubId1 * scale;
            float val_13 = (float)val_8.m_SubId2 * scale;
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 32}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_9;
            }
            
            int val_15 = System.Convert.ToInt32(value:  val_13);
            val_6 = System.Convert.ToInt32(value:  val_12);
            val_3 = 0;
            InternalClipper.IntPoint val_16 = new InternalClipper.IntPoint(X:  1152921504621064192, Y:  null);
            if((__RuntimeMethodHiddenParam + 48 + 16) != 0)
            {
                goto label_33;
            }
            
            goto label_33;
            label_9:
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 32}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_18;
            }
            
            long val_21 = System.Convert.ToInt64(value:  val_13);
            val_6 = System.Convert.ToInt64(value:  val_12);
            val_3 = 0;
            InternalClipper.IntPoint val_22 = new InternalClipper.IntPoint(X:  1152921504621117440, Y:  null);
            if((__RuntimeMethodHiddenParam + 48 + 16) != 0)
            {
                goto label_33;
            }
            
            goto label_33;
            label_18:
            if((System.Type.op_Equality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 32}), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_33;
            }
            
            float val_27 = System.Convert.ToSingle(value:  val_13);
            val_6 = System.Convert.ToSingle(value:  val_12);
            val_3 = 0;
            InternalClipper.IntPoint val_28 = new InternalClipper.IntPoint(X:  1152921504623194112, Y:  null);
            if((__RuntimeMethodHiddenParam + 48 + 16) != 0)
            {
                goto label_33;
            }
            
            goto label_33;
            label_6:
            val_36 = val_34;
            val_35 = val_32;
            val_37 = 345;
            val_3 = null;
            val_2 = val_6;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_3.Dispose();
            if((( == 0) ? 345 : ()) != 345)
            {
                goto label_64;
            }
            
            if( != 0)
            {
                goto label_71;
            }
            
            goto label_71;
            label_64:
            if( == 0)
            {
                goto label_67;
            }
            
            if( != 0)
            {
                goto label_71;
            }
            
            goto label_71;
            label_67:
            if( != 0)
            {
                goto label_71;
            }
            
            goto label_71;
            label_3:
            val_41 = 380;
            val_2 = val_3;
            val_3 = null;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_3.Dispose();
            if( == 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>>)val_32;
            }
            
            if( == 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>>)val_32;
            }
            
            if( == 380)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>>)val_32;
            }
            
            return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<T>>>)val_32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Mapbox.VectorTile.Geometry.Point2d<long> zigzagDecode(long x, long y)
        {
            x = (-(x & 1)) ^ (x >> 1);
            y = (-(y & 1)) ^ (y >> 1);
            return (Mapbox.VectorTile.Geometry.Point2d<System.Int64>)x;
        }
    
    }

}
