using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ProcessedDirectedPointsDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IProcessedDirectedPointsAccepter> directedPointsAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IProcessedDirectedPointsAccepter> accepters)
    {
        this.directedPointsAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendDirectedPointsEvent(UnityEngine.Vector3[] keys, DirectedPointsManager.DirectedPointData[] data, UnityEngine.Vector3 cameraPos)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.directedPointsAccepters.Item[0].OnDirectedPointsUpdateEvent(keys:  keys, data:  data, cameraPos:  new UnityEngine.Vector3() {x = cameraPos.x, y = cameraPos.y, z = cameraPos.z});
        0 = 1;
        label_1:
        if(0 < this.directedPointsAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProcessedDirectedPointsDispenser()
    {
    
    }

}
