using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardCellBuilder
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardCell rewardCellPrefab;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardCellBuilder(GameUI.RewardCell rewardCellPrefab)
        {
            this.rewardCellPrefab = rewardCellPrefab;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.RewardCell CreateRewardCell(GameUI.ItemUIDescription itemUiDescription, UnityEngine.Transform rewardCellsParent)
        {
            GameUI.RewardCell val_1 = UnityEngine.Object.Instantiate<GameUI.RewardCell>(original:  this.rewardCellPrefab, parent:  rewardCellsParent);
            val_1.SetData(itemUiDescription:  itemUiDescription);
            val_1.SetSprite(sprite:  itemUiDescription.sprite);
            return val_1;
        }
    
    }

}
