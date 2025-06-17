using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardDropData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop Currency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop Items;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss Penalty;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardDropData()
        {
            this.Currency = new Game.ItemDefinition.Data.DataDefinitions.RewardCurrencyDrop();
            this.Items = new Game.ItemDefinition.Data.DataDefinitions.RewardItemDrop();
            this.Penalty = new Game.ItemDefinition.Data.DataDefinitions.EssenceOnLoss();
        }
    
    }

}
