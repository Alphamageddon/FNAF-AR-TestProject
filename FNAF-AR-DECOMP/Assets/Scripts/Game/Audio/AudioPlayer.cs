using UnityEngine;

namespace Game.Audio
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioPlayer : AsyncInterfaceAccess<Game.Audio.IAudioPlayer>, IAudioPlayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Audio.IAudioDomain _audioDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.AudioEventLookup _audioEventLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<Game.Audio.AudioMode, Game.Audio.AudioGroup> _audioGroups;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _cameraParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _mapParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _workshopParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _displayMode;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Wwise.ISoundBankLoader SoundBankLoader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.Audio.IAudioPlayer GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.Audio.Wwise.ISoundBankLoader get_SoundBankLoader()
        {
            if(this._audioDomain == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._audioDomain.SoundBankLoader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            if(this._audioDomain == null)
            {
                    return false;
            }
            
            return (bool)(this._audioEventLookup != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.Audio.IAudioPlayer get_GetPublicInterface()
        {
            return (Game.Audio.IAudioPlayer)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterEmitter(Systems.Audio.Components.AkAudioEmitter emitter, Game.Audio.AudioMode mode)
        {
            var val_4;
            if((this._audioGroups.TryGetValue(key:  mode, value: out  0)) == false)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 2;
            this._audioDomain.SetEmittersListener(emitter:  emitter);
            val_1.AddEmitter(emitter:  emitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeregisterEmitter(Systems.Audio.Components.AkAudioEmitter emitter, Game.Audio.AudioMode mode)
        {
            if((this._audioGroups.TryGetValue(key:  mode, value: out  0)) == false)
            {
                    return;
            }
            
            val_1.RemoveEmitter(emitter:  emitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetGlobalMute(bool shouldMute)
        {
            if(shouldMute == false)
            {
                goto label_12;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._audioGroups.Keys.GetEnumerator();
            label_7:
            if(((-668845768) & 1) == 0)
            {
                goto label_4;
            }
            
            this._audioGroups.Item[0.region].SetMuteState(isMuted:  true);
            goto label_7;
            label_4:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525412837688});
            return;
            label_12:
            this.SetAudioModeToMatchDisplayMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMute(Systems.Audio.Components.AkAudioEmitter emitter, bool shouldMute)
        {
            emitter.SetMute(shouldMute:  shouldMute);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetState(string group, string state)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._audioDomain.SetState(group:  group, state:  state);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventForEmitter(Game.Audio.AudioEventName name, Systems.Audio.Components.AkAudioEmitter emitter)
        {
            var val_6;
            Game.Audio.AudioEventLookup val_7;
            val_6 = emitter;
            val_7 = this._audioEventLookup;
            if((val_7.GetAudioEvent(name:  name)) == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = val_1.Names.GetEnumerator();
            val_7 = 1152921517654220160;
            label_6:
            if(((-668423704) & 1) == 0)
            {
                goto label_4;
            }
            
            val_6.SendEvent(eventName:  0.emailUIDataHandler);
            goto label_6;
            label_4:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525413259752});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventForEmitterWithOverride(Game.Audio.AudioEventName name, string overridePrefix, Systems.Audio.Components.AkAudioEmitter emitter)
        {
            Systems.Audio.Components.AkAudioEmitter val_6;
            var val_7;
            val_6 = emitter;
            val_7 = this;
            if((this._audioEventLookup.GetAudioEvent(name:  name, animatronicId:  overridePrefix)) == null)
            {
                goto label_2;
            }
            
            List.Enumerator<T> val_2 = val_1.Names.GetEnumerator();
            val_7 = 1152921517654220160;
            label_6:
            if(((-668250280) & 1) == 0)
            {
                goto label_4;
            }
            
            val_6.SendEvent(eventName:  0.emailUIDataHandler);
            goto label_6;
            label_2:
            this.RaiseGameEventForEmitter(name:  name, emitter:  val_6);
            return;
            label_4:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525413433176});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventForMode(Game.Audio.AudioEventName name, Game.Audio.AudioMode mode)
        {
            Game.Audio.AudioMode val_4 = mode;
            Game.Audio.AudioGroup val_1 = 0;
            if((this._audioGroups.TryGetValue(key:  val_4 = mode, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_4 = val_1;
            this.RaiseGameEventForEmitter(name:  name, emitter:  val_4.DefaultEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventForModeByName(string name, Game.Audio.AudioMode mode)
        {
            Game.Audio.AudioMode val_9;
            string val_10;
            val_9 = mode;
            val_10 = name;
            if((this._audioGroups.TryGetValue(key:  val_9, value: out  0)) == false)
            {
                    return;
            }
            
            if((this._audioEventLookup.GetAudioEventByName(eventName:  val_10)) == null)
            {
                    return;
            }
            
            val_10 = val_3.Names;
            List.Enumerator<T> val_4 = val_10.GetEnumerator();
            val_9 = 1152921517654220160;
            label_9:
            if(( & 1) == 0)
            {
                goto label_6;
            }
            
            val_1.DefaultEmitter.SendEvent(eventName:  0.emailUIDataHandler);
            goto label_9;
            label_6:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventForModeWithOverride(Game.Audio.AudioEventName name, string overridePrefix, Game.Audio.AudioMode mode)
        {
            if((this._audioGroups.TryGetValue(key:  mode, value: out  0)) == false)
            {
                    return;
            }
            
            this.RaiseGameEventForEmitterWithOverride(name:  name, overridePrefix:  overridePrefix, emitter:  val_1.DefaultEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RaiseGameEventForModeWithOverrideByName(string name, string overridePrefix, Game.Audio.AudioMode mode)
        {
            Game.Audio.AudioMode val_9;
            var val_10;
            val_9 = mode;
            val_10 = this;
            if((this._audioGroups.TryGetValue(key:  val_9, value: out  0)) == false)
            {
                    return;
            }
            
            if((this._audioEventLookup.GetAudioEventByName(eventName:  name, animatronicId:  overridePrefix)) == null)
            {
                goto label_4;
            }
            
            val_9 = val_3.Names;
            List.Enumerator<T> val_4 = val_9.GetEnumerator();
            val_10 = 1152921517654220160;
            label_9:
            if(((-667581096) & 1) == 0)
            {
                goto label_6;
            }
            
            val_1.DefaultEmitter.SendEvent(eventName:  0.emailUIDataHandler);
            goto label_9;
            label_4:
            this.RaiseGameEventForModeByName(name:  name, mode:  val_9);
            return;
            label_6:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525414102360});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetParameterForEmitter(Game.Audio.AudioParameterName name, float value, Systems.Audio.Components.AkAudioEmitter emitter)
        {
            if((this._audioEventLookup.GetAudioParameter(name:  name)) == null)
            {
                    return;
            }
            
            emitter.SetRtpcValue(rtpcName:  val_1.Name, rtpcValue:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetParameterForMode(Game.Audio.AudioParameterName name, float value, Game.Audio.AudioMode mode)
        {
            Game.Audio.AudioMode val_4 = mode;
            Game.Audio.AudioGroup val_1 = 0;
            if((this._audioGroups.TryGetValue(key:  val_4 = mode, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_4 = val_1;
            this.SetParameterForEmitter(name:  name, value:  value, emitter:  val_4.DefaultEmitter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this._displayMode = args.currentDisplay;
            this.SetAudioModeToMatchDisplayMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetAudioModeToMatchDisplayMode()
        {
            var val_15;
            UnityEngine.Transform val_16;
            var val_17;
            var val_18;
            val_15 = this;
            if(this._audioDomain == null)
            {
                    return;
            }
            
            val_16 = 1152921504851574784;
            if(this._cameraParent == 0)
            {
                    return;
            }
            
            if(this._mapParent == 0)
            {
                    return;
            }
            
            val_17 = 0;
            if(this._workshopParent == 0)
            {
                    return;
            }
            
            val_18 = 0;
            if(this._displayMode > 7)
            {
                goto label_28;
            }
            
            var val_15 = 52947176 + (this._displayMode) << 2;
            val_15 = val_15 + 52947176;
            goto (52947176 + (this._displayMode) << 2 + 52947176);
            label_28:
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_8 = this._audioGroups.Keys.GetEnumerator();
            label_38:
            if(((-666928264) & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_9 = 0.region;
            if(val_9 != 1)
            {
                goto label_32;
            }
            
            this._audioGroups.Item[1].SetMuteState(isMuted:  false);
            goto label_38;
            label_32:
            this._audioGroups.Item[val_9].SetMuteState(isMuted:  (val_9 != ) ? 1 : 0);
            goto label_38;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioPlayer(Master.EventExposer masterEventExposer, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.MasterData.MasterDataDomain masterDataDomain)
        {
            this._audioGroups = new System.Collections.Generic.Dictionary<Game.Audio.AudioMode, Game.Audio.AudioGroup>();
            this._displayMode = 6;
            this._masterEventExposer = masterEventExposer;
            masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.Audio.AudioPlayer::GameDisplayChanged(TheGame.GameDisplayData args)));
            if(sceneLookupTableAccess != 0)
            {
                    sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  public System.Void Game.Audio.AudioPlayer::CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)));
                sceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void Game.Audio.AudioPlayer::MapSceneLookupTableReady(MapSceneLookupTable mapSceneLookupTable)));
                sceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(returnWorkshopSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnWorkshopSceneLookupTable(object:  this, method:  System.Void Game.Audio.AudioPlayer::WorkshopSceneLookupTableReady(WorkshopSceneLookupTable workshopSceneLookupTable)));
            }
            
            masterDataDomain.GetAccessToData.GetAudioDataAsync(returnAudioDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.AUDIO_DATA>(object:  this, method:  System.Void Game.Audio.AudioPlayer::AudioDataReady(ProtoData.AUDIO_DATA audioData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CameraSceneLookupTableReady(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this._cameraParent = cameraSceneLookupTable.AudioListenerParent.transform;
            this.SetAudioModeToMatchDisplayMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MapSceneLookupTableReady(MapSceneLookupTable mapSceneLookupTable)
        {
            this._mapParent = mapSceneLookupTable.AudioListenerParent.transform;
            this.SetAudioModeToMatchDisplayMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void WorkshopSceneLookupTableReady(WorkshopSceneLookupTable workshopSceneLookupTable)
        {
            this._workshopParent = workshopSceneLookupTable.AudioListenerParent.transform;
            this.SetAudioModeToMatchDisplayMode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AudioDataReady(ProtoData.AUDIO_DATA audioData)
        {
            this._audioEventLookup = new Game.Audio.AudioEventLookup(audioData:  audioData);
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.Audio.IAudioDomain audioDomain)
        {
            this._audioDomain = audioDomain;
            this.CreateGroups();
            this.SetAudioModeToMatchDisplayMode();
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateGroups()
        {
            this._audioGroups.Add(key:  1, value:  this.MakeNewGroup(name:  "Global", startsMuted:  false));
            this._audioGroups.Add(key:  2, value:  this.MakeNewGroup(name:  "Camera", startsMuted:  true));
            this._audioGroups.Add(key:  3, value:  this.MakeNewGroup(name:  "Map", startsMuted:  true));
            this._audioGroups.Add(key:  4, value:  this.MakeNewGroup(name:  "Workshop", startsMuted:  true));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.AudioGroup MakeNewGroup(string name, bool startsMuted)
        {
            var val_6;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = public Systems.Audio.Components.AkAudioEmitter Systems.Audio.IAudioDomain::MakeNewEmitter(string name);
            Systems.Audio.Components.AkAudioEmitter val_2 = this._audioDomain.MakeNewEmitter(name:  name);
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_6 = 2;
            this._audioDomain.SetEmittersListener(emitter:  val_2);
            Game.Audio.AudioGroup val_4 = new Game.Audio.AudioGroup(defaultEmitter:  val_2);
            val_4.SetMuteState(isMuted:  startsMuted);
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._audioDomain = 0;
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.Audio.AudioPlayer::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer = 0;
        }
    
    }

}
