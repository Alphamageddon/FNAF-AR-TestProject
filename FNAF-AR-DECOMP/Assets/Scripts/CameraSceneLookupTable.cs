using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class CameraSceneLookupTable : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _displayParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera _foregroundCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Transform _stableCameraTransform;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ShockerFxController _shockerFxController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ModifiedGlitchShader _modifiedGlitchShader;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private HaywireFxController _haywireFxController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ThreatLevelFxController _threatLevelFxController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FlashlightFxController _flashlightFxController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private MaskController _maskController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.EssenceCollection.Visuals.EssenceVisualsParent _essenceVisualsParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private DefaultNamespace.ObjectDetectionManager_Config _objectDetectionManagerConfig;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _audioListenerParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _arSessionOriginObject;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject DisplayParent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera ForegroundCamera { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform StableCameraTransform { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShockerFxController ShockerFxController { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ModifiedGlitchShader ModifiedGlitchShader { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HaywireFxController HaywireFxController { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ThreatLevelFxController ThreatLevelFxController { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FlashlightFxController FlashlightFxController { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MaskController MaskController { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.EssenceCollection.Visuals.EssenceVisualsParent EssenceVisualsParent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DefaultNamespace.ObjectDetectionManager_Config ObjectDetectionManagerConfig { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject AudioListenerParent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject ArSessionOriginObject { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_DisplayParent()
    {
        return (UnityEngine.GameObject)this._displayParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera get_ForegroundCamera()
    {
        return (UnityEngine.Camera)this._foregroundCamera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Transform get_StableCameraTransform()
    {
        return (UnityEngine.Transform)this._stableCameraTransform;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ShockerFxController get_ShockerFxController()
    {
        return (ShockerFxController)this._shockerFxController;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ModifiedGlitchShader get_ModifiedGlitchShader()
    {
        return (ModifiedGlitchShader)this._modifiedGlitchShader;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public HaywireFxController get_HaywireFxController()
    {
        return (HaywireFxController)this._haywireFxController;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ThreatLevelFxController get_ThreatLevelFxController()
    {
        return (ThreatLevelFxController)this._threatLevelFxController;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FlashlightFxController get_FlashlightFxController()
    {
        return (FlashlightFxController)this._flashlightFxController;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MaskController get_MaskController()
    {
        return (MaskController)this._maskController;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.EssenceCollection.Visuals.EssenceVisualsParent get_EssenceVisualsParent()
    {
        return (Game.EssenceCollection.Visuals.EssenceVisualsParent)this._essenceVisualsParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DefaultNamespace.ObjectDetectionManager_Config get_ObjectDetectionManagerConfig()
    {
        return (DefaultNamespace.ObjectDetectionManager_Config)this._objectDetectionManagerConfig;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_AudioListenerParent()
    {
        return (UnityEngine.GameObject)this._audioListenerParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_ArSessionOriginObject()
    {
        return (UnityEngine.GameObject)this._arSessionOriginObject;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CameraSceneLookupTable()
    {
    
    }

}
