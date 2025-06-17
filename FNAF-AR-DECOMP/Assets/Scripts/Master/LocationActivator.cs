using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LocationActivator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._eventExposer = val_1.eventExposer;
            val_1.eventExposer.add_ReadyToActivateLocationServices(value:  new System.Action(object:  this, method:  System.Void Master.LocationActivator::StartPulse()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartPulse()
        {
            UnityEngine.Input.location.Start();
            this._eventExposer.remove_ReadyToActivateLocationServices(value:  new System.Action(object:  this, method:  System.Void Master.LocationActivator::StartPulse()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationActivator()
        {
        
        }
    
    }

}
