using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HeartbeatDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly float DEFAULT_HEARTBEAT_PERIOD;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.HeartbeatRequester _requester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _currentHeartbeatPeriod;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _heartbeatTicker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _active;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _heartbeatIndex;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer, Game.Server.HeartbeatRequester requester)
        {
            null = null;
            this._active = false;
            this._heartbeatIndex = 0;
            this._eventExposer = eventExposer;
            this._currentHeartbeatPeriod = Game.Server.HeartbeatDispatcher.DEFAULT_HEARTBEAT_PERIOD;
            this._heartbeatTicker = 0f;
            eventExposer.add_HeartbeatPeriodChanged(value:  new System.Action<System.Single>(object:  this, method:  System.Void Game.Server.HeartbeatDispatcher::EventExposer_OnHeartbeatPeriodChanged(float heartbeatPeriod)));
            this._eventExposer.add_GameReadyForServerHeartbeat(value:  new System.Action(object:  this, method:  System.Void Game.Server.HeartbeatDispatcher::EventExposer_OnGameReadyForServerHeartbeat()));
            this._requester = requester;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._eventExposer != null)
            {
                    this._eventExposer.remove_HeartbeatPeriodChanged(value:  new System.Action<System.Single>(object:  this, method:  System.Void Game.Server.HeartbeatDispatcher::EventExposer_OnHeartbeatPeriodChanged(float heartbeatPeriod)));
                this._eventExposer.remove_GameReadyForServerHeartbeat(value:  new System.Action(object:  this, method:  System.Void Game.Server.HeartbeatDispatcher::EventExposer_OnGameReadyForServerHeartbeat()));
            }
            
            this._eventExposer = 0;
            mem[1152921525145360904] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._active == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this._heartbeatTicker + val_1;
            this._heartbeatTicker = val_1;
            if(val_1 <= this._currentHeartbeatPeriod)
            {
                    return;
            }
            
            this._heartbeatTicker = 0f;
            this.DispatchHeartbeat();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DispatchHeartbeat()
        {
            this._heartbeatIndex = this._heartbeatIndex + 1;
            this._requester.SendHeartbeat(index:  this._heartbeatIndex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnGameReadyForServerHeartbeat()
        {
            this._active = true;
            this.DispatchHeartbeat();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnHeartbeatPeriodChanged(float heartbeatPeriod)
        {
            this._currentHeartbeatPeriod = heartbeatPeriod;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HeartbeatDispatcher()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static HeartbeatDispatcher()
        {
            Game.Server.HeartbeatDispatcher.DEFAULT_HEARTBEAT_PERIOD = 30f;
        }
    
    }

}
