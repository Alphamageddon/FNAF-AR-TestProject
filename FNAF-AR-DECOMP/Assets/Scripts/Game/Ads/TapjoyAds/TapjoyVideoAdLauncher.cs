using UnityEngine;

namespace Game.Ads.TapjoyAds
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TapjoyVideoAdLauncher : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string videoAdName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool canRepeat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject buttonParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Ads.AdsDomain _adsDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Ads.TapjoyAds.ITapjoyPlacement _adPlacement;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _useFinalRewardDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isShowing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasShown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string VideoErrorTitleKey = "ui_tapjoy_video_dialog_play_error_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string VideoErrorMessageKey = "ui_tapjoy_video_dialog_play_error_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string VideoErrorButtonKey = "ui_tapjoy_video_dialog_play_error_button";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string VideoErrorTitle = "Video Playback Error";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string VideoErrorMessage = "An error occurred while your video was playing. Please try again later.";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string VideoErrorButton = "OK";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoinsSoonTitleKey = "ui_tapjoy_video_dialog_reward_soon_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoinsSoonMessageKey = "ui_tapjoy_video_dialog_reward_soon_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoinsSoonButtonKey = "ui_tapjoy_video_dialog_reward_soon_button";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoinsSoonTitle = "Video Complete";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoinsSoonMessage = "Your Faz-Coins are on their way!";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string CoinsSoonButton = "OK";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            if(Master.MasterDomain.GetDomain() != null)
            {
                    this._masterEventExposer = val_1.eventExposer;
            }
            else
            {
                    this._masterEventExposer = 456;
            }
            
            this._adsDomain = val_1.AdsDomain;
            this._adPlacement = val_1.AdsDomain.GetTapjoyPlacement(placementName:  this.videoAdName);
            val_1.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)));
            val_1.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioPlayerReady(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConfigDataReady(ProtoData.CONFIG_DATA.Types.ENTRY data)
        {
            var val_8;
            var val_9;
            bool val_10;
            val_8 = this;
            if(data == null)
            {
                goto label_3;
            }
            
            ADS val_2 = data.Ads;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            TAPJOY val_3 = val_2.Tapjoy;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            bool val_5 = val_3.UseFinalRewardDialog;
            val_9 = 0;
            val_8 = (data == 0) ? 0 : (val_8);
            goto label_4;
            label_3:
            val_9 = 0;
            label_4:
            if(((-575448548) & 1) == 0)
            {
                goto label_5;
            }
            
            val_10 = val_9.GetValueOrDefault();
            if(this != null)
            {
                goto label_8;
            }
            
            goto label_7;
            label_5:
            val_10 = false;
            if(this != null)
            {
                goto label_8;
            }
            
            label_7:
            label_8:
            this._useFinalRewardDialog = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            IntPtr val_7;
            IntPtr val_9;
            IntPtr val_11;
            System.Action val_1 = null;
            val_7 = System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::ContentDismiss();
            val_1 = new System.Action(object:  this, method:  val_7);
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = 6;
            this._adPlacement.add_OnContentDismiss(value:  val_1);
            System.Action val_3 = null;
            val_9 = System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::VideoError();
            val_3 = new System.Action(object:  this, method:  val_9);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 8;
            this._adPlacement.add_OnVideoError(value:  val_3);
            System.Action val_5 = null;
            val_11 = System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::VideoComplete();
            val_5 = new System.Action(object:  this, method:  val_11);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = 10;
            this._adPlacement.add_OnVideoComplete(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            IntPtr val_7;
            IntPtr val_9;
            IntPtr val_11;
            System.Action val_1 = null;
            val_7 = System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::ContentDismiss();
            val_1 = new System.Action(object:  this, method:  val_7);
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = 7;
            this._adPlacement.remove_OnContentDismiss(value:  val_1);
            System.Action val_3 = null;
            val_9 = System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::VideoError();
            val_3 = new System.Action(object:  this, method:  val_9);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_9 = 9;
            this._adPlacement.remove_OnVideoError(value:  val_3);
            System.Action val_5 = null;
            val_11 = System.Void Game.Ads.TapjoyAds.TapjoyVideoAdLauncher::VideoComplete();
            val_5 = new System.Action(object:  this, method:  val_11);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = 11;
            this._adPlacement.remove_OnVideoComplete(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            Systems.Ads.TapjoyAds.ITapjoyPlacement val_6;
            var val_7;
            if(this.buttonParent == 0)
            {
                    return;
            }
            
            if(this.canRepeat == false)
            {
                goto label_4;
            }
            
            label_12:
            UnityEngine.GameObject val_2 = this.buttonParent.gameObject;
            val_6 = this._adPlacement;
            var val_3 = (val_6 == 0) ? 0 : (val_2);
            if(val_6 == null)
            {
                goto label_6;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_10;
            label_4:
            if(this._hasShown == true)
            {
                    return;
            }
            
            goto label_12;
            label_6:
            val_7 = val_2;
            if(val_7 != null)
            {
                goto label_15;
            }
            
            goto label_14;
            label_10:
            val_6 = val_6.IsPlacementReady();
            if(val_3 != 0)
            {
                goto label_15;
            }
            
            label_14:
            label_15:
            val_3.SetActive(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsContentShowing()
        {
            return (bool)this._isShowing;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void VideoButtonClicked()
        {
            var val_6;
            if(this._adPlacement == null)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            if(this._adPlacement.IsPlacementReady() == false)
            {
                    return;
            }
            
            val_6 = 0;
            if(this.buttonParent != 0)
            {
                    val_6 = 0;
                this.buttonParent.SetActive(value:  false);
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_6 = 3;
            this._audioPlayer.SetGlobalMute(shouldMute:  true);
            this._isShowing = true;
            this._hasShown = true;
            var val_8 = 0;
            val_8 = val_8 + 1;
            this._adPlacement.ShowContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ContentDismiss()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.SetGlobalMute(shouldMute:  false);
            this._isShowing = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VideoError()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this._audioPlayer.SetGlobalMute(shouldMute:  false);
            this._isShowing = false;
            this._masterEventExposer.GenericDialogRequest(genericDialogData:  this._audioPlayer.BuildVideoErrorDialog());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void VideoComplete()
        {
            if(this._useFinalRewardDialog == false)
            {
                    return;
            }
            
            this._masterEventExposer.GenericDialogRequest(genericDialogData:  this.BuildCoinsSoonDialog());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData BuildVideoErrorDialog()
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_9 = 0;
            val_9 = val_9 + 1;
            .title = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_tapjoy_video_dialog_play_error_title", originalString:  "Video Playback Error");
            var val_10 = 0;
            val_10 = val_10 + 1;
            .message = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_tapjoy_video_dialog_play_error_message", originalString:  "An error occurred while your video was playing. Please try again later.");
            var val_11 = 0;
            val_11 = val_11 + 1;
            .negativeButtonText = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_tapjoy_video_dialog_play_error_button", originalString:  "OK");
            return (GameUI.GenericDialogData)new GameUI.GenericDialogData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData BuildCoinsSoonDialog()
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_9 = 0;
            val_9 = val_9 + 1;
            .title = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_tapjoy_video_dialog_reward_soon_title", originalString:  "Video Complete");
            var val_10 = 0;
            val_10 = val_10 + 1;
            .message = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_tapjoy_video_dialog_reward_soon_message", originalString:  "Your Faz-Coins are on their way!");
            var val_11 = 0;
            val_11 = val_11 + 1;
            .negativeButtonText = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_tapjoy_video_dialog_reward_soon_button", originalString:  "OK");
            return (GameUI.GenericDialogData)new GameUI.GenericDialogData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TapjoyVideoAdLauncher()
        {
        
        }
    
    }

}
