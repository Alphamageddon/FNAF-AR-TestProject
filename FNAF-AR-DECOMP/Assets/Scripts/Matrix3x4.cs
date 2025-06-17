using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
protected struct MotionState.Matrix3x4
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m00;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m01;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m02;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m03;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m12;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m13;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m20;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m21;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m22;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float m23;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector4 GetRow(int i)
    {
        var val_1 = (this.m10 != 0f) ? 1 : 0;
        return new UnityEngine.Vector4();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotion.MotionState.Matrix3x4 op_Implicit(UnityEngine.Matrix4x4 from)
    {
        Matrix3x4 val_0;
        val_0.m00 = from.m00;
        val_0.m01 = from.m01;
        val_0.m02 = from.m02;
        val_0.m03 = from.m03;
        val_0.m10 = from.m10;
        val_0.m11 = from.m11;
        val_0.m12 = from.m12;
        val_0.m13 = from.m13;
        val_0.m20 = from.m20;
        val_0.m21 = from.m21;
        val_0.m22 = from.m22;
        val_0.m23 = from.m23;
        return val_0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Matrix4x4 op_Implicit(AmplifyMotion.MotionState.Matrix3x4 from)
    {
        UnityEngine.Matrix4x4 val_0;
        val_0.m00 = from.m00;
        val_0.m10 = from.m10;
        val_0.m20 = from.m20;
        val_0.m30 = 0f;
        val_0.m01 = from.m01;
        val_0.m11 = from.m11;
        val_0.m21 = from.m21;
        val_0.m31 = 0f;
        val_0.m02 = from.m02;
        val_0.m12 = from.m12;
        val_0.m22 = from.m22;
        val_0.m32 = 0f;
        val_0.m03 = from.m03;
        val_0.m13 = from.m13;
        val_0.m23 = from.m23;
        val_0.m33 = 1f;
        return val_0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static AmplifyMotion.MotionState.Matrix3x4 op_Multiply(AmplifyMotion.MotionState.Matrix3x4 a, AmplifyMotion.MotionState.Matrix3x4 b)
    {
        Matrix3x4 val_0;
        float val_37 = a.m02;
        float val_38 = b.m20;
        float val_39 = b.m21;
        float val_35 = b.m12;
        float val_36 = b.m13;
        float val_40 = b.m22;
        float val_34 = a.m11;
        float val_18 = a.m21 * b.m11;
        float val_19 = a.m12 * val_38;
        float val_20 = a.m12 * val_39;
        float val_21 = a.m12 * val_40;
        float val_22 = a.m12 * b.m23;
        float val_25 = val_34 * val_35;
        val_34 = val_34 * val_36;
        float val_26 = a.m21 * b.m10;
        val_35 = a.m21 * val_35;
        val_36 = a.m21 * val_36;
        val_37 = val_37 * b.m23;
        val_38 = a.m22 * val_38;
        val_39 = a.m22 * val_39;
        val_40 = a.m22 * val_40;
        float val_29 = a.m22 * b.m23;
        float val_30 = (a.m00 * b.m00) + (a.m01 * b.m10);
        float val_41 = a.m00 * b.m01;
        val_26 = (a.m20 * b.m00) + val_26;
        val_18 = (a.m20 * b.m01) + val_18;
        val_35 = (a.m20 * b.m02) + val_35;
        val_41 = val_41 + (a.m01 * b.m11);
        float val_42 = a.m00 * b.m02;
        val_36 = (a.m20 * b.m03) + val_36;
        val_25 = (a.m10 * b.m02) + val_25;
        val_42 = val_42 + (a.m01 * val_35);
        float val_43 = a.m00 * b.m03;
        val_42 = val_42 + (val_37 * val_40);
        val_43 = val_43 + (a.m01 * val_36);
        float val_44 = val_34 * b.m10;
        val_34 = (a.m10 * b.m03) + val_34;
        val_44 = (a.m10 * b.m00) + val_44;
        float val_45 = a.m10 * b.m01;
        val_19 = val_44 + val_19;
        val_45 = val_45 + (val_34 * b.m11);
        val_20 = val_45 + val_20;
        val_43 = val_43 + val_37;
        val_22 = val_34 + val_22;
        val_29 = val_36 + val_29;
        val_30 = val_30 + (val_37 * val_38);
        val_41 = val_41 + (val_37 * val_39);
        val_21 = val_25 + val_21;
        val_43 = a.m03 + val_43;
        val_22 = a.m13 + val_22;
        val_29 = a.m23 + val_29;
        val_0.m00 = val_30;
        val_0.m01 = val_41;
        val_0.m10 = val_19;
        val_0.m11 = val_20;
        val_0.m20 = val_26 + val_38;
        val_0.m21 = val_18 + val_39;
        val_0.m02 = val_42;
        val_0.m03 = val_43;
        val_0.m12 = val_21;
        val_0.m13 = val_22;
        val_0.m22 = val_35 + val_40;
        val_0.m23 = val_29;
        return val_0;
    }

}
