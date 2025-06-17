using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class LightningFxController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool spawn;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject[] _lightnings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DigitalRuby.ThunderAndLightning.LightningMeshSurfaceScript[] _lightningScripts;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera _fxCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isCameraFound;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _lastSpawnStatus;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._lightningScripts = this.GetComponentsInChildren<DigitalRuby.ThunderAndLightning.LightningMeshSurfaceScript>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_7;
        var val_8;
        if(this._lightningScripts == null)
        {
                return;
        }
        
        if(((this.spawn == true) ? 1 : 0) == ((this._lastSpawnStatus == true) ? 1 : 0))
        {
                return;
        }
        
        this._lastSpawnStatus = this.spawn;
        if((this.spawn == false) || (this._isCameraFound == true))
        {
            goto label_7;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  "Camera_Foreground_PostFX");
        if(val_3 == 0)
        {
            goto label_7;
        }
        
        val_7 = 0;
        this._fxCamera = val_3.GetComponent<UnityEngine.Camera>();
        this._isCameraFound = true;
        goto label_9;
        label_13:
        DigitalRuby.ThunderAndLightning.LightningMeshSurfaceScript val_7 = this._lightningScripts[0];
        val_7 = 1;
        mem2[0] = this._fxCamera;
        label_9:
        if(val_7 < this._lightningScripts.Length)
        {
            goto label_13;
        }
        
        label_7:
        val_8 = 0;
        goto label_14;
        label_18:
        DigitalRuby.ThunderAndLightning.LightningMeshSurfaceScript val_8 = this._lightningScripts[0];
        val_8 = 1;
        mem2[0] = this.spawn ^ 1;
        label_14:
        if(val_8 < this._lightningScripts.Length)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LightningFxController()
    {
    
    }

}
