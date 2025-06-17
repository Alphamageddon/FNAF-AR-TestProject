using UnityEngine;

namespace Systems.Guide
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideConditionSharedContext
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapSceneLookupTable _mapSceneLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _activeSeasonalAssets;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Store.StoreDomain _storeDomain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapSceneLookupTable MapSceneLookup { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> ActiveSeasonalAssets { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.StoreDomain StoreDomain { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapSceneLookupTable get_MapSceneLookup()
        {
            return (MapSceneLookupTable)this._mapSceneLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> get_ActiveSeasonalAssets()
        {
            return (System.Collections.Generic.List<System.String>)this._activeSeasonalAssets;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.StoreDomain get_StoreDomain()
        {
            return (Game.Store.StoreDomain)this._storeDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer exposer, Game.Store.StoreDomain storeDomain)
        {
            this._eventExposer = exposer;
            this._storeDomain = storeDomain;
            exposer.add_ActiveSeasonalEventsUpdated(value:  new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Systems.Guide.GuideConditionSharedContext::EventDomain_ActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> list)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMapTable(MapSceneLookupTable mapSceneLookupTable)
        {
            this._mapSceneLookup = mapSceneLookupTable;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._eventExposer.remove_ActiveSeasonalEventsUpdated(value:  new System.Action<Game.SeasonalEvents.SeasonMechanicTag, System.Collections.Generic.List<System.String>>(object:  this, method:  System.Void Systems.Guide.GuideConditionSharedContext::EventDomain_ActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> list)));
            this._eventExposer = 0;
            mem[1152921523364340456] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventDomain_ActiveSeasonalEventsUpdated(Game.SeasonalEvents.SeasonMechanicTag tag, System.Collections.Generic.List<string> list)
        {
            if(tag != 2)
            {
                    return;
            }
            
            this._activeSeasonalAssets = list;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideConditionSharedContext()
        {
            this._activeSeasonalAssets = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
