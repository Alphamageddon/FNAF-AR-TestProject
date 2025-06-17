using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameResetter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.Domain domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameResetter.GameResetChangedArgs gameResetChangedArgs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<TheGame.GameResetter.GameResetChangedArgs> OnGameResetChangeEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGameResetChangeEvent(System.Action<TheGame.GameResetter.GameResetChangedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGameResetChangeEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGameResetChangeEvent != 1152921523484635200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGameResetChangeEvent(System.Action<TheGame.GameResetter.GameResetChangedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGameResetChangeEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGameResetChangeEvent != 1152921523484771776);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameResetter(TheGame.Domain domain)
        {
            this.domain = domain;
            .startingGameDisplay = domain.startingGameDisplay;
            this.gameResetChangedArgs = new GameResetter.GameResetChangedArgs();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetAll()
        {
            Master.MasterDomain val_1 = this.domain.MasterDomain;
            val_1.AnimatronicEntityDomain.container.Clear();
            if(this.OnGameResetChangeEvent == null)
            {
                    return;
            }
            
            this.OnGameResetChangeEvent.Invoke(obj:  this.gameResetChangedArgs);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetGameState()
        {
            Master.MasterDomain val_1 = this.domain.MasterDomain;
            val_1.AnimatronicEntityDomain.container.Clear();
        }
    
    }

}
