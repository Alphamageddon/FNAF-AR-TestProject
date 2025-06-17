using UnityEngine;

namespace Game.SeasonalEvents.Container
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SeasonalEventDataContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.SeasonalEvents.Data.SeasonalEventData> _activeEvents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action EventDataLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.SeasonalEvents.Data.SeasonalEventData> ActiveEvents { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.SeasonalEvents.Data.SeasonalEventData> get_ActiveEvents()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.SeasonalEvents.Data.SeasonalEventData>)this._activeEvents;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SeasonalEventDataContainer(Master.EventExposer eventExposer)
        {
            this._activeEvents = new System.Collections.Generic.Dictionary<System.String, Game.SeasonalEvents.Data.SeasonalEventData>();
            eventExposer.add_SeasonalEventDataReceived(value:  new System.Action<System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData>>(object:  this, method:  System.Void Game.SeasonalEvents.Container.SeasonalEventDataContainer::GetCurrentEventData(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> data)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._activeEvents.Clear();
            this._activeEvents = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetCurrentEventData(System.Collections.Generic.List<Game.SeasonalEvents.Data.SeasonalEventData> data)
        {
            var val_4;
            this._activeEvents.Clear();
            val_4 = 0;
            goto label_2;
            label_8:
            Game.SeasonalEvents.Data.SeasonalEventData val_1 = data.Item[0];
            this._activeEvents.Add(key:  val_1.EventID, value:  data.Item[0]);
            val_4 = 1;
            label_2:
            if(val_4 < data.Count)
            {
                goto label_8;
            }
            
            if(this.EventDataLoaded == null)
            {
                    return;
            }
            
            this.EventDataLoaded.Invoke();
        }
    
    }

}
