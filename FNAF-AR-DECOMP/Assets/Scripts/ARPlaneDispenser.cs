using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ARPlaneDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IARPlaneAccepter> planeAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(IARPlaneAccepter accepter)
    {
        this.planeAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IARPlaneAccepter> accepters)
    {
        this.planeAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendPlaneAddedEvent(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_9:
        val_5 = public IARPlaneAccepter System.Collections.Generic.List<IARPlaneAccepter>::get_Item(int index);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_5 = 0;
        this.planeAccepters.Item[0].OnPlaneAddedEvent(plane:  plane);
        val_4 = 1;
        label_1:
        if(val_4 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendPlaneRemovedEvent(UnityEngine.XR.ARFoundation.ARPlane plane)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_9:
        val_5 = public IARPlaneAccepter System.Collections.Generic.List<IARPlaneAccepter>::get_Item(int index);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_5 = 1;
        this.planeAccepters.Item[0].OnPlaneRemovedEvent(plane:  plane);
        val_4 = 1;
        label_1:
        if(val_4 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ARPlaneDispenser()
    {
        this.planeAccepters = new System.Collections.Generic.List<IARPlaneAccepter>();
    }

}
