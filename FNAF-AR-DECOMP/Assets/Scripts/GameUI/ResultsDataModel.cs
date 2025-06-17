using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ResultsDataModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <resultDirty>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Encounters.EncounterResult <encounterResult>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.RewardDataV3 <rewardDataV3>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool resultDirty { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Encounters.EncounterResult encounterResult { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 rewardDataV3 { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ResultsDataModel(Master.MasterDomain masterDomain)
        {
            this.masterDomain = masterDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_resultDirty(bool value)
        {
            this.<resultDirty>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_resultDirty()
        {
            return (bool)this.<resultDirty>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_encounterResult(Game.AttackSequence.Encounters.EncounterResult value)
        {
            this.<encounterResult>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Encounters.EncounterResult get_encounterResult()
        {
            return (Game.AttackSequence.Encounters.EncounterResult)this.<encounterResult>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_rewardDataV3(Game.TheGame.Data.RewardDataV3 value)
        {
            this.<rewardDataV3>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.RewardDataV3 get_rewardDataV3()
        {
            return (Game.TheGame.Data.RewardDataV3)this.<rewardDataV3>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEncounterResult(Game.AttackSequence.Encounters.EncounterResult result, Game.TheGame.Data.RewardDataV3 rewardDataV3)
        {
            this.<resultDirty>k__BackingField = true;
            this.<encounterResult>k__BackingField = result;
            this.<rewardDataV3>k__BackingField = rewardDataV3;
            this.masterDomain.eventExposer.OnResultsDataUpdated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CleanEncounterResult()
        {
            this.<rewardDataV3>k__BackingField = 0;
            this.<resultDirty>k__BackingField = false;
        }
    
    }

}
