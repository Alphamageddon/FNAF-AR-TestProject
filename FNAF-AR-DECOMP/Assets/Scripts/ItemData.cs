using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
protected class SplineBase.ItemData
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 Position;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 A;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 B;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 C;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 D;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Length;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float AccumulatedLength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int SegmentCount = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int SegmentCountPlus1 = 11;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float DeltaTime = 0.1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3[] RenderPoints;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool EnsureRenderPointsValidity()
    {
        var val_2;
        if((this.RenderPoints != null) && (this.RenderPoints.Length == 11))
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.RenderPoints = new UnityEngine.Vector3[11];
        val_2 = 1;
        return (bool)val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void UpdateRenderPoints()
    {
        var val_4 = 0;
        var val_2 = 0;
        float val_3 = 0f;
        do
        {
            UnityEngine.Vector3 val_1 = this.EvalPosition(t:  val_3);
            val_2 = val_2 + 1;
            val_3 = val_3 + 0.1f;
            val_4 = val_4 + 12;
            this.RenderPoints[val_4] = val_1;
            this.RenderPoints[val_4] = val_1.y;
            this.RenderPoints[val_4] = val_1.z;
        }
        while(val_2 != 11);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 EvalPosition(float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  t, a:  new UnityEngine.Vector3() {x = this.D, y = V13.16B, z = V11.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.C, y = V9.16B, z = V15.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  t, a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.B, y = this.B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  t, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.A, y = this.A, z = this.A}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 EvalFirstDerivative(float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.C, y = V14.16B, z = V12.16B}, d:  2f);
        float val_5 = 3f;
        val_5 = t * val_5;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.D, y = val_1.y, z = val_1.z}, d:  val_5);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  t, a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.B, y = V10.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 EvalSecondDerivative(float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = this.C, y = V9.16B, z = V10.16B});
        float val_3 = 6f;
        val_3 = t * val_3;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  val_3, a:  new UnityEngine.Vector3() {x = this.D, y = val_1.z, z = V10.16B});
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 EvalThirdDerivative(float t)
    {
        return UnityEngine.Vector3.op_Multiply(d:  6f, a:  new UnityEngine.Vector3() {x = this.D, y = V8.16B, z = V9.16B});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float EvalSpeed(float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.C, y = V14.16B, z = V12.16B}, d:  2f);
        float val_6 = 3f;
        val_6 = t * val_6;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.D, y = val_1.y, z = val_1.z}, d:  val_6);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  t, a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.B, y = V10.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        return (float)val_5.x;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 EvalTangent(float t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.C, y = V14.16B, z = V12.16B}, d:  2f);
        float val_6 = 3f;
        val_6 = t * val_6;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.D, y = val_1.y, z = val_1.z}, d:  val_6);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  t, a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.B, y = V10.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float EvalLength()
    {
        return Dest.Math.Integrator.GaussianQuadrature(function:  new System.Func<System.Single, System.Single>(object:  this, method:  public System.Single SplineBase.ItemData::EvalSpeed(float t)), a:  0f, b:  1f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float EvalLength(float t0, float t1)
    {
        return Dest.Math.Integrator.GaussianQuadrature(function:  new System.Func<System.Single, System.Single>(object:  this, method:  public System.Single SplineBase.ItemData::EvalSpeed(float t)), a:  t0, b:  t1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ProcessLength(float currentLength)
    {
        float val_1 = this.EvalLength();
        float val_2 = val_1 + currentLength;
        this.Length = val_1;
        this.AccumulatedLength = val_2;
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SplineBase.ItemData()
    {
    
    }

}
