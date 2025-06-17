using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class InternalClipper.Clipper : InternalClipper.ClipperBase
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ioReverseSolution = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ioStrictlySimple = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ioPreserveCollinear = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.ClipType m_ClipType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Maxima m_Maxima;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge m_SortedEdges;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode> m_IntersectList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.IComparer<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode> m_IntersectNodeComparer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_ExecuteLocked;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType m_ClipFillType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType m_SubjFillType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Join> m_Joins;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Join> m_GhostJoins;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_UsingPolyTree;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <ReverseSolution>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <StrictlySimple>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool ReverseSolution { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool StrictlySimple { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.Clipper(int InitOptions = 0)
    {
        mem[1152921519904037016] = 0;
        mem[1152921519904037032] = 0;
        this.m_Maxima = 0;
        this.m_SortedEdges = 0;
        this.m_IntersectList = new System.Collections.Generic.List<IntersectNode>();
        this.m_IntersectNodeComparer = new InternalClipper.MyIntersectNodeSort();
        this.m_ExecuteLocked = false;
        this.m_UsingPolyTree = false;
        mem[1152921519904037024] = new System.Collections.Generic.List<OutRec>();
        this.m_Joins = new System.Collections.Generic.List<Join>();
        this.m_GhostJoins = new System.Collections.Generic.List<Join>();
        this.<ReverseSolution>k__BackingField = InitOptions & 1;
        this.<StrictlySimple>k__BackingField = (uint)(InitOptions >> 1) & 1;
        this.PreserveCollinear = (uint)(InitOptions >> 2) & 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InsertMaxima(long X)
    {
        InternalClipper.Maxima val_2;
        InternalClipper.Maxima val_3;
        val_2 = this;
        InternalClipper.Maxima val_1 = null;
        val_3 = val_1;
        val_1 = new InternalClipper.Maxima();
        .X = X;
        if(this.m_Maxima == null)
        {
            goto label_2;
        }
        
        if(this.m_Maxima.X > X)
        {
                .Next = this.m_Maxima;
            .Prev = 0;
            this.m_Maxima = val_3;
            return;
        }
        
        label_6:
        val_2 = this.m_Maxima;
        if(this.m_Maxima.Next != null)
        {
                if(this.m_Maxima.Next.X <= X)
        {
            goto label_6;
        }
        
        }
        
        if(this.m_Maxima.X == X)
        {
                return;
        }
        
        if(val_3 == null)
        {
            goto label_8;
        }
        
        .Next = this.m_Maxima.Next;
        goto label_9;
        label_2:
        this.m_Maxima = val_3;
        .Next = 0;
        val_3 = this.m_Maxima;
        this.m_Maxima.Prev = 0;
        return;
        label_8:
        mem[24] = this.m_Maxima.Next;
        label_9:
        .Prev = val_2;
        if(this.m_Maxima.Next != null)
        {
                this.m_Maxima.Next.Prev = val_3;
        }
        
        this.m_Maxima.Next = val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_ReverseSolution()
    {
        return (bool)this.<ReverseSolution>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ReverseSolution(bool value)
    {
        this.<ReverseSolution>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_StrictlySimple()
    {
        return (bool)this.<StrictlySimple>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_StrictlySimple(bool value)
    {
        this.<StrictlySimple>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Execute(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> solution, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType FillType = 0)
    {
        return this.Execute(clipType:  clipType, solution:  solution, subjFillType:  FillType, clipFillType:  FillType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Execute(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.ClipType clipType, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree polytree, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType FillType = 0)
    {
        return this.Execute(clipType:  clipType, polytree:  polytree, subjFillType:  FillType, clipFillType:  FillType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Execute(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> solution, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType subjFillType, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType clipFillType)
    {
        var val_3;
        if(this.m_ExecuteLocked != false)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        if(this.m_ExecuteLocked != true)
        {
                this.m_ExecuteLocked = true;
            solution.Clear();
            this.m_ClipFillType = clipFillType;
            this.m_SubjFillType = subjFillType;
            this.m_ClipType = clipType;
            this.m_UsingPolyTree = false;
            if(this.ExecuteInternal() != false)
        {
                this.BuildResult(polyg:  solution);
            val_3 = 1;
        }
        else
        {
                val_3 = 0;
        }
        
            this.DisposeAllPolyPts();
            this.m_ExecuteLocked = false;
            return (bool)val_3;
        }
        
        if(0 == 1)
        {
                new InternalClipper.ClipperException(description:  "Error: PolyTree struct is needed for open path clipping.").DisposeAllPolyPts();
            mem[1152921519905114776] = 0;
            if(null == null)
        {
                return (bool)val_3;
        }
        
            return (bool)val_3;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Execute(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.ClipType clipType, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree polytree, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType subjFillType, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType clipFillType)
    {
        var val_2;
        if(this.m_ExecuteLocked != false)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.m_ClipFillType = clipFillType;
        this.m_SubjFillType = subjFillType;
        this.m_ClipType = clipType;
        this.m_ExecuteLocked = true;
        this.m_UsingPolyTree = true;
        if(this.ExecuteInternal() != false)
        {
                this.BuildResult2(polytree:  polytree);
            val_2 = 1;
        }
        else
        {
                val_2 = 0;
        }
        
        this.DisposeAllPolyPts();
        this.m_ExecuteLocked = false;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void FixHoleLinkage(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec)
    {
        InternalClipper.OutRec val_5;
        bool val_6;
        val_5 = outRec.FirstLeft;
        if(val_5 == null)
        {
                return;
        }
        
        val_6 = outRec.FirstLeft.IsHole;
        if(((outRec.IsHole == true) ? 1 : 0) == ((val_6 == true) ? 1 : 0))
        {
            goto label_4;
        }
        
        if(outRec.FirstLeft.Pts != null)
        {
                return;
        }
        
        goto label_4;
        label_7:
        val_6 = outRec.FirstLeft.IsHole;
        label_4:
        var val_4 = (val_6 != true) ? 1 : 0;
        val_4 = val_4 ^ ((outRec.IsHole == true) ? 1 : 0);
        if((val_4 & 1) != 0)
        {
                if(outRec.FirstLeft.Pts != null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = outRec.FirstLeft.FirstLeft;
        if(val_5 != null)
        {
            goto label_7;
        }
        
        label_6:
        outRec.FirstLeft = val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool ExecuteInternal()
    {
        var val_9;
        var val_18;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        this.Reset();
        this.m_Maxima = 0;
        this.m_SortedEdges = 0;
        if((this.PopScanbeam(Y: out  0)) == false)
        {
            goto label_5;
        }
        
        this.InsertLocalMinimaIntoAEL(botY:  0);
        label_6:
        if((this.PopScanbeam(Y: out  0)) != true)
        {
                if(this.LocalMinimaPending() == false)
        {
            goto label_3;
        }
        
        }
        
        this.ProcessHorizontals();
        this.m_GhostJoins.Clear();
        if((this.ProcessIntersections(topY:  0)) == false)
        {
            goto label_5;
        }
        
        this.ProcessEdgesAtTopOfScanbeam(topY:  0);
        this.InsertLocalMinimaIntoAEL(botY:  0);
        goto label_6;
        label_5:
        val_22 = 0;
        val_23 = 0;
        label_43:
        val_24 = 358;
        goto label_7;
        label_3:
        List.Enumerator<T> val_7 = GetEnumerator();
        label_14:
        if(((-1881193904) & 1) == 0)
        {
            goto label_9;
        }
        
        if((val_10._emailDatas == null) || (val_10._emailDatas != null))
        {
            goto label_14;
        }
        
        var val_12 = ((this.<ReverseSolution>k__BackingField) == true) ? 1 : 0;
        val_12 = ((1152921519905472496 != 0) ? 1 : 0) ^ val_12;
        val_12 = val_12 ^ (((this.Area(outRec:  val_9.emailUIDataHandler)) > 0f) ? 1 : 0);
        if((val_12 & 1) != 0)
        {
            goto label_14;
        }
        
        this.ReversePolyPtLinks(pp:  val_10._emailDatas);
        goto label_14;
        label_9:
        val_25 = 0;
        val_26 = 227;
        long val_15 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519905522256});
        if( == 227)
        {
            
        }
        else
        {
                if( != 0)
        {
                val_25 = 0;
        }
        
        }
        
        this.JoinCommonEdges();
        List.Enumerator<T> val_16 = GetEnumerator();
        do
        {
            label_31:
            if(((-1881193904) & 1) == 0)
        {
            goto label_32;
        }
        
            GameUI.EmailUIDataHandler val_19 = val_18.emailUIDataHandler;
        }
        while(val_19._emailDatas == null);
        
        if(val_19._emailDatas == null)
        {
            goto label_29;
        }
        
        this.FixupOutPolyline(outrec:  val_19);
        goto label_31;
        label_29:
        this.FixupOutPolygon(outRec:  val_19);
        goto label_31;
        label_32:
        long val_20 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519905522256});
        if(((317 == 0) ? 317 : 317) == 317)
        {
            
        }
        
        if((this.<StrictlySimple>k__BackingField) == false)
        {
            goto label_43;
        }
        
        this.DoSimplePolygons();
        goto label_43;
        label_7:
        this.m_Joins.Clear();
        this.m_GhostJoins.Clear();
        if( == 0)
        {
                return (bool);
        }
        
        if( == 0)
        {
                return (bool);
        }
        
        if( == 358)
        {
                return (bool);
        }
        
        return (bool);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DisposeAllPolyPts()
    {
        int val_1 = Count;
        if(val_1 >= 1)
        {
                var val_2 = 0;
            do
        {
            this.DisposeOutRec(index:  0);
            val_2 = val_2 + 1;
        }
        while(val_1 != val_2);
        
        }
        
        this.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddJoin(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt Op1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt Op2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint OffPt)
    {
        InternalClipper.Join val_1 = new InternalClipper.Join();
        if(val_1 != null)
        {
                .OutPt1 = Op1;
            .OutPt2 = Op2;
        }
        else
        {
                mem[16] = Op1;
            mem[24] = Op2;
        }
        
        .OffPt = OffPt.X;
        mem[1152921519905849816] = OffPt.Y;
        this.m_Joins.Add(item:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddGhostJoin(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt Op, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint OffPt)
    {
        InternalClipper.Join val_1 = new InternalClipper.Join();
        if(val_1 != null)
        {
                .OutPt1 = Op;
        }
        else
        {
                mem[16] = Op;
        }
        
        .OffPt = OffPt.X;
        mem[1152921519905986392] = OffPt.Y;
        this.m_GhostJoins.Add(item:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InsertLocalMinimaIntoAEL(long botY)
    {
        TEdge val_20;
        InternalClipper.IntPoint val_21;
        var val_22;
        InternalClipper.OutPt val_23;
        TEdge val_24;
        var val_25;
        var val_26;
        val_21 = 0;
        InternalClipper.LocalMinima val_1 = 0;
        if((this.PopLocalMinima(Y:  botY, current: out  val_1)) == false)
        {
                return;
        }
        
        label_54:
        val_22 = val_1;
        if(val_1 != 0)
        {
            goto label_2;
        }
        
        val_22 = val_1;
        if(val_22 == 0)
        {
            goto label_3;
        }
        
        label_2:
        val_20 = 15026800;
        if(val_20 == 0)
        {
            goto label_4;
        }
        
        this.InsertEdgeIntoAEL(edge:  val_20, startEdge:  0);
        if(64 == 0)
        {
            goto label_5;
        }
        
        this.InsertEdgeIntoAEL(edge:  64, startEdge:  val_20);
        this.SetWindingCount(edge:  val_20);
        mem[164] = -1879047808;
        mem[168] = -1861664141;
        if((this.IsContributing(edge:  val_20)) == false)
        {
            goto label_6;
        }
        
        val_21 = -2006975390;
        val_23 = this.AddLocalMinPoly(e1:  val_20, e2:  64, pt:  new IntPoint() {X = 5836669809464441954, Y = 3746995600923950180});
        goto label_7;
        label_4:
        val_24 = 0;
        this.InsertEdgeIntoAEL(edge:  64, startEdge:  val_24);
        this.SetWindingCount(edge:  64);
        if((this.IsContributing(edge:  64)) == false)
        {
            goto label_8;
        }
        
        val_24 = 0;
        val_21 = 0;
        val_23 = this.AddOutPt(e:  64, pt:  new IntPoint());
        goto label_13;
        label_5:
        this.SetWindingCount(edge:  val_20);
        if((this.IsContributing(edge:  val_20)) != false)
        {
                InternalClipper.OutPt val_8 = this.AddOutPt(e:  val_20, pt:  new IntPoint() {X = 5836669809464441954, Y = 3746995600923950180});
        }
        
        this.InsertScanbeam(Y:  -2999674703300666950);
        goto label_52;
        label_6:
        val_23 = 0;
        label_7:
        val_24 = 0;
        this.InsertScanbeam(Y:  -2999674703300666950);
        goto label_13;
        label_8:
        if(64 == 0)
        {
            goto label_52;
        }
        
        val_23 = 0;
        label_13:
        if((InternalClipper.ClipperBase.IsHorizontal(e:  64)) == false)
        {
            goto label_15;
        }
        
        if(66481712 != 0)
        {
                val_24 = 0;
            this.InsertScanbeam(Y:  18532);
        }
        
        this.AddEdgeToSEL(edge:  64);
        if(val_20 == 0)
        {
            goto label_52;
        }
        
        label_53:
        if(((val_23 != 0) && ((InternalClipper.ClipperBase.IsHorizontal(e:  64)) != false)) && ((this.m_GhostJoins.Count >= 1) && (7375136 != 0)))
        {
                int val_12 = this.m_GhostJoins.Count;
            if(val_12 >= 1)
        {
                do
        {
            Join val_13 = this.m_GhostJoins.Item[0];
            val_24 = val_13.OffPt;
            val_21 = 0;
            if((this.HorzSegmentsOverlap(seg1a:  val_13.OutPt1.Pt, seg1b:  val_24, seg2a:  0, seg2b:  65536)) != false)
        {
                val_21 = val_13.OffPt;
            val_24 = val_23;
            this.AddJoin(Op1:  val_13.OutPt1, Op2:  val_24, OffPt:  new IntPoint() {X = val_21, Y = 65536});
        }
        
            val_25 = 0 + 1;
        }
        while(val_12 != val_25);
        
        }
        
        }
        
        if((((((-1860009951) & 2147483648) == 0) && ((-1862269981) != 0)) && ((mem[-6191319324687334397]) == (-2006975390))) && (((mem[-6191319324687334321]) & 2147483648) == 0))
        {
                val_21 = mem[-6191319324687334373];
            if((((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = 5836669809464441954, Y = mem[-6191319324687334389]}, pt2:  new IntPoint() {X = mem[-6191319324687334381], Y = val_21}, pt3:  new IntPoint() {X = -5098057177004769284, Y = -5116071570262981565}, pt4:  new IntPoint() {X = 6052838227400654943, Y = -2999674703300666950}, UseFullRange:  true)) != false) && ((-805200575) != 0)) && ((mem[-6191319324687334333]) != 0))
        {
                val_21 = 1797193823;
            this.AddJoin(Op1:  val_23, Op2:  this.AddOutPt(e:  -1862269981, pt:  new IntPoint() {X = 5836669809464441954, Y = 3746995600923950180}), OffPt:  new IntPoint() {X = 6052838227400654943, Y = -2999674703300666950});
        }
        
        }
        
        if((-1859984748) == 64)
        {
            goto label_52;
        }
        
        if(((0 & 2147483648) == 0) && ((703 & 2147483648) == 0))
        {
                val_26 = 496;
            if(496 == 0)
        {
                val_26 = 496;
        }
        
            val_25 = 647;
            if((((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = 1636382540392, Y = 622770258567}, pt2:  new IntPoint() {X = 506, Y = 1301375091307}, pt3:  new IntPoint() {X = 62590012, Y = 62590012}, pt4:  new IntPoint() {X = 65536, Y = 25769803777}, UseFullRange:  true)) != false) && (7375136 != 0)) && (0 != 0))
        {
                this.AddJoin(Op1:  val_23, Op2:  this.AddOutPt(e:  496, pt:  new IntPoint()), OffPt:  new IntPoint() {X = 65536, Y = 25769803777});
        }
        
        }
        
        val_23 = -1859984748;
        if(val_23 != 0)
        {
            goto label_48;
        }
        
        goto label_52;
        label_51:
        this.IntersectEdges(e1:  64, e2:  val_23, pt:  new IntPoint() {X = -5098057177004769284, Y = -5116071570262981565});
        val_23 = mem[-7998353482205437156];
        label_48:
        if(val_23 != 64)
        {
            goto label_51;
        }
        
        goto label_52;
        label_15:
        this.InsertScanbeam(Y:  25769803777);
        if(val_20 != 0)
        {
            goto label_53;
        }
        
        label_52:
        if((this.PopLocalMinima(Y:  botY, current: out  val_1)) == true)
        {
            goto label_54;
        }
        
        return;
        label_3:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InsertEdgeIntoAEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge startEdge)
    {
        var val_3;
        InternalClipper.TEdge val_4;
        InternalClipper.TEdge val_6;
        val_3 = this;
        val_4 = startEdge;
        if(X8 == 0)
        {
            goto label_0;
        }
        
        if(val_4 != null)
        {
            goto label_10;
        }
        
        if((this.E2InsertsBeforeE1(e1:  X8, e2:  edge)) == false)
        {
            goto label_12;
        }
        
        if(edge == null)
        {
            goto label_3;
        }
        
        edge.PrevInAEL = 0;
        goto label_4;
        label_0:
        if(edge != null)
        {
                edge.PrevInAEL = 0;
        }
        else
        {
                mem[144] = 0;
        }
        
        edge.NextInAEL = 0;
        goto label_9;
        label_3:
        mem[144] = 0;
        label_4:
        edge.NextInAEL = val_4;
        startEdge.PrevInAEL = edge;
        goto label_9;
        label_12:
        label_10:
        val_3 = val_4;
        val_6 = startEdge.NextInAEL;
        if(val_6 == null)
        {
            goto label_11;
        }
        
        if((this.E2InsertsBeforeE1(e1:  val_6, e2:  edge)) == false)
        {
            goto label_12;
        }
        
        val_6 = mem[startEdge + 136];
        val_6 = startEdge + 136;
        label_11:
        edge.NextInAEL = val_6;
        if((startEdge + 136) != 0)
        {
                mem2[0] = edge;
        }
        
        edge.PrevInAEL = val_4;
        label_9:
        mem2[0] = edge;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool E2InsertsBeforeE1(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e2)
    {
        TEdge val_5 = e2;
        if(e2.Curr == e1.Curr)
        {
                if(e1 <= e1.Curr)
        {
                return (bool)(e1.Top > (InternalClipper.Clipper.TopX(edge:  val_5 = e2, currentY:  e1.Curr))) ? 1 : 0;
        }
        
            val_5 = e2.Top;
            long val_1 = InternalClipper.Clipper.TopX(edge:  e1, currentY:  e1);
        }
        
        var val_2 = (e2.Curr < e1.Curr) ? 1 : 0;
        return (bool)(e1.Top > (InternalClipper.Clipper.TopX(edge:  val_5, currentY:  e1.Curr))) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsEvenOddFillType(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge)
    {
        return (bool)(((edge.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType) == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsEvenOddAltFillType(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge)
    {
        return (bool)(((edge.PolyTyp == 0) ? this.m_ClipFillType : this.m_SubjFillType) == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsContributing(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge)
    {
        int val_10;
        var val_11;
        var val_1 = (edge.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType;
        var val_2 = (edge.PolyTyp == 0) ? this.m_ClipFillType : this.m_SubjFillType;
        if(val_1 == 2)
        {
            goto label_2;
        }
        
        if(val_1 == 1)
        {
            goto label_3;
        }
        
        if(val_1 != 0)
        {
            goto label_4;
        }
        
        if(edge.WindDelta != 0)
        {
            goto label_15;
        }
        
        label_2:
        val_10 = edge.WindCnt;
        goto label_6;
        label_3:
        label_6:
        if(((edge.WindCnt < 0) ? (-edge.WindCnt) : edge.WindCnt) != 1)
        {
            goto label_9;
        }
        
        label_15:
        if(this.m_ClipType > 3)
        {
            goto label_10;
        }
        
        var val_8 = 52955776 + (this.m_ClipType) << 2;
        val_8 = val_8 + 52955776;
        goto (52955776 + (this.m_ClipType) << 2 + 52955776);
        label_4:
        if(edge.WindCnt == 1)
        {
            goto label_15;
        }
        
        label_9:
        val_11 = 0;
        return (bool);
        label_10:
        val_11 = 1;
        return (bool);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetWindingCount(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge)
    {
        InternalClipper.PolyType val_12;
        int val_13;
        int val_14;
        InternalClipper.TEdge val_15;
        int val_16;
        var val_17;
        if(edge.PrevInAEL == null)
        {
            goto label_2;
        }
        
        val_12 = edge;
        label_5:
        if(edge.PrevInAEL.PolyTyp != edge.PolyTyp)
        {
            goto label_3;
        }
        
        int val_12 = edge.PrevInAEL.WindDelta;
        if(val_12 != 0)
        {
            goto label_4;
        }
        
        label_3:
        if(edge.PrevInAEL.PrevInAEL != null)
        {
            goto label_5;
        }
        
        label_2:
        val_13 = edge.WindDelta;
        val_12 = edge.PolyTyp;
        val_14 = 0;
        edge.WindCnt = (((val_12 == 0) ? this.m_SubjFillType : this.m_ClipFillType) != 3) ? (-0) : 0;
        edge.WindCnt2 = 0;
        val_15 = 1152921519906982120;
        goto label_7;
        label_4:
        if(edge.WindDelta == 0)
        {
                if(this.m_ClipType != 1)
        {
            goto label_9;
        }
        
        }
        
        if(((edge.PrevInAEL.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType) == 0)
        {
            goto label_10;
        }
        
        if(((val_12 * edge.PrevInAEL.WindCnt) & 2147483648) != 0)
        {
            goto label_11;
        }
        
        if(edge.WindDelta == 0)
        {
            goto label_12;
        }
        
        val_12 = edge.WindDelta * val_12;
        val_12 = edge.WindDelta & (~(val_12 >> 31));
        val_16 = edge.PrevInAEL.WindCnt + val_12;
        goto label_25;
        label_10:
        if(edge.WindDelta != 0)
        {
            goto label_14;
        }
        
        val_17 = 1;
        goto label_16;
        label_17:
        if(edge.PrevInAEL.PolyTyp == edge.PrevInAEL.PolyTyp)
        {
                val_17 = val_17 ^ ((edge.PrevInAEL.WindDelta != 0) ? 1 : 0);
        }
        
        label_16:
        if(edge.PrevInAEL.PrevInAEL != null)
        {
            goto label_17;
        }
        
        int val_6 = (~val_17) & 1;
        if(edge == null)
        {
            goto label_18;
        }
        
        label_14:
        edge.WindCnt = val_6;
        goto label_19;
        label_9:
        val_16 = 1;
        goto label_25;
        label_11:
        if(((edge.PrevInAEL.WindCnt < 0) ? (-edge.PrevInAEL.WindCnt) : edge.PrevInAEL.WindCnt) >= 2)
        {
            goto label_23;
        }
        
        var val_8 = (edge.WindDelta != 0) ? edge.WindDelta : (0 + 1);
        goto label_25;
        label_12:
        int val_9 = edge.PrevInAEL.WindCnt >> 31;
        val_9 = val_9 | 1;
        val_16 = val_9 + edge.PrevInAEL.WindCnt;
        goto label_25;
        label_23:
        int val_14 = edge.WindDelta;
        int val_13 = edge.PrevInAEL.WindDelta;
        val_13 = val_14 * val_13;
        val_14 = val_14 & (~(val_13 >> 31));
        val_16 = edge.PrevInAEL.WindCnt + val_14;
        label_25:
        edge.WindCnt = val_16;
        label_19:
        val_14 = edge.PrevInAEL.WindCnt2;
        label_39:
        val_15 = edge.PrevInAEL.NextInAEL;
        edge.WindCnt2 = val_14;
        label_7:
        if((((edge + 88) == 0) ? this.m_ClipFillType : this.m_SubjFillType) == 0)
        {
            goto label_26;
        }
        
        if(mem[edge.PrevInAEL.NextInAEL] == edge)
        {
                return;
        }
        
        val_12 = 96;
        goto label_28;
        label_31:
        val_14 = edge.WindCnt2;
        label_28:
        if(mem[edge.PrevInAEL.NextInAEL] != 0)
        {
                int val_15 = mem[edge.PrevInAEL.NextInAEL] + 96;
            val_15 = val_15 + val_14;
            edge.WindCnt2 = val_15;
        }
        else
        {
                int val_16 = 62590012;
            val_16 = val_16 + val_14;
            edge.WindCnt2 = val_16;
        }
        
        if((mem[edge.PrevInAEL.NextInAEL] + 136) != edge)
        {
            goto label_31;
        }
        
        return;
        label_26:
        if(mem[edge.PrevInAEL.NextInAEL] == edge)
        {
                return;
        }
        
        do
        {
            if((mem[edge.PrevInAEL.NextInAEL] + 96) != 0)
        {
                if(edge != null)
        {
                val_12 = edge.WindCnt2;
        }
        else
        {
                val_12 = edge.WindCnt2;
        }
        
            edge.WindCnt2 = (val_12 == 0) ? 1 : 0;
        }
        
        }
        while((mem[edge.PrevInAEL.NextInAEL] + 136) != edge);
        
        return;
        label_18:
        edge.WindCnt = val_6;
        goto label_39;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddEdgeToSEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge)
    {
        if(this.m_SortedEdges == null)
        {
            goto label_0;
        }
        
        if(edge == null)
        {
            goto label_1;
        }
        
        edge.NextInSEL = this.m_SortedEdges;
        goto label_2;
        label_0:
        this.m_SortedEdges = edge;
        if(edge == null)
        {
            goto label_3;
        }
        
        edge.PrevInSEL = 0;
        goto label_4;
        label_1:
        mem[152] = this.m_SortedEdges;
        label_2:
        edge.PrevInSEL = 0;
        this.m_SortedEdges.PrevInSEL = edge;
        this.m_SortedEdges = edge;
        return;
        label_3:
        mem[160] = 0;
        label_4:
        edge.NextInSEL = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool PopEdgeFromSEL(out Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        e = this.m_SortedEdges;
        if(this.m_SortedEdges == null)
        {
                return false;
        }
        
        this.m_SortedEdges = this.m_SortedEdges.NextInSEL;
        if(this.m_SortedEdges.NextInSEL != null)
        {
                this.m_SortedEdges.NextInSEL.PrevInSEL = 0;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void CopyAELToSEL()
    {
        this.m_SortedEdges = null;
        if(X8 == 0)
        {
                return;
        }
        
        do
        {
            mem2[0] = X8 + 136;
            mem2[0] = X8 + 136 + 8;
        }
        while((X8 + 136) != 0);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SwapPositionsInSEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge2)
    {
        var val_1;
        if(edge1.NextInSEL == null)
        {
                if(edge1.PrevInSEL == null)
        {
                return;
        }
        
        }
        
        if(edge2.NextInSEL == null)
        {
                if(edge2.PrevInSEL == null)
        {
                return;
        }
        
        }
        
        if(edge1.NextInSEL == edge2)
        {
            goto label_6;
        }
        
        if(edge2.NextInSEL == edge1)
        {
            goto label_7;
        }
        
        val_1 = edge1;
        mem2[0] = edge2.NextInSEL;
        if(edge2.NextInSEL != null)
        {
                edge2.NextInSEL.PrevInSEL = edge1;
        }
        
        mem2[0] = edge2.PrevInSEL;
        if(edge2.PrevInSEL != null)
        {
                edge2.PrevInSEL.NextInSEL = edge1;
        }
        
        edge2.NextInSEL = edge1.NextInSEL;
        if(edge1.NextInSEL != null)
        {
                edge1.NextInSEL.PrevInSEL = edge2;
        }
        
        edge2.PrevInSEL = edge1.PrevInSEL;
        if(edge1.PrevInSEL == null)
        {
            goto label_12;
        }
        
        edge1.PrevInSEL.NextInSEL = edge2;
        goto label_12;
        label_6:
        if(edge2.NextInSEL != null)
        {
                edge2.NextInSEL.PrevInSEL = edge1;
        }
        
        if(edge1.PrevInSEL != null)
        {
                edge1.PrevInSEL.NextInSEL = edge2;
        }
        
        edge2.NextInSEL = edge1;
        edge2.PrevInSEL = edge1.PrevInSEL;
        edge1.NextInSEL = edge2.NextInSEL;
        edge1.PrevInSEL = edge2;
        goto label_15;
        label_7:
        if(edge1.NextInSEL != null)
        {
                edge1.NextInSEL.PrevInSEL = edge2;
        }
        
        if(edge2.PrevInSEL != null)
        {
                edge2.PrevInSEL.NextInSEL = edge1;
        }
        
        val_1 = edge1;
        edge1.PrevInSEL = edge2.PrevInSEL;
        edge1.NextInSEL = edge2;
        edge2.NextInSEL = edge1.NextInSEL;
        edge2.PrevInSEL = edge1;
        label_12:
        if((edge1 + 160) == 0)
        {
            goto label_18;
        }
        
        label_15:
        if(edge2.PrevInSEL != null)
        {
                return;
        }
        
        this.m_SortedEdges = edge2;
        return;
        label_18:
        this.m_SortedEdges = edge1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddLocalMaxPoly(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt)
    {
        var val_3;
        var val_4;
        int val_5;
        int val_6;
        TEdge val_7;
        TEdge val_8;
        InternalClipper.OutPt val_1 = this.AddOutPt(e:  e1, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        if(e2.WindDelta == 0)
        {
            goto label_1;
        }
        
        if(e1 == null)
        {
            goto label_2;
        }
        
        label_5:
        val_3 = e1;
        val_4 = e2;
        val_5 = e1.OutIdx;
        val_6 = e2.OutIdx;
        if(val_5 == val_6)
        {
            goto label_3;
        }
        
        goto label_4;
        label_1:
        InternalClipper.OutPt val_2 = this.AddOutPt(e:  e2, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        if(e1 != null)
        {
            goto label_5;
        }
        
        label_2:
        val_3 = 108;
        val_4 = e2;
        if(0 != e2.OutIdx)
        {
            goto label_6;
        }
        
        label_3:
        mem[108] = 0;
        mem2[0] = 0;
        return;
        label_6:
        val_5 = mem[108];
        val_6 = mem[e2 + 108];
        val_6 = e2 + 108;
        label_4:
        if(val_5 < val_6)
        {
                val_7 = e1;
            val_8 = e2;
        }
        else
        {
                val_7 = e2;
            val_8 = e1;
        }
        
        this.AppendPolygon(e1:  val_7, e2:  val_8);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt AddLocalMinPoly(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt)
    {
        TEdge val_13;
        InternalClipper.OutPt val_14;
        int val_15;
        val_13 = e1;
        if((InternalClipper.ClipperBase.IsHorizontal(e:  e2)) == false)
        {
            goto label_0;
        }
        
        val_14 = this.AddOutPt(e:  val_13, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        val_15 = e1.OutIdx;
        if(e2 != null)
        {
            goto label_2;
        }
        
        mem[108] = val_15;
        e1.Side = 0;
        goto label_3;
        label_0:
        if(e1.Dx <= e2.Dx)
        {
            goto label_6;
        }
        
        val_15 = e1.OutIdx;
        val_14 = this.AddOutPt(e:  val_13, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        label_2:
        e2.OutIdx = val_15;
        e1.Side = 0;
        label_3:
        e2.Side = 1;
        var val_4 = (e1.PrevInAEL == e2) ? e2 : (val_13);
        goto label_7;
        label_6:
        e1.Side = 1;
        val_14 = this.AddOutPt(e:  e2, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        e1.OutIdx = e2.OutIdx;
        e2.Side = 0;
        var val_6 = (e2.PrevInAEL == val_13) ? (val_13) : e2;
        val_13 = e2;
        label_7:
        if((e2.PrevInAEL == val_13 ? e1 : e2 + 144) == 0)
        {
                return val_14;
        }
        
        var val_13 = e2.PrevInAEL == val_13 ? e1 : e2 + 144 + 108;
        val_13 = val_13 >> 31;
        if(val_13 != 0)
        {
                return val_14;
        }
        
        val_15 = InternalClipper.Clipper.TopX(edge:  e2.PrevInAEL == val_13 ? e1 : e2 + 144, currentY:  pt.Y);
        if(val_15 != (InternalClipper.Clipper.TopX(edge:  val_13, currentY:  pt.Y)))
        {
                return val_14;
        }
        
        if(e2.WindDelta == 0)
        {
                return val_14;
        }
        
        if((e2.PrevInAEL == val_13 ? e1 : e2 + 144 + 96) == 0)
        {
                return val_14;
        }
        
        InternalClipper.IntPoint val_9 = new InternalClipper.IntPoint(X:  val_15, Y:  pt.Y);
        InternalClipper.IntPoint val_10 = new InternalClipper.IntPoint(X:  val_15, Y:  pt.Y);
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = val_9.X, Y = val_9.Y}, pt2:  new IntPoint() {X = e2.PrevInAEL == val_13 ? e1 : e2 + 144 + 48, Y = e2.PrevInAEL == val_13 ? e1 : e2 + 144 + 48 + 8}, pt3:  new IntPoint() {X = val_10.X, Y = val_10.Y}, pt4:  new IntPoint() {X = e2.Top}, UseFullRange:  e2.PrevInAEL == val_13 ? e1 : e2 + 144 + 96)) == false)
        {
                return val_14;
        }
        
        this.AddJoin(Op1:  val_14, Op2:  this.AddOutPt(e:  e2.PrevInAEL == val_13 ? e1 : e2 + 144, pt:  new IntPoint() {X = pt.X, Y = pt.Y}), OffPt:  new IntPoint() {X = e2.Top, Y = val_10.X});
        return val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt AddOutPt(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt)
    {
        long val_8;
        var val_9;
        OutPt val_10;
        val_8 = pt.Y;
        val_9 = this;
        if((e.OutIdx & 2147483648) != 0)
        {
            goto label_2;
        }
        
        val_9 = this.Item[e.OutIdx];
        val_10 = val_1.Pts;
        if(e.Side == 0)
        {
            goto label_5;
        }
        
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = pt.X, Y = val_8}, b:  new IntPoint() {X = val_1.Pts.Prev.Pt, Y = pt.Y})) == false)
        {
            goto label_8;
        }
        
        val_10 = val_1.Pts.Prev;
        return (InternalClipper.OutPt)val_10;
        label_2:
        OutRec val_3 = this.CreateOutRec();
        val_3.IsOpen = (e.WindDelta == 0) ? 1 : 0;
        InternalClipper.OutPt val_5 = null;
        val_10 = val_5;
        val_5 = new InternalClipper.OutPt();
        if(val_3 == null)
        {
            goto label_11;
        }
        
        val_3.Pts = val_10;
        goto label_12;
        label_5:
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = pt.X, Y = val_8}, b:  new IntPoint() {X = val_1.Pts.Pt, Y = pt.Y})) == true)
        {
                return (InternalClipper.OutPt)val_10;
        }
        
        label_8:
        InternalClipper.OutPt val_7 = new InternalClipper.OutPt();
        if(val_7 == null)
        {
            goto label_15;
        }
        
        .Idx = val_1.Idx;
        .Pt = pt.X;
        mem[1152921519908154288] = val_8;
        goto label_16;
        label_11:
        mem[32] = val_10;
        label_12:
        if(val_10 != null)
        {
                .Idx = val_3.Idx;
            .Pt = pt.X;
            mem[1152921519908150192] = val_8;
            .Next = val_10;
        }
        else
        {
                mem[16] = val_3.Idx;
            mem[24] = pt.X;
            mem[32] = val_8;
            mem[40] = 0;
        }
        
        .Prev = val_10;
        if(val_3.IsOpen != true)
        {
                this.SetHoleState(e:  e, outRec:  val_3);
        }
        
        e.OutIdx = val_3.Idx;
        return (InternalClipper.OutPt)val_10;
        label_15:
        mem[16] = val_1.Idx;
        mem[24] = pt.X;
        mem[32] = val_8;
        label_16:
        .Next = val_10;
        val_8 = val_1.Pts.Prev;
        .Prev = val_8;
        val_1.Pts.Prev.Next = val_7;
        val_1.Pts.Prev = val_7;
        val_10 = val_7;
        if(e.Side != 0)
        {
                return (InternalClipper.OutPt)val_10;
        }
        
        val_10 = val_7;
        val_1.Pts = val_7;
        return (InternalClipper.OutPt)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt GetLastOutPt(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        OutPt val_2;
        OutRec val_1 = this.Item[e.OutIdx];
        val_2 = val_1.Pts;
        if(e.Side == 0)
        {
                return (InternalClipper.OutPt)val_2;
        }
        
        val_2 = val_1.Pts.Prev;
        return (InternalClipper.OutPt)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void SwapPoints(ref Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, ref Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2)
    {
        InternalClipper.IntPoint val_1 = new InternalClipper.IntPoint(X:  pt1.X, Y:  pt1.Y);
        pt1.X = pt2.X;
        pt2.X = val_1.X;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
    {
        long val_6;
        var val_7;
        long val_2 = seg1b;
        long val_1 = seg1a;
        long val_4 = seg2b;
        long val_3 = seg2a;
        if(seg1a > seg1b)
        {
                this.Swap(val1: ref  val_1, val2: ref  val_2);
            val_6 = val_4;
        }
        
        if(val_3 > val_6)
        {
                this.Swap(val1: ref  val_3, val2: ref  val_4);
            val_6 = val_4;
        }
        
        if(val_1 < val_6)
        {
                var val_5 = (val_3 < val_2) ? 1 : 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetHoleState(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec)
    {
        var val_4;
        var val_5;
        bool val_6;
        val_4 = e;
        if(e.PrevInAEL == null)
        {
            goto label_10;
        }
        
        do
        {
            label_8:
            if((e.PrevInAEL.OutIdx & 2147483648) == 0)
        {
                if(e.PrevInAEL.WindDelta != 0)
        {
            goto label_4;
        }
        
        }
        
        }
        while(e.PrevInAEL.PrevInAEL != null);
        
        goto label_6;
        label_4:
        val_5 = e.PrevInAEL;
        if(0 != 0)
        {
                var val_1 = (0 == e.PrevInAEL.OutIdx) ? 0 : 0;
        }
        
        if(e.PrevInAEL.PrevInAEL != null)
        {
            goto label_8;
        }
        
        goto label_9;
        label_6:
        val_5 = 0;
        label_9:
        if(val_5 == 0)
        {
            goto label_10;
        }
        
        val_4 = 0;
        OutRec val_2 = this.Item[0];
        if(outRec == null)
        {
            goto label_12;
        }
        
        outRec.FirstLeft = val_2;
        if(val_2 != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        val_6 = val_2.IsHole ^ 1;
        goto label_17;
        label_10:
        if(outRec != null)
        {
                val_6 = 0;
            outRec.FirstLeft = 0;
        }
        else
        {
                mem[24] = 0;
            val_6 = false;
        }
        
        label_17:
        outRec.IsHole = val_6;
        return;
        label_12:
        mem[24] = val_2;
        if(mem[24] != 0)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double GetDx(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2)
    {
        if()
        {
                return -3.4E+38;
        }
        
        double val_3 = (double)pt2.X - pt1.X;
        val_3 = val_3 / ((double)pt2.Y - pt1.Y);
        return (double)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool FirstIsBottomPt(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt btmPt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt btmPt2)
    {
        double val_18;
        double val_19;
        double val_20;
        double val_21;
        var val_22;
        bool val_13 = true;
        label_5:
        if(btmPt1.Prev != btmPt1)
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = btmPt1.Prev.Pt, Y = X22}, b:  new IntPoint() {X = btmPt1.Pt})) == true)
        {
            goto label_5;
        }
        
        }
        
        val_13 = X9 - val_13;
        if(btmPt1.Prev == btmPt1)
        {
                val_18 = -3.4E+38;
        }
        else
        {
                InternalClipper.IntPoint val_14 = btmPt1.Prev.Pt;
            val_14 = val_14 - btmPt1.Pt;
            val_18 = (double)val_14 / (double)val_13;
        }
        
        label_12:
        if(btmPt1.Next != btmPt1)
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = btmPt1.Next.Pt, Y = X22}, b:  new IntPoint() {X = btmPt1.Pt})) == true)
        {
            goto label_12;
        }
        
        }
        
        if(btmPt1.Next == btmPt1)
        {
                val_19 = -3.4E+38;
        }
        else
        {
                InternalClipper.IntPoint val_15 = btmPt1.Next.Pt;
            val_15 = val_15 - btmPt1.Pt;
            val_19 = (double)val_15 / ((double)((btmPt1.Prev.Pt - btmPt1.Pt) - System.Math.__il2cppRuntimeField_cctor_finished));
        }
        
        double val_16 = System.Math.Abs(val_18);
        double val_17 = System.Math.Abs(val_19);
        label_21:
        if(btmPt2.Prev != btmPt2)
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = btmPt2.Prev.Pt, Y = X22}, b:  new IntPoint() {X = btmPt2.Pt})) == true)
        {
            goto label_21;
        }
        
        }
        
        if(btmPt2.Prev == btmPt2)
        {
                val_20 = -3.4E+38;
        }
        else
        {
                InternalClipper.IntPoint val_18 = btmPt2.Prev.Pt;
            val_18 = val_18 - btmPt2.Pt;
            val_20 = (double)val_18 / ((double)((btmPt1.Next.Pt - btmPt1.Pt) - System.Math.__il2cppRuntimeField_cctor_finished));
        }
        
        label_28:
        if(btmPt2.Next != btmPt2)
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = btmPt2.Next.Pt, Y = X22}, b:  new IntPoint() {X = btmPt2.Pt})) == true)
        {
            goto label_28;
        }
        
        }
        
        if(btmPt2.Next == btmPt2)
        {
                val_21 = -3.4E+38;
        }
        else
        {
                InternalClipper.IntPoint val_19 = btmPt2.Next.Pt;
            val_19 = val_19 - btmPt2.Pt;
            val_21 = (double)val_19 / ((double)((btmPt2.Prev.Pt - btmPt2.Pt) - System.Math.__il2cppRuntimeField_cctor_finished));
        }
        
        double val_20 = System.Math.Abs(val_20);
        double val_21 = System.Math.Abs(val_21);
        if((System.Math.Max(val1:  val_16, val2:  val_17)) == (System.Math.Max(val1:  val_20, val2:  val_21)))
        {
                if((System.Math.Min(val1:  val_16, val2:  val_17)) == (System.Math.Min(val1:  val_20, val2:  val_21)))
        {
                var val_10 = ((this.Area(op:  btmPt1)) > 0f) ? 1 : 0;
            return (bool)val_22;
        }
        
        }
        
        if((val_16 >= val_20) && (val_16 >= val_21))
        {
                val_22 = 1;
            return (bool)val_22;
        }
        
        val_22 = ((val_17 >= val_20) ? 1 : 0) & ((val_17 >= val_21) ? 1 : 0);
        return (bool)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt GetBottomPt(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt pp)
    {
        InternalClipper.OutPt val_5 = pp;
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_11:
        label_10:
        val_5 = X8;
        label_8:
        if((X8 + 32) > X8)
        {
            goto label_6;
        }
        
        if(((X8 + 32) != X8) || ((X8 + 24) > pp.Pt))
        {
            goto label_5;
        }
        
        if((X8 + 24) < pp.Pt)
        {
            goto label_6;
        }
        
        if((X8 + 40) != val_5)
        {
            goto label_7;
        }
        
        label_5:
        if((X8 + 40) != val_5)
        {
            goto label_8;
        }
        
        goto label_9;
        label_7:
        var val_1 = ((X8 + 48) == val_5) ? 0 : (val_5);
        goto label_10;
        label_6:
        if(pp.Next != val_5)
        {
            goto label_11;
        }
        
        return (InternalClipper.OutPt)val_5;
        label_9:
        if((0 != 0) && (0 != val_5))
        {
                do
        {
            var val_3 = ((this.FirstIsBottomPt(btmPt1:  val_5 = pp, btmPt2:  0)) != true) ? (val_5) : 0;
            do
        {
        
        }
        while((InternalClipper.IntPoint.op_Inequality(a:  new IntPoint() {X = 53093924, Y = 53093992}, b:  new IntPoint() {X = val_2 != true ? pp : 0 + 24, Y = val_2 != true ? pp : 0 + 24 + 8})) == true);
        
        }
        while(69077560 != val_5);
        
            return (InternalClipper.OutPt)val_5;
        }
        
        val_5 = val_5;
        return (InternalClipper.OutPt)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec GetLowermostRec(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec2)
    {
        var val_5;
        OutPt val_6;
        val_5 = outRec1;
        if(outRec1.BottomPt == null)
        {
            goto label_1;
        }
        
        label_10:
        val_6 = outRec2.BottomPt;
        if(val_6 == null)
        {
                val_6 = this.GetBottomPt(pp:  outRec2.Pts);
            outRec2.BottomPt = val_6;
        }
        
        if(X24 > outRec1.BottomPt)
        {
                return (OutRec)val_5;
        }
        
        if(X9 >= outRec1.BottomPt)
        {
            goto label_7;
        }
        
        label_13:
        val_5 = outRec2;
        return (OutRec)val_5;
        label_1:
        outRec1.BottomPt = this.GetBottomPt(pp:  outRec1.Pts);
        if(outRec2 != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_7:
        if(outRec1.BottomPt.Pt < val_1.Pt)
        {
                return (OutRec)val_5;
        }
        
        if((outRec1.BottomPt.Pt > val_1.Pt) || (outRec1.BottomPt.Next == outRec1.BottomPt))
        {
            goto label_13;
        }
        
        if(val_1.Next == val_6)
        {
                return (OutRec)val_5;
        }
        
        var val_4 = ((this.FirstIsBottomPt(btmPt1:  outRec1.BottomPt, btmPt2:  val_6)) != true) ? (val_5) : outRec2;
        return (OutRec)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool OutRec1RightOfOutRec2(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec2)
    {
        var val_1;
        label_2:
        if(outRec1.FirstLeft == outRec2)
        {
            goto label_1;
        }
        
        if(outRec1.FirstLeft != null)
        {
            goto label_2;
        }
        
        val_1 = 0;
        return (bool)val_1;
        label_1:
        val_1 = 1;
        return (bool)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec GetOutRec(int idx)
    {
        int val_3 = idx;
        if(11235 != 0)
        {
            goto label_3;
        }
        
        goto label_3;
        label_6:
        val_3 = mem[idx + 16];
        val_3 = idx + 16;
        label_3:
        OutRec val_1 = 0.Item[val_3];
        if(val_1 != Item[val_1.Idx])
        {
            goto label_6;
        }
        
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AppendPolygon(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e2)
    {
        OutRec val_1 = X22.Item[e1.OutIdx];
        OutRec val_2 = e1.OutIdx.Item[e2.OutIdx];
        label_7:
        if(val_1.FirstLeft == val_2)
        {
            goto label_6;
        }
        
        if(val_1.FirstLeft != null)
        {
            goto label_7;
        }
        
        label_10:
        if(val_2.FirstLeft == val_1)
        {
            goto label_9;
        }
        
        if(val_2.FirstLeft != null)
        {
            goto label_10;
        }
        
        OutRec val_3 = this.GetLowermostRec(outRec1:  val_1, outRec2:  val_2);
        if(val_1 != null)
        {
            goto label_31;
        }
        
        goto label_32;
        label_6:
        if(val_1 != null)
        {
            goto label_31;
        }
        
        label_32:
        label_31:
        if(e1.Side == 0)
        {
            goto label_19;
        }
        
        if(e2.Side != 1)
        {
            goto label_20;
        }
        
        this.ReversePolyPtLinks(pp:  val_2.Pts);
        val_1.Pts.Prev.Next = val_2.Pts.Prev;
        val_2.Pts.Prev.Prev = val_1.Pts.Prev;
        val_2.Pts.Next = val_1.Pts;
        val_1.Pts.Prev = val_2.Pts;
        goto label_30;
        label_19:
        if(e2.Side == 0)
        {
            goto label_24;
        }
        
        val_2.Pts.Prev.Next = val_1.Pts;
        val_1.Pts.Prev = val_2.Pts.Prev;
        val_2.Pts.Prev = val_1.Pts.Prev;
        val_1.Pts.Prev.Next = val_2.Pts;
        val_1.Pts = val_2.Pts;
        goto label_30;
        label_20:
        val_1.Pts.Prev.Next = val_2.Pts;
        val_2.Pts.Prev = val_1.Pts.Prev;
        val_1.Pts.Prev = val_2.Pts.Prev;
        val_2.Pts.Prev.Next = val_1.Pts;
        goto label_30;
        label_9:
        if(val_1 != null)
        {
            goto label_31;
        }
        
        goto label_32;
        label_24:
        this.ReversePolyPtLinks(pp:  val_2.Pts);
        val_2.Pts.Next = val_1.Pts;
        val_1.Pts.Prev = val_2.Pts;
        val_1.Pts.Prev.Next = val_2.Pts.Prev;
        val_2.Pts.Prev.Prev = val_1.Pts.Prev;
        val_1.Pts = val_2.Pts.Prev;
        label_30:
        val_1.BottomPt = 0;
        if(val_1 == val_2)
        {
                if(val_2.FirstLeft != val_1)
        {
                val_1.FirstLeft = val_2.FirstLeft;
        }
        
            val_1.IsHole = val_2.IsHole;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        val_2.FirstLeft = val_1;
        e1.OutIdx = 0;
        e2.OutIdx = 0;
        if(mem[1152921519909726856] == 0)
        {
            goto label_37;
        }
        
        label_39:
        if((mem[1152921519909726856] + 108) == e2.OutIdx)
        {
            goto label_38;
        }
        
        if((mem[1152921519909726856] + 136) != 0)
        {
            goto label_39;
        }
        
        label_37:
        if(val_1 != null)
        {
            goto label_43;
        }
        
        label_44:
        label_43:
        val_2.Idx = val_1.Idx;
        return;
        label_38:
        mem2[0] = e1.OutIdx;
        mem2[0] = e1.Side;
        if(val_1 != null)
        {
            goto label_43;
        }
        
        goto label_44;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ReversePolyPtLinks(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt pp)
    {
        var val_1;
        var val_2;
        if(pp == null)
        {
                return;
        }
        
        do
        {
            if(pp != null)
        {
                val_1 = pp + 48;
            mem2[0] = pp.Prev;
            val_2 = pp + 48 + -8;
        }
        else
        {
                val_2 = 69077560;
            mem[40] = 0;
            val_1 = 48;
        }
        
            mem[48] = val_2;
        }
        while(val_2 != pp);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void SwapSides(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge2)
    {
        TEdge val_1 = edge2;
        if(val_1 != null)
        {
                edge1.Side = edge2.Side;
        }
        else
        {
                val_1 = 92;
            edge1.Side = 0;
        }
        
        mem[92] = edge1.Side;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void SwapPolyIndexes(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge2)
    {
        TEdge val_1 = edge2;
        if(val_1 != null)
        {
                edge1.OutIdx = edge2.OutIdx;
        }
        else
        {
                val_1 = 108;
            edge1.OutIdx = 0;
        }
        
        mem[108] = edge1.OutIdx;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void IntersectEdges(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt)
    {
        int val_38;
        var val_39;
        var val_40;
        int val_41;
        int val_42;
        TEdge val_43;
        int val_44;
        int val_45;
        val_38 = e1.OutIdx;
        int val_38 = e2.WindDelta;
        if(e1.WindDelta == 0)
        {
            goto label_3;
        }
        
        if(val_38 == 0)
        {
            goto label_4;
        }
        
        if(e1.PolyTyp != e2.PolyTyp)
        {
            goto label_5;
        }
        
        if(((e1.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType) == 0)
        {
            goto label_6;
        }
        
        val_38 = val_38 + ((val_38 == e1.WindCnt) ? 0 : e1.WindCnt);
        e1.WindCnt = val_38;
        int val_39 = e2.WindCnt;
        val_39 = val_39 - e1.WindDelta;
        if(val_38 != e1.WindCnt)
        {
            goto label_7;
        }
        
        e2.WindCnt = -e1.WindDelta;
        goto label_33;
        label_3:
        if(val_38 == 0)
        {
                return;
        }
        
        label_4:
        if(e1.PolyTyp != e2.PolyTyp)
        {
            goto label_10;
        }
        
        if(e1.WindDelta == val_38)
        {
                return;
        }
        
        if(this.m_ClipType != 1)
        {
                return;
        }
        
        if(e1.WindDelta == 0)
        {
            goto label_13;
        }
        
        if((val_38 & 2147483648) == 0)
        {
            goto label_26;
        }
        
        return;
        label_10:
        if(e1.WindDelta == 0)
        {
                if(((e2.WindCnt < 0) ? (-e2.WindCnt) : e2.WindCnt) == 1)
        {
                if((this.m_ClipType != 1) || (e2.WindCnt2 == 0))
        {
            goto label_21;
        }
        
        }
        
        }
        
        if(e2.WindDelta != 0)
        {
                return;
        }
        
        val_38 = e1.WindCnt;
        if(((val_38 < 0) ? (-val_38) : (val_38)) != 1)
        {
                return;
        }
        
        if(this.m_ClipType == 1)
        {
                if(e1.WindCnt2 != 0)
        {
                return;
        }
        
        }
        
        label_26:
        InternalClipper.OutPt val_5 = this.AddOutPt(e:  e2, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        if((e2.OutIdx & 2147483648) != 0)
        {
                return;
        }
        
        e2.OutIdx = 0;
        return;
        label_5:
        val_38 = val_38 + e1.WindCnt2;
        e1.WindCnt2 = (((e2.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType) == 0) ? ((e1.WindCnt2 == 0) ? 1 : 0) : (val_38);
        if(((e1.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType) == 0)
        {
            goto label_30;
        }
        
        val_39 = e2.WindCnt2 - e1.WindDelta;
        goto label_31;
        label_6:
        e1.WindCnt = e2.WindCnt;
        e2.WindCnt = e1.WindCnt;
        goto label_33;
        label_30:
        label_31:
        e2.WindCnt2 = (e2.WindCnt2 == 0) ? 1 : 0;
        goto label_33;
        label_7:
        e2.WindCnt = val_39;
        label_33:
        var val_11 = (e1.PolyTyp == 0) ? this.m_ClipFillType : this.m_SubjFillType;
        var val_12 = (e1.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType;
        var val_14 = (e2.PolyTyp == 0) ? this.m_SubjFillType : this.m_ClipFillType;
        val_40 = mem[e2.PolyTyp == null ? this.m_ClipFillType : this.m_SubjFillType];
        val_40 = (e2.PolyTyp == 0) ? this.m_ClipFillType : this.m_SubjFillType;
        if(val_12 == 3)
        {
            goto label_34;
        }
        
        if(val_12 != 2)
        {
            goto label_35;
        }
        
        val_41 = e1.WindCnt;
        goto label_37;
        label_34:
        val_41 = -e1.WindCnt;
        goto label_37;
        label_35:
        val_40 = val_40;
        var val_15 = (e1.WindCnt < 0) ? (-e1.WindCnt) : e1.WindCnt;
        label_37:
        if(val_14 == 3)
        {
            goto label_40;
        }
        
        if(val_14 != 2)
        {
            goto label_41;
        }
        
        val_42 = e2.WindCnt;
        goto label_43;
        label_40:
        val_42 = -e2.WindCnt;
        goto label_43;
        label_41:
        var val_16 = (e2.WindCnt < 0) ? (-e2.WindCnt) : e2.WindCnt;
        label_43:
        int val_17 = val_38 >> 31;
        val_17 = val_17 ^ 1;
        val_17 = val_17 & (~(e2.OutIdx >> 31));
        if(val_17 == 0)
        {
            goto label_46;
        }
        
        if((val_16 | val_15) > 1)
        {
            goto label_49;
        }
        
        if(e1.PolyTyp != e2.PolyTyp)
        {
                if(this.m_ClipType != 3)
        {
            goto label_49;
        }
        
        }
        
        InternalClipper.OutPt val_19 = this.AddOutPt(e:  e1, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        label_54:
        val_43 = e2;
        goto label_50;
        label_49:
        this.AddLocalMaxPoly(e1:  e1, e2:  e2, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        return;
        label_46:
        if((val_38 & 2147483648) != 0)
        {
            goto label_51;
        }
        
        if(val_16 > 1)
        {
                return;
        }
        
        val_43 = e1;
        label_50:
        InternalClipper.OutPt val_20 = this.AddOutPt(e:  val_43, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        InternalClipper.Clipper.SwapSides(edge1:  e1, edge2:  e2);
        InternalClipper.Clipper.SwapPolyIndexes(edge1:  e1, edge2:  e2);
        return;
        label_51:
        if((e2.OutIdx & 2147483648) != 0)
        {
            goto label_53;
        }
        
        if(val_15 <= 1)
        {
            goto label_54;
        }
        
        return;
        label_13:
        if((e2.OutIdx & 2147483648) != 0)
        {
                return;
        }
        
        label_21:
        InternalClipper.OutPt val_21 = this.AddOutPt(e:  e1, pt:  new IntPoint() {X = pt.X, Y = pt.Y});
        if((val_38 & 2147483648) != 0)
        {
                return;
        }
        
        e1.OutIdx = 0;
        return;
        label_53:
        if((val_15 | val_16) > 1)
        {
                return;
        }
        
        if(val_11 == 3)
        {
            goto label_60;
        }
        
        if(val_11 != 2)
        {
            goto label_61;
        }
        
        val_44 = e1.WindCnt2;
        goto label_63;
        label_60:
        val_44 = -e1.WindCnt2;
        goto label_63;
        label_61:
        val_38 = val_40;
        var val_23 = (e1.WindCnt2 < 0) ? (-e1.WindCnt2) : e1.WindCnt2;
        label_63:
        if(val_38 == 3)
        {
            goto label_66;
        }
        
        if(val_38 != 2)
        {
            goto label_67;
        }
        
        val_45 = e2.WindCnt2;
        goto label_69;
        label_66:
        val_45 = -e2.WindCnt2;
        goto label_69;
        label_67:
        val_38 = e2.WindCnt2;
        label_69:
        if(e1.PolyTyp != e2.PolyTyp)
        {
            goto label_81;
        }
        
        if((val_15 != 1) || (val_16 != 1))
        {
            goto label_74;
        }
        
        if(this.m_ClipType > 3)
        {
                return;
        }
        
        var val_40 = 52955792 + (this.m_ClipType) << 2;
        val_40 = val_40 + 52955792;
        goto (52955792 + (this.m_ClipType) << 2 + 52955792);
        label_74:
        InternalClipper.Clipper.SwapSides(edge1:  e1, edge2:  e2);
        return;
        label_81:
        InternalClipper.OutPt val_37 = ???.AddLocalMinPoly(e1:  ???, e2:  ???, pt:  new IntPoint() {X = ???, Y = ???});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DeleteFromSEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        var val_3;
        InternalClipper.TEdge val_4;
        if(e != null)
        {
                val_3 = e;
            val_4 = e.PrevInSEL;
        }
        else
        {
                val_3 = 160;
            val_4 = 7375136;
        }
        
        if((e.NextInSEL | val_4) == null)
        {
                if(mem[this.m_SortedEdges] != e)
        {
                return;
        }
        
        }
        
        var val_3 = (val_4 != 0) ? (val_4 + 152) : this.m_SortedEdges;
        mem2[0] = e.NextInSEL;
        if(e.NextInSEL != null)
        {
                e.NextInSEL.PrevInSEL = val_4;
        }
        
        e.NextInSEL = 0;
        mem[160] = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ProcessHorizontals()
    {
        goto label_0;
        label_2:
        this.m_SortedEdges = X1 + 152;
        if((X1 + 152) != 0)
        {
                mem2[0] = 0;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        this.ProcessHorizontal(horzEdge:  null);
        label_0:
        if(this.m_SortedEdges != null)
        {
            goto label_2;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GetHorzDirection(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge HorzEdge, out Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Direction Dir, out long Left, out long Right)
    {
        long val_1;
        InternalClipper.Direction val_2;
        if(HorzEdge == null)
        {
            goto label_0;
        }
        
        val_1 = HorzEdge + 16;
        if(HorzEdge.Bot >= (HorzEdge + 16 + 32))
        {
            goto label_1;
        }
        
        Left = HorzEdge.Bot;
        val_2 = 1;
        goto label_5;
        label_0:
        if(11993091 >= 0)
        {
            goto label_3;
        }
        
        Left = 4306960387;
        val_2 = 1;
        val_1 = 48;
        goto label_5;
        label_1:
        val_2 = 0;
        Left = HorzEdge + 16 + 32;
        val_1 = HorzEdge + 16;
        goto label_5;
        label_3:
        Left = 15762873573703680;
        val_2 = 0;
        val_1 = 16;
        label_5:
        Right = val_1;
        Dir = val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ProcessHorizontal(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge horzEdge)
    {
        long val_34;
        TEdge val_36;
        TEdge val_37;
        InternalClipper.Maxima val_38;
        var val_39;
        InternalClipper.OutPt val_40;
        TEdge val_41;
        long val_42;
        TEdge val_43;
        long val_44;
        TEdge val_45;
        InternalClipper.IntPoint val_46;
        TEdge val_47;
        long val_48;
        long val_49;
        TEdge val_50;
        TEdge val_51;
        InternalClipper.IntPoint val_52;
        long val_53;
        var val_54;
        TEdge val_55;
        long val_56;
        long val_57;
        TEdge val_58;
        TEdge val_9 = horzEdge;
        InternalClipper.Direction val_1 = 0;
        long val_3 = 0;
        long val_2 = 0;
        this.GetHorzDirection(HorzEdge:  horzEdge, Dir: out  val_1, Left: out  val_2, Right: out  val_3);
        val_36 = val_9;
        label_3:
        val_37 = val_36;
        if((horzEdge + 128) == 0)
        {
            goto label_4;
        }
        
        if((InternalClipper.ClipperBase.IsHorizontal(e:  horzEdge + 128)) == true)
        {
            goto label_3;
        }
        
        if((horzEdge + 128) == 0)
        {
            goto label_4;
        }
        
        goto label_5;
        label_4:
        TEdge val_5 = horzEdge + 128.GetMaximaPair(e:  val_37);
        label_5:
        val_38 = this.m_Maxima;
        if(val_38 == null)
        {
            goto label_6;
        }
        
        if(val_1 != 1)
        {
            goto label_7;
        }
        
        label_10:
        if(this.m_Maxima.X > (horzEdge + 16))
        {
            goto label_9;
        }
        
        if(this.m_Maxima.Next != null)
        {
            goto label_10;
        }
        
        label_6:
        val_39 = 0;
        goto label_17;
        label_15:
        if((horzEdge + 16 + 16) >= (horzEdge + 16))
        {
            goto label_13;
        }
        
        val_38 = this.m_Maxima.Next.Next;
        label_7:
        if(this.m_Maxima.Next.Next.Next != null)
        {
            goto label_15;
        }
        
        label_13:
        var val_6 = (this.m_Maxima.Next.Next.X > (horzEdge + 48)) ? (val_38) : 0;
        goto label_17;
        label_9:
        label_17:
        val_40 = 0;
        goto label_19;
        label_74:
        if((InternalClipper.ClipperBase.IsHorizontal(e:  horzEdge + 128)) == false)
        {
            goto label_21;
        }
        
        this.UpdateEdgeIntoAEL(e: ref  val_9);
        this.AddOutPt(e:  val_9, pt:  new IntPoint() {X = horzEdge + 16, Y = horzEdge + 16 + 8}).GetHorzDirection(HorzEdge:  val_9, Dir: out  val_1, Left: out  val_2, Right: out  val_3);
        val_36 = val_9;
        label_19:
        val_41 = mem[val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136)];
        val_41 = (val_1 != 1) ? (val_36 + 144) : (val_36 + 136);
        if(val_41 == 0)
        {
            goto label_71;
        }
        
        label_70:
        if(((this.m_Maxima.X < (horzEdge + 48)) ? (val_38) : 0) == 0)
        {
            goto label_36;
        }
        
        if(val_1 != 1)
        {
            goto label_41;
        }
        
        label_34:
        if((this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 16) >= (val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32))
        {
            goto label_36;
        }
        
        if((horzEdge.WindDelta != 0) && (((horzEdge + 108) & 2147483648) == 0))
        {
                val_42 = mem[this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 16];
            val_42 = this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 16;
            InternalClipper.IntPoint val_14 = new InternalClipper.IntPoint(X:  val_42, Y:  horzEdge + 24);
            val_34 = val_14.Y;
            InternalClipper.OutPt val_15 = this.AddOutPt(e:  val_9, pt:  new IntPoint() {X = val_14.X, Y = val_34});
        }
        
        if((this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 24) != 0)
        {
            goto label_34;
        }
        
        goto label_36;
        label_41:
        if((this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 16) <= (val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32))
        {
            goto label_36;
        }
        
        if((horzEdge.WindDelta != 0) && (((horzEdge + 108) & 2147483648) == 0))
        {
                val_42 = mem[this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 16];
            val_42 = this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 16;
            InternalClipper.IntPoint val_16 = new InternalClipper.IntPoint(X:  val_42, Y:  horzEdge + 24);
            val_34 = val_16.Y;
            InternalClipper.OutPt val_17 = this.AddOutPt(e:  val_9, pt:  new IntPoint() {X = val_16.X, Y = val_34});
        }
        
        if((this.m_Maxima.X < horzEdge + 48 ? this.m_Maxima : 0 + 32) != 0)
        {
            goto label_41;
        }
        
        label_36:
        if(val_1 != 1)
        {
            goto label_42;
        }
        
        if((val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32) <= val_3)
        {
            goto label_43;
        }
        
        goto label_71;
        label_42:
        if(val_1 == 0)
        {
            goto label_45;
        }
        
        label_43:
        val_42 = val_41;
        label_72:
        val_43 = val_9;
        if(((val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32) == (horzEdge + 48)) && ((horzEdge + 128) != 0))
        {
                if((val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 80) < 0)
        {
            goto label_71;
        }
        
        }
        
        if(val_9 == 0)
        {
            goto label_53;
        }
        
        if(horzEdge.WindDelta != 0)
        {
            goto label_54;
        }
        
        goto label_57;
        label_53:
        if(horzEdge.WindDelta == 0)
        {
            goto label_57;
        }
        
        label_54:
        if(((horzEdge + 108) & 2147483648) != 0)
        {
            goto label_57;
        }
        
        val_44 = mem[val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32 + 8];
        val_44 = val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32 + 8;
        val_40 = this.AddOutPt(e:  val_9, pt:  new IntPoint() {X = val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32, Y = val_44});
        if(this.m_SortedEdges == null)
        {
            goto label_58;
        }
        
        label_63:
        if((this.m_SortedEdges.OutIdx & 2147483648) != 0)
        {
            goto label_62;
        }
        
        val_43 = val_9;
        val_45 = val_43;
        if(val_43 != 0)
        {
            goto label_60;
        }
        
        val_45 = val_9;
        if(val_45 == 0)
        {
            goto label_101;
        }
        
        label_60:
        val_44 = this.m_SortedEdges.Bot;
        val_46 = this.m_SortedEdges.Top;
        if((this.HorzSegmentsOverlap(seg1a:  horzEdge + 16, seg1b:  horzEdge + 48, seg2a:  val_44, seg2b:  val_46)) != false)
        {
                val_44 = this.m_SortedEdges.Top;
            this.AddJoin(Op1:  this.GetLastOutPt(e:  this.m_SortedEdges), Op2:  val_40, OffPt:  new IntPoint() {X = val_44, Y = val_46});
        }
        
        label_62:
        if(this.m_SortedEdges.NextInSEL != null)
        {
            goto label_63;
        }
        
        label_58:
        this.AddGhostJoin(Op:  val_40, OffPt:  new IntPoint() {X = horzEdge + 16, Y = horzEdge + 16 + 8});
        label_57:
        if(val_36 == val_37)
        {
                if(val_41 == val_5)
        {
            goto label_66;
        }
        
        }
        
        val_43 = val_9;
        if(val_1 == 1)
        {
                InternalClipper.IntPoint val_21 = new InternalClipper.IntPoint(X:  val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32, Y:  horzEdge + 40);
            val_47 = val_9;
            val_48 = val_21.X;
            val_49 = val_21.Y;
            val_50 = val_41;
        }
        else
        {
                InternalClipper.IntPoint val_22 = new InternalClipper.IntPoint(X:  val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32, Y:  horzEdge + 40);
            val_50 = val_9;
            val_48 = val_22.X;
            val_49 = val_22.Y;
            val_47 = val_41;
        }
        
        this.IntersectEdges(e1:  val_47, e2:  val_50, pt:  new IntPoint() {X = val_48, Y = val_49});
        var val_25 = (val_1 != 1) ? (val_41 + 144) : (val_41 + 136);
        val_34 = 0;
        this.SwapPositionsInAEL(edge1:  val_9, edge2:  val_41);
        val_41 = val_25;
        if(val_25 != 0)
        {
            goto label_70;
        }
        
        goto label_71;
        label_45:
        val_42 = val_41;
        if((val_1 != 0x1 ? (horzEdge + 144) : (horzEdge + 136) + 32) >= val_2)
        {
            goto label_72;
        }
        
        label_71:
        if((horzEdge + 128) != 0)
        {
            goto label_74;
        }
        
        label_21:
        if((val_40 != 0) || (((horzEdge + 108) & 2147483648) != 0))
        {
            goto label_77;
        }
        
        InternalClipper.OutPt val_26 = this.GetLastOutPt(e:  val_9);
        if(this.m_SortedEdges == null)
        {
            goto label_78;
        }
        
        label_83:
        if((this.m_SortedEdges.OutIdx & 2147483648) != 0)
        {
            goto label_82;
        }
        
        val_51 = val_9;
        if(val_9 != 0)
        {
            goto label_80;
        }
        
        val_51 = val_9;
        if(val_51 == 0)
        {
            goto label_101;
        }
        
        label_80:
        val_52 = this.m_SortedEdges.Bot;
        val_49 = this.m_SortedEdges.Top;
        if((this.HorzSegmentsOverlap(seg1a:  horzEdge + 16, seg1b:  horzEdge + 48, seg2a:  val_52, seg2b:  val_49)) != false)
        {
                val_52 = this.m_SortedEdges.Top;
            this.AddJoin(Op1:  this.GetLastOutPt(e:  this.m_SortedEdges), Op2:  val_26, OffPt:  new IntPoint() {X = val_52, Y = val_49});
        }
        
        label_82:
        if(this.m_SortedEdges.NextInSEL != null)
        {
            goto label_83;
        }
        
        label_78:
        val_37 = val_9;
        val_53 = mem[horzEdge + 48 + 8];
        val_53 = horzEdge + 48 + 8;
        this.AddGhostJoin(Op:  val_26, OffPt:  new IntPoint() {X = horzEdge + 48, Y = val_53});
        label_77:
        if(val_9 == 0)
        {
            goto label_85;
        }
        
        val_54 = (horzEdge + 108) >> 31;
        if((horzEdge + 128) == 0)
        {
            goto label_86;
        }
        
        label_93:
        if((val_54 & 1) == 0)
        {
            goto label_87;
        }
        
        this.UpdateEdgeIntoAEL(e: ref  val_9);
        return;
        label_66:
        if(((horzEdge + 108) & 2147483648) == 0)
        {
                val_37 = val_9;
            this.AddLocalMaxPoly(e1:  val_37, e2:  val_5, pt:  new IntPoint() {X = horzEdge + 48, Y = horzEdge + 48 + 8});
        }
        
        this.DeleteFromAEL(e:  val_9);
        label_96:
        this.DeleteFromAEL(e:  val_5);
        return;
        label_85:
        val_54 = (horzEdge + 108) >> 31;
        if((horzEdge + 128) != 0)
        {
            goto label_93;
        }
        
        label_86:
        if((val_54 & 1) != 0)
        {
            goto label_96;
        }
        
        InternalClipper.OutPt val_29 = this.AddOutPt(e:  val_9, pt:  new IntPoint() {X = horzEdge + 48, Y = horzEdge + 48 + 8});
        goto label_96;
        label_87:
        this.UpdateEdgeIntoAEL(e: ref  val_9);
        if((horzEdge + 96) == 0)
        {
                return;
        }
        
        val_55 = val_9;
        if(val_9 != 0)
        {
            goto label_100;
        }
        
        val_55 = val_9;
        if(val_55 == 0)
        {
            goto label_101;
        }
        
        label_100:
        if((((((((horzEdge + 144) != 0) && ((horzEdge + 144 + 32) == (horzEdge + 16))) && ((horzEdge + 144 + 40) == (horzEdge + 24))) && ((horzEdge + 144 + 96) != 0)) && (((horzEdge + 144 + 108) & 2147483648) == 0)) && ((horzEdge + 144 + 40) > (horzEdge + 144 + 56))) && ((InternalClipper.ClipperBase.SlopesEqual(e1:  val_9, e2:  horzEdge + 144, UseFullRange:  false)) != false))
        {
                val_56 = mem[horzEdge + 16];
            val_56 = horzEdge + 16;
            val_57 = mem[horzEdge + 16 + 8];
            val_57 = horzEdge + 16 + 8;
            val_58 = horzEdge + 144;
        }
        else
        {
                if((horzEdge + 136) == 0)
        {
                return;
        }
        
            if((horzEdge + 136 + 32) != (horzEdge + 16))
        {
                return;
        }
        
            if((horzEdge + 136 + 40) != (horzEdge + 24))
        {
                return;
        }
        
            if((horzEdge + 136 + 96) == 0)
        {
                return;
        }
        
            if(((horzEdge + 136 + 108) & 2147483648) != 0)
        {
                return;
        }
        
            if((horzEdge + 136 + 40) <= (horzEdge + 136 + 56))
        {
                return;
        }
        
            if((InternalClipper.ClipperBase.SlopesEqual(e1:  val_9, e2:  horzEdge + 136, UseFullRange:  false)) == false)
        {
                return;
        }
        
            val_56 = mem[horzEdge + 16];
            val_56 = horzEdge + 16;
            val_57 = mem[horzEdge + 16 + 8];
            val_57 = horzEdge + 16 + 8;
            val_58 = horzEdge + 136;
        }
        
        this.AddJoin(Op1:  this.AddOutPt(e:  val_9, pt:  new IntPoint() {X = horzEdge + 48, Y = horzEdge + 48 + 8}), Op2:  this.AddOutPt(e:  val_58, pt:  new IntPoint() {X = val_56, Y = val_57}), OffPt:  new IntPoint() {X = horzEdge + 48, Y = horzEdge + 48 + 8});
        return;
        label_101:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge GetNextInAEL(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Direction Direction)
    {
        return (TEdge)(Direction != 1) ? e.PrevInAEL : e.NextInAEL;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsMinima(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        var val_2;
        if((e != null) && (e.Prev.NextInLML != e))
        {
                var val_1 = (e.Next.NextInLML != e) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsMaxima(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, double Y)
    {
        if(e == null)
        {
                return false;
        }
        
        if((double)D1 != Y)
        {
                return false;
        }
        
        return (bool)(e.NextInLML == 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsIntermediate(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e, double Y)
    {
        var val_2;
        if((double)Y == Y)
        {
                var val_1 = (e.NextInLML != 0) ? 1 : 0;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge GetMaximaPair(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        InternalClipper.TEdge val_3;
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = e.Next.Top, Y = e}, b:  new IntPoint() {X = e.Top})) != false)
        {
                if(e.Next.NextInLML == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = e.Prev.Top, Y = e}, b:  new IntPoint() {X = e.Top})) == false)
        {
                return (TEdge)val_3;
        }
        
        if(e.Prev.NextInLML == null)
        {
            goto label_8;
        }
        
        val_3 = 0;
        return (TEdge)val_3;
        label_4:
        val_3 = e.Next;
        return (TEdge)val_3;
        label_8:
        val_3 = e.Prev;
        return (TEdge)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge GetMaximaPairEx(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        var val_3;
        TEdge val_1 = this.GetMaximaPair(e:  e);
        if(val_1 == null)
        {
                return (TEdge)val_3;
        }
        
        if(val_1.OutIdx == 2)
        {
                val_3 = 0;
            return (TEdge)val_3;
        }
        
        if(val_1.NextInAEL == val_1.PrevInAEL)
        {
                val_3 = 0;
            if((InternalClipper.ClipperBase.IsHorizontal(e:  val_1)) == false)
        {
                return (TEdge)val_3;
        }
        
        }
        
        val_3 = val_1;
        return (TEdge)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool ProcessIntersections(long topY)
    {
        if(true == 0)
        {
                return true;
        }
        
        this.BuildIntersectList(topY:  topY);
        if(this.m_IntersectList.Count == 0)
        {
                return true;
        }
        
        if(this.m_IntersectList.Count != 1)
        {
                if(this.FixupIntersectionOrder() == false)
        {
                return true;
        }
        
        }
        
        this.ProcessIntersectList();
        this.m_SortedEdges = 0;
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void BuildIntersectList(long topY)
    {
        bool val_5;
        InternalClipper.TEdge val_6;
        InternalClipper.TEdge val_7;
        InternalClipper.IntPoint val_8;
        long val_9;
        long val_10;
        val_5 = static_value_04282A97;
        val_5 = true;
        if(==0)
        {
                return;
        }
        
        this.m_SortedEdges = null;
        do
        {
            long val_1 = InternalClipper.Clipper.TopX(edge:  static_value_04282000, currentY:  topY);
        }
        while(mem[69738632] != 0);
        
        label_15:
        val_6 = this.m_SortedEdges;
        if(val_6 == null)
        {
            goto label_14;
        }
        
        label_13:
        label_8:
        val_6 = val_6;
        if(val_6 == null)
        {
            goto label_4;
        }
        
        val_7 = this.m_SortedEdges.NextInSEL;
        if(val_7 == null)
        {
            goto label_5;
        }
        
        val_8 = this.m_SortedEdges.Curr;
        goto label_7;
        label_4:
        val_7 = 6486152;
        val_8 = this.m_SortedEdges.Curr;
        label_7:
        if(val_8 <= 65185696)
        {
            goto label_8;
        }
        
        this.IntersectPoint(edge1:  val_6, edge2:  val_7, ip: out  new InternalClipper.IntPoint());
        if(0 < topY)
        {
                InternalClipper.IntPoint val_3 = new InternalClipper.IntPoint(X:  InternalClipper.Clipper.TopX(edge:  val_6, currentY:  topY), Y:  topY);
        }
        
        InternalClipper.IntersectNode val_4 = new InternalClipper.IntersectNode();
        if(val_4 != null)
        {
                .Edge1 = val_6;
            .Edge2 = val_7;
            val_9 = val_3.X;
            val_10 = val_3.Y;
        }
        else
        {
                mem[16] = val_6;
            mem[24] = val_7;
            val_9 = val_3.X;
            val_10 = val_3.Y;
        }
        
        .Pt = val_9;
        mem[1152921519912349304] = val_10;
        this.m_IntersectList.Add(item:  val_4);
        this.SwapPositionsInSEL(edge1:  val_6, edge2:  val_7);
        goto label_13;
        label_5:
        if(this.m_SortedEdges.PrevInSEL == null)
        {
            goto label_14;
        }
        
        this.m_SortedEdges.PrevInSEL.NextInSEL = 0;
        if((0 & 255) != 0)
        {
            goto label_15;
        }
        
        label_14:
        this.m_SortedEdges = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool EdgesAdjacent(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode inode)
    {
        InternalClipper.TEdge val_2;
        var val_3;
        val_2 = inode.Edge2;
        if(inode.Edge1.NextInSEL != val_2)
        {
                if(inode.Edge1 == null)
        {
                val_2 = inode.Edge2;
        }
        
            var val_1 = (inode.Edge1.PrevInSEL == val_2) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int IntersectNodeSort(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode node1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntersectNode node2)
    {
        return (int)node2 - W8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool FixupIntersectionOrder()
    {
        System.Collections.Generic.IComparer<IntersectNode> val_11;
        System.Collections.Generic.List<IntersectNode> val_12;
        IntersectNode val_13;
        var val_14;
        val_11 = this.m_IntersectNodeComparer;
        this.m_IntersectList.Sort(comparer:  val_11);
        this.m_SortedEdges = 1152921519912723472;
        if((public System.Void System.Collections.Generic.List<IntersectNode>::Sort(System.Collections.Generic.IComparer<T> comparer)) != 0)
        {
                do
        {
        
        }
        while((public System.Void System.Collections.Generic.List<AmsSceneReference>::set_Item(int index, AmsSceneReference value)) != 0);
        
        }
        
        int val_1 = this.m_IntersectList.Count;
        if(val_1 < 1)
        {
            goto label_5;
        }
        
        val_11 = 0;
        var val_12 = 1;
        label_20:
        IntersectNode val_2 = this.m_IntersectList.Item[0];
        if((val_2.EdgesAdjacent(inode:  val_2)) == true)
        {
            goto label_7;
        }
        
        var val_11 = val_12;
        label_10:
        if(val_11 >= val_1)
        {
            goto label_8;
        }
        
        val_12 = this.m_IntersectList;
        IntersectNode val_4 = val_12.Item[1];
        val_11 = val_11 + 1;
        if((val_4.EdgesAdjacent(inode:  val_4)) == false)
        {
            goto label_10;
        }
        
        label_8:
        if(val_1 == val_11)
        {
            goto label_11;
        }
        
        if(this.m_IntersectList != null)
        {
                val_13 = this.m_IntersectList.Item[1];
        }
        else
        {
                val_13 = 0.Item[1];
        }
        
        this.m_IntersectList.set_Item(index:  0, value:  val_13);
        this.m_IntersectList.set_Item(index:  1, value:  this.m_IntersectList.Item[0]);
        label_7:
        IntersectNode val_9 = this.m_IntersectList.Item[0];
        val_12 = this.m_IntersectList.Item[0];
        this.SwapPositionsInSEL(edge1:  val_9.Edge1, edge2:  val_10.Edge2);
        val_11 = val_11 + 1;
        val_12 = val_12 + 1;
        if(val_11 < val_1)
        {
            goto label_20;
        }
        
        label_5:
        val_14 = 1;
        return (bool)val_14;
        label_11:
        val_14 = 0;
        return (bool)val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ProcessIntersectList()
    {
        var val_3;
        var val_4;
        InternalClipper.TEdge val_5;
        TEdge val_6;
        TEdge val_7;
        TEdge val_8;
        val_3 = 0;
        goto label_2;
        label_8:
        IntersectNode val_2 = X22.Item[0];
        if(val_2 != null)
        {
                val_4 = val_2;
            val_5 = val_2.Edge1;
            val_6 = val_2 + 16;
            val_7 = mem[val_2 + 16 + 8];
            val_7 = val_2 + 16 + 8;
        }
        else
        {
                val_5 = 11993091;
            val_7 = 15026800;
            val_6 = 24;
            val_4 = 16;
        }
        
        this.IntersectEdges(e1:  val_5, e2:  val_7, pt:  new IntPoint() {X = val_2.Pt});
        if(val_2 != null)
        {
            
        }
        else
        {
                val_8 = 11993091;
        }
        
        this.SwapPositionsInAEL(edge1:  val_8, edge2:  val_6);
        val_3 = 1;
        label_2:
        if(val_3 < this.m_IntersectList.Count)
        {
            goto label_8;
        }
        
        this.m_IntersectList.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static long Round(double value)
    {
        value = ((value >= 0) ? 0.5 : -0.5) + value;
        return (long)(long)value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static long TopX(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge, long currentY)
    {
        InternalClipper.IntPoint val_4;
        double val_5;
        InternalClipper.IntPoint val_6;
        if(edge == null)
        {
            goto label_0;
        }
        
        if(X8 == currentY)
        {
            goto label_1;
        }
        
        val_4 = edge.Bot;
        val_5 = edge.Dx;
        goto label_2;
        label_0:
        if(7599944634466311 != currentY)
        {
            goto label_3;
        }
        
        label_1:
        val_6 = edge.Top;
        return (long)val_6;
        label_3:
        val_4 = 11993091;
        val_5 = 0;
        label_2:
        double val_3 = (double)currentY - 80;
        val_3 = val_5 * val_3;
        float val_2 = (val_3 >= 0) ? 0.5 : -0.5;
        val_2 = val_3 + val_2;
        val_6 = val_4 + (long)val_2;
        return (long)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void IntersectPoint(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge edge2, out Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint ip)
    {
        var val_13;
        float val_14;
        InternalClipper.IntPoint val_16;
        double val_17;
        double val_18;
        long val_19;
        ip.X = 0;
        ip.Y = 0;
        double val_15 = edge2.Dx;
        if(edge1.Dx != val_15)
        {
            goto label_3;
        }
        
        ip.Y = edge1;
        label_22:
        label_23:
        ip.X = InternalClipper.Clipper.TopX(edge:  edge1, currentY:  edge1);
        return;
        label_3:
        if(edge1.Delta == 0)
        {
            goto label_4;
        }
        
        if(edge2.Delta == 0)
        {
            goto label_5;
        }
        
        double val_14 = edge1.Dx;
        double val_13 = (double)D2;
        val_13 = val_14 * val_13;
        val_14 = val_14 - val_15;
        val_15 = val_15 * (double)D3;
        double val_2 = (double)edge1.Bot - val_13;
        double val_3 = (double)edge2.Bot - val_15;
        val_15 = val_3 - val_2;
        double val_4 = val_15 / val_14;
        float val_5 = (val_4 >= 0) ? 0.5 : -0.5;
        val_5 = val_4 + val_5;
        val_13 = 1152921519913439392;
        ip.Y = (long)val_5;
        double val_19 = edge2.Dx;
        double val_17 = System.Math.Abs(val_19);
        if(System.Math.Abs(edge1.Dx) >= 0)
        {
            goto label_8;
        }
        
        double val_18 = edge1.Dx;
        val_18 = val_4 * val_18;
        val_14 = val_2 + val_18;
        goto label_9;
        label_4:
        ip.X = edge1.Bot;
        if((InternalClipper.ClipperBase.IsHorizontal(e:  edge2)) == true)
        {
            goto label_10;
        }
        
        val_16 = edge2.Bot;
        val_17 = edge2.Dx;
        goto label_11;
        label_5:
        ip.X = edge2.Bot;
        if((InternalClipper.ClipperBase.IsHorizontal(e:  edge1)) == false)
        {
            goto label_12;
        }
        
        label_10:
        val_13 = 1152921519913439392;
        ip.Y = edge2.Bot;
        goto label_14;
        label_8:
        val_19 = val_4 * val_19;
        val_14 = val_3 + val_19;
        label_9:
        val_14 = val_14 + ((val_14 >= 0) ? 0.5 : -0.5);
        ip.X = (long)val_14;
        goto label_14;
        label_12:
        val_16 = edge1.Bot;
        val_17 = edge1.Dx;
        label_11:
        val_13 = 1152921519913439392;
        double val_20 = (double)val_16;
        val_20 = val_20 / val_17;
        val_20 = (double)edge2.Bot - val_20;
        val_17 = (double)ip.X / val_17;
        val_20 = val_20 + val_17;
        val_20 = val_20 + ((val_20 >= 0) ? 0.5 : -0.5);
        ip.Y = (long)val_20;
        label_14:
        val_18 = ip.Y;
        if(val_18 >= X9)
        {
                if(val_18 >= X10)
        {
            goto label_16;
        }
        
        }
        
        ip.Y = (X9 > X10) ? (X9) : (X10);
        val_19 = ip.Y;
        double val_22 = System.Math.Abs(edge2.Dx);
        ip.X = InternalClipper.Clipper.TopX(edge:  (System.Math.Abs(edge1.Dx) < 0) ? edge1 : edge2, currentY:  val_19);
        val_18 = ip.Y;
        label_16:
        if(val_18 <= val_19)
        {
                return;
        }
        
        ip.Y = val_19;
        if(System.Math.Abs(edge1.Dx) <= System.Math.Abs(edge2.Dx))
        {
            goto label_22;
        }
        
        goto label_23;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ProcessEdgesAtTopOfScanbeam(long topY)
    {
        var val_15;
        long val_16;
        long val_17;
        long val_18;
        long val_19;
        long val_20;
        long val_21;
        long val_22;
        InternalClipper.OutPt val_23;
        bool val_24;
        bool val_25;
        long val_26;
        long val_27;
        long val_28;
        TEdge val_29;
        bool val_30;
        long val_2 = topY;
        if(topY == 0)
        {
            goto label_0;
        }
        
        label_37:
        if(((double)topY + 56) == (double)topY)
        {
                if((topY + 128) == 0)
        {
            goto label_4;
        }
        
        }
        
        label_31:
        if(((((double)topY + 56) == (double)topY) && ((topY + 128) != 0)) && ((InternalClipper.ClipperBase.IsHorizontal(e:  topY + 128)) != false))
        {
                val_16 = 0;
            this.UpdateEdgeIntoAEL(e: ref  val_2);
            if(((topY + 108) & 2147483648) == 0)
        {
                val_16 = mem[topY + 16];
            val_16 = topY + 16;
            val_17 = mem[topY + 16 + 8];
            val_17 = topY + 16 + 8;
            InternalClipper.OutPt val_3 = this.AddOutPt(e:  val_2, pt:  new IntPoint() {X = val_16, Y = val_17});
        }
        
            this.AddEdgeToSEL(edge:  val_2);
        }
        else
        {
                val_18 = val_2;
            if(val_2 == 0)
        {
                val_18 = val_2;
        }
        
            mem2[0] = InternalClipper.Clipper.TopX(edge:  val_18, currentY:  topY);
            mem2[0] = topY;
        }
        
        if((this.<StrictlySimple>k__BackingField) == false)
        {
            goto label_25;
        }
        
        val_19 = val_2;
        if(val_2 != 0)
        {
            goto label_16;
        }
        
        val_19 = val_2;
        if(val_19 == 0)
        {
            goto label_45;
        }
        
        label_16:
        if((((((topY + 108) & 2147483648) == 0) && ((topY + 144) != 0)) && ((topY + 96) != 0)) && (((topY + 144 + 108) & 2147483648) == 0))
        {
                val_20 = val_2;
            if(((topY + 144 + 32) == (topY + 32)) && ((topY + 144 + 96) != 0))
        {
                InternalClipper.IntPoint val_5 = new InternalClipper.IntPoint(X:  topY + 32, Y:  topY + 32 + 8);
            val_17 = val_5.X;
            this.AddJoin(Op1:  this.AddOutPt(e:  topY + 144, pt:  new IntPoint() {X = val_5.X, Y = val_5.Y}), Op2:  this.AddOutPt(e:  val_2, pt:  new IntPoint() {X = val_5.X, Y = val_5.Y}), OffPt:  new IntPoint() {X = val_17, Y = val_5.Y});
        }
        
        }
        
        label_25:
        val_21 = val_2;
        if(val_21 != 0)
        {
            goto label_28;
        }
        
        goto label_28;
        label_4:
        TEdge val_8 = this.GetMaximaPairEx(e:  topY);
        if((val_8 == null) || ((InternalClipper.ClipperBase.IsHorizontal(e:  val_8)) == false))
        {
            goto label_30;
        }
        
        if(val_2 != 0)
        {
            goto label_31;
        }
        
        goto label_45;
        label_30:
        if((this.<StrictlySimple>k__BackingField) != false)
        {
                this.InsertMaxima(X:  topY + 48);
        }
        
        val_22 = val_2;
        if(val_2 == 0)
        {
                val_22 = val_2;
        }
        
        val_21 = mem[topY + 144];
        val_21 = topY + 144;
        this.DoMaxima(e:  val_22);
        if(val_21 == 0)
        {
            goto label_2;
        }
        
        label_28:
        val_15 = mem[topY + 144 + 136];
        val_15 = topY + 144 + 136;
        label_2:
        if(val_15 != 0)
        {
            goto label_37;
        }
        
        label_0:
        this.ProcessHorizontals();
        this.m_Maxima = 0;
        bool val_11 = this.<StrictlySimple>k__BackingField;
        if((this.<StrictlySimple>k__BackingField) == false)
        {
                return;
        }
        
        label_81:
        if((((double)this.<StrictlySimple>k__BackingField + 56) != (double)topY) || ((this.<StrictlySimple>k__BackingField + 128) == 0))
        {
            goto label_77;
        }
        
        if(((this.<StrictlySimple>k__BackingField + 108) & 2147483648) == 0)
        {
                val_17 = mem[this.<StrictlySimple>k__BackingField + 48 + 8];
            val_17 = this.<StrictlySimple>k__BackingField + 48 + 8;
            val_23 = this.AddOutPt(e:  val_11, pt:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 48, Y = val_17});
        }
        else
        {
                val_23 = 0;
        }
        
        this.UpdateEdgeIntoAEL(e: ref  val_11);
        val_24 = val_11;
        if(val_11 == true)
        {
            goto label_44;
        }
        
        val_24 = val_11;
        if(val_24 == false)
        {
            goto label_45;
        }
        
        label_44:
        val_21 = mem[this.<StrictlySimple>k__BackingField + 136];
        val_21 = this.<StrictlySimple>k__BackingField + 136;
        if(((this.<StrictlySimple>k__BackingField + 144) == 0) || ((this.<StrictlySimple>k__BackingField + 144 + 32) != (this.<StrictlySimple>k__BackingField + 16)))
        {
            goto label_61;
        }
        
        if(val_11 == false)
        {
            goto label_49;
        }
        
        if(val_23 != 0)
        {
            goto label_50;
        }
        
        goto label_61;
        label_49:
        if(val_23 == 0)
        {
            goto label_61;
        }
        
        label_50:
        if((((this.<StrictlySimple>k__BackingField + 144 + 40) != (this.<StrictlySimple>k__BackingField + 24)) || (((this.<StrictlySimple>k__BackingField + 144 + 108) & 2147483648) != 0)) || ((this.<StrictlySimple>k__BackingField + 144 + 40) <= (this.<StrictlySimple>k__BackingField + 144 + 56)))
        {
            goto label_61;
        }
        
        val_25 = val_11;
        if(val_11 != true)
        {
                val_25 = val_11;
        }
        
        val_17 = mem[this.<StrictlySimple>k__BackingField + 48 + 8];
        val_17 = this.<StrictlySimple>k__BackingField + 48 + 8;
        val_26 = mem[this.<StrictlySimple>k__BackingField + 144 + 32];
        val_26 = this.<StrictlySimple>k__BackingField + 144 + 32;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 32, Y = this.<StrictlySimple>k__BackingField + 32 + 8}, pt2:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 48, Y = val_17}, pt3:  new IntPoint() {X = val_26, Y = this.<StrictlySimple>k__BackingField + 144 + 32 + 8}, pt4:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 144 + 48, Y = this.<StrictlySimple>k__BackingField + 144 + 48 + 8}, UseFullRange:  this.<StrictlySimple>k__BackingField + 144 + 40)) == false)
        {
            goto label_61;
        }
        
        val_20 = val_11;
        if(((this.<StrictlySimple>k__BackingField + 96) == 0) || ((this.<StrictlySimple>k__BackingField + 144 + 96) == 0))
        {
            goto label_61;
        }
        
        val_27 = mem[this.<StrictlySimple>k__BackingField + 16];
        val_27 = this.<StrictlySimple>k__BackingField + 16;
        val_28 = mem[this.<StrictlySimple>k__BackingField + 16 + 8];
        val_28 = this.<StrictlySimple>k__BackingField + 16 + 8;
        val_29 = this.<StrictlySimple>k__BackingField + 144;
        goto label_63;
        label_61:
        if(val_21 == 0)
        {
            goto label_77;
        }
        
        val_20 = val_11;
        if((this.<StrictlySimple>k__BackingField + 136 + 32) != (this.<StrictlySimple>k__BackingField + 16))
        {
            goto label_77;
        }
        
        val_20 = val_11;
        if((((val_23 == 0) || ((this.<StrictlySimple>k__BackingField + 136 + 40) != (this.<StrictlySimple>k__BackingField + 24))) || (((this.<StrictlySimple>k__BackingField + 136 + 108) & 2147483648) != 0)) || ((this.<StrictlySimple>k__BackingField + 136 + 40) <= (this.<StrictlySimple>k__BackingField + 136 + 56)))
        {
            goto label_77;
        }
        
        val_30 = val_11;
        if(val_11 != true)
        {
                val_30 = val_11;
        }
        
        val_20 = mem[this.<StrictlySimple>k__BackingField + 32 + 8];
        val_20 = this.<StrictlySimple>k__BackingField + 32 + 8;
        val_26 = mem[this.<StrictlySimple>k__BackingField + 136 + 32];
        val_26 = this.<StrictlySimple>k__BackingField + 136 + 32;
        if((((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 32, Y = val_20}, pt2:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 48, Y = this.<StrictlySimple>k__BackingField + 48 + 8}, pt3:  new IntPoint() {X = val_26, Y = this.<StrictlySimple>k__BackingField + 136 + 32 + 8}, pt4:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 136 + 48, Y = this.<StrictlySimple>k__BackingField + 136 + 48 + 8}, UseFullRange:  this.<StrictlySimple>k__BackingField + 136 + 40)) == false) || ((this.<StrictlySimple>k__BackingField + 96) == 0)) || ((this.<StrictlySimple>k__BackingField + 136 + 96) == 0))
        {
            goto label_77;
        }
        
        val_27 = mem[this.<StrictlySimple>k__BackingField + 16];
        val_27 = this.<StrictlySimple>k__BackingField + 16;
        val_28 = mem[this.<StrictlySimple>k__BackingField + 16 + 8];
        val_28 = this.<StrictlySimple>k__BackingField + 16 + 8;
        val_29 = val_21;
        label_63:
        val_21 = this.AddOutPt(e:  val_29, pt:  new IntPoint() {X = val_27, Y = val_28});
        this.AddJoin(Op1:  val_23, Op2:  val_21, OffPt:  new IntPoint() {X = this.<StrictlySimple>k__BackingField + 48, Y = this.<StrictlySimple>k__BackingField + 48 + 8});
        label_77:
        if((this.<StrictlySimple>k__BackingField + 136) != 0)
        {
            goto label_81;
        }
        
        return;
        label_45:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DoMaxima(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.TEdge e)
    {
        TEdge val_6;
        long val_7;
        var val_8;
        TEdge val_1 = this.GetMaximaPairEx(e:  e);
        if(e == null)
        {
            goto label_1;
        }
        
        if(val_1 != null)
        {
            goto label_4;
        }
        
        goto label_3;
        label_1:
        if(val_1 != null)
        {
            goto label_4;
        }
        
        label_3:
        if((e.OutIdx & 2147483648) == 0)
        {
                InternalClipper.OutPt val_2 = this.AddOutPt(e:  e, pt:  new IntPoint() {X = e.Top});
        }
        
        val_6 = e;
        goto label_6;
        label_8:
        if(X22 == val_1)
        {
            goto label_7;
        }
        
        this.IntersectEdges(e1:  e, e2:  X22, pt:  new IntPoint() {X = e.Top});
        val_7 = 0;
        this.SwapPositionsInAEL(edge1:  e, edge2:  X22);
        label_4:
        if(e.NextInAEL != null)
        {
            goto label_8;
        }
        
        label_7:
        if(e.OutIdx == 1)
        {
            goto label_9;
        }
        
        if((e.OutIdx & 2147483648) != 0)
        {
            goto label_10;
        }
        
        if((val_1.OutIdx & 2147483648) != 0)
        {
            goto label_11;
        }
        
        this.AddLocalMaxPoly(e1:  e, e2:  val_1, pt:  new IntPoint() {X = e.Top});
        goto label_13;
        label_9:
        if(val_1.OutIdx == 1)
        {
            goto label_13;
        }
        
        label_10:
        val_8 = 1;
        goto label_14;
        label_13:
        this.DeleteFromAEL(e:  e);
        goto label_18;
        label_11:
        val_8 = 0;
        label_14:
        if(e.WindDelta != 0)
        {
            goto label_16;
        }
        
        if((val_8 & 1) == 0)
        {
                InternalClipper.OutPt val_3 = this.AddOutPt(e:  e, pt:  new IntPoint() {X = e.Top, Y = val_7});
            e.OutIdx = 0;
        }
        
        this.DeleteFromAEL(e:  e);
        if((val_1.OutIdx & 2147483648) == 0)
        {
                InternalClipper.OutPt val_4 = this.AddOutPt(e:  val_1, pt:  new IntPoint() {X = e.Top, Y = val_7});
            val_1.OutIdx = 0;
        }
        
        label_18:
        val_6 = val_1;
        label_6:
        this.DeleteFromAEL(e:  val_6);
        return;
        label_16:
        InternalClipper.ClipperException val_5 = new InternalClipper.ClipperException(description:  "DoMaxima error");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> polys)
    {
        List.Enumerator<T> val_1 = polys.GetEnumerator();
        label_4:
        if(((-1872859864) & 1) == 0)
        {
            goto label_2;
        }
        
        0.emailUIDataHandler.Reverse();
        goto label_4;
        label_2:
        long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519913856296});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool Orientation(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> poly)
    {
        return (bool)((InternalClipper.Clipper.Area(poly:  poly)) >= 0f) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int PointCount(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt pts)
    {
        if(pts == null)
        {
                return (int)0;
        }
        
        do
        {
            0 = 1;
        }
        while(pts.Next != pts);
        
        return (int)0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> polyg)
    {
        long val_5;
        var val_6;
        OutPt val_7;
        val_5 = polyg;
        val_5.Clear();
        val_6 = 1152921519903249216;
        int val_1 = X21.Count;
        val_5.Capacity = val_1;
        int val_2 = val_1.Count;
        if(val_2 < 1)
        {
                return;
        }
        
        var val_7 = 0;
        do
        {
            val_7 = X23.Item[0];
            if((val_3.Pts != null) && (val_3.Pts.Prev != null))
        {
                int val_5 = 0;
            do
        {
            val_6 = val_5;
            val_5 = val_6 + 1;
            val_7 = val_3.Pts.Prev.Next;
        }
        while(val_7 != val_3.Pts.Prev);
        
            if(val_5 >= 2)
        {
                System.Collections.Generic.List<IntPoint> val_4 = null;
            val_7 = val_4;
            val_4 = new System.Collections.Generic.List<IntPoint>(capacity:  val_5);
            var val_6 = 0;
            do
        {
            val_4.Add(item:  new IntPoint() {X = val_3.Pts.Prev.Pt, Y = val_5});
            val_6 = val_6 + 1;
        }
        while(val_6 != val_6);
        
            val_5 = val_5;
            val_5.Add(item:  val_4);
        }
        
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 != val_2);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void BuildResult2(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree polytree)
    {
        var val_8;
        OutPt val_9;
        InternalClipper.PolyNode val_10;
        if(polytree != null)
        {
                polytree.Clear();
        }
        else
        {
                0.Clear();
        }
        
        polytree.m_AllPolys.Capacity = X22.Count;
        int val_2 = polytree.m_AllPolys.Count;
        if(val_2 < 1)
        {
            goto label_6;
        }
        
        var val_8 = 0;
        goto label_29;
        label_12:
        val_8 = 0;
        if(X24 != 0)
        {
            goto label_9;
        }
        
        goto label_9;
        label_29:
        if(val_3.Pts == null)
        {
            goto label_12;
        }
        
        do
        {
            val_8 = 1;
            val_9 = val_3.Pts.Next;
        }
        while(val_9 != val_3.Pts);
        
        label_9:
        if(val_8 < 2)
        {
                if(val_3.IsOpen == true)
        {
            goto label_25;
        }
        
        }
        
        if(val_8 <= 2)
        {
                if(val_3.IsOpen == false)
        {
            goto label_25;
        }
        
        }
        
        this.FixHoleLinkage(outRec:  polytree.Item[0]);
        InternalClipper.PolyNode val_4 = null;
        val_9 = val_4;
        val_4 = new InternalClipper.PolyNode();
        polytree + 64.Add(item:  val_4);
        val_3.PolyNode = val_9;
        (InternalClipper.PolyNode)[1152921519914519376].m_polygon.Capacity = 1;
        if(val_8 >= 1)
        {
                do
        {
            (InternalClipper.PolyNode)[1152921519914519376].m_polygon.Add(item:  new IntPoint() {X = val_3.Pts.Prev.Pt, Y = X27});
            val_8 = val_8 - 1;
        }
        while(val_8 != 0);
        
        }
        
        label_25:
        val_8 = val_8 + 1;
        if(val_8 != val_2)
        {
            goto label_29;
        }
        
        label_6:
        val_10 = 1152921519903249216;
        polytree + 48.Capacity = val_8.Count;
        int val_6 = polytree + 48.Count;
        if(val_6 < 1)
        {
                return;
        }
        
        val_9 = 1152921519903378624;
        var val_9 = 0;
        goto label_44;
        label_42:
        if((public System.Void System.Collections.Generic.List<PolyNode>::set_Capacity(int value)) == 0)
        {
            goto label_38;
        }
        
        if(as. 
           
           
          
        
        
        
         != 0)
        {
            goto label_37;
        }
        
        goto label_38;
        label_44:
        OutRec val_7 = Item[0];
        val_10 = val_7.PolyNode;
        if(val_10 == null)
        {
            goto label_41;
        }
        
        if(val_7.IsOpen == false)
        {
            goto label_42;
        }
        
        val_10.IsOpen = true;
        val_10 = val_7.PolyNode;
        label_38:
        label_37:
        polytree.AddChild(Child:  val_10);
        label_41:
        val_9 = val_9 + 1;
        if(val_6 != val_9)
        {
            goto label_44;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixupOutPolyline(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outrec)
    {
        InternalClipper.IntPoint val_3;
        var val_4;
        label_9:
        label_6:
        if(outrec.Pts == outrec.Pts.Prev)
        {
            goto label_2;
        }
        
        if(outrec.Pts.Next != null)
        {
                val_3 = outrec.Pts.Next.Pt;
        }
        else
        {
                val_3 = 15026800;
            val_4 = 64;
        }
        
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = 15026800, Y = 64}, b:  new IntPoint() {X = outrec.Pts.Next.Prev.Pt})) == false)
        {
            goto label_6;
        }
        
        var val_2 = (outrec.Pts.Next == outrec.Pts.Prev) ? outrec.Pts.Next.Prev : outrec.Pts.Prev;
        outrec.Pts.Next.Prev.Next = outrec.Pts.Next.Next;
        outrec.Pts.Next.Next.Prev = outrec.Pts.Next.Prev;
        goto label_9;
        label_2:
        if(outrec.Pts.Prev != outrec.Pts.Prev.Prev)
        {
                return;
        }
        
        outrec.Pts = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixupOutPolygon(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec)
    {
        OutPt val_8;
        var val_9;
        OutPt val_10;
        long val_11;
        if(outRec != null)
        {
                outRec.BottomPt = 0;
        }
        else
        {
                mem[40] = 0;
        }
        
        val_8 = outRec.Pts;
        if(this.PreserveCollinear != false)
        {
            
        }
        else
        {
                var val_2 = ((this.<StrictlySimple>k__BackingField) == false) ? 1 : 0;
        }
        
        val_9 = 0;
        goto label_4;
        label_22:
        val_10 = outRec.Pts.Next;
        if(val_2 == val_10)
        {
            goto label_5;
        }
        
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = outRec.Pts.Pt, Y = X22}, b:  new IntPoint() {X = outRec.Pts.Next.Pt})) == true)
        {
            goto label_16;
        }
        
        val_10 = outRec.Pts.Prev;
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = outRec.Pts.Pt, Y = outRec.Pts.Pt}, b:  new IntPoint() {X = outRec.Pts.Prev.Pt})) == true)
        {
            goto label_16;
        }
        
        val_11 = mem[X28 + 24];
        val_11 = X28 + 24;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = val_11, Y = X28 + 24 + 8}, pt2:  new IntPoint() {X = outRec.Pts.Pt, Y = val_10}, pt3:  new IntPoint() {X = outRec.Pts.Next.Pt}, UseFullRange:  false)) == false)
        {
            goto label_12;
        }
        
        if((val_2 & 1) != 0)
        {
            goto label_16;
        }
        
        val_11 = mem[X28 + 24];
        val_11 = X28 + 24;
        if((this.Pt2IsBetweenPt1AndPt3(pt1:  new IntPoint() {X = val_11, Y = X28 + 24 + 8}, pt2:  new IntPoint() {X = outRec.Pts.Pt, Y = val_10}, pt3:  new IntPoint() {X = outRec.Pts.Next.Pt})) == false)
        {
            goto label_16;
        }
        
        label_12:
        if(val_8 == val_9)
        {
            goto label_17;
        }
        
        var val_7 = (val_9 == 0) ? (val_8) : (val_9);
        goto label_18;
        label_16:
        mem2[0] = outRec.Pts + 40;
        val_11 = mem[X28];
        val_11 = X28;
        val_9 = 0;
        mem2[0] = val_11;
        label_18:
        val_8 = mem[X28];
        val_8 = X28;
        label_4:
        if((X28 + 48) != val_8)
        {
            goto label_22;
        }
        
        label_5:
        label_25:
        mem2[0] = 0;
        return;
        label_17:
        if(outRec != 0)
        {
            goto label_25;
        }
        
        goto label_25;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt DupOutPt(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt outPt, bool InsertAfter)
    {
        int val_4;
        var val_5;
        var val_6;
        InternalClipper.OutPt val_1 = new InternalClipper.OutPt();
        if(val_1 != null)
        {
                .Pt = outPt.Pt;
            mem[1152921519915031536] = ???;
            val_4 = outPt.Idx;
        }
        else
        {
                mem[24] = outPt.Pt;
            mem[32] = ???;
            val_4 = outPt.Idx;
        }
        
        .Idx = val_4;
        if(InsertAfter != false)
        {
                val_5 = outPt;
            .Next = outPt.Next;
            .Prev = outPt;
            val_6 = (outPt + 40) + 48;
        }
        else
        {
                val_5 = outPt;
            .Next = outPt;
            .Prev = outPt.Prev;
            val_6 = (outPt + 48) + 40;
        }
        
        mem2[0] = val_1;
        mem2[0] = val_1;
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
    {
        long val_7;
        long val_8;
        if(a1 >= a2)
        {
            goto label_1;
        }
        
        if(b1 >= b2)
        {
            goto label_2;
        }
        
        Left = System.Math.Max(val1:  a1, val2:  b1);
        val_7 = a2;
        goto label_5;
        label_1:
        if(b1 >= b2)
        {
            goto label_6;
        }
        
        Left = System.Math.Max(val1:  a2, val2:  b1);
        val_7 = a1;
        label_5:
        val_8 = b2;
        goto label_9;
        label_2:
        Left = System.Math.Max(val1:  a1, val2:  b2);
        val_7 = a2;
        goto label_12;
        label_6:
        Left = System.Math.Max(val1:  a2, val2:  b2);
        val_7 = a1;
        label_12:
        val_8 = b1;
        label_9:
        long val_5 = System.Math.Min(val1:  val_7, val2:  val_8);
        Right = val_5;
        return (bool)(Left < val_5) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool JoinHorz(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op1b, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op2b, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint Pt, bool DiscardLeft)
    {
        bool val_24;
        InternalClipper.OutPt val_25;
        OutPt val_26;
        var val_27;
        OutPt val_28;
        bool val_29;
        InternalClipper.OutPt val_30;
        var val_31;
        InternalClipper.OutPt val_32;
        bool val_33;
        OutPt val_34;
        OutPt val_35;
        val_24 = DiscardLeft;
        val_25 = op2b;
        val_26 = op2;
        val_27 = op1;
        if(((op1.Pt <= op1b.Pt) ? 1 : 0) == ((op2.Pt <= op2b.Pt) ? 1 : 0))
        {
            goto label_4;
        }
        
        if(op1.Pt <= op1b.Pt)
        {
            goto label_5;
        }
        
        goto label_6;
        label_13:
        if((op1.Next.Pt < op1.Pt) || (op1.Next.Pt != Pt.Y))
        {
            goto label_10;
        }
        
        val_28 = op1.Next;
        label_5:
        if(op1.Next.Next.Pt <= Pt.X)
        {
            goto label_13;
        }
        
        label_10:
        if((val_24 != false) && (op1.Next.Pt != Pt.X))
        {
                val_28 = op1.Next.Next;
        }
        
        bool val_3 = val_24 ^ 1;
        val_25 = this.DupOutPt(outPt:  val_28, InsertAfter:  val_3);
        if((InternalClipper.IntPoint.op_Inequality(a:  new IntPoint() {X = val_5.Pt, Y = val_28}, b:  new IntPoint() {X = Pt.X, Y = Pt.Y})) == false)
        {
            goto label_29;
        }
        
        val_5.Pt = Pt.X;
        mem2[0] = Pt.Y;
        val_29 = val_3;
        goto label_18;
        label_25:
        if((op1.Next.Next.Next.Pt > op1.Next.Next.Pt) || (op1.Next.Next.Next.Pt != Pt.Y))
        {
            goto label_22;
        }
        
        val_28 = op1.Next.Next.Next;
        label_6:
        if(op1.Next.Next.Next.Next.Pt >= Pt.X)
        {
            goto label_25;
        }
        
        label_22:
        if((val_24 != true) && (op1.Next.Next.Next.Pt != Pt.X))
        {
                val_28 = op1.Next.Next.Next.Next;
        }
        
        val_25 = this.DupOutPt(outPt:  val_28, InsertAfter:  val_24);
        bool val_9 = InternalClipper.IntPoint.op_Inequality(a:  new IntPoint() {X = val_8.Pt, Y = val_28}, b:  new IntPoint() {X = Pt.X, Y = Pt.Y});
        if(val_9 == false)
        {
            goto label_29;
        }
        
        val_29 = val_24;
        val_8.Pt = Pt.X;
        mem2[0] = Pt.Y;
        label_18:
        val_30 = val_9.DupOutPt(outPt:  val_25, InsertAfter:  val_29);
        goto label_30;
        label_4:
        val_31 = 0;
        return (bool)val_31;
        label_29:
        val_30 = val_25;
        val_25 = val_28;
        label_30:
        if(op2.Pt <= op2b.Pt)
        {
            goto label_32;
        }
        
        goto label_33;
        label_40:
        if((op2.Next.Pt < op2.Pt) || (op2.Next.Pt != Pt.Y))
        {
            goto label_37;
        }
        
        val_26 = op2.Next;
        label_32:
        if(op2.Next.Next.Pt <= Pt.X)
        {
            goto label_40;
        }
        
        label_37:
        if((val_24 != false) && (op2.Next.Pt != Pt.X))
        {
                val_26 = op2.Next.Next;
        }
        
        bool val_11 = val_24 ^ 1;
        val_32 = this.DupOutPt(outPt:  val_26, InsertAfter:  val_11);
        if((InternalClipper.IntPoint.op_Inequality(a:  new IntPoint() {X = val_13.Pt, Y = val_26}, b:  new IntPoint() {X = Pt.X, Y = Pt.Y})) == false)
        {
            goto label_56;
        }
        
        val_13.Pt = Pt.X;
        mem2[0] = Pt.Y;
        val_33 = val_11;
        goto label_45;
        label_52:
        if((op2.Next.Next.Next.Pt > op2.Next.Next.Pt) || (op2.Next.Next.Next.Pt != Pt.Y))
        {
            goto label_49;
        }
        
        val_26 = op2.Next.Next.Next;
        label_33:
        if(op2.Next.Next.Next.Next.Pt >= Pt.X)
        {
            goto label_52;
        }
        
        label_49:
        if((val_24 != true) && (op2.Next.Next.Next.Pt != Pt.X))
        {
                val_26 = op2.Next.Next.Next.Next;
        }
        
        val_32 = this.DupOutPt(outPt:  val_26, InsertAfter:  val_24);
        bool val_17 = InternalClipper.IntPoint.op_Inequality(a:  new IntPoint() {X = val_16.Pt, Y = val_26}, b:  new IntPoint() {X = Pt.X, Y = Pt.Y});
        if(val_17 == false)
        {
            goto label_56;
        }
        
        val_33 = val_24;
        val_16.Pt = Pt.X;
        mem2[0] = Pt.Y;
        label_45:
        val_34 = val_17.DupOutPt(outPt:  val_32, InsertAfter:  val_33);
        goto label_57;
        label_56:
        val_34 = val_32;
        val_32 = val_26;
        label_57:
        val_24 = ((op1.Pt <= op1b.Pt) ? 1 : 0) ^ val_24;
        if(val_25 == null)
        {
            goto label_58;
        }
        
        if(val_24 == false)
        {
            goto label_59;
        }
        
        label_64:
        op1.Next.Next.Next = val_32;
        op2.Next.Next.Prev = val_25;
        val_5.Prev = val_34;
        val_35 = val_13.Next;
        goto label_63;
        label_58:
        if(val_24 == true)
        {
            goto label_64;
        }
        
        label_59:
        op1.Next.Next.Prev = val_32;
        op2.Next.Next.Next = val_25;
        val_5.Next = val_34;
        val_35 = val_13.Prev;
        label_63:
        val_31 = 1;
        mem2[0] = val_30;
        return (bool)val_31;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool JoinPoints(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Join j, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec2)
    {
        long val_28;
        OutPt val_29;
        OutPt val_30;
        InternalClipper.IntPoint val_31;
        OutPt val_32;
        long val_33;
        long val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        InternalClipper.IntPoint val_40;
        var val_41;
        var val_42;
        long val_43;
        long val_44;
        long val_46;
        long val_47;
        OutRec val_48;
        var val_49;
        OutPt val_50;
        var val_51;
        OutPt val_52;
        long val_5 = 0;
        long val_4 = 0;
        if(j == null)
        {
            goto label_0;
        }
        
        val_28 = j;
        val_29 = j.OutPt1;
        val_30 = val_29;
        if(val_29 != null)
        {
            goto label_67;
        }
        
        label_68:
        label_67:
        if(X25 != X8)
        {
            goto label_3;
        }
        
        val_32 = val_30;
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j.OffPt, Y = X25}, b:  new IntPoint() {X = j + 16 + 24, Y = j + 16 + 24 + 8})) == false)
        {
            goto label_18;
        }
        
        val_29 = mem[j + 16 + 8];
        val_29 = j + 16 + 8;
        val_31 = j.OffPt;
        val_33 = mem[j + 16 + 8 + 24 + 8];
        val_33 = j + 16 + 8 + 24 + 8;
        val_34 = j.OffPt;
        bool val_2 = InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = val_31, Y = val_34}, b:  new IntPoint() {X = j + 16 + 8 + 24, Y = val_33});
        val_32 = val_30;
        if(val_2 == false)
        {
            goto label_18;
        }
        
        if(outRec1 != outRec2)
        {
            goto label_100;
        }
        
        if((j + 16) == 0)
        {
            goto label_99;
        }
        
        label_12:
        val_35 = mem[j + 16 + 40];
        val_35 = j + 16 + 40;
        if(val_35 == val_30)
        {
            goto label_10;
        }
        
        val_34 = mem[j + 16 + 40 + 24 + 8];
        val_34 = j + 16 + 40 + 24 + 8;
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j + 16 + 40 + 24, Y = val_34}, b:  new IntPoint() {X = j.OffPt, Y = val_33})) == true)
        {
            goto label_12;
        }
        
        goto label_13;
        label_18:
        if((val_32 == X9) && (j.OutPt1.Prev != val_30))
        {
                if(j.OutPt1.Prev != (j + 16 + 8))
        {
            goto label_18;
        }
        
        }
        
        label_23:
        val_28 = val_30;
        val_29 = j.OutPt1.Next;
        val_30 = j.OutPt1.Next;
        if(j.OutPt1.Prev != X9)
        {
            goto label_21;
        }
        
        if(val_30 == val_32)
        {
            goto label_100;
        }
        
        if(val_30 != (j + 16 + 8))
        {
            goto label_23;
        }
        
        val_30 = j + 16 + 8;
        label_21:
        val_36 = 0;
        if((val_30 == val_32) || (val_30 == (j + 16 + 8)))
        {
            goto label_116;
        }
        
        label_30:
        if(((j + 16 + 8 + 48 + 32) == (j + 16 + 8 + 32)) && ((j + 16 + 8 + 48) != (j + 16 + 8)))
        {
                if((j + 16 + 8 + 48) != val_28)
        {
            goto label_30;
        }
        
        }
        
        label_35:
        val_29 = mem[j + 16 + 8 + 40];
        val_29 = j + 16 + 8 + 40;
        val_37 = mem[j + 16 + 8 + 32 + 8];
        val_37 = j + 16 + 8 + 32 + 8;
        if((j + 16 + 8 + 40 + 32) != (j + 16 + 8 + 32))
        {
            goto label_33;
        }
        
        if(val_37 == (j + 16 + 8))
        {
            goto label_100;
        }
        
        if(val_37 != val_32)
        {
            goto label_35;
        }
        
        val_37 = val_32;
        label_33:
        val_38 = 0;
        if((val_37 == (j + 16 + 8)) || (val_37 == val_32))
        {
            goto label_116;
        }
        
        if(val_32 == null)
        {
                val_39 = 0;
        }
        
        val_29 = j.OutPt1.Pt;
        if(val_28 == null)
        {
                val_39 = 0;
        }
        
        val_31 = j.OutPt1.Pt;
        if((j + 16 + 8) == 0)
        {
                val_39 = 0;
        }
        
        if((this.GetOverlap(a1:  val_29, a2:  val_31, b1:  j + 16 + 8 + 24, b2:  j + 16 + 8 + 24, Left: out  val_4, Right: out  val_5)) == false)
        {
            goto label_100;
        }
        
        val_40 = j.OutPt1.Pt;
        if(val_40 < val_4)
        {
            goto label_42;
        }
        
        val_41 = val_28;
        val_42 = val_32;
        if(val_40 <= val_5)
        {
            goto label_47;
        }
        
        label_42:
        val_40 = mem[j + 16 + 8 + 24];
        val_40 = j + 16 + 8 + 24;
        if(val_40 < val_4)
        {
            goto label_44;
        }
        
        val_41 = j + 16 + 8;
        val_42 = j + 16 + 8;
        if(val_40 <= val_5)
        {
            goto label_47;
        }
        
        label_44:
        val_40 = j.OutPt1.Pt;
        if(val_40 < val_4)
        {
            goto label_46;
        }
        
        val_42 = val_28;
        val_41 = val_32;
        if(val_40 <= val_5)
        {
            goto label_47;
        }
        
        label_46:
        val_40 = mem[j + 16 + 8 + 24];
        val_40 = j + 16 + 8 + 24;
        val_42 = j + 16 + 8;
        val_41 = j + 16 + 8;
        label_47:
        if(j == null)
        {
            goto label_48;
        }
        
        mem2[0] = val_32;
        goto label_49;
        label_3:
        label_54:
        val_44 = j + 16 + 8;
        if(j.OutPt1.Next != val_30)
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j.OutPt1.Next.Pt, Y = val_44}, b:  new IntPoint() {X = j.OutPt1.Pt, Y = outRec2})) == true)
        {
            goto label_54;
        }
        
        }
        
        if(j.OutPt1.Next.Pt > (j + 16 + 8))
        {
            goto label_57;
        }
        
        val_29 = j.OutPt1.Next.Pt;
        val_44 = j + 16 + 8;
        val_43 = j.OutPt1.Next.Pt;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = j.OutPt1.Pt, Y = val_44}, pt2:  new IntPoint() {X = val_29, Y = val_43}, pt3:  new IntPoint() {X = j.OffPt}, UseFullRange:  false)) == false)
        {
            goto label_57;
        }
        
        if((j + 16 + 8) != 0)
        {
            goto label_75;
        }
        
        label_76:
        label_75:
        label_62:
        val_29 = mem[j + 16 + 8 + 40];
        val_29 = j + 16 + 8 + 40;
        val_46 = mem[j + 16 + 8 + 24 + 8];
        val_46 = j + 16 + 8 + 24 + 8;
        val_47 = j + 16 + 8 + 40 + 24 + 8;
        if(val_29 != (j + 16 + 8))
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j + 16 + 8 + 40 + 24, Y = val_47}, b:  new IntPoint() {X = j + 16 + 8 + 24, Y = val_46})) == true)
        {
            goto label_62;
        }
        
        }
        
        val_31 = mem[j + 16 + 8 + 40 + 32];
        val_31 = j + 16 + 8 + 40 + 32;
        if(val_31 > (j + 16 + 8 + 32))
        {
            goto label_65;
        }
        
        val_47 = j + 16 + 8 + 32;
        val_46 = val_31;
        val_48 = outRec1;
        val_28 = j + 16;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = j + 16 + 8 + 24, Y = val_47}, pt2:  new IntPoint() {X = j + 16 + 8 + 40 + 24, Y = val_46}, pt3:  new IntPoint() {X = j.OffPt}, UseFullRange:  false)) == false)
        {
            goto label_65;
        }
        
        val_49 = 0;
        goto label_66;
        label_0:
        if(11993091 != 0)
        {
            goto label_67;
        }
        
        goto label_68;
        label_57:
        label_71:
        if(j.OutPt1.Prev != val_30)
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j.OutPt1.Prev.Pt, Y = val_44}, b:  new IntPoint() {X = j.OutPt1.Pt, Y = outRec2})) == true)
        {
            goto label_71;
        }
        
        }
        
        if(j.OutPt1.Next.Pt > (j + 16 + 8))
        {
            goto label_100;
        }
        
        val_29 = j.OutPt1.Prev.Pt;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = j.OutPt1.Pt, Y = j + 16 + 8}, pt2:  new IntPoint() {X = val_29, Y = j.OutPt1.Next.Pt}, pt3:  new IntPoint() {X = j.OffPt}, UseFullRange:  false)) == false)
        {
            goto label_100;
        }
        
        if((j + 16 + 8) != 0)
        {
            goto label_75;
        }
        
        goto label_76;
        label_65:
        label_79:
        val_29 = mem[j + 16 + 8 + 48];
        val_29 = j + 16 + 8 + 48;
        if(val_29 != (j + 16 + 8))
        {
                if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j + 16 + 8 + 48 + 24, Y = j + 16 + 8 + 48 + 24 + 8}, b:  new IntPoint() {X = j + 16 + 8 + 24, Y = j + 16 + 8 + 24 + 8})) == true)
        {
            goto label_79;
        }
        
        }
        
        val_31 = mem[j + 16 + 8 + 48 + 32];
        val_31 = j + 16 + 8 + 48 + 32;
        if(val_31 > (j + 16 + 8 + 32))
        {
            goto label_100;
        }
        
        val_28 = mem[j + 16 + 8 + 48 + 24];
        val_28 = j + 16 + 8 + 48 + 24;
        if((InternalClipper.ClipperBase.SlopesEqual(pt1:  new IntPoint() {X = j + 16 + 8 + 24, Y = j + 16 + 8 + 32}, pt2:  new IntPoint() {X = val_28, Y = val_31}, pt3:  new IntPoint() {X = j.OffPt}, UseFullRange:  false)) == false)
        {
            goto label_100;
        }
        
        val_48 = outRec1;
        val_49 = 1;
        label_66:
        val_28 = j + 16 + 8;
        val_36 = 0;
        if(((j.OutPt1.Next == val_29) || (j.OutPt1.Next == val_30)) || (val_29 == (j + 16 + 8)))
        {
            goto label_116;
        }
        
        if(val_48 == outRec2)
        {
                if(1 == val_49)
        {
            goto label_100;
        }
        
        }
        
        if(1 == 0)
        {
            goto label_88;
        }
        
        InternalClipper.OutPt val_15 = this.DupOutPt(outPt:  val_30, InsertAfter:  false);
        val_50 = val_15;
        j.OutPt1.Prev = j + 16 + 8;
        mem2[0] = val_30;
        val_15.Next = val_15.DupOutPt(outPt:  j + 16 + 8, InsertAfter:  true);
        val_16.Prev = val_50;
        goto label_92;
        label_10:
        val_35 = val_30;
        if(val_30 == null)
        {
            goto label_99;
        }
        
        label_13:
        if((j + 16 + 8) == 0)
        {
            goto label_99;
        }
        
        label_97:
        val_51 = mem[j + 16 + 8 + 40];
        val_51 = j + 16 + 8 + 40;
        if(val_51 == (j + 16 + 8))
        {
            goto label_95;
        }
        
        if((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = j + 16 + 8 + 40 + 24, Y = j + 16 + 8 + 40 + 24 + 8}, b:  new IntPoint() {X = j.OffPt, Y = val_33})) == true)
        {
            goto label_97;
        }
        
        goto label_98;
        label_95:
        val_51 = j + 16 + 8;
        if((j + 16 + 8) == 0)
        {
            goto label_99;
        }
        
        label_98:
        if(((val_35 > outRec2) ? 1 : 0) == (((j + 16 + 8 + 32) > X9) ? 1 : 0))
        {
            goto label_100;
        }
        
        if(val_35 <= outRec2)
        {
            goto label_101;
        }
        
        InternalClipper.OutPt val_20 = val_2.DupOutPt(outPt:  val_30, InsertAfter:  false);
        val_52 = val_20;
        j.OutPt1.Prev = j + 16 + 8;
        mem2[0] = val_30;
        val_20.Next = val_20.DupOutPt(outPt:  j + 16 + 8, InsertAfter:  true);
        val_21.Prev = val_52;
        goto label_106;
        label_100:
        val_36 = 0;
        label_116:
        val_36 = val_36 & 1;
        return (bool)val_36;
        label_88:
        InternalClipper.OutPt val_22 = this.DupOutPt(outPt:  val_30, InsertAfter:  true);
        val_50 = val_22;
        j.OutPt1.Next = j + 16 + 8;
        mem2[0] = val_30;
        val_22.Prev = val_22.DupOutPt(outPt:  j + 16 + 8, InsertAfter:  false);
        val_23.Next = val_50;
        label_92:
        mem2[0] = val_30;
        mem2[0] = val_50;
        goto label_116;
        label_101:
        InternalClipper.OutPt val_24 = val_2.DupOutPt(outPt:  val_30, InsertAfter:  true);
        val_52 = val_24;
        j.OutPt1.Next = j + 16 + 8;
        mem2[0] = val_30;
        val_24.Prev = val_24.DupOutPt(outPt:  j + 16 + 8, InsertAfter:  false);
        val_25.Next = val_52;
        label_106:
        mem2[0] = val_30;
        mem2[0] = val_52;
        goto label_116;
        label_48:
        mem2[0] = val_32;
        label_49:
        mem2[0] = j + 16 + 8;
        bool val_27 = this.JoinHorz(op1:  val_32, op1b:  val_28, op2:  j + 16 + 8, op2b:  j + 16 + 8, Pt:  new IntPoint() {X = val_40, Y = j + 16 + 8 + 32}, DiscardLeft:  (val_40 > (j + 16 + 8 + 24)) ? 1 : 0);
        goto label_116;
        label_99:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int PointInPolygon(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt, System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> path)
    {
        var val_18;
        var val_19;
        var val_20;
        int val_1 = path.Count;
        if(val_1 < 3)
        {
            goto label_2;
        }
        
        IntPoint val_2 = path.Item[0];
        val_18 = val_2.X;
        val_19 = 0;
        var val_17 = 1;
        label_16:
        IntPoint val_4 = path.Item[(val_1 == val_17) ? 0 : (val_17)];
        if(val_4.Y != pt.Y)
        {
            goto label_7;
        }
        
        if(val_4.X == pt.X)
        {
            goto label_15;
        }
        
        if(val_2.Y != pt.Y)
        {
            goto label_7;
        }
        
        var val_5 = (val_4.X > pt.X) ? 1 : 0;
        var val_6 = (val_18 < pt.X) ? 1 : 0;
        if(val_6 == val_5)
        {
            goto label_15;
        }
        
        label_7:
        var val_8 = (val_6 < val_5) ? 1 : 0;
        var val_10 = (val_6 < val_5) ? 1 : 0;
        if(val_8 == val_10)
        {
            goto label_14;
        }
        
        if(val_8 >= val_10)
        {
            goto label_10;
        }
        
        val_20 = val_4.X - pt.X;
        if(val_8 > val_10)
        {
            goto label_13;
        }
        
        goto label_14;
        label_10:
        val_20 = val_4.X - pt.X;
        if(val_8 <= val_10)
        {
            goto label_13;
        }
        
        val_19 = 1 - val_19;
        goto label_14;
        label_13:
        double val_16 = (double)val_18 - pt.X;
        val_16 = val_16 * ((double)val_4.Y - pt.Y);
        val_16 = val_16 - (((double)val_2.Y - pt.Y) * (double)val_20);
        if(val_16 == 0f)
        {
            goto label_15;
        }
        
        var val_13 = (val_16 > 0f) ? 1 : 0;
        val_13 = ((val_4.Y > val_2.Y) ? 1 : 0) ^ val_13;
        val_19 = (val_13 != 0) ? (val_19) : (1 - val_19);
        label_14:
        val_17 = val_17 + 1;
        val_18 = val_4.X;
        if(val_17 <= val_1)
        {
            goto label_16;
        }
        
        return (int)val_19;
        label_2:
        val_19 = 0;
        return (int)val_19;
        label_15:
        val_19 = 0;
        return (int)val_19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int PointInPolygon(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op)
    {
        InternalClipper.IntPoint val_14;
        var val_15;
        var val_16;
        InternalClipper.IntPoint val_17;
        var val_18;
        if(op != null)
        {
                val_14 = op.Pt;
        }
        else
        {
                val_14 = 15026800;
        }
        
        val_16 = 0;
        label_15:
        if(op.Next != null)
        {
                val_17 = op.Next.Pt;
        }
        else
        {
                val_17 = 15026800;
        }
        
        if(24 != pt.Y)
        {
            goto label_6;
        }
        
        if(15026800 == pt.X)
        {
            goto label_14;
        }
        
        if(X27 != pt.Y)
        {
            goto label_6;
        }
        
        var val_1 = (15026800 > pt.X) ? 1 : 0;
        var val_2 = (15026800 < pt.X) ? 1 : 0;
        if(val_2 == val_1)
        {
            goto label_14;
        }
        
        label_6:
        var val_4 = (val_2 < val_1) ? 1 : 0;
        var val_6 = (val_2 < val_1) ? 1 : 0;
        if(val_4 == val_6)
        {
            goto label_13;
        }
        
        if(val_4 >= val_6)
        {
            goto label_9;
        }
        
        val_18 = val_17 - pt.X;
        if(val_4 > val_6)
        {
            goto label_12;
        }
        
        goto label_13;
        label_9:
        val_18 = val_17 - pt.X;
        if(val_4 <= val_6)
        {
            goto label_12;
        }
        
        val_16 = 1 - val_16;
        goto label_13;
        label_12:
        double val_12 = (double)val_14 - pt.X;
        val_12 = val_12 * ((double)24 - pt.Y);
        val_12 = val_12 - (((double)X27 - pt.Y) * (double)val_18);
        if(val_12 == 0f)
        {
            goto label_14;
        }
        
        var val_9 = (val_12 > 0f) ? 1 : 0;
        val_9 = ((24 > X27) ? 1 : 0) ^ val_9;
        val_16 = (val_9 != 0) ? (val_16) : (1 - val_16);
        label_13:
        val_15 = 24;
        if(op.Next != op)
        {
            goto label_15;
        }
        
        return (int)val_16;
        label_14:
        val_16 = 0;
        return (int)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool Poly2ContainsPoly1(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt outPt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt outPt2)
    {
        var val_3;
        do
        {
            int val_1 = InternalClipper.Clipper.PointInPolygon(pt:  new IntPoint() {X = outPt1.Pt, Y = outPt2}, op:  outPt2);
            if((val_1 & 2147483648) == 0)
        {
                return (bool)(val_1 != 0) ? 1 : 0;
        }
        
        }
        while(outPt1.Next != outPt1);
        
        val_3 = 1;
        return (bool)(val_1 != 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixupFirstLefts1(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec OldOutRec, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec NewOutRec)
    {
        GameUI.ServerGameUIDataModel val_6;
        var val_7;
        GameUI.ServerGameUIDataModel val_8;
        val_6 = NewOutRec;
        List.Enumerator<T> val_1 = this.GetEnumerator();
        goto label_11;
        label_12:
        val_7 = 0.emailUIDataHandler;
        val_8 = val_2._serverGameUIDataModel;
        if(val_8 == null)
        {
            goto label_5;
        }
        
        label_6:
        if((val_2._serverGameUIDataModel.<modSlotUnlocks>k__BackingField) != 0)
        {
            goto label_5;
        }
        
        val_8 = val_2._serverGameUIDataModel.<currentStreak>k__BackingField;
        if(val_8 != 0)
        {
            goto label_6;
        }
        
        label_5:
        if((val_8 == OldOutRec) && (val_2._emailDatas != null))
        {
                if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_2._emailDatas, outPt2:  NewOutRec.Pts)) != false)
        {
                val_2._serverGameUIDataModel = val_6;
        }
        
        }
        
        label_11:
        if(((-1870445224) & 1) != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixupFirstLefts2(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec innerOutRec, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outerOutRec)
    {
        var val_3;
        GameUI.ServerGameUIDataModel val_9;
        var val_10;
        System.Collections.Generic.List<GameUI.EmailData> val_11;
        GameUI.ServerGameUIDataModel val_12;
        val_9 = outerOutRec;
        List.Enumerator<T> val_1 = this.GetEnumerator();
        goto label_24;
        label_25:
        val_10 = val_3.emailUIDataHandler;
        if((val_10 == innerOutRec) || (val_10 == val_9))
        {
            goto label_24;
        }
        
        val_11 = val_4._emailDatas;
        if(val_11 == null)
        {
            goto label_24;
        }
        
        val_12 = val_4._serverGameUIDataModel;
        if(val_12 == null)
        {
            goto label_9;
        }
        
        label_10:
        if((val_4._serverGameUIDataModel.<modSlotUnlocks>k__BackingField) != 0)
        {
            goto label_9;
        }
        
        val_12 = val_4._serverGameUIDataModel.<currentStreak>k__BackingField;
        if(val_12 != 0)
        {
            goto label_10;
        }
        
        label_9:
        if((val_12 != val_9) && (val_12 != outerOutRec.FirstLeft))
        {
                if(val_12 != innerOutRec)
        {
            goto label_24;
        }
        
        }
        
        if(val_10 == null)
        {
            goto label_14;
        }
        
        if(innerOutRec != null)
        {
            goto label_17;
        }
        
        goto label_16;
        label_14:
        val_11 = val_4._emailDatas;
        if(innerOutRec != null)
        {
            goto label_17;
        }
        
        label_16:
        label_17:
        if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_11, outPt2:  innerOutRec.Pts)) != false)
        {
                val_4._serverGameUIDataModel = innerOutRec;
        }
        else
        {
                if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_4._emailDatas, outPt2:  outerOutRec.Pts)) != false)
        {
                val_4._serverGameUIDataModel = val_9;
        }
        else
        {
                if(val_4._serverGameUIDataModel != innerOutRec)
        {
                if(val_4._serverGameUIDataModel != val_9)
        {
            goto label_24;
        }
        
        }
        
            val_4._serverGameUIDataModel = outerOutRec.FirstLeft;
        }
        
        }
        
        label_24:
        if(((-1870255424) & 1) != 0)
        {
            goto label_25;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FixupFirstLefts3(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec OldOutRec, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec NewOutRec)
    {
        GameUI.ServerGameUIDataModel val_5;
        var val_6;
        val_5 = NewOutRec;
        List.Enumerator<T> val_1 = this.GetEnumerator();
        goto label_5;
        label_6:
        val_6 = 0.emailUIDataHandler;
        if((val_2._emailDatas != null) && (val_2._serverGameUIDataModel == OldOutRec))
        {
                val_2._serverGameUIDataModel = val_5;
        }
        
        label_5:
        if(((-1870069672) & 1) != 0)
        {
            goto label_6;
        }
        
        long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519916646488});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec ParseFirstLeft(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec FirstLeft)
    {
        goto label_0;
        label_2:
        if(FirstLeft.Pts != null)
        {
                return (OutRec)FirstLeft.FirstLeft;
        }
        
        label_0:
        if(FirstLeft.FirstLeft != null)
        {
            goto label_2;
        }
        
        return (OutRec)FirstLeft.FirstLeft;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void JoinCommonEdges()
    {
        OutRec val_21;
        InternalClipper.OutPt val_22;
        var val_23;
        int val_1 = this.m_Joins.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_23 = 0;
        goto label_49;
        label_43:
        mem2[0] = ???;
        label_44:
        mem2[0] = 0;
        OutRec val_2 = this.CreateOutRec();
        val_21 = val_2;
        if(val_21 != null)
        {
                val_22 = val_21;
            val_2.Pts = X23 + 24;
            val_2.UpdateOutPtIdxs(outrec:  val_21);
        }
        else
        {
                mem[32] = X23 + 24;
            val_2.UpdateOutPtIdxs(outrec:  0);
            val_22 = 32;
        }
        
        if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_22, outPt2:  X22 + 32)) == false)
        {
            goto label_6;
        }
        
        if(val_21 == null)
        {
            goto label_7;
        }
        
        val_23 = val_21;
        val_2.IsHole = ((X22 + 20) == 0) ? 1 : 0;
        goto label_8;
        label_6:
        val_22 = mem[X22 + 20];
        val_22 = X22 + 20;
        val_2.IsHole = val_22;
        if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  X22 + 32, outPt2:  mem[32])) == false)
        {
            goto label_11;
        }
        
        mem2[0] = val_22 ^ 1;
        val_2.FirstLeft = X22 + 24;
        mem2[0] = val_21;
        if(this.m_UsingPolyTree != false)
        {
                this.FixupFirstLefts2(innerOutRec:  X22, outerOutRec:  val_21);
        }
        
        var val_21 = X22 + 20;
        val_21 = ((val_21 != 0) ? 1 : 0) ^ (((this.<ReverseSolution>k__BackingField) == true) ? 1 : 0);
        val_21 = val_21 ^ (((this.Area(outRec:  X22)) > 0f) ? 1 : 0);
        if((val_21 & 1) != 0)
        {
            goto label_48;
        }
        
        this.ReversePolyPtLinks(pp:  X22 + 32);
        goto label_48;
        label_11:
        val_2.FirstLeft = X22 + 24;
        if(this.m_UsingPolyTree == false)
        {
            goto label_48;
        }
        
        this.FixupFirstLefts1(OldOutRec:  X22, NewOutRec:  val_21);
        goto label_48;
        label_7:
        mem[20] = ((X22 + 20) == 0) ? 1 : 0;
        val_23 = 20;
        label_8:
        val_2.FirstLeft = null;
        if(this.m_UsingPolyTree != false)
        {
                this.FixupFirstLefts2(innerOutRec:  val_21, outerOutRec:  X22);
        }
        
        var val_22 = mem[20];
        val_22 = ((val_22 != 0) ? 1 : 0) ^ (((this.<ReverseSolution>k__BackingField) == true) ? 1 : 0);
        val_22 = val_22 ^ (((this.Area(outRec:  val_21)) > 0f) ? 1 : 0);
        if((val_22 & 1) != 0)
        {
            goto label_48;
        }
        
        this.ReversePolyPtLinks(pp:  mem[32]);
        goto label_48;
        label_49:
        val_21 = this.m_Joins.Item[0];
        OutRec val_17 = this.GetOutRec(idx:  val_16.OutPt1.Idx);
        OutRec val_18 = this.GetOutRec(idx:  val_16.OutPt2.Idx);
        if((((val_17.Pts == null) || (val_18.Pts == null)) || (val_17.IsOpen == true)) || (val_18.IsOpen == true))
        {
            goto label_48;
        }
        
        val_22 = val_17;
        if(val_17 == val_18)
        {
            goto label_37;
        }
        
        label_32:
        if(val_17.FirstLeft == val_18)
        {
            goto label_31;
        }
        
        if(val_17.FirstLeft != null)
        {
            goto label_32;
        }
        
        label_35:
        if(val_18.FirstLeft == val_17)
        {
            goto label_34;
        }
        
        if(val_18.FirstLeft != null)
        {
            goto label_35;
        }
        
        val_22 = this.GetLowermostRec(outRec1:  val_17, outRec2:  val_18);
        goto label_37;
        label_31:
        val_22 = val_18;
        goto label_37;
        label_34:
        val_22 = val_17;
        label_37:
        if((this.JoinPoints(j:  val_21, outRec1:  val_17, outRec2:  val_18)) == false)
        {
            goto label_48;
        }
        
        if(val_17 == val_18)
        {
            goto label_39;
        }
        
        if(val_18 == null)
        {
            goto label_40;
        }
        
        val_18.Pts = 0;
        goto label_41;
        label_39:
        if(val_17 == null)
        {
            goto label_43;
        }
        
        val_17.Pts = val_16.OutPt1;
        goto label_44;
        label_40:
        val_18.Pts = 0;
        label_41:
        val_18.BottomPt = 0;
        val_18.Idx = val_17.Idx;
        val_17.IsHole = val_17.IsHole;
        if(val_22 == val_18)
        {
                val_17.FirstLeft = val_18.FirstLeft;
        }
        
        val_18.FirstLeft = val_17;
        if(this.m_UsingPolyTree != false)
        {
                this.FixupFirstLefts3(OldOutRec:  val_18, NewOutRec:  val_17);
        }
        
        label_48:
        val_23 = val_23 + 1;
        if(val_23 != val_1)
        {
            goto label_49;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateOutPtIdxs(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outrec)
    {
        do
        {
            if(outrec.Pts != null)
        {
                outrec.Pts.Idx = outrec.Idx;
        }
        else
        {
                mem[16] = outrec.Idx;
        }
        
        }
        while(outrec.Pts.Prev != outrec.Pts);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void DoSimplePolygons()
    {
        long val_11;
        OutRec val_12;
        var val_13;
        OutRec val_14;
        OutRec val_15;
        var val_16;
        InternalClipper.OutPt val_17;
        val_11 = 1152921519903249216;
        val_12 = 1152921519903378624;
        val_13 = 0;
        goto label_5;
        label_35:
        OutRec val_1 = Item[0];
        val_13 = 1;
        if(val_1.Pts == null)
        {
            goto label_5;
        }
        
        val_13 = 1;
        if(val_1.IsOpen == true)
        {
            goto label_5;
        }
        
        goto label_33;
        label_29:
        val_14 = val_12;
        val_15 = val_1;
        goto label_7;
        label_27:
        val_14 = val_1;
        val_15 = val_12;
        label_7:
        this.FixupFirstLefts2(innerOutRec:  val_14, outerOutRec:  val_15);
        label_32:
        val_16 = val_1.Pts;
        goto label_31;
        label_33:
        val_16 = val_1.Pts;
        if(val_1.Pts != null)
        {
            goto label_31;
        }
        
        goto label_32;
        label_31:
        if(val_1.Pts.Next == val_1.Pts)
        {
            goto label_12;
        }
        
        if((((InternalClipper.IntPoint.op_Equality(a:  new IntPoint() {X = val_1.Pts.Pt, Y = val_11}, b:  new IntPoint() {X = val_1.Pts.Next.Pt})) == false) || (val_1.Pts.Next.Next == val_1.Pts)) || (val_1.Pts.Next.Prev == val_1.Pts))
        {
            goto label_31;
        }
        
        val_1.Pts.Prev = val_1.Pts.Next.Prev;
        val_1.Pts.Next.Prev.Next = val_1.Pts;
        val_1.Pts.Next.Prev = val_1.Pts.Prev;
        val_1.Pts.Prev.Next = val_1.Pts.Next;
        val_1.Pts = val_1.Pts;
        OutRec val_3 = this.CreateOutRec();
        if(val_3 != null)
        {
                val_17 = val_3;
            val_3.Pts = val_1.Pts.Next;
            val_3.UpdateOutPtIdxs(outrec:  val_3);
        }
        else
        {
                mem[32] = val_1.Pts.Next;
            val_3.UpdateOutPtIdxs(outrec:  0);
            val_17 = 32;
        }
        
        if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_17, outPt2:  val_1.Pts)) == false)
        {
            goto label_21;
        }
        
        if(val_3 == null)
        {
            goto label_22;
        }
        
        val_3.IsHole = (val_1.IsHole == false) ? 1 : 0;
        goto label_23;
        label_21:
        if(val_3 == null)
        {
            goto label_24;
        }
        
        val_3.IsHole = val_1.IsHole;
        if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_1.Pts, outPt2:  mem[32])) == false)
        {
            goto label_25;
        }
        
        label_30:
        val_1.IsHole = val_1.IsHole ^ 1;
        val_3.FirstLeft = val_1.FirstLeft;
        val_1.FirstLeft = val_3;
        if(this.m_UsingPolyTree == false)
        {
            goto label_31;
        }
        
        goto label_27;
        label_22:
        mem[20] = (val_1.IsHole == false) ? 1 : 0;
        label_23:
        val_3.FirstLeft = val_1;
        if(this.m_UsingPolyTree == false)
        {
            goto label_31;
        }
        
        goto label_29;
        label_24:
        val_3.IsHole = val_1.IsHole;
        if((InternalClipper.Clipper.Poly2ContainsPoly1(outPt1:  val_1.Pts, outPt2:  mem[32])) == true)
        {
            goto label_30;
        }
        
        label_25:
        val_3.FirstLeft = val_1.FirstLeft;
        if(this.m_UsingPolyTree == false)
        {
            goto label_31;
        }
        
        this.FixupFirstLefts1(OldOutRec:  val_1, NewOutRec:  val_3);
        goto label_32;
        label_12:
        if(val_1.Pts.Next != val_1.Pts)
        {
            goto label_33;
        }
        
        val_11 = 1152921519903249216;
        val_12 = 1152921519903378624;
        val_13 = 1;
        label_5:
        if(val_13 < val_1.Count)
        {
            goto label_35;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static double Area(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> poly)
    {
        var val_11;
        var val_12;
        var val_13;
        int val_1 = poly.Count;
        if(val_1 < 3)
        {
                return (double)val_14;
        }
        
        var val_12 = 0;
        int val_2 = val_1 - 1;
        double val_13 = 0;
        do
        {
            if(poly != null)
        {
                IntPoint val_3 = poly.Item[val_2];
            val_11 = val_3.X;
            IntPoint val_4 = poly.Item[0];
            val_12 = val_4.X;
            IntPoint val_5 = poly.Item[val_2];
            val_13 = val_5.Y;
        }
        else
        {
                IntPoint val_6 = 0.Item[val_2];
            val_11 = val_6.X;
            IntPoint val_7 = 0.Item[0];
            val_12 = val_7.X;
            IntPoint val_8 = 0.Item[val_2];
            val_13 = val_8.Y;
        }
        
            IntPoint val_9 = poly.Item[0];
            double val_11 = (double)val_11;
            val_11 = val_11 + (double)val_12;
            val_12 = val_12 + 1;
            val_11 = val_11 * ((double)val_13 - (double)val_9.Y);
            val_13 = val_13 + val_11;
        }
        while(val_1 != val_12);
        
        double val_14 = -0.5;
        val_14 = val_13 * val_14;
        return (double)val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal double Area(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutRec outRec)
    {
        if(outRec != null)
        {
                return this.Area(op:  outRec.Pts);
        }
        
        return this.Area(op:  outRec.Pts);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal double Area(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op)
    {
        OutPt val_1;
        if(op == null)
        {
                return 0;
        }
        
        double val_3 = 0;
        label_4:
        val_1 = op.Prev;
        if(op.Prev != null)
        {
            goto label_2;
        }
        
        val_1 = op.Prev;
        if(val_1 == null)
        {
            goto label_3;
        }
        
        label_2:
        InternalClipper.IntPoint val_1 = op.Prev.Pt;
        val_1 = op.Pt + val_1;
        val_1 = val_1 - X11;
        double val_2 = (double)val_1;
        val_2 = val_2 * (double)val_1;
        val_3 = val_3 + val_2;
        if(op.Next != op)
        {
            goto label_4;
        }
        
        double val_4 = 0.5;
        val_4 = val_3 * val_4;
        return 0;
        label_3:
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> SimplifyPolygon(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> poly, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType fillType = 0)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        InternalClipper.Clipper val_2 = new InternalClipper.Clipper(InitOptions:  0);
        if(val_2 != null)
        {
                .<StrictlySimple>k__BackingField = true;
            bool val_3 = val_2.AddPath(pg:  poly, polyType:  0, Closed:  true);
        }
        else
        {
                .<StrictlySimple>k__BackingField = true;
            bool val_4 = 0.AddPath(pg:  poly, polyType:  0, Closed:  true);
        }
        
        bool val_5 = val_2.Execute(clipType:  1, solution:  val_1, subjFillType:  fillType, clipFillType:  fillType);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> SimplifyPolygons(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> polys, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyFillType fillType = 0)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        InternalClipper.Clipper val_2 = new InternalClipper.Clipper(InitOptions:  0);
        if(val_2 != null)
        {
                .<StrictlySimple>k__BackingField = true;
            bool val_3 = val_2.AddPaths(ppg:  polys, polyType:  0, closed:  true);
        }
        else
        {
                .<StrictlySimple>k__BackingField = true;
            bool val_4 = 0.AddPaths(ppg:  polys, polyType:  0, closed:  true);
        }
        
        bool val_5 = val_2.Execute(clipType:  1, solution:  val_1, subjFillType:  fillType, clipFillType:  fillType);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static double DistanceSqrd(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2)
    {
        double val_2 = (double)pt1.Y;
        val_2 = val_2 - (double)pt2.Y;
        double val_1 = (double)pt1.X - (double)pt2.X;
        val_1 = val_1 * val_1;
        val_2 = val_2 * val_2;
        val_2 = val_1 + val_2;
        return (double)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static double DistanceFromLineSqrd(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint ln1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint ln2)
    {
        double val_4 = (double)ln1.X;
        double val_5 = (double)ln1.Y;
        double val_8 = (double)ln1.Y - ln2.Y;
        double val_9 = (double)ln2.X - ln1.X;
        val_4 = val_4 * val_8;
        val_5 = val_5 * val_9;
        double val_6 = (double)pt.X;
        val_4 = val_4 + val_5;
        double val_7 = (double)pt.Y;
        val_6 = val_6 * val_8;
        val_7 = val_7 * val_9;
        val_7 = val_6 + val_7;
        val_8 = val_8 * val_8;
        val_9 = val_9 * val_9;
        val_4 = val_7 - val_4;
        val_4 = val_4 * val_4;
        val_4 = val_4 / (val_8 + val_9);
        return (double)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool SlopesNearCollinear(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt3, double distSqrd)
    {
        long val_15;
        long val_16;
        long val_17;
        long val_18;
        long val_19;
        long val_20;
        long val_1 = pt1.X - pt2.X;
        long val_3 = pt1.Y - pt2.Y;
        if(((<0) ? (-val_1) : (val_1)) <= ((<0) ? (-val_3) : (val_3)))
        {
            goto label_3;
        }
        
        var val_5 = (pt1.X > pt2.X) ? 1 : 0;
        val_5 = val_5 ^ ((pt1.X < pt3.X) ? 1 : 0);
        if((val_5 & 1) == 0)
        {
            goto label_6;
        }
        
        var val_7 = (pt1.X < pt2.X) ? 1 : 0;
        goto label_5;
        label_3:
        var val_8 = (pt1.Y > pt2.Y) ? 1 : 0;
        val_8 = val_8 ^ ((pt1.Y < pt3.Y) ? 1 : 0);
        if((val_8 & 1) == 0)
        {
            goto label_6;
        }
        
        var val_10 = (pt1.Y < pt2.Y) ? 1 : 0;
        label_5:
        val_10 = val_10 ^ ((pt2.Y < pt3.Y) ? 1 : 0);
        if((val_10 & 1) == 0)
        {
            goto label_7;
        }
        
        val_15 = pt3.X;
        val_16 = pt3.Y;
        val_17 = pt1.X;
        val_18 = pt1.Y;
        val_19 = pt2.X;
        val_20 = pt2.Y;
        return (bool)((InternalClipper.Clipper.DistanceFromLineSqrd(pt:  new IntPoint() {X = val_15, Y = val_16}, ln1:  new IntPoint() {X = val_17, Y = val_18}, ln2:  new IntPoint() {X = val_19, Y = val_20})) < 0) ? 1 : 0;
        label_6:
        val_15 = pt1.X;
        val_16 = pt1.Y;
        val_17 = pt2.X;
        val_18 = pt2.Y;
        goto label_9;
        label_7:
        val_15 = pt2.X;
        val_16 = pt2.Y;
        val_17 = pt1.X;
        val_18 = pt1.Y;
        label_9:
        val_19 = pt3.X;
        val_20 = pt3.Y;
        return (bool)((InternalClipper.Clipper.DistanceFromLineSqrd(pt:  new IntPoint() {X = val_15, Y = val_16}, ln1:  new IntPoint() {X = val_17, Y = val_18}, ln2:  new IntPoint() {X = val_19, Y = val_20})) < 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static bool PointsAreClose(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint pt2, double distSqrd)
    {
        double val_2 = (double)pt1.Y;
        val_2 = val_2 - (double)pt2.Y;
        double val_3 = (double)pt2.X;
        val_3 = (double)pt1.X - val_3;
        val_3 = val_3 * val_3;
        val_2 = val_2 * val_2;
        val_2 = val_3 + val_2;
        return (bool)(val_2 <= distSqrd) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt ExcludeOp(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.OutPt op)
    {
        OutPt val_1;
        if(op != null)
        {
                val_1 = op.Prev;
        }
        else
        {
                val_1 = 0;
        }
        
        mem[15762873573703720] = op.Next;
        op.Next.Prev = val_1;
        mem[15762873573703696] = 0;
        return (InternalClipper.OutPt)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> CleanPolygon(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> path, double distance = 1.415)
    {
        var val_11;
        InternalClipper.OutPt val_12;
        int val_13;
        var val_14;
        InternalClipper.OutPt val_15;
        int val_16;
        var val_17;
        double val_14 = distance;
        val_11 = path.Count;
        if(val_11 == 0)
        {
            goto label_2;
        }
        
        InternalClipper.OutPt[] val_2 = new InternalClipper.OutPt[0];
        if(val_11 < 1)
        {
            goto label_3;
        }
        
        var val_11 = 0;
        label_10:
        InternalClipper.OutPt val_3 = null;
        val_12 = val_3;
        val_3 = new InternalClipper.OutPt();
        if(val_2 == null)
        {
            goto label_4;
        }
        
        if(val_12 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_12 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        mem2[0] = val_12;
        val_11 = val_11 + 1;
        if(val_11 != val_11)
        {
            goto label_10;
        }
        
        if(val_11 >= 1)
        {
                var val_12 = 0;
            do
        {
            IntPoint val_4 = path.Item[0];
            typeof(InternalClipper.OutPt[]).__il2cppRuntimeField_18 = val_4.X;
            typeof(InternalClipper.OutPt[]).__il2cppRuntimeField_20 = val_4.Y;
            val_13 = val_2.Length;
            if(val_12 >= val_13)
        {
                val_13 = val_2.Length;
        }
        
            val_12 = val_12 + 1;
            typeof(InternalClipper.OutPt[]).__il2cppRuntimeField_28 = val_2[(long)(val_12 == val_11) ? 0 : (val_12)];
            val_12 = val_12 - 1;
            mem2[0] = null;
            val_12 = val_12 + 1;
            typeof(InternalClipper.OutPt[]).__il2cppRuntimeField_10 = 0;
        }
        while(val_12 != val_11);
        
        }
        
        val_14 = val_14 * val_14;
        goto label_27;
        label_2:
        System.Collections.Generic.List<IntPoint> val_6 = null;
        val_14 = val_6;
        val_6 = new System.Collections.Generic.List<IntPoint>();
        return (System.Collections.Generic.List<IntPoint>)val_14;
        label_3:
        val_14 = val_14 * val_14;
        label_27:
        val_15 = val_2[0];
        goto label_39;
        label_42:
        if(val_2[0].Next == val_2[0].Prev)
        {
            goto label_30;
        }
        
        double val_15 = (double)distance;
        double val_16 = (double)val_2[0].Prev.Pt;
        val_15 = (double)X23 - val_15;
        val_16 = (double)val_2[0].Pt - val_16;
        val_16 = val_16 * val_16;
        val_15 = val_15 * val_15;
        val_15 = val_16 + val_15;
        if(val_15 <= val_14)
        {
            goto label_38;
        }
        
        double val_17 = (double)val_15;
        double val_18 = (double)val_2[0].Next.Pt;
        val_17 = (double)val_2[0].Prev - val_17;
        val_18 = (double)val_2[0].Prev.Pt - val_18;
        val_18 = val_18 * val_18;
        val_17 = val_17 * val_17;
        val_17 = val_18 + val_17;
        if(val_17 <= val_14)
        {
            goto label_35;
        }
        
        if((InternalClipper.Clipper.SlopesNearCollinear(pt1:  new IntPoint() {X = val_2[0].Prev.Pt, Y = val_2[0].Prev}, pt2:  new IntPoint() {X = val_2[0].Pt, Y = val_2[0].Prev}, pt3:  new IntPoint() {X = val_2[0].Next.Pt}, distSqrd:  val_14)) == true)
        {
            goto label_38;
        }
        
        val_2[0].Idx = 1;
        val_15 = val_2[0].Next;
        goto label_39;
        label_38:
        val_16 = 0;
        goto label_40;
        label_35:
        InternalClipper.OutPt val_8 = InternalClipper.Clipper.ExcludeOp(op:  val_2[0].Next);
        val_16 = -2;
        label_40:
        val_15 = InternalClipper.Clipper.ExcludeOp(op:  val_15);
        val_11 = val_11 + val_16;
        label_39:
        if(val_9.Idx == 0)
        {
            goto label_42;
        }
        
        label_30:
        val_16 = (val_11 > 2) ? (val_11) : 0;
        System.Collections.Generic.List<IntPoint> val_10 = null;
        val_14 = val_10;
        val_10 = new System.Collections.Generic.List<IntPoint>(capacity:  val_16);
        if(val_16 < 1)
        {
                return (System.Collections.Generic.List<IntPoint>)val_14;
        }
        
        do
        {
            val_10.Add(item:  new IntPoint() {X = val_9.Pt, Y = val_2[0].Prev});
            val_17 = val_16 - 1;
        }
        while(val_17 != 0);
        
        return (System.Collections.Generic.List<IntPoint>)val_14;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> CleanPolygons(System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> polys, double distance = 1.415)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_2 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>(capacity:  polys.Count);
        int val_3 = polys.Count;
        if(val_3 < 1)
        {
                return val_2;
        }
        
        var val_6 = 0;
        do
        {
            val_2.Add(item:  InternalClipper.Clipper.CleanPolygon(path:  polys.Item[0], distance:  distance));
            val_6 = val_6 + 1;
        }
        while(val_3 != val_6);
        
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> Minkowski(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> pattern, System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> path, bool IsSum, bool IsClosed)
    {
        var val_6;
        var val_46;
        var val_47;
        int val_48;
        long val_49;
        long val_50;
        val_46 = IsSum;
        val_47 = path;
        int val_1 = pattern.Count;
        val_48 = val_47.Count;
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_3 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>(capacity:  val_48);
        if(val_46 == false)
        {
            goto label_3;
        }
        
        if(val_48 < 1)
        {
            goto label_23;
        }
        
        val_49 = 0;
        label_21:
        System.Collections.Generic.List<IntPoint> val_4 = new System.Collections.Generic.List<IntPoint>(capacity:  val_1);
        List.Enumerator<T> val_5 = pattern.GetEnumerator();
        label_10:
        if(((-1867461200) & 1) == 0)
        {
            goto label_11;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_8 = val_6.trackableId;
        IntPoint val_9 = val_47.Item[0];
        IntPoint val_10 = val_47.Item[0];
        val_6 = 0;
        InternalClipper.IntPoint val_13 = new InternalClipper.IntPoint(X:  val_9.X + val_8.m_SubId1, Y:  val_10.Y + val_8.m_SubId2);
        val_4.Add(item:  new IntPoint() {X = val_13.X, Y = val_13.Y});
        goto label_10;
        label_11:
        long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519919254960});
        if(((146 == 0) ? 146 : 146) != 146)
        {
            goto label_16;
        }
        
        if(val_3 != null)
        {
            goto label_20;
        }
        
        goto label_18;
        label_16:
        if( != 0)
        {
                val_49 = 0;
        }
        
        if(val_3 != null)
        {
            goto label_20;
        }
        
        label_18:
        label_20:
        val_3.Add(item:  val_4);
        val_48 = val_48;
        val_46 = 0 + 1;
        if(val_46 < val_48)
        {
            goto label_21;
        }
        
        goto label_23;
        label_3:
        if(val_48 < 1)
        {
            goto label_23;
        }
        
        val_49 = 0;
        label_40:
        System.Collections.Generic.List<IntPoint> val_16 = new System.Collections.Generic.List<IntPoint>(capacity:  val_1);
        List.Enumerator<T> val_17 = pattern.GetEnumerator();
        label_29:
        if(((-1867461200) & 1) == 0)
        {
            goto label_30;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_18 = val_13.X.trackableId;
        IntPoint val_19 = val_47.Item[0];
        IntPoint val_20 = val_47.Item[0];
        val_6 = 0;
        InternalClipper.IntPoint val_23 = new InternalClipper.IntPoint(X:  val_19.X - val_18.m_SubId1, Y:  val_20.Y - val_18.m_SubId2);
        val_16.Add(item:  new IntPoint() {X = val_23.X, Y = val_23.Y});
        goto label_29;
        label_30:
        long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519919254960});
        if(((281 == 0) ? 281 : 281) != 281)
        {
            goto label_35;
        }
        
        if(val_3 != null)
        {
            goto label_39;
        }
        
        goto label_37;
        label_35:
        if( != 0)
        {
                val_49 = 0;
        }
        
        if(val_3 != null)
        {
            goto label_39;
        }
        
        label_37:
        label_39:
        val_3.Add(item:  val_16);
        val_48 = val_48;
        val_46 = 0 + 1;
        if(val_46 < val_48)
        {
            goto label_40;
        }
        
        label_23:
        val_50 = IsClosed;
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_28 = null;
        int val_45 = val_1;
        val_45 = val_45 + 1;
        val_28 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>(capacity:  (val_48 + val_50) * val_45);
        int val_46 = ~IsClosed;
        val_46 = val_46 & 1;
        val_46 = val_48 - val_46;
        if(val_46 < 1)
        {
                return val_28;
        }
        
        do
        {
            val_49 = 0 + 1;
            if(val_1 >= 1)
        {
                do
        {
            int val_29 = 1 - 1;
            System.Collections.Generic.List<IntPoint> val_30 = new System.Collections.Generic.List<IntPoint>(capacity:  4);
            int val_32 = 0 - ((0 / val_48) * val_48);
            IntPoint val_34 = val_3.Item[val_32].Item[val_29];
            val_30.Add(item:  new IntPoint() {X = val_34.X, Y = val_34.Y});
            int val_36 = val_49 - ((val_49 / val_48) * val_48);
            IntPoint val_38 = val_3.Item[val_36].Item[val_29];
            val_30.Add(item:  new IntPoint() {X = val_38.X, Y = val_38.Y});
            int val_40 = ((-val_1) == 1) ? 0 : 1;
            IntPoint val_41 = val_3.Item[val_36].Item[val_40];
            val_30.Add(item:  new IntPoint() {X = val_41.X, Y = val_41.Y});
            IntPoint val_43 = val_3.Item[val_32].Item[val_40];
            val_50 = val_43.X;
            val_30.Add(item:  new IntPoint() {X = val_50, Y = val_43.Y});
            if((InternalClipper.Clipper.Area(poly:  val_30)) < 0f)
        {
                val_30.Reverse();
        }
        
            val_28.Add(item:  val_30);
            int val_47 = -val_1;
            val_47 = 1 + 1;
            val_47 = val_47 + val_47;
        }
        while(val_47 != 1);
        
        }
        
        }
        while(val_49 != val_46);
        
        return val_28;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> MinkowskiSum(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> pattern, System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> path, bool pathIsClosed)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_2 = InternalClipper.Clipper.Minkowski(pattern:  pattern, path:  path, IsSum:  true, IsClosed:  pathIsClosed);
        InternalClipper.Clipper val_3 = new InternalClipper.Clipper(InitOptions:  0);
        if(val_3 != null)
        {
                bool val_4 = val_3.AddPaths(ppg:  val_2, polyType:  0, closed:  true);
        }
        else
        {
                bool val_5 = 0.AddPaths(ppg:  val_2, polyType:  0, closed:  true);
        }
        
        bool val_6 = val_3.Execute(clipType:  1, solution:  val_2, subjFillType:  1, clipFillType:  1);
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> TranslatePath(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> path, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint delta)
    {
        var val_9;
        int val_1 = path.Count;
        System.Collections.Generic.List<IntPoint> val_2 = new System.Collections.Generic.List<IntPoint>(capacity:  val_1);
        if(val_1 < 1)
        {
                return val_2;
        }
        
        var val_9 = 0;
        do
        {
            if(path != null)
        {
                IntPoint val_3 = path.Item[0];
            val_9 = val_3.X;
        }
        else
        {
                IntPoint val_4 = 0.Item[0];
            val_9 = val_4.X;
        }
        
            IntPoint val_5 = path.Item[0];
            InternalClipper.IntPoint val_8 = new InternalClipper.IntPoint(X:  val_9 + delta.X, Y:  val_5.Y + delta.Y);
            val_2.Add(item:  new IntPoint() {X = val_8.X, Y = val_8.Y});
            val_9 = val_9 + 1;
        }
        while(val_1 != val_9);
        
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> MinkowskiSum(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> pattern, System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> paths, bool pathIsClosed)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        InternalClipper.Clipper val_2 = new InternalClipper.Clipper(InitOptions:  0);
        int val_3 = paths.Count;
        if(val_3 >= 1)
        {
                var val_13 = 0;
            do
        {
            bool val_7 = val_2.AddPaths(ppg:  InternalClipper.Clipper.Minkowski(pattern:  pattern, path:  paths.Item[0], IsSum:  true, IsClosed:  pathIsClosed), polyType:  0, closed:  true);
            if(pathIsClosed != false)
        {
                IntPoint val_9 = pattern.Item[0];
            bool val_11 = val_2.AddPath(pg:  InternalClipper.Clipper.TranslatePath(path:  paths.Item[0], delta:  new IntPoint() {X = val_9.X, Y = val_9.Y}), polyType:  1, Closed:  true);
        }
        
            val_13 = val_13 + 1;
        }
        while(val_3 != val_13);
        
        }
        
        bool val_12 = val_2.Execute(clipType:  1, solution:  val_1, subjFillType:  1, clipFillType:  1);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> MinkowskiDiff(System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> poly1, System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint> poly2)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = InternalClipper.Clipper.Minkowski(pattern:  poly1, path:  poly2, IsSum:  false, IsClosed:  true);
        InternalClipper.Clipper val_2 = new InternalClipper.Clipper(InitOptions:  0);
        if(val_2 != null)
        {
                bool val_3 = val_2.AddPaths(ppg:  val_1, polyType:  0, closed:  true);
        }
        else
        {
                bool val_4 = 0.AddPaths(ppg:  val_1, polyType:  0, closed:  true);
        }
        
        bool val_5 = val_2.Execute(clipType:  1, solution:  val_1, subjFillType:  1, clipFillType:  1);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> PolyTreeToPaths(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree polytree)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        val_1.Capacity = polytree.Total;
        InternalClipper.Clipper.AddPolyNodeToPaths(polynode:  polytree, nt:  0, paths:  val_1);
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static void AddPolyNodeToPaths(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyNode polynode, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Clipper.NodeType nt, System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> paths)
    {
        var val_10;
        var val_11;
        var val_12;
        val_10 = paths;
        val_11 = polynode;
        if(nt == 1)
        {
                return;
        }
        
        if(nt != 2)
        {
            goto label_2;
        }
        
        val_12 = (~val_11.IsOpen) & 1;
        if(val_11 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        val_12 = 1;
        if(val_11 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        var val_3 = (polynode.m_polygon.Count > 0) ? 1 : 0;
        val_3 = val_12 & val_3;
        if(val_3 != 0)
        {
                val_10.Add(item:  polynode.m_polygon);
        }
        
        List.Enumerator<T> val_5 = val_11.Childs.GetEnumerator();
        val_11 = 1152921519920149584;
        label_13:
        if(((-1866543400) & 1) == 0)
        {
            goto label_11;
        }
        
        GameUI.EmailUIDataHandler val_6 = 0.emailUIDataHandler;
        goto label_13;
        label_11:
        long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519920172760});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> OpenPathsFromPolyTree(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree polytree)
    {
        var val_9;
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        val_1.Capacity = polytree.ChildCount;
        val_9 = 0;
        goto label_3;
        label_13:
        if(polytree.Childs.Item[0].IsOpen != false)
        {
                PolyNode val_7 = polytree.Childs.Item[0];
            val_1.Add(item:  val_7.m_polygon);
        }
        
        val_9 = 1;
        label_3:
        if(val_9 < polytree.ChildCount)
        {
            goto label_13;
        }
        
        return val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.List<System.Collections.Generic.List<Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.IntPoint>> ClosedPathsFromPolyTree(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.PolyTree polytree)
    {
        System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>();
        val_1.Capacity = polytree.Total;
        InternalClipper.Clipper.AddPolyNodeToPaths(polynode:  polytree, nt:  2, paths:  val_1);
        return val_1;
    }

}
