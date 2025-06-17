using UnityEngine;

namespace MapMode.MovementNode
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LocationNode
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MovementNode.LocationNode.LocationType _type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _positionMeters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d _positionLatLon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _labels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _occupied;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode.LocationType Type { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Occupied { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d PositionMeters { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d PositionLatLon { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] Labels { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this._id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapMode.MovementNode.LocationNode.LocationType get_Type()
        {
            return (LocationType)this._type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Occupied()
        {
            return (int)this._occupied;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Occupied(int value)
        {
            this._occupied = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_PositionMeters()
        {
            return new Mapbox.Utils.Vector2d() {x = this._positionMeters};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PositionMeters(Mapbox.Utils.Vector2d value)
        {
            this._positionMeters = value;
            mem[1152921524620609096] = value.y;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = value.x, y = value.y});
            this._positionLatLon = val_1;
            mem[1152921524620609112] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_PositionLatLon()
        {
            return new Mapbox.Utils.Vector2d() {x = this._positionLatLon};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_PositionLatLon(Mapbox.Utils.Vector2d value)
        {
            this._positionLatLon = value;
            mem[1152921524620833112] = value.y;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = value.x, y = value.y});
            this._positionMeters = val_1;
            mem[1152921524620833096] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Name()
        {
            return (string)this._name;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Name(string value)
        {
            this._name = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_Labels()
        {
            return (System.String[])this._labels;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Labels(string[] value)
        {
            this._labels = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationNode(MapMode.MovementNode.LocationNode.LocationType type, string name = "")
        {
            this._name = "";
            val_1 = new System.Object();
            System.Guid val_2 = System.Guid.NewGuid();
            this._id = ;
            this._type = type;
            this._name = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LocationNode(MapMode.MovementNode.LocationNode.LocationType type, string name = "", string id = "")
        {
            this._name = "";
            val_1 = new System.Object();
            this._id = id;
            this._type = type;
            this._name = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static MapMode.MovementNode.LocationNode CreateNodeForMeters(MapMode.MovementNode.LocationNode.LocationType type, Mapbox.Utils.Vector2d locationMeters, string name = "")
        {
            ._positionMeters = locationMeters;
            mem[1152921524621874376] = locationMeters.y;
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = locationMeters.x, y = locationMeters.y});
            ._positionLatLon = val_2;
            mem[1152921524621874392] = val_2.y;
            return (MapMode.MovementNode.LocationNode)new MapMode.MovementNode.LocationNode(type:  type, name:  name);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static MapMode.MovementNode.LocationNode CreateNodeForLatLon(MapMode.MovementNode.LocationNode.LocationType type, Mapbox.Utils.Vector2d locationLatLon, string name = "")
        {
            ._positionLatLon = locationLatLon;
            mem[1152921524622010968] = locationLatLon.y;
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = locationLatLon.x, y = locationLatLon.y});
            ._positionMeters = val_2;
            mem[1152921524622010952] = val_2.y;
            return (MapMode.MovementNode.LocationNode)new MapMode.MovementNode.LocationNode(type:  type, name:  name);
        }
    
    }

}
