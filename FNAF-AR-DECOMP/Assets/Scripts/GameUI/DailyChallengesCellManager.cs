using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengesCellManager
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.DailyChallengesCell> _dailyChallengeCells;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshCellsData(GameUI.DailyChallengesDisplayHandler.LoadData data)
        {
            this.GenerateCells(data:  new LoadData());
            this.SetCellData(data:  new LoadData());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshCellIcons(GameUI.DailyChallengesDisplayHandler.LoadData data, Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this.SetCellIcons(data:  new LoadData(), iconLookup:  iconLookup);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateCells(GameUI.DailyChallengesDisplayHandler.LoadData data)
        {
            var val_10;
            System.Collections.Generic.List<GameUI.DailyChallengesCell> val_11;
            var val_12;
            val_10 = 1152921524824846336;
            this.ClearCells();
            if(this._dailyChallengeCells == null)
            {
                    this._dailyChallengeCells = new System.Collections.Generic.List<GameUI.DailyChallengesCell>();
            }
            
            val_11 = data.dailyChallengesContainer.ActiveChallenges.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = val_11.GetEnumerator();
            val_12 = 0;
            goto label_5;
            label_11:
            GameUI.EmailUIDataHandler val_5 = 0.emailUIDataHandler;
            val_11 = this._dailyChallengeCells;
            if(val_11.Count <= val_12)
            {
                    val_11 = UnityEngine.Object.Instantiate<GameUI.DailyChallengesCell>(original:  data.dailyChallengesCellPrefab, parent:  data.dailyChallengesCellParent);
                this._dailyChallengeCells.Add(item:  val_11);
            }
            
            val_12 = 1;
            label_5:
            if(((-1256881240) & 1) != 0)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCellData(GameUI.DailyChallengesDisplayHandler.LoadData data)
        {
            var val_5;
            Game.DailyChallenge.Data.DailyChallengeData val_12;
            var val_13 = this;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = data.dailyChallengesContainer.ActiveChallenges.Values.GetEnumerator();
            goto label_4;
            label_10:
            val_12 = val_5.emailUIDataHandler;
            if(this._dailyChallengeCells.Count > 0)
            {
                    new GameUI.DailyChallengesCellData() = new System.Object();
                .dcData = val_12;
                this._dailyChallengeCells.Item[0].SetData(data:  new GameUI.DailyChallengesCellData());
            }
            
            label_4:
            if(((-1256567456) & 1) != 0)
            {
                goto label_10;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCellIcons(GameUI.DailyChallengesDisplayHandler.LoadData data, Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            var val_5;
            var val_13;
            var val_14;
            string val_15;
            val_13 = iconLookup;
            val_14 = 1152921524825468832;
            if(val_13 == null)
            {
                    return;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = data.dailyChallengesContainer.ActiveChallenges.Values.GetEnumerator();
            val_14 = 0;
            goto label_5;
            label_15:
            val_15 = val_5.emailUIDataHandler;
            if(this._dailyChallengeCells.Count > val_14)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_15 = val_13.GetIcon(group:  8, name:  val_15);
                this._dailyChallengeCells.Item[0].SetSprite(sprite:  val_15);
            }
            
            val_14 = 1;
            label_5:
            if(((-1256258752) & 1) != 0)
            {
                goto label_15;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearCells()
        {
            if(this._dailyChallengeCells == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this._dailyChallengeCells.GetEnumerator();
            label_6:
            if(((-1256018648) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Object.Destroy(obj:  0.emailUIDataHandler.gameObject);
            goto label_6;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524825664808});
            if(this._dailyChallengeCells == null)
            {
                    return;
            }
            
            this._dailyChallengeCells.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengesCellManager()
        {
        
        }
    
    }

}
