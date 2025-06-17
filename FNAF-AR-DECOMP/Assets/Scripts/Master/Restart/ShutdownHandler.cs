using UnityEngine;

namespace Master.Restart
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShutdownHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.Restart.ShutdownParameters _data;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.Restart.ShutdownParameters shutdownData)
        {
            this._data = shutdownData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._data = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShutDownGame(System.Action onShutdownComplete)
        {
            this._data.MasterDomain._theGameDomain.Teardown(onShutdownComplete:  onShutdownComplete);
            this._data.MasterDomain.AnimatronicEntityDomain.Teardown();
            this._data.MasterDomain.AttackSequenceDomain.Teardown();
            this._data.MasterDomain._alertsDomain.enabled = false;
            this._data.DomainLifecycle.Teardown();
            this._data.DomainLifecycle.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShutdownHandler()
        {
        
        }
    
    }

}
