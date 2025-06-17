using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TopBarUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI fazTokenText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI streakMaxNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI streakNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI partsNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI essenceNumText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject topBarParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject devicesParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI devicesDisplayNum;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image playerAvatarImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DailyChallengesButtonDisplay dailyChallengesButtonDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject dailyChallengesButtonParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.TopBarDisplayHandler _topBarDisplayHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.TopBarDisplayHandler.TopBarDisplayData _topBarDisplayData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplayHandler _deviceDisplayHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplayData _deviceDisplayData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildData()
        {
            UnityEngine.GameObject val_6;
            TopBarDisplayHandler.TopBarDisplayData val_1 = new TopBarDisplayHandler.TopBarDisplayData();
            if(val_1 != null)
            {
                    .masterDomain = this._masterDomain;
                .fazTokenText = this.fazTokenText;
                .streakMaxNumText = this.streakMaxNumText;
                .streakNumText = this.streakNumText;
                .partsNumText = this.partsNumText;
                .essenceNumText = this.essenceNumText;
                .topBarParent = this.topBarParent;
                .playerAvatarImage = this.playerAvatarImage;
                val_6 = this.dailyChallengesButtonParent;
            }
            else
            {
                    mem[16] = this._masterDomain;
                mem[24] = this.fazTokenText;
                mem[32] = this.streakMaxNumText;
                mem[40] = this.streakNumText;
                mem[48] = this.partsNumText;
                mem[56] = this.essenceNumText;
                mem[64] = this.topBarParent;
                mem[72] = this.playerAvatarImage;
                val_6 = this.dailyChallengesButtonParent;
            }
            
            .dailyChallengesButtonParent = val_6;
            .gameDisplayChanger = this._masterDomain.theGameDomain.gameDisplayChanger;
            .gameUIDomain = this._masterDomain.gameUIDomain;
            this._topBarDisplayData = val_1;
            this._deviceDisplayData = new GameUI.DeviceDisplayData(masterDomain:  this._masterDomain, devicesParent:  this.devicesParent, devicesDisplayNum:  this.devicesDisplayNum);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.BuildData();
            this._topBarDisplayHandler = new GameUI.TopBarDisplayHandler(topBarDisplayData:  this._topBarDisplayData);
            this._deviceDisplayHandler = new GameUI.DeviceDisplayHandler(deviceDisplayData:  this._deviceDisplayData);
            this.dailyChallengesButtonDisplay.SetData(dailyChallengeContainer:  this._masterDomain.dailyChallengeDomain.DailyChallengeContainer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            TheGame.Domain val_1 = this._masterDomain.theGameDomain;
            if(val_1.GameActive == false)
            {
                    return;
            }
            
            this._topBarDisplayHandler.Update();
            this._deviceDisplayHandler.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._topBarDisplayHandler.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TopBarUIView()
        {
        
        }
    
    }

}
