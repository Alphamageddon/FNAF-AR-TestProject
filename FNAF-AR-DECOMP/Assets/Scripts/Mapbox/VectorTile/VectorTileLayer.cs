using UnityEngine;

namespace Mapbox.VectorTile
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorTileLayer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] <Data>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong <Version>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ulong <Extent>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<byte[]> <_FeaturesData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<object> <Values>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> <Keys>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Data { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong Version { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong Extent { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<byte[]> _FeaturesData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<object> Values { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Keys { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTileLayer()
        {
            this.<_FeaturesData>k__BackingField = new System.Collections.Generic.List<System.Byte[]>();
            this.<Keys>k__BackingField = new System.Collections.Generic.List<System.String>();
            this.<Values>k__BackingField = new System.Collections.Generic.List<System.Object>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTileLayer(byte[] data)
        {
            this.<Data>k__BackingField = data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_Data()
        {
            return (System.Byte[])this.<Data>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Data(byte[] value)
        {
            this.<Data>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FeatureCount()
        {
            if((this.<_FeaturesData>k__BackingField) != null)
            {
                    return this.<_FeaturesData>k__BackingField.Count;
            }
            
            return this.<_FeaturesData>k__BackingField.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileFeature GetFeature(int feature, System.Nullable<uint> clipBuffer, float scale = 1)
        {
            return Mapbox.VectorTile.VectorTileReader.GetFeature(layer:  this, data:  this.<_FeaturesData>k__BackingField.Item[feature], validate:  true, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = clipBuffer.HasValue}, scale:  scale);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFeatureData(byte[] data)
        {
            this.<_FeaturesData>k__BackingField.Add(item:  data);
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
        public ulong get_Version()
        {
            return (ulong)this.<Version>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Version(ulong value)
        {
            this.<Version>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ulong get_Extent()
        {
            return (ulong)this.<Extent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Extent(ulong value)
        {
            this.<Extent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<byte[]> get__FeaturesData()
        {
            return (System.Collections.Generic.List<System.Byte[]>)this.<_FeaturesData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__FeaturesData(System.Collections.Generic.List<byte[]> value)
        {
            this.<_FeaturesData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<object> get_Values()
        {
            return (System.Collections.Generic.List<System.Object>)this.<Values>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Values(System.Collections.Generic.List<object> value)
        {
            this.<Values>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> get_Keys()
        {
            return (System.Collections.Generic.List<System.String>)this.<Keys>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Keys(System.Collections.Generic.List<string> value)
        {
            this.<Keys>k__BackingField = value;
        }
    
    }

}
