using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Domain_SROptions
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistanceToTriggerStalkingMode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DistanceToTriggerDarkMode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ForceMalfunction { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Domain_SROptions(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DistanceToTriggerStalkingMode()
        {
            if(this._animatronicEntityDomain._animatronicEntityConfig != null)
            {
                    return ImperialMetricConversions.MetersToMiles(meters:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode);
            }
            
            return ImperialMetricConversions.MetersToMiles(meters:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DistanceToTriggerStalkingMode(float value)
        {
            this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerStalkingMode = ImperialMetricConversions.MilesToMeters(miles:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_DistanceToTriggerDarkMode()
        {
            if(this._animatronicEntityDomain._animatronicEntityConfig != null)
            {
                    return ImperialMetricConversions.MetersToFeet(meters:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerDarkMode);
            }
            
            return ImperialMetricConversions.MetersToFeet(meters:  this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerDarkMode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_DistanceToTriggerDarkMode(float value)
        {
            this._animatronicEntityDomain._animatronicEntityConfig.playerDistanceToTriggerDarkMode = ImperialMetricConversions.FeetToMeters(feet:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_ForceMalfunction()
        {
            if(this._animatronicEntityDomain != null)
            {
                    return (bool)this._animatronicEntityDomain.forceMalfunction;
            }
            
            return (bool)this._animatronicEntityDomain.forceMalfunction;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_ForceMalfunction(bool value)
        {
            this._animatronicEntityDomain.forceMalfunction = value;
        }
    
    }

}
