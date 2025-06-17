using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SetCameraHeight : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Map.AbstractMap _map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera _referenceCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _cameraOffset;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        if(this._map == 0)
        {
                this._map = UnityEngine.Object.FindObjectOfType<Mapbox.Unity.Map.AbstractMap>();
        }
        
        if(this._referenceCamera != 0)
        {
                return;
        }
        
        this._referenceCamera = UnityEngine.Object.FindObjectOfType<UnityEngine.Camera>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_6;
        var val_7;
        UnityEngine.Vector3 val_2 = this._referenceCamera.transform.position;
        if(this._map != null)
        {
                Mapbox.Utils.Vector2d val_3 = this._map.CenterLatitudeLongitude;
            val_6 = val_3.x;
            val_7 = val_3.y;
        }
        else
        {
                Mapbox.Utils.Vector2d val_4 = 0.CenterLatitudeLongitude;
            val_6 = val_4.x;
            val_7 = val_4.y;
        }
        
        float val_6 = val_6;
        val_6 = val_6 + this._cameraOffset;
        this._referenceCamera.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_6, z = val_2.z};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SetCameraHeight()
    {
        this._cameraOffset = 100f;
    }

}
