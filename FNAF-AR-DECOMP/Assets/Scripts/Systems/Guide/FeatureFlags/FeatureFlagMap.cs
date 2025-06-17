using UnityEngine;

namespace Systems.Guide.FeatureFlags
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureFlagMap
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _alertCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _spawnCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _essenceCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _moodCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _topBarCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _staySafeCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _resultsReturnToCameraCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _screenSleepAllowed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AreAlertsAllowed()
        {
            return (bool)(this._alertCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AreSpawnsAllowed()
        {
            return (bool)(this._spawnCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEssenceAllowed()
        {
            return (bool)(this._essenceCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsScaryMoodAllowed()
        {
            return (bool)(this._moodCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsTopBarAllowed()
        {
            return (bool)(this._topBarCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsStaySafeAllowed()
        {
            return (bool)(this._staySafeCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsResultsReturnToCameraAllowed()
        {
            return (bool)(this._resultsReturnToCameraCache == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsScreenSleepAllowed()
        {
            return (bool)(this._screenSleepAllowed == 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Collections.Generic.List<Systems.Guide.FeatureFlags.FeatureFlagEntry> flags)
        {
            var val_18;
            this._alertCache = 0;
            this._spawnCache = 0;
            this._essenceCache = 0;
            this._moodCache = 0;
            mem[1152921523386774496] = 0;
            val_18 = 0;
            goto label_1;
            label_21:
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_1 = flags.Item[0];
            this._alertCache = System.Math.Max(val1:  0, val2:  val_1.AlertState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_3 = flags.Item[0];
            this._spawnCache = System.Math.Max(val1:  this._spawnCache, val2:  val_3.SpawnState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_5 = flags.Item[0];
            this._essenceCache = System.Math.Max(val1:  this._essenceCache, val2:  val_5.EssenceState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_7 = flags.Item[0];
            this._moodCache = System.Math.Max(val1:  this._moodCache, val2:  val_7.MoodState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_9 = flags.Item[0];
            this._topBarCache = System.Math.Max(val1:  this._topBarCache, val2:  val_9.TopBarState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_11 = flags.Item[0];
            this._staySafeCache = System.Math.Max(val1:  this._staySafeCache, val2:  val_11.StaySafeState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_13 = flags.Item[0];
            this._resultsReturnToCameraCache = System.Math.Max(val1:  this._resultsReturnToCameraCache, val2:  val_13.ResultsReturnToCameraState);
            Systems.Guide.FeatureFlags.FeatureFlagEntry val_15 = flags.Item[0];
            val_18 = 1;
            this._screenSleepAllowed = System.Math.Max(val1:  this._screenSleepAllowed, val2:  val_15.ScreenSleepAllowed);
            label_1:
            if(val_18 < flags.Count)
            {
                goto label_21;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureFlagMap()
        {
        
        }
    
    }

}
