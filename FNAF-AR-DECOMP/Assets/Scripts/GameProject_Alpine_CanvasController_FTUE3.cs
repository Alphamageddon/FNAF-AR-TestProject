using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameProject_Alpine_CanvasController_FTUE3 : CanvasController
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.Start();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnStoreButtonClicked()
    {
        Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
        val_1.eventExposer.OnUIChangeRequest(obj:  3);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameProject_Alpine_CanvasController_FTUE3()
    {
    
    }

}
