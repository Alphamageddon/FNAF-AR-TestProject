using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class FadeToColorTransitionAnimator.<>c__DisplayClass8_1
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public P7.CanvasFlow.CanvasController source;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public P7.CanvasFlow.FadeToColorTransitionAnimator.<>c__DisplayClass8_0 CS$<>8__locals1;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FadeToColorTransitionAnimator.<>c__DisplayClass8_1()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <AnimateTransitionForInitialCanvasController>b__0()
    {
        FadeToColorTransitionAnimator.<>c__DisplayClass8_0 val_3;
        P7.CanvasFlow.FadeToColorTransitionAnimator val_4;
        FadeToColorTransitionAnimator.<>c__DisplayClass8_0 val_5;
        this.CS$<>8__locals1.imageOverlay.SetParent(parent:  P7.CanvasFlow.CanvasControllerExtensions.CanvasRectTransform(canvasController:  this.source));
        this.source.ContentActive = false;
        val_3 = this.CS$<>8__locals1;
        if(val_3 == null)
        {
            goto label_4;
        }
        
        val_4 = this.CS$<>8__locals1.<>4__this;
        val_5 = val_3;
        goto label_7;
        label_4:
        val_5 = this.CS$<>8__locals1;
        val_4 = this.CS$<>8__locals1.<>4__this;
        if(val_5 == null)
        {
            goto label_6;
        }
        
        val_3 = val_5;
        goto label_7;
        label_6:
        val_3 = this.CS$<>8__locals1;
        if(val_3 == null)
        {
            goto label_8;
        }
        
        label_7:
        val_4.PerformPostFade(imageOverlay:  this.CS$<>8__locals1.imageOverlay, completion:  new System.Action(object:  this.CS$<>8__locals1.transitionContext, method:  public System.Void P7.CanvasFlow.CanvasControllerTransitionContext::CompleteTransition()));
        return;
        label_8:
    }

}
