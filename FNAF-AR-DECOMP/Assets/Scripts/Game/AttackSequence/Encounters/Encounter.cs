using UnityEngine;

namespace Game.AttackSequence.Encounters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Encounter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackSpawner _spawner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackDestroyer _destroyer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.CameraEquipment.Shocker.IShocker _shocker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.AttackAnimatronic _animatronic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _encounterDefeated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _awaitingUiTrigger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInRewardsSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.RewardDispatcher _rewardDispatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayData.DisplayType _currentMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _currentStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _bestStreak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _currentRemnant;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Encounters.EncounterAnalyticsCollector _encounterAnalyticsCollector;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EntityInEncounter { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_EntityInEncounter()
        {
            int val_2;
            if(this._animatronic != null)
            {
                    if(this._animatronic.EntityId != null)
            {
                    return (string)val_2;
            }
            
            }
            
            val_2 = System.String.alignConst;
            return (string)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsTutorialEncounter(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)
        {
            return (bool)((type - 1) < 2) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInProgress()
        {
            if(this._animatronic == null)
            {
                    return (bool)(this._isInRewardsSequence == true) ? 1 : 0;
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsPlayingOutro()
        {
            return (bool)this._awaitingUiTrigger;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsShockable()
        {
            if(this._animatronic == null)
            {
                    return (bool)(this._animatronic.EncounterType != 3) ? 1 : 0;
            }
            
            return (bool)(this._animatronic.EncounterType != 3) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShockerActivated(bool isDisruptionFullyActive)
        {
            var val_5;
            Game.AttackSequence.Encounters.EncounterAnalyticsCollector val_6;
            int val_7;
            val_5 = 19181;
            val_6 = this._encounterAnalyticsCollector;
            if(val_6 != null)
            {
                    val_7 = this._encounterAnalyticsCollector.numShocksFired;
            }
            else
            {
                    val_6 = 16;
                val_7 = 11993091;
                val_5 = 0;
            }
            
            mem[16] = 11993092;
            if(this._animatronic == null)
            {
                goto label_3;
            }
            
            if(this._shocker != null)
            {
                goto label_9;
            }
            
            label_10:
            label_9:
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_8;
            label_3:
            if(this._shocker != null)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            this._shocker.Activate(didHitAnimatronic:  this._animatronic.HitByShocker(), isDisruptionFullyActive:  isDisruptionFullyActive);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)
        {
            Game.AttackSequence.Encounters.EncounterAnalyticsCollector val_1;
            int val_2;
            if(isFlashlightOn == false)
            {
                    return;
            }
            
            val_1 = this._encounterAnalyticsCollector;
            if(val_1 != null)
            {
                    val_2 = this._encounterAnalyticsCollector.numFlashlightActivations;
            }
            else
            {
                    val_1 = 20;
                val_2 = 1;
            }
            
            mem[20] = 2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnChargeStarted(float angleFromCamera, float fov)
        {
            Game.AttackSequence.Encounters.EncounterAnalyticsCollector val_2;
            var val_3;
            if(angleFromCamera >= 0)
            {
                goto label_0;
            }
            
            val_2 = this._encounterAnalyticsCollector;
            if(val_2 == null)
            {
                goto label_1;
            }
            
            val_3 = 3;
            goto label_2;
            label_0:
            val_2 = this._encounterAnalyticsCollector;
            label_2:
            this._encounterAnalyticsCollector.lastChargerRelativeDirection = (angleFromCamera < 0) ? 2 : (0 + 1);
            return;
            label_1:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EncounterWon()
        {
            var val_1;
            var val_2;
            if(this._animatronic == null)
            {
                    if(this._isInRewardsSequence == false)
            {
                goto label_2;
            }
            
            }
            
            if(this._awaitingUiTrigger != true)
            {
                    if(this._isInRewardsSequence == false)
            {
                goto label_4;
            }
            
            }
            
            val_1 = null;
            val_1 = null;
            label_13:
            ConsoleLogger.LogError(className:  Game.AttackSequence.Encounters.Encounter.ClassName, functionName:  "EncounterWon", logString:  "Cannot mark encounter won. Encounter already ending");
            return;
            label_2:
            val_2 = null;
            val_2 = null;
            goto label_13;
            label_4:
            this._encounterDefeated = true;
            this._awaitingUiTrigger = true;
            this._masterEventExposer.OnAnimatronicDefeated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EncounterLost()
        {
            var val_1;
            var val_2;
            if(this._animatronic == null)
            {
                    if(this._isInRewardsSequence == false)
            {
                goto label_2;
            }
            
            }
            
            if(this._awaitingUiTrigger != true)
            {
                    if(this._isInRewardsSequence == false)
            {
                goto label_4;
            }
            
            }
            
            val_1 = null;
            val_1 = null;
            label_13:
            ConsoleLogger.LogError(className:  Game.AttackSequence.Encounters.Encounter.ClassName, functionName:  "EncounterLost", logString:  "Cannot mark encounter lost. Encounter already ending");
            return;
            label_2:
            val_2 = null;
            val_2 = null;
            goto label_13;
            label_4:
            this._encounterDefeated = true;
            this._awaitingUiTrigger = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReadyForUi()
        {
            var val_15;
            string val_16;
            string val_17;
            string val_18;
            var val_19;
            int val_20;
            int val_21;
            var val_22;
            if(this._animatronic == null)
            {
                    if(this._isInRewardsSequence == false)
            {
                goto label_2;
            }
            
            }
            
            if(this._awaitingUiTrigger == false)
            {
                goto label_3;
            }
            
            if(this._isInRewardsSequence == false)
            {
                goto label_4;
            }
            
            val_15 = null;
            val_15 = null;
            val_16 = Game.AttackSequence.Encounters.Encounter.ClassName;
            val_17 = "ReadyForUi";
            val_18 = "Cannot mark encounter ready for UI. UI already showing";
            goto label_14;
            label_3:
            val_19 = null;
            val_19 = null;
            val_16 = Game.AttackSequence.Encounters.Encounter.ClassName;
            val_17 = "ReadyForUi";
            val_18 = "Cannot mark encounter ready for UI. Not awaiting UI trigger";
            goto label_14;
            label_4:
            .EncounterType = this._animatronic.EncounterType;
            .EntityId = this._animatronic.EntityId;
            .CpuId = this._animatronic.CpuId;
            .PlushSuitId = this._animatronic.PlushSuitId;
            .AnimatronicAudioId = this._animatronic.CpuAudioId;
            .PlayerDidWin = this._encounterDefeated;
            .OldCurrentStreak = this._currentStreak;
            val_20 = this._bestStreak;
            .OldBestStreak = val_20;
            .CurrentRemnant = this._currentRemnant;
            if(this._encounterDefeated == false)
            {
                goto label_21;
            }
            
            val_21 = this._currentStreak + 1;
            .NewCurrentStreak = val_21;
            if(val_21 >= (Game.AttackSequence.Encounters.EncounterResult)[1152921525445847552].NewBestStreak)
            {
                    Systems.Analytics.AnalyticsCalls.FireEvent_MaxStreakIncreased(maxStreak:  val_21, totalRemnant:  this._currentRemnant);
                val_20 = (Game.AttackSequence.Encounters.EncounterResult)[1152921525445847552].OldBestStreak;
                val_21 = (Game.AttackSequence.Encounters.EncounterResult)[1152921525445847552].NewCurrentStreak;
            }
            
            .NewBestStreak = UnityEngine.Mathf.Max(a:  val_21, b:  val_20);
            goto label_27;
            label_2:
            val_22 = null;
            val_22 = null;
            val_16 = Game.AttackSequence.Encounters.Encounter.ClassName;
            val_17 = "ReadyForUi";
            val_18 = "Cannot mark encounter ready for UI. No encounter in progress";
            label_14:
            ConsoleLogger.LogError(className:  val_16, functionName:  val_17, logString:  val_18);
            return;
            label_21:
            .NewCurrentStreak = 0;
            .NewBestStreak = val_20;
            label_27:
            this._rewardDispatcher.RequestRewards(entityId:  this._animatronic.EntityId, cpuId:  this._animatronic.CpuId, plushSuitId:  this._animatronic.PlushSuitId, encounterDefeated:  (this._encounterDefeated == true) ? 1 : 0, encounterAnalyticsCollector:  this._encounterAnalyticsCollector);
            Systems.Analytics.AnalyticsCalls.FireEvents_AttackSequence_EncounterEnded(encounterStartTime:  this._animatronic.EncounterStartTime, encounterAnalyticsCollector:  this._encounterAnalyticsCollector);
            if(this._currentMode == 1)
            {
                    this._isInRewardsSequence = this._currentMode;
                this._masterEventExposer.add_RewardsFlowCompleted(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::RewardsFlowCompleted()));
                this._masterEventExposer.OnAttackSequenceReadyForUi(result:  new Game.AttackSequence.Encounters.EncounterResult());
                return;
            }
            
            this._animatronic.RequestDestruction();
            this.FinalizeEncounter();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimatronicSpawned(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)
        {
            var val_2;
            if(this._animatronic == null)
            {
                    if(this._isInRewardsSequence == false)
            {
                goto label_2;
            }
            
            }
            
            val_2 = null;
            val_2 = null;
            ConsoleLogger.LogError(className:  Game.AttackSequence.Encounters.Encounter.ClassName, functionName:  "AnimatronicSpawned", logString:  "Cannot start encounter. Encounter still in progress");
            return;
            label_2:
            this._animatronic = animatronic;
            this._encounterAnalyticsCollector.numShocksFired = 0;
            this._encounterAnalyticsCollector.numFlashlightActivations = 0;
            Systems.Analytics.AnalyticsCalls.FireEvent_AttackSequence_BeginEncounter();
            this._masterEventExposer.OnAttackEncounterStarted(type:  animatronic.EncounterType);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AnimatronicAboutToBeDestroyed(Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload animatronicDestroyedPayload)
        {
            if(this._animatronic == null)
            {
                goto label_0;
            }
            
            if(animatronicDestroyedPayload != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            if((System.String.op_Equality(a:  this._animatronic.EntityId, b:  animatronicDestroyedPayload.EntityId)) == false)
            {
                    return;
            }
            
            this._animatronic = 0;
            return;
            label_0:
            if(animatronicDestroyedPayload != null)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GameDisplayChanged(TheGame.GameDisplayData args)
        {
            this._currentMode = args.currentDisplay;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StreakDataUpdated(TheGame.Data.StreakData data)
        {
            if(data != null)
            {
                    this._currentStreak = data.currentStreak;
            }
            else
            {
                    this._currentStreak = 11993091;
            }
            
            this._bestStreak = data.bestStreak;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> currencies)
        {
            this._currentRemnant = currencies.Item["ESSENCE"];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RecordRewardsAnalytics(Game.TheGame.Data.RewardDataV3 rewardData)
        {
            var val_6;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_15 = 0;
            goto label_1;
            label_8:
            Game.TheGame.Data.RewardItem val_1 = rewardData.cpuRewardList.Item[0];
            Systems.Analytics.AnalyticsCalls.FireEvent_Reward_CPU(cpuId:  val_1.item);
            val_15 = 1;
            label_1:
            if(val_15 < rewardData.cpuRewardList.Count)
            {
                goto label_8;
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = rewardData.animatronicRewardTable.Keys.GetEnumerator();
            val_16 = 0;
            label_28:
            if(((-634931264) & 1) == 0)
            {
                goto label_11;
            }
            
            GameUI.EmailUIDataHandler val_7 = val_6.emailUIDataHandler;
            List.Enumerator<T> val_9 = rewardData.animatronicRewardTable.Item[val_7].GetEnumerator();
            label_20:
            if(((-634931296) & 1) == 0)
            {
                goto label_15;
            }
            
            GameUI.EmailUIDataHandler val_10 = val_6.emailUIDataHandler;
            if((System.String.op_Equality(a:  val_10._masterDomain, b:  "PlushSuit")) == false)
            {
                goto label_20;
            }
            
            Systems.Analytics.AnalyticsCalls.FireEvent_Reward_PlushSuit(plushSuitId:  val_7);
            goto label_20;
            label_15:
            val_17 = val_16;
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525446752160});
            if((((146 == 0) ? 146 : 146) == 146) || ( == 0))
            {
                goto label_28;
            }
            
            goto label_28;
            label_11:
            val_18 = 171;
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525446752192});
            if( == 0)
            {
                    return;
            }
            
            if(146 == 0)
            {
                    return;
            }
            
            if(146 == 171)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RewardsFlowCompleted()
        {
            this._masterEventExposer.remove_RewardsFlowCompleted(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::RewardsFlowCompleted()));
            this.FinalizeEncounter();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FinalizeEncounter()
        {
            if(this._animatronic != null)
            {
                    Game.TheGame.Data.RewardDataV3 val_1 = this._animatronic.RewardData;
                val_1.RecordRewardsAnalytics(rewardData:  val_1);
            }
            
            this._animatronic = 0;
            this._awaitingUiTrigger = false;
            this._isInRewardsSequence = false;
            this._masterEventExposer.OnAttackEncounterEnded();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Encounter(Master.EventExposer masterEventExposer)
        {
            this._masterEventExposer = masterEventExposer;
            this._encounterAnalyticsCollector = new Game.AttackSequence.Encounters.EncounterAnalyticsCollector();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.AttackSequence.Animatronic.AttackSpawner spawner, Game.AttackSequence.Animatronic.AttackDestroyer destroyer, Game.AttackSequence.RewardDispatcher rewardDispatcher, Game.CameraEquipment.Shocker.IShocker shocker)
        {
            this._spawner = spawner;
            this._destroyer = destroyer;
            this._shocker = shocker;
            this._rewardDispatcher = rewardDispatcher;
            spawner.add_OnAnimatronicSpawned(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::AnimatronicSpawned(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)));
            this._destroyer.add_OnAnimatronicAboutToBeDestroyed(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::AnimatronicAboutToBeDestroyed(Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload animatronicDestroyedPayload)));
            this._masterEventExposer.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._masterEventExposer.add_StreakDataUpdated(value:  new System.Action<TheGame.Data.StreakData>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::StreakDataUpdated(TheGame.Data.StreakData data)));
            this._masterEventExposer.add_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::PlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> currencies)));
            this._masterEventExposer.add_RewardsFlowCompleted(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::RewardsFlowCompleted()));
            this._masterEventExposer.add_FlashlightStateChanged(value:  new FlashlightState.StateChanged(object:  this, method:  public System.Void Game.AttackSequence.Encounters.Encounter::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_FlashlightStateChanged(value:  new FlashlightState.StateChanged(object:  this, method:  public System.Void Game.AttackSequence.Encounters.Encounter::FlashlightStateChanged(bool isFlashlightOn, bool shouldPlayAudio)));
            this._masterEventExposer.remove_RewardsFlowCompleted(value:  new System.Action(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::RewardsFlowCompleted()));
            this._masterEventExposer.remove_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::PlayerCurrencyRefreshed(System.Collections.Generic.Dictionary<string, int> currencies)));
            this._masterEventExposer.remove_StreakDataUpdated(value:  new System.Action<TheGame.Data.StreakData>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::StreakDataUpdated(TheGame.Data.StreakData data)));
            this._masterEventExposer.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::GameDisplayChanged(TheGame.GameDisplayData args)));
            this._destroyer.remove_OnAnimatronicAboutToBeDestroyed(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::AnimatronicAboutToBeDestroyed(Game.AttackSequence.Animatronic.AttackAnimatronicDestroyedPayload animatronicDestroyedPayload)));
            this._spawner.remove_OnAnimatronicSpawned(value:  new System.Action<Game.AttackSequence.Animatronic.AttackAnimatronic>(object:  this, method:  System.Void Game.AttackSequence.Encounters.Encounter::AnimatronicSpawned(Game.AttackSequence.Animatronic.AttackAnimatronic animatronic)));
            this._rewardDispatcher = 0;
            this._spawner = 0;
            this._destroyer = 0;
            if(this._animatronic != null)
            {
                    this._animatronic.RequestDestruction();
            }
            
            this._animatronic = 0;
            this._masterEventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Encounter()
        {
            Game.AttackSequence.Encounters.Encounter.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
