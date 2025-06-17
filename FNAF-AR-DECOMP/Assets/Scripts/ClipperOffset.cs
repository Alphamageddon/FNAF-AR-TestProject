using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class InternalClipper.ClipperOffset
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> m_destPolys;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> m_srcPoly;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> m_destPoly;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.DoublePoint> m_normals;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double m_delta;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double m_sinA;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double m_sin;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double m_cos;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double m_miterLim;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double m_StepsPerRad;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint m_lowest;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode m_polyNodes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double <ArcTolerance>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double <MiterLimit>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const double two_pi = 6.28318530717959;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const double def_arc_tolerance = 0.25;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double ArcTolerance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double MiterLimit { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_ArcTolerance()
    {
        return (double)this.<ArcTolerance>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ArcTolerance(double value)
    {
        this.<ArcTolerance>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_MiterLimit()
    {
        return (double)this.<MiterLimit>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MiterLimit(double value)
    {
        this.<MiterLimit>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.ClipperOffset(double miterLimit = 2, double arcTolerance = 0.25)
    {
        this.m_normals = new System.Collections.Generic.List<DoublePoint>();
        this.m_polyNodes = new InternalClipper.PolyNode();
        this.<ArcTolerance>k__BackingField = arcTolerance;
        this.<MiterLimit>k__BackingField = miterLimit;
        this.m_lowest = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Clear()
    {
        this.m_polyNodes.m_Childs.Clear();
        this.m_lowest = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static long Round(double value)
    {
        value = ((value >= 0) ? 0.5 : -0.5) + value;
        return (long)(long)value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddPath(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> path, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.JoinType joinType, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.EndType endType)
    {
        System.Collections.Generic.List<IntPoint> val_25;
        JoinType val_26;
        InternalClipper.ClipperOffset val_27;
        int val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_26 = joinType;
        val_27 = this;
        val_28 = path.Count - 1;
        if((val_28 & 2147483648) != 0)
        {
                return;
        }
        
        InternalClipper.PolyNode val_2 = new InternalClipper.PolyNode();
        if(val_2 != null)
        {
                .m_jointype = val_26;
        }
        else
        {
                .m_jointype = val_26;
        }
        
        .m_endtype = endType;
        if((endType > 1) || (val_28 < 1))
        {
            goto label_10;
        }
        
        label_11:
        if(path != null)
        {
                IntPoint val_3 = path.Item[0];
            val_29 = val_3.X;
            val_30 = val_3.Y;
        }
        else
        {
                IntPoint val_4 = 0.Item[0];
            val_29 = val_4.X;
            val_30 = val_4.Y;
        }
        
        IntPoint val_5 = path.Item[val_28];
        if((val_30 != val_5.Y) || (val_29 != val_5.X))
        {
            goto label_10;
        }
        
        val_28 = val_28 - 1;
        if(val_28 >= 1)
        {
            goto label_11;
        }
        
        label_10:
        val_25 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon;
        val_25.Capacity = val_28 + 1;
        val_27 = 1152921519901027632;
        IntPoint val_7 = path.Item[0];
        (InternalClipper.PolyNode)[1152921519921554960].m_polygon.Add(item:  new IntPoint() {X = val_7.X, Y = val_7.Y});
        if(val_28 < 1)
        {
            goto label_16;
        }
        
        val_31 = 0;
        val_26 = 0;
        var val_24 = 1;
        label_33:
        val_25 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon;
        IntPoint val_8 = val_25.Item[0];
        val_32 = val_8.X;
        IntPoint val_9 = path.Item[1];
        if(val_8.Y == val_9.Y)
        {
                if(val_32 == val_9.X)
        {
            goto label_29;
        }
        
        }
        
        IntPoint val_10 = path.Item[1];
        (InternalClipper.PolyNode)[1152921519921554960].m_polygon.Add(item:  new IntPoint() {X = val_10.X, Y = val_10.Y});
        val_31 = val_31 + 1;
        IntPoint val_11 = path.Item[1];
        val_25 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon;
        val_32 = val_11.Y;
        IntPoint val_12 = val_25.Item[0];
        if(val_32 <= val_12.Y)
        {
            goto label_25;
        }
        
        label_32:
        val_26 = val_31;
        goto label_29;
        label_25:
        IntPoint val_13 = path.Item[1];
        val_25 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon;
        val_32 = val_13.Y;
        IntPoint val_14 = val_25.Item[0];
        if(val_32 != val_14.Y)
        {
            goto label_29;
        }
        
        IntPoint val_15 = path.Item[1];
        val_25 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon;
        val_32 = val_15.X;
        IntPoint val_16 = val_25.Item[0];
        if(val_32 < val_16.X)
        {
            goto label_32;
        }
        
        label_29:
        val_24 = val_24 + 1;
        if(val_24 <= val_28)
        {
            goto label_33;
        }
        
        goto label_34;
        label_16:
        val_26 = 0;
        val_31 = 0;
        label_34:
        if(endType == 0)
        {
                if(val_31 < 2)
        {
                return;
        }
        
        }
        
        val_25 = mem[1152921519921510784];
        val_25.AddChild(Child:  val_2);
        if(endType != 0)
        {
                return;
        }
        
        val_25 = mem[1152921519921510784];
        if((mem[1152921519921510768] & 9223372036854775808) != 0)
        {
            goto label_46;
        }
        
        PolyNode val_17 = mem[1152921519921510784] + 48.Item[mem[1152921519921510768]];
        IntPoint val_18 = val_17.m_polygon.Item[mem[1152921519921510776]];
        IntPoint val_19 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon.Item[0];
        if(val_19.Y <= val_18.Y)
        {
            goto label_45;
        }
        
        label_50:
        val_25 = mem[1152921519921510784];
        label_46:
        mem[1152921519921510768] = (long)val_25.ChildCount - 1;
        mem[1152921519921510776] = 0;
        return;
        label_45:
        IntPoint val_22 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon.Item[0];
        if(val_22.Y != val_18.Y)
        {
                return;
        }
        
        IntPoint val_23 = (InternalClipper.PolyNode)[1152921519921554960].m_polygon.Item[0];
        if(val_23.X < val_18.X)
        {
            goto label_50;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> paths, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.JoinType joinType, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.EndType endType)
    {
        List.Enumerator<T> val_1 = paths.GetEnumerator();
        label_3:
        if(((-1865019560) & 1) == 0)
        {
            goto label_2;
        }
        
        this.AddPath(path:  0.emailUIDataHandler, joinType:  joinType, endType:  endType = endType);
        goto label_3;
        label_2:
        long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519921696600});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixOrientations()
    {
        InternalClipper.IntPoint val_9;
        var val_10;
        InternalClipper.PolyNode val_11;
        var val_12;
        System.Collections.Generic.List<IntPoint> val_13;
        val_9 = this.m_lowest;
        if((val_9 & 9223372036854775808) != 0)
        {
            goto label_1;
        }
        
        if(this.m_polyNodes == null)
        {
                val_9 = this.m_lowest;
        }
        
        PolyNode val_1 = this.m_polyNodes.m_Childs.Item[val_9];
        if((InternalClipper.Clipper.Orientation(poly:  val_1.m_polygon)) == false)
        {
            goto label_5;
        }
        
        label_1:
        val_10 = 0;
        goto label_6;
        label_14:
        PolyNode val_3 = this.m_polyNodes.m_Childs.Item[0];
        if(val_3.m_endtype == 1)
        {
                if((InternalClipper.Clipper.Orientation(poly:  val_3.m_polygon)) != true)
        {
                val_3.m_polygon.Reverse();
        }
        
        }
        
        val_10 = 1;
        label_6:
        val_11 = this.m_polyNodes;
        if(val_10 < val_11.ChildCount)
        {
            goto label_14;
        }
        
        return;
        label_5:
        val_12 = 0;
        goto label_16;
        label_26:
        val_13 = this.m_polyNodes.m_Childs.Item[0];
        if(val_6.m_endtype == 1)
        {
            goto label_20;
        }
        
        if(val_6.m_endtype != 0)
        {
            goto label_23;
        }
        
        val_13 = val_6.m_polygon;
        goto label_22;
        label_20:
        if((InternalClipper.Clipper.Orientation(poly:  val_6.m_polygon)) == false)
        {
            goto label_23;
        }
        
        label_22:
        val_6 + 24.Reverse();
        label_23:
        val_12 = 1;
        label_16:
        val_11 = this.m_polyNodes;
        if(val_12 < val_11.ChildCount)
        {
            goto label_26;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.DoublePoint GetUnitNormal(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2)
    {
        float val_6;
        long val_1 = pt2.X - pt1.X;
        long val_2 = pt2.Y - pt1.Y;
        if((val_1 | val_2) == 0)
        {
                return new DoublePoint();
        }
        
        double val_4 = (double)val_1 * (double)val_1;
        double val_5 = (double)val_2 * (double)val_2;
        val_5 = val_4 + val_5;
        if(val_4 >= _TYPE_MAX_)
        {
                val_6 = val_5;
        }
        
        double val_6 = 1;
        val_6 = val_6 / val_6;
        val_6 = val_6 * (double)val_2;
        val_6 = -(val_6 * (double)val_1);
        return new DoublePoint();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DoOffset(double delta)
    {
        PolyNode val_83;
        var val_84;
        InternalClipper.PolyNode val_85;
        double val_86;
        float val_87;
        double val_88;
        var val_89;
        var val_90;
        System.Collections.Generic.List<IntPoint> val_91;
        float val_92;
        System.Collections.Generic.List<IntPoint> val_93;
        int val_94;
        double val_95;
        double val_96;
        var val_97;
        System.Collections.Generic.List<IntPoint> val_98;
        var val_99;
        double val_102;
        double val_103;
        int val_104;
        int val_105;
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        this.m_destPolys = val_1;
        this.m_delta = delta;
        if((delta <= (-1E-20)) || (delta >= 0))
        {
            goto label_2;
        }
        
        val_1.Capacity = this.m_polyNodes.ChildCount;
        val_83 = 1152921519892539584;
        val_84 = 0;
        goto label_5;
        label_12:
        PolyNode val_3 = this.m_polyNodes.m_Childs.Item[0];
        if(val_3.m_endtype == 0)
        {
                this.m_destPolys.Add(item:  val_3.m_polygon);
        }
        
        val_84 = 1;
        label_5:
        val_85 = this.m_polyNodes;
        if(val_84 < val_85.ChildCount)
        {
            goto label_12;
        }
        
        return;
        label_2:
        double val_83 = this.<MiterLimit>k__BackingField;
        if(val_83 > 2)
        {
                val_83 = val_83 * val_83;
            val_86 = 2 / val_83;
        }
        else
        {
                val_86 = 0.5;
        }
        
        this.m_miterLim = val_86;
        if((this.<ArcTolerance>k__BackingField) <= 0f)
        {
            goto label_16;
        }
        
        val_87 = System.Math.Abs(delta) * 0.25;
        if((this.<ArcTolerance>k__BackingField) <= val_87)
        {
            goto label_19;
        }
        
        goto label_23;
        label_16:
        val_87 = 0.25;
        goto label_23;
        label_19:
        val_87 = this.<ArcTolerance>k__BackingField;
        label_23:
        double val_85 = System.Math.Abs(delta);
        val_85 = val_87 / val_85;
        val_85 = 1 - val_85;
        val_88 = 6.28318530717959;
        double val_5 = 3.14159265358979 / val_85;
        val_87 = val_88 / val_5;
        this.m_sin = val_87;
        this.m_cos = val_87;
        this.m_StepsPerRad = val_5 / val_88;
        if(delta < 0)
        {
                this.m_sin = -this.m_sin;
        }
        
        this.m_destPolys.Capacity = this.m_polyNodes.ChildCount << 1;
        val_89 = 1152921519892539584;
        val_90 = 0;
        goto label_29;
        label_137:
        val_83 = this.m_polyNodes.m_Childs.Item[0];
        this.m_srcPoly = val_9.m_polygon;
        int val_10 = val_9.m_polygon.Count;
        if(val_10 == 0)
        {
            goto label_46;
        }
        
        if(delta <= 0f)
        {
            goto label_35;
        }
        
        label_47:
        System.Collections.Generic.List<IntPoint> val_11 = null;
        val_91 = val_11;
        val_11 = new System.Collections.Generic.List<IntPoint>();
        int val_12 = val_10 - 1;
        this.m_destPoly = val_91;
        if(delta != 0f)
        {
            goto label_36;
        }
        
        if(val_9.m_jointype != 1)
        {
            goto label_37;
        }
        
        if(val_5 < 1)
        {
            goto label_134;
        }
        
        val_92 = 0;
        val_83 = 2;
        val_88 = 1;
        goto label_39;
        label_43:
        double val_87 = this.m_sin;
        double val_86 = this.m_cos;
        val_93 = this.m_destPoly;
        val_83 = 3;
        val_86 = val_88 * val_86;
        val_87 = val_92 * val_87;
        val_92 = (val_92 * val_86) + (val_88 * val_87);
        val_88 = val_86 - val_87;
        label_39:
        IntPoint val_15 = this.m_srcPoly.Item[0];
        double val_88 = (double)val_15.X;
        val_87 = val_88 * delta;
        val_88 = val_87 + val_88;
        val_88 = val_88 + ((val_88 >= 0) ? 0.5 : -0.5);
        IntPoint val_17 = this.m_srcPoly.Item[0];
        double val_89 = (double)val_17.Y;
        val_89 = (val_92 * delta) + val_89;
        val_89 = val_89 + ((val_89 >= 0) ? 0.5 : -0.5);
        val_93.Add(item:  new IntPoint() {X = (long)val_88, Y = (long)val_89});
        if(val_5 >= 3)
        {
            goto label_43;
        }
        
        goto label_134;
        label_35:
        if((val_10 < 3) || (val_9.m_endtype != 0))
        {
            goto label_46;
        }
        
        goto label_47;
        label_36:
        this.m_normals.Clear();
        this.m_normals.Capacity = val_10;
        if(val_12 >= 1)
        {
                var val_90 = 1;
            do
        {
            IntPoint val_21 = this.m_srcPoly.Item[val_90 - 1];
            IntPoint val_22 = this.m_srcPoly.Item[1];
            DoublePoint val_23 = InternalClipper.ClipperOffset.GetUnitNormal(pt1:  new IntPoint() {X = val_21.X, Y = val_21.Y}, pt2:  new IntPoint() {X = val_22.X, Y = val_22.Y});
            this.m_normals.Add(item:  new DoublePoint() {X = val_23.X, Y = val_23.Y});
            val_90 = val_90 + 1;
        }
        while(val_10 != val_90);
        
        }
        
        if((val_9 + 40) > 1)
        {
            goto label_56;
        }
        
        val_94 = val_12;
        IntPoint val_24 = this.m_srcPoly.Item[val_94];
        val_83 = val_83;
        IntPoint val_25 = this.m_srcPoly.Item[0];
        DoublePoint val_26 = InternalClipper.ClipperOffset.GetUnitNormal(pt1:  new IntPoint() {X = val_24.X, Y = val_24.Y}, pt2:  new IntPoint() {X = val_25.X, Y = val_25.Y});
        val_88 = val_26.Y;
        val_95 = val_26.X;
        val_96 = val_88;
        this.m_normals.Add(item:  new DoublePoint() {X = val_95, Y = val_96});
        val_97 = val_90;
        val_89 = 1152921519892539584;
        goto label_60;
        label_37:
        val_83 = 3;
        goto label_61;
        label_69:
        val_98 = this.m_destPoly;
        val_83 = 2;
        label_61:
        val_88 = -1;
        IntPoint val_27 = this.m_srcPoly.Item[0];
        double val_91 = (double)val_27.X;
        val_91 = ((-1) * delta) + val_91;
        val_91 = val_91 + ((val_91 >= 0) ? 0.5 : -0.5);
        IntPoint val_30 = this.m_srcPoly.Item[0];
        double val_92 = (double)val_30.Y;
        val_92 = (val_88 * delta) + val_92;
        val_92 = val_92 + ((val_92 >= 0) ? 0.5 : -0.5);
        val_98.Add(item:  new IntPoint() {X = (long)val_91, Y = (long)val_92});
        if((-1) >= 0)
        {
            goto label_65;
        }
        
        if(val_83 != 0)
        {
            goto label_69;
        }
        
        goto label_134;
        label_65:
        if(val_83 != 0)
        {
            goto label_69;
        }
        
        goto label_134;
        label_56:
        DoublePoint val_34 = this.m_normals.Item[val_10 - 2];
        val_97 = val_90;
        val_89 = 1152921519892539584;
        val_83 = val_83;
        val_88 = val_34.X;
        val_95 = val_88;
        val_96 = val_34.Y;
        this.m_normals.Add(item:  new DoublePoint() {X = val_95, Y = val_96});
        val_94 = val_12;
        label_60:
        val_99 = mem[val_9 + 40];
        val_99 = val_9 + 40;
        if(val_99 == 1)
        {
            goto label_73;
        }
        
        if(val_99 != 0)
        {
            goto label_74;
        }
        
        if(val_10 < 1)
        {
            goto label_134;
        }
        
        var val_93 = 0;
        do
        {
            this.OffsetPoint(j:  0, k: ref  val_94, jointype:  val_9 + 36);
            val_93 = val_93 + 1;
        }
        while(val_10 != val_93);
        
        goto label_134;
        label_73:
        if(val_10 >= 1)
        {
                var val_94 = 0;
            do
        {
            this.OffsetPoint(j:  0, k: ref  val_94, jointype:  val_9 + 36);
            val_94 = val_94 + 1;
        }
        while(val_10 != val_94);
        
        }
        
        this.m_destPolys.Add(item:  this.m_destPoly);
        this.m_destPoly = new System.Collections.Generic.List<IntPoint>();
        DoublePoint val_38 = this.m_normals.Item[val_12];
        val_83 = this.m_normals;
        if(val_12 >= 1)
        {
                do
        {
            int val_39 = val_12 - 1;
            DoublePoint val_40 = val_83.Item[val_39];
            DoublePoint val_41 = this.m_normals.Item[val_39];
            val_83.set_Item(index:  val_12, value:  new DoublePoint() {X = -val_40.X, Y = -val_41.Y});
            val_83 = this.m_normals;
        }
        while(val_39 > 0);
        
        }
        
        val_88 = -val_38.Y;
        val_83.set_Item(index:  0, value:  new DoublePoint() {X = -val_38.X, Y = val_88});
        val_89 = 1152921519892539584;
        int val_95 = val_12;
        if((val_95 & 2147483648) != 0)
        {
            goto label_134;
        }
        
        do
        {
            this.OffsetPoint(j:  val_95, k: ref  0, jointype:  val_9 + 36);
            val_95 = val_95 - 1;
        }
        while((val_95 & 2147483648) == 0);
        
        goto label_134;
        label_74:
        if(val_94 >= 2)
        {
                var val_96 = 2;
            do
        {
            this.OffsetPoint(j:  val_96 - 1, k: ref  0, jointype:  val_9 + 36);
            val_96 = val_96 + 1;
        }
        while(val_10 != val_96);
        
            val_99 = mem[val_9 + 40];
            val_99 = val_9 + 40;
        }
        
        if(val_99 != 2)
        {
            goto label_94;
        }
        
        IntPoint val_45 = this.m_srcPoly.Item[val_94];
        DoublePoint val_46 = this.m_normals.Item[val_94];
        val_46.X = val_46.X * delta;
        val_46.X = val_46.X + (double)val_45.X;
        IntPoint val_49 = this.m_srcPoly.Item[val_94];
        DoublePoint val_50 = this.m_normals.Item[val_94];
        double val_97 = (double)val_49.Y;
        val_50.Y = val_50.Y * delta;
        val_97 = val_50.Y + val_97;
        val_97 = val_97 + ((val_97 >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_46.X + ((val_46.X >= 0) ? 0.5 : -0.5), Y = (long)val_97});
        IntPoint val_52 = this.m_srcPoly.Item[val_94];
        DoublePoint val_53 = this.m_normals.Item[val_94];
        val_53.X = val_53.X * delta;
        val_53.X = (double)val_52.X - val_53.X;
        IntPoint val_56 = this.m_srcPoly.Item[val_94];
        DoublePoint val_57 = this.m_normals.Item[val_94];
        double val_98 = (double)val_56.Y;
        val_57.Y = val_57.Y * delta;
        val_98 = val_98 - val_57.Y;
        val_103 = val_98 + ((val_98 >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_53.X + ((val_53.X >= 0) ? 0.5 : -0.5), Y = (long)val_103});
        val_104 = val_94;
        goto label_111;
        label_94:
        int val_59 = val_10 - 2;
        this.m_sinA = 0;
        DoublePoint val_60 = this.m_normals.Item[val_94];
        DoublePoint val_61 = this.m_normals.Item[val_94];
        val_103 = -val_60.X;
        val_102 = -val_61.Y;
        this.m_normals.set_Item(index:  val_94, value:  new DoublePoint() {X = val_103, Y = val_102});
        if((val_9 + 40) != 3)
        {
            goto label_109;
        }
        
        this.DoSquare(j:  val_94, k:  val_59);
        val_104 = val_94;
        goto label_111;
        label_109:
        this.DoRound(j:  val_94, k:  val_59);
        val_104 = val_94;
        goto label_111;
        label_115:
        val_104 = val_104 - 1;
        DoublePoint val_62 = val_59.Item[val_104];
        DoublePoint val_63 = this.m_normals.Item[val_104];
        val_103 = -val_62.X;
        val_102 = -val_63.Y;
        val_59.set_Item(index:  val_104 + 1, value:  new DoublePoint() {X = val_103, Y = val_102});
        label_111:
        if(val_104 > 0)
        {
            goto label_115;
        }
        
        DoublePoint val_65 = this.m_normals.Item[1];
        DoublePoint val_66 = this.m_normals.Item[1];
        val_88 = -val_66.Y;
        this.m_normals.set_Item(index:  0, value:  new DoublePoint() {X = -val_65.X, Y = val_88});
        val_89 = 1152921519892539584;
        val_105 = val_10 - 2;
        goto label_118;
        label_120:
        this.OffsetPoint(j:  val_105, k: ref  val_94, jointype:  val_9 + 36);
        val_105 = val_105 - 1;
        label_118:
        if(val_105 > 0)
        {
            goto label_120;
        }
        
        if((val_9 + 40) == 2)
        {
                IntPoint val_68 = this.m_srcPoly.Item[0];
            DoublePoint val_69 = this.m_normals.Item[0];
            val_69.X = val_69.X * delta;
            val_69.X = (double)val_68.X - val_69.X;
            IntPoint val_72 = this.m_srcPoly.Item[0];
            DoublePoint val_73 = this.m_normals.Item[0];
            double val_99 = (double)val_72.Y;
            val_73.Y = val_73.Y * delta;
            val_99 = val_99 - val_73.Y;
            val_99 = val_99 + ((val_99 >= 0) ? 0.5 : -0.5);
            this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_69.X + ((val_69.X >= 0) ? 0.5 : -0.5), Y = (long)val_99});
            IntPoint val_75 = this.m_srcPoly.Item[0];
            DoublePoint val_76 = this.m_normals.Item[0];
            val_76.X = val_76.X * delta;
            val_76.X = val_76.X + (double)val_75.X;
            IntPoint val_79 = this.m_srcPoly.Item[0];
            DoublePoint val_80 = this.m_normals.Item[0];
            double val_100 = (double)val_79.Y;
            val_80.Y = val_80.Y * delta;
            val_100 = val_80.Y + val_100;
            val_83 = this.m_destPoly;
            val_100 = val_100 + ((val_100 >= 0) ? 0.5 : -0.5);
            val_83.Add(item:  new IntPoint() {X = (long)val_76.X + ((val_76.X >= 0) ? 0.5 : -0.5), Y = (long)val_100});
        }
        else
        {
                this.m_sinA = 0;
            if((val_9 + 40) == 3)
        {
                this.DoSquare(j:  0, k:  1);
        }
        else
        {
                this.DoRound(j:  0, k:  1);
        }
        
        }
        
        label_134:
        this.m_destPolys.Add(item:  this.m_destPoly);
        label_46:
        val_90 = val_97 + 1;
        label_29:
        val_85 = this.m_polyNodes;
        if(val_90 < val_85.ChildCount)
        {
            goto label_137;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Execute(ref System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> solution, double delta)
    {
        long val_5;
        var val_6;
        long val_7;
        long val_8;
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_15;
        solution.Clear();
        this.FixOrientations();
        this.DoOffset(delta:  delta);
        InternalClipper.Clipper val_1 = new InternalClipper.Clipper(InitOptions:  0);
        bool val_2 = val_1.AddPaths(ppg:  this.m_destPolys, polyType:  0, closed:  true);
        if(delta > 0f)
        {
                bool val_3 = val_1.Execute(clipType:  1, solution:  solution, subjFillType:  2, clipFillType:  2);
            return;
        }
        
        InternalClipper.IntRect val_4 = InternalClipper.ClipperBase.GetBounds(paths:  this.m_destPolys);
        long val_15 = val_5;
        long val_17 = val_7;
        long val_16 = val_8;
        System.Collections.Generic.List<IntPoint> val_9 = new System.Collections.Generic.List<IntPoint>(capacity:  4);
        val_15 = val_15 - 10;
        val_16 = val_16 + 10;
        val_9.Add(item:  new IntPoint() {X = val_15, Y = val_16});
        val_17 = val_17 + 10;
        val_9.Add(item:  new IntPoint() {X = val_17, Y = val_16});
        long val_10 = val_6 - 10;
        if(val_9 != null)
        {
                val_9.Add(item:  new IntPoint() {X = val_17, Y = val_10});
        }
        else
        {
                val_9.Add(item:  new IntPoint() {X = val_17, Y = val_10});
        }
        
        val_9.Add(item:  new IntPoint() {X = val_15, Y = val_10});
        if(val_1 != null)
        {
                bool val_11 = val_1.AddPath(pg:  val_9, polyType:  0, Closed:  true);
            val_1.ReverseSolution = true;
            val_15 = solution;
        }
        else
        {
                bool val_12 = val_1.AddPath(pg:  val_9, polyType:  0, Closed:  true);
            val_1.ReverseSolution = true;
            val_15 = solution;
        }
        
        bool val_13 = val_1.Execute(clipType:  1, solution:  val_15, subjFillType:  3, clipFillType:  3);
        if(solution.Count < 1)
        {
                return;
        }
        
        solution.RemoveAt(index:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Execute(ref Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree solution, double delta)
    {
        long val_5;
        var val_6;
        var val_7;
        long val_8;
        long val_24;
        InternalClipper.PolyTree val_25;
        var val_26;
        solution.Clear();
        this.FixOrientations();
        this.DoOffset(delta:  delta);
        InternalClipper.Clipper val_1 = new InternalClipper.Clipper(InitOptions:  0);
        bool val_2 = val_1.AddPaths(ppg:  this.m_destPolys, polyType:  0, closed:  true);
        if(delta > 0f)
        {
                bool val_3 = val_1.Execute(clipType:  1, polytree:  solution, subjFillType:  2, clipFillType:  2);
            return;
        }
        
        InternalClipper.IntRect val_4 = InternalClipper.ClipperBase.GetBounds(paths:  this.m_destPolys);
        long val_24 = val_5;
        long val_25 = val_8;
        System.Collections.Generic.List<IntPoint> val_9 = new System.Collections.Generic.List<IntPoint>(capacity:  4);
        val_24 = val_24 - 10;
        val_25 = val_25 + 10;
        val_9.Add(item:  new IntPoint() {X = val_24, Y = val_25});
        val_24 = val_7 + 10;
        val_9.Add(item:  new IntPoint() {X = val_24, Y = val_25});
        long val_10 = val_6 - 10;
        if(val_9 != null)
        {
                val_9.Add(item:  new IntPoint() {X = val_24, Y = val_10});
        }
        else
        {
                val_9.Add(item:  new IntPoint() {X = val_24, Y = val_10});
        }
        
        val_9.Add(item:  new IntPoint() {X = val_24, Y = val_10});
        if(val_1 != null)
        {
                bool val_11 = val_1.AddPath(pg:  val_9, polyType:  0, Closed:  true);
            val_1.ReverseSolution = true;
            val_25 = solution;
        }
        else
        {
                bool val_12 = val_1.AddPath(pg:  val_9, polyType:  0, Closed:  true);
            val_1.ReverseSolution = true;
            val_25 = solution;
        }
        
        bool val_13 = val_1.Execute(clipType:  1, polytree:  val_25, subjFillType:  3, clipFillType:  3);
        if(solution.ChildCount == 1)
        {
                if((mem[solution + 48].Item[0].ChildCount) >= 1)
        {
                PolyNode val_17 = mem[solution + 48].Item[0];
            mem[solution + 48].Capacity = val_17.ChildCount;
            mem[solution + 48].set_Item(index:  0, value:  val_17.m_Childs.Item[0]);
            val_26 = mem[solution + 48].Item[0];
            val_20.m_Parent = solution;
            if(val_17.ChildCount < 2)
        {
                return;
        }
        
            do
        {
            val_24 = val_17.m_Childs.Item[1];
            solution.AddChild(Child:  val_24);
            val_26 = 1 + 1;
        }
        while(val_26 < val_17.ChildCount);
        
            return;
        }
        
        }
        
        solution.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OffsetPoint(int j, ref int k, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.JoinType jointype)
    {
        long val_38;
        System.Collections.Generic.List<DoublePoint> val_39;
        double val_40;
        double val_41;
        double val_42;
        var val_43;
        int val_44;
        val_38 = this;
        DoublePoint val_1 = this.m_normals.Item[k];
        DoublePoint val_2 = this.m_normals.Item[j];
        DoublePoint val_3 = this.m_normals.Item[j];
        val_39 = this.m_normals;
        DoublePoint val_4 = val_39.Item[k];
        double val_5 = val_1.X * val_2.Y;
        val_4.Y = val_3.X * val_4.Y;
        val_40 = val_5 - val_4.Y;
        this.m_sinA = val_40;
        val_5 = this.m_delta * val_40;
        val_41 = 1;
        if(System.Math.Abs(val_5) >= 0)
        {
            goto label_7;
        }
        
        DoublePoint val_6 = this.m_normals.Item[k];
        val_40 = val_6.X;
        DoublePoint val_7 = this.m_normals.Item[j];
        DoublePoint val_8 = this.m_normals.Item[j];
        val_39 = this.m_normals;
        DoublePoint val_9 = val_39.Item[k];
        double val_10 = val_40 * val_7.X;
        val_9.Y = val_8.Y * val_9.Y;
        val_10 = val_10 + val_9.Y;
        if(val_10 <= 0f)
        {
            goto label_12;
        }
        
        IntPoint val_11 = this.m_srcPoly.Item[j];
        DoublePoint val_12 = this.m_normals.Item[k];
        val_12.X = val_12.X * this.m_delta;
        val_12.X = val_12.X + (double)val_11.X;
        IntPoint val_15 = this.m_srcPoly.Item[j];
        DoublePoint val_16 = this.m_normals.Item[k];
        double val_39 = this.m_delta;
        val_39 = val_16.Y * val_39;
        val_39 = val_39 + (double)val_15.Y;
        val_39 = val_39 + ((val_39 >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_12.X + ((val_12.X >= 0) ? 0.5 : -0.5), Y = (long)val_39});
        return;
        label_7:
        val_42 = this.m_sinA;
        if(val_42 <= val_41)
        {
            goto label_18;
        }
        
        val_43 = 4607182418800017408;
        goto label_19;
        label_12:
        val_42 = this.m_sinA;
        goto label_21;
        label_18:
        val_41 = -1;
        if(val_42 >= 0)
        {
            goto label_21;
        }
        
        val_43 = -4616189618054758400;
        label_19:
        val_42 = val_41;
        this.m_sinA = -1;
        label_21:
        val_42 = val_42 * this.m_delta;
        if(val_42 >= 0)
        {
            goto label_22;
        }
        
        IntPoint val_18 = this.m_srcPoly.Item[j];
        DoublePoint val_19 = this.m_normals.Item[k];
        val_40 = -0.5;
        val_19.X = val_19.X * this.m_delta;
        val_19.X = val_19.X + (double)val_18.X;
        IntPoint val_22 = this.m_srcPoly.Item[j];
        DoublePoint val_23 = this.m_normals.Item[k];
        double val_40 = this.m_delta;
        val_40 = val_23.Y * val_40;
        val_40 = val_40 + (double)val_22.Y;
        val_40 = val_40 + ((val_40 >= 0) ? 0.5 : (val_40));
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_19.X + ((val_19.X >= 0) ? 0.5 : (val_40)), Y = (long)val_40});
        IntPoint val_25 = this.m_srcPoly.Item[j];
        this.m_destPoly.Add(item:  new IntPoint() {X = val_25.X, Y = val_25.Y});
        IntPoint val_26 = this.m_srcPoly.Item[j];
        DoublePoint val_27 = this.m_normals.Item[j];
        val_27.X = val_27.X * this.m_delta;
        val_27.X = val_27.X + (double)val_26.X;
        val_39 = (long)val_27.X + ((val_27.X >= 0) ? 0.5 : (val_40));
        IntPoint val_30 = this.m_srcPoly.Item[j];
        DoublePoint val_31 = this.m_normals.Item[j];
        double val_41 = this.m_delta;
        val_41 = val_31.Y * val_41;
        val_41 = val_41 + (double)val_30.Y;
        val_41 = val_41 + ((val_41 >= 0) ? 0.5 : (val_40));
        val_38 = (long)val_41;
        this.m_destPoly.Add(item:  new IntPoint() {X = val_39, Y = val_38});
        goto label_45;
        label_22:
        if(jointype == 0)
        {
            goto label_36;
        }
        
        if(jointype == 1)
        {
            goto label_37;
        }
        
        if(jointype != 2)
        {
            goto label_45;
        }
        
        DoublePoint val_33 = this.m_normals.Item[j];
        val_40 = val_33.X;
        DoublePoint val_34 = this.m_normals.Item[k];
        DoublePoint val_35 = this.m_normals.Item[j];
        val_39 = k;
        DoublePoint val_36 = this.m_normals.Item[val_39];
        double val_37 = val_40 * val_34.X;
        val_36.Y = val_35.Y * val_36.Y;
        val_44 = k;
        val_37 = val_37 + val_36.Y;
        val_37 = val_37 + 1;
        if(val_37 < this.m_miterLim)
        {
            goto label_43;
        }
        
        this.DoMiter(j:  j, k:  val_44, r:  val_37);
        goto label_45;
        label_36:
        val_44 = k;
        label_43:
        this.DoSquare(j:  j, k:  val_44);
        goto label_45;
        label_37:
        this.DoRound(j:  j, k:  k);
        label_45:
        k = j;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void DoSquare(int j, int k)
    {
        DoublePoint val_1 = this.m_normals.Item[k];
        DoublePoint val_2 = this.m_normals.Item[j];
        DoublePoint val_3 = this.m_normals.Item[k];
        DoublePoint val_4 = this.m_normals.Item[j];
        val_4.Y = val_3.Y * val_4.Y;
        val_4.Y = (val_1.X * val_2.X) + val_4.Y;
        double val_22 = this.m_sinA;
        val_22 = val_22 * 0.25;
        IntPoint val_6 = this.m_srcPoly.Item[j];
        DoublePoint val_7 = this.m_normals.Item[k];
        double val_23 = val_7.X;
        DoublePoint val_8 = this.m_normals.Item[k];
        val_8.Y = val_22 * val_8.Y;
        val_8.Y = val_23 - val_8.Y;
        val_8.Y = this.m_delta * val_8.Y;
        val_23 = val_8.Y + (double)val_6.X;
        val_23 = val_23 + ((val_23 >= 0) ? 0.5 : -0.5);
        IntPoint val_10 = this.m_srcPoly.Item[j];
        DoublePoint val_11 = this.m_normals.Item[k];
        DoublePoint val_12 = this.m_normals.Item[k];
        val_12.X = val_22 * val_12.X;
        val_12.X = val_11.Y + val_12.X;
        val_12.X = this.m_delta * val_12.X;
        val_12.X = val_12.X + (double)val_10.Y;
        val_12.X = val_12.X + ((val_12.X >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_23, Y = (long)val_12.X});
        IntPoint val_14 = this.m_srcPoly.Item[j];
        DoublePoint val_15 = this.m_normals.Item[j];
        double val_24 = val_15.X;
        DoublePoint val_16 = this.m_normals.Item[j];
        val_16.Y = val_22 * val_16.Y;
        val_16.Y = val_24 + val_16.Y;
        val_16.Y = this.m_delta * val_16.Y;
        val_24 = val_16.Y + (double)val_14.X;
        val_24 = val_24 + ((val_24 >= 0) ? 0.5 : -0.5);
        IntPoint val_18 = this.m_srcPoly.Item[j];
        DoublePoint val_19 = this.m_normals.Item[j];
        DoublePoint val_20 = this.m_normals.Item[j];
        val_20.X = val_22 * val_20.X;
        val_20.X = val_19.Y - val_20.X;
        val_20.X = this.m_delta * val_20.X;
        val_20.X = val_20.X + (double)val_18.Y;
        val_20.X = val_20.X + ((val_20.X >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_24, Y = (long)val_20.X});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void DoMiter(int j, int k, double r)
    {
        double val_9 = this.m_delta;
        IntPoint val_1 = this.m_srcPoly.Item[j];
        val_9 = val_9 / r;
        DoublePoint val_2 = this.m_normals.Item[k];
        double val_10 = val_2.X;
        DoublePoint val_3 = this.m_normals.Item[j];
        val_3.X = val_10 + val_3.X;
        val_3.X = val_9 * val_3.X;
        val_10 = val_3.X + (double)val_1.X;
        val_10 = val_10 + ((val_10 >= 0) ? 0.5 : -0.5);
        IntPoint val_5 = this.m_srcPoly.Item[j];
        DoublePoint val_6 = this.m_normals.Item[k];
        DoublePoint val_7 = this.m_normals.Item[j];
        val_7.Y = val_6.Y + val_7.Y;
        double val_11 = (double)val_5.Y;
        val_7.Y = val_9 * val_7.Y;
        val_11 = val_7.Y + val_11;
        val_11 = val_11 + ((val_11 >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_10, Y = (long)val_11});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void DoRound(int j, int k)
    {
        float val_22;
        var val_23;
        DoublePoint val_1 = this.m_normals.Item[k];
        DoublePoint val_2 = this.m_normals.Item[j];
        DoublePoint val_3 = this.m_normals.Item[k];
        DoublePoint val_4 = this.m_normals.Item[j];
        val_4.Y = val_3.Y * val_4.Y;
        val_4.Y = (val_1.X * val_2.X) + val_4.Y;
        double val_22 = System.Math.Abs(this.m_sinA);
        val_22 = this.m_StepsPerRad * val_22;
        val_22 = val_22 + ((val_22 >= 0) ? 0.5 : -0.5);
        DoublePoint val_8 = this.m_normals.Item[k];
        double val_26 = val_8.X;
        DoublePoint val_9 = this.m_normals.Item[k];
        double val_27 = val_9.Y;
        val_23 = 0;
        goto label_9;
        label_13:
        double val_23 = this.m_delta;
        val_23 = val_26 * val_23;
        val_23 = val_23 + (double)this.m_normals;
        val_23 = val_23 + ((val_23 >= 0) ? 0.5 : -0.5);
        IntPoint val_11 = this.m_srcPoly.Item[j];
        double val_24 = this.m_delta;
        val_24 = val_27 * val_24;
        val_24 = val_24 + (double)val_11.Y;
        val_24 = val_24 + ((val_24 >= 0) ? 0.5 : -0.5);
        k.Add(item:  new IntPoint() {X = (long)val_23, Y = (long)val_24});
        double val_25 = this.m_sin;
        val_23 = 1;
        val_25 = val_26 * val_25;
        val_22 = val_27 * this.m_cos;
        val_26 = (val_26 * this.m_cos) - (val_27 * val_25);
        val_27 = val_22 + val_25;
        label_9:
        IntPoint val_15 = this.m_srcPoly.Item[j];
        if(val_23 < (System.Math.Max(val1:  (long)val_22, val2:  1)))
        {
            goto label_13;
        }
        
        DoublePoint val_16 = this.m_normals.Item[j];
        val_16.X = val_16.X * this.m_delta;
        val_16.X = val_16.X + (double)val_15.X;
        IntPoint val_19 = this.m_srcPoly.Item[j];
        DoublePoint val_20 = this.m_normals.Item[j];
        double val_28 = this.m_delta;
        val_28 = val_20.Y * val_28;
        val_28 = val_28 + (double)val_19.Y;
        val_28 = val_28 + ((val_28 >= 0) ? 0.5 : -0.5);
        this.m_destPoly.Add(item:  new IntPoint() {X = (long)val_16.X + ((val_16.X >= 0) ? 0.5 : -0.5), Y = (long)val_28});
    }

}
