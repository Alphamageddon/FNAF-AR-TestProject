using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LeaderboardTabHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.LeaderboardTabData leaderboardTabData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameUI.LeaderboardCell> leaderboardCells;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_BestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> leaderboard)
        {
            this.ClearLeaderboard();
            this.GenerateLeaderboard(leaderboard:  leaderboard);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateLeaderboard(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> leaderboard)
        {
            var val_6 = this;
            List.Enumerator<T> val_1 = leaderboard.GetEnumerator();
            label_4:
            if(((-1244109432) & 1) == 0)
            {
                goto label_2;
            }
            
            this.leaderboardCells.Add(item:  this.BuildLeaderboardCell(leaderboardEntry:  0.emailUIDataHandler));
            goto label_4;
            label_2:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524837574024});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.LeaderboardCell BuildLeaderboardCell(TheGame.Data.LeaderboardEntry leaderboardEntry)
        {
            GameUI.LeaderboardTabData val_11;
            IntPtr val_12;
            LeaderboardTabHandler.<>c__DisplayClass5_0 val_1 = new LeaderboardTabHandler.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .leaderboardEntry = leaderboardEntry;
            val_11 = this.leaderboardTabData;
            if(this.leaderboardTabData != null)
            {
                goto label_3;
            }
            
            val_11 = this.leaderboardTabData;
            if(val_11 == null)
            {
                goto label_4;
            }
            
            label_3:
            GameUI.LeaderboardCell val_2 = UnityEngine.Object.Instantiate<GameUI.LeaderboardCell>(original:  this.leaderboardTabData.leaderboardCellPrefab, parent:  this.leaderboardTabData.cellParent);
            .leaderboardEntry = (LeaderboardTabHandler.<>c__DisplayClass5_0)[1152921524837847872].leaderboardEntry;
            Server.LoginDomain val_5 = this._masterDomain.theGameDomain.loginDomain;
            .isPlayer = System.String.op_Equality(a:  (LeaderboardTabHandler.<>c__DisplayClass5_0)[1152921524837847872].leaderboardEntry.userId, b:  val_5.playerProfile.userId);
            val_2.SetData(item:  new GameUI.LeaderboardCellData());
            GameUI.Domain val_8 = this._masterDomain.gameUIDomain;
            if((GameUI.LeaderboardCellData)[1152921524837872448].isPlayer != false)
            {
                    val_12 = 1152921524837777536;
            }
            else
            {
                    val_12 = 1152921524837778560;
            }
            
            System.Predicate<GameUI.ProfileAvatarSet> val_9 = new System.Predicate<GameUI.ProfileAvatarSet>(object:  val_1, method:  val_12);
            if((val_8.profileAvatarConfigs.Find(match:  null)) == null)
            {
                goto label_19;
            }
            
            if(val_2 != null)
            {
                goto label_21;
            }
            
            label_22:
            label_21:
            val_2.SetSprite(sprite:  val_10.sprite);
            return val_2;
            label_19:
            if(val_2 != null)
            {
                goto label_21;
            }
            
            goto label_22;
            label_4:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearLeaderboard()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.leaderboardCells.GetEnumerator();
            label_10:
            if(((-1243652992) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if(val_4.gameObject == 0)
            {
                goto label_10;
            }
            
            UnityEngine.Object.Destroy(obj:  val_4.gameObject);
            goto label_10;
            label_2:
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524838030464});
            this.leaderboardCells.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LeaderboardTabHandler(Master.MasterDomain masterDomain, GameUI.LeaderboardTabData leaderboardTabData)
        {
            val_1 = new System.Object();
            this.leaderboardTabData = val_1;
            this.leaderboardCells = new System.Collections.Generic.List<GameUI.LeaderboardCell>();
            this._masterDomain = masterDomain;
            masterDomain.eventExposer.add_BestStreakLeaderboardUpdated(value:  new System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>>(object:  this, method:  System.Void GameUI.LeaderboardTabHandler::EventExposer_BestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> leaderboard)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateLeaderboardTab()
        {
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.bestStreakLeaderboardGetter.GetLeaderboard();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearLeaderboardList()
        {
            this.ClearLeaderboard();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDestroy()
        {
            this.ClearLeaderboard();
            this.leaderboardCells = 0;
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_BestStreakLeaderboardUpdated(value:  new System.Action<System.Collections.Generic.List<TheGame.Data.LeaderboardEntry>>(object:  this, method:  System.Void GameUI.LeaderboardTabHandler::EventExposer_BestStreakLeaderboardUpdated(System.Collections.Generic.List<TheGame.Data.LeaderboardEntry> leaderboard)));
        }
    
    }

}
