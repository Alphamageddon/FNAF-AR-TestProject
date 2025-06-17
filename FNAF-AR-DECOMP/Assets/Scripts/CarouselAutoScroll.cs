using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class StoreCarousel.CarouselAutoScroll
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float ROTATE_INTERVAL = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action _scrollDelegate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SimpleTimer _simpleTimer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public StoreCarousel.CarouselAutoScroll(System.Action ScrollDelegate)
    {
        this._scrollDelegate = ScrollDelegate;
        this._simpleTimer = new SimpleTimer();
        this.ResetTimer();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ResetTimer()
    {
        this._simpleTimer.StartTimer(time:  5f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Update(bool isDragging)
    {
        if(isDragging != true)
        {
                if(this._simpleTimer.IsExpired() == false)
        {
                return;
        }
        
            this._scrollDelegate.Invoke();
        }
        
        this.ResetTimer();
    }

}
