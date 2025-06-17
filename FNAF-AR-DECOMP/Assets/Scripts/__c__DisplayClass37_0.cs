using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class StoreCarousel.<>c__DisplayClass37_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.EventSystems.PointerEventData eventData;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public StoreCarousel.<>c__DisplayClass37_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent)
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        parent.OnDrag(eventData:  this.eventData);
    }

}
