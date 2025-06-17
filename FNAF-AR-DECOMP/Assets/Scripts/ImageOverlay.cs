using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class FadeToColorTransitionAnimator.ImageOverlay
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject gameObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Image image;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.RectTransform rectTransform;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color Color { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FadeToColorTransitionAnimator.ImageOverlay()
    {
        System.Type[] val_1 = new System.Type[1];
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_2;
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "FadeToColorTransitionAnimator - Overlay", components:  val_1);
        this.gameObject = val_3;
        this.image = val_3.AddComponent<UnityEngine.UI.Image>();
        this.rectTransform = this.gameObject.GetComponent<UnityEngine.RectTransform>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color get_Color()
    {
        if(this.image != null)
        {
                return this.image.color;
        }
        
        return this.image.color;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Color(UnityEngine.Color value)
    {
        this.image.color = new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetParent(UnityEngine.RectTransform parent)
    {
        this.rectTransform.SetParent(parent:  parent, worldPositionStays:  false);
        P7.CanvasFlow.RectTransformExtensions.RectTransformExtensions.FillParent(rectTransform:  this.rectTransform);
    }

}
