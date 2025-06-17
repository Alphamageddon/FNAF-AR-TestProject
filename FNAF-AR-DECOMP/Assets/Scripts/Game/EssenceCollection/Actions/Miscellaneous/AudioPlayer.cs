using UnityEngine;

namespace Game.EssenceCollection.Actions.Miscellaneous
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AudioPlayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.EventExposer <_masterEventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.Audio.GameAudioDomain <_gameAudioDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.AttackSequenceDomain <_attackSequenceDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly TheGame.GameDisplayChanger <_gameDisplay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedThreat <_collectedThreat>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator <_essenceAngleCalculator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum <_particleVacuum>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool audioCanPlay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool vacuumAudioIsOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool moteSpawnTriggeredThisFrame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool threatSpawnTriggeredThisFrame;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float debug_rtpcLogTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _spawnedEssenceNodes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _decloakedEssenceNodes;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.GameAudioDomain _gameAudioDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer _audioPlayer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _gameDisplay { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat _collectedThreat { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator _essenceAngleCalculator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum _particleVacuum { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer get__masterEventExposer()
        {
            return (Master.EventExposer)this.<_masterEventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.GameAudioDomain get__gameAudioDomain()
        {
            return (Game.Audio.GameAudioDomain)this.<_gameAudioDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Audio.IAudioPlayer get__audioPlayer()
        {
            return (Game.Audio.IAudioPlayer)this.<_audioPlayer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__audioPlayer(Game.Audio.IAudioPlayer value)
        {
            this.<_audioPlayer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain get__attackSequenceDomain()
        {
            return (Game.AttackSequence.AttackSequenceDomain)this.<_attackSequenceDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger get__gameDisplay()
        {
            return (TheGame.GameDisplayChanger)this.<_gameDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat get__collectedThreat()
        {
            return (Game.EssenceCollection.Data.Collected.CollectedThreat)this.<_collectedThreat>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator get__essenceAngleCalculator()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator)this.<_essenceAngleCalculator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum get__particleVacuum()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum)this.<_particleVacuum>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AudioPlayer(Master.EventExposer masterEventExposer, Game.Audio.GameAudioDomain gameAudioDomain, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain, TheGame.GameDisplayChanger gameDisplay, Game.EssenceCollection.Data.Collected.CollectedThreat collectedThreat, Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator essenceAngleCalculator, Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum particleVacuum)
        {
            this._spawnedEssenceNodes = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._decloakedEssenceNodes = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            val_3 = new System.Object();
            this.<_masterEventExposer>k__BackingField = masterEventExposer;
            this.<_gameAudioDomain>k__BackingField = val_3;
            gameAudioDomain._audioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer::GetAudioPlayer(Game.Audio.IAudioPlayer audioPlayer)));
            this.<_attackSequenceDomain>k__BackingField = attackSequenceDomain;
            this.<_gameDisplay>k__BackingField = gameDisplay;
            this.<_collectedThreat>k__BackingField = collectedThreat;
            this.<_essenceAngleCalculator>k__BackingField = essenceAngleCalculator;
            this.<_particleVacuum>k__BackingField = particleVacuum;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetAudioPlayer(Game.Audio.IAudioPlayer audioPlayer)
        {
            this.<_audioPlayer>k__BackingField = audioPlayer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEmitterAudioMode(Systems.Audio.Components.AkAudioEmitter emitter)
        {
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.<_audioPlayer>k__BackingField.RegisterEmitter(emitter:  emitter, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AudioCanPlayNow()
        {
            TheGame.GameDisplayChanger val_4;
            var val_5;
            val_4 = this;
            if((this.<_attackSequenceDomain>k__BackingField.IsInEncounter()) != false)
            {
                    val_5 = 0;
                return (bool)(val_4.GetDisplayType() == 1) ? 1 : 0;
            }
            
            val_4 = this.<_gameDisplay>k__BackingField;
            return (bool)(val_4.GetDisplayType() == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerEssenceNodeSpawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> val_7;
            Game.Audio.IAudioPlayer val_8;
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            val_7 = this._spawnedEssenceNodes;
            if((val_7.Contains(item:  essenceNode)) != false)
            {
                    return;
            }
            
            if(this.audioCanPlay != false)
            {
                    val_8 = this.<_audioPlayer>k__BackingField;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_8.RaiseGameEventForEmitter(name:  62, emitter:  essenceNode.EssenceVisual.AkAudioEmitter);
            }
            
            bool val_5 = this._spawnedEssenceNodes.Add(item:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerEssenceNodeDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> val_8;
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            val_8 = this._spawnedEssenceNodes;
            if((val_8.Contains(item:  essenceNode)) == false)
            {
                    return;
            }
            
            if(this.audioCanPlay != false)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                this.<_audioPlayer>k__BackingField.RaiseGameEventForEmitter(name:  65, emitter:  essenceNode.EssenceVisual.AkAudioEmitter);
            }
            
            bool val_5 = this._spawnedEssenceNodes.Remove(item:  essenceNode);
            val_8 = this._decloakedEssenceNodes;
            if((val_8.Contains(item:  essenceNode)) == false)
            {
                    return;
            }
            
            bool val_7 = this._decloakedEssenceNodes.Remove(item:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerEssenceNodeDecloaked(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> val_7;
            Game.Audio.IAudioPlayer val_8;
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            val_7 = this._decloakedEssenceNodes;
            if((val_7.Contains(item:  essenceNode)) != false)
            {
                    return;
            }
            
            if(this.audioCanPlay != false)
            {
                    val_8 = this.<_audioPlayer>k__BackingField;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_8.RaiseGameEventForEmitter(name:  63, emitter:  essenceNode.EssenceVisual.AkAudioEmitter);
            }
            
            bool val_5 = this._decloakedEssenceNodes.Add(item:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerEssenceNodeCloaked(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> val_7;
            Game.Audio.IAudioPlayer val_8;
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            val_7 = this._decloakedEssenceNodes;
            if((val_7.Contains(item:  essenceNode)) == false)
            {
                    return;
            }
            
            if(this.audioCanPlay != false)
            {
                    val_8 = this.<_audioPlayer>k__BackingField;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_8.RaiseGameEventForEmitter(name:  64, emitter:  essenceNode.EssenceVisual.AkAudioEmitter);
            }
            
            bool val_5 = this._decloakedEssenceNodes.Remove(item:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerMoteSpawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.moteSpawnTriggeredThisFrame == true)
            {
                    return;
            }
            
            if(this.audioCanPlay == false)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.<_audioPlayer>k__BackingField.RaiseGameEventForEmitterWithOverride(name:  68, overridePrefix:  essenceNode.EssenceTypesEntry.NodeType.Logical, emitter:  essenceNode.EssenceVisual.AkAudioEmitter);
            this.moteSpawnTriggeredThisFrame = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerMoteDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerThreatPillSpawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.threatSpawnTriggeredThisFrame == true)
            {
                    return;
            }
            
            if(this.audioCanPlay == false)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.<_audioPlayer>k__BackingField.RaiseGameEventForEmitter(name:  70, emitter:  essenceNode.EssenceVisual.AkAudioEmitter);
            this.threatSpawnTriggeredThisFrame = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerThreatPillDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerMoteAbsorbed()
        {
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.audioCanPlay == false)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.<_audioPlayer>k__BackingField.RaiseGameEventForMode(name:  69, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerThreatPillAbsorbed()
        {
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.audioCanPlay == false)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.<_audioPlayer>k__BackingField.RaiseGameEventForMode(name:  71, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateModeState()
        {
            bool val_1 = this.AudioCanPlayNow();
            if((val_1 == false) || (this.audioCanPlay == true))
            {
                goto label_2;
            }
            
            this.<_masterEventExposer>k__BackingField.OnRemnantCollectionAudioStarted();
            var val_6 = 0;
            val_6 = val_6 + 1;
            goto label_8;
            label_2:
            var val_2 = (this.audioCanPlay == false) ? 1 : 0;
            val_2 = val_1 | val_2;
            if(val_2 == true)
            {
                goto label_16;
            }
            
            this.<_masterEventExposer>k__BackingField.OnRemnantCollectionAudioEnded();
            var val_7 = 0;
            val_7 = val_7 + 1;
            goto label_15;
            label_8:
            this.<_audioPlayer>k__BackingField.RaiseGameEventForMode(name:  60, mode:  2);
            this.TurnOnSpawnedNodes();
            this.TurnOnDecloakedNodes();
            goto label_16;
            label_15:
            this.<_audioPlayer>k__BackingField.RaiseGameEventForMode(name:  61, mode:  2);
            this.TurnOffSpawnedNodes();
            this.TurnOffDecloakedNodes();
            label_16:
            this.audioCanPlay = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVacuumState()
        {
            var val_2 = ((this.<_particleVacuum>k__BackingField._vacuumIsOn) == true) ? 1 : 0;
            val_2 = this.AudioCanPlayNow() & val_2;
            if(val_2 == true)
            {
                    if(this.vacuumAudioIsOn == true)
            {
                    return;
            }
            
                var val_5 = 0;
                val_5 = val_5 + 1;
            }
            else
            {
                    if(this.vacuumAudioIsOn == false)
            {
                    return;
            }
            
                var val_6 = 0;
                val_6 = val_6 + 1;
                this.<_audioPlayer>k__BackingField.RaiseGameEventForMode(name:  67, mode:  2);
                this.vacuumAudioIsOn = false;
                return;
            }
            
            this.<_audioPlayer>k__BackingField.RaiseGameEventForMode(name:  66, mode:  2);
            this.vacuumAudioIsOn = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TurnOffSpawnedNodes()
        {
            HashSet.Enumerator<T> val_1 = this._spawnedEssenceNodes.GetEnumerator();
            label_6:
            if(((-721886440) & 1) == 0)
            {
                    return;
            }
            
            0.emailUIDataHandler.EssenceVisual.AkAudioEmitter.StopAllAudio();
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TurnOnSpawnedNodes()
        {
            var val_8 = this;
            HashSet.Enumerator<T> val_1 = this._spawnedEssenceNodes.GetEnumerator();
            label_10:
            if(((-721729384) & 1) == 0)
            {
                    return;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.<_audioPlayer>k__BackingField.RaiseGameEventForEmitter(name:  62, emitter:  0.emailUIDataHandler.EssenceVisual.AkAudioEmitter);
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TurnOffDecloakedNodes()
        {
            HashSet.Enumerator<T> val_1 = this._decloakedEssenceNodes.GetEnumerator();
            label_6:
            if(((-721572296) & 1) == 0)
            {
                    return;
            }
            
            0.emailUIDataHandler.EssenceVisual.AkAudioEmitter.StopAllAudio();
            goto label_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TurnOnDecloakedNodes()
        {
            var val_8 = this;
            HashSet.Enumerator<T> val_1 = this._decloakedEssenceNodes.GetEnumerator();
            label_10:
            if(((-721415240) & 1) == 0)
            {
                    return;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.<_audioPlayer>k__BackingField.RaiseGameEventForEmitter(name:  63, emitter:  0.emailUIDataHandler.EssenceVisual.AkAudioEmitter);
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateThreatLevel(bool doDebugLog)
        {
            float val_1 = this.<_collectedThreat>k__BackingField.Percent;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.<_audioPlayer>k__BackingField.SetParameterForMode(name:  1, value:  this.<_collectedThreat>k__BackingField.Percent, mode:  2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAngleIntensities(bool doDebugLog)
        {
            var val_3;
            var val_11 = this;
            HashSet.Enumerator<T> val_1 = this._spawnedEssenceNodes.GetEnumerator();
            label_11:
            if(((-721113376) & 1) == 0)
            {
                    return;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            float val_5 = this.<_essenceAngleCalculator>k__BackingField.GetAngleMagnitudeToEssence(essenceNode:  val_4);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_5 = 1f - val_5;
            this.<_audioPlayer>k__BackingField.SetParameterForEmitter(name:  2, value:  val_5, emitter:  val_4.EssenceVisual.AkAudioEmitter);
            goto label_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            float val_2;
            var val_3;
            this.moteSpawnTriggeredThisFrame = false;
            this.threatSpawnTriggeredThisFrame = false;
            if((this.<_audioPlayer>k__BackingField) == null)
            {
                    return;
            }
            
            val_2 = this.debug_rtpcLogTimer;
            if(val_2 > 0f)
            {
                    val_3 = 0;
            }
            else
            {
                    val_3 = 1;
                val_2 = 1f;
                this.debug_rtpcLogTimer = 1f;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_2 - val_1;
            this.debug_rtpcLogTimer = val_1;
            this.UpdateModeState();
            this.UpdateVacuumState();
            this.UpdateThreatLevel(doDebugLog:  true);
            this.UpdateAngleIntensities(doDebugLog:  true);
        }
    
    }

}
