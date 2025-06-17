using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class RecenterMap : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Map.AbstractMap map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject recenterTarget;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void DoRecenterNow()
    {
        var val_5;
        UnityEngine.Vector3 val_2 = this.recenterTarget.transform.position;
        if(this.map != null)
        {
                val_5 = this.map.InitialZoom;
        }
        else
        {
                val_5 = 0.InitialZoom;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public RecenterMap()
    {
    
    }

}
