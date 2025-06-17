using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class LoadingScreenManager : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool FTUEVideoIsPlaying;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool FTUEVideoWasPlaying;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string MAIN_CAMERA = "Main Camera";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string SCRIM_CANVAS = "ScrimCanvasSplash";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const string LOADING_BACKGROUND = "LoadingBackgroundScrim";
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float ALPHA_MULTIPLE = 0.7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const float MUSIC_MULTIPLE = 0.7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject frontCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject backCamera;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AudioClip MusicClip;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.AudioSource MusicSource;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Loading canvasController;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameUI.LoadingUIView loadingUIView;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject mainCameraObj;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject scrimObj;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.UI.Image loadingBackgroundImage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float alpha;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool wrappedUp;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void FetchSceneObjects()
    {
        if(this.mainCameraObj == 0)
        {
                UnityEngine.GameObject val_2 = UnityEngine.GameObject.Find(name:  "Main Camera");
            this.mainCameraObj = val_2;
            if(val_2 != null)
        {
                val_2.SetActive(value:  false);
        }
        
        }
        
        if(this.scrimObj == 0)
        {
                UnityEngine.GameObject val_4 = UnityEngine.GameObject.Find(name:  "ScrimCanvasSplash");
            this.scrimObj = val_4;
            if(val_4 != null)
        {
                val_4.SetActive(value:  false);
        }
        
        }
        
        if(this.loadingBackgroundImage == 0)
        {
                UnityEngine.GameObject val_6 = UnityEngine.GameObject.Find(name:  "LoadingBackgroundScrim");
            this.loadingBackgroundImage = val_6.GetComponent<UnityEngine.UI.Image>();
        }
        
        if(this.canvasController == 0)
        {
                this.canvasController = UnityEngine.Object.FindObjectOfType<GameUI.CanvasFlow.GameProject_Alpine_CanvasController_Loading>();
        }
        
        if(this.loadingUIView != 0)
        {
                return;
        }
        
        this.loadingUIView = UnityEngine.Object.FindObjectOfType<GameUI.LoadingUIView>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateFadeOut()
    {
        float val_8 = this.MusicSource.volume;
        float val_8 = -0.7f;
        val_8 = UnityEngine.Time.deltaTime * val_8;
        val_8 = val_8 + val_8;
        this.MusicSource.volume = val_8;
        if(this.MusicSource.isPlaying != false)
        {
                if(this.MusicSource.volume <= 0f)
        {
                this.MusicSource.Stop();
        }
        
        }
        
        if((this.loadingBackgroundImage != 0) && (this.alpha < 0))
        {
                val_8 = UnityEngine.Time.deltaTime;
            float val_9 = 0.7f;
            val_9 = val_8 * val_9;
            val_9 = this.alpha + val_9;
            this.alpha = UnityEngine.Mathf.Clamp(value:  val_9, min:  0f, max:  1f);
            this.loadingBackgroundImage.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        if(this.wrappedUp == true)
        {
                return;
        }
        
        if(this.alpha < 1f)
        {
                return;
        }
        
        this.wrappedUp = true;
        if(this.canvasController != null)
        {
                this.canvasController.LoadingScreenEnd();
        }
        
        UnityEngine.RenderSettings.fog = true;
        if(this.mainCameraObj != null)
        {
                this.mainCameraObj.SetActive(value:  true);
        }
        
        if(this.scrimObj == null)
        {
                return;
        }
        
        this.scrimObj.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.MusicSource.clip = this.MusicClip;
        this.MusicSource.loop = true;
        this.MusicSource.Play();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        this.FetchSceneObjects();
        if(LoadingScreenManager.MUSIC_MULTIPLE == 0)
        {
            goto label_1;
        }
        
        if(LoadingScreenManager.FTUEVideoWasPlaying == true)
        {
            goto label_5;
        }
        
        this.MusicSource.Stop();
        goto label_5;
        label_1:
        if(LoadingScreenManager.FTUEVideoWasPlaying != false)
        {
                this.MusicSource.Play();
        }
        
        label_5:
        LoadingScreenManager.FTUEVideoWasPlaying = LoadingScreenManager.MUSIC_MULTIPLE;
        if(this.canvasController == 0)
        {
                return;
        }
        
        if(this.canvasController.LoadingComplete() != false)
        {
                this.UpdateFadeOut();
        }
        
        if(this.canvasController.GetDisplayPercent() > 0f)
        {
                return;
        }
        
        this.frontCamera.SetActive(value:  false);
        this.backCamera.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LoadingScreenManager()
    {
    
    }

}
