using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideActionSharedContext
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapSceneLookupTable _mapSceneLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.TutorialRequester _serverTutorialRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.AnimatronicDataByIDRequester _serverAnimatronicRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Inbox.SendInboxAlertMessageRequester _serverInboxAlertMessageRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Creator _animatronicCreator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.Container _animatronicContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.UI.ITutorialScrim _scrim;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.KeyValueAccess _keyValueAccess;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Permissions.CameraPermissionGovernor _cameraPermissionGovernor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.Domain _gameUIDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Server.PushNotificationsInitializer _pushNotificationsInitializer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool overrideIsTapped;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer MasterEvents { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapSceneLookupTable MapSceneLookup { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.TutorialRequester ServerTutorialRequester { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicDataByIDRequester ServerAnimatronicRequester { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.SendInboxAlertMessageRequester ServerInboxAlertMessageRequester { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Creator AnimatronicCreator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Container AnimatronicContainer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.KeyValueAccess KeyValueAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Permissions.CameraPermissionGovernor CameraPermissionGovernor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PushNotificationsInitializer PushNotificationsInitializer { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer get_MasterEvents()
        {
            return (Master.EventExposer)this._masterEvents;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapSceneLookupTable get_MapSceneLookup()
        {
            return (MapSceneLookupTable)this._mapSceneLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.TutorialRequester get_ServerTutorialRequester()
        {
            return (Game.Server.TutorialRequester)this._serverTutorialRequester;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.AnimatronicDataByIDRequester get_ServerAnimatronicRequester()
        {
            return (Game.Server.AnimatronicDataByIDRequester)this._serverAnimatronicRequester;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.Inbox.SendInboxAlertMessageRequester get_ServerInboxAlertMessageRequester()
        {
            return (Game.Server.Inbox.SendInboxAlertMessageRequester)this._serverInboxAlertMessageRequester;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Creator get_AnimatronicCreator()
        {
            return (AnimatronicEntity.Creator)this._animatronicCreator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.Container get_AnimatronicContainer()
        {
            return (AnimatronicEntity.Container)this._animatronicContainer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.KeyValueAccess get_KeyValueAccess()
        {
            return (Game.MasterData.KeyValueAccess)this._keyValueAccess;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Permissions.CameraPermissionGovernor get_CameraPermissionGovernor()
        {
            return (Master.Permissions.CameraPermissionGovernor)this._cameraPermissionGovernor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Server.PushNotificationsInitializer get_PushNotificationsInitializer()
        {
            return (Systems.Server.PushNotificationsInitializer)this._pushNotificationsInitializer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetMapLookupAsync(MapSceneLookupTable mapSceneLookupTable)
        {
            this._mapSceneLookup = mapSceneLookupTable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetKeyValueDataAsync(ProtoData.KEY_VALUE_DATA kvd)
        {
            Game.MasterData.GetAccessToData val_1 = this._masterDataDomain.GetAccessToData;
            this._keyValueAccess = val_1.KeyValueAccess;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetAudioInterfaceAsync(Game.Audio.IAudioPlayer audioPlayer)
        {
            this._audioPlayer = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TryGetScrim(out Systems.Guide.UI.ITutorialScrim scrim)
        {
            if(this._scrim == null)
            {
                    Systems.Guide.UI.ITutorialScrim val_1 = GuideUtils.GetScrim();
                this._scrim = val_1;
            }
            
            scrim = val_1;
            return (bool)(this._scrim != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InvokeAudio(string audioEventName)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioPlayer.RaiseGameEventForModeByName(name:  audioEventName, emitter:  1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleBottomBarVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleBatteryVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleEmfVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleExtraBatteryVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleFlashlightVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleRemnantVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleShockerVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ToggleReturnToMapVisibility(bool shouldShow)
        {
            mem2[0] = shouldShow;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.MasterDomain masterDomain)
        {
            Game.MasterData.MasterDataDomain val_14;
            if(masterDomain != null)
            {
                    val_14 = this._masterDataDomain;
                this._masterEvents = masterDomain.eventExposer;
                this._masterDataDomain = masterDomain.MasterDataDomain;
                this._gameUIDomain = masterDomain.gameUIDomain;
            }
            else
            {
                    this._masterEvents = 456;
                val_14 = this._masterDataDomain;
                this._masterDataDomain = 62590012;
                this._gameUIDomain = 0.gameUIDomain;
            }
            
            masterDomain.SceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void Systems.Guide.GuideActionSharedContext::GetMapLookupAsync(MapSceneLookupTable mapSceneLookupTable)));
            mem[this._masterDataDomain].GetAccessToData.GetKeyValueDataAsync(returnKeyValueDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.KEY_VALUE_DATA>(object:  this, method:  System.Void Systems.Guide.GuideActionSharedContext::GetKeyValueDataAsync(ProtoData.KEY_VALUE_DATA kvd)));
            this._serverTutorialRequester = masterDomain.serverDomain.tutorialRequester;
            this._serverAnimatronicRequester = masterDomain.serverDomain.animatronicDataByIdRequester;
            this._serverInboxAlertMessageRequester = masterDomain.serverDomain.sendInboxAlertMessageRequester;
            this._animatronicCreator = masterDomain.AnimatronicEntityDomain.creator;
            this._animatronicContainer = masterDomain.AnimatronicEntityDomain.container;
            TheGame.Domain val_9 = masterDomain.theGameDomain;
            this._cameraPermissionGovernor = val_9.cameraPermissionGovernor;
            masterDomain.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Systems.Guide.GuideActionSharedContext::GetAudioInterfaceAsync(Game.Audio.IAudioPlayer audioPlayer)));
            Server.LoginDomain val_13 = masterDomain.theGameDomain.loginDomain;
            this._pushNotificationsInitializer = val_13.pushNotificationsInitializer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._audioPlayer = 0;
            this._pushNotificationsInitializer = 0;
            this._gameUIDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideActionSharedContext()
        {
        
        }
    
    }

}
