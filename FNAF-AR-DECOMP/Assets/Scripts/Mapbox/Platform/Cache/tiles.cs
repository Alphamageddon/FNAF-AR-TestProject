using UnityEngine;

namespace Mapbox.Platform.Cache
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class tiles
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <tile_set>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <zoom_level>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <tile_column>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <tile_row>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] <tile_data>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <timestamp>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <etag>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<int> <lastmodified>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int tile_set { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int zoom_level { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long tile_column { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long tile_row { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] tile_data { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int timestamp { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string etag { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> lastmodified { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_tile_set()
        {
            return (int)this.<tile_set>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_tile_set(int value)
        {
            this.<tile_set>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_zoom_level()
        {
            return (int)this.<zoom_level>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_zoom_level(int value)
        {
            this.<zoom_level>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_tile_column()
        {
            return (long)this.<tile_column>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_tile_column(long value)
        {
            this.<tile_column>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_tile_row()
        {
            return (long)this.<tile_row>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_tile_row(long value)
        {
            this.<tile_row>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_tile_data()
        {
            return (System.Byte[])this.<tile_data>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_tile_data(byte[] value)
        {
            this.<tile_data>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_timestamp()
        {
            return (int)this.<timestamp>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_timestamp(int value)
        {
            this.<timestamp>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_etag()
        {
            return (string)this.<etag>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_etag(string value)
        {
            this.<etag>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> get_lastmodified()
        {
            return (System.Nullable<System.Int32>)this.<lastmodified>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_lastmodified(System.Nullable<int> value)
        {
            this.<lastmodified>k__BackingField = value.HasValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public tiles()
        {
        
        }
    
    }

}
