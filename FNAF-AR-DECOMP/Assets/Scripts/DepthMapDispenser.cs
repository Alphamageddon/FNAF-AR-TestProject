using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DepthMapDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IDepthMapAccepter> depthMapAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(IDepthMapAccepter accepter)
    {
        this.depthMapAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IDepthMapAccepter> accepters)
    {
        this.depthMapAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendDepthMapEvent(UnityEngine.Vector3[,] depthMap, bool[,] mask, UnityEngine.Vector3 cameraPos)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.depthMapAccepters.Item[0].OnDepthMapUpdatedEvent(depthMap:  depthMap, keepMask:  mask, cameraPos:  new UnityEngine.Vector3() {x = cameraPos.x, y = cameraPos.y, z = cameraPos.z});
        0 = 1;
        label_1:
        if(0 < this.depthMapAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DepthMapDispenser()
    {
        this.depthMapAccepters = new System.Collections.Generic.List<IDepthMapAccepter>();
    }

}
