using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TimeUpdateDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<ITimeUpdateAccepter> timeAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(ITimeUpdateAccepter accepter)
    {
        this.timeAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<ITimeUpdateAccepter> accepters)
    {
        this.timeAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendTimeUpdateEvent()
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.timeAccepters.Item[0].TimeUpdateEvent();
        0 = 1;
        label_1:
        if(0 < this.timeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TimeUpdateDispenser()
    {
        this.timeAccepters = new System.Collections.Generic.List<ITimeUpdateAccepter>();
    }

}
