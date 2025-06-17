using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
internal struct InternalClipper.Int128
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private long hi;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ulong lo;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.Int128(long _lo)
    {
        mem[1152921519894443280] = _lo >> 63;
        mem[1152921519894443288] = _lo;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.Int128(long _hi, ulong _lo)
    {
        mem[1152921519894555280] = _hi;
        mem[1152921519894555288] = _lo;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public InternalClipper.Int128(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val)
    {
        mem[1152921519894667280] = val.hi;
        mem[1152921519894667288] = val.lo;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsNegative()
    {
        return (bool)X8 >> 63;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool op_Equality(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val2)
    {
        var val_4;
        if(val1.hi != val2.hi)
        {
                val_4 = ((val1.hi == val2.hi) ? 1 : 0) & ((val1.lo == val2.lo) ? 1 : 0);
            return (bool)val_4;
        }
        
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool op_Inequality(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val2)
    {
        bool val_1 = InternalClipper.Int128.op_Equality(val1:  new InternalClipper.Int128() {hi = val1.hi, lo = val1.lo}, val2:  new InternalClipper.Int128() {hi = val2.hi, lo = val2.lo});
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object obj)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        int val_2 = GetHashCode();
        val_2 = val_2 ^ GetHashCode();
        return (int)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool op_GreaterThan(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val2)
    {
        val1.hi = (val1.hi != val2.hi) ? ((val1.hi > val2.hi) ? 1 : 0) : ((val1.lo > val2.lo) ? 1 : 0);
        return (bool)val1.hi;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool op_LessThan(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val1, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val2)
    {
        val1.hi = (val1.hi != val2.hi) ? ((val1.hi < val2.hi) ? 1 : 0) : ((val1.lo < val2.lo) ? 1 : 0);
        return (bool)val1.hi;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 op_Addition(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 lhs, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 rhs)
    {
        long val_1 = rhs.hi + lhs.hi;
        lhs.lo = rhs.lo + lhs.lo;
        lhs.hi = () ? (val_1 + 1) : (val_1);
        return new InternalClipper.Int128() {hi = lhs.hi, lo = lhs.lo};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 op_Subtraction(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 lhs, Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 rhs)
    {
        lhs.lo = lhs.lo - rhs.lo;
        var val_1 = (rhs.lo == 0) ? (-rhs.hi) : (!rhs.hi);
        val_1 = val_1 + lhs.hi;
        lhs.hi = (lhs.lo < (-rhs.lo)) ? (val_1 + 1) : (val_1);
        return new InternalClipper.Int128() {hi = lhs.hi, lo = lhs.lo};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 op_UnaryNegation(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val)
    {
        val.hi = (val.lo == 0) ? (-val.hi) : (!val.hi);
        return new InternalClipper.Int128() {hi = val.hi, lo = -val.lo};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static double op_Explicit(Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 val)
    {
        if((val.hi & 9223372036854775808) == 0)
        {
                double val_1 = 1.84467440737096E+19;
            val_1 = (double)val.hi * val_1;
            val_1 = val_1 + (double)val.lo;
            return (double)val_1;
        }
        
        if(val.lo != 0)
        {
                double val_2 = 1.84467440737096E+19;
            val_2 = ((double)~val.hi) * val_2;
            val_2 = val_2 + ((double)~val.lo);
            return (double)-val_2;
        }
        
        double val_3 = 1.84467440737096E+19;
        val_3 = (double)val.hi * val_3;
        return (double)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Mapbox.VectorTile.Geometry.InteralClipperLib.InternalClipper.Int128 Int128Mul(long lhs, long rhs)
    {
        var val_1 = (rhs < 0) ? (-rhs) : rhs;
        var val_2 = (lhs < 0) ? (-lhs) : lhs;
        var val_3 = val_1 >> 32;
        val_1 = val_1 & 4294967295;
        var val_4 = val_2 & 4294967295;
        val_2 = val_2 >> 32;
        val_1 = val_1 * val_2;
        val_1 = val_1 + (val_3 * val_4);
        val_2 = (val_3 * val_2) + (val_1 >> 32);
        rhs = (val_1 * val_4) + ((((rhs < 0 ?  (-rhs) : rhs >> 32) * (lhs < 0 ?  (-lhs) : lhs & 4294967295)) + ((rhs < 0 ?  (-rhs) : rhs & 4294967295) * (lhs < 0 ?  (-lhs) : lhs >> 32))) << 32);
        lhs = (lhs >= 0) ? (val_2 + 1) : (val_2);
        if((rhs ^ lhs & 9223372036854775808) == 0)
        {
                return new InternalClipper.Int128() {hi = lhs, lo = rhs};
        }
        
        lhs = (rhs == 0) ? (-lhs) : (!lhs);
        return new InternalClipper.Int128() {hi = lhs, lo = -rhs};
    }

}
