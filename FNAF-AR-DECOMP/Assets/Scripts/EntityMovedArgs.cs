using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class Mover.EntityMovedArgs
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AnimatronicEntity.AnimatronicEntity entity;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Utils.Vector2d geoPosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float distanceFromPlayer;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mover.EntityMovedArgs()
    {
    
    }

}
