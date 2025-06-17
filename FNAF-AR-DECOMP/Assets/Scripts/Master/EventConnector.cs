using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EventConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.EventExposer alertEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Spawner.EventExposer animatronicsSpawnerEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer eventExposer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.MasterDomain masterDomain)
        {
            this.AssignEventExposers(masterDomain:  masterDomain);
            this.ConnectEvents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.DisconnectEvents();
            this.animatronicsSpawnerEvents = 0;
            this.eventExposer = 0;
            this.alertEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssignEventExposers(Master.MasterDomain masterDomain)
        {
            if(masterDomain != null)
            {
                    this.eventExposer = masterDomain.eventExposer;
            }
            else
            {
                    this.eventExposer = 456;
            }
            
            this.alertEvents = masterDomain.alertsDomain.EventExposer;
            this.animatronicsSpawnerEvents = masterDomain.AnimatronicsSpawnerDomain.eventExposer;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConnectEvents()
        {
            this.alertEvents.add_AlertPlayerDataUpdatedEvent(value:  new System.Action<Alerts.Data.PlayerAlertData>(object:  this.eventExposer, method:  public System.Void Master.EventExposer::OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData e)));
            this.eventExposer.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this.alertEvents, method:  public System.Void Alerts.EventExposer::OnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)));
            this.animatronicsSpawnerEvents.add_OnAnimatronicRequestedFromServer(value:  new System.Action<System.String>(object:  this.eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicRequestedFromServer(string e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisconnectEvents()
        {
            this.alertEvents.remove_AlertPlayerDataUpdatedEvent(value:  new System.Action<Alerts.Data.PlayerAlertData>(object:  this.eventExposer, method:  public System.Void Master.EventExposer::OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData e)));
            this.eventExposer.remove_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this.alertEvents, method:  public System.Void Alerts.EventExposer::OnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)));
            this.animatronicsSpawnerEvents.remove_OnAnimatronicRequestedFromServer(value:  new System.Action<System.String>(object:  this.eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicRequestedFromServer(string e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NullEventExposers()
        {
            this.animatronicsSpawnerEvents = 0;
            this.eventExposer = 0;
            this.alertEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventConnector()
        {
        
        }
    
    }

}
