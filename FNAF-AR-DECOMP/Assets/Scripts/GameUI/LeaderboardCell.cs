using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LeaderboardCell : MonoBehaviour, ICellInterface<GameUI.LeaderboardCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI rankText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI userNameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI scoreText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image avatar;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private HighlightToggle highlightToggle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.LeaderboardCellData item)
        {
            this.userNameText.text = item.leaderboardEntry.name;
            long val_3 = item.leaderboardEntry.rank;
            val_3 = val_3 + 1;
            this.rankText.text = val_3.ToString();
            this.scoreText.text = item.leaderboardEntry.score.ToString();
            if(item.isPlayer == false)
            {
                    return;
            }
            
            this = this.highlightToggle;
            this.SetHighlight(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this.avatar.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LeaderboardCell()
        {
        
        }
    
    }

}
