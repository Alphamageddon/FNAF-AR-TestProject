using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class RawDirectedPointsDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IRawDirectedPointsAccepter> directedPointsAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(IRawDirectedPointsAccepter accepter)
    {
        this.directedPointsAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IRawDirectedPointsAccepter> accepters)
    {
        this.directedPointsAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendDirectedPointsEvent(UnityEngine.Vector3[] positions, UnityEngine.Vector3[] directions, UnityEngine.Vector3 cameraPos)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.directedPointsAccepters.Item[0].OnDirectedPointsUpdateEvent(positions:  positions, directions:  directions, cameraPos:  new UnityEngine.Vector3() {x = cameraPos.x, y = cameraPos.y, z = cameraPos.z});
        0 = 1;
        label_1:
        if(0 < this.directedPointsAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public RawDirectedPointsDispenser()
    {
        this.directedPointsAccepters = new System.Collections.Generic.List<IRawDirectedPointsAccepter>();
    }

}
