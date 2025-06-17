using UnityEngine;

namespace Game.EssenceCollection.Actions.Particles.Motes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MoteSpawner
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
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
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
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
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
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
        public MoteSpawner(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.Particles.AllMotes allMotes, Game.EssenceCollection.Data.EssenceNodes.EssenceNodes essenceNodes, Master.SceneLookupTableAccess sceneLookupTableAccess, Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer audioPlayer)
        {
            this._essencesThatAreSpawning = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._oldEssences = new System.Collections.Generic.HashSet<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>();
            this._lastSpawnTimestampForEssence = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Single>();
            val_4 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_essenceNodes>k__BackingField = essenceNodes;
            this.<_allMotes>k__BackingField = val_4;
            this.<_audioPlayer>k__BackingField = audioPlayer;
            essenceNodes.add_EssenceNodeDespawned(value:  new System.Action<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(object:  this, method:  System.Void Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner::EssenceNodesOnEssenceNodeDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)));
            sceneLookupTableAccess.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner::ReturnCameraSceneLookupTableCallback(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EssenceNodesOnEssenceNodeDespawned(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            goto label_1;
            label_4:
            this.DespawnMote(moteSpawnInfo:  this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  essenceNode)[0]);
            0 = 1;
            label_1:
            if(0 < val_1.Length)
            {
                goto label_4;
            }
            
            MoteSpawnInfo[] val_2 = this.<_allMotes>k__BackingField.GetDetachedMotes();
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.Length < 1)
            {
                    return;
            }
            
            do
            {
                if(val_2[0x0][0].EssenceNode == essenceNode)
            {
                    this.DespawnMote(moteSpawnInfo:  val_2[0]);
            }
            
            }
            while((0 + 1) < val_2.Length);
        
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
        public void DespawnMote(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            moteSpawnInfo.Mote.transform.parent = this.<_essenceVisualsParent>k__BackingField.transform;
            this.<_essenceVisualsParent>k__BackingField.ReturnMoteParent(moteParent:  moteSpawnInfo.MoteParent);
            this.<_essenceVisualsParent>k__BackingField.ReturnMote(mote:  moteSpawnInfo.Mote);
            this.<_allMotes>k__BackingField.RemoveMote(moteSpawnInfo:  moteSpawnInfo);
            if((this.<_audioPlayer>k__BackingField) != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateSpawningFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            this.SpawnAnyInitialMotes(essenceNode:  essenceNode);
            if((this.IsReadyToSpawnFor(essenceNode:  essenceNode)) == false)
            {
                    return;
            }
            
            if(essenceNode.NumRemainingMotes < 1)
            {
                    return;
            }
            
            this.SpawnNewMoteFor(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnAnyInitialMotes(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            goto label_0;
            label_2:
            this.SpawnNewMoteFor(essenceNode:  essenceNode);
            label_0:
            if(essenceNode.NumInitialMotesToSpawn > 0)
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
            val_14 = this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  val_13);
            if((this.<_masterDataConnector>k__BackingField.Motes_MaxVisibleMotesPerEssence) <= (float)val_1.Length)
            {
                goto label_4;
            }
            
            val_14 = this._lastSpawnTimestampForEssence;
            if((val_14.ContainsKey(key:  val_13)) == false)
            {
                goto label_6;
            }
            
            val_13 = val_13.EssenceTypesEntry;
            MOTEOVERRIDES val_5 = val_13.MoteOverrides;
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
            if(((-726499600) & 1) == 0)
            {
                    return (bool)((this._lastSpawnTimestampForEssence.Item[val_13] + val_16) <= UnityEngine.Time.time) ? 1 : 0;
            }
            
            val_16 = (float)0.South;
            return (bool)((this._lastSpawnTimestampForEssence.Item[val_13] + val_16) <= UnityEngine.Time.time) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CanSpawnFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            return (bool)(essenceNode.NumRemainingMotes > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SpawnNewMoteFor(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            float val_30;
            essenceNode.ObtainMotes(numMotes:  1);
            this._lastSpawnTimestampForEssence.set_Item(key:  essenceNode, value:  UnityEngine.Time.time);
            UnityEngine.GameObject val_2 = this.<_essenceVisualsParent>k__BackingField.ObtainAvailableMoteParent();
            UnityEngine.Vector3 val_6 = essenceNode.EssenceVisual.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_9 = essenceNode.EssenceVisual.transform.localScale;
            val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_12 = UnityEngine.Random.rotation;
            val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            Game.EssenceCollection.Visuals.MoteVisual val_15 = this.<_essenceVisualsParent>k__BackingField.ObtainAvailableMoteOfType(motePrefab:  essenceNode.EssenceVisual.MotePrefab);
            val_15.transform.parent = val_2.transform;
            MOTEOVERRIDES val_19 = essenceNode.EssenceTypesEntry.MoteOverrides;
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
            if(((-726091344) & 1) != 0)
            {
                    val_30 = (float)0.South;
            }
            
            MOTEOVERRIDES val_24 = essenceNode.EssenceTypesEntry.MoteOverrides;
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
            this.<_allMotes>k__BackingField.AddMote(essenceNode:  essenceNode, moteParent:  val_2, mote:  val_15);
            this.<_audioPlayer>k__BackingField.TriggerMoteSpawned(essenceNode:  essenceNode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshKnownEssences()
        {
            var val_4;
            HashSet.Enumerator<T> val_2 = this._essencesThatAreSpawning.GetEnumerator();
            label_6:
            if(((-725831872) & 1) == 0)
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
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525355851584});
            HashSet.Enumerator<T> val_10 = this._oldEssences.GetEnumerator();
            label_15:
            if(((-725831872) & 1) == 0)
            {
                goto label_13;
            }
            
            bool val_12 = this._essencesThatAreSpawning.Remove(item:  val_4.emailUIDataHandler);
            goto label_15;
            label_13:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525355851584});
            this._oldEssences.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanUpOldSpawnTimes()
        {
            var val_4;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this._lastSpawnTimestampForEssence.Keys.GetEnumerator();
            label_6:
            if(((-725642032) & 1) == 0)
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
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525356041424});
            HashSet.Enumerator<T> val_10 = this._oldEssences.GetEnumerator();
            label_15:
            if(((-725642056) & 1) == 0)
            {
                goto label_13;
            }
            
            bool val_12 = this._lastSpawnTimestampForEssence.Remove(key:  0.emailUIDataHandler);
            goto label_15;
            label_13:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525356041400});
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
            if(((-725476744) & 1) == 0)
            {
                goto label_5;
            }
            
            this.UpdateSpawningFor(essenceNode:  0.emailUIDataHandler);
            goto label_6;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525356206712});
            this.CleanUpOldSpawnTimes();
        }
    
    }

}
