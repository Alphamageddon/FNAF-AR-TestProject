using UnityEngine;

namespace Master.Restart
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class RestartHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Restart.RestartParameters _data;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Restart.RestartParameters restartData)
        {
            this._data = restartData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._data = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RestartGame()
        {
            this._data.MasterDomain._alertsDomain.enabled = false;
            this._data.MasterDomain.AttackSequenceDomain.Setup();
            this._data.MasterDomain.AnimatronicEntityDomain.Setup();
            this._data.MasterDomain._theGameDomain.Restart();
            this._data.DomainLifecycle.Setup();
            this._data.DomainLifecycle.enabled = true;
            this._data.DisplayChooser.RequestDisplayChange(displayType:  6);
            GameSparks.Core.GS.Instance.Reconnect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RestartHandler()
        {
        
        }
    
    }

}
