using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodeOverrideSpawning
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float _minimumSpawnTimer = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder <_cameraInfoRecorder>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <_spawnTimer>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes _essenceNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder _cameraInfoRecorder { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _spawnTimer { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes get__essenceNodes()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.EssenceNodes)this.<_essenceNodes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder get__cameraInfoRecorder()
        {
            return (Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder)this.<_cameraInfoRecorder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float get__spawnTimer()
        {
            return (float)this.<_spawnTimer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__spawnTimer(float value)
        {
            this.<_spawnTimer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodeOverrideSpawning(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Systems.ARObjectDetection.ARObjectDetectionDomain arObjectDetectionDomain, Game.EssenceCollection.Data.EssenceNodes.EssenceNodes essenceNodes, Game.EssenceCollection.Actions.EssenceNodes.CameraInfoRecorder cameraInfoRecorder)
        {
            val_1 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_essenceNodes>k__BackingField = essenceNodes;
            this.<_cameraInfoRecorder>k__BackingField = cameraInfoRecorder;
            this.<_spawnTimer>k__BackingField = masterDataConnector.Detect_OverrideCooldown;
            essenceNodes.add_EssenceNodeSpawned(value:  new System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning::EssenceNodesOnEssenceNodeSpawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode obj)));
            val_1.EventExposer.add_OnObjectDetectionUpdatedEvent(value:  new System.Action<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[]>(object:  this, method:  System.Void Game.EssenceCollection.Actions.EssenceNodes.EssenceNodeOverrideSpawning::EventExposerOnOnObjectDetectionUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EssenceNodesOnEssenceNodeSpawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode obj)
        {
            this.<_spawnTimer>k__BackingField = this.<_masterDataConnector>k__BackingField.Detect_OverrideCooldown;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnOnObjectDetectionUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)
        {
            if((this.AreAnyObjectsSpawnable(detectedObjects:  detectedObjects)) == false)
            {
                    return;
            }
            
            this.<_spawnTimer>k__BackingField = this.<_masterDataConnector>k__BackingField.Detect_OverrideCooldown;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AreAnyObjectsSpawnable(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            label_4:
            if(val_1 >= detectedObjects.Length)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(detectedObjects[0] < (this.<_masterDataConnector>k__BackingField.Detect_MinConfidence))
            {
                goto label_4;
            }
            
            val_2 = 1;
            return (bool)val_2;
            label_1:
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetSpawnTimer()
        {
            this.<_spawnTimer>k__BackingField = this.<_masterDataConnector>k__BackingField.Detect_OverrideCooldown;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessSpawnTimer()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = (this.<_spawnTimer>k__BackingField) - val_1;
            this.<_spawnTimer>k__BackingField = val_1;
            if(val_1 > 0f)
            {
                    return;
            }
            
            this.SpawnEssence();
            this.<_spawnTimer>k__BackingField = this.<_masterDataConnector>k__BackingField.Detect_OverrideCooldown;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnEssence()
        {
            this.<_cameraInfoRecorder>k__BackingField.ForceSpawnNow();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if((this.<_cameraInfoRecorder>k__BackingField.CanDoEssenceNow()) == false)
            {
                    return;
            }
            
            this.ProcessSpawnTimer();
        }
    
    }

}
