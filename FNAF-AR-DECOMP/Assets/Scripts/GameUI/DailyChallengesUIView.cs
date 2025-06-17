using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengesUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DailyChallengesCell _dailyChallengesCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _dailyChallengesCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.TimerDisplay _timeRemainingTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.IllumixButton _collectButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _collectButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_DailyChallenges _dialogHandler_DailyChallenges;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PossibleRewardsCell _possibleRewardsCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _possibleRewardsCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DailyChallengesDisplayHandler _dailyChallengesDisplayHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectMoreInfoButton()
        {
            this._dailyChallengesDisplayHandler.ShowMoreInfo();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Master.MasterDomain val_4;
            Master.MasterDomain val_5;
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_4 = val_1;
            this._masterDomain = val_1;
            if(val_1 != null)
            {
                goto label_1;
            }
            
            val_4 = this._masterDomain;
            if(val_4 == null)
            {
                goto label_2;
            }
            
            label_1:
            val_5 = this._masterDomain;
            if(this._masterDomain == null)
            {
                    val_5 = this._masterDomain;
            }
            
            this._dailyChallengesDisplayHandler = new GameUI.DailyChallengesDisplayHandler(dailyChallengesLoadData:  new LoadData() {eventExposer = val_1.eventExposer, dailyChallengesCellPrefab = this._dailyChallengesCellPrefab, dailyChallengesCellParent = this._dailyChallengesCellParent, gameAssetManagementDomain = this._masterDomain.GameAssetManagementDomain, collectButton = this._collectButton, collectButtonText = this._collectButtonText, dialogHandler_DailyChallenges = this._dialogHandler_DailyChallenges, timerRemainingDisplay = this._timeRemainingTimer, dailyChallengesContainer = this._masterDomain.dailyChallengeDomain.DailyChallengeContainer, dailyChallengeDomain = this._masterDomain.dailyChallengeDomain, possibleRewardsCellPrefab = this._possibleRewardsCellPrefab, possibleRewardsCellParent = this._possibleRewardsCellParent, gameAudioDomain = this._masterDomain.GameAudioDomain});
            return;
            label_2:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this._dailyChallengesDisplayHandler.UpdateCollectButtonState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._dailyChallengesDisplayHandler.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengesUIView()
        {
        
        }
    
    }

}
