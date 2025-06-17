using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreBadgeBroker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.StoreBadgeController _storeBadgeController;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreBadgeBroker(DefaultNamespace.StoreBadgeController storeBadgeController, Master.EventExposer eventExposer)
        {
            val_1 = new System.Object();
            this._eventExposer = val_1;
            this._storeBadgeController = storeBadgeController;
            storeBadgeController.Setup();
            this.SetupCallbacks(eventExposer:  Master.EventExposer val_1 = eventExposer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._eventExposer.remove_RecallButtonTapped(value:  new System.Action(object:  this, method:  System.Void GameUI.StoreBadgeBroker::EventExposerOnRecallButtonTapped()));
            this._eventExposer.remove_StoreOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.StoreBadgeBroker::StoreOpened()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupCallbacks(Master.EventExposer eventExposer)
        {
            eventExposer.add_RecallButtonTapped(value:  new System.Action(object:  this, method:  System.Void GameUI.StoreBadgeBroker::EventExposerOnRecallButtonTapped()));
            eventExposer.add_StoreOpened(value:  new System.Action(object:  this, method:  System.Void GameUI.StoreBadgeBroker::StoreOpened()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposerOnRecallButtonTapped()
        {
            this._storeBadgeController.HandleRecallIncrement();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StoreOpened()
        {
            this._storeBadgeController.HandleStoreOpened();
        }
    
    }

}
