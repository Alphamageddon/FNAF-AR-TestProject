using UnityEngine;

namespace Game.EssenceCollection
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceCollectionDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <RewardsFlowActive>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedEssence <_collectedEssence>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedThreat <_collectedThreat>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Threat.ThreatLevelDisplay <_threatLevelDisplay>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator <_essenceAngleCalculator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeDespawner <_essenceNodeDespawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.Cooldowns <_cooldowns>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder <_cameraInfoRecorder>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator <_arObjectEvaluator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.EssenceNodePackager <_essenceNodePackager>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning <_essenceNodeOverrideSpawning>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum <_particleVacuum>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner <_moteSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.Motes.MoteOrbiter <_moteOrbiter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.Motes.MoteDegrader <_moteDegrader>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner <_threatPillSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillOrbiter <_threatPillOrbiter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillDegrader <_threatPillDegrader>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.ParticleCollector <_particleCollector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.GeigerCounter <_geigerCounter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.CloakDecloak <_cloakDecloak>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Threat.ThreatEvaluator <_threatEvaluator>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int AmountOfEssence { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatPercent { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RewardsFlowActive { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedEssence _collectedEssence { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat _collectedThreat { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Threat.ThreatLevelDisplay _threatLevelDisplay { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator _essenceAngleCalculator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer _audioPlayer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes _essenceNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeDespawner _essenceNodeDespawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns _cooldowns { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder _cameraInfoRecorder { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator _arObjectEvaluator { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceNodePackager _essenceNodePackager { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning _essenceNodeOverrideSpawning { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum _particleVacuum { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner _moteSpawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteOrbiter _moteOrbiter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteDegrader _moteDegrader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner _threatPillSpawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillOrbiter _threatPillOrbiter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillDegrader _threatPillDegrader { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleCollector _particleCollector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.GeigerCounter _geigerCounter { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CloakDecloak _cloakDecloak { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Threat.ThreatEvaluator _threatEvaluator { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_AmountOfEssence()
        {
            if((this.<_collectedEssence>k__BackingField) != null)
            {
                    return (int)this.<_collectedEssence>k__BackingField._amount;
            }
            
            return (int)this.<_collectedEssence>k__BackingField._amount;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_ThreatPercent()
        {
            if((this.<_collectedThreat>k__BackingField) != null)
            {
                    return (float)this.<_collectedThreat>k__BackingField._percent;
            }
            
            return (float)this.<_collectedThreat>k__BackingField._percent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_RewardsFlowActive()
        {
            return (bool)this.<RewardsFlowActive>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_RewardsFlowActive(bool value)
        {
            this.<RewardsFlowActive>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedEssence get__collectedEssence()
        {
            return (Game.EssenceCollection.Data.Collected.CollectedEssence)this.<_collectedEssence>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat get__collectedThreat()
        {
            return (Game.EssenceCollection.Data.Collected.CollectedThreat)this.<_collectedThreat>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Threat.ThreatLevelDisplay get__threatLevelDisplay()
        {
            return (Game.EssenceCollection.Actions.Threat.ThreatLevelDisplay)this.<_threatLevelDisplay>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator get__essenceAngleCalculator()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator)this.<_essenceAngleCalculator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer get__audioPlayer()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer)this.<_audioPlayer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes get__essenceNodes()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.EssenceNodes)this.<_essenceNodes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills get__allThreatPills()
        {
            return (Game.EssenceCollection.Data.Particles.AllThreatPills)this.<_allThreatPills>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeDespawner get__essenceNodeDespawner()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeDespawner)this.<_essenceNodeDespawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.Cooldowns get__cooldowns()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.Cooldowns)this.<_cooldowns>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder get__cameraInfoRecorder()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder)this.<_cameraInfoRecorder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator get__arObjectEvaluator()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator)this.<_arObjectEvaluator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceNodePackager get__essenceNodePackager()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.EssenceNodePackager)this.<_essenceNodePackager>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning get__essenceNodeOverrideSpawning()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning)this.<_essenceNodeOverrideSpawning>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum get__particleVacuum()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum)this.<_particleVacuum>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner get__moteSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner)this.<_moteSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteOrbiter get__moteOrbiter()
        {
            return (Game.EssenceCollection.Actions.Particles.Motes.MoteOrbiter)this.<_moteOrbiter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteDegrader get__moteDegrader()
        {
            return (Game.EssenceCollection.Actions.Particles.Motes.MoteDegrader)this.<_moteDegrader>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner get__threatPillSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner)this.<_threatPillSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillOrbiter get__threatPillOrbiter()
        {
            return (Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillOrbiter)this.<_threatPillOrbiter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillDegrader get__threatPillDegrader()
        {
            return (Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillDegrader)this.<_threatPillDegrader>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleCollector get__particleCollector()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.ParticleCollector)this.<_particleCollector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.GeigerCounter get__geigerCounter()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.GeigerCounter)this.<_geigerCounter>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CloakDecloak get__cloakDecloak()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.CloakDecloak)this.<_cloakDecloak>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Threat.ThreatEvaluator get__threatEvaluator()
        {
            return (Game.EssenceCollection.Actions.Threat.ThreatEvaluator)this.<_threatEvaluator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceCollectionDomain(Master.SceneLookupTableAccess sceneLookupTableAccess, Game.MasterData.MasterDataDomain masterDataDomain, Game.Server.ServerDomain serverDomain, Master.EventExposer eventExposer, Systems.ARObjectDetection.ARObjectDetectionDomain arObjectDetectionDomain, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain, Game.CameraEquipment.CameraEquipmentDomain cameraEquipmentDomain, Game.AssetManagement.GameAssetManagementDomain gameAssetManagementDomain, TheGame.GameDisplayChanger gameDisplay, Game.Audio.GameAudioDomain gameAudioDomain)
        {
            val_1 = new System.Object();
            this.<_masterDataConnector>k__BackingField = new Game.EssenceCollection.Data.MasterDataConnector(sceneLookupTableAccess:  sceneLookupTableAccess, masterDataDomain:  Game.MasterData.MasterDataDomain val_1 = masterDataDomain);
            this.<_collectedEssence>k__BackingField = new Game.EssenceCollection.Data.Collected.CollectedEssence();
            Game.EssenceCollection.Data.Collected.CollectedThreat val_4 = new Game.EssenceCollection.Data.Collected.CollectedThreat(masterDataConnector:  this.<_masterDataConnector>k__BackingField);
            this.<_collectedThreat>k__BackingField = val_4;
            this.<_threatLevelDisplay>k__BackingField = new Game.EssenceCollection.Actions.Threat.ThreatLevelDisplay(collectedThreat:  val_4, sceneLookupTableAccess:  sceneLookupTableAccess, attackSequenceDomain:  attackSequenceDomain);
            this.<_essenceAngleCalculator>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.EssenceAngleCalculator(masterDataConnector:  this.<_masterDataConnector>k__BackingField, sceneLookupTableAccess:  sceneLookupTableAccess);
            this.<_allMotes>k__BackingField = new Game.EssenceCollection.Data.Particles.AllMotes(masterDataConnector:  this.<_masterDataConnector>k__BackingField);
            Game.EssenceCollection.Data.Particles.AllThreatPills val_8 = new Game.EssenceCollection.Data.Particles.AllThreatPills(masterDataConnector:  this.<_masterDataConnector>k__BackingField);
            this.<_allThreatPills>k__BackingField = val_8;
            Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum val_9 = new Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum(masterDataConnector:  this.<_masterDataConnector>k__BackingField, attackSequenceDomain:  attackSequenceDomain, cameraEquipmentDomain:  cameraEquipmentDomain, allMotes:  this.<_allMotes>k__BackingField, allThreatPills:  val_8, sceneLookupTableAccess:  sceneLookupTableAccess);
            this.<_particleVacuum>k__BackingField = val_9;
            this.<_audioPlayer>k__BackingField = new Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer(masterEventExposer:  eventExposer, gameAudioDomain:  gameAudioDomain, attackSequenceDomain:  attackSequenceDomain, gameDisplay:  gameDisplay, collectedThreat:  this.<_collectedThreat>k__BackingField, essenceAngleCalculator:  this.<_essenceAngleCalculator>k__BackingField, particleVacuum:  val_9);
            Game.EssenceCollection.Data.EssenceNodes.EssenceNodes val_12 = new Game.EssenceCollection.Data.EssenceNodes.EssenceNodes(masterEventExposer:  eventExposer, sceneLookupTableAccess:  sceneLookupTableAccess, masterDataConnector:  this.<_masterDataConnector>k__BackingField, assetCacheAccess:  gameAssetManagementDomain.AssetCacheAccess, audioPlayer:  this.<_audioPlayer>k__BackingField);
            this.<_essenceNodes>k__BackingField = val_12;
            this.<_essenceNodeDespawner>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeDespawner(essenceCollectionDomain:  this, essenceNodes:  val_12, attackSequenceDomain:  attackSequenceDomain, allMotes:  this.<_allMotes>k__BackingField, gameDisplayChanger:  gameDisplay);
            Game.EssenceCollection.Data.EssenceNodes.Cooldowns val_14 = new Game.EssenceCollection.Data.EssenceNodes.Cooldowns(masterDataConnector:  this.<_masterDataConnector>k__BackingField, eventExposer:  eventExposer);
            this.<_cooldowns>k__BackingField = val_14;
            Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator val_15 = new Game.EssenceCollection.Actions.EssenceNodes.ArObjectEvaluator(masterDataConnector:  this.<_masterDataConnector>k__BackingField, cooldowns:  val_14);
            this.<_arObjectEvaluator>k__BackingField = val_15;
            this.<_cameraInfoRecorder>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder(essenceCollectionDomain:  this, sceneLookupTableAccess:  sceneLookupTableAccess, arObjectDetectionDomain:  arObjectDetectionDomain, masterEventExposer:  eventExposer, masterDataConnector:  this.<_masterDataConnector>k__BackingField, attackSequenceDomain:  attackSequenceDomain, arObjectEvaluator:  val_15, gameDisplay:  gameDisplay);
            this.<_essenceNodePackager>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.EssenceNodePackager(masterEventExposer:  eventExposer, cooldowns:  this.<_cooldowns>k__BackingField, serverDomain:  serverDomain);
            this.<_essenceNodeOverrideSpawning>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning(masterDataConnector:  this.<_masterDataConnector>k__BackingField, arObjectDetectionDomain:  arObjectDetectionDomain, essenceNodes:  this.<_essenceNodes>k__BackingField, cameraInfoRecorder:  this.<_cameraInfoRecorder>k__BackingField);
            this.<_moteSpawner>k__BackingField = new Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner(masterDataConnector:  this.<_masterDataConnector>k__BackingField, allMotes:  this.<_allMotes>k__BackingField, essenceNodes:  this.<_essenceNodes>k__BackingField, sceneLookupTableAccess:  sceneLookupTableAccess, audioPlayer:  this.<_audioPlayer>k__BackingField);
            this.<_moteOrbiter>k__BackingField = new Game.EssenceCollection.Actions.Particles.Motes.MoteOrbiter(allMotes:  this.<_allMotes>k__BackingField);
            this.<_moteDegrader>k__BackingField = new Game.EssenceCollection.Actions.Particles.Motes.MoteDegrader(masterDataConnector:  this.<_masterDataConnector>k__BackingField, allMotes:  this.<_allMotes>k__BackingField, particleVacuum:  this.<_particleVacuum>k__BackingField, moteSpawner:  this.<_moteSpawner>k__BackingField);
            this.<_threatPillSpawner>k__BackingField = new Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner(masterDataConnector:  this.<_masterDataConnector>k__BackingField, allThreatPills:  this.<_allThreatPills>k__BackingField, essenceNodes:  this.<_essenceNodes>k__BackingField, sceneLookupTableAccess:  sceneLookupTableAccess, audioPlayer:  this.<_audioPlayer>k__BackingField);
            this.<_threatPillOrbiter>k__BackingField = new Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillOrbiter(allThreatPills:  this.<_allThreatPills>k__BackingField);
            this.<_threatPillDegrader>k__BackingField = new Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillDegrader(masterDataConnector:  this.<_masterDataConnector>k__BackingField, allThreatPills:  this.<_allThreatPills>k__BackingField, particleVacuum:  this.<_particleVacuum>k__BackingField, threatPillSpawner:  this.<_threatPillSpawner>k__BackingField);
            this.<_particleCollector>k__BackingField = new Game.EssenceCollection.Actions.Miscellaneous.ParticleCollector(masterDataConnector:  this.<_masterDataConnector>k__BackingField, allMotes:  this.<_allMotes>k__BackingField, allThreatPills:  this.<_allThreatPills>k__BackingField, audioPlayer:  this.<_audioPlayer>k__BackingField, moteSpawner:  this.<_moteSpawner>k__BackingField, threatPillSpawner:  this.<_threatPillSpawner>k__BackingField, collectedEssence:  this.<_collectedEssence>k__BackingField, collectedThreat:  this.<_collectedThreat>k__BackingField, particleVacuum:  this.<_particleVacuum>k__BackingField, serverDomain:  serverDomain);
            this.<_geigerCounter>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.GeigerCounter(masterDataConnector:  this.<_masterDataConnector>k__BackingField, essenceNodes:  this.<_essenceNodes>k__BackingField, allMotes:  this.<_allMotes>k__BackingField, gameDisplay:  gameDisplay, essenceAngleCalculator:  this.<_essenceAngleCalculator>k__BackingField);
            this.<_cloakDecloak>k__BackingField = new Game.EssenceCollection.Actions.EssenceNodes.CloakDecloak(masterDataConnector:  this.<_masterDataConnector>k__BackingField, essenceNodes:  this.<_essenceNodes>k__BackingField, moteSpawner:  this.<_moteSpawner>k__BackingField, threatPillSpawner:  this.<_threatPillSpawner>k__BackingField, sceneLookupTableAccess:  sceneLookupTableAccess, audioPlayer:  this.<_audioPlayer>k__BackingField);
            .<_masterDataConnector>k__BackingField = this.<_masterDataConnector>k__BackingField;
            .<_serverDomain>k__BackingField = serverDomain;
            .<_collectedThreat>k__BackingField = this.<_collectedThreat>k__BackingField;
            .<_attackSequenceDomain>k__BackingField = attackSequenceDomain;
            .<_cooldowns>k__BackingField = this.<_cooldowns>k__BackingField;
            this.<_threatEvaluator>k__BackingField = new Game.EssenceCollection.Actions.Threat.ThreatEvaluator();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEssence(int num)
        {
            int val_1 = this.<_collectedEssence>k__BackingField._amount;
            val_1 = val_1 + num;
            this.<_collectedEssence>k__BackingField._amount = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveEssence(int num)
        {
            int val_1 = this.<_collectedEssence>k__BackingField._amount;
            val_1 = val_1 - num;
            val_1 = val_1 & (~(val_1 >> 31));
            this.<_collectedEssence>k__BackingField._amount = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(float deltaTime)
        {
            if((this.<_masterDataConnector>k__BackingField.<_configDataEntry>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<_masterDataConnector>k__BackingField.<_essenceTypesData>k__BackingField) == null)
            {
                    return;
            }
            
            this.<_audioPlayer>k__BackingField.Update();
            this.<_essenceNodes>k__BackingField.ProcessOnDeckEssences();
            this.<_essenceNodes>k__BackingField.RemoveExpiredEssences();
            this.<_collectedThreat>k__BackingField.Update(deltaTime:  deltaTime);
            this.<_threatLevelDisplay>k__BackingField.Update();
            this.<_essenceNodeDespawner>k__BackingField.Update();
            this.<_cameraInfoRecorder>k__BackingField.Update();
            this.<_essenceNodeOverrideSpawning>k__BackingField.Update();
            this.<_particleVacuum>k__BackingField.Update();
            this.<_moteSpawner>k__BackingField.Update();
            this.<_moteOrbiter>k__BackingField.Update();
            this.<_moteDegrader>k__BackingField.Update();
            this.<_threatPillSpawner>k__BackingField.Update();
            this.<_threatPillOrbiter>k__BackingField.Update();
            this.<_threatPillDegrader>k__BackingField.Update();
            this.<_particleCollector>k__BackingField.Update();
            this.<_geigerCounter>k__BackingField.Update();
            this.<_cloakDecloak>k__BackingField.Update();
            this.<_threatEvaluator>k__BackingField.CheckForThreatSpawn();
        }
    
    }

}
