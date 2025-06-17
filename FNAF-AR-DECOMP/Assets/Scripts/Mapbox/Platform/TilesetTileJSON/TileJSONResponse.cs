using UnityEngine;

namespace Mapbox.Platform.TilesetTileJSON
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileJSONResponse
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Attribution>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <AutoScale>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] _bounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2dBounds <BoundsParsed>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double[] _center;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <CenterParsed>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<long> _created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<System.DateTime> <CreatedUtc>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Description>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Format>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <MaxZoom>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <MinZoom>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<long> _modified;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<System.DateTime> <ModifiedUtc>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Private>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Scheme>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Source>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <TileJSONVersion>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] <Tiles>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer[] <VectorLayers>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <WebPage>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Attribution { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AutoScale { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] Bounds { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds BoundsParsed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] Center { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d CenterParsed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> Created { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> CreatedUtc { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Format { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxZoom { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MinZoom { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> Modified { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> ModifiedUtc { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Private { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Scheme { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Source { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TileJSONVersion { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] Tiles { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer[] VectorLayers { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string WebPage { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Attribution()
        {
            return (string)this.<Attribution>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Attribution(string value)
        {
            this.<Attribution>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_AutoScale()
        {
            return (bool)this.<AutoScale>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_AutoScale(bool value)
        {
            this.<AutoScale>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] get_Bounds()
        {
            return (System.Double[])this._bounds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Bounds(double[] value)
        {
            this._bounds = value;
            Mapbox.Utils.Vector2d val_1 = new Mapbox.Utils.Vector2d(x:  value[1], y:  this._bounds[0]);
            Mapbox.Utils.Vector2d val_2 = new Mapbox.Utils.Vector2d(x:  this._bounds[3], y:  this._bounds[2]);
            this.<BoundsParsed>k__BackingField = 0;
            mem[1152921519956976736] = 0;
            mem[1152921519956976752] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds get_BoundsParsed()
        {
            Mapbox.Utils.Vector2dBounds val_0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_BoundsParsed(Mapbox.Utils.Vector2dBounds value)
        {
            this.<BoundsParsed>k__BackingField = new Mapbox.Utils.Vector2dBounds();
            mem[1152921519957360240] = ???;
            mem[1152921519957360248] = ???;
            mem[1152921519957360256] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double[] get_Center()
        {
            return (System.Double[])this._center;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Center(double[] value)
        {
            this._center = value;
            Mapbox.Utils.Vector2d val_1 = new Mapbox.Utils.Vector2d(x:  value[1], y:  this._center[0]);
            this.<CenterParsed>k__BackingField = val_1.x;
            mem[1152921519957735784] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_CenterParsed()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<CenterParsed>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CenterParsed(Mapbox.Utils.Vector2d value)
        {
            this.<CenterParsed>k__BackingField = value;
            mem[1152921519958033512] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> get_Created()
        {
            return (System.Nullable<System.Int64>)this._created;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Created(System.Nullable<long> value)
        {
            this._created = value.HasValue;
            mem[1152921519958257528] = X2;
            if((1152921519958257520 & 1) != 0)
            {
                    System.DateTime val_1 = Mapbox.Utils.UnixTimestampUtils.From(timestamp:  1152921519958257520);
                this.<CreatedUtc>k__BackingField = 0;
                mem[1152921519958257544] = 0;
                return;
            }
            
            this.<CreatedUtc>k__BackingField = 0;
            mem[1152921519958257544] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> get_CreatedUtc()
        {
            return (System.Nullable<System.DateTime>)this.<CreatedUtc>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CreatedUtc(System.Nullable<System.DateTime> value)
        {
            this.<CreatedUtc>k__BackingField = value;
            mem[1152921519958481544] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Description()
        {
            return (string)this.<Description>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Description(string value)
        {
            this.<Description>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Format()
        {
            return (string)this.<Format>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Format(string value)
        {
            this.<Format>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaxZoom()
        {
            return (int)this.<MaxZoom>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaxZoom(int value)
        {
            this.<MaxZoom>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MinZoom()
        {
            return (int)this.<MinZoom>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MinZoom(int value)
        {
            this.<MinZoom>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<long> get_Modified()
        {
            return (System.Nullable<System.Int64>)this._modified;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Modified(System.Nullable<long> value)
        {
            this._modified = value.HasValue;
            mem[1152921519959874744] = X2;
            if((1152921519959874736 & 1) != 0)
            {
                    System.DateTime val_1 = Mapbox.Utils.UnixTimestampUtils.From(timestamp:  1152921519959874736);
                this.<ModifiedUtc>k__BackingField = 0;
                mem[1152921519959874760] = 0;
                return;
            }
            
            this.<ModifiedUtc>k__BackingField = 0;
            mem[1152921519959874760] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> get_ModifiedUtc()
        {
            return (System.Nullable<System.DateTime>)this.<ModifiedUtc>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ModifiedUtc(System.Nullable<System.DateTime> value)
        {
            this.<ModifiedUtc>k__BackingField = value;
            mem[1152921519960098760] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Private()
        {
            return (bool)this.<Private>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Private(bool value)
        {
            this.<Private>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Scheme()
        {
            return (string)this.<Scheme>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Scheme(string value)
        {
            this.<Scheme>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Source()
        {
            return (string)this.<Source>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Source(string value)
        {
            this.<Source>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_TileJSONVersion()
        {
            return (string)this.<TileJSONVersion>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TileJSONVersion(string value)
        {
            this.<TileJSONVersion>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string[] get_Tiles()
        {
            return (System.String[])this.<Tiles>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Tiles(string[] value)
        {
            this.<Tiles>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer[] get_VectorLayers()
        {
            return (Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer[])this.<VectorLayers>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_VectorLayers(Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer[] value)
        {
            this.<VectorLayers>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_WebPage()
        {
            return (string)this.<WebPage>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_WebPage(string value)
        {
            this.<WebPage>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileJSONResponse()
        {
        
        }
    
    }

}
