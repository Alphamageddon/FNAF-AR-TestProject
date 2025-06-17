using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MapSceneLookupTable : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _displayParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Map.AbstractMap _map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.MapMode.PlayerTarget _playerTarget;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera referenceCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _audioListenerParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private MapMode.MapInputController _mapInputController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _guideArrow;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject DisplayParent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Map.AbstractMap Map { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.MapMode.PlayerTarget PlayerTarget { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera ReferenceCamera { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject AudioListenerParent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MapMode.MapInputController MapInputController { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject GuideArrow { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_DisplayParent()
    {
        return (UnityEngine.GameObject)this._displayParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Map.AbstractMap get_Map()
    {
        return (Mapbox.Unity.Map.AbstractMap)this._map;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Game.MapMode.PlayerTarget get_PlayerTarget()
    {
        return (Game.MapMode.PlayerTarget)this._playerTarget;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Camera get_ReferenceCamera()
    {
        return (UnityEngine.Camera)this.referenceCamera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_AudioListenerParent()
    {
        return (UnityEngine.GameObject)this._audioListenerParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MapMode.MapInputController get_MapInputController()
    {
        return (MapMode.MapInputController)this._mapInputController;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_GuideArrow()
    {
        return (UnityEngine.GameObject)this._guideArrow;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MapSceneLookupTable()
    {
    
    }

}
