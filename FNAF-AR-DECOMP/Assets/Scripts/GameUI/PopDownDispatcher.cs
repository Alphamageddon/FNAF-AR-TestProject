using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PopDownDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PopDownDispatcherData _popDownDispatcherHookups;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PopDownData _currentPopDownData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.IItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<TheGame.GameDisplayData.DisplayType, bool> IsDisplayType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PopDownDispatcher(Master.MasterDomain masterDomain, GameUI.PopDownDispatcherData popDownDispatcherData)
        {
            this._masterDomain = masterDomain;
            mem[1152921524896539240] = popDownDispatcherData.popDownUnidentifiedOverlay;
            mem[1152921524896539224] = popDownDispatcherData.popDownTextMessagesText;
            this._popDownDispatcherHookups = popDownDispatcherData.popDownPanel;
            this.IsDisplayType = new System.Func<DisplayType, System.Boolean>(object:  masterDomain.theGameDomain.gameDisplayChanger, method:  public System.Boolean TheGame.GameDisplayChanger::IsDisplayType(TheGame.GameDisplayData.DisplayType displayType));
            masterDomain.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void GameUI.PopDownDispatcher::GetAudioInterfaceAsync(Game.Audio.IAudioPlayer audioPlayer)));
            this.AddSubscriptions(masterDomain:  masterDomain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubscriptions(Master.MasterDomain masterDomain)
        {
            masterDomain.ItemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void GameUI.PopDownDispatcher::ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
            masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.PopDownDispatcher::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            masterDomain.eventExposer.add_GenericPopDownRequested(value:  new System.Action<GameUI.PopDownData>(object:  this, method:  System.Void GameUI.PopDownDispatcher::EventExposer_GenericPopdownRequested(GameUI.PopDownData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            this._itemDefinitionDomain = itemDefinitionDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_GenericPopdownRequested(GameUI.PopDownData data)
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            val_1.masterDomain = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator ShowMessageTimer(GameUI.PopDownData popDownData)
        {
            PopDownDispatcher.<ShowMessageTimer>d__12 val_1 = new PopDownDispatcher.<ShowMessageTimer>d__12();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .popDownData = popDownData;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetAudioInterfaceAsync(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePopDownVisibility()
        {
            var val_30;
            var val_31;
            if(((this._currentPopDownData != null) && (this._currentPopDownData.show != false)) && (this.IsCorrectDisplayType() != false))
            {
                    val_30 = 1;
            }
            else
            {
                    val_30 = 0;
            }
            
            this._popDownDispatcherHookups.SetActive(value:  false);
            if(this._currentPopDownData == null)
            {
                    return;
            }
            
            if(this._currentPopDownData.show == false)
            {
                    return;
            }
            
            bool val_2 = System.String.IsNullOrWhiteSpace(value:  this._currentPopDownData.title);
            UnityEngine.GameObject val_3 = X21.gameObject;
            if(val_2 ^ val_3.activeSelf != true)
            {
                    val_3.gameObject.SetActive(value:  val_2 ^ 1);
            }
            
            bool val_9 = System.String.IsNullOrWhiteSpace(value:  this._currentPopDownData.message);
            UnityEngine.GameObject val_10 = val_3.gameObject;
            if(val_9 ^ val_10.activeSelf != true)
            {
                    val_10.gameObject.SetActive(value:  val_9 ^ 1);
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  this._currentPopDownData.senderId)) != false)
            {
                    if(this.HasValidIcon() == false)
            {
                goto label_21;
            }
            
            }
            
            bool val_29 = this._currentPopDownData.showUnidentifiedOverlay;
            val_29 = val_29 ^ 1;
            val_31 = val_29 & 255;
            goto label_23;
            label_21:
            val_31 = 0;
            label_23:
            UnityEngine.GameObject val_18 = this._currentPopDownData.gameObject;
            if(val_31 != val_18.activeSelf)
            {
                    UnityEngine.GameObject val_21 = val_18.gameObject;
                val_21.SetActive(value:  (val_31 != 0) ? 1 : 0);
            }
            
            if((((this._currentPopDownData.showUnidentifiedOverlay == true) ? 1 : 0) ^ val_21.gameObject.activeSelf) == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  (this._currentPopDownData.showUnidentifiedOverlay == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasValidIcon()
        {
            string val_6;
            string val_7;
            val_6 = this;
            if((System.String.IsNullOrWhiteSpace(value:  this._currentPopDownData.iconGroupId)) != true)
            {
                    if((System.String.IsNullOrWhiteSpace(value:  this._currentPopDownData.iconId)) == false)
            {
                goto label_4;
            }
            
            }
            
            val_7 = 0;
            return (bool)System.Enum.TryParse<Game.AssetManagement.Icons.IconGroup>(value:  val_7 = val_6, result: out  0);
            label_4:
            val_6 = this._currentPopDownData.iconGroupId;
            return (bool)System.Enum.TryParse<Game.AssetManagement.Icons.IconGroup>(value:  val_7, result: out  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsCorrectDisplayType()
        {
            var val_11;
            var val_15;
            val_11 = this;
            ALERT_DATA.Types.ENTRY.Types.UIMESSAGE.Types.UIDISPLAYRESTRICTION val_10 = this._currentPopDownData.uIDISPLAYRESTRICTION;
            val_10 = val_10 - 2;
            if(val_10 <= 5)
            {
                    var val_11 = 52945420 + ((this._currentPopDownData.uIDISPLAYRESTRICTION - 2)) << 2;
                val_11 = val_11 + 52945420;
            }
            else
            {
                    val_15 = 1;
                 = ;
                return (bool);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePopDownMessageContent()
        {
            if(X20.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this._currentPopDownData == null)
            {
                goto label_3;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.text = this._currentPopDownData.message;
            return;
            label_3:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePopDownTitleContent()
        {
            if(X20.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this._currentPopDownData == null)
            {
                goto label_3;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.text = this._currentPopDownData.title;
            return;
            label_3:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePopDownImage()
        {
            GameUI.PopDownData val_6;
            if(gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this._currentPopDownData == null)
            {
                    return;
            }
            
            if(this._currentPopDownData.show == false)
            {
                    return;
            }
            
            if(this._currentPopDownData.senderId == null)
            {
                goto label_6;
            }
            
            this._currentPopDownData.showUnidentifiedOverlay = (this._masterDomain.devicesDomain.AllPlayerDevices.active.Transponder.Count < 1) ? 1 : 0;
            if(this._currentPopDownData.showUnidentifiedOverlay == true)
            {
                goto label_15;
            }
            
            this.SetIconForPopDownBySender(senderId:  this._currentPopDownData.senderId, popDownIcon:  null);
            return;
            label_6:
            if(this.HasValidIcon() == false)
            {
                goto label_15;
            }
            
            val_6 = this._currentPopDownData;
            if(this._currentPopDownData != null)
            {
                goto label_16;
            }
            
            val_6 = this._currentPopDownData;
            if(val_6 == null)
            {
                goto label_17;
            }
            
            label_16:
            this.SetIconForPopDown(iconGroupId:  this._currentPopDownData.iconGroupId, iconId:  this._currentPopDownData.iconId, popDownIcon:  null);
            return;
            label_15:
            this.sprite = 0;
            return;
            label_17:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForPopDownUnknown(UnityEngine.UI.Image popDownImage)
        {
            popDownImage.sprite = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForPopDownBySender(string senderId, UnityEngine.UI.Image popDownIcon)
        {
            var val_13;
            string val_15;
            Game.AssetManagement.Icons.IIconLookup val_16;
            val_13 = popDownIcon;
            if(this._itemDefinitionDomain == null)
            {
                goto label_7;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            if((this._itemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  senderId)) == null)
            {
                goto label_7;
            }
            
            val_15 = val_3.PortraitIconName;
            if(val_15 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_15 = System.String.alignConst;
            label_8:
            if((System.String.IsNullOrWhiteSpace(value:  val_15)) == false)
            {
                goto label_9;
            }
            
            val_16 = this._iconLookup;
            if(val_16 == null)
            {
                goto label_22;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_14;
            label_9:
            if(val_13.sprite != 0)
            {
                    if((System.String.op_Inequality(a:  val_13.sprite.name, b:  val_15)) == false)
            {
                    return;
            }
            
            }
            
            val_16 = this._iconLookup;
            if(val_16 == null)
            {
                goto label_22;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_26;
            label_14:
            val_16 = val_16.GetDefaultIcon();
            val_13 = (val_16 == 0) ? 0 : (val_13);
            label_22:
            if(val_13 != 0)
            {
                goto label_28;
            }
            
            label_29:
            label_28:
            val_13.sprite = val_16;
            return;
            label_26:
            UnityEngine.Sprite val_15 = val_16.GetIcon(group:  3, name:  val_15);
            if(((val_16 == 0) ? 0 : (val_13)) != 0)
            {
                goto label_28;
            }
            
            goto label_29;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIconForPopDown(string iconGroupId, string iconId, UnityEngine.UI.Image popDownIcon)
        {
            var val_10;
            string val_11;
            Game.AssetManagement.Icons.IIconLookup val_12;
            val_10 = popDownIcon;
            val_11 = iconId;
            val_12 = this;
            Game.AssetManagement.Icons.IconGroup val_6 = 0;
            if(val_10.sprite != 0)
            {
                    if((System.String.op_Inequality(a:  val_10.sprite.name, b:  val_11)) == false)
            {
                    return;
            }
            
            }
            
            if((System.Enum.TryParse<Game.AssetManagement.Icons.IconGroup>(value:  iconGroupId, result: out  val_6)) == false)
            {
                    return;
            }
            
            val_12 = this._iconLookup;
            if(val_12 == null)
            {
                goto label_11;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_15;
            label_11:
            val_11 = 0;
            if(val_10 != null)
            {
                goto label_18;
            }
            
            goto label_17;
            label_15:
            val_11 = val_12.GetIcon(group:  val_6, name:  val_11);
            val_10 = (val_12 == 0) ? 0 : (val_10);
            if(val_10 != 0)
            {
                goto label_18;
            }
            
            label_17:
            label_18:
            val_10.sprite = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePopDownDisplay()
        {
            this.UpdatePopDownTitleContent();
            this.UpdatePopDownMessageContent();
            this.UpdatePopDownImage();
            this.UpdatePopDownVisibility();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DispatchMessage(GameUI.PopDownData popDownData)
        {
            UnityEngine.Coroutine val_2 = this._masterDomain.StartCoroutine(routine:  this.ShowMessageTimer(popDownData:  popDownData));
            if(popDownData.audioId == null)
            {
                    return;
            }
            
            this.InvokeAudio(audioID:  popDownData.audioId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InvokeAudio(string audioID)
        {
            if(this._audioPlayer == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForModeByName(name:  audioID, emitter:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConsumeAlertData()
        {
            var val_5 = this;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if(X8 == 0)
            {
                    return;
            }
            
            GameUI.Domain val_2 = this._masterDomain.gameUIDomain;
            if(val_2.masterDomain == null)
            {
                    return;
            }
            
            GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
            this.DispatchMessage(popDownData:  val_3.masterDomain);
            GameUI.Domain val_4 = this._masterDomain.gameUIDomain;
            val_4.masterDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClosePopDown()
        {
            if(this._currentPopDownData == null)
            {
                    return;
            }
            
            this._currentPopDownData.show = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.ConsumeAlertData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LateUpdate()
        {
            this.UpdatePopDownDisplay();
        }
    
    }

}
