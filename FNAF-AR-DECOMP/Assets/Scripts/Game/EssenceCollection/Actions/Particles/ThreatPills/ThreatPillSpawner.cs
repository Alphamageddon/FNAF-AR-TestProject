using UnityEngine;

namespace Game.EssenceCollection.Actions.Particles.ThreatPills
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ThreatPillSpawner
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisualsParent <_essenceVisualsParent>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _essencesThatAreSpawning;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode> _oldEssences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, float> _lastSpawnTimestampForEssence;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes _essenceNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisualsParent _essenceVisualsParent { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer _audioPlayer { get; }
        
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
        private Game.EssenceCollection.Data.Particles.AllThreatPills get__allThreatPills()
        {
            return (Game.EssenceCollection.Data.Particles.AllThreatPills)this.<_allThreatPills>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisualsParent get__essenceVisualsParent()
        {
            return (Game.EssenceCollection.Visuals.EssenceVisualsParent)this.<_essenceVisualsParent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__essenceVisualsParent(Game.EssenceCollection.Visuals.EssenceVisualsParent value)
        {
            this.<_essenceVisualsParent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer get__audioPlayer()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer)this.<_audioPlayer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ThreatPillSpawner(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.Particles.AllThreatPills allThreatPills, Game.EssenceCollection.Data.EssenceNodes.EssenceNodes essenceNodes, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer audioPlayer)
        {
            this._essencesThatAreSpawning = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._oldEssences = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._lastSpawnTimestampForEssence = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single>();
            val_4 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_essenceNodes>k__BackingField = essenceNodes;
            this.<_allThreatPills>k__BackingField = val_4;
            this.<_audioPlayer>k__BackingField = audioPlayer;
            essenceNodes.add_EssenceNodeDespawned(value:  new System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(object:  this, method:  System.Void Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner::EssenceNodesOnEssenceNodeDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)));
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EssenceNodesOnEssenceNodeDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            ThreatPillSpawnInfo[] val_1 = this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  essenceNode);
            if((val_1 != null) && (val_1.Length >= 1))
            {
                    do
            {
                this.DespawnThreatPill(threatPillSpawnInfo:  val_1[0]);
            }
            while((0 + 1) < val_1.Length);
            
            }
            
            ThreatPillSpawnInfo[] val_3 = this.<_allThreatPills>k__BackingField.GetDetachedThreatPills();
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_3.Length < 1)
            {
                    return;
            }
            
            do
            {
                if(val_3[0x0][0].EssenceNode == essenceNode)
            {
                    this.DespawnThreatPill(threatPillSpawnInfo:  val_3[0]);
            }
            
            }
            while((0 + 1) < val_3.Length);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)
        {
            this.<_essenceVisualsParent>k__BackingField = cameraSceneLookupTable.EssenceVisualsParent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartSpawningFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            bool val_1 = this._essencesThatAreSpawning.Add(item:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StopSpawningFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            bool val_1 = this._essencesThatAreSpawning.Remove(item:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DespawnThreatPill(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            threatPillSpawnInfo.ThreatPill.transform.parent = this.<_essenceVisualsParent>k__BackingField.transform;
            this.<_essenceVisualsParent>k__BackingField.ReturnThreatPillParent(threatPillParent:  threatPillSpawnInfo.ThreatPillParent);
            this.<_essenceVisualsParent>k__BackingField.ReturnThreatPill(threatPill:  threatPillSpawnInfo.ThreatPill);
            this.<_allThreatPills>k__BackingField.RemoveThreatPill(threatPillSpawnInfo:  threatPillSpawnInfo);
            if((this.<_audioPlayer>k__BackingField) != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSpawningFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            this.SpawnAnyInitialThreatPills(essenceNode:  essenceNode);
            if((this.IsReadyToSpawnFor(essenceNode:  essenceNode)) == false)
            {
                    return;
            }
            
            if(essenceNode.NumRemainingThreatPills < 1)
            {
                    return;
            }
            
            this.SpawnNewThreatPillFor(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnAnyInitialThreatPills(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            goto label_0;
            label_2:
            this.SpawnNewThreatPillFor(essenceNode:  essenceNode);
            label_0:
            if(essenceNode.NumInitialThreatPillsToSpawn > 0)
            {
                goto label_2;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsReadyToSpawnFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            Game.EssenceCollection.Data.EssenceNodes.EssenceNode val_13;
            System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single> val_14;
            var val_15;
            float val_16;
            val_13 = essenceNode;
            val_14 = this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  val_13);
            if((this.<_masterDataConnector>k__BackingField.ThreatPills_MaxVisibleThreatPillsPerEssence) <= (float)val_1.Length)
            {
                goto label_4;
            }
            
            val_14 = this._lastSpawnTimestampForEssence;
            if((val_14.ContainsKey(key:  val_13)) == false)
            {
                goto label_6;
            }
            
            val_13 = val_13.EssenceTypesEntry;
            THREATPILLOVERRIDES val_5 = val_13.ThreatPillOverrides;
            if(val_5 == null)
            {
                goto label_11;
            }
            
            SPAWNBEHAVIOR val_6 = val_5.SpawnBehavior;
            if(val_6 == null)
            {
                goto label_11;
            }
            
            double val_7 = val_6.SpawnTime;
            goto label_12;
            label_4:
            val_15 = 0;
            return (bool)((this._lastSpawnTimestampForEssence.Item[val_13] + val_16) <= UnityEngine.Time.time) ? 1 : 0;
            label_6:
            val_15 = 1;
            return (bool)((this._lastSpawnTimestampForEssence.Item[val_13] + val_16) <= UnityEngine.Time.time) ? 1 : 0;
            label_11:
            label_12:
            val_16 = 0f;
            if(((-732440976) & 1) == 0)
            {
                    return (bool)((this._lastSpawnTimestampForEssence.Item[val_13] + val_16) <= UnityEngine.Time.time) ? 1 : 0;
            }
            
            val_16 = (float)0.South;
            return (bool)((this._lastSpawnTimestampForEssence.Item[val_13] + val_16) <= UnityEngine.Time.time) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanSpawnFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            return (bool)(essenceNode.NumRemainingThreatPills > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnNewThreatPillFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            float val_30;
            essenceNode.ObtainThreatPills(numThreatPills:  1);
            this._lastSpawnTimestampForEssence.set_Item(key:  essenceNode, value:  UnityEngine.Time.time);
            UnityEngine.GameObject val_2 = this.<_essenceVisualsParent>k__BackingField.ObtainAvailableThreatPillParent();
            UnityEngine.Vector3 val_6 = essenceNode.EssenceVisual.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_9 = essenceNode.EssenceVisual.transform.localScale;
            val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_12 = UnityEngine.Random.rotation;
            val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            Game.EssenceCollection.Visuals.ThreatPillVisual val_15 = this.<_essenceVisualsParent>k__BackingField.ObtainAvailableThreatPillOfType(threatPillPrefab:  essenceNode.EssenceVisual.ThreatPillPrefab);
            val_15.transform.parent = val_2.transform;
            THREATPILLOVERRIDES val_19 = essenceNode.EssenceTypesEntry.ThreatPillOverrides;
            if(val_19 == null)
            {
                goto label_25;
            }
            
            SPAWNBEHAVIOR val_20 = val_19.SpawnBehavior;
            if(val_20 == null)
            {
                goto label_25;
            }
            
            double val_21 = val_20.MinOrbitRadius;
            goto label_26;
            label_25:
            label_26:
            val_30 = 0f;
            if(((-732031696) & 1) != 0)
            {
                    val_30 = (float)0.South;
            }
            
            THREATPILLOVERRIDES val_24 = essenceNode.EssenceTypesEntry.ThreatPillOverrides;
            if(val_24 == null)
            {
                goto label_31;
            }
            
            SPAWNBEHAVIOR val_25 = val_24.SpawnBehavior;
            if(val_25 == null)
            {
                goto label_31;
            }
            
            double val_26 = val_25.MaxOrbitRadius;
            goto label_32;
            label_31:
            label_32:
            float val_28 = UnityEngine.Random.Range(min:  val_30, max:  (float)0.South);
            val_15.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.<_allThreatPills>k__BackingField.AddThreatPill(essenceNode:  essenceNode, threatPillParent:  val_2, threatPill:  val_15);
            this.<_audioPlayer>k__BackingField.TriggerThreatPillSpawned(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshKnownEssences()
        {
            var val_4;
            HashSet.Enumerator<T> val_2 = this._essencesThatAreSpawning.GetEnumerator();
            label_6:
            if(((-731766080) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            if((System.Linq.Enumerable.Contains<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(source:  this.<_essenceNodes>k__BackingField.CurrentEssences, value:  val_5)) == true)
            {
                goto label_6;
            }
            
            bool val_7 = this._oldEssences.Add(item:  val_5);
            goto label_6;
            label_3:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525349917376});
            HashSet.Enumerator<T> val_10 = this._oldEssences.GetEnumerator();
            label_15:
            if(((-731766080) & 1) == 0)
            {
                goto label_13;
            }
            
            bool val_12 = this._essencesThatAreSpawning.Remove(item:  val_4.emailUIDataHandler);
            goto label_15;
            label_13:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525349917376});
            this._oldEssences.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanUpOldSpawnTimes()
        {
            var val_4;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._lastSpawnTimestampForEssence.Keys.GetEnumerator();
            label_6:
            if(((-731576240) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            if((this.IsReadyToSpawnFor(essenceNode:  val_5)) == false)
            {
                goto label_6;
            }
            
            bool val_7 = this._oldEssences.Add(item:  val_5);
            goto label_6;
            label_3:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525350107216});
            HashSet.Enumerator<T> val_10 = this._oldEssences.GetEnumerator();
            label_15:
            if(((-731576264) & 1) == 0)
            {
                goto label_13;
            }
            
            bool val_12 = this._lastSpawnTimestampForEssence.Remove(key:  0.emailUIDataHandler);
            goto label_15;
            label_13:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525350107192});
            this._oldEssences.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.<_essenceVisualsParent>k__BackingField)) == false)
            {
                    return;
            }
            
            this.RefreshKnownEssences();
            HashSet.Enumerator<T> val_2 = this._essencesThatAreSpawning.GetEnumerator();
            label_6:
            if(((-731410952) & 1) == 0)
            {
                goto label_5;
            }
            
            this.UpdateSpawningFor(essenceNode:  0.emailUIDataHandler);
            goto label_6;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525350272504});
            this.CleanUpOldSpawnTimes();
        }
    
    }

}
