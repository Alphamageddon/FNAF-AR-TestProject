using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureFlagsResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> FeatureFlagUpdated;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap> callback)
        {
            this.FeatureFlagUpdated = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "PlayerFeatureFlags");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessFeatureFlags(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessFeatureFlags(Systems.Server.ServerData data)
        {
            System.Collections.Generic.List<Systems.Server.ServerData> val_7 = data.GetServerDataList(key:  "flags");
            if(val_7 == null)
            {
                    return;
            }
            
            int val_2 = val_7.Count;
            System.Collections.Generic.List<Systems.Guide.FeatureFlags.FeatureFlagEntry> val_3 = new System.Collections.Generic.List<Systems.Guide.FeatureFlags.FeatureFlagEntry>(capacity:  val_2);
            if(val_2 >= 1)
            {
                    var val_7 = 0;
                do
            {
                Systems.Server.ServerData val_4 = val_7.Item[0];
                val_3.Add(item:  val_4.ProcessEntry(data:  val_4));
                val_7 = val_7 + 1;
            }
            while(val_2 != val_7);
            
            }
            
            Systems.Guide.FeatureFlags.FeatureFlagMap val_6 = null;
            val_7 = val_6;
            val_6 = new Systems.Guide.FeatureFlags.FeatureFlagMap();
            val_6.Setup(flags:  val_3);
            if(this.FeatureFlagUpdated == null)
            {
                    return;
            }
            
            this.FeatureFlagUpdated.Invoke(obj:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.Guide.FeatureFlags.FeatureFlagEntry ProcessEntry(Systems.Server.ServerData data)
        {
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            .TutorialKey = data.GetString(key:  "TutorialKey");
            System.Nullable<System.Int32> val_3 = data.GetInt(key:  "AlertState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_4 = data.GetInt(key:  "AlertState");
            }
            else
            {
                    val_19 = 0;
            }
            
            .AlertState = val_19;
            System.Nullable<System.Int32> val_5 = data.GetInt(key:  "SpawnState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_6 = data.GetInt(key:  "SpawnState");
            }
            else
            {
                    val_20 = 0;
            }
            
            .SpawnState = val_20;
            System.Nullable<System.Int32> val_7 = data.GetInt(key:  "EssenceState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_8 = data.GetInt(key:  "EssenceState");
            }
            else
            {
                    val_21 = 0;
            }
            
            .EssenceState = val_21;
            System.Nullable<System.Int32> val_9 = data.GetInt(key:  "ScaryMoodState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_10 = data.GetInt(key:  "ScaryMoodState");
            }
            else
            {
                    val_22 = 0;
            }
            
            .MoodState = val_22;
            System.Nullable<System.Int32> val_11 = data.GetInt(key:  "TopBarState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_12 = data.GetInt(key:  "TopBarState");
            }
            else
            {
                    val_23 = 0;
            }
            
            .TopBarState = val_23;
            System.Nullable<System.Int32> val_13 = data.GetInt(key:  "StaySafeState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_14 = data.GetInt(key:  "StaySafeState");
            }
            else
            {
                    val_24 = 0;
            }
            
            .StaySafeState = val_24;
            System.Nullable<System.Int32> val_15 = data.GetInt(key:  "ResultsReturnToCameraState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_16 = data.GetInt(key:  "ResultsReturnToCameraState");
            }
            else
            {
                    val_25 = 0;
            }
            
            .ResultsReturnToCameraState = val_25;
            System.Nullable<System.Int32> val_17 = data.GetInt(key:  "ScreenSleepState");
            if(((-902845320) & 1) != 0)
            {
                    System.Nullable<System.Int32> val_18 = data.GetInt(key:  "ScreenSleepState");
            }
            else
            {
                    val_26 = 0;
            }
            
            .ScreenSleepAllowed = val_26;
            return (Systems.Guide.FeatureFlags.FeatureFlagEntry)new Systems.Guide.FeatureFlags.FeatureFlagEntry();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureFlagsResponseHandler()
        {
        
        }
    
    }

}
