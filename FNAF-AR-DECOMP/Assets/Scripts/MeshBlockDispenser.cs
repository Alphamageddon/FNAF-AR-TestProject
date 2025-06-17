using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MeshBlockDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IMeshBlockAccepter> meshBlockAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(IMeshBlockAccepter accepter)
    {
        this.meshBlockAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IMeshBlockAccepter> accepters)
    {
        this.meshBlockAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SendMeshBlockEvent(UnityEngine.Vector3 key, UnityEngine.Vector3[] vertices, int[] triangles)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.meshBlockAccepters.Item[0].OnMeshBlockUpdatedEvent(key:  new UnityEngine.Vector3() {x = key.x, y = key.y, z = key.z}, indexes:  vertices, triangles:  triangles);
        0 = 1;
        label_1:
        if(0 < this.meshBlockAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MeshBlockDispenser()
    {
        this.meshBlockAccepters = new System.Collections.Generic.List<IMeshBlockAccepter>();
    }

}
