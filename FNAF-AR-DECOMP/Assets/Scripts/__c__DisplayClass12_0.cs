using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class SlideTransitionAnimator.<>c__DisplayClass12_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public P7.CanvasFlow.CanvasController presentedCanvasController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 contentStartPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 contentEndPosition;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SlideTransitionAnimator.<>c__DisplayClass12_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <MovePresentedContentAnimation>b__0(float progress01)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = this.contentStartPosition, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.contentEndPosition, y = V11.16B, z = V9.16B}, t:  progress01);
        this.presentedCanvasController.ContentPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }

}
