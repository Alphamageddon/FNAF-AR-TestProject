using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class Test_NumericalOdeSolver.OdeTask
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float t0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float tEnd;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float y0;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float step;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Dest.Math.OdeFunction Func;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Func<float, float> ExactSolution;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float ScaleY;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Test_NumericalOdeSolver.OdeTask()
    {
    
    }

}
