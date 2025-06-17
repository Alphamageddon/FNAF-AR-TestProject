using UnityEngine;

namespace Game.EssenceCollection.Actions.Threat
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThreatEvaluator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.Server.ServerDomain <_serverDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedThreat <_collectedThreat>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.AttackSequenceDomain <_attackSequenceDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.Cooldowns <_cooldowns>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat _collectedThreat { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns _cooldowns { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain get__serverDomain()
        {
            return (Game.Server.ServerDomain)this.<_serverDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat get__collectedThreat()
        {
            return (Game.EssenceCollection.Data.Collected.CollectedThreat)this.<_collectedThreat>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain get__attackSequenceDomain()
        {
            return (Game.AttackSequence.AttackSequenceDomain)this.<_attackSequenceDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns get__cooldowns()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.Cooldowns)this.<_cooldowns>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThreatEvaluator(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.Server.ServerDomain serverDomain, Game.EssenceCollection.Data.Collected.CollectedThreat collectedThreat, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain, Game.EssenceCollection.Data.EssenceNodes.Cooldowns cooldowns)
        {
            val_1 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_serverDomain>k__BackingField = val_1;
            this.<_collectedThreat>k__BackingField = collectedThreat;
            this.<_attackSequenceDomain>k__BackingField = attackSequenceDomain;
            this.<_cooldowns>k__BackingField = cooldowns;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CheckForThreatSpawn()
        {
            if((this.<_cooldowns>k__BackingField.IsThreatCooledDown()) == false)
            {
                    return;
            }
            
            if((this.<_collectedThreat>k__BackingField._percent) < 0.99f)
            {
                    return;
            }
            
            this.<_serverDomain>k__BackingField.startEssenceEncounterRequester.StartEssenceEncounter();
            this = this.<_collectedThreat>k__BackingField;
            this.<_collectedThreat>k__BackingField._percent = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.CheckForThreatSpawn();
        }
    
    }

}
