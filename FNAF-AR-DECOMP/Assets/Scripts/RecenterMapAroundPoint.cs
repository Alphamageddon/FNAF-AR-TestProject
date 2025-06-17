using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class RecenterMapAroundPoint : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Map.AbstractMap map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string className = "RecenterMapAroundPoint";
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SnapToCenterAroundPoint(Mapbox.Utils.Vector2d point)
    {
        var val_3;
        if(this.map != null)
        {
                val_3 = this.map.InitialZoom;
        }
        else
        {
                val_3 = 0.InitialZoom;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public RecenterMapAroundPoint()
    {
    
    }

}
