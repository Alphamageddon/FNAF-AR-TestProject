using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class InternalClipper.ClipperBase
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal const double horizontal = -3.4E+38;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal const int Skip = -2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal const int Unassigned = -1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal const double tolerance = 1E-20;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const long loRange = 1073741823;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const long hiRange = 4611686018427387903;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.LocalMinima m_MinimaList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.LocalMinima m_CurrentLM;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge>> m_edges;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Scanbeam m_Scanbeam;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec> m_PolyOuts;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge m_ActiveEdges;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool m_UseFullRange;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool m_HasOpenPaths;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <PreserveCollinear>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool PreserveCollinear { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool near_zero(double val)
    {
        return (bool)((val > (-1E-20)) ? 1 : 0) & ((val < 0) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_PreserveCollinear()
    {
        return (bool)this.<PreserveCollinear>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_PreserveCollinear(bool value)
    {
        this.<PreserveCollinear>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Swap(ref long val1, ref long val2)
    {
        val1 = val2;
        val2 = val1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool IsHorizontal(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        return (bool)(X8 == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool PointIsVertex(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt pp)
    {
        var val_1;
        do
        {
            if(pp.Pt == pt.X)
        {
                if(pp.Pt == pt.Y)
        {
            goto label_2;
        }
        
        }
        
        }
        while(pp.Next != pp);
        
        val_1 = 0;
        return (bool)val_1;
        label_2:
        val_1 = 1;
        return (bool)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool PointOnLineSegment(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint linePt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint linePt2, bool UseFullRange)
    {
        var val_22;
        var val_1 = (pt.X == linePt1.X) ? 1 : 0;
        val_1 = val_1 & ((pt.Y == linePt1.Y) ? 1 : 0);
        if(UseFullRange == false)
        {
            goto label_0;
        }
        
        if((val_1 & 1) != 0)
        {
            goto label_6;
        }
        
        if(pt.X == linePt2.X)
        {
                if(pt.Y == linePt2.Y)
        {
            goto label_6;
        }
        
        }
        
        var val_4 = (pt.Y > linePt2.Y) ? 1 : 0;
        val_4 = val_4 ^ ((pt.X < linePt2.X) ? 1 : 0);
        if((val_4 & 1) != 0)
        {
            goto label_10;
        }
        
        var val_7 = (pt.X > linePt2.X) ? 1 : 0;
        val_7 = val_7 ^ ((pt.Y < linePt2.Y) ? 1 : 0);
        if((val_7 & 1) != 0)
        {
            goto label_10;
        }
        
        InternalClipper.Int128 val_10 = InternalClipper.Int128.Int128Mul(lhs:  pt.X - linePt1.X, rhs:  linePt2.Y - linePt1.Y);
        InternalClipper.Int128 val_12 = InternalClipper.Int128.Int128Mul(lhs:  linePt2.X - linePt1.X, rhs:  pt.Y - linePt1.Y);
        return InternalClipper.Int128.op_Equality(val1:  new InternalClipper.Int128() {hi = val_10.hi, lo = val_10.lo}, val2:  new InternalClipper.Int128() {hi = val_12.hi, lo = val_12.lo});
        label_0:
        if((val_1 & 1) == 0)
        {
                if((pt.X != linePt2.X) || (pt.Y != linePt2.Y))
        {
            goto label_8;
        }
        
        }
        
        label_6:
        val_22 = 1;
        return (bool)val_22;
        label_8:
        long val_13 = pt.X - linePt1.X;
        var val_14 = (pt.X > linePt2.X) ? 1 : 0;
        val_14 = val_14 ^ ((pt.X < linePt2.X) ? 1 : 0);
        if((val_14 & 1) != 0)
        {
            goto label_10;
        }
        
        long val_16 = pt.Y - linePt1.Y;
        var val_17 = (pt.X > linePt2.X) ? 1 : 0;
        val_17 = val_17 ^ ((pt.Y < linePt2.Y) ? 1 : 0);
        if((val_17 & 1) == 0)
        {
            goto label_11;
        }
        
        label_10:
        val_22 = 0;
        return (bool)val_22;
        label_11:
        val_13 = (linePt2.Y - linePt1.Y) * val_13;
        val_16 = (linePt2.X - linePt1.X) * val_16;
        var val_21 = (val_13 == val_16) ? 1 : 0;
        return (bool)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool PointOnPolygon(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt pp, bool UseFullRange)
    {
        OutPt val_3;
        InternalClipper.IntPoint val_4;
        var val_5;
        var val_6;
        var val_7;
        val_3 = pp;
        label_4:
        if(val_3 != null)
        {
                val_4 = pp.Pt;
        }
        else
        {
                val_4 = 15026800;
            val_5 = 64;
            val_6 = 0;
        }
        
        if(pp.Next == null)
        {
                val_6 = 0;
        }
        
        if((this.PointOnLineSegment(pt:  new IntPoint() {X = pt.X, Y = pt.Y}, linePt1:  new IntPoint() {X = 15026800, Y = 64}, linePt2:  new IntPoint() {X = pp.Next.Pt}, UseFullRange:  UseFullRange)) == true)
        {
            goto label_3;
        }
        
        val_3 = pp.Next;
        if(val_3 != pp)
        {
            goto label_4;
        }
        
        val_7 = 0;
        return (bool)val_7;
        label_3:
        val_7 = 1;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool SlopesEqual(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e2, bool UseFullRange)
    {
        if(UseFullRange != false)
        {
                InternalClipper.Int128 val_1 = InternalClipper.Int128.Int128Mul(lhs:  X22, rhs:  e2.Delta);
            InternalClipper.Int128 val_2 = InternalClipper.Int128.Int128Mul(lhs:  e1.Delta, rhs:  X8);
            return InternalClipper.Int128.op_Equality(val1:  new InternalClipper.Int128() {hi = val_1.hi, lo = val_1.lo}, val2:  new InternalClipper.Int128() {hi = val_2.hi, lo = val_2.lo});
        }
        
        InternalClipper.IntPoint val_5 = e1.Delta;
        val_5 = X9 * val_5;
        return (bool)((e2.Delta * X22) == val_5) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool SlopesEqual(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt3, bool UseFullRange)
    {
        long val_1 = pt1.Y - pt2.Y;
        long val_2 = pt2.X - pt3.X;
        if(UseFullRange != false)
        {
                InternalClipper.Int128 val_3 = InternalClipper.Int128.Int128Mul(lhs:  val_1, rhs:  val_2);
            InternalClipper.Int128 val_6 = InternalClipper.Int128.Int128Mul(lhs:  pt1.X - pt2.X, rhs:  pt2.Y - pt3.Y);
            return InternalClipper.Int128.op_Equality(val1:  new InternalClipper.Int128() {hi = val_3.hi, lo = val_3.lo}, val2:  new InternalClipper.Int128() {hi = val_6.hi, lo = val_6.lo});
        }
        
        long val_7 = pt1.X - pt2.X;
        val_7 = (pt2.Y - pt3.Y) * val_7;
        return (bool)((val_2 * val_1) == val_7) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static bool SlopesEqual(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt3, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt4, bool UseFullRange)
    {
        long val_1 = pt1.Y - pt2.Y;
        long val_2 = pt3.X - pt4.X;
        if(UseFullRange != false)
        {
                InternalClipper.Int128 val_3 = InternalClipper.Int128.Int128Mul(lhs:  val_1, rhs:  val_2);
            InternalClipper.Int128 val_6 = InternalClipper.Int128.Int128Mul(lhs:  pt1.X - pt2.X, rhs:  pt3.Y - pt4.Y);
            return InternalClipper.Int128.op_Equality(val1:  new InternalClipper.Int128() {hi = val_3.hi, lo = val_3.lo}, val2:  new InternalClipper.Int128() {hi = val_6.hi, lo = val_6.lo});
        }
        
        long val_7 = pt1.X - pt2.X;
        val_7 = (pt3.Y - pt4.Y) * val_7;
        return (bool)((val_2 * val_1) == val_7) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal InternalClipper.ClipperBase()
    {
        this.m_edges = new System.Collections.Generic.List<System.Collections.Generic.List<TEdge>>();
        this.m_UseFullRange = false;
        this.m_HasOpenPaths = false;
        this.m_MinimaList = 0;
        this.m_CurrentLM = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public virtual void Clear()
    {
        var val_5;
        var val_6;
        if(this.m_MinimaList != null)
        {
                do
        {
            this.m_MinimaList = this.m_MinimaList.Next;
        }
        while(this.m_MinimaList.Next != null);
        
        }
        
        this.m_CurrentLM = 0;
        val_5 = 0;
        goto label_4;
        label_11:
        val_6 = 0;
        goto label_6;
        label_9:
        X24.set_Item(index:  0, value:  0);
        val_6 = 1;
        label_6:
        if(val_6 < X22.Item[0].Count)
        {
            goto label_9;
        }
        
        this.m_edges.Item[0].Clear();
        val_5 = 1;
        label_4:
        if(val_5 < this.m_edges.Count)
        {
            goto label_11;
        }
        
        this.m_edges.Clear();
        this.m_UseFullRange = false;
        this.m_HasOpenPaths = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DisposeLocalMinimaList()
    {
        if(this.m_MinimaList != null)
        {
                do
        {
            this.m_MinimaList = this.m_MinimaList.Next;
        }
        while(this.m_MinimaList.Next != null);
        
        }
        
        this.m_CurrentLM = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RangeTest(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint Pt, ref bool useFullRange)
    {
        if(useFullRange != true)
        {
                var val_5 = ((Pt.X > 1073741823) ? 1 : 0) | ((Pt.Y > 1073741823) ? 1 : 0);
            val_5 = (((-Pt.X) > 1073741823) ? 1 : 0) | val_5;
            val_5 = (((-Pt.Y) > 1073741823) ? 1 : 0) | val_5;
            if(val_5 == 0)
        {
                return;
        }
        
            useFullRange = true;
        }
        
        if(((((-Pt.Y) <= 4611686018427387903) && ((-Pt.X) <= 4611686018427387903)) && (Pt.X <= 4611686018427387903)) && (Pt.Y < 4611686018427387904))
        {
                return;
        }
        
        InternalClipper.ClipperException val_6 = new InternalClipper.ClipperException(description:  "Coordinate outside allowed range");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitEdge(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge eNext, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge ePrev, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt)
    {
        if(e != null)
        {
                e.Next = eNext;
            e.Prev = ePrev;
            e.Curr = pt.X;
            mem2[0] = pt.Y;
        }
        else
        {
                mem[112] = eNext;
            mem[120] = ePrev;
            mem[32] = pt.X;
            mem[40] = pt.Y;
        }
        
        e.OutIdx = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitEdge2(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyType polyType)
    {
        var val_1;
        InternalClipper.TEdge val_2;
        if(e != null)
        {
            
        }
        else
        {
                val_1 = 69077560;
        }
        
        if(val_1 < X10)
        {
                val_2 = e.Next;
            e.Top = e.Curr;
            mem2[0] = ???;
            e.Bot = e.Next.Curr;
            mem2[0] = ???;
        }
        else
        {
                val_2 = e.Next;
            e.Bot = e.Curr;
            mem2[0] = ???;
            e.Top = e.Next.Curr;
            mem2[0] = ???;
        }
        
        this.SetDx(e:  e);
        e.PolyTyp = polyType;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge FindNextLocMin(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge E)
    {
        InternalClipper.TEdge val_2;
        InternalClipper.IntPoint val_3;
        var val_4;
        InternalClipper.TEdge val_5;
        var val_6;
        val_2 = E;
        label_23:
        if(val_2 == null)
        {
            goto label_8;
        }
        
        label_7:
        val_3 = E.Bot;
        goto label_1;
        label_8:
        val_3 = 11993091;
        val_4 = 15026800;
        label_1:
        if((val_3 == E.Prev.Bot) && (val_4 == 52944896))
        {
                if((E.Curr != E.Top) || (E.Curr != E.Top))
        {
            goto label_6;
        }
        
        }
        
        if(E.Next != null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_6:
        if(E.Dx != (-3.4E+38))
        {
                if(E.Prev.Dx != (-3.4E+38))
        {
            goto label_11;
        }
        
        }
        
        val_5 = val_2;
        goto label_12;
        label_15:
        val_5 = E.Prev;
        label_12:
        if(E.Prev.Prev.Dx == (-3.4E+38))
        {
            goto label_15;
        }
        
        val_2 = val_5;
        goto label_16;
        label_20:
        val_2 = E.Prev.Next;
        label_16:
        if(val_2 == null)
        {
            goto label_17;
        }
        
        if(E.Prev.Next.Dx == (-3.4E+38))
        {
            goto label_20;
        }
        
        goto label_19;
        label_17:
        if(0 == (-3.4E+38))
        {
            goto label_20;
        }
        
        val_3 = 4194311;
        val_2 = 0;
        goto label_21;
        label_19:
        label_21:
        if(val_3 == E.Curr)
        {
            goto label_23;
        }
        
        var val_1 = (E.Prev.Prev.Bot < E.Prev.Next.Bot) ? (val_5) : (val_2);
        return (TEdge)val_6;
        label_11:
        val_6 = val_2;
        return (TEdge)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge ProcessBound(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge E, bool LeftBoundIsForward)
    {
        TEdge val_4;
        TEdge val_5;
        InternalClipper.TEdge val_6;
        InternalClipper.TEdge val_7;
        var val_8;
        double val_9;
        double val_10;
        var val_11;
        InternalClipper.TEdge val_12;
        var val_13;
        InternalClipper.TEdge val_14;
        var val_15;
        InternalClipper.TEdge val_16;
        InternalClipper.TEdge val_17;
        var val_18;
        InternalClipper.TEdge val_19;
        val_4 = E;
        val_5 = this;
        if(E.OutIdx != 2)
        {
            goto label_2;
        }
        
        if(LeftBoundIsForward == false)
        {
            goto label_3;
        }
        
        val_6 = 56;
        val_7 = val_4;
        goto label_4;
        label_8:
        val_7 = E.Next;
        label_4:
        if(val_7 != null)
        {
            
        }
        else
        {
                val_8 = 4194311;
        }
        
        if(4194311 == E.OutIdx)
        {
            goto label_8;
        }
        
        if(val_7 == val_4)
        {
            goto label_27;
        }
        
        val_9 = -3.4E+38;
        label_12:
        if(E.Next.Dx != val_9)
        {
            goto label_24;
        }
        
        if(E.Next.Prev != val_4)
        {
            goto label_12;
        }
        
        goto label_27;
        label_2:
        val_9 = -3.4E+38;
        if(E.Dx != val_9)
        {
            goto label_39;
        }
        
        if(((LeftBoundIsForward != true) ? E.Prev : E.Next) == 0)
        {
            goto label_15;
        }
        
        val_10 = mem[LeftBoundIsForward != true ? E.Prev : E.Next + 80];
        val_10 = LeftBoundIsForward != true ? E.Prev : E.Next + 80;
        goto label_16;
        label_3:
        val_6 = 56;
        val_7 = val_4;
        goto label_17;
        label_21:
        val_7 = E.Prev;
        label_17:
        if(val_7 != null)
        {
            
        }
        else
        {
                val_11 = 4194311;
        }
        
        if(4194311 == E.OutIdx)
        {
            goto label_21;
        }
        
        if(val_7 == val_4)
        {
            goto label_27;
        }
        
        val_9 = -3.4E+38;
        label_25:
        if(E.Prev.Dx != val_9)
        {
            goto label_24;
        }
        
        if(E.Prev.Next != val_4)
        {
            goto label_25;
        }
        
        goto label_27;
        label_24:
        if(val_7 == val_4)
        {
            goto label_27;
        }
        
        InternalClipper.TEdge val_2 = (LeftBoundIsForward != true) ? E.Next : E.Prev;
        .Next = 0;
        if(val_2 == 0)
        {
            goto label_30;
        }
        
        .RightBound = val_2;
        .Y = LeftBoundIsForward != true ? E.Next : E.Prev + 24;
        .LeftBound = 0;
        goto label_31;
        label_27:
        if(val_4 == null)
        {
            goto label_32;
        }
        
        if(LeftBoundIsForward == false)
        {
            goto label_33;
        }
        
        label_35:
        val_12 = E.Next;
        return (TEdge)mem[E.Prev.Next.Prev];
        label_32:
        if(LeftBoundIsForward == true)
        {
            goto label_35;
        }
        
        label_33:
        val_12 = E.Prev;
        return (TEdge)mem[E.Prev.Next.Prev];
        label_15:
        val_10 = 0;
        label_16:
        val_13 = mem[LeftBoundIsForward != true ? E.Prev : E.Next + 16];
        val_13 = LeftBoundIsForward != true ? E.Prev : E.Next + 16;
        if(val_10 != val_9)
        {
            goto label_37;
        }
        
        if(val_13 == E.Bot)
        {
            goto label_39;
        }
        
        val_13 = mem[LeftBoundIsForward != true ? E.Prev : E.Next + 48];
        val_13 = LeftBoundIsForward != true ? E.Prev : E.Next + 48;
        label_37:
        if(val_13 != E.Bot)
        {
                this.ReverseHorizontal(e:  val_4);
        }
        
        label_39:
        if(LeftBoundIsForward == false)
        {
            goto label_40;
        }
        
        val_14 = val_4;
        goto label_41;
        label_47:
        if(E.Next.OutIdx == 2)
        {
            goto label_43;
        }
        
        val_14 = E.Next;
        label_41:
        if(val_14 != null)
        {
            
        }
        else
        {
                val_15 = 4194311;
        }
        
        val_6 = E.Next.Next;
        if(4194311 == E.Next.OutIdx)
        {
            goto label_47;
        }
        
        label_43:
        if((E.Next.Dx == val_9) && (E.Next.Next.OutIdx != 2))
        {
                do
        {
            val_16 = E.Next.Prev;
            if(E.Next.Prev == null)
        {
                val_16 = E.Next.Prev;
        }
        
        }
        while(E.Next.Prev.Dx == val_9);
        
            val_6 = E.Next.Next;
            if(E.Next.Prev.Top > E.Next.Next.Top)
        {
                val_14 = E.Next.Prev;
        }
        
        }
        
        val_5 = val_4;
        goto label_58;
        label_66:
        val_6 = E.Next;
        if(val_5 != null)
        {
                E.NextInLML = val_6;
        }
        else
        {
                mem[128] = val_6;
        }
        
        if((val_5 != val_4) && (E.Dx == val_9))
        {
                val_6 = E.Bot;
            if(val_6 != E.Prev.Top)
        {
                this.ReverseHorizontal(e:  val_5);
        }
        
        }
        
        val_5 = E.Next;
        label_58:
        if(val_5 != val_14)
        {
            goto label_66;
        }
        
        if((val_14 != val_4) && (E.Next.Prev.Dx == val_9))
        {
                val_5 = E.Next.Prev.Prev;
            val_4 = E.Next.Prev.Bot;
            if(val_4 != E.Next.Prev.Prev.Top)
        {
                this.ReverseHorizontal(e:  val_14);
        }
        
        }
        
        val_12 = E.Next.Prev.Next;
        return (TEdge)mem[E.Prev.Next.Prev];
        label_40:
        val_17 = val_4;
        goto label_72;
        label_78:
        if(E.Prev.OutIdx == 2)
        {
            goto label_74;
        }
        
        val_17 = E.Prev;
        label_72:
        if(val_17 != null)
        {
            
        }
        else
        {
                val_18 = 4194311;
        }
        
        val_6 = E.Prev.Prev;
        if(4194311 == E.Prev.OutIdx)
        {
            goto label_78;
        }
        
        label_74:
        if((E.Prev.Dx != val_9) || (E.Prev.Prev.OutIdx == 2))
        {
            goto label_91;
        }
        
        do
        {
            val_19 = E.Prev.Next;
            if(E.Prev.Next == null)
        {
                val_19 = E.Prev.Next;
        }
        
        }
        while(E.Prev.Next.Dx == val_9);
        
        val_6 = E.Prev.Prev;
        if(E.Prev.Next.Top == E.Prev.Prev.Top)
        {
            goto label_88;
        }
        
        val_6 = E.Prev.Prev;
        if(E.Prev.Next.Top <= E.Prev.Prev.Top)
        {
            goto label_91;
        }
        
        label_88:
        val_17 = E.Prev.Next;
        label_91:
        val_5 = val_4;
        goto label_92;
        label_100:
        val_6 = E.Prev;
        if(val_5 != null)
        {
                E.NextInLML = val_6;
        }
        else
        {
                mem[128] = val_6;
        }
        
        if((val_5 != val_4) && (E.Dx == val_9))
        {
                val_6 = E.Bot;
            if(val_6 != E.Next.Top)
        {
                this.ReverseHorizontal(e:  val_5);
        }
        
        }
        
        val_5 = E.Prev;
        label_92:
        if(val_5 != val_17)
        {
            goto label_100;
        }
        
        if((val_17 != val_4) && (E.Prev.Next.Dx == val_9))
        {
                val_5 = E.Prev.Next.Next;
            val_4 = E.Prev.Next.Bot;
            if(val_4 != E.Prev.Next.Next.Top)
        {
                this.ReverseHorizontal(e:  val_17);
        }
        
        }
        
        val_12 = E.Prev.Next.Prev;
        return (TEdge)mem[E.Prev.Next.Prev];
        label_30:
        .LeftBound = 0;
        .RightBound = 0;
        .Y = 15026800;
        label_31:
        LeftBoundIsForward = LeftBoundIsForward;
        mem2[0] = 0;
        this.InsertLocalMinima(newLm:  new InternalClipper.LocalMinima());
        return (TEdge)mem[E.Prev.Next.Prev];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AddPath(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> pg, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyType polyType, bool Closed)
    {
        InternalClipper.TEdge val_62;
        int val_63;
        var val_64;
        var val_65;
        InternalClipper.TEdge val_66;
        int val_67;
        var val_68;
        var val_69;
        TEdge val_70;
        TEdge val_71;
        TEdge val_72;
        TEdge val_73;
        long val_74;
        TEdge val_75;
        TEdge val_76;
        bool val_77;
        InternalClipper.PolyType val_78;
        InternalClipper.TEdge val_79;
        TEdge val_80;
        var val_81;
        long val_82;
        InternalClipper.IntPoint val_83;
        var val_84;
        var val_85;
        long val_86;
        var val_87;
        var val_88;
        var val_89;
        TEdge val_90;
        InternalClipper.TEdge val_91;
        double val_92;
        var val_93;
        var val_94;
        InternalClipper.TEdge val_95;
        int val_96;
        TEdge val_97;
        var val_98;
        TEdge val_99;
        var val_100;
        val_62 = pg;
        bool val_1 = Closed ^ 1;
        if(polyType == 1)
        {
                if(val_1 == true)
        {
            goto label_2;
        }
        
        }
        
        val_63 = val_62.Count - 1;
        var val_3 = (val_63 < 1) ? 1 : 0;
        val_3 = val_3 | val_1;
        if(val_3 == true)
        {
            goto label_8;
        }
        
        label_9:
        if(val_62 != null)
        {
                IntPoint val_4 = val_62.Item[val_63];
            val_64 = val_4.X;
            val_65 = val_4.Y;
        }
        else
        {
                IntPoint val_5 = 0.Item[val_63];
            val_64 = val_5.X;
            val_65 = val_5.Y;
        }
        
        IntPoint val_6 = val_62.Item[0];
        if((val_65 != val_6.Y) || (val_64 != val_6.X))
        {
            goto label_8;
        }
        
        val_63 = val_63 - 1;
        if(val_63 >= 1)
        {
            goto label_9;
        }
        
        label_8:
        val_66 = 1152921519901027632;
        label_14:
        val_67 = val_63;
        val_63 = val_67 - 1;
        if(val_63 >= 1)
        {
                if(val_62 != null)
        {
                IntPoint val_7 = val_62.Item[val_67];
            val_68 = val_7.X;
            val_69 = val_7.Y;
        }
        else
        {
                IntPoint val_8 = 0.Item[val_67];
            val_68 = val_8.X;
            val_69 = val_8.Y;
        }
        
            IntPoint val_9 = val_62.Item[val_63];
            if(val_69 == val_9.Y)
        {
                if(val_68 == val_9.X)
        {
            goto label_14;
        }
        
        }
        
        }
        
        if(Closed == false)
        {
            goto label_15;
        }
        
        if(val_67 > 1)
        {
            goto label_16;
        }
        
        goto label_74;
        label_15:
        if(val_67 < 1)
        {
            goto label_74;
        }
        
        label_16:
        System.Collections.Generic.List<TEdge> val_11 = new System.Collections.Generic.List<TEdge>(capacity:  val_67 + 1);
        var val_62 = 0;
        do
        {
            val_11.Add(item:  new InternalClipper.TEdge());
            val_62 = val_62 + 1;
        }
        while(val_62 <= val_67);
        
        TEdge val_13 = val_11.Item[1];
        IntPoint val_14 = val_62.Item[1];
        val_13.Curr = val_14.X;
        mem2[0] = val_14.Y;
        IntPoint val_15 = val_62.Item[0];
        this.RangeTest(Pt:  new IntPoint() {X = val_15.X, Y = val_15.Y}, useFullRange: ref  1152921519901230016);
        IntPoint val_17 = val_62.Item[val_67];
        this.RangeTest(Pt:  new IntPoint() {X = val_17.X, Y = val_17.Y}, useFullRange: ref  1152921519901230016);
        if(val_11 != null)
        {
                val_70 = val_11.Item[0];
            val_71 = val_11.Item[1];
        }
        else
        {
                val_70 = val_11.Item[0];
            val_71 = val_11.Item[1];
        }
        
        IntPoint val_24 = val_62.Item[0];
        val_24.X.InitEdge(e:  val_70, eNext:  val_71, ePrev:  val_11.Item[val_67], pt:  new IntPoint() {X = val_24.X, Y = val_24.Y});
        if(val_11 != null)
        {
                val_72 = val_11.Item[val_67];
            val_73 = val_11.Item[0];
        }
        else
        {
                val_72 = val_11.Item[val_67];
            val_73 = val_11.Item[0];
        }
        
        IntPoint val_30 = val_62.Item[val_67];
        val_74 = val_30.Y;
        val_30.X.InitEdge(e:  val_72, eNext:  val_73, ePrev:  val_11.Item[val_63], pt:  new IntPoint() {X = val_30.X, Y = val_74});
        if(val_63 >= 1)
        {
                do
        {
            int val_31 = val_67 - 1;
            IntPoint val_32 = val_62.Item[val_31];
            this.RangeTest(Pt:  new IntPoint() {X = val_32.X, Y = val_32.Y}, useFullRange: ref  1152921519901230016);
            if(val_11 != null)
        {
                val_75 = val_11.Item[val_31];
            val_76 = val_11.Item[val_67];
        }
        else
        {
                val_75 = val_11.Item[val_31];
            val_76 = val_11.Item[val_67];
        }
        
            val_67 = val_67 - 2;
            IntPoint val_39 = val_62.Item[val_31];
            val_74 = val_39.Y;
            val_39.X.InitEdge(e:  val_75, eNext:  val_76, ePrev:  val_11.Item[val_67], pt:  new IntPoint() {X = val_39.X, Y = val_74});
        }
        while(val_67 > 0);
        
        }
        
        val_77 = Closed;
        val_78 = polyType;
        TEdge val_40 = val_11.Item[0];
        val_79 = val_40;
        bool val_41 = val_77 ^ 1;
        val_80 = val_79;
        goto label_40;
        label_64:
        TEdge val_43 = val_40.RemoveEdge(e:  val_31);
        val_79 = val_43;
        goto label_40;
        label_58:
        if(val_31 == ((val_31 == val_80) ? (val_41) : (val_80)))
        {
                val_80 = mem[(((val_2 - 1) - 1) - 1) + 112];
            val_80 = (((val_2 - 1) - 1) - 1) + 112;
        }
        
        TEdge val_44 = val_43.RemoveEdge(e:  val_31);
        val_79 = val_44.Prev;
        label_40:
        val_81 = val_79;
        label_62:
        if(val_81 != null)
        {
                val_82 = val_81;
            val_83 = val_44.Prev.Curr;
            val_84 = val_44.Prev + 32;
            val_85 = mem[val_44.Prev + 32 + 8];
            val_85 = val_44.Prev + 32 + 8;
        }
        else
        {
                val_83 = 64;
            val_85 = 69077560;
            val_84 = 40;
            val_82 = 32;
        }
        
        if(val_83 != val_44.Prev.Next.Curr)
        {
            goto label_46;
        }
        
        val_62 = val_44.Prev.Next;
        if(val_85 != val_44.Prev.Next.Curr)
        {
            goto label_48;
        }
        
        var val_45 = (val_44.Prev.Next == val_80) ? 1 : 0;
        val_62 = val_80;
        val_45 = val_45 & val_41;
        if(val_45 == true)
        {
            goto label_48;
        }
        
        goto label_49;
        label_46:
        val_62 = val_44.Prev.Next;
        label_48:
        if(val_44.Prev.Prev == val_62)
        {
            goto label_65;
        }
        
        if(val_77 == false)
        {
            goto label_54;
        }
        
        if(val_44.Prev.Prev == null)
        {
                val_62 = val_44.Prev.Next;
        }
        
        val_86 = val_44.Prev.Prev.Curr;
        val_77 = Closed;
        val_78 = polyType;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = val_86, Y = val_77}, pt2:  new IntPoint() {X = val_82, Y = 69077560}, pt3:  new IntPoint() {X = val_44.Prev.Next.Curr, Y = val_74}, UseFullRange:  this.m_UseFullRange)) == false)
        {
            goto label_54;
        }
        
        if(mem[1152921519901230018] == false)
        {
            goto label_58;
        }
        
        if(val_44.Prev.Prev == null)
        {
                val_86 = 0;
        }
        
        val_62 = val_44.Prev.Next;
        if(val_62 == null)
        {
                val_86 = 0;
        }
        
        val_77 = Closed;
        val_78 = polyType;
        if((this.Pt2IsBetweenPt1AndPt3(pt1:  new IntPoint() {X = val_44.Prev.Prev.Curr, Y = val_77}, pt2:  new IntPoint() {X = 64, Y = 69077560}, pt3:  new IntPoint() {X = val_44.Prev.Next.Curr, Y = this.m_UseFullRange})) == false)
        {
            goto label_58;
        }
        
        label_54:
        val_67 = val_44.Prev.Next;
        val_66 = val_79;
        if(val_67 == val_66)
        {
            goto label_59;
        }
        
        if((val_77 == true) || (val_44.Prev.Next.Next != val_80))
        {
            goto label_62;
        }
        
        goto label_63;
        label_49:
        if(val_81 != val_44.Prev.Next)
        {
            goto label_64;
        }
        
        goto label_65;
        label_59:
        val_87 = val_66;
        label_65:
        if(val_77 == false)
        {
            goto label_66;
        }
        
        if(val_87 == 0)
        {
            goto label_67;
        }
        
        val_66 = mem[val_44.Prev + 120];
        val_66 = val_44.Prev + 120;
        goto label_68;
        label_66:
        if(val_87 == 0)
        {
            goto label_96;
        }
        
        label_63:
        if(val_87 == (val_44.Prev + 112))
        {
            goto label_74;
        }
        
        val_67 = this;
        mem[1152921519901230017] = 1;
        mem2[0] = -2;
        goto label_73;
        label_67:
        val_66 = 1;
        label_68:
        val_67 = this;
        if(val_66 == (val_44.Prev + 112))
        {
            goto label_74;
        }
        
        label_73:
        do
        {
            this.InitEdge2(e:  val_80, polyType:  val_78);
            if((1 & 1) != 0)
        {
                var val_48 = (((((val_2 - 1) - 1) - 1) + 112 + 112 + 40) == ((((val_2 - 1) - 1) - 1) + 112 + 40)) ? 1 : 0;
        }
        else
        {
                val_66 = 0;
        }
        
        }
        while(((((val_2 - 1) - 1) - 1) + 112 + 112) != val_80);
        
        if(val_66 == 0)
        {
            goto label_81;
        }
        
        if(val_77 == false)
        {
            goto label_82;
        }
        
        label_74:
        val_88 = 0;
        return (bool)val_88;
        label_81:
        mem[1152921519901229984].Add(item:  val_11);
        val_66 = mem[(((val_2 - 1) - 1) - 1) + 112 + 120];
        val_66 = (((val_2 - 1) - 1) - 1) + 112 + 120;
        val_89 = val_66;
        if(val_66 != 0)
        {
            goto label_86;
        }
        
        val_89 = mem[(((val_2 - 1) - 1) - 1) + 112 + 120];
        val_89 = (((val_2 - 1) - 1) - 1) + 112 + 120;
        if(val_89 == 0)
        {
            goto label_96;
        }
        
        label_86:
        if((((((val_2 - 1) - 1) - 1) + 112 + 120 + 16) == ((((val_2 - 1) - 1) - 1) + 112 + 120 + 48)) && (((((val_2 - 1) - 1) - 1) + 112 + 120 + 24) == ((((val_2 - 1) - 1) - 1) + 112 + 120 + 56)))
        {
                val_90 = mem[(((val_2 - 1) - 1) - 1) + 112 + 112];
            val_90 = (((val_2 - 1) - 1) - 1) + 112 + 112;
        }
        
        val_91 = this.FindNextLocMin(E:  val_90);
        val_88 = 1;
        if(val_91 == null)
        {
                return (bool)val_88;
        }
        
        label_113:
        InternalClipper.LocalMinima val_51 = null;
        val_77 = val_51;
        val_51 = new InternalClipper.LocalMinima();
        .Next = 0;
        if(val_91 != null)
        {
                .Y = (((val_2 - 1) - 1) - 1) + 112 + 120 + 56;
            val_92 = val_49.Dx;
        }
        else
        {
                .Y = 15026800;
            val_92 = 0;
        }
        
        if(val_92 >= 0)
        {
            goto label_95;
        }
        
        val_93 = val_77;
        .RightBound = val_91;
        val_94 = 1152921519901397152;
        mem[1152921519901397144] = val_49.Prev;
        if(val_49.Prev == null)
        {
            goto label_96;
        }
        
        val_62 = 0;
        val_91 = val_49.Prev;
        goto label_97;
        label_95:
        val_94 = val_77;
        .LeftBound = val_91;
        val_93 = 1152921519901397152;
        val_62 = 1;
        mem[1152921519901397152] = val_49.Prev;
        label_97:
        val_49.Side = 0;
        mem2[0] = val_88;
        val_95 = .LeftBound;
        if(Closed != false)
        {
                val_95 = .LeftBound;
            var val_52 = (val_49.Next != mem[1152921519901397152]) ? (-0) : 0;
        }
        else
        {
                val_96 = 0;
        }
        
        WindDelta = val_96;
        mem2[0] = -val_49.WindDelta;
        val_97 = this.ProcessBound(E:  .LeftBound, LeftBoundIsForward:  true);
        if(val_53.OutIdx == 2)
        {
                val_97 = this.ProcessBound(E:  val_97, LeftBoundIsForward:  true);
        }
        
        bool val_55 = val_62 ^ 1;
        val_67 = this.ProcessBound(E:  mem[1152921519901397152], LeftBoundIsForward:  val_55);
        if(val_56.OutIdx == 2)
        {
                val_67 = this.ProcessBound(E:  val_67, LeftBoundIsForward:  val_55);
        }
        
        if(val_49.OutIdx == 2)
        {
            goto label_110;
        }
        
        val_94 = val_93;
        if((val_49.Prev + 108) != 2)
        {
            goto label_112;
        }
        
        label_110:
        mem[1152921519901397152] = 0;
        label_112:
        this.InsertLocalMinima(newLm:  val_51);
        if((this.FindNextLocMin(E:  (val_62 != 0) ? (val_97) : (val_67))) != ((0 == 0) ? (val_91) : 0))
        {
            goto label_113;
        }
        
        goto label_114;
        label_82:
        mem2[0] = -2;
        InternalClipper.LocalMinima val_60 = new InternalClipper.LocalMinima();
        if(val_60 != null)
        {
                .Next = 0;
            val_98 = val_60;
            .RightBound = val_80;
            mem[1152921519901434000] = (((val_2 - 1) - 1) - 1) + 112 + 24;
            mem[1152921519901434008] = 0;
            mem2[0] = 1;
        }
        else
        {
                mem[40] = 0;
            mem[16] = (((val_2 - 1) - 1) - 1) + 112 + 24;
            mem[24] = 0;
            mem[32] = val_80;
            mem2[0] = 1;
            val_98 = 32;
        }
        
        mem2[0] = 0;
        goto label_121;
        label_127:
        mem2[0] = (((val_2 - 1) - 1) - 1) + 112 + 112;
        val_99 = (((val_2 - 1) - 1) - 1) + 112 + 112;
        label_121:
        if(val_99 != 0)
        {
                val_100 = mem[(((val_2 - 1) - 1) - 1) + 112 + 112 + 16];
            val_100 = (((val_2 - 1) - 1) - 1) + 112 + 112 + 16;
        }
        else
        {
                val_100 = mem[16];
        }
        
        val_62 = mem[(((val_2 - 1) - 1) - 1) + 112 + 112 + 120];
        val_62 = (((val_2 - 1) - 1) - 1) + 112 + 112 + 120;
        if(val_100 != ((((val_2 - 1) - 1) - 1) + 112 + 112 + 120 + 48))
        {
                this.ReverseHorizontal(e:  val_99);
        }
        
        if(((((val_2 - 1) - 1) - 1) + 112 + 112 + 112 + 108) != 2)
        {
            goto label_127;
        }
        
        this.InsertLocalMinima(newLm:  val_60);
        val_66 = mem[1152921519901229984];
        val_66.Add(item:  val_11);
        label_114:
        val_88 = 1;
        return (bool)val_88;
        label_96:
        label_2:
        InternalClipper.ClipperException val_61 = new InternalClipper.ClipperException(description:  "AddPath: Open paths must be subject.");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> ppg, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyType polyType, bool closed)
    {
        var val_5;
        int val_1 = ppg.Count;
        if(val_1 >= 1)
        {
                var val_6 = 0;
            do
        {
            val_6 = val_6 + 1;
            val_5 = 0 | (this.AddPath(pg:  ppg.Item[0], polyType:  polyType, Closed:  closed));
        }
        while(val_1 != val_6);
        
            return (bool)val_5 & 1;
        }
        
        val_5 = 0;
        return (bool)val_5 & 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool Pt2IsBetweenPt1AndPt3(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt3)
    {
        if(pt1.X == pt3.X)
        {
                if(pt1.Y == pt3.Y)
        {
                return false;
        }
        
        }
        
        if(pt1.Y == pt2.Y)
        {
                if(pt1.X == pt2.X)
        {
                return false;
        }
        
        }
        
        if((pt3.X == pt2.X) && (pt3.Y == pt2.Y))
        {
                return false;
        }
        
        if(pt1.X == pt3.X)
        {
                var val_1 = (pt2.Y > pt1.Y) ? 1 : 0;
        }
        else
        {
                var val_2 = (pt2.X > pt1.X) ? 1 : 0;
        }
        
        val_2 = val_2 ^ ((pt2.X < pt3.X) ? 1 : 0);
        return (bool)val_2 ^ 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge RemoveEdge(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        InternalClipper.TEdge val_1;
        InternalClipper.TEdge val_2;
        if(e != null)
        {
                val_1 = e;
            val_2 = e.Prev;
        }
        else
        {
                val_1 = 120;
            val_2 = 1;
        }
        
        mem[25769803889] = e.Next;
        e.Next.Prev = val_1;
        mem[120] = 0;
        return (TEdge)e.Next;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetDx(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        InternalClipper.IntPoint val_3;
        var val_4;
        double val_5;
        if(e == null)
        {
            goto label_0;
        }
        
        val_3 = e.Top - e.Bot;
        val_4 = X9 - X11;
        e.Delta = val_3;
        mem2[0] = val_4;
        if(val_4 != 0)
        {
            goto label_1;
        }
        
        goto label_3;
        label_0:
        mem[64] = 15762869266743293;
        mem[72] = 7599944619439511;
        if(mem[72] == 0)
        {
            goto label_3;
        }
        
        val_3 = mem[64];
        val_4 = mem[72];
        label_1:
        val_5 = (1.57628692787364E+16) / (7.599944630272E+15);
        goto label_4;
        label_3:
        val_5 = -3.4E+38;
        label_4:
        e.Dx = val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InsertLocalMinima(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.LocalMinima newLm)
    {
        var val_1;
        InternalClipper.LocalMinima val_2;
        InternalClipper.LocalMinima val_3;
        val_1 = this;
        val_2 = this.m_MinimaList;
        if(val_2 == null)
        {
            goto label_0;
        }
        
        if(newLm != null)
        {
            goto label_1;
        }
        
        val_2 = val_2;
        if(val_2 == null)
        {
            goto label_2;
        }
        
        label_1:
        if(newLm.Y >= this.m_MinimaList.Y)
        {
            goto label_3;
        }
        
        label_6:
        val_3 = this.m_MinimaList.Next;
        val_1 = this.m_MinimaList + 40;
        if(val_3 == null)
        {
            goto label_7;
        }
        
        if(newLm.Y < this.m_MinimaList.Next.Y)
        {
            goto label_6;
        }
        
        goto label_7;
        label_3:
        val_3 = val_2;
        label_7:
        newLm.Next = val_3;
        label_0:
        this.m_MinimaList = newLm;
        return;
        label_2:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool PopLocalMinima(long Y, out Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.LocalMinima current)
    {
        current = this.m_CurrentLM;
        if(this.m_CurrentLM == null)
        {
                return false;
        }
        
        if(this.m_CurrentLM.Y != Y)
        {
                return false;
        }
        
        this.m_CurrentLM = this.m_CurrentLM.Next;
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ReverseHorizontal(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        e.Top = e.Bot;
        e.Bot = e.Top;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal virtual void Reset()
    {
        this.m_CurrentLM = this.m_MinimaList;
        if(this.m_MinimaList == null)
        {
                return;
        }
        
        this.m_Scanbeam = 0;
        do
        {
            this.InsertScanbeam(Y:  this.m_MinimaList.Y);
            if(this.m_MinimaList.LeftBound != null)
        {
                this.m_MinimaList.LeftBound.OutIdx = 0;
            this.m_MinimaList.LeftBound.Curr = this.m_MinimaList.LeftBound.Bot;
            mem2[0] = ???;
        }
        
            if(this.m_MinimaList.RightBound != null)
        {
                this.m_MinimaList.RightBound.OutIdx = 0;
            this.m_MinimaList.RightBound.Curr = this.m_MinimaList.RightBound.Bot;
            mem2[0] = ???;
        }
        
        }
        while(this.m_MinimaList.Next != null);
        
        this.m_ActiveEdges = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> paths)
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        long val_26;
        long val_27;
        InternalClipper.IntRect val_0;
        val_23 = val_0;
        int val_1 = paths.Count;
        if(val_1 < 1)
        {
            goto label_2;
        }
        
        val_22 = 1152921519891683264;
        val_24 = 1152921519901026608;
        val_25 = 0;
        label_6:
        if(paths.Item[0].Count != 0)
        {
            goto label_7;
        }
        
        val_25 = val_25 + 1;
        if(val_25 < val_1)
        {
            goto label_6;
        }
        
        goto label_7;
        label_2:
        val_25 = 0;
        label_7:
        if(val_25 != val_1)
        {
            goto label_8;
        }
        
        val_26 = 0;
        val_27 = 0;
        val_0.left = 0;
        val_0.top = 0;
        val_0.right = 0;
        val_0.bottom = 0;
        goto label_39;
        label_8:
        val_22 = 1152921519891683264;
        val_24 = 1152921519901027632;
        IntPoint val_5 = paths.Item[0].Item[0];
        val_26 = val_5.X;
        IntPoint val_7 = paths.Item[0].Item[0];
        val_27 = val_7.Y;
        if(val_25 >= val_1)
        {
            goto label_14;
        }
        
        label_38:
        val_23 = paths.Item[0].Count;
        if(val_23 < 1)
        {
            goto label_17;
        }
        
        var val_22 = 0;
        label_37:
        IntPoint val_11 = paths.Item[0].Item[0];
        IntPoint val_13 = paths.Item[0].Item[0];
        if(val_11.X >= val_26)
        {
            goto label_22;
        }
        
        if(paths != null)
        {
            goto label_28;
        }
        
        goto label_24;
        label_22:
        if(val_13.X > val_26)
        {
                IntPoint val_15 = paths.Item[0].Item[0];
            val_26 = val_15.X;
        }
        
        if(paths != null)
        {
            goto label_28;
        }
        
        label_24:
        label_28:
        IntPoint val_17 = paths.Item[0].Item[0];
        IntPoint val_19 = paths.Item[0].Item[0];
        if(val_17.Y < val_27)
        {
            
        }
        else
        {
                if(val_19.Y > val_27)
        {
                IntPoint val_21 = paths.Item[0].Item[0];
            val_27 = val_21.Y;
        }
        
        }
        
        val_22 = val_22 + 1;
        if(val_23 != val_22)
        {
            goto label_37;
        }
        
        label_17:
        val_25 = val_25 + 1;
        if(val_25 != val_1)
        {
            goto label_38;
        }
        
        goto label_39;
        label_14:
        label_39:
        val_0.bottom = val_27;
        val_0.left = val_26;
        val_0.top = val_27;
        val_0.right = val_26;
        return val_0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void InsertScanbeam(long Y)
    {
        long val_4 = Y;
        if(this.m_Scanbeam == null)
        {
            goto label_1;
        }
        
        if(this.m_Scanbeam.Y >= val_4)
        {
            goto label_6;
        }
        
        InternalClipper.Scanbeam val_1 = new InternalClipper.Scanbeam();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .Y = val_4;
        val_4 = this.m_Scanbeam;
        goto label_4;
        label_6:
        if(this.m_Scanbeam.Next != null)
        {
                if(this.m_Scanbeam.Next.Y >= val_4)
        {
            goto label_6;
        }
        
        }
        
        if(this.m_Scanbeam.Y == val_4)
        {
                return;
        }
        
        InternalClipper.Scanbeam val_2 = new InternalClipper.Scanbeam();
        if(val_2 == null)
        {
            goto label_8;
        }
        
        .Y = val_4;
        val_4 = this.m_Scanbeam.Next;
        goto label_9;
        label_1:
        this.m_Scanbeam = new InternalClipper.Scanbeam();
        .Next = 0;
        this.m_Scanbeam.Y = val_4;
        return;
        label_3:
        mem[16] = val_4;
        val_4 = this.m_Scanbeam;
        label_4:
        .Next = val_4;
        this.m_Scanbeam = val_1;
        return;
        label_8:
        mem[16] = val_4;
        val_4 = this.m_Scanbeam.Next;
        label_9:
        .Next = val_4;
        this.m_Scanbeam.Next = val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool PopScanbeam(out long Y)
    {
        var val_1;
        if(this.m_Scanbeam != null)
        {
                Y = this.m_Scanbeam.Y;
            val_1 = 1;
            this.m_Scanbeam = this.m_Scanbeam.Next;
            return (bool)val_1;
        }
        
        val_1 = 0;
        Y = 0;
        return (bool)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool LocalMinimaPending()
    {
        return (bool)(this.m_CurrentLM != 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec CreateOutRec()
    {
        var val_4;
        InternalClipper.OutRec val_1 = new InternalClipper.OutRec();
        if(val_1 != null)
        {
                val_4 = val_1;
            .Idx = 0;
            mem[1152921519903306260] = 0;
            mem[1152921519903306272] = 0;
            mem[1152921519903306280] = 0;
            mem[1152921519903306264] = 0;
        }
        else
        {
                val_4 = 16;
            mem[16] = 0;
            .IsHole = false;
            .IsOpen = false;
            mem[24] = 0;
            mem[32] = 0;
            mem[40] = 0;
        }
        
        .PolyNode = 0;
        this.m_PolyOuts.Add(item:  val_1);
        mem[16] = this.m_PolyOuts.Count - 1;
        return (OutRec)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void DisposeOutRec(int index)
    {
        OutRec val_1 = this.m_PolyOuts.Item[index];
        val_1.Pts = 0;
        this.m_PolyOuts.set_Item(index:  index, value:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void UpdateEdgeIntoAEL(ref Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        InternalClipper.TEdge val_3;
        InternalClipper.TEdge val_4;
        InternalClipper.TEdge val_5;
        InternalClipper.TEdge val_6;
        InternalClipper.TEdge val_7;
        InternalClipper.TEdge val_8;
        InternalClipper.IntPoint val_9;
        var val_10;
        if(e.NextInLML == null)
        {
            goto label_2;
        }
        
        val_3 = e;
        if(val_3 == null)
        {
            goto label_3;
        }
        
        val_4 = mem[e + 144];
        val_4 = e.PrevInAEL;
        goto label_4;
        label_3:
        val_4 = mem[e + 144];
        val_4 = e.PrevInAEL;
        if(e == null)
        {
            goto label_5;
        }
        
        val_3 = e;
        label_4:
        label_30:
        label_31:
        OutIdx = e.OutIdx;
        var val_1 = (val_4 == 0) ? this.m_ActiveEdges : (null);
        mem2[0] = e.NextInLML;
        if(e.NextInAEL != null)
        {
                PrevInAEL = e.NextInLML;
        }
        
        val_5 = e;
        if(e != null)
        {
            goto label_10;
        }
        
        val_5 = e;
        if(val_5 == null)
        {
            goto label_20;
        }
        
        label_10:
        Side = e.Side;
        val_6 = e;
        if(e != null)
        {
            goto label_13;
        }
        
        val_6 = e;
        if(val_6 == null)
        {
            goto label_20;
        }
        
        label_13:
        WindDelta = e.WindDelta;
        val_7 = e;
        if(e != null)
        {
            goto label_16;
        }
        
        val_7 = e;
        if(val_7 == null)
        {
            goto label_20;
        }
        
        label_16:
        WindCnt = e.WindCnt;
        val_8 = e;
        if(e != null)
        {
            goto label_19;
        }
        
        val_8 = e;
        if(val_8 == null)
        {
            goto label_20;
        }
        
        label_19:
        WindCnt2 = e.WindCnt2;
        e = e.NextInLML;
        if(e.NextInLML != null)
        {
                val_9 = mem[e.NextInLML + 16];
            val_9 = e.NextInLML.Bot;
            val_10 = mem[e.NextInLML + 16 + 8];
        }
        else
        {
                val_9 = 11993091;
            val_10 = 15026800;
        }
        
        Curr = val_9;
        mem2[0] = val_10;
        PrevInAEL = val_4;
        NextInAEL = e.NextInAEL;
        if((mem[e.NextInLML + 72]) == 0)
        {
                return;
        }
        
        this.InsertScanbeam(Y:  mem[e.NextInLML + 56]);
        return;
        label_5:
        if(e != null)
        {
            goto label_30;
        }
        
        if(e != null)
        {
            goto label_31;
        }
        
        label_20:
        label_2:
        InternalClipper.ClipperException val_2 = new InternalClipper.ClipperException(description:  "UpdateEdgeIntoAEL: invalid call");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void SwapPositionsInAEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge2)
    {
        var val_1;
        InternalClipper.TEdge val_2;
        InternalClipper.TEdge val_3;
        if(edge1 != null)
        {
                val_1 = edge1;
            val_2 = edge1.NextInAEL;
        }
        else
        {
                val_1 = 136;
            val_2 = 62656512;
        }
        
        if(val_2 == edge1.PrevInAEL)
        {
                return;
        }
        
        if(edge2 != null)
        {
                val_2 = edge2;
            val_3 = edge2.NextInAEL;
        }
        else
        {
                val_2 = 136;
            val_3 = 62656512;
        }
        
        if(val_3 == edge2.PrevInAEL)
        {
                return;
        }
        
        if(62656512 == edge2)
        {
            goto label_6;
        }
        
        if(62656512 == edge1)
        {
            goto label_7;
        }
        
        mem[136] = 62656512;
        edge1.PrevInAEL = edge2.PrevInAEL;
        if(edge2.PrevInAEL != null)
        {
                edge2.PrevInAEL.NextInAEL = edge1;
        }
        
        mem[136] = 62656512;
        edge2.PrevInAEL = edge1.PrevInAEL;
        if(edge1.PrevInAEL == null)
        {
            goto label_12;
        }
        
        edge1.PrevInAEL.NextInAEL = edge2;
        goto label_12;
        label_6:
        if(edge1.PrevInAEL != null)
        {
                edge1.PrevInAEL.NextInAEL = edge2;
        }
        
        edge2.PrevInAEL = edge1.PrevInAEL;
        mem[136] = edge1;
        edge1.PrevInAEL = edge2;
        mem[136] = 62656512;
        goto label_15;
        label_7:
        if(edge2.PrevInAEL != null)
        {
                edge2.PrevInAEL.NextInAEL = edge1;
        }
        
        edge1.PrevInAEL = edge2.PrevInAEL;
        mem[136] = edge2;
        edge2.PrevInAEL = edge1;
        mem[136] = 62656512;
        label_12:
        if(edge1.PrevInAEL == null)
        {
            goto label_18;
        }
        
        label_15:
        if(edge2.PrevInAEL != null)
        {
                return;
        }
        
        this.m_ActiveEdges = edge2;
        return;
        label_18:
        this.m_ActiveEdges = edge1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void DeleteFromAEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        var val_3;
        InternalClipper.TEdge val_4;
        if(e != null)
        {
                val_3 = e;
            val_4 = e.PrevInAEL;
        }
        else
        {
                val_3 = 144;
            val_4 = 62656512;
        }
        
        if((e.NextInAEL | val_4) == null)
        {
                if(mem[this.m_ActiveEdges] != e)
        {
                return;
        }
        
        }
        
        var val_3 = (val_4 != 0) ? (val_4 + 136) : this.m_ActiveEdges;
        mem2[0] = e.NextInAEL;
        if(e.NextInAEL != null)
        {
                e.NextInAEL.PrevInAEL = val_4;
        }
        
        e.NextInAEL = 0;
        mem[144] = 0;
    }

}
