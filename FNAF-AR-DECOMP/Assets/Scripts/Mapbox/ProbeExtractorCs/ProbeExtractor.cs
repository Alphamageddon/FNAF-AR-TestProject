using UnityEngine;

namespace Mapbox.ProbeExtractorCs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProbeExtractor
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.CheapRulerCs.CheapRuler _ruler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.ProbeExtractorCs.ProbeExtractorOptions _options;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProbeExtractor(Mapbox.CheapRulerCs.CheapRuler ruler, Mapbox.ProbeExtractorCs.ProbeExtractorOptions options)
        {
            val_1 = new System.Object();
            this._ruler = ruler;
            this._options = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe> ExtractProbes(System.Collections.Generic.List<Mapbox.ProbeExtractorCs.TracePoint> trace)
        {
            long val_9;
            double val_10;
            double val_11;
            long val_13;
            double val_14;
            double val_15;
            bool val_31;
            long val_36;
            float val_45;
            float val_47;
            var val_49;
            var val_51;
            double val_53;
            double val_55;
            System.Collections.Generic.List<Mapbox.ProbeExtractorCs.TracePoint> val_60;
            System.Double[] val_61;
            System.Double[] val_62;
            int val_63;
            int val_64;
            double val_65;
            Mapbox.ProbeExtractorCs.ProbeExtractor val_66;
            double val_67;
            var val_68;
            long val_69;
            double val_70;
            var val_71;
            var val_72;
            var val_73;
            float val_74;
            var val_75;
            bool val_76;
            int val_77;
            var val_78;
            System.Int64[] val_79;
            System.Collections.Generic.List<T> val_80;
            long val_81;
            int val_82;
            val_60 = trace;
            int val_1 = val_60.Count;
            int val_2 = val_1 - 1;
            long[] val_3 = new long[0];
            double[] val_4 = new double[0];
            val_61 = new double[0];
            val_62 = new double[0];
            if(val_1 > 1)
            {
                    System.Int64[] val_64 = val_3[24];
                System.Double[] val_65 = val_4[24];
                System.Double[] val_66 = val_61[24];
                System.Double[] val_67 = val_62[24];
                var val_70 = 4;
                do
            {
                int val_7 = val_70 - 3;
                Mapbox.ProbeExtractorCs.TracePoint val_8 = val_60.Item[val_7];
                long val_68 = val_9;
                val_7 = val_7 - 1;
                Mapbox.ProbeExtractorCs.TracePoint val_12 = val_60.Item[val_7];
                var val_16 = val_68 - val_13;
                val_68 = (val_16 >> 7) + (val_16 >> 63);
                val_3[0] = val_68;
                double[] val_18 = new double[2];
                val_63 = val_18.Length;
                val_62 = val_62;
                if(val_63 == 0)
            {
                    val_63 = val_18.Length;
            }
            
                val_18[0] = val_11;
                val_18[1] = val_10;
                double[] val_19 = new double[2];
                val_64 = val_19.Length;
                val_61 = val_61;
                if(val_64 == 0)
            {
                    val_64 = val_19.Length;
            }
            
                val_19[0] = val_15;
                val_19[1] = val_14;
                val_65 = mem[1152921519878584368].Distance(a:  val_18, b:  val_19);
                mem[1152921519878624576] = val_65;
                if(val_7 >= mem[1152921519878624568])
            {
                    val_65 = mem[1152921519878624576];
            }
            
                double val_69 = (double)val_3[0];
                val_69 = val_65 / val_69;
                val_65 = val_69 * 3600;
                mem[1152921519878628672] = val_65;
                double val_21 = mem[1152921519878584368].Bearing(a:  val_19, b:  val_18);
                val_60 = val_60;
                mem[1152921519878632768] = (val_21 < 0) ? (val_21 + 360) : (val_21);
                val_70 = val_70 + 1;
            }
            while((val_7 + 2) != val_1);
            
            }
            else
            {
                    System.Double[] val_71 = val_61[24];
                System.Double[] val_72 = val_4[24];
                System.Double[] val_73 = val_62[24];
                System.Int64[] val_74 = val_3[24];
            }
            
            val_66 = this;
            System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe> val_25 = new System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe>();
            val_67 = 89;
            val_68 = 0;
            val_69 = 0;
            val_70 = 0.5;
            goto label_67;
            label_75:
            if((val_69 & 1) != 0)
            {
                goto label_26;
            }
            
            System.Int64[] val_26 = val_3 + (-15264765696);
            val_71 = mem[(val_3 + -15264765696) + 32];
            val_71 = (val_3 + -15264765696) + 32;
            if((val_71 & 9223372036854775808) != 0)
            {
                goto label_29;
            }
            
            if(val_3 >= val_74)
            {
                    val_72 = mem[(val_3 + -15264765696) + 32];
                val_72 = (val_3 + -15264765696) + 32;
            }
            
            if((mem[1152921519878584376] + 16) > (double)val_72)
            {
                goto label_32;
            }
            
            System.Int64[] val_75 = val_3;
            val_75 = val_75 + 0;
            double val_76 = (double)(val_3 + 0) + 32;
            val_76 = (mem[1152921519878584376] + 32) * val_76;
            if(val_76 < 0)
            {
                goto label_41;
            }
            
            val_73 = mem[val_5[0x18]];
            val_73 = val_71;
            if(val_3 >= val_73)
            {
                    val_73 = mem[val_5[0x18]];
                val_73 = val_71;
            }
            
            val_74 = mem[mem[1152921519878584376] + 40];
            val_74 = mem[1152921519878584376] + 40;
            val_61 = val_61;
            double val_79 = (double)(val_3 + -15264765696) + 32;
            val_79 = val_74 * val_79;
            if(((val_61[-1908095712]) - val_61[0]) > val_79)
            {
                goto label_41;
            }
            
            val_75 = mem[val_5[0x18]];
            val_75 = val_71;
            if(val_68 >= val_75)
            {
                    val_75 = mem[val_5[0x18]];
                val_75 = val_71;
            }
            
            val_74 = mem[mem[1152921519878584376] + 48];
            val_74 = mem[1152921519878584376] + 48;
            double val_80 = (double)(val_3 + -15264765696) + 32;
            val_80 = val_74 * val_80;
            if(((val_5[0x0] + 32) - (val_5[0xFFFFFFFF8E44C520] + 32)) <= val_80)
            {
                goto label_46;
            }
            
            label_41:
            val_60 = val_60;
            label_32:
            val_69 = 0;
            goto label_71;
            label_29:
            val_76 = mem[1152921519878584376];
            if((mem[1152921519878584376] + 60) == 0)
            {
                goto label_84;
            }
            
            label_26:
            val_69 = 1;
            label_71:
            if((mem[1152921519878584376] + 60) == 0)
            {
                goto label_51;
            }
            
            if(val_60 != null)
            {
                goto label_72;
            }
            
            label_73:
            label_72:
            Mapbox.ProbeExtractorCs.TracePoint val_29 = val_60.Item[0];
            System.Double[] val_30 = val_4 + (-15264765696);
            System.Double[] val_34 = this.pointAtDistanceAndBearing(tracePoint:  new Mapbox.ProbeExtractorCs.TracePoint() {Timestamp = val_13, Latitude = val_13, Longitude = val_15, Bearing = val_15, Elevation = new System.Nullable<System.Single>() {HasValue = val_31}, HDop = new System.Nullable<System.Single>() {HasValue = val_31}, VDop = new System.Nullable<System.Single>() {HasValue = val_31}}, distance:  ((val_4 + -15264765696) + 32) * val_70, bearing:  val_62[-1908095712]);
            val_77 = val_34.Length;
            if(val_77 <= 1)
            {
                    val_77 = val_34.Length;
            }
            
            Mapbox.ProbeExtractorCs.TracePoint val_35 = val_60.Item[-1908095712];
            System.Int64[] val_84 = val_3;
            val_84 = val_84 + (-15264765696);
            System.Double[] val_85 = val_61;
            val_85 = val_85 + (-15264765696);
            val_9 = val_34[1];
            val_10 = val_34[0];
            val_11 = val_36;
            val_25.Add(item:  new Mapbox.ProbeExtractorCs.Probe() {Latitude = val_9, Longitude = val_10, StartTime = val_11, Duration = (val_3 + -15264765696) + 32, Speed = (val_5 + -15264765696) + 32, Bearing = val_6[0xFFFFFFFF8E44C520] + 32, Distance = (val_4 + -15264765696) + 32, IsGood = false});
            val_62 = val_62;
            val_61 = val_61;
            val_60 = val_60;
            val_66 = this;
            val_69 = val_69;
            label_51:
            val_68 = 1;
            goto label_67;
            label_46:
            val_78 = mem[val_6[0x18]];
            val_78 = val_73;
            if(val_68 >= val_78)
            {
                    val_78 = mem[val_6[0x18]];
                val_78 = val_73;
            }
            
            if((this.compareBearing(baseBearing:  val_62[0], bearing:  val_62[-1908095712], range:  val_67, allowReverse:  false)) == false)
            {
                goto label_71;
            }
            
            if(val_60 != 0)
            {
                goto label_72;
            }
            
            goto label_73;
            label_67:
            if((val_68 + 1) < val_71)
            {
                goto label_75;
            }
            
            val_79 = val_3;
            val_80 = val_25;
            if((mem[1152921519878584376] + 60) != 0)
            {
                goto label_77;
            }
            
            val_76 = mem[1152921519878584376];
            if(val_25.Count < (mem[1152921519878584376] + 56))
            {
                goto label_84;
            }
            
            label_77:
            val_76 = 1152921519878475552;
            if(val_25.Count == 0)
            {
                    if((mem[1152921519878584376] + 56) == 0)
            {
                goto label_84;
            }
            
            }
            
            if(val_25.Count < 2)
            {
                    return (System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe>)val_80;
            }
            
            Mapbox.ProbeExtractorCs.Probe val_42 = val_25.Item[0];
            Mapbox.ProbeExtractorCs.Probe val_43 = val_25.Item[1];
            val_74 = val_31;
            Mapbox.ProbeExtractorCs.Probe val_44 = val_25.Item[0];
            float val_90 = val_45;
            Mapbox.ProbeExtractorCs.Probe val_46 = val_25.Item[1];
            Mapbox.ProbeExtractorCs.Probe val_48 = val_25.Item[0];
            var val_89 = val_49;
            Mapbox.ProbeExtractorCs.Probe val_50 = val_25.Item[1];
            var val_88 = val_51;
            val_88 = val_88 + val_89;
            val_89 = (val_88 < 0) ? (val_88 + 1) : (val_88);
            Mapbox.ProbeExtractorCs.Probe val_52 = val_25.Item[0];
            Mapbox.ProbeExtractorCs.Probe val_54 = val_25.Item[1];
            if((val_69 & 1) == 0)
            {
                goto label_95;
            }
            
            val_76 = mem[1152921519878584376];
            if((mem[1152921519878584376] + 60) != 0)
            {
                goto label_122;
            }
            
            label_84:
            System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe> val_57 = null;
            val_80 = val_57;
            val_57 = new System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe>();
            return (System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe>)val_80;
            label_95:
            val_81 = val_3[0];
            if((val_81 & 9223372036854775808) != 0)
            {
                goto label_122;
            }
            
            if(val_74 == 0)
            {
                    val_81 = val_3[0];
            }
            
            val_69 = mem[1152921519878584376];
            if((mem[1152921519878584376] + 16) > (double)val_81)
            {
                goto label_122;
            }
            
            val_90 = val_90 + val_47;
            val_90 = val_90 * val_70;
            float val_91 = mem[1152921519878584376] + 24;
            val_91 = val_90 * val_91;
            if(mem[1152921519878624576] > val_91)
            {
                goto label_122;
            }
            
            val_89 = val_89 >> 1;
            val_69 = mem[1152921519878584376];
            float val_92 = mem[1152921519878584376] + 32;
            val_92 = val_92 * (double)val_89;
            if(val_92 < 0)
            {
                goto label_122;
            }
            
            val_74 = ((val_5 + -15264765696) + 32) + val_74;
            val_70 = val_74 * val_70;
            double val_94 = (double)val_3[0];
            val_94 = (mem[1152921519878584376] + 40) * val_94;
            if((val_70 - val_61[0]) > val_94)
            {
                goto label_122;
            }
            
            val_74 = mem[mem[1152921519878584376] + 48];
            val_74 = mem[1152921519878584376] + 48;
            double val_96 = (double)val_3[0];
            val_96 = val_74 * val_96;
            if(((val_61[0] - val_70) > val_96) || ((this.compareBearing(baseBearing:  val_62[0], bearing:  this.averageAngle(a:  val_53, b:  val_55), range:  val_67, allowReverse:  false)) == false))
            {
                goto label_122;
            }
            
            val_76 = 1;
            if(val_60 != null)
            {
                goto label_127;
            }
            
            goto label_124;
            label_122:
            val_76 = mem[1152921519878584376];
            if((mem[1152921519878584376] + 60) == 0)
            {
                    return (System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe>)val_80;
            }
            
            val_76 = false;
            if(val_60 != null)
            {
                goto label_127;
            }
            
            label_124:
            label_127:
            Mapbox.ProbeExtractorCs.TracePoint val_61 = val_60.Item[0];
            val_67 = mem[1152921519878624576];
            System.Double[] val_62 = this.pointAtDistanceAndBearing(tracePoint:  new Mapbox.ProbeExtractorCs.TracePoint() {Timestamp = val_13, Latitude = val_13, Longitude = val_15, Bearing = val_15, Elevation = new System.Nullable<System.Single>() {HasValue = val_31}, HDop = new System.Nullable<System.Single>() {HasValue = val_31}, VDop = new System.Nullable<System.Single>() {HasValue = val_31}}, distance:  val_67, bearing:  val_62[0]);
            val_82 = val_62.Length;
            if(val_82 <= 1)
            {
                    val_82 = val_62.Length;
            }
            
            Mapbox.ProbeExtractorCs.TracePoint val_63 = val_60.Item[0];
            val_69 = val_36;
            val_61 = val_3[0];
            val_79 = mem[1152921519878628672];
            val_9 = val_62[1];
            val_10 = val_62[0];
            val_11 = val_69;
            val_25.Insert(index:  0, item:  new Mapbox.ProbeExtractorCs.Probe() {Latitude = val_9, Longitude = val_10, StartTime = val_11, Duration = val_61, Speed = val_79, Bearing = mem[1152921519878632768], Distance = mem[1152921519878624576], IsGood = val_76});
            return (System.Collections.Generic.List<Mapbox.ProbeExtractorCs.Probe>)val_80;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double averageAngle(double a, double b)
        {
            double val_13 = b;
            double val_2 = (a >= 0) ? a : (a + 360);
            double val_4 = (val_13 >= 0) ? (val_13) : (val_13 + 360);
            double val_5 = System.Math.Min(val1:  val_2, val2:  val_4);
            double val_6 = System.Math.Max(val1:  val_2, val2:  val_4);
            double val_8 = 360 - val_6;
            double val_12 = System.Math.Abs(a - val_13);
            val_8 = val_5 + val_8;
            float val_9 = (val_12 > val_8) ? (val_8) : (val_12);
            val_9 = val_9 * 0.5;
            val_13 = ((val_12 > val_8) ? (val_6) : (val_5)) + val_9;
            float val_14 = val_13;
            val_14 = (val_13 >= 0) ? (val_14) : (val_14 + 360);
            return (double)val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double normalizeAngle(double angle)
        {
            angle = (angle >= 0) ? angle : (angle + 360);
            return (double)angle;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool compareBearing(double baseBearing, double bearing, double range, bool allowReverse)
        {
            float val_17;
            var val_18;
            var val_19;
            val_17 = baseBearing;
            val_18 = allowReverse ^ 1;
            goto label_0;
            label_3:
            val_17 = D13 + 180;
            val_18 = 1;
            label_0:
            float val_2 = (val_17 >= 0) ? (val_17) : (val_17 + 360);
            val_17 = val_2 - range;
            float val_4 = (bearing >= 0) ? bearing : (bearing + 360);
            double val_6 = val_2 + range;
            float val_7 = (val_17 >= 0) ? (val_17) : (val_17 + 360);
            float val_13 = val_6;
            val_13 = (val_6 >= 0) ? (val_13) : (val_13 + 360);
            if(val_7 < 0)
            {
                    val_19 = ((val_7 <= val_4) ? 1 : 0) & ((val_4 <= val_13) ? 1 : 0);
            }
            else
            {
                    var val_11 = (val_4 <= val_13) ? 1 : 0;
                val_19 = ((val_7 <= val_4) ? 1 : 0) | val_11;
            }
            
            val_11 = val_18 | val_19;
            if((val_11 & 1) == 0)
            {
                goto label_3;
            }
            
            return (bool)val_19;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] pointAtDistanceAndBearing(Mapbox.ProbeExtractorCs.TracePoint tracePoint, double distance, double bearing)
        {
            int val_2;
            double[] val_1 = new double[2];
            val_2 = val_1.Length;
            if(val_2 == 0)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = tracePoint.Longitude;
            val_1[1] = tracePoint.Latitude;
            if(this._ruler != null)
            {
                    return this._ruler.Destination(p:  val_1, distance:  distance, bearing:  bearing);
            }
            
            return this._ruler.Destination(p:  val_1, distance:  distance, bearing:  bearing);
        }
    
    }

}
