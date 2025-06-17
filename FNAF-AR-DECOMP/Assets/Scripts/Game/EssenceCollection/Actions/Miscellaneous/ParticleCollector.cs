using UnityEngine;

namespace Game.EssenceCollection.Actions.Miscellaneous
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ParticleCollector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllThreatPills <_allThreatPills>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer <_audioPlayer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner <_moteSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner <_threatPillSpawner>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedEssence <_collectedEssence>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Collected.CollectedThreat <_collectedThreat>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum <_particleVacuum>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.Server.ServerDomain <_serverDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo> _motesToCollect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo> _threatPillsToCollect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _motesIdBatch;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _timeLastMoteCollected;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _nextTimeCanCollectMotes;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllThreatPills _allThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer _audioPlayer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner _moteSpawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner _threatPillSpawner { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedEssence _collectedEssence { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Collected.CollectedThreat _collectedThreat { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum _particleVacuum { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
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
        private Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer get__audioPlayer()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer)this.<_audioPlayer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner get__moteSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner)this.<_moteSpawner>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner get__threatPillSpawner()
        {
            return (Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner)this.<_threatPillSpawner>k__BackingField;
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
        private Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum get__particleVacuum()
        {
            return (Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum)this.<_particleVacuum>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain get__serverDomain()
        {
            return (Game.Server.ServerDomain)this.<_serverDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ParticleCollector(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector, Game.EssenceCollection.Data.Particles.AllMotes allMotes, Game.EssenceCollection.Data.Particles.AllThreatPills allThreatPills, Game.EssenceCollection.Actions.Miscellaneous.AudioPlayer audioPlayer, Game.EssenceCollection.Actions.Particles.Motes.MoteSpawner moteSpawner, Game.EssenceCollection.Actions.Particles.ThreatPills.ThreatPillSpawner threatPillSpawner, Game.EssenceCollection.Data.Collected.CollectedEssence collectedEssence, Game.EssenceCollection.Data.Collected.CollectedThreat collectedThreat, Game.EssenceCollection.Actions.Miscellaneous.ParticleVacuum particleVacuum, Game.Server.ServerDomain serverDomain)
        {
            this._motesToCollect = new System.Collections.Generic.List<MoteSpawnInfo>();
            this._threatPillsToCollect = new System.Collections.Generic.List<ThreatPillSpawnInfo>();
            this._motesIdBatch = new System.Collections.Generic.List<System.String>();
            val_4 = new System.Object();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
            this.<_allMotes>k__BackingField = val_4;
            this.<_allThreatPills>k__BackingField = allThreatPills;
            this.<_audioPlayer>k__BackingField = audioPlayer;
            this.<_moteSpawner>k__BackingField = moteSpawner;
            this.<_threatPillSpawner>k__BackingField = threatPillSpawner;
            this.<_particleVacuum>k__BackingField = particleVacuum;
            this.<_serverDomain>k__BackingField = serverDomain;
            this.<_collectedEssence>k__BackingField = collectedEssence;
            this.<_collectedThreat>k__BackingField = collectedThreat;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CollectCloseParticles()
        {
            if((this.<_particleVacuum>k__BackingField.IsInitialized()) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.<_particleVacuum>k__BackingField.GetPositionToSuckTo();
            this.CollectCloseMotes(suckToPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.CollectCloseThreatPills(suckToPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CollectCloseMotes(UnityEngine.Vector3 suckToPosition)
        {
            var val_9;
            var val_21;
            MoteSpawnInfo val_22;
            var val_23;
            float val_24;
            var val_25;
            var val_26;
            val_21 = 0;
            goto label_2;
            label_12:
            val_22 = this.<_allMotes>k__BackingField.GetAllMotesForEssence(essenceNode:  this.<_allMotes>k__BackingField.GetAllEssences()[0]);
            val_23 = 0;
            goto label_5;
            label_10:
            MoteSpawnInfo val_22 = val_22[0];
            val_24 = suckToPosition.x;
            if((this.IsMoteCloseEnoughToCollect(moteSpawnInfo:  val_22, suckToPosition:  new UnityEngine.Vector3() {x = val_24, y = suckToPosition.y, z = suckToPosition.z})) != false)
            {
                    this._motesToCollect.Add(item:  val_22);
            }
            
            val_23 = 1;
            label_5:
            if(val_23 < val_2.Length)
            {
                goto label_10;
            }
            
            val_21 = 1;
            label_2:
            if(val_21 < val_1.Length)
            {
                goto label_12;
            }
            
            val_25 = 0;
            goto label_14;
            label_19:
            val_22 = this.<_allMotes>k__BackingField.GetDetachedMotes()[0];
            val_24 = suckToPosition.x;
            if((this.IsMoteCloseEnoughToCollect(moteSpawnInfo:  val_22, suckToPosition:  new UnityEngine.Vector3() {x = val_24, y = suckToPosition.y, z = suckToPosition.z})) != false)
            {
                    this._motesToCollect.Add(item:  val_22);
            }
            
            val_25 = 1;
            label_14:
            if(val_25 < val_4.Length)
            {
                goto label_19;
            }
            
            if(this._motesToCollect.Count >= 1)
            {
                    this.<_audioPlayer>k__BackingField.TriggerMoteAbsorbed();
            }
            
            List.Enumerator<T> val_7 = this._motesToCollect.GetEnumerator();
            var val_23 = 0;
            label_43:
            if(((-717060544) & 1) == 0)
            {
                goto label_24;
            }
            
            this.<_moteSpawner>k__BackingField.DespawnMote(moteSpawnInfo:  val_9.emailUIDataHandler);
            ENTRY val_11 = val_10._masterDomain.EssenceTypesEntry;
            if(val_11 != null)
            {
                    MOTEOVERRIDES val_13 = (val_11 == 0) ? 0 : (val_11).MoteOverrides;
                if(val_13 != null)
            {
                    SPAWNBEHAVIOR val_15 = (val_13 == 0) ? (val_23) : (val_13).SpawnBehavior;
                val_23 = (val_15 == 0) ? 0 : (val_15);
                if(val_15 != null)
            {
                    double val_16 = val_23.EssencePerMote;
                val_9 = 0;
            }
            
            }
            
            }
            
            if(((-717060560) & 1) != 0)
            {
                    val_9 = 0;
                val_24 = (float)0.South;
                val_26 = val_9;
            }
            else
            {
                    val_26 = 0;
            }
            
            if(((-717060504) & 1) != 0)
            {
                    this.<_collectedEssence>k__BackingField.AddEssence(newEssence:  0);
            }
            else
            {
                    this.<_collectedEssence>k__BackingField.AddEssence(newEssence:  1);
            }
            
            this.AddEssenceNodeToCollect(moteId:  val_10._masterDomain.CollectMoteFromPool());
            goto label_43;
            label_24:
            long val_19 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525364622912});
            this._motesToCollect.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddEssenceNodeToCollect(string moteId)
        {
            if((System.String.IsNullOrEmpty(value:  moteId)) == true)
            {
                    return;
            }
            
            this._motesIdBatch.Add(item:  moteId);
            System.DateTimeOffset val_2 = System.DateTimeOffset.Now;
            float val_4 = this.<_masterDataConnector>k__BackingField.Mote_CollectTimeToWaitToSeeIfMoreMotesComingIn;
            val_4 = val_4 * 1000f;
            long val_5 = (long)val_4;
            val_5 = val_2.m_dateTime.dateData.ToUnixTimeMilliseconds() + val_5;
            this._timeLastMoteCollected = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AttemptToCollectMotes(long currentTime)
        {
            if(this._motesIdBatch.Count < 1)
            {
                    return;
            }
            
            if(this._timeLastMoteCollected >= currentTime)
            {
                    return;
            }
            
            if(this._nextTimeCanCollectMotes >= currentTime)
            {
                    return;
            }
            
            this.FlushEssenceNodesToCollect(currentTimeSeconds:  currentTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FlushEssenceNodesToCollect(long currentTimeSeconds)
        {
            float val_1 = this.<_masterDataConnector>k__BackingField.Mote_CollectionFlushBatchTime;
            val_1 = val_1 * 1000f;
            long val_2 = (long)val_1;
            val_2 = val_2 + currentTimeSeconds;
            this._nextTimeCanCollectMotes = val_2;
            this.<_serverDomain>k__BackingField.essenceNodeCollectRequester.Collect(motesCollectedList:  this._motesIdBatch);
            this._motesIdBatch.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsMoteCloseEnoughToCollect(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo, UnityEngine.Vector3 suckToPosition)
        {
            UnityEngine.Vector3 val_2 = moteSpawnInfo.Mote.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z});
            return (bool)(val_3.x <= (this.<_masterDataConnector>k__BackingField.ParticleVacuum_CollectDistanceMote)) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CollectCloseThreatPills(UnityEngine.Vector3 suckToPosition)
        {
            var val_11;
            ThreatPillSpawnInfo val_12;
            var val_13;
            var val_14;
            val_11 = 0;
            goto label_2;
            label_12:
            val_12 = this.<_allThreatPills>k__BackingField.GetAllThreatPillsForEssence(essenceNode:  this.<_allThreatPills>k__BackingField.GetAllEssences()[0]);
            val_13 = 0;
            goto label_5;
            label_10:
            ThreatPillSpawnInfo val_12 = val_12[0];
            if((this.IsThreatPillCloseEnoughToCollect(threatPillSpawnInfo:  val_12, suckToPosition:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z})) != false)
            {
                    this._threatPillsToCollect.Add(item:  val_12);
            }
            
            val_13 = 1;
            label_5:
            if(val_13 < val_2.Length)
            {
                goto label_10;
            }
            
            val_11 = 1;
            label_2:
            if(val_11 < val_1.Length)
            {
                goto label_12;
            }
            
            val_14 = 0;
            goto label_14;
            label_19:
            val_12 = this.<_allThreatPills>k__BackingField.GetDetachedThreatPills()[0];
            if((this.IsThreatPillCloseEnoughToCollect(threatPillSpawnInfo:  val_12, suckToPosition:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z})) != false)
            {
                    this._threatPillsToCollect.Add(item:  val_12);
            }
            
            val_14 = 1;
            label_14:
            if(val_14 < val_4.Length)
            {
                goto label_19;
            }
            
            if(this._threatPillsToCollect.Count >= 1)
            {
                    this.<_audioPlayer>k__BackingField.TriggerThreatPillAbsorbed();
            }
            
            List.Enumerator<T> val_7 = this._threatPillsToCollect.GetEnumerator();
            label_27:
            if(((-716016168) & 1) == 0)
            {
                goto label_24;
            }
            
            this.<_threatPillSpawner>k__BackingField.DespawnThreatPill(threatPillSpawnInfo:  0.emailUIDataHandler);
            this.<_collectedThreat>k__BackingField.AddThreat(newThreatPills:  1);
            goto label_27;
            label_24:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525365667288});
            this._threatPillsToCollect.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsThreatPillCloseEnoughToCollect(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo, UnityEngine.Vector3 suckToPosition)
        {
            UnityEngine.Vector3 val_2 = threatPillSpawnInfo.ThreatPill.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = suckToPosition.x, y = suckToPosition.y, z = suckToPosition.z});
            return (bool)(val_3.x <= (this.<_masterDataConnector>k__BackingField.ParticleVacuum_CollectDistanceThreat)) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.CollectCloseParticles();
            System.DateTimeOffset val_1 = System.DateTimeOffset.Now;
            this.AttemptToCollectMotes(currentTime:  val_1.m_dateTime.dateData.ToUnixTimeMilliseconds());
        }
    
    }

}
