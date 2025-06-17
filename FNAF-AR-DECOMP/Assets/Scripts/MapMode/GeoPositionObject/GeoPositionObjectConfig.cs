using UnityEngine;

namespace MapMode.GeoPositionObject
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeoPositionObjectConfig : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData> _possiblePrefabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _minWorkshops;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maxWorkshops;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData> PossiblePrefabs { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MinWorkshops { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxWorkshops { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData> get_PossiblePrefabs()
        {
            return (System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData>)this._possiblePrefabs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MinWorkshops()
        {
            return (int)this._minWorkshops;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaxWorkshops()
        {
            return (int)this._maxWorkshops;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeoPositionObjectConfig()
        {
            this._possiblePrefabs = new System.Collections.Generic.List<MapMode.GeoPositionObject.PrefabInfoData>();
            this._minWorkshops = 3;
            this._maxWorkshops = 3;
        }
    
    }

}
