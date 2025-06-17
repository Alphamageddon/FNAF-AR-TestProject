using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FCGameOverlayCanvasController : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private FCPlayer player;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Text playerHeightLabel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Text playerTargetHeightLabel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Button playerBoostLeftButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Button playerBoostRightButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float playerHeightPrevious;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        this.ListenForKeyPresses();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LateUpdate()
    {
        this.UpdatePlayerHeightLabelIfNecessary(force:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        if(this.player == 0)
        {
                return;
        }
        
        this.player.remove_OnPlayerReachedHeight(value:  new System.Action<FCPlayer>(object:  this, method:  System.Void FCGameOverlayCanvasController::OnPlayerReachedHeight(FCPlayer _player)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ConfigureWithPlayer(FCPlayer _player)
    {
        this.player = _player;
        string val_1 = System.String.Format(format:  "TARGET : {0}m", arg0:  _player.targetHeight);
        this.player.add_OnPlayerReachedHeight(value:  new System.Action<FCPlayer>(object:  this, method:  System.Void FCGameOverlayCanvasController::OnPlayerReachedHeight(FCPlayer _player)));
        this.UpdatePlayerHeightLabelIfNecessary(force:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdatePlayerHeightLabelIfNecessary(bool force = False)
    {
        if(this.player == 0)
        {
                return;
        }
        
        if(force != true)
        {
                if((UnityEngine.Mathf.Approximately(a:  this.player.currentHeight, b:  this.playerHeightPrevious)) == true)
        {
                return;
        }
        
        }
        
        string val_3 = System.String.Format(format:  "•{0:0.0}m•", arg0:  this.player.currentHeight);
        this.playerHeightPrevious = this.player.currentHeight;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnBoostPressed(int boostId)
    {
        if(this.player == 0)
        {
                return;
        }
        
        this.player.SetBoosting(boosterId:  boostId, active:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnBoostReleased(int boostId)
    {
        if(this.player == 0)
        {
                return;
        }
        
        this.player.SetBoosting(boosterId:  boostId, active:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ListenForKeyPresses()
    {
        UnityEngine.GameObject val_1 = this.playerBoostLeftButton.gameObject;
        val_1.ProcessKeyCodeForTarget(keyCode:  97, target:  val_1);
        UnityEngine.GameObject val_2 = this.playerBoostRightButton.gameObject;
        val_2.ProcessKeyCodeForTarget(keyCode:  100, target:  val_2);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ProcessKeyCodeForTarget(UnityEngine.KeyCode keyCode, UnityEngine.GameObject target)
    {
        UnityEngine.EventSystems.BaseEventData val_12;
        var val_14;
        if((UnityEngine.Input.GetKeyDown(key:  keyCode)) != false)
        {
                UnityEngine.EventSystems.PointerEventData val_3 = null;
            val_12 = val_3;
            val_3 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.EventSystems.EventSystem.current);
            bool val_5 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IPointerEnterHandler>(target:  target, eventData:  val_3, functor:  UnityEngine.EventSystems.ExecuteEvents.pointerEnterHandler);
            ExecuteEvents.EventFunction<UnityEngine.EventSystems.IPointerDownHandler> val_6 = UnityEngine.EventSystems.ExecuteEvents.pointerDownHandler;
            val_14 = 1152921519058344352;
        }
        else
        {
                if((UnityEngine.Input.GetKeyUp(key:  keyCode)) == false)
        {
                return;
        }
        
            UnityEngine.EventSystems.PointerEventData val_9 = null;
            val_12 = val_9;
            val_9 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.EventSystems.EventSystem.current);
            val_14 = 1152921519058357664;
        }
        
        bool val_11 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IPointerUpHandler>(target:  target, eventData:  val_9, functor:  UnityEngine.EventSystems.ExecuteEvents.pointerUpHandler);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnPlayerReachedHeight(FCPlayer _player)
    {
        this.PerformTransitionWithIdentifier(identifier:  "PresentGameCompleteScreen");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnResetButtonPressed()
    {
        if(this.player == 0)
        {
                return;
        }
        
        this.player.ResetPosition();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FCGameOverlayCanvasController()
    {
    
    }

}
