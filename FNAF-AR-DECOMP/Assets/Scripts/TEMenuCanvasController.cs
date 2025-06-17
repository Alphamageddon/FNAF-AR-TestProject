using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TEMenuCanvasController : CanvasController, ICanvasControllerTransitioningAnimatorVendor
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public P7.CanvasFlow.CanvasControllerTransitioningAnimator[] animators;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDefaultTransitionButtonPressed()
    {
        this.PresentCanvasController<TESlideTransitionCanvasController>(animated:  true, configuration:  new System.Action<TEDefaultTransitionCanvasController>(object:  this, method:  System.Void TEMenuCanvasController::<OnDefaultTransitionButtonPressed>b__1_0(TEDefaultTransitionCanvasController descriptionCanvasController)), completion:  0, canvasWorldPositionOverride:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, loadAsynchronously:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnFadeTransitionButtonPressed()
    {
        this.PresentCanvasController<TESlideTransitionCanvasController>(animated:  true, configuration:  new System.Action<TEFadeTransitionCanvasController>(object:  this, method:  System.Void TEMenuCanvasController::<OnFadeTransitionButtonPressed>b__2_0(TEFadeTransitionCanvasController descriptionCanvasController)), completion:  0, canvasWorldPositionOverride:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, loadAsynchronously:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnSlideTransitionButtonPressed()
    {
        this.PresentCanvasController<TESlideTransitionCanvasController>(animated:  true, configuration:  new System.Action<TESlideTransitionCanvasController>(object:  this, method:  System.Void TEMenuCanvasController::<OnSlideTransitionButtonPressed>b__3_0(TESlideTransitionCanvasController descriptionCanvasController)), completion:  0, canvasWorldPositionOverride:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, loadAsynchronously:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnScaleTransitionButtonPressed()
    {
        this.PresentCanvasController<TESlideTransitionCanvasController>(animated:  true, configuration:  new System.Action<TEScaleTransitionCanvasController>(object:  this, method:  System.Void TEMenuCanvasController::<OnScaleTransitionButtonPressed>b__4_0(TEScaleTransitionCanvasController descriptionCanvasController)), completion:  0, canvasWorldPositionOverride:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, loadAsynchronously:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnScaleAndFadeTransitionButtonPressed()
    {
        this.PresentCanvasController<TESlideTransitionCanvasController>(animated:  true, configuration:  new System.Action<TEScaleAndFadeTransitionCanvasController>(object:  this, method:  System.Void TEMenuCanvasController::<OnScaleAndFadeTransitionButtonPressed>b__5_0(TEScaleAndFadeTransitionCanvasController descriptionCanvasController)), completion:  0, canvasWorldPositionOverride:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, loadAsynchronously:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public P7.CanvasFlow.ICanvasControllerTransitioningAnimator TransitioningAnimatorForContext(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
    {
        P7.CanvasFlow.CanvasController val_6;
        if(transitionContext == null)
        {
            goto label_1;
        }
        
        if(transitionContext.isUpstream == false)
        {
            goto label_2;
        }
        
        label_4:
        val_6 = transitionContext.sourceCanvasController;
        goto label_3;
        label_1:
        if(64 != 0)
        {
            goto label_4;
        }
        
        label_2:
        val_6 = transitionContext.destinationCanvasController;
        label_3:
        return (P7.CanvasFlow.ICanvasControllerTransitioningAnimator)this.animators[0];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TEMenuCanvasController()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnDefaultTransitionButtonPressed>b__1_0(TEDefaultTransitionCanvasController descriptionCanvasController)
    {
        mem2[0] = this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnFadeTransitionButtonPressed>b__2_0(TEFadeTransitionCanvasController descriptionCanvasController)
    {
        mem2[0] = this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnSlideTransitionButtonPressed>b__3_0(TESlideTransitionCanvasController descriptionCanvasController)
    {
        mem2[0] = this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnScaleTransitionButtonPressed>b__4_0(TEScaleTransitionCanvasController descriptionCanvasController)
    {
        mem2[0] = this;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnScaleAndFadeTransitionButtonPressed>b__5_0(TEScaleAndFadeTransitionCanvasController descriptionCanvasController)
    {
        mem2[0] = this;
    }

}
