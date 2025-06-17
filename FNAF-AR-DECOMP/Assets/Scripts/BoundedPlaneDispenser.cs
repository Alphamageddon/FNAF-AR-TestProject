using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class BoundedPlaneDispenser
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<IBoundedPlaneAccepter> planeAccepters;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddAccepter(IBoundedPlaneAccepter accepter)
    {
        this.planeAccepters.Add(item:  accepter);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetAccepters(System.Collections.Generic.List<IBoundedPlaneAccepter> accepters)
    {
        this.planeAccepters = accepters;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.planeAccepters.Item[0].OnHorizontalBoundedPlaneAdd(id:  id, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
        0 = 1;
        label_1:
        if(0 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.planeAccepters.Item[0].OnHorizontalBoundedPlaneUpdate(id:  id, boundary:  boundary, height:  height);
        0 = 1;
        label_1:
        if(0 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnHorizontalPlaneRemove(int id)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_9:
        val_5 = public IBoundedPlaneAccepter System.Collections.Generic.List<IBoundedPlaneAccepter>::get_Item(int index);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_5 = 2;
        this.planeAccepters.Item[0].OnHorizontalBoundedPlaneRemove(id:  id);
        val_4 = 1;
        label_1:
        if(val_4 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.planeAccepters.Item[0].OnVerticalBoundedPlaneAdd(id:  id, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
        0 = 1;
        label_1:
        if(0 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal)
    {
        goto label_1;
        label_9:
        var val_4 = 0;
        val_4 = val_4 + 1;
        this.planeAccepters.Item[0].OnVerticalBoundedPlaneUpdate(id:  id, boundary:  boundary, center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, normal:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z});
        0 = 1;
        label_1:
        if(0 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnVerticalPlaneRemove(int id)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_9:
        val_5 = public IBoundedPlaneAccepter System.Collections.Generic.List<IBoundedPlaneAccepter>::get_Item(int index);
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_5 = 5;
        this.planeAccepters.Item[0].OnVerticalBoundedPlaneRemove(id:  id);
        val_4 = 1;
        label_1:
        if(val_4 < this.planeAccepters.Count)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public BoundedPlaneDispenser()
    {
        this.planeAccepters = new System.Collections.Generic.List<IBoundedPlaneAccepter>();
    }

}
