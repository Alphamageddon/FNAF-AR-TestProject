using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PossibleRewardsCellManager : UICellManager<GameUI.PossibleRewardsCell, ICellInterface<GameUI.PossibleRewardsCellData>, GameUI.PossibleRewardsCellData>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GeneratePossibleRewardsCells(GameUI.DailyChallengesDisplayHandler.LoadData loadData)
        {
            this.GenerateCells(prefab:  loadData.possibleRewardsCellPrefab, parent:  loadData.possibleRewardsCellParent, numCells:  loadData.dailyChallengesContainer.Rewards.Count);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshDisplayContent(GameUI.DailyChallengesDisplayHandler.LoadData loadData)
        {
            var val_5;
            object val_13;
            var val_14 = this;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = loadData.dailyChallengesContainer.Rewards.Values.GetEnumerator();
            goto label_4;
            label_16:
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            Game.DailyChallenge.Data.DailyChallengeRewardItem val_7 = val_6._emailIdsToBeDeletedOnServer.Item[0];
            val_13 = new GameUI.PossibleRewardsCellData();
            val_13 = new System.Object();
            .quantity = val_7.Quantity;
            Game.Localization.LocalizationDomain val_9 = Game.Localization.LocalizationDomain.Instance;
            var val_14 = 0;
            val_14 = val_14 + 1;
            .name = val_9.ILocalization.GetLocalizedString(localizedStringId:  val_7.LocRef, originalString:  val_7.LocRef);
            this.SetData(data:  new GameUI.PossibleRewardsCellData(), index:  0);
            label_4:
            if(((-1231633808) & 1) != 0)
            {
                goto label_16;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshDisplayIcons(GameUI.DailyChallengesDisplayHandler.LoadData loadData, Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            var val_5;
            var val_11;
            var val_12;
            val_11 = iconLookup;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = loadData.dailyChallengesContainer.Rewards.Values.GetEnumerator();
            val_12 = 0;
            goto label_4;
            label_13:
            GameUI.EmailUIDataHandler val_6 = val_5.emailUIDataHandler;
            Game.DailyChallenge.Data.DailyChallengeRewardItem val_7 = val_6._emailIdsToBeDeletedOnServer.Item[0];
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.SetIcon(icon:  val_11.GetIcon(group:  4, name:  val_7.IconRef), index:  0);
            val_12 = 1;
            label_4:
            if(((-1231311776) & 1) != 0)
            {
                goto label_13;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PossibleRewardsCellManager()
        {
        
        }
    
    }

}
