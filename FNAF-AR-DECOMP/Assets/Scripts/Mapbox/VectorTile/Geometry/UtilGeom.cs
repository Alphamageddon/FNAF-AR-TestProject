using UnityEngine;

namespace Mapbox.VectorTile.Geometry
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class UtilGeom
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<long>>> ClipGeometries(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<long>>> geoms, Mapbox.VectorTile.Geometry.GeomType geomType, long extent, uint bufferSize, float scale)
        {
            long val_4;
            var val_27;
            var val_48;
            var val_63;
            var val_64;
            var val_66;
            System.Collections.Generic.List<T> val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            Mapbox.VectorTile.Geometry.GeomType val_79;
            System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_80;
            System.Collections.Generic.List<T> val_81;
            var val_82;
            long val_63 = extent;
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_1 = null;
            val_63 = val_1;
            val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>();
            if(geomType != 1)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_2 = geoms.GetEnumerator();
            val_64 = 0;
            uint val_5 = val_64 - bufferSize;
            val_63 = val_63 + bufferSize;
            val_66 = 1152921519890412672;
            val_67 = 1152921519890413696;
            val_68 = val_64;
            label_24:
            if(((-1894950368) & 1) == 0)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>> val_7 = new System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>();
            List.Enumerator<T> val_8 = val_4.emailUIDataHandler.GetEnumerator();
            label_11:
            if(((-1894950400) & 1) == 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_9 = val_4.trackableId;
            if((((val_9.m_SubId1 < val_5) || (val_9.m_SubId2 < val_5)) || (val_9.m_SubId1 > val_63)) || (val_9.m_SubId2 > val_63))
            {
                goto label_11;
            }
            
            null.Add(item:  new Mapbox.VectorTile.Geometry.Point2d<System.Int64>() {Y = val_9.m_SubId1});
            goto label_11;
            label_5:
            val_69 = val_63;
            val_70 = val_68;
            long val_10 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519891765760});
            if(((146 == 0) ? 146 : 146) != 146)
            {
                goto label_15;
            }
            
            if(null != null)
            {
                goto label_21;
            }
            
            goto label_20;
            label_15:
            if( == 0)
            {
                goto label_18;
            }
            
            if(null != null)
            {
                goto label_21;
            }
            
            goto label_20;
            label_18:
            if(null != null)
            {
                goto label_21;
            }
            
            label_20:
            label_21:
            if(null.Count < 1)
            {
                goto label_24;
            }
            
            val_72.Add(item:  null);
            goto label_24;
            label_1:
            bool val_13 = (geomType != 2) ? 1 : 0;
            System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_14 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
            System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_15 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>(capacity:  1);
            System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_16 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
            System.Collections.Generic.List<IntPoint> val_17 = new System.Collections.Generic.List<IntPoint>(capacity:  4);
            if(val_15 != null)
            {
                    val_15.Add(item:  val_17);
            }
            else
            {
                    val_15.Add(item:  val_17);
            }
            
            uint val_19 = 0 - bufferSize;
            val_15.Item[0].Add(item:  new IntPoint() {X = val_19, Y = val_19});
            val_63 = bufferSize + val_63;
            val_15.Item[0].Add(item:  new IntPoint() {X = val_63, Y = val_19});
            val_15.Item[0].Add(item:  new IntPoint() {X = val_63, Y = val_63});
            val_15.Item[0].Add(item:  new IntPoint() {X = val_19, Y = val_63});
            List.Enumerator<T> val_23 = val_68.GetEnumerator();
            val_73 = 1152921519890413696;
            val_74 = 0;
            val_75 = 0;
            label_50:
            if(((-1894950368) & 1) == 0)
            {
                goto label_35;
            }
            
            System.Collections.Generic.List<IntPoint> val_25 = new System.Collections.Generic.List<IntPoint>();
            List.Enumerator<T> val_26 = val_4.emailUIDataHandler.GetEnumerator();
            label_39:
            if(((-1894950400) & 1) == 0)
            {
                goto label_37;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_29 = val_27.trackableId;
            null.Add(item:  new IntPoint() {X = val_29.m_SubId1, Y = val_29.m_SubId2});
            goto label_39;
            label_37:
            val_76 = val_75;
            long val_30 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519891765760});
            if(((431 == 0) ? 431 : 431) != 431)
            {
                goto label_43;
            }
            
            val_77 = val_14;
            if(val_77 != null)
            {
                goto label_49;
            }
            
            goto label_48;
            label_43:
            val_77 = val_14;
            if( == 0)
            {
                goto label_46;
            }
            
            if(val_77 != null)
            {
                goto label_49;
            }
            
            goto label_48;
            label_46:
            if(val_77 != null)
            {
                goto label_49;
            }
            
            label_48:
            label_49:
            val_14.Add(item:  null);
            goto label_50;
            label_35:
            val_78 = val_68;
            val_79 = geomType;
            val_80 = val_14;
            val_67 = val_15;
            goto label_51;
            label_3:
            val_73 = 192;
            long val_32 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519891765792});
            if(( != 0) && (val_73 != 0))
            {
                    val_78 = val_63;
                if(val_73 == 192)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            }
            
            }
            
            val_78 = val_63;
            return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            label_51:
            long val_33 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519891765792});
            if(((W22 == 0) ? 464 : (W22)) == 464)
            {
                    val_66 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_75 = 0;
            }
            
            }
            
            InternalClipper.Clipper val_35 = new InternalClipper.Clipper(InitOptions:  0);
            if(val_35 != null)
            {
                    bool val_36 = val_35.AddPaths(ppg:  null, polyType:  0, closed:  val_13);
            }
            else
            {
                    bool val_37 = 0.AddPaths(ppg:  null, polyType:  0, closed:  val_13);
            }
            
            bool val_38 = 0.AddPaths(ppg:  val_15, polyType:  1, closed:  true);
            if( == 2)
            {
                    InternalClipper.PolyTree val_39 = new InternalClipper.PolyTree();
                if((val_35.Execute(clipType:  0, polytree:  val_39, subjFillType:  1, clipFillType:  1)) == false)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            }
            
                val_81 = InternalClipper.Clipper.PolyTreeToPaths(polytree:  val_39);
            }
            else
            {
                    val_81 = val_16;
                if((val_35.Execute(clipType:  0, solution:  val_16, subjFillType:  1, clipFillType:  1)) == false)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            }
            
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>> val_43 = null;
            val_78 = val_43;
            val_43 = new System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>();
            List.Enumerator<T> val_44 = val_16.GetEnumerator();
            val_73 = 1152921519890270976;
            label_101:
            if(((-1894950432) & 1) == 0)
            {
                goto label_80;
            }
            
            System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>> val_46 = new System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>();
            List.Enumerator<T> val_47 = val_4.emailUIDataHandler.GetEnumerator();
            val_82 = val_75;
            label_84:
            if(((-1894950464) & 1) == 0)
            {
                goto label_85;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_50 = val_48.trackableId;
            null.Add(item:  new Mapbox.VectorTile.Geometry.Point2d<System.Int64>() {Y = val_50.m_SubId1});
            goto label_84;
            label_85:
            long val_51 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519891765696});
            if(((680 == 0) ? 680 : 680) == 680)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_82 = 0;
            }
            
            }
            
            if( == 3)
            {
                    Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_53 = null.Item[0];
                Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_56 = null.Item[null.Count - 1];
                val_4 = val_56.Y;
                long val_58 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_53.Y});
                if((val_53.Y.Equals(obj:  val_4)) != true)
            {
                    Mapbox.VectorTile.Geometry.Point2d<System.Int64> val_61 = null.Item[null.Count - 1];
                null.Insert(index:  0, item:  new Mapbox.VectorTile.Geometry.Point2d<System.Int64>() {Y = val_61.Y});
            }
            
            }
            
            val_43.Add(item:  null);
            goto label_101;
            label_80:
            val_66 = 790;
            long val_62 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519891765728});
            if( == 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            }
            
            if(790 == 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            }
            
            if(790 == 790)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
            }
            
            return (System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.Point2d<System.Int64>>>)val_78;
        }
    
    }

}
