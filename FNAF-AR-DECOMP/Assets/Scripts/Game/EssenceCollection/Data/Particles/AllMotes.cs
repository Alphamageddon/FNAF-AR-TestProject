using UnityEngine;

namespace Game.EssenceCollection.Data.Particles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AllMotes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.MasterDataConnector <_masterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo>> _motesByEssence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo> _detachedMotes;
        
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
        public AllMotes(Game.EssenceCollection.Data.MasterDataConnector masterDataConnector)
        {
            this._motesByEssence = new System.Collections.Generic.Dictionary<Game.EssenceCollection.Data.EssenceNodes.EssenceNode, System.Collections.Generic.List<MoteSpawnInfo>>();
            this._detachedMotes = new System.Collections.Generic.List<MoteSpawnInfo>();
            this.<_masterDataConnector>k__BackingField = masterDataConnector;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddMote(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode, UnityEngine.GameObject moteParent, Game.EssenceCollection.Visuals.MoteVisual mote)
        {
            float val_18;
            float val_19;
            AllMotes.MoteSpawnInfo val_1 = new AllMotes.MoteSpawnInfo();
            if(val_1 != null)
            {
                    .EssenceNode = essenceNode;
                .MoteParent = moteParent;
            }
            else
            {
                    mem[16] = essenceNode;
                mem[24] = moteParent;
            }
            
            .Mote = mote;
            MOTEOVERRIDES val_2 = essenceNode.<EssenceTypesEntry>k__BackingField.MoteOverrides;
            if(val_2 == null)
            {
                goto label_6;
            }
            
            SPAWNBEHAVIOR val_3 = val_2.SpawnBehavior;
            if(val_3 == null)
            {
                goto label_6;
            }
            
            double val_4 = val_3.MoteLifetime;
            goto label_7;
            label_6:
            label_7:
            val_18 = 0f;
            if(((-752688672) & 1) != 0)
            {
                    val_18 = (float)0.South;
            }
            
            .DegradeTimeLeft = val_18;
            MOTEOVERRIDES val_6 = essenceNode.<EssenceTypesEntry>k__BackingField.MoteOverrides;
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
            if(((-752688672) & 1) != 0)
            {
                    val_19 = (float)0.South;
            }
            
            MOTEOVERRIDES val_10 = essenceNode.<EssenceTypesEntry>k__BackingField.MoteOverrides;
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
            .MoteOrbitParams = UnityEngine.Random.Range(min:  val_19, max:  (float)0.South);
            if((this._motesByEssence.ContainsKey(key:  essenceNode)) != true)
            {
                    this._motesByEssence.Add(key:  essenceNode, value:  new System.Collections.Generic.List<MoteSpawnInfo>());
            }
            
            this._motesByEssence.Item[essenceNode].Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveMote(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            Game.EssenceCollection.Data.EssenceNodes.EssenceNode val_4 = moteSpawnInfo.EssenceNode;
            if(val_4 != null)
            {
                    val_4 = this._motesByEssence.Item[val_4];
                if((val_4.Remove(item:  moteSpawnInfo)) != false)
            {
                    return;
            }
            
            }
            
            bool val_3 = this._detachedMotes.Remove(item:  moteSpawnInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DetachMote(Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo moteSpawnInfo)
        {
            bool val_2 = this._motesByEssence.Item[moteSpawnInfo.EssenceNode].Remove(item:  moteSpawnInfo);
            this._detachedMotes.Add(item:  moteSpawnInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.EssenceNodes.EssenceNode[] GetAllEssences()
        {
            return System.Linq.Enumerable.ToArray<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(source:  this._motesByEssence.Keys);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo[] GetAllMotesForEssence(Game.EssenceCollection.Data.EssenceNodes.EssenceNode essenceNode)
        {
            Game.EssenceCollection.Data.EssenceNodes.EssenceNode val_5 = essenceNode;
            if((this._motesByEssence.ContainsKey(key:  val_5 = essenceNode)) == false)
            {
                    return (MoteSpawnInfo[])System.Array.Empty<MoteSpawnInfo>();
            }
            
            val_5 = this._motesByEssence.Item[val_5];
            T[] val_3 = val_5.ToArray();
            return (MoteSpawnInfo[])System.Array.Empty<MoteSpawnInfo>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Data.Particles.AllMotes.MoteSpawnInfo[] GetDetachedMotes()
        {
            if(this._detachedMotes != null)
            {
                    return this._detachedMotes.ToArray();
            }
            
            return this._detachedMotes.ToArray();
        }
    
    }

}
