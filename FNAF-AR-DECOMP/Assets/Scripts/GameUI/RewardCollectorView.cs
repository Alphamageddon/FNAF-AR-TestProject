using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardCollectorView
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int uncollectedFazTokens;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int totalCollectionAmount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float totalCollectionTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool collectRewards;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SimpleTimer collectionTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardCollectorView(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
            this.uncollectedFazTokens = 0;
            this.totalCollectionAmount = 0;
            this.collectRewards = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetTotalCurrencyOnWin(System.Collections.Generic.List<Game.TheGame.Data.RewardItem> currencyList)
        {
            var val_5;
            List.Enumerator<T> val_1 = currencyList.GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_4:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            label_2:
            if(((-1138943016) & 1) != 0)
            {
                goto label_4;
            }
            
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524942740440});
            return 1152921505240924160;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateFazTokenCollection()
        {
            this.UpdateUncollectedFazTokens();
            if(this.uncollectedFazTokens > 0)
            {
                    return;
            }
            
            this.collectionTimer = 0;
            this.collectRewards = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateUncollectedFazTokens()
        {
            int val_4;
            if(this.uncollectedFazTokens < 1)
            {
                    return;
            }
            
            float val_2 = this.collectionTimer.GetRemainingTime() / this.totalCollectionTime;
            if(val_2 > 0f)
            {
                    float val_4 = (float)this.totalCollectionAmount;
                val_4 = val_2 * val_4;
                val_4 = 0;
                int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_4);
            }
            else
            {
                    val_4 = 0;
            }
            
            this.uncollectedFazTokens = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetUncollectedFazTokensTotal()
        {
            return (int)this.uncollectedFazTokens;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool GetIsCollectingRewards()
        {
            return (bool)this.collectRewards;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetRewardsData(Game.TheGame.Data.RewardData data)
        {
            this.uncollectedFazTokens = this.GetTotalCurrencyOnWin(currencyList:  data.currencyList);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CollectRewards(float collectionTime)
        {
            this.totalCollectionTime = collectionTime;
            this.collectRewards = true;
            this.totalCollectionAmount = this.uncollectedFazTokens;
            SimpleTimer val_1 = new SimpleTimer();
            this.collectionTimer = val_1;
            val_1.StartTimer(time:  collectionTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.collectRewards == false)
            {
                    return;
            }
            
            this.UpdateUncollectedFazTokens();
            if(this.uncollectedFazTokens > 0)
            {
                    return;
            }
            
            this.collectionTimer = 0;
            this.collectRewards = false;
        }
    
    }

}
