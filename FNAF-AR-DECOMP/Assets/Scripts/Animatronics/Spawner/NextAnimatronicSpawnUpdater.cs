using UnityEngine;

namespace Animatronics.Spawner
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NextAnimatronicSpawnUpdater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool active;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long nextTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.Server.NextAnimatronicRequester.DisplayState> RequestNextAnimatronic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.GameDisplayChanger _gameDisplayChanger;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly long TIMEOUT_TIME;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string CLASS_NAME;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.Server.NextAnimatronicRequester.DisplayState> requestCallback, Master.EventExposer masterExposer, TheGame.GameDisplayChanger gameDisplayChanger)
        {
            this.RequestNextAnimatronic = requestCallback;
            this.eventExposer = masterExposer;
            this._gameDisplayChanger = gameDisplayChanger;
            masterExposer.add_UpdateNextAnimatronicRequestTime(value:  new System.Action<System.Int64>(object:  this, method:  System.Void Animatronics.Spawner.NextAnimatronicSpawnUpdater::OnRequestTimeRefresh(long newNextTime)));
            this.eventExposer.add_LoadingDone(value:  new System.Action(object:  this, method:  System.Void Animatronics.Spawner.NextAnimatronicSpawnUpdater::OnLoadingDone()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.eventExposer.remove_LoadingDone(value:  new System.Action(object:  this, method:  System.Void Animatronics.Spawner.NextAnimatronicSpawnUpdater::OnLoadingDone()));
            this.eventExposer.remove_UpdateNextAnimatronicRequestTime(value:  new System.Action<System.Int64>(object:  this, method:  System.Void Animatronics.Spawner.NextAnimatronicSpawnUpdater::OnRequestTimeRefresh(long newNextTime)));
            this.RequestNextAnimatronic = 0;
            this.eventExposer = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this.active == false)
            {
                    return;
            }
            
            if(TheGame.ServerTime.GetCurrentTime() <= this.nextTime)
            {
                    return;
            }
            
            if(this.RequestNextAnimatronic != null)
            {
                    this.RequestNextAnimatronic.Invoke(obj:  this.GetCurrentDisplayState());
            }
            
            long val_4 = this.TIMEOUT_TIME;
            val_4 = val_4 + TheGame.ServerTime.GetCurrentTime();
            this.nextTime = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.NextAnimatronicRequester.DisplayState GetCurrentDisplayState()
        {
            return (DisplayState)(this._gameDisplayChanger.GetDisplayType() != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnRequestTimeRefresh(long newNextTime)
        {
            this.nextTime = newNextTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLoadingDone()
        {
            this.active = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NextAnimatronicSpawnUpdater()
        {
            this.TIMEOUT_TIME = 10;
            this.CLASS_NAME = "NextAnimatronicSpawnUpdater";
        }
    
    }

}
