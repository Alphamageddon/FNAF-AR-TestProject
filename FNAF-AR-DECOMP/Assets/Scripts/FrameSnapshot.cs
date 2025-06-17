using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class GuideHistory.FrameSnapshot
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Systems.Guide.GuideNode[] listening;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Systems.Guide.GuideNode[] acting;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Systems.Guide.GuideNode[] expired;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GuideHistory.FrameSnapshot(Systems.Guide.GuideNodeDriver driver)
    {
        if(driver != null)
        {
                this.listening = driver.Listening;
            this.acting = driver.Acting;
        }
        else
        {
                this.listening = 0.Listening;
            this.acting = 0.Acting;
        }
        
        this.expired = driver.ExpiredLastFrame;
    }

}
