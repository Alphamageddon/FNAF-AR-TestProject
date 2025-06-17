using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameStartDisplayChooser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain domain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameStartDisplayChooser(TheGame.Domain domain)
        {
            this.domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSplashScreenDisplay()
        {
            this.domain.gameDisplayChanger.RequestDisplayChange(displayType:  6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            this.SetSplashScreenDisplay();
        }
    
    }

}
