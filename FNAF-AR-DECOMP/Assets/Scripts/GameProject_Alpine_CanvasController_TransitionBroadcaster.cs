using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class GameProject_Alpine_CanvasController_TransitionBroadcaster : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Master.MasterDomain masterDomain;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract TheGame.GameDisplayData.DisplayType DisplayType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract TheGame.GameDisplayData.DisplayType get_DisplayType(); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.Start();
        this.masterDomain = Master.MasterDomain.GetDomain();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CanvasDidAppear()
    {
        this.CanvasDidAppear();
        this.masterDomain.eventExposer.OnUICanvasDidAppear(displayType:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void CanvasDidDisappear()
    {
        this.CanvasDidDisappear();
        this.masterDomain.eventExposer.OnUICanvasClosed(displayType:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected GameProject_Alpine_CanvasController_TransitionBroadcaster()
    {
    
    }

}
