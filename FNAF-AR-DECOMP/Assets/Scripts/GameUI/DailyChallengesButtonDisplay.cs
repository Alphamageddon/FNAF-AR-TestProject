using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengesButtonDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.TimerDisplay _timerDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _animatingParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _nonAnimatingParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.DailyChallenge.Container.DailyChallengeContainer _dailyChallengeContainer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDisplay()
        {
            var val_7;
            UnityEngine.GameObject val_8;
            if(this._dailyChallengeContainer.State != 0)
            {
                    var val_1 = (this._dailyChallengeContainer.State == 2) ? 1 : 0;
            }
            else
            {
                    val_7 = 1;
            }
            
            if(this._animatingParent != 0)
            {
                    this._animatingParent.SetActive(value:  true);
            }
            
            val_8 = this._nonAnimatingParent;
            if(val_8 != 0)
            {
                    val_8 = this._nonAnimatingParent;
                val_8.SetActive(value:  (val_7 == 0) ? 1 : 0);
            }
            
            if(this._timerDisplay == 0)
            {
                    return;
            }
            
            if(this._dailyChallengeContainer == null)
            {
                    return;
            }
            
            this._timerDisplay.SetEndTime(t:  this._dailyChallengeContainer.ExpirationTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(Game.DailyChallenge.Container.DailyChallengeContainer dailyChallengeContainer)
        {
            this._dailyChallengeContainer = dailyChallengeContainer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengesButtonDisplay()
        {
        
        }
    
    }

}
