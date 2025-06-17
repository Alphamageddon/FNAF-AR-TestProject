using UnityEngine;

namespace MapMode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ApproachModeZoomListener
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.Domain domain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ApproachModeZoomListener(MapMode.Domain domain)
        {
            this.domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)
        {
            if((AnimatronicEntity.StateData.IsInState(sourceState:  e.animatronicState, stateToCheck:  2)) == false)
            {
                    return;
            }
            
            this.domain.<PlayerTarget>k__BackingField.SnapToCenterAroundPlayer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEnable()
        {
            this.domain.masterDomain.eventExposer.add_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void MapMode.ApproachModeZoomListener::EventExposer_OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDisable()
        {
            if(this.domain.masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this.domain.masterDomain.eventExposer.remove_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void MapMode.ApproachModeZoomListener::EventExposer_OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
        }
    
    }

}
