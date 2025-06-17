using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TutorialSendUIEvent : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TutorialSendUIEvent.TutorialUIEvent _eventId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _sendOnStart;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(this._sendOnStart == false)
        {
                return;
        }
        
        this.Trigger();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Trigger()
    {
        Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
        val_1.eventExposer.OnTutorialUIEvent(eventId:  this._eventId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialSendUIEvent()
    {
    
    }

}
