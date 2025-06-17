using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PointDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IPointAccepter> pointAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(IPointAccepter accepter)
    {
        this.pointAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IPointAccepter> accepters)
    {
        this.pointAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendPointUpdateEvent(UnityEngine.Vector3[] pointData)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_9:
        val_5 = public IPointAccepter System.Collections.Generic.List<IPointAccepter>::get_Item(int index);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_5 = 0;
        this.pointAccepters.Item[0].OnPointUpdatedEvent(pointData:  pointData);
        val_4 = 1;
        label_1:
        if(val_4 < this.pointAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PointDispenser()
    {
        this.pointAccepters = new System.Collections.Generic.List<IPointAccepter>();
    }

}
