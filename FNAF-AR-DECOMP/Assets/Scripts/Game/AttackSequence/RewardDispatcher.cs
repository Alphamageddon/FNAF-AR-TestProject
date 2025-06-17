using UnityEngine;

namespace Game.AttackSequence
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldRequestRewards;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardDispatcher(Master.EventExposer masterEventExposer, Game.Server.ServerDomain serverDomain)
        {
            this._shouldRequestRewards = true;
            val_1 = new System.Object();
            this._masterEventExposer = masterEventExposer;
            this._serverDomain = val_1;
            masterEventExposer.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.AttackSequence.RewardDispatcher::OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.AttackSequence.RewardDispatcher::OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map)));
            this._masterEventExposer = 0;
            mem[1152921525431598376] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap map)
        {
            this._shouldRequestRewards = map.AreSpawnsAllowed();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RequestRewards(string entityId, string cpuId, string plushSuitId, bool encounterDefeated, Game.AttackSequence.Encounters.EncounterAnalyticsCollector encounterAnalyticsCollector)
        {
            if(this._shouldRequestRewards == false)
            {
                goto label_0;
            }
            
            if(encounterDefeated == false)
            {
                goto label_2;
            }
            
            Game.AttackSequence.RewardDispatcher.ReportWin(serverDomain:  this._serverDomain, entityId:  entityId, cpuId:  cpuId, plushSuitId:  plushSuitId, relativeDirection:  encounterAnalyticsCollector.lastChargerRelativeDirection);
            return;
            label_0:
            this._masterEventExposer.OnEncounterEnded(success:  encounterDefeated, cpuId:  cpuId);
            return;
            label_2:
            Game.AttackSequence.RewardDispatcher.ReportLoss(serverDomain:  this._serverDomain, entityId:  entityId, cpuId:  cpuId, plushSuitId:  plushSuitId, relativeDirection:  encounterAnalyticsCollector.lastChargerRelativeDirection);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReportWin(Game.Server.ServerDomain serverDomain, string entityId, string cpuId, string plushSuitId, Game.AttackSequence.Encounters.RelativeDirection relativeDirection)
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_AttackSequence_WinAnimatronic(cpuId:  cpuId, plushSuitId:  plushSuitId, chargeDirection:  relativeDirection);
            serverDomain.entityRewardRequester.RewardTrophies(entityId:  entityId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReportLoss(Game.Server.ServerDomain serverDomain, string entityId, string cpuId, string plushSuitId, Game.AttackSequence.Encounters.RelativeDirection relativeDirection)
        {
            Systems.Analytics.AnalyticsCalls.FireEvent_AttackSequence_LoseAnimatronic(cpuId:  cpuId, plushSuitId:  plushSuitId, chargeDirection:  relativeDirection);
            serverDomain.attackModeLostRequester.AttackModeLost(entityId:  entityId);
        }
    
    }

}
