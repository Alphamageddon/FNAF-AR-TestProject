using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_1
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color startColor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color endColor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public P7.CanvasFlow.ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_0 CS$<>8__locals1;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_1()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <FadeBackgroundAnimation>b__0(float progress01)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.startColor}, b:  new UnityEngine.Color() {r = this.endColor}, t:  progress01);
        this.CS$<>8__locals1.backgroundImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }

}
