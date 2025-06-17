using UnityEngine;

namespace Game.EssenceCollection.Actions.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNodeDespawner
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.EssenceCollectionDomain <_essenceCollectionDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.EssenceNodes.EssenceNodes <_essenceNodes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.AttackSequenceDomain <_attackSequenceDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Data.Particles.AllMotes <_allMotes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _gameDisplayChanger;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.EssenceCollectionDomain _essenceCollectionDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes _essenceNodes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain _attackSequenceDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes _allMotes { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.EssenceCollectionDomain get__essenceCollectionDomain()
        {
            return (Game.EssenceCollection.EssenceCollectionDomain)this.<_essenceCollectionDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.EssenceNodes.EssenceNodes get__essenceNodes()
        {
            return (Game.EssenceCollection.Data.EssenceNodes.EssenceNodes)this.<_essenceNodes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.AttackSequenceDomain get__attackSequenceDomain()
        {
            return (Game.AttackSequence.AttackSequenceDomain)this.<_attackSequenceDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Data.Particles.AllMotes get__allMotes()
        {
            return (Game.EssenceCollection.Data.Particles.AllMotes)this.<_allMotes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNodeDespawner(Game.EssenceCollection.EssenceCollectionDomain essenceCollectionDomain, Game.EssenceCollection.Data.EssenceNodes.EssenceNodes essenceNodes, Game.AttackSequence.AttackSequenceDomain attackSequenceDomain, Game.EssenceCollection.Data.Particles.AllMotes allMotes, TheGame.GameDisplayChanger gameDisplayChanger)
        {
            val_1 = new System.Object();
            this.<_essenceCollectionDomain>k__BackingField = essenceCollectionDomain;
            this.<_essenceNodes>k__BackingField = val_1;
            this.<_attackSequenceDomain>k__BackingField = attackSequenceDomain;
            this.<_allMotes>k__BackingField = allMotes;
            this._gameDisplayChanger = gameDisplayChanger;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DespawnAllEssenceNodes(Game.EssenceCollection.Data.EssenceNodes.EssenceNode[] essenceNodesArray)
        {
            goto label_0;
            label_4:
            this.<_essenceNodes>k__BackingField.DespawnEssenceNode(essenceNode:  essenceNodesArray[0]);
            0 = 1;
            label_0:
            if(0 < essenceNodesArray.Length)
            {
                goto label_4;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ShouldDespawnAllEssenceNodes()
        {
            TheGame.GameDisplayChanger val_5;
            var val_6;
            val_5 = this;
            if((this.<_attackSequenceDomain>k__BackingField.IsInEncounter()) != true)
            {
                    if((this.<_essenceCollectionDomain>k__BackingField.RewardsFlowActive) == false)
            {
                goto label_3;
            }
            
            }
            
            val_6 = 1;
            goto label_4;
            label_3:
            val_5 = this._gameDisplayChanger;
            bool val_3 = val_5.IsDisplayType(displayType:  1);
            val_6 = val_3 ^ 1;
            label_4:
            val_3 = val_6;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.ShouldDespawnAllEssenceNodes() == false)
            {
                    return;
            }
            
            this.DespawnAllEssenceNodes(essenceNodesArray:  System.Linq.Enumerable.ToArray<Game.EssenceCollection.Data.EssenceNodes.EssenceNode>(source:  this.<_essenceNodes>k__BackingField.CurrentEssences));
        }
    
    }

}
