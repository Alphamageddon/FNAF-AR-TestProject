using UnityEngine;

namespace Mapbox.MapMatching
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Tracepoint : Waypoint
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <WaypointIndex>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <MatchingsIndex>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <AlternativesCount>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int WaypointIndex { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MatchingsIndex { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int AlternativesCount { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_WaypointIndex()
        {
            return (int)this.<WaypointIndex>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_WaypointIndex(int value)
        {
            this.<WaypointIndex>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MatchingsIndex()
        {
            return (int)this.<MatchingsIndex>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MatchingsIndex(int value)
        {
            this.<MatchingsIndex>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_AlternativesCount()
        {
            return (int)this.<AlternativesCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AlternativesCount(int value)
        {
            this.<AlternativesCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Tracepoint()
        {
            val_1 = new System.Object();
        }
    
    }

}
