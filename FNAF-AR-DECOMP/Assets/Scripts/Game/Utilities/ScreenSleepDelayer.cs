using UnityEngine;

namespace Game.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScreenSleepDelayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Game.Utilities.ScreenSleepDelayer.Lock, bool> _locks;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer masterEvents)
        {
            this._locks = new System.Collections.Generic.Dictionary<Lock, System.Boolean>();
            masterEvents.add_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.Utilities.ScreenSleepDelayer::OnGameDisplayChange(TheGame.GameDisplayData data)));
            masterEvents.add_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.Utilities.ScreenSleepDelayer::OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap featureFlags)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown(Master.EventExposer masterEvents)
        {
            masterEvents.remove_GameDisplayChange(value:  new System.Action<TheGame.GameDisplayData>(object:  this, method:  System.Void Game.Utilities.ScreenSleepDelayer::OnGameDisplayChange(TheGame.GameDisplayData data)));
            masterEvents.remove_FeatureFlagsUpdatedEvent(value:  new System.Action<Systems.Guide.FeatureFlags.FeatureFlagMap>(object:  this, method:  System.Void Game.Utilities.ScreenSleepDelayer::OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap featureFlags)));
            this._locks = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGameDisplayChange(TheGame.GameDisplayData data)
        {
            var val_4;
            if(data.currentDisplay != 1)
            {
                goto label_2;
            }
            
            val_4 = 1;
            if(this._locks != null)
            {
                goto label_6;
            }
            
            goto label_4;
            label_2:
            if(this._locks != null)
            {
                goto label_6;
            }
            
            label_4:
            label_6:
            this._locks.set_Item(key:  0, value:  (data.currentDisplay == 7) ? 1 : 0);
            this.UpdateLock();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnFeatureFlagsUpdated(Systems.Guide.FeatureFlags.FeatureFlagMap featureFlags)
        {
            this._locks.set_Item(key:  1, value:  (~featureFlags.IsScreenSleepAllowed()) & 1);
            this.UpdateLock();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateLock()
        {
            var val_5;
            var val_6;
            var val_7;
            Dictionary.Enumerator<TKey, TValue> val_1 = this._locks.GetEnumerator();
            val_5 = 1152921525275538336;
            val_6 = 0;
            goto label_2;
            label_3:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            label_2:
            if(((-806120912) & 1) != 0)
            {
                goto label_3;
            }
            
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525275562544});
            if(((-806120920) & 1) != 0)
            {
                goto label_4;
            }
            
            goto label_9;
            label_4:
            val_7 = 0;
            goto label_10;
            label_9:
            val_7 = -2;
            label_10:
            UnityEngine.Screen.sleepTimeout = -2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScreenSleepDelayer()
        {
        
        }
    
    }

}
