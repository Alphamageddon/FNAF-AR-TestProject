using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class WorkshopSceneLookupTable : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _displayParent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameUI.WorkshopStageView _workshopStage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _audioListenerParent;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject DisplayParent { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.WorkshopStageView WorkshopStage { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject AudioListenerParent { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_DisplayParent()
    {
        return (UnityEngine.GameObject)this._displayParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.WorkshopStageView get_WorkshopStage()
    {
        return (GameUI.WorkshopStageView)this._workshopStage;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject get_AudioListenerParent()
    {
        return (UnityEngine.GameObject)this._audioListenerParent;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public WorkshopSceneLookupTable()
    {
    
    }

}
