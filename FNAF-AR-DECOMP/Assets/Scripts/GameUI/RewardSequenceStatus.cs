using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RewardSequenceStatus
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int defaultMinTime = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float sequenceTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AudioSourceWatcher audioSourceWatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AnimationWatcher animationWatcher;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GameObjectClicked gameObjectClick;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SimpleTimer simpleTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RewardSequenceStatus(UnityEngine.GameObject gameObject, float time = -1)
        {
            this.sequenceTime = time;
            this.audioSourceWatcher = new GameUI.AudioSourceWatcher(gameObject:  gameObject);
            this.animationWatcher = new GameUI.AnimationWatcher(gameObject:  gameObject);
            this.gameObjectClick = new GameUI.GameObjectClicked(gameObject:  gameObject);
            SimpleTimer val_4 = new SimpleTimer();
            this.simpleTimer = val_4;
            val_4.StartTimer(time:  (this.sequenceTime < 0) ? 3f : this.sequenceTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsComplete(GameUI.StatusType statusType)
        {
            if(statusType > 3)
            {
                    return true;
            }
            
            var val_1 = 52946004 + (statusType) << 2;
            val_1 = val_1 + 52946004;
            goto (52946004 + (statusType) << 2 + 52946004);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AllComplete(GameUI.StatusType[] statusTypes)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            label_3:
            if(val_2 >= statusTypes.Length)
            {
                goto label_1;
            }
            
            val_2 = val_2 + 1;
            if((this.IsComplete(statusType:  statusTypes[0])) == true)
            {
                goto label_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
            label_1:
            val_3 = 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetClick()
        {
            this.gameObjectClick.buttonClicked = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RestartTimer()
        {
            this.simpleTimer.StartTimer(time:  (this.sequenceTime < 0) ? 3f : this.sequenceTime);
        }
    
    }

}
