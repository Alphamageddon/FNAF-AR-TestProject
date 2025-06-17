using UnityEngine;

namespace Game.EssenceCollection.Data.Particles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AllThreatPills
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo>> _threatPillsByEssence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo> _detachedThreatPills;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector _masterDataConnector { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.MasterDataConnector get__masterDataConnector()
        {
            return (Game.EssenceCollection.Data.MasterDataConnector)this.<_masterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AllThreatPills(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector)
        {
            this._threatPillsByEssence = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Collections.Generic.List<ThreatPillSpawnInfo>>();
            this._detachedThreatPills = new System.Collections.Generic.List<ThreatPillSpawnInfo>();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddThreatPill(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode, UnityEngine.GameObject threatPillParent, Game.EssenceCollection.Visuals.ThreatPillVisual threatPill)
        {
            float val_18;
            float val_19;
            AllThreatPills.ThreatPillSpawnInfo val_1 = new AllThreatPills.ThreatPillSpawnInfo();
            if(val_1 != null)
            {
                    .EssenceNode = essenceNode;
                .ThreatPillParent = threatPillParent;
            }
            else
            {
                    mem[16] = essenceNode;
                mem[24] = threatPillParent;
            }
            
            .ThreatPill = threatPill;
            THREATPILLOVERRIDES val_2 = essenceNode.<EssenceTypesEntry>k__BackingField.ThreatPillOverrides;
            if(val_2 == null)
            {
                goto label_6;
            }
            
            SPAWNBEHAVIOR val_3 = val_2.SpawnBehavior;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            double val_4 = val_3.ThreatPillLifetime;
            goto label_7;
            label_6:
            label_7:
            val_18 = 0f;
            if(((-751202464) & 1) != 0)
            {
                    val_18 = (float)0.South;
            }
            
            .DegradeTimeLeft = val_18;
            THREATPILLOVERRIDES val_6 = essenceNode.<EssenceTypesEntry>k__BackingField.ThreatPillOverrides;
            if(val_6 == null)
            {
                goto label_11;
            }
            
            SPAWNBEHAVIOR val_7 = val_6.SpawnBehavior;
            if(val_7 == null)
            {
                goto label_11;
            }
            
            double val_8 = val_7.MinAngleSpeedDegrees;
            goto label_12;
            label_11:
            label_12:
            val_19 = 0f;
            if(((-751202464) & 1) != 0)
            {
                    val_19 = (float)0.South;
            }
            
            THREATPILLOVERRIDES val_10 = essenceNode.<EssenceTypesEntry>k__BackingField.ThreatPillOverrides;
            if(val_10 == null)
            {
                goto label_16;
            }
            
            SPAWNBEHAVIOR val_11 = val_10.SpawnBehavior;
            if(val_11 == null)
            {
                goto label_16;
            }
            
            double val_12 = val_11.MaxAngleSpeedDegrees;
            goto label_17;
            label_16:
            label_17:
            .ThreatPillOrbitParams = UnityEngine.Random.Range(min:  val_19, max:  (float)0.South);
            if((this._threatPillsByEssence.ContainsKey(key:  essenceNode)) != true)
            {
                    this._threatPillsByEssence.Add(key:  essenceNode, value:  new System.Collections.Generic.List<ThreatPillSpawnInfo>());
            }
            
            this._threatPillsByEssence.Item[essenceNode].Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveThreatPill(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            Game.EssenceCollection.Data.EssenceNodes.EssenceNode val_4 = threatPillSpawnInfo.EssenceNode;
            if(val_4 != null)
            {
                    val_4 = this._threatPillsByEssence.Item[val_4];
                if((val_4.Remove(item:  threatPillSpawnInfo)) != false)
            {
                    return;
            }
            
            }
            
            bool val_3 = this._detachedThreatPills.Remove(item:  threatPillSpawnInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DetachThreatPill(Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo threatPillSpawnInfo)
        {
            bool val_2 = this._threatPillsByEssence.Item[threatPillSpawnInfo.EssenceNode].Remove(item:  threatPillSpawnInfo);
            this._detachedThreatPills.Add(item:  threatPillSpawnInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.EssenceNodes.EssenceNode[] GetAllEssences()
        {
            return System.Linq.Enumerable.ToArray<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(source:  this._threatPillsByEssence.Keys);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo[] GetAllThreatPillsForEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            Game.EssenceCollection.Data.EssenceNodes.EssenceNode val_5 = essenceNode;
            if((this._threatPillsByEssence.ContainsKey(key:  val_5 = essenceNode)) == false)
            {
                    return (ThreatPillSpawnInfo[])System.Array.Empty<ThreatPillSpawnInfo>();
            }
            
            val_5 = this._threatPillsByEssence.Item[val_5];
            T[] val_3 = val_5.ToArray();
            return (ThreatPillSpawnInfo[])System.Array.Empty<ThreatPillSpawnInfo>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllThreatPills.ThreatPillSpawnInfo[] GetDetachedThreatPills()
        {
            if(this._detachedThreatPills != null)
            {
                    return this._detachedThreatPills.ToArray();
            }
            
            return this._detachedThreatPills.ToArray();
        }
    
    }

}
