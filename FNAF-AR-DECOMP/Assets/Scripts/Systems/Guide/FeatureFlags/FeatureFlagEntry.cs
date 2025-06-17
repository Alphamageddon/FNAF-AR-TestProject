using UnityEngine;

namespace Systems.Guide.FeatureFlags
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureFlagEntry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TutorialKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int AlertState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SpawnState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int EssenceState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MoodState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TopBarState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StaySafeState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ResultsReturnToCameraState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ScreenSleepAllowed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureFlagEntry()
        {
        
        }
    
    }

}
