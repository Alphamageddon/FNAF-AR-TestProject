using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class Math3d
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.Transform tempChild;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.Transform tempParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.Vector3[] positionRegister;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] posTimeRegister;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int positionSamplesTaken;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.Quaternion[] rotationRegister;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float[] rotTimeRegister;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int rotationSamplesTaken;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Init()
    {
        var val_9 = null;
        Math3d.tempChild = new UnityEngine.GameObject(name:  "Math3d_TempChild").transform;
        Math3d.tempParent = new UnityEngine.GameObject(name:  "Math3d_TempParent").transform;
        Math3d.tempChild.gameObject.hideFlags = 61;
        UnityEngine.Object.DontDestroyOnLoad(target:  Math3d.tempChild.gameObject);
        Math3d.tempParent.gameObject.hideFlags = 61;
        UnityEngine.Object.DontDestroyOnLoad(target:  Math3d.tempParent.gameObject);
        Math3d.tempChild.parent = Math3d.tempParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector2 GetPointOnSpline(float percentage, UnityEngine.Vector2[] cPoints)
    {
        float val_34;
        float val_35;
        int val_36;
        val_34 = percentage;
        if()
        {
                val_35 = 0f;
        }
        else
        {
                float val_3 = ((float)cPoints.Length - 3) * val_34;
            int val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_3), b:  cPoints.Length - 4);
            val_36 = cPoints.Length;
            if(val_5 >= val_36)
        {
                val_36 = cPoints.Length;
        }
        
            UnityEngine.Vector2 val_34 = cPoints[(long)val_5];
            UnityEngine.Vector2 val_35 = cPoints[(long)val_5];
            var val_6 = (long)val_5 + 1;
            if(val_6 >= val_36)
        {
                val_36 = cPoints.Length;
        }
        
            UnityEngine.Vector2 val_36 = cPoints[(long)val_6];
            UnityEngine.Vector2 val_37 = cPoints[(long)val_6];
            var val_7 = (long)val_5 + 2;
            if(val_7 >= val_36)
        {
                val_36 = cPoints.Length;
        }
        
            UnityEngine.Vector2 val_38 = cPoints[(long)val_7];
            UnityEngine.Vector2 val_39 = cPoints[(long)val_7];
            UnityEngine.Vector2 val_40 = cPoints[(long)(long)val_5 + 3];
            float val_9 = val_3 - (float)val_5;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(d:  2f, a:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_34, y = val_35});
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_38, y = val_39});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, d:  val_9);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(d:  2f, a:  new UnityEngine.Vector2() {x = val_34, y = val_35});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Multiply(d:  5f, a:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(d:  4f, a:  new UnityEngine.Vector2() {x = val_38, y = val_39});
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            val_34 = cPoints[(long)(long)val_5 + 3];
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, b:  new UnityEngine.Vector2() {x = val_40, y = val_34});
            float val_21 = val_9 * val_9;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, d:  val_21);
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_34, y = val_35});
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Multiply(d:  3f, a:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Multiply(d:  3f, a:  new UnityEngine.Vector2() {x = val_38, y = val_39});
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, b:  new UnityEngine.Vector2() {x = val_40, y = val_34});
            float val_42 = val_9;
            val_42 = val_42 * val_21;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, d:  val_42);
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
            val_35 = val_31.x;
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector2() {x = val_35, y = val_31.y});
        }
        
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_32.x, y:  val_32.y);
        return new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float[] GetLineSplineIntersections(UnityEngine.Vector2[] linePoints, UnityEngine.Vector2[] cPoints)
    {
        int val_51;
        var val_53;
        var val_54;
        float val_55;
        int val_56;
        UnityEngine.Vector2 val_57;
        float val_58;
        UnityEngine.Vector2 val_59;
        float val_60;
        float val_61;
        float val_62;
        System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
        int val_2 = cPoints.Length - 3;
        if(val_2 < 1)
        {
                return (System.Single[])val_1.ToArray();
        }
        
        var val_45 = 0;
        val_51 = cPoints.Length & 4294967295;
        val_53 = 8589934592;
        val_54 = 12884901888;
        val_55 = 3f;
        goto label_3;
        label_30:
        val_51 = cPoints.Length;
        val_53 = 12884901888;
        val_54 = 17179869184;
        val_55 = 3f;
        label_3:
        if(val_45 >= val_51)
        {
                val_51 = cPoints.Length;
        }
        
        val_45 = val_45 + 1;
        if(val_45 >= val_51)
        {
                val_51 = cPoints.Length;
        }
        
        val_45 = val_45 + 1;
        if(val_45 >= val_51)
        {
                val_51 = cPoints.Length;
        }
        
        UnityEngine.Vector2 val_46 = cPoints[0];
        val_45 = val_45 + 1;
        UnityEngine.Vector2 val_47 = cPoints[0];
        UnityEngine.Vector2 val_48 = cPoints[0];
        UnityEngine.Vector2 val_49 = cPoints[0];
        val_56 = linePoints.Length;
        if(val_56 == 0)
        {
                val_56 = linePoints.Length;
        }
        
        if(val_56 <= 1)
        {
                val_56 = linePoints.Length;
        }
        
        if(val_56 <= 1)
        {
                val_56 = linePoints.Length;
        }
        
        if(val_56 == 0)
        {
                val_56 = linePoints.Length;
        }
        
        val_57 = linePoints[0];
        if(val_56 == 0)
        {
                val_57 = linePoints[0];
            val_56 = linePoints.Length;
        }
        
        float val_3 = null * val_55;
        float val_4 = null * val_55;
        float val_7 = (-1.162476E-27f) + (-1.162476E-27f);
        if(val_56 <= 1)
        {
                val_56 = linePoints.Length;
        }
        
        val_3 = val_3 - null;
        val_4 = val_4 - (-1.162476E-27f);
        val_55 = val_47 * val_55;
        val_58 = (null + null) - (null * 5f);
        float val_10 = val_46 * 4f;
        val_7 = val_7 - (null * 5f);
        if(val_56 == 0)
        {
                val_56 = linePoints.Length;
            val_58 = val_58;
        }
        
        val_55 = val_4 - val_55;
        val_10 = val_58 + val_10;
        if(val_56 <= 1)
        {
                val_56 = linePoints.Length;
        }
        
        val_59 = linePoints[1];
        float val_15 = val_55 + val_49;
        if(val_56 == 0)
        {
                val_59 = val_59;
            val_56 = linePoints.Length;
        }
        
        val_60 = ((val_3 - (val_46 * val_55)) + val_48) * 0.5f;
        val_15 = val_15 * 0.5f;
        val_61 = (val_10 - val_48) * 0.5f;
        float val_22 = ((val_7 + (val_47 * 4f)) - val_49) * 0.5f;
        float val_25 = ((-1.162476E-27f) + (-1.162476E-27f)) * 0.5f;
        float val_27 = linePoints[1] - val_57;
        if(val_56 == 0)
        {
                val_61 = val_61;
            val_60 = val_60;
            val_59 = val_59;
        }
        
        UnityEngine.Vector2 val_57 = val_57;
        UnityEngine.Vector2 val_56 = linePoints[0];
        val_57 = val_57 - linePoints[1];
        UnityEngine.Vector2 val_58 = linePoints[0];
        val_57 = val_57 * linePoints[0];
        val_56 = (val_59 - linePoints[0]) * val_56;
        val_58 = val_58 - linePoints[1];
        val_56 = val_57 + val_56;
        float val_30 = val_25 * val_58;
        val_30 = val_30 + ((((-1.162476E-27f) + (-1.162476E-27f)) * 0.5f) * val_27);
        val_22 = (val_61 * val_58) + (val_22 * val_27);
        val_62 = (((val_46 - (-1.162476E-27f)) * 0.5f) * val_58) + (((val_47 - (-1.162476E-27f)) * 0.5f) * val_27);
        val_25 = val_30 + val_56;
        Math3d.SolveCubic(nRoots: out  0, x1: out  float val_39 = 8.532524E+15f, x2: out  float val_40 = 8.532522E+15f, x3: out  float val_41 = 8.532519E+15f, a:  (val_60 * val_58) + (val_15 * val_27), b:  val_22, c:  val_62, d:  val_25);
        val_45 = val_45 - 3;
        float val_60 = 0f;
        float val_59 = (float)val_45;
        float val_42 = val_59 / (float)val_2;
        val_59 = val_59 + 1f;
        val_59 = val_59 / (float)val_2;
        float val_43 = val_59 - val_42;
        if((val_60 >= 0f) && (val_60 <= 1f))
        {
                val_60 = val_43 * val_60;
            val_62 = val_42 + val_60;
            val_1.Add(item:  val_62);
        }
        
        float val_61 = 0f;
        if((val_61 >= 0f) && (val_61 <= 1f))
        {
                val_61 = val_43 * val_61;
            val_62 = val_42 + val_61;
            val_1.Add(item:  val_62);
        }
        
        float val_62 = 0f;
        if((val_62 >= 0f) && (val_62 <= 1f))
        {
                val_62 = val_43 * val_62;
            val_62 = val_42 + val_62;
            val_1.Add(item:  val_62);
        }
        
        val_45 = val_45 + 1;
        if(val_45 != val_2)
        {
            goto label_30;
        }
        
        return (System.Single[])val_1.ToArray();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void SolveCubic(out int nRoots, out float x1, out float x2, out float x3, float a, float b, float c, float d)
    {
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_17 = c;
        float val_19 = b;
        a = val_19 / a;
        float val_1 = val_17 / a;
        float val_2 = d / a;
        float val_18 = 9f;
        val_2 = val_2 * (-27f);
        float val_4 = a * a;
        float val_16 = -2f;
        val_4 = (val_1 * 3f) - val_4;
        val_16 = a * val_16;
        val_1 = (a * val_18) * val_1;
        val_16 = a * val_16;
        val_1 = val_1 + val_2;
        val_17 = val_4 / val_18;
        val_1 = val_1 + (a * val_16);
        val_18 = val_17 * val_17;
        val_16 = val_1 / 54f;
        float val_7 = val_17 * val_18;
        val_1 = val_16 * val_16;
        val_17 = val_7 + val_1;
        val_19 = a / 3f;
        if(val_17 < 0)
        {
                nRoots = 3;
            if(a >= _TYPE_MAX_)
        {
                val_18 = -val_7;
        }
        
            val_18 = val_16 / val_18;
            val_16 = val_18;
            if(val_17 >= _TYPE_MAX_)
        {
                val_19 = -val_17;
        }
        
            float val_8 = val_16 / 3f;
            val_19 = val_19 + val_19;
            val_8 = val_19 * val_8;
            val_8 = val_8 - val_19;
            x1 = val_8;
            float val_9 = val_16 + 6.283185f;
            val_9 = val_9 / 3f;
            val_9 = val_19 * val_9;
            val_9 = val_9 - val_19;
            x2 = val_9;
            float val_10 = val_16 + 12.56637f;
            val_10 = val_10 / 3f;
            val_10 = val_19 * val_10;
            val_20 = val_10 - val_19;
        }
        else
        {
                if(val_17 > 0f)
        {
                nRoots = 1;
            if(val_17 >= _TYPE_MAX_)
        {
                float val_20 = val_17;
            val_21 = val_20;
        }
        
            val_20 = val_16 + val_21;
            val_17 = Math3d.CubeRoot(d:  val_20);
            float val_13 = Math3d.CubeRoot(d:  val_16 - val_21);
            val_13 = val_17 + val_13;
            val_1 = val_13 - val_19;
            val_20 = 0f;
            x1 = val_1;
            x2 = 0f;
        }
        else
        {
                nRoots = 3;
            float val_14 = Math3d.CubeRoot(d:  val_16);
            float val_15 = val_14 + val_14;
            val_20 = val_14 - val_19;
            val_15 = val_15 - val_19;
            x1 = val_15;
            x2 = val_20;
        }
        
        }
        
        x3 = val_20;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static float CubeRoot(float d)
    {
        if(d < 0)
        {
                return (float)-(-d);
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 AddVectorLength(UnityEngine.Vector3 vector, float size)
    {
        float val_2 = vector.y;
        float val_1 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = vector.x, y = val_2, z = vector.z});
        val_2 = val_1 + size;
        size = val_2 / val_1;
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, d:  size);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 SetVectorLength(UnityEngine.Vector3 vector, float size)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  size);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Quaternion SubtractRotation(UnityEngine.Quaternion B, UnityEngine.Quaternion A)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = A.x, y = A.y, z = A.z, w = A.w});
        return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, rhs:  new UnityEngine.Quaternion() {x = B.x, y = B.y, z = B.z, w = B.w});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Quaternion AddRotation(UnityEngine.Quaternion A, UnityEngine.Quaternion B)
    {
        return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = A.x, y = A.y, z = A.z, w = A.w}, rhs:  new UnityEngine.Quaternion() {x = B.x, y = B.y, z = B.z, w = B.w});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 TransformDirectionMath(UnityEngine.Quaternion rotation, UnityEngine.Vector3 vector)
    {
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, point:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 InverseTransformDirectionMath(UnityEngine.Quaternion rotation, UnityEngine.Vector3 vector)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w});
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 RotateVectorFromTo(UnityEngine.Quaternion from, UnityEngine.Quaternion to, UnityEngine.Vector3 vector)
    {
        float val_1;
        UnityEngine.Quaternion val_2 = Math3d.SubtractRotation(B:  new UnityEngine.Quaternion() {x = to.x, y = to.y, z = to.z, w = to.w}, A:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w});
        UnityEngine.Vector3 val_3 = Math3d.InverseTransformDirectionMath(rotation:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w}, vector:  new UnityEngine.Vector3() {x = vector.x, y = val_1, z = vector.y});
        UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return Math3d.TransformDirectionMath(rotation:  new UnityEngine.Quaternion() {x = from.x, y = from.y, z = from.z, w = from.w}, vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool PlanePlaneIntersection(out UnityEngine.Vector3 linePoint, out UnityEngine.Vector3 lineVec, UnityEngine.Vector3 plane1Normal, UnityEngine.Vector3 plane1Position, UnityEngine.Vector3 plane2Normal, UnityEngine.Vector3 plane2Position)
    {
        float val_1;
        float val_7;
        float val_12;
        var val_13;
        val_12 = plane2Normal.x;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        linePoint.x = val_2.x;
        linePoint.y = val_2.y;
        linePoint.z = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        lineVec.x = val_3.x;
        lineVec.y = val_3.y;
        lineVec.z = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = plane1Normal.x, y = plane1Normal.y, z = plane1Normal.z}, rhs:  new UnityEngine.Vector3() {x = val_12, y = val_1, z = plane2Normal.y});
        lineVec.x = val_4.x;
        lineVec.y = val_4.y;
        lineVec.z = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_12, y = val_1, z = plane2Normal.y}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = plane1Normal.x, y = plane1Normal.y, z = plane1Normal.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if(System.Math.Abs(val_6) > 0.006f)
        {
                val_12 = val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = plane1Position.x, y = plane1Position.y, z = plane1Position.z}, b:  new UnityEngine.Vector3() {x = plane2Normal.z, y = val_12, z = plane2Position.x});
            float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = plane1Normal.x, y = plane1Normal.y, z = plane1Normal.z}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_9 = val_9 / val_6;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = plane2Normal.z, y = val_12, z = plane2Position.x}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_13 = 1;
            linePoint.x = val_11.x;
            linePoint.y = val_11.y;
            linePoint.z = val_11.z;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool LinePlaneIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Vector3 linePoint, UnityEngine.Vector3 lineVec, UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint)
    {
        float val_1;
        float val_2;
        float val_9;
        float val_10;
        var val_11;
        val_9 = planeNormal.x;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        intersection.x = val_3.x;
        intersection.y = val_3.y;
        intersection.z = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = planeNormal.z, y = val_1, z = planePoint.x}, b:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z});
        val_10 = lineVec.z;
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = val_10}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_2, z = planeNormal.y});
        if(val_6 != 0f)
        {
                val_9 = (UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_2, z = planeNormal.y})) / val_6;
            UnityEngine.Vector3 val_7 = Math3d.SetVectorLength(vector:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = val_10}, size:  val_9);
            val_9 = val_7.x;
            val_10 = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z}, b:  new UnityEngine.Vector3() {x = val_9, y = val_7.y, z = val_10});
            val_11 = 1;
            intersection.x = val_8.x;
            intersection.y = val_8.y;
            intersection.z = val_8.z;
            return (bool)val_11;
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool LineLineIntersection(out UnityEngine.Vector3 intersection, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 lineVec1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 lineVec2)
    {
        float val_1;
        float val_2;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        var val_16;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint2.x, y = val_2, z = linePoint2.y}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = lineVec1.z}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_1, z = lineVec2.x});
        val_11 = val_3.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_1, z = lineVec2.x});
        val_12 = val_3.y;
        val_13 = val_11;
        val_14 = 0.0001f;
        val_15 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_12, z = val_13}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}));
        if((val_15 < 0) && (val_15 > val_14))
        {
                val_11 = val_4.z;
            float val_11 = val_4.x;
            float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_11, y = val_4.y, z = val_11});
            val_14 = val_7;
            val_11 = val_14 / val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = lineVec1.z}, d:  val_11);
            val_15 = linePoint1.x;
            val_12 = linePoint1.y;
            val_13 = linePoint1.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_16 = 1;
        }
        else
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_16 = 0;
        }
        
        intersection.x = val_10.x;
        intersection.y = val_10.y;
        intersection.z = val_10.z;
        return (bool)val_16;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool ClosestPointsOnTwoLines(out UnityEngine.Vector3 closestPointLine1, out UnityEngine.Vector3 closestPointLine2, UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 lineVec1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 lineVec2)
    {
        float val_1;
        float val_8;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        var val_22;
        val_18 = lineVec1.z;
        float val_19 = val_1;
        val_19 = lineVec2.x;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        closestPointLine1.x = val_2.x;
        closestPointLine1.y = val_2.y;
        closestPointLine1.z = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        closestPointLine2.x = val_3.x;
        closestPointLine2.y = val_3.y;
        closestPointLine2.z = val_3.z;
        val_20 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18});
        float val_22 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = lineVec1.x, y = lineVec1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = val_19});
        float val_18 = val_19;
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = val_18}, rhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = val_19});
        val_18 = val_20 * val_6;
        val_19 = val_18 - (val_22 * val_22);
        if(val_19 != 0f)
        {
                val_21 = linePoint2.x;
            val_21 = val_21;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, b:  new UnityEngine.Vector3() {x = val_21, y = val_8, z = linePoint2.y});
            val_19 = lineVec1.x;
            val_20 = val_9.y;
            val_18 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_19, y = lineVec1.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_20, z = val_9.z});
            float val_20 = val_19;
            float val_11 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_20, z = val_19}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_20, z = val_9.z});
            float val_21 = val_6;
            val_20 = val_22 * val_11;
            val_21 = val_21 * val_18;
            val_20 = val_20 - val_21;
            val_11 = val_20 * val_11;
            val_11 = val_11 - (val_22 * val_18);
            val_22 = val_11 / val_19;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19, y = lineVec1.y, z = val_18}, d:  val_20 / val_19);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            closestPointLine1.x = val_15.x;
            closestPointLine1.y = val_15.y;
            closestPointLine1.z = val_15.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = linePoint2.z, y = val_19, z = val_19}, d:  val_22);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21, y = val_8, z = linePoint2.y}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_22 = 1;
            closestPointLine2.x = val_17.x;
            closestPointLine2.y = val_17.y;
            closestPointLine2.z = val_17.z;
            return (bool)val_22;
        }
        
        val_22 = 0;
        return (bool)val_22;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 ProjectPointOnLine(UnityEngine.Vector3 linePoint, UnityEngine.Vector3 lineVec, UnityEngine.Vector3 point)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = val_1, z = point.y}, b:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = lineVec.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = lineVec.x, y = lineVec.y, z = lineVec.z}));
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = linePoint.x, y = linePoint.y, z = linePoint.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 ProjectPointOnLineSegment(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 point)
    {
        var val_6;
        float val_10;
        float val_11;
        float val_12;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z});
        val_6 = null;
        UnityEngine.Vector3 val_3 = Math3d.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, lineVec:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, point:  new UnityEngine.Vector3() {x = point.x, y = point.y});
        val_10 = val_3.x;
        val_11 = val_3.y;
        val_12 = val_3.z;
        int val_4 = Math3d.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, linePoint2:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, point:  new UnityEngine.Vector3() {x = val_10, y = val_12});
        if(val_4 == 0)
        {
                return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
        }
        
        if(val_4 == 1)
        {
            goto label_6;
        }
        
        if(val_4 != 2)
        {
            goto label_7;
        }
        
        val_10 = linePoint2.x;
        val_11 = linePoint2.y;
        val_12 = linePoint2.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
        label_6:
        val_10 = linePoint1.x;
        val_11 = linePoint1.y;
        val_12 = linePoint1.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
        label_7:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_10 = val_5.x;
        val_11 = val_5.y;
        val_12 = val_5.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 ProjectPointOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
    {
        float val_1;
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        val_4 = val_1;
        val_5 = point.y;
        val_6 = point.x;
        val_7 = planePoint.z;
        val_5 = val_5;
        val_4 = val_4;
        val_6 = val_6;
        val_7 = val_7;
        val_5 = val_5;
        val_4 = val_4;
        val_6 = val_6;
        UnityEngine.Vector3 val_3 = Math3d.SetVectorLength(vector:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, size:  -(Math3d.SignedDistancePlanePoint(planeNormal:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, planePoint:  new UnityEngine.Vector3() {x = planePoint.x, y = planePoint.y, z = val_7}, point:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = ???})));
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_5}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 ProjectVectorOnPlane(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 vector)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, rhs:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}), a:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z});
        return UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SignedDistancePlanePoint(UnityEngine.Vector3 planeNormal, UnityEngine.Vector3 planePoint, UnityEngine.Vector3 point)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = val_1, z = point.y}, b:  new UnityEngine.Vector3() {x = planePoint.x, y = planePoint.y, z = planePoint.z});
        return UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = planeNormal.x, y = planeNormal.y, z = planeNormal.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SignedDotProduct(UnityEngine.Vector3 vectorA, UnityEngine.Vector3 vectorB, UnityEngine.Vector3 normal)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = normal.x, y = val_1, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = vectorA.x, y = vectorA.y, z = vectorA.z});
        return UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = vectorB.x, y = vectorB.y, z = vectorB.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float SignedVectorAngle(UnityEngine.Vector3 referenceVector, UnityEngine.Vector3 otherVector, UnityEngine.Vector3 normal)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = normal.x, y = val_1, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = referenceVector.x, y = referenceVector.y, z = referenceVector.z});
        float val_5 = UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = otherVector.x, y = otherVector.y, z = otherVector.z}));
        val_5 = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = referenceVector.x, y = referenceVector.y, z = referenceVector.z}, to:  new UnityEngine.Vector3() {x = otherVector.x, y = otherVector.y, z = otherVector.z})) * val_5;
        return (float)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float AngleVectorPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 normal)
    {
        float val_2 = (float)(double)UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vector.x, y = vector.y, z = vector.z}, rhs:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
        val_2 = 1.570796f - val_2;
        return (float)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float DotProductAngle(UnityEngine.Vector3 vec1, UnityEngine.Vector3 vec2)
    {
        float val_1 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = vec1.x, y = vec1.y, z = vec1.z}, rhs:  new UnityEngine.Vector3() {x = vec2.x, y = vec2.y, z = vec2.z});
        return (float)(float)vec2.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void PlaneFrom3Points(out UnityEngine.Vector3 planeNormal, out UnityEngine.Vector3 planePoint, UnityEngine.Vector3 pointA, UnityEngine.Vector3 pointB, UnityEngine.Vector3 pointC)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        planeNormal.x = val_2.x;
        planeNormal.y = val_2.y;
        planeNormal.z = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        planePoint.x = val_3.x;
        planePoint.y = val_3.y;
        planePoint.z = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointB.x, y = pointB.y, z = pointB.z}, b:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointC.x, y = val_1, z = pointC.y}, b:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        planeNormal.x = val_7.x;
        planeNormal.y = val_7.y;
        planeNormal.z = val_7.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pointA.x, y = pointA.y, z = pointA.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointC.x, y = val_1, z = pointC.y}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointB.x, y = pointB.y, z = pointB.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        bool val_14 = Math3d.ClosestPointsOnTwoLines(closestPointLine1: out  new UnityEngine.Vector3() {x = planePoint.x, y = planePoint.y, z = planePoint.z}, closestPointLine2: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, linePoint1:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, lineVec1:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, linePoint2:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = val_13.x}, lineVec2:  new UnityEngine.Vector3() {x = val_13.z, z = val_5.x});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 GetForwardVector(UnityEngine.Quaternion q)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 GetUpVector(UnityEngine.Quaternion q)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 GetRightVector(UnityEngine.Quaternion q)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Quaternion QuaternionFromMatrix(UnityEngine.Matrix4x4 m)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = V3.16B});
        return UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, upwards:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.Vector3 PositionFromMatrix(UnityEngine.Matrix4x4 m)
    {
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void LookRotationExtended(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 alignWithVector, UnityEngine.Vector3 alignWithNormal, UnityEngine.Vector3 customForward, UnityEngine.Vector3 customUp)
    {
        float val_1;
        float val_2;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = alignWithVector.x, y = alignWithVector.y, z = alignWithVector.z}, upwards:  new UnityEngine.Vector3() {x = alignWithNormal.x, y = alignWithNormal.y, z = alignWithNormal.z});
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = customForward.x, y = val_2, z = customForward.y}, upwards:  new UnityEngine.Vector3() {x = customForward.z, y = val_1, z = customUp.x});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
        gameObjectInOut.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void TransformWithParent(out UnityEngine.Quaternion childRotation, out UnityEngine.Vector3 childPosition, UnityEngine.Quaternion parentRotation, UnityEngine.Vector3 parentPosition, UnityEngine.Quaternion startParentRotation, UnityEngine.Vector3 startParentPosition, UnityEngine.Quaternion startChildRotation, UnityEngine.Vector3 startChildPosition)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_7;
        float val_8;
        float val_9;
        var val_13;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        childRotation.x = val_1.x;
        childRotation.y = val_1.y;
        childRotation.z = val_1.z;
        childRotation.w = val_1.w;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        childPosition.x = val_2.x;
        childPosition.y = val_2.y;
        childPosition.z = val_2.z;
        val_13 = null;
        val_13 = null;
        Math3d.tempParent.rotation = new UnityEngine.Quaternion() {x = startParentRotation.x, y = val_4, z = startParentRotation.y, w = val_3};
        Math3d.tempParent.position = new UnityEngine.Vector3() {x = startParentRotation.z, y = val_5, z = startParentRotation.w};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        Math3d.tempParent.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        Math3d.tempChild.rotation = new UnityEngine.Quaternion() {x = startParentPosition.x, y = val_8, z = startParentPosition.y, w = val_7};
        Math3d.tempChild.position = new UnityEngine.Vector3() {x = startParentPosition.z, y = val_9, z = startChildRotation.x};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        Math3d.tempChild.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        Math3d.tempParent.rotation = new UnityEngine.Quaternion() {x = parentRotation.x, y = parentRotation.y, z = parentRotation.z, w = parentRotation.w};
        Math3d.tempParent.position = new UnityEngine.Vector3() {x = parentPosition.x, y = parentPosition.y, z = parentPosition.z};
        UnityEngine.Quaternion val_11 = Math3d.tempChild.rotation;
        childRotation.x = val_11.x;
        childRotation.y = val_11.y;
        childRotation.z = val_11.z;
        childRotation.w = val_11.w;
        UnityEngine.Vector3 val_12 = Math3d.tempChild.position;
        childPosition.x = val_12.x;
        childPosition.y = val_12.y;
        childPosition.z = val_12.z;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void PreciseAlign(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 alignWithVector, UnityEngine.Vector3 alignWithNormal, UnityEngine.Vector3 alignWithPosition, UnityEngine.Vector3 triangleForward, UnityEngine.Vector3 triangleNormal, UnityEngine.Vector3 trianglePosition)
    {
        float val_1;
        float val_4;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        val_10 = triangleForward.z;
        val_11 = triangleForward.y;
        val_12 = alignWithPosition.z;
        val_13 = alignWithNormal.x;
        val_14 = alignWithVector.y;
        val_12 = val_12;
        val_10 = val_10;
        val_11 = val_11;
        val_15 = val_14;
        val_13 = val_13;
        val_14 = val_15;
        val_12 = val_12;
        val_10 = val_10;
        val_11 = val_11;
        val_15 = val_14;
        Math3d.LookRotationExtended(gameObjectInOut: ref  UnityEngine.GameObject val_5 = gameObjectInOut, alignWithVector:  new UnityEngine.Vector3() {x = alignWithVector.x, y = val_15, z = alignWithVector.z}, alignWithNormal:  new UnityEngine.Vector3() {x = val_13, y = alignWithNormal.y, z = alignWithNormal.z}, customForward:  new UnityEngine.Vector3() {x = val_12, y = triangleForward.x, z = val_11}, customUp:  new UnityEngine.Vector3() {x = val_10, z = alignWithNormal.z});
        UnityEngine.Vector3 val_7 = val_5.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = triangleNormal.x, y = val_1, z = triangleNormal.y});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = alignWithPosition.x, y = val_4, z = alignWithPosition.y}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_5.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, relativeTo:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void VectorsToTransform(ref UnityEngine.GameObject gameObjectInOut, UnityEngine.Vector3 positionVector, UnityEngine.Vector3 directionVector, UnityEngine.Vector3 normalVector)
    {
        float val_1;
        gameObjectInOut.transform.position = new UnityEngine.Vector3() {x = positionVector.x, y = positionVector.y, z = positionVector.z};
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = directionVector.x, y = directionVector.y, z = directionVector.z}, upwards:  new UnityEngine.Vector3() {x = normalVector.x, y = val_1, z = normalVector.y});
        gameObjectInOut.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int PointOnWhichSideOfLineSegment(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 point)
    {
        float val_1;
        float val_7;
        var val_8;
        val_7 = linePoint1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = val_1, z = point.y}, b:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = val_7});
        float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        if(val_4 > 0f)
        {
                val_7 = val_4;
            val_8 = ((val_7 > val_4) ? 1 : 0) << 1;
            return (int)val_8;
        }
        
        val_8 = 1;
        return (int)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MouseDistanceToLine(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2)
    {
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = val_1.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z});
        UnityEngine.Vector3 val_4 = val_1.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z});
        UnityEngine.Vector3 val_5 = Math3d.ProjectPointOnLineSegment(linePoint1:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, linePoint2:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z, z = 0f});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        return (float)val_6.x;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float MouseDistanceToCircle(UnityEngine.Vector3 point, float radius)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_4.x = val_4.x - radius;
        return (float)val_4.x;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsLineInRectangle(UnityEngine.Vector3 linePoint1, UnityEngine.Vector3 linePoint2, UnityEngine.Vector3 rectA, UnityEngine.Vector3 rectB, UnityEngine.Vector3 rectC, UnityEngine.Vector3 rectD)
    {
        var val_1;
        var val_2;
        var val_3;
        float val_4;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        var val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        val_13 = 1152921505071702016;
        val_14 = val_1;
        val_15 = rectC.y;
        val_16 = rectC.x;
        val_18 = val_2;
        val_17 = rectB.z;
        val_19 = null;
        val_20 = rectB.y;
        val_21 = val_3;
        val_22 = rectB.x;
        val_23 = rectA.x;
        val_17 = val_17;
        val_22 = val_22;
        val_15 = val_15;
        val_16 = val_16;
        val_21 = val_21;
        val_14 = val_14;
        val_24 = val_17;
        if((Math3d.IsPointInRectangle(point:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, rectA:  new UnityEngine.Vector3() {x = val_23, y = val_4, z = rectA.y}, rectC:  new UnityEngine.Vector3() {x = val_20, y = val_17, z = rectA.z}, rectB:  new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_15}, rectD:  new UnityEngine.Vector3())) == true)
        {
            goto label_3;
        }
        
        val_25 = null;
        if((Math3d.IsPointInRectangle(point:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, rectA:  new UnityEngine.Vector3() {x = val_23, y = val_4, z = rectA.y}, rectC:  new UnityEngine.Vector3() {x = val_20, y = val_24, z = rectA.z}, rectB:  new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_15}, rectD:  new UnityEngine.Vector3() {z = rectA.z})) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_26 = 1;
        return (bool)val_26;
        label_6:
        val_27 = null;
        val_18 = linePoint2.y;
        val_24 = linePoint2.z;
        val_23 = val_14;
        val_20 = linePoint2.x;
        val_13 = Math3d.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = val_20, y = linePoint2.y, z = val_24}, pointB1:  new UnityEngine.Vector3() {x = val_20, y = val_24, z = val_16}, pointB2:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_15});
        bool val_12 = ((Math3d.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = val_23, y = rectA.y, z = rectA.z}, pointB2:  new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_15})) | (Math3d.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = linePoint2.x, y = linePoint2.y, z = linePoint2.z}, pointB1:  new UnityEngine.Vector3() {x = rectA.z, y = val_22, z = val_20}, pointB2:  new UnityEngine.Vector3() {x = val_24, y = val_16, z = val_15}))) | val_13;
        val_12 = val_12 | (Math3d.AreLineSegmentsCrossing(pointA1:  new UnityEngine.Vector3() {x = linePoint1.x, y = linePoint1.y, z = linePoint1.z}, pointA2:  new UnityEngine.Vector3() {x = val_20, y = val_18, z = val_24}, pointB1:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_23}, pointB2:  new UnityEngine.Vector3() {x = rectA.y, y = val_16, z = val_15}));
        val_26 = val_12;
        return (bool)val_26;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsPointInRectangle(UnityEngine.Vector3 point, UnityEngine.Vector3 rectA, UnityEngine.Vector3 rectC, UnityEngine.Vector3 rectB, UnityEngine.Vector3 rectD)
    {
        float val_1;
        float val_2;
        float val_3;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = rectC.x, y = val_1, z = rectC.y}, b:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
        UnityEngine.Vector3 val_6 = Math3d.AddVectorLength(vector:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, size:  val_4.x * (-0.5f));
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = rectC.z, y = val_3, z = rectB.x}, b:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
        val_8.x = val_8.x * 0.5f;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = rectB.y, y = val_2, z = rectB.z}, b:  new UnityEngine.Vector3() {x = rectA.x, y = rectA.y, z = rectA.z});
        UnityEngine.Vector3 val_10 = Math3d.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, lineVec:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, point:  new UnityEngine.Vector3() {x = point.x, y = point.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
        UnityEngine.Vector3 val_12 = Math3d.ProjectPointOnLine(linePoint:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, lineVec:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, point:  new UnityEngine.Vector3() {x = point.x, y = point.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
        float val_17 = 0.5f;
        val_17 = val_9.x * val_17;
        return (bool)((val_13.x <= val_8.x) ? 1 : 0) & ((val_11.x <= val_17) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool AreLineSegmentsCrossing(UnityEngine.Vector3 pointA1, UnityEngine.Vector3 pointA2, UnityEngine.Vector3 pointB1, UnityEngine.Vector3 pointB2)
    {
        float val_1;
        float val_2;
        float val_10;
        float val_11;
        var val_12;
        var val_13;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointA2.x, y = pointA2.y, z = pointA2.z}, b:  new UnityEngine.Vector3() {x = pointA1.x, y = pointA1.y, z = pointA1.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pointB1.z, y = val_2, z = pointB2.x}, b:  new UnityEngine.Vector3() {x = pointB1.x, y = val_1, z = pointB1.y});
        val_10 = val_4.z;
        val_11 = val_4.y;
        if((Math3d.ClosestPointsOnTwoLines(closestPointLine1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, closestPointLine2: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, linePoint1:  new UnityEngine.Vector3() {x = pointA1.x, y = pointA1.y, z = pointA1.z}, lineVec1:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_10}, linePoint2:  new UnityEngine.Vector3() {x = pointB1.x, y = pointB1.y, z = val_4.x}, lineVec2:  new UnityEngine.Vector3() {x = val_4.z, y = val_2, z = pointA2.x})) != false)
        {
                val_12 = null;
            val_11 = 0f;
            val_10 = 0f;
            var val_9 = (((Math3d.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = pointA1.x, y = pointA1.y, z = pointA1.z}, linePoint2:  new UnityEngine.Vector3() {x = pointA2.x, y = pointA2.y, z = pointA2.z}, point:  new UnityEngine.Vector3() {x = 0f, y = val_10, z = val_4.x})) | (Math3d.PointOnWhichSideOfLineSegment(linePoint1:  new UnityEngine.Vector3() {x = pointB1.x, y = val_1, z = pointB1.y}, linePoint2:  new UnityEngine.Vector3() {x = pointB1.z, y = val_2, z = pointB2.x}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_4.x}))) == 0) ? 1 : 0;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool LinearAcceleration(out UnityEngine.Vector3 vector, UnityEngine.Vector3 position, int samples)
    {
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        System.Single[] val_37;
        var val_38;
        System.Single[] val_39;
        float val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        float val_46;
        float val_47;
        var val_48;
        val_27 = position.y;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_28 = val_1.x;
        val_29 = val_1.y;
        val_30 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        vector.x = val_2.x;
        vector.y = val_2.y;
        vector.z = val_2.z;
        val_33 = null;
        val_33 = null;
        if(Math3d.positionRegister == null)
        {
                UnityEngine.Vector3[] val_4 = new UnityEngine.Vector3[0];
            val_34 = null;
            val_34 = null;
            Math3d.positionRegister = val_4;
            val_33 = null;
            Math3d.posTimeRegister = new float[0];
        }
        
        val_35 = 1;
        goto label_8;
        label_20:
        val_36 = mem[1152921519005571816];
        var val_6 = W25 + 1;
        if(val_6 >= val_36)
        {
                val_36 = mem[1152921519005571816];
        }
        
        UnityEngine.Vector3 val_36 = val_4[1];
        val_6 = val_6 - 1;
        var val_7 = Math3d.positionRegister + ((long)(long)(int)(W25) * 12);
        mem2[0] = val_36;
        mem2[0] = val_4[2];
        mem2[0] = val_4[2];
        val_37 = Math3d.posTimeRegister;
        val_38 = mem[1152921519005575912];
        var val_8 = val_6 + 1;
        if(val_8 >= val_38)
        {
                val_38 = mem[1152921519005575912];
        }
        
        var val_9 = val_8 - 1;
        System.Single[] val_10 = val_37 + (((long)(int)(W25)) << 2);
        mem2[0] = val_36;
        val_33 = null;
        val_35 = 2;
        label_8:
        val_33 = null;
        val_39 = val_35 - 1;
        if(Math3d.positionRegister == null)
        {
                val_33 = null;
        }
        
        var val_39 = mem[1152921519005571816];
        val_39 = val_39 - 1;
        if(val_39 < val_39)
        {
            goto label_20;
        }
        
        val_33 = null;
        var val_40 = -4294967296;
        val_40 = val_40 + ((mem[1152921519005571816]) << 32);
        var val_41 = 12;
        val_41 = Math3d.positionRegister + ((val_40 >> 32) * val_41);
        mem2[0] = position.x;
        mem2[0] = val_27;
        mem2[0] = position.z;
        if(Math3d.posTimeRegister != null)
        {
                val_41 = UnityEngine.Time.time;
        }
        else
        {
                val_41 = UnityEngine.Time.time;
        }
        
        var val_42 = -4294967296;
        val_42 = val_42 + ((mem[1152921519005575912]) << 32);
        var val_14 = val_42 >> 32;
        System.Single[] val_15 = Math3d.posTimeRegister + ((((-4294967296 + (mem[1152921519005575912]) << 32) >> 32)) << 2);
        mem2[0] = val_41;
        val_42 = null;
        int val_43 = Math3d.positionSamplesTaken;
        val_43 = val_43 + 1;
        Math3d.positionSamplesTaken = val_43;
        if(Math3d.positionSamplesTaken < ((samples > 3) ? samples : 3))
        {
                return false;
        }
        
        val_43 = 2;
        goto label_29;
        label_61:
        var val_17 = Math3d.positionRegister + (1 * 12);
        var val_18 = (val_39 + 1) - 1;
        val_39 = (long)val_39;
        var val_19 = Math3d.positionRegister + (val_39 * 12);
        val_44 = mem[((long)(int)((val_35 - 1)) * 12) + val_4 + 32];
        val_44 = ((long)(int)((val_35 - 1)) * 12) + val_4 + 32;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (1 * 12) + val_4 + 32, y = (1 * 12) + val_4 + 32 + 4, z = (1 * 12) + val_4 + 40}, b:  new UnityEngine.Vector3() {x = val_44, y = ((long)(int)((val_35 - 1)) * 12) + val_4 + 32 + 4, z = ((long)(int)((val_35 - 1)) * 12) + val_4 + 40});
        val_27 = val_20.y;
        val_41 = val_20.z;
        val_18 = val_18 + 1;
        float val_44 = UnityEngine.Vector3.__il2cppRuntimeField_127 + 32;
        val_37 = Math3d.posTimeRegister;
        val_18 = val_18 - 1;
        System.Single[] val_21 = val_37 + (((long)(int)((val_35 - 1))) << 2);
        val_44 = val_44 - (mem[(val_5 + ((long)(int)((val_35 - 1))) << 2) + 32]);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_27, z = val_41}, d:  val_44);
        val_45 = null;
        val_27 = val_22.x;
        val_45 = null;
        val_18 = val_18 + 2;
        val_46 = val_28;
        var val_23 = Math3d.positionRegister + (2 * 12);
        val_18 = val_18 - 1;
        var val_24 = Math3d.positionRegister + (1 * 12);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (2 * 12) + val_4 + 32, y = (2 * 12) + val_4 + 32 + 4, z = (2 * 12) + val_4 + 40}, b:  new UnityEngine.Vector3() {x = (1 * 12) + val_4 + 32, y = (1 * 12) + val_4 + 32 + 4, z = (1 * 12) + val_4 + 40});
        val_44 = val_25.x;
        val_41 = val_25.z;
        val_37 = Math3d.posTimeRegister;
        val_18 = val_18 + 1;
        float val_45 = (2 * 12) + val_4 + 32;
        val_39 = Math3d.posTimeRegister;
        var val_26 = val_18 - 1;
        val_45 = val_45 - (mem[1152921519005575912] + 32);
        if(val_45 == 0f)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_44, y = val_25.y, z = val_41}, d:  val_45);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_27, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_46, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_42 = null;
        val_28 = val_29.x;
        val_47 = val_29.y;
        val_30 = val_29.z;
        val_43 = 3;
        label_29:
        val_42 = null;
        if(Math3d.positionRegister == null)
        {
                val_42 = null;
        }
        
        var val_46 = mem[1152921519005571816];
        val_46 = val_46 - 2;
        if((val_43 - 2) < val_46)
        {
            goto label_61;
        }
        
        val_48 = 1152921519005567728;
        var val_47 = mem[1152921519005571816];
        val_47 = val_47 - 2;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_28, y = val_47, z = val_30}, d:  (float)val_47);
        var val_48 = -4294967296;
        val_48 = val_48 + ((mem[1152921519005575912]) << 32);
        var val_32 = val_48 >> 32;
        System.Single[] val_33 = Math3d.posTimeRegister + ((((-4294967296 + (mem[1152921519005575912]) << 32) >> 32)) << 2);
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  (mem[(val_5 + (((-4294967296 + (mem[1152921519005575912]) << 32) >> 32)) << 2) + 32]) - mem[1152921519005575920]);
        vector.x = val_35.x;
        vector.y = val_35.y;
        vector.z = val_35.z;
        return false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool AngularAcceleration(out UnityEngine.Vector3 vector, UnityEngine.Quaternion rotation, int samples)
    {
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        UnityEngine.Quaternion[] val_46;
        var val_47;
        var val_48;
        float val_50;
        var val_51;
        var val_52;
        var val_53;
        float val_54;
        float val_55;
        var val_56;
        val_34 = rotation.z;
        val_35 = rotation.x;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_36 = val_1.x;
        val_37 = val_1.y;
        val_38 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        vector.x = val_2.x;
        vector.y = val_2.y;
        vector.z = val_2.z;
        val_41 = null;
        val_41 = null;
        if(Math3d.rotationRegister == null)
        {
                UnityEngine.Quaternion[] val_4 = new UnityEngine.Quaternion[0];
            val_42 = null;
            val_42 = null;
            Math3d.rotationRegister = val_4;
            val_41 = null;
            Math3d.rotTimeRegister = new float[0];
        }
        
        val_43 = 1;
        goto label_8;
        label_20:
        val_44 = mem[1152921519005712456];
        val_45 = 1;
        if(val_4[1] >= val_44)
        {
                val_44 = mem[1152921519005712456];
        }
        
        val_46 = val_4[1] - 1;
        mem2[0] = Math3d.__il2cppRuntimeField_cctor_finished + 32;
        mem2[0] = Math3d.__il2cppRuntimeField_cctor_finished + 32 + 4;
        mem2[0] = Math3d.__il2cppRuntimeField_cctor_finished + 40;
        mem2[0] = Math3d.__il2cppRuntimeField_cctor_finished + 40 + 4;
        val_47 = mem[1152921519005716552];
        if(val_46[1] >= val_47)
        {
                val_47 = mem[1152921519005716552];
        }
        
        UnityEngine.Quaternion[] val_6 = val_46[1] - 1;
        mem2[0] = Math3d.__il2cppRuntimeField_cctor_finished + 32;
        val_41 = null;
        val_43 = 2;
        label_8:
        val_41 = null;
        val_48 = val_43 - 1;
        if(Math3d.rotationRegister == null)
        {
                val_41 = null;
        }
        
        var val_32 = mem[1152921519005712456];
        val_32 = val_32 - 1;
        if(val_48 < val_32)
        {
            goto label_20;
        }
        
        val_41 = null;
        var val_33 = -4294967296;
        val_33 = val_33 + ((mem[1152921519005712456]) << 32);
        var val_7 = val_33 >> 32;
        UnityEngine.Quaternion[] val_8 = Math3d.rotationRegister + ((((-4294967296 + (mem[1152921519005712456]) << 32) >> 32)) << 4);
        mem2[0] = val_35;
        mem2[0] = rotation.y;
        mem2[0] = val_34;
        mem2[0] = rotation.w;
        if(Math3d.rotTimeRegister != null)
        {
                val_50 = UnityEngine.Time.time;
        }
        else
        {
                val_50 = UnityEngine.Time.time;
        }
        
        var val_34 = -4294967296;
        val_34 = val_34 + ((mem[1152921519005716552]) << 32);
        val_51 = val_34 >> 32;
        System.Single[] val_11 = Math3d.rotTimeRegister + ((((-4294967296 + (mem[1152921519005716552]) << 32) >> 32)) << 2);
        mem2[0] = val_50;
        val_52 = null;
        int val_35 = Math3d.rotationSamplesTaken;
        val_35 = val_35 + 1;
        Math3d.rotationSamplesTaken = val_35;
        if(Math3d.rotationSamplesTaken < ((samples > 3) ? samples : 3))
        {
            goto label_51;
        }
        
        val_53 = 2;
        goto label_29;
        label_59:
        val_48 = 1;
        val_46 = Math3d.rotationRegister;
        UnityEngine.Quaternion val_15 = Math3d.SubtractRotation(B:  new UnityEngine.Quaternion() {x = 0f, y = 3.051758E-05f, z = 3.78118E-40f, w = 0f}, A:  new UnityEngine.Quaternion() {x = mem[(val_4 + ((long)(int)(Math3d.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 32], y = mem[(val_4 + ((long)(int)(Math3d.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 32 + 4], z = mem[(val_4 + ((long)(int)(Math3d.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 40], w = mem[(val_4 + ((long)(int)(Math3d.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 40 + 4]});
        val_50 = val_15.x;
        val_34 = val_15.z;
        val_54 = 0f - (mem[(val_5 + ((long)(int)(Math3d.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 2) + 32]);
        if(val_54 == 0f)
        {
            goto label_51;
        }
        
        UnityEngine.Vector3 val_18 = Math3d.RotDiffToSpeedVec(rotation:  new UnityEngine.Quaternion() {x = val_50, y = val_15.y, z = val_34, w = val_15.w}, deltaTime:  val_54);
        val_34 = val_18.y;
        UnityEngine.Quaternion val_21 = Math3d.SubtractRotation(B:  new UnityEngine.Quaternion() {x = 0f, y = 3.051758E-05f, z = 3.78118E-40f, w = 0f}, A:  new UnityEngine.Quaternion() {x = mem[1152921519005712456] + 32, y = mem[1152921519005712456] + 32 + 4, z = mem[1152921519005712456] + 40, w = mem[1152921519005712456] + 40 + 4});
        val_35 = val_21.x;
        val_50 = val_21.z;
        val_54 = 0f - (mem[1152921519005716552] + 32);
        if(val_54 == 0f)
        {
            goto label_51;
        }
        
        UnityEngine.Vector3 val_23 = Math3d.RotDiffToSpeedVec(rotation:  new UnityEngine.Quaternion() {x = val_35, y = val_21.y, z = val_50, w = val_21.w}, deltaTime:  val_54);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_34, z = val_18.z});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_38}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        val_52 = null;
        val_36 = val_25.x;
        val_37 = val_25.y;
        val_55 = val_25.z;
        val_53 = 3;
        label_29:
        val_52 = null;
        if(Math3d.rotationRegister == null)
        {
                val_52 = null;
        }
        
        var val_36 = mem[1152921519005712456];
        val_36 = val_36 - 2;
        if((val_53 - 2) < val_36)
        {
            goto label_59;
        }
        
        val_52 = null;
        var val_37 = mem[1152921519005712456];
        val_37 = val_37 - 2;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_55}, d:  (float)val_37);
        val_50 = val_27.x;
        val_54 = val_27.z;
        var val_38 = -4294967296;
        val_38 = val_38 + ((mem[1152921519005716552]) << 32);
        var val_28 = val_38 >> 32;
        System.Single[] val_29 = Math3d.rotTimeRegister + ((((-4294967296 + (mem[1152921519005716552]) << 32) >> 32)) << 2);
        val_51 = 1152921519005708352;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_50, y = val_27.y, z = val_54}, d:  (mem[(val_5 + (((-4294967296 + (mem[1152921519005716552]) << 32) >> 32)) << 2) + 32]) - mem[1152921519005716560]);
        val_56 = 1;
        vector.x = val_31.x;
        vector.y = val_31.y;
        vector.z = val_31.z;
        return (bool)val_56;
        label_51:
        val_56 = 0;
        return (bool)val_56;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float LinearFunction2DBasic(float x, float Qx, float Qy)
    {
        Qx = Qy / Qx;
        x = Qx * x;
        return (float)x;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static float LinearFunction2DFull(float x, float Px, float Py, float Qx, float Qy)
    {
        Qx = Qx - Px;
        Qy = Qy - Py;
        Qx = Qy / Qx;
        x = x - Px;
        x = x * Qx;
        x = x + Py;
        return (float)x;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.Vector3 RotDiffToSpeedVec(UnityEngine.Quaternion rotation, float deltaTime)
    {
        float val_1 = rotation.x + (-360f);
        rotation.x = val_1 + (-360f);
        rotation.z = (rotation.z > 180f) ? (rotation.z + (-360f)) : rotation.z;
        float val_5 = ((rotation.x > 180f) ? (val_1) : rotation.x) / deltaTime;
        float val_6 = ((val_1 > 180f) ? (rotation.x) : (val_1)) / deltaTime;
        rotation.z = rotation.z / deltaTime;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static double GetDistance(UnityEngine.Vector3 vec1, UnityEngine.Vector3 vec2)
    {
        vec1.x = vec1.x - vec2.x;
        vec1.y = vec1.y - vec2.y;
        vec1.z = vec1.z - vec2.z;
        double val_1 = (double)vec1.x;
        double val_2 = (double)vec1.y;
        double val_3 = (double)vec1.z;
        val_1 = val_1 * val_1;
        val_2 = val_2 * val_2;
        val_3 = val_3 * val_3;
        val_1 = val_1 + val_2;
        val_1 = val_3 + val_1;
        if(val_2 <= _TYPE_MAX_)
        {
                return (double)val_2;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Math3d()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static Math3d()
    {
    
    }

}
