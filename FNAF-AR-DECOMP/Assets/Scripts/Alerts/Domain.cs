using UnityEngine;

namespace Alerts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Domain : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.EventExposer <EventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Data.DesignData <DesignData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Data.AllEligibleAlerts <AllEligibleAlerts>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Data.CooldownTimers <CooldownTimers>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Data.NonRepeatableAlerts <NonRepeatableAlerts>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Data.FiredAlerts <FiredAlerts>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Data.LastKnownAnimatronicPerAlert <LastKnownAnimatronicPerAlert>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.PeriodicTriggers.PeriodicTriggers <PassiveTriggers>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.PeriodicTriggers.PeriodicTriggers <AnimatronicTriggers>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.DelayedAlerts <DelayedAlerts>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.DeferredAlerts <DeferredAlerts>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Server.TriggerAlertHandler <triggerAlertHandler>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Debug_UseDateOverride>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Debug_DateOverrideMonth>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Debug_DateOverrideDay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <Debug_DateOverrideYear>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Debug_LogicalId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain_SROptions debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _debugAlertEvalSpeedup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _featureFlagAllowed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _gameReadyForAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string DebugMenuName;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.MasterDataDomain MasterDataDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.Domain TheGameDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain AnimatronicEntityDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.AnimatronicStatsDomain AnimatronicStatsDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.EventExposer EventExposer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.DesignData DesignData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.AllEligibleAlerts AllEligibleAlerts { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.CooldownTimers CooldownTimers { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.NonRepeatableAlerts NonRepeatableAlerts { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.FiredAlerts FiredAlerts { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.LastKnownAnimatronicPerAlert LastKnownAnimatronicPerAlert { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.PeriodicTriggers.PeriodicTriggers PassiveTriggers { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.PeriodicTriggers.PeriodicTriggers AnimatronicTriggers { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.DelayedAlerts DelayedAlerts { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.DeferredAlerts DeferredAlerts { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Server.TriggerAlertHandler triggerAlertHandler { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Debug_AlertEvalSpeedup { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTimeOffset DateTimeOffsetToUse { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Debug_UseDateOverride { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Debug_DateOverrideMonth { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Debug_DateOverrideDay { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Debug_DateOverrideYear { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Debug_LogicalId { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.MasterData.MasterDataDomain get_MasterDataDomain()
        {
            if(this._masterDomain != null)
            {
                    return (Game.MasterData.MasterDataDomain)this._masterDomain.MasterDataDomain;
            }
            
            return (Game.MasterData.MasterDataDomain)this._masterDomain.MasterDataDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.Domain get_TheGameDomain()
        {
            if(this._masterDomain != null)
            {
                    return this._masterDomain.theGameDomain;
            }
            
            return this._masterDomain.theGameDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntity.AnimatronicEntityDomain get_AnimatronicEntityDomain()
        {
            if(this._masterDomain != null)
            {
                    return (AnimatronicEntity.AnimatronicEntityDomain)this._masterDomain.AnimatronicEntityDomain;
            }
            
            return (AnimatronicEntity.AnimatronicEntityDomain)this._masterDomain.AnimatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Animatronics.AnimatronicStats.AnimatronicStatsDomain get_AnimatronicStatsDomain()
        {
            if(this._masterDomain != null)
            {
                    return (Animatronics.AnimatronicStats.AnimatronicStatsDomain)this._masterDomain.AnimatronicStatsDomain;
            }
            
            return (Animatronics.AnimatronicStats.AnimatronicStatsDomain)this._masterDomain.AnimatronicStatsDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.EventExposer get_EventExposer()
        {
            return (Alerts.EventExposer)this.<EventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_EventExposer(Alerts.EventExposer value)
        {
            this.<EventExposer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.DesignData get_DesignData()
        {
            return (Alerts.Data.DesignData)this.<DesignData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DesignData(Alerts.Data.DesignData value)
        {
            this.<DesignData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.AllEligibleAlerts get_AllEligibleAlerts()
        {
            return (Alerts.Data.AllEligibleAlerts)this.<AllEligibleAlerts>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AllEligibleAlerts(Alerts.Data.AllEligibleAlerts value)
        {
            this.<AllEligibleAlerts>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.CooldownTimers get_CooldownTimers()
        {
            return (Alerts.Data.CooldownTimers)this.<CooldownTimers>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CooldownTimers(Alerts.Data.CooldownTimers value)
        {
            this.<CooldownTimers>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.NonRepeatableAlerts get_NonRepeatableAlerts()
        {
            return (Alerts.Data.NonRepeatableAlerts)this.<NonRepeatableAlerts>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NonRepeatableAlerts(Alerts.Data.NonRepeatableAlerts value)
        {
            this.<NonRepeatableAlerts>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.FiredAlerts get_FiredAlerts()
        {
            return (Alerts.Data.FiredAlerts)this.<FiredAlerts>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_FiredAlerts(Alerts.Data.FiredAlerts value)
        {
            this.<FiredAlerts>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Data.LastKnownAnimatronicPerAlert get_LastKnownAnimatronicPerAlert()
        {
            return (Alerts.Data.LastKnownAnimatronicPerAlert)this.<LastKnownAnimatronicPerAlert>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LastKnownAnimatronicPerAlert(Alerts.Data.LastKnownAnimatronicPerAlert value)
        {
            this.<LastKnownAnimatronicPerAlert>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.PeriodicTriggers.PeriodicTriggers get_PassiveTriggers()
        {
            return (Alerts.Trigger.PeriodicTriggers.PeriodicTriggers)this.<PassiveTriggers>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_PassiveTriggers(Alerts.Trigger.PeriodicTriggers.PeriodicTriggers value)
        {
            this.<PassiveTriggers>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.PeriodicTriggers.PeriodicTriggers get_AnimatronicTriggers()
        {
            return (Alerts.Trigger.PeriodicTriggers.PeriodicTriggers)this.<AnimatronicTriggers>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_AnimatronicTriggers(Alerts.Trigger.PeriodicTriggers.PeriodicTriggers value)
        {
            this.<AnimatronicTriggers>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.DelayedAlerts get_DelayedAlerts()
        {
            return (Alerts.Trigger.DelayedAlerts)this.<DelayedAlerts>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DelayedAlerts(Alerts.Trigger.DelayedAlerts value)
        {
            this.<DelayedAlerts>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Trigger.DeferredAlerts get_DeferredAlerts()
        {
            return (Alerts.Trigger.DeferredAlerts)this.<DeferredAlerts>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DeferredAlerts(Alerts.Trigger.DeferredAlerts value)
        {
            this.<DeferredAlerts>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Server.TriggerAlertHandler get_triggerAlertHandler()
        {
            return (Alerts.Server.TriggerAlertHandler)this.<triggerAlertHandler>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_triggerAlertHandler(Alerts.Server.TriggerAlertHandler value)
        {
            this.<triggerAlertHandler>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Debug_AlertEvalSpeedup()
        {
            return (float)(this._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._debugAlertEvalSpeedup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Debug_AlertEvalSpeedup(float value)
        {
            this._debugAlertEvalSpeedup = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTimeOffset get_DateTimeOffsetToUse()
        {
            int val_2;
            var val_3;
            var val_4;
            if((this.<Debug_UseDateOverride>k__BackingField) != false)
            {
                    val_2 = this.<Debug_DateOverrideYear>k__BackingField;
                val_3 = null;
                val_3 = null;
                val_4 = 0;
                return new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_1.m_dateTime.dateData}, m_offsetMinutes = val_1.m_offsetMinutes};
            }
            
            System.DateTimeOffset val_1 = System.DateTimeOffset.Now;
            return new System.DateTimeOffset() {m_dateTime = new System.DateTime() {dateData = val_1.m_dateTime.dateData}, m_offsetMinutes = val_1.m_offsetMinutes};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Debug_UseDateOverride()
        {
            return (bool)this.<Debug_UseDateOverride>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Debug_UseDateOverride(bool value)
        {
            this.<Debug_UseDateOverride>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Debug_DateOverrideMonth()
        {
            return (int)this.<Debug_DateOverrideMonth>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Debug_DateOverrideMonth(int value)
        {
            this.<Debug_DateOverrideMonth>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Debug_DateOverrideDay()
        {
            return (int)this.<Debug_DateOverrideDay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Debug_DateOverrideDay(int value)
        {
            this.<Debug_DateOverrideDay>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Debug_DateOverrideYear()
        {
            return (int)this.<Debug_DateOverrideYear>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Debug_DateOverrideYear(int value)
        {
            this.<Debug_DateOverrideYear>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Debug_LogicalId()
        {
            return (string)this.<Debug_LogicalId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Debug_LogicalId(string value)
        {
            this.<Debug_LogicalId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Debug_TriggerThisLogicalId()
        {
            Alerts.Evaluate.AlertEvaluator val_12;
            var val_13;
            if((System.String.IsNullOrEmpty(value:  this.<Debug_LogicalId>k__BackingField)) != false)
            {
                    ConsoleLogger.LogError(className:  "Domain", functionName:  "Debug_TriggerThisLogicalId", logString:  "Trying to trigger an alert, but no Logical Id specified");
                return;
            }
            
            label_10:
            if(0 >= val_3.Length)
            {
                goto label_6;
            }
            
            val_12 = this.<AllEligibleAlerts>k__BackingField.GetAnimatronicAlerts()[0];
            val_13 = 0 + 1;
            if((System.String.op_Equality(a:  val_3[0x0][0]._alertEntry.Logical, b:  this.<Debug_LogicalId>k__BackingField)) == false)
            {
                goto label_10;
            }
            
            goto label_19;
            label_6:
            label_18:
            if(0 >= val_6.Length)
            {
                goto label_14;
            }
            
            val_12 = this.<AllEligibleAlerts>k__BackingField.GetPassiveAlerts()[0];
            val_13 = 0 + 1;
            if((System.String.op_Equality(a:  val_6[0x0][0]._alertEntry.Logical, b:  this.<Debug_LogicalId>k__BackingField)) == false)
            {
                goto label_18;
            }
            
            goto label_19;
            label_14:
            do
            {
                if(0 >= val_9.Length)
            {
                    return;
            }
            
                val_12 = this.<AllEligibleAlerts>k__BackingField.GetPassiveAlerts()[0];
                val_13 = 0 + 1;
            }
            while((System.String.op_Equality(a:  val_9[0x0][0]._alertEntry.Logical, b:  this.<Debug_LogicalId>k__BackingField)) == false);
            
            label_19:
            ._alertEntry = val_9[0x0][0]._alertEntry;
            (Alerts.Trigger.AlertTriggerer)[1152921525099899808]._displayRestrictionChecker._alertEntry = val_9[0x0][0]._alertEntry;
            new Alerts.Trigger.AlertTriggerer(domain:  this).TriggerTheAlert();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            ._domain = this;
            this.<EventExposer>k__BackingField = new Alerts.EventExposer();
            this.<DesignData>k__BackingField = new Alerts.Data.DesignData(domain:  this);
            this.<AllEligibleAlerts>k__BackingField = new Alerts.Data.AllEligibleAlerts(domain:  this);
            this.<CooldownTimers>k__BackingField = new Alerts.Data.CooldownTimers(domain:  this);
            this.<NonRepeatableAlerts>k__BackingField = new Alerts.Data.NonRepeatableAlerts();
            this.<FiredAlerts>k__BackingField = new Alerts.Data.FiredAlerts();
            this.<LastKnownAnimatronicPerAlert>k__BackingField = new Alerts.Data.LastKnownAnimatronicPerAlert();
            ._domain = this;
            this.<PassiveTriggers>k__BackingField = new Alerts.Trigger.PeriodicTriggers.PeriodicTriggers(domain:  this, periodicTriggersConfig:  new Alerts.Trigger.PeriodicTriggers.PassiveTriggersConfig());
            ._domain = this;
            this.<AnimatronicTriggers>k__BackingField = new Alerts.Trigger.PeriodicTriggers.PeriodicTriggers(domain:  this, periodicTriggersConfig:  new Alerts.Trigger.PeriodicTriggers.AnimatronicTriggersConfig());
            this.<DelayedAlerts>k__BackingField = new Alerts.Trigger.DelayedAlerts(domain:  this);
            this.<DeferredAlerts>k__BackingField = new Alerts.Trigger.DeferredAlerts(domain:  this);
            this._debugAlertEvalSpeedup = 1f;
            System.DateTimeOffset val_14 = System.DateTimeOffset.Now;
            this.<Debug_DateOverrideMonth>k__BackingField = val_14.m_dateTime.dateData.Month;
            this.<Debug_DateOverrideDay>k__BackingField = val_14.m_dateTime.dateData.Day;
            this.<Debug_DateOverrideYear>k__BackingField = val_14.m_dateTime.dateData.Year;
            .PlayerAlertDataUpdated = new System.Action<Alerts.Data.PlayerAlertData>(object:  this.<EventExposer>k__BackingField, method:  public System.Void Alerts.EventExposer::OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData data));
            this.<triggerAlertHandler>k__BackingField = new Alerts.Server.TriggerAlertHandler();
            this.<EventExposer>k__BackingField.add_AlertPlayerDataUpdatedEvent(value:  new System.Action<Alerts.Data.PlayerAlertData>(object:  this, method:  System.Void Alerts.Domain::OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData data)));
            this.<EventExposer>k__BackingField.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Alerts.Domain::OnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)));
            this._masterDomain.eventExposer.add_GameReadyForAlertsEvent(value:  new System.Action(object:  this, method:  System.Void Alerts.Domain::OnGameReadyForAlertsEvent()));
            ._domain = this;
            this.debugOptions = new Alerts.Domain_SROptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  this.DebugMenuName, sectionMenuObject:  this.debugOptions, defaultToOn:  false);
            if((this.<EventExposer>k__BackingField) != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            DevTools.Runtime.DebugMenu.ShowHideSROptions.DeregisterMenuSection(sectionName:  this.DebugMenuName);
            if((this.<EventExposer>k__BackingField) != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._featureFlagAllowed == false)
            {
                    return;
            }
            
            if(this._gameReadyForAlerts == false)
            {
                    return;
            }
            
            this.<PassiveTriggers>k__BackingField.Update();
            this.<AnimatronicTriggers>k__BackingField.Update();
            this.<DelayedAlerts>k__BackingField.Update();
            this.<DeferredAlerts>k__BackingField.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData data)
        {
            this.<CooldownTimers>k__BackingField._cooldownTimers = data.cooldownTimers;
            this.<FiredAlerts>k__BackingField._firedAlerts = data.firedAlerts;
            this.<NonRepeatableAlerts>k__BackingField._nonRepeatableAlerts = data.nonRepeatableAlerts;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)
        {
            this._featureFlagAllowed = data.AreAlertsAllowed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGameReadyForAlertsEvent()
        {
            this._gameReadyForAlerts = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Domain()
        {
            this._featureFlagAllowed = true;
            this.DebugMenuName = "Alert System Tweaks";
        }
    
    }

}
