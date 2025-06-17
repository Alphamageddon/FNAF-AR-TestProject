using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TileDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<ITileAccepter> tileAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(ITileAccepter accepter)
    {
        this.tileAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<ITileAccepter> accepters)
    {
        this.tileAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendTileAddEvent(UnityEngine.Vector3 center, float length)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.tileAccepters.Item[0].OnTileAddEvent(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, length:  length);
        0 = 1;
        label_1:
        if(0 < this.tileAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SentTileRemoveEvent(UnityEngine.Vector3 center)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.tileAccepters.Item[0].OnTileRemoveEvent(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        0 = 1;
        label_1:
        if(0 < this.tileAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TileDispenser()
    {
        this.tileAccepters = new System.Collections.Generic.List<ITileAccepter>();
    }

}
