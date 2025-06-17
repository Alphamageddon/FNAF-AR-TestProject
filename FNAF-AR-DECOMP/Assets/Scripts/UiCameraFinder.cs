using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class UiCameraFinder : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _uiCameraGameObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera _uiCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Canvas _canvas;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindWithTag(tag:  "UiCamera");
        this._uiCameraGameObject = val_1;
        if(val_1 != 0)
        {
                this._uiCamera = this._uiCameraGameObject.GetComponent<UnityEngine.Camera>();
        }
        
        this._canvas = this.gameObject.GetComponent<UnityEngine.Canvas>();
        if(this._uiCamera == 0)
        {
                return;
        }
        
        if(this._canvas == 0)
        {
                return;
        }
        
        this._canvas.worldCamera = this._uiCamera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UiCameraFinder()
    {
    
    }

}
