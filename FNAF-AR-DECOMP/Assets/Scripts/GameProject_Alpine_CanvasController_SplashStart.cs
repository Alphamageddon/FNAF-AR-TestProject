using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameProject_Alpine_CanvasController_SplashStart : CanvasController
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.Start();
        Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
        val_1.eventExposer.SendPreloadEvent(preloadView:  this, eventName:  "start");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameProject_Alpine_CanvasController_SplashStart()
    {
    
    }

}
