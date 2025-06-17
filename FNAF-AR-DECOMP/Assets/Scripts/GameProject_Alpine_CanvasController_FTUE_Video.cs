using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameProject_Alpine_CanvasController_FTUE_Video : CanvasController
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Video.VideoPlayer _videoPlayer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _splashDisplayParent;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        this.Start();
        this._videoPlayer.enabled = true;
        this._videoPlayer.add_loopPointReached(value:  new VideoPlayer.EventHandler(object:  this, method:  System.Void GameProject_Alpine_CanvasController_FTUE_Video::PlayerOnLoopPointReached(UnityEngine.Video.VideoPlayer source)));
        UnityEngine.GameObject val_2 = UnityEngine.GameObject.Find(name:  "SplashDisplayParent");
        this._splashDisplayParent = val_2;
        val_2.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PlayerOnLoopPointReached(UnityEngine.Video.VideoPlayer source)
    {
        this.DismissCanvasController(animated:  true, completion:  0);
        this._splashDisplayParent.SetActive(value:  true);
        Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
        val_1.eventExposer.OnCompleteFTUEVideo();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameProject_Alpine_CanvasController_FTUE_Video()
    {
    
    }

}
