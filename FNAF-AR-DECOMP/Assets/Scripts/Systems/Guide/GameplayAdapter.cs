using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameplayAdapter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideEventsSharedContext _guideEventsSharedContext;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.GuideNodeDriver _driver;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _secondsSinceLastClockTick;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Systems.Guide.GuideEventsSharedContext guideEventsSharedContext, Systems.Guide.GuideNodeDriver nodeDriver)
        {
            this._guideEventsSharedContext = guideEventsSharedContext;
            this._driver = nodeDriver;
            guideEventsSharedContext._masterEvents.add_UICanvasDidAppear(value:  new System.Action<DisplayType>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnUIOpened(TheGame.GameDisplayData.DisplayType type)));
            this._guideEventsSharedContext._masterEvents.add_UICanvasClosed(value:  new System.Action<DisplayType>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnUIClosed(TheGame.GameDisplayData.DisplayType type)));
            this._guideEventsSharedContext._masterEvents.add_GuidePopupRequested(value:  new System.Action<System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnGuidePopupOpened(string popupName)));
            this._guideEventsSharedContext._masterEvents.add_GuidePopupClosing(value:  new System.Action<System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnGuidePopupClosing(string popupName)));
            this._guideEventsSharedContext._masterEvents.add_AnimatronicDefeated(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicDefeated()));
            this._guideEventsSharedContext._masterEvents.add_AnimatronicAttackWindowClosed(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicAttackWindowClosed()));
            this._guideEventsSharedContext._masterEvents.add_AnimatronicShocked(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicShocked()));
            this._guideEventsSharedContext._masterEvents.add_StartupTaskCompleted(value:  new System.Action<System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnStartupTaskCompleted(string taskName)));
            this._guideEventsSharedContext._masterEvents.add_PhaseCompleted(value:  new System.Action<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnPhaseCompleted(Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase phase)));
            this._guideEventsSharedContext._masterEvents.add_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)));
            this._guideEventsSharedContext._masterEvents.add_EncounterEndedEvent(value:  new System.Action<System.Boolean, System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnEncounterEnded(bool success, string cpuId)));
            this._guideEventsSharedContext._masterEvents.add_StreakDataUpdated(value:  new System.Action<TheGame.Data.StreakData>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnPlayerStreakChanged(TheGame.Data.StreakData streakData)));
            this._guideEventsSharedContext._masterEvents.add_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnRemnantCountUpdated(System.Collections.Generic.Dictionary<string, int> dictionary)));
            this._guideEventsSharedContext._masterEvents.add_InventoryUpdated(value:  new System.Action<TheGame.PlayerInventory>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnInventoryUpdated(TheGame.PlayerInventory data)));
            this._guideEventsSharedContext._masterEvents.add_ModInventoryUpdated(value:  new System.Action<Game.Workshop.Data.ModInventory>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnModInventoryUpdated(Game.Workshop.Data.ModInventory data)));
            this._guideEventsSharedContext._masterEvents.add_CPUInventoryUpdated(value:  new System.Action<Game.TheGame.Data.CPUInventory>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data)));
            this._guideEventsSharedContext._masterEvents.add_AnimatronicEntityReturned(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicReturnedWithWear()));
            this._guideEventsSharedContext._masterEvents.add_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnTutorialDataReceived(Game.TheGame.Data.TutorialData data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._guideEventsSharedContext._masterEvents != null)
            {
                    this._guideEventsSharedContext._masterEvents.remove_UICanvasDidAppear(value:  new System.Action<DisplayType>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnUIOpened(TheGame.GameDisplayData.DisplayType type)));
                this._guideEventsSharedContext._masterEvents.remove_UICanvasClosed(value:  new System.Action<DisplayType>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnUIClosed(TheGame.GameDisplayData.DisplayType type)));
                this._guideEventsSharedContext._masterEvents.remove_GuidePopupRequested(value:  new System.Action<System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnGuidePopupOpened(string popupName)));
                this._guideEventsSharedContext._masterEvents.remove_GuidePopupClosing(value:  new System.Action<System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnGuidePopupClosing(string popupName)));
                this._guideEventsSharedContext._masterEvents.remove_AnimatronicDefeated(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicDefeated()));
                this._guideEventsSharedContext._masterEvents.remove_AnimatronicAttackWindowClosed(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicAttackWindowClosed()));
                this._guideEventsSharedContext._masterEvents.remove_AnimatronicShocked(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicShocked()));
                this._guideEventsSharedContext._masterEvents.remove_StartupTaskCompleted(value:  new System.Action<System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnStartupTaskCompleted(string taskName)));
                this._guideEventsSharedContext._masterEvents.remove_PhaseCompleted(value:  new System.Action<Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnPhaseCompleted(Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase phase)));
                this._guideEventsSharedContext._masterEvents.remove_AttackEncounterStarted(value:  new System.Action<Game.ItemDefinition.Data.DataDefinitions.EncounterType>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)));
                this._guideEventsSharedContext._masterEvents.remove_EncounterEndedEvent(value:  new System.Action<System.Boolean, System.String>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnEncounterEnded(bool success, string cpuId)));
                this._guideEventsSharedContext._masterEvents.remove_StreakDataUpdated(value:  new System.Action<TheGame.Data.StreakData>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnPlayerStreakChanged(TheGame.Data.StreakData streakData)));
                this._guideEventsSharedContext._masterEvents.remove_PlayerCurrencyRefreshed(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnRemnantCountUpdated(System.Collections.Generic.Dictionary<string, int> dictionary)));
                this._guideEventsSharedContext._masterEvents.remove_InventoryUpdated(value:  new System.Action<TheGame.PlayerInventory>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnInventoryUpdated(TheGame.PlayerInventory data)));
                this._guideEventsSharedContext._masterEvents.remove_ModInventoryUpdated(value:  new System.Action<Game.Workshop.Data.ModInventory>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnModInventoryUpdated(Game.Workshop.Data.ModInventory data)));
                this._guideEventsSharedContext._masterEvents.remove_CPUInventoryUpdated(value:  new System.Action<Game.TheGame.Data.CPUInventory>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data)));
                this._guideEventsSharedContext._masterEvents.remove_AnimatronicEntityReturned(value:  new System.Action(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnAnimatronicReturnedWithWear()));
                this._guideEventsSharedContext._masterEvents.remove_TutorialStartupDataReceived(value:  new System.Action<Game.TheGame.Data.TutorialData>(object:  this, method:  public System.Void Systems.Guide.GameplayAdapter::OnTutorialDataReceived(Game.TheGame.Data.TutorialData data)));
            }
            
            this._guideEventsSharedContext = 0;
            mem[1152921523371803192] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this._secondsSinceLastClockTick + val_1;
            this._secondsSinceLastClockTick = val_1;
            if(val_1 <= 1f)
            {
                    return;
            }
            
            val_1 = val_1 + (-1f);
            this._secondsSinceLastClockTick = val_1;
            this._driver.ProcessEvent(guideEvent:  1, argument:  System.String.alignConst);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUIOpened(TheGame.GameDisplayData.DisplayType type)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = type});
            this._driver.ProcessEvent(guideEvent:  2, argument:  type.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUIClosed(TheGame.GameDisplayData.DisplayType type)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = type});
            this._driver.ProcessEvent(guideEvent:  3, argument:  type.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGuidePopupOpened(string popupName)
        {
            this._driver.ProcessEvent(guideEvent:  2, argument:  popupName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnGuidePopupClosing(string popupName)
        {
            this._driver.ProcessEvent(guideEvent:  3, argument:  popupName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicShocked()
        {
            this._driver.ProcessEvent(guideEvent:  5, argument:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicAttackWindowClosed()
        {
            this._driver.ProcessEvent(guideEvent:  6, argument:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnStartupTaskCompleted(string taskName)
        {
            this._driver.ProcessEvent(guideEvent:  10, argument:  taskName);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPhaseCompleted(Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase phase)
        {
            Systems.Guide.GuideNodeDriver val_1;
            string val_2;
            if(phase != 5)
            {
                    if(phase != 7)
            {
                    return;
            }
            
                val_1 = this._driver;
                val_2 = "Charge";
            }
            else
            {
                    val_1 = this._driver;
                val_2 = "Pause";
            }
            
            val_1.ProcessEvent(guideEvent:  7, argument:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAttackEncounterStarted(Game.ItemDefinition.Data.DataDefinitions.EncounterType type)
        {
            this._driver.ProcessEvent(guideEvent:  11, argument:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEncounterEnded(bool success, string cpuId)
        {
            this._driver.ProcessEvent(guideEvent:  12, argument:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicDefeated()
        {
            this._driver.ProcessEvent(guideEvent:  13, argument:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPlayerStreakChanged(TheGame.Data.StreakData streakData)
        {
            this._driver.ProcessEvent(guideEvent:  14, argument:  streakData.bestStreak.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnModInventoryUpdated(Game.Workshop.Data.ModInventory data)
        {
            Dictionary.Enumerator<TKey, TValue> val_2 = data.GetMods().GetEnumerator();
            goto label_3;
            label_4:
            UnityEngine.XR.ARSubsystems.TrackableId val_3 = 0.trackableId;
            label_3:
            if((1587052680 & 1) != 0)
            {
                goto label_4;
            }
            
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523373768840});
            this._driver.ProcessEvent(guideEvent:  16, argument:  1.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCPUInventoryUpdated(Game.TheGame.Data.CPUInventory data)
        {
            Dictionary.Enumerator<TKey, TValue> val_2 = data.entries.GetEnumerator();
            goto label_5;
            label_6:
            UnityEngine.XR.ARSubsystems.TrackableId val_3 = 0.trackableId;
            bool val_5 = val_3.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int32>::get_Key()).Contains(value:  "BareEndo");
            label_5:
            if((1587210832 & 1) != 0)
            {
                goto label_6;
            }
            
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523373926992});
            this._driver.ProcessEvent(guideEvent:  17, argument:  1.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInventoryUpdated(TheGame.PlayerInventory data)
        {
            List.Enumerator<T> val_2 = data.GetPlushSuits().GetEnumerator();
            goto label_5;
            label_6:
            bool val_4 = 0.emailUIDataHandler.Contains(value:  "BareEndo");
            label_5:
            if((1587367912 & 1) != 0)
            {
                goto label_6;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523374084072});
            this._driver.ProcessEvent(guideEvent:  18, argument:  1.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemnantCountUpdated(System.Collections.Generic.Dictionary<string, int> dictionary)
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = dictionary.GetEnumerator();
            goto label_4;
            label_5:
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            bool val_4 = val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int32>::get_Key()).Equals(value:  "ESSENCE");
            label_4:
            if((1587521960 & 1) != 0)
            {
                goto label_5;
            }
            
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523374238120});
            this._driver.ProcessEvent(guideEvent:  15, argument:  val_2.m_SubId1.ToString());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAnimatronicReturnedWithWear()
        {
            this._driver.ProcessEvent(guideEvent:  8, argument:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnTutorialDataReceived(Game.TheGame.Data.TutorialData data)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = 0;
            val_6 = 1;
            goto label_1;
            label_9:
            Game.TheGame.Data.TutorialEntry val_1 = data.Entries.Item[0];
            if((val_1.TutorialKey.Equals(value:  "FTUE")) != false)
            {
                    val_6 = val_1.GuideNodeId.Equals(value:  "");
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < data.Entries.Count)
            {
                goto label_9;
            }
            
            if(val_6 == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            UnityEngine.PlayerPrefs.SetString(key:  Game.Server.TutorialDataResponseHandler.IgnoreFTUEVO, value:  "IgnoreFTUEVO_true");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameplayAdapter()
        {
        
        }
    
    }

}
