using UnityEngine;

namespace Alerts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EventExposer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Alerts.Data.PlayerAlertData> AlertPlayerDataUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> FeatureFlagsUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_AlertPlayerDataUpdatedEvent(System.Action<Alerts.Data.PlayerAlertData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.AlertPlayerDataUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertPlayerDataUpdatedEvent != 1152921525103401120);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_AlertPlayerDataUpdatedEvent(System.Action<Alerts.Data.PlayerAlertData> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.AlertPlayerDataUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.AlertPlayerDataUpdatedEvent != 1152921525103537696);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_FeatureFlagsUpdatedEvent(System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.FeatureFlagsUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FeatureFlagsUpdatedEvent != 1152921525103674280);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_FeatureFlagsUpdatedEvent(System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.FeatureFlagsUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.FeatureFlagsUpdatedEvent != 1152921525103810856);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventExposer(Alerts.Domain domain)
        {
            this._domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAlertPlayerDataUpdatedEvent(Alerts.Data.PlayerAlertData data)
        {
            if(this.AlertPlayerDataUpdatedEvent == null)
            {
                    return;
            }
            
            this.AlertPlayerDataUpdatedEvent.Invoke(obj:  data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnFeatureFlagsUpdatedEvent(Systems.Guide.FeatureFlags.FeatureFlagMap data)
        {
            if(this.FeatureFlagsUpdatedEvent == null)
            {
                    return;
            }
            
            this.FeatureFlagsUpdatedEvent.Invoke(obj:  data);
        }
    
    }

}
