using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class Container.<>c__DisplayClass16_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MapMode.GeoPositionObject.EntityType entityType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<MapMode.GeoPositionObject.GeoPositionObjectInfo> objectsCleared;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Container.<>c__DisplayClass16_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal bool <ClearAllOfType>b__0(MapMode.GeoPositionObject.GeoPositionObjectInfo target)
    {
        MapMode.GeoPositionObject.GeoPositionObject val_2;
        var val_3;
        val_2 = target;
        if(target.entityType != this.entityType)
        {
            goto label_2;
        }
        
        MapMode.GeoPositionObject.GeoPositionObjectInfo val_1 = new MapMode.GeoPositionObject.GeoPositionObjectInfo();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .entityType = this.entityType;
        val_2 = target.geoPositionObject;
        goto label_4;
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_3:
        mem[16] = this.entityType;
        val_2 = target.geoPositionObject;
        label_4:
        .geoPositionObject = val_2;
        this.objectsCleared.Add(item:  val_1);
        val_3 = 1;
        return (bool)val_3;
    }

}
