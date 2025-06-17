using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ARSessionActivator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject ARObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject ARSessionObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isActive;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_1.eventExposer.add_ReadyToActivateAR(value:  new System.Action(object:  this, method:  System.Void Master.ARSessionActivator::TurnOnARObject()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TurnOnARObject()
        {
            this.ARObject.SetActive(value:  true);
            this.ARSessionObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool IsInCameraState()
        {
            return (bool)(this._masterDomain.theGameDomain.gameDisplayChanger.GetDisplayType() == 1) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            var val_2 = (this.isActive == true) ? 1 : 0;
            val_2 = this.IsInCameraState() ^ val_2;
            if(val_2 == false)
            {
                    return;
            }
            
            bool val_3 = (this.isActive == false) ? 1 : 0;
            this.isActive = val_3;
            this.ARObject.SetActive(value:  val_3);
            this.ARSessionObject.SetActive(value:  (this.isActive == true) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ARSessionActivator()
        {
        
        }
    
    }

}
