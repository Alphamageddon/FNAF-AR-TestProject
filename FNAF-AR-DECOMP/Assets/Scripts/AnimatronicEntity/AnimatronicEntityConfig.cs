using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicEntityConfig : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int maxEntitiesAllowed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float updateFrequencyMinSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float updateFrequencyMaxSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float stalkingDegreesPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float stalkingClockwiseChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float stalkingSwitchbackMinTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float stalkingSwitchbackMaxTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float approachUpdateFrequencyMinSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float approachUpdateFrequencyMaxSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float playerDistanceToTriggerStalkingMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float playerDistanceToTriggerDarkMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float playerDistanceToTriggerTravelMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float playerDistanceTravelMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float darkModeMetersPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float sendDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float blinkTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float sendSpawnOffset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicEntityConfig()
        {
            this.updateFrequencyMinSeconds = ;
            this.updateFrequencyMaxSeconds = ;
            this.stalkingDegreesPerSecond = 6f;
            this.stalkingClockwiseChance = 0.5f;
            this.maxEntitiesAllowed = 5;
            this.stalkingSwitchbackMinTimer = ;
            this.stalkingSwitchbackMaxTimer = ;
            this.approachUpdateFrequencyMinSeconds = 0.2f;
            this.approachUpdateFrequencyMaxSeconds = 1f;
            this.darkModeMetersPerSecond = 10f;
            this.sendDistance = 2.295887E-41f;
            this.playerDistanceToTriggerStalkingMode = ;
            this.playerDistanceToTriggerDarkMode = ;
            this.playerDistanceToTriggerTravelMode = 800f;
            this.playerDistanceTravelMax = 1000f;
            this.blinkTime = 2f;
            this.sendSpawnOffset = 150f;
        }
    
    }

}
