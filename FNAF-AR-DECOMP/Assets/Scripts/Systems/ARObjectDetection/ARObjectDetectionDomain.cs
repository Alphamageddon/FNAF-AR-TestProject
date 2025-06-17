using UnityEngine;

namespace Systems.ARObjectDetection
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ARObjectDetectionDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.ARObjectDetection.EventExposer <EventExposer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.ARObjectDetection.Listener <Listener>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.ARObjectDetection.EventExposer EventExposer { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.ARObjectDetection.Listener Listener { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.ARObjectDetection.EventExposer get_EventExposer()
        {
            return (Systems.ARObjectDetection.EventExposer)this.<EventExposer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_EventExposer(Systems.ARObjectDetection.EventExposer value)
        {
            this.<EventExposer>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.ARObjectDetection.Listener get_Listener()
        {
            return (Systems.ARObjectDetection.Listener)this.<Listener>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Listener(Systems.ARObjectDetection.Listener value)
        {
            this.<Listener>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ARObjectDetectionDomain()
        {
            ._arObjectDetectionDomain = this;
            this.<EventExposer>k__BackingField = new Systems.ARObjectDetection.EventExposer();
            this.<Listener>k__BackingField = new Systems.ARObjectDetection.Listener(arObjectDetectionDomain:  this);
        }
    
    }

}
