using UnityEngine;

namespace Mapbox.VectorTile
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VectorTileReader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, byte[]> _Layers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _Validate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VectorTileReader(byte[] data, bool validate = True)
        {
            string val_5;
            this._Layers = new System.Collections.Generic.Dictionary<System.String, System.Byte[]>();
            if(data == null)
            {
                goto label_1;
            }
            
            if(data.Length <= 0)
            {
                goto label_2;
            }
            
            if(data[0] == 31)
            {
                    if(data[0] == 139)
            {
                goto label_5;
            }
            
            }
            
            this._Validate = validate;
            this.layers(data:  data);
            return;
            label_1:
            val_5 = "Tile data cannot be null";
            goto label_7;
            label_2:
            val_5 = "Tile data cannot be empty";
            goto label_7;
            label_5:
            val_5 = "Tile data is zipped";
            label_7:
            null = new System.Exception(message:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void layers(byte[] data)
        {
            System.Byte[] val_17;
            var val_18;
            string val_19;
            ulong val_20;
            object val_21;
            string val_22;
            var val_23;
            var val_24;
            val_17 = data;
            Mapbox.VectorTile.PbfReader val_1 = new Mapbox.VectorTile.PbfReader(tileBuffer:  val_17);
            goto label_23;
            label_26:
            if(this._Validate == false)
            {
                goto label_2;
            }
            
            val_18 = null;
            val_18 = null;
            val_17 = Mapbox.VectorTile.Contants.ConstantsAsDictionary.TileType;
            if((val_17.ContainsKey(key:  (Mapbox.VectorTile.PbfReader)[1152921519887812400].<Tag>k__BackingField)) == false)
            {
                goto label_7;
            }
            
            label_2:
            if(val_1 == null)
            {
                goto label_8;
            }
            
            if(((Mapbox.VectorTile.PbfReader)[1152921519887812400].<Tag>k__BackingField) != 3)
            {
                goto label_9;
            }
            
            label_24:
            val_17 = val_1.View();
            Mapbox.VectorTile.PbfReader val_4 = new Mapbox.VectorTile.PbfReader(tileBuffer:  val_17);
            val_19 = 0;
            goto label_15;
            label_17:
            if(val_4 == null)
            {
                goto label_11;
            }
            
            if(((Mapbox.VectorTile.PbfReader)[1152921519887853360].<Tag>k__BackingField) != 1)
            {
                goto label_12;
            }
            
            val_20 = val_4.Varint();
            goto label_13;
            label_11:
            if(((Mapbox.VectorTile.PbfReader)[1152921519887853360].<Tag>k__BackingField) == 1)
            {
                goto label_14;
            }
            
            label_12:
            ulong val_6 = val_4.Skip();
            goto label_15;
            label_14:
            val_20 = val_4.Varint();
            label_13:
            val_19 = val_4.GetString(length:  val_20);
            label_15:
            if(val_4.NextByte() == true)
            {
                goto label_17;
            }
            
            if(this._Validate == false)
            {
                goto label_18;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_19)) == true)
            {
                goto label_19;
            }
            
            if((this._Layers.ContainsKey(key:  val_19)) == true)
            {
                goto label_21;
            }
            
            label_18:
            this._Layers.Add(key:  val_19, value:  val_17);
            goto label_23;
            label_8:
            val_17 = (Mapbox.VectorTile.PbfReader)[1152921519887812400].<Tag>k__BackingField;
            if(val_17 == 3)
            {
                goto label_24;
            }
            
            label_9:
            ulong val_12 = val_1.Skip();
            label_23:
            if(val_1.NextByte() == true)
            {
                goto label_26;
            }
            
            return;
            label_7:
            val_21 = (Mapbox.VectorTile.PbfReader)[1152921519887812400].<Tag>k__BackingField;
            val_22 = "Unknown tile tag: {0}";
            goto label_27;
            label_19:
            val_23 = 1152921519887710192;
            val_24 = new System.Exception(message:  "Layer missing name");
            goto label_28;
            label_21:
            val_21 = val_19;
            val_22 = "Duplicate layer names: {0}";
            label_27:
            val_23 = 1152921519887710192;
            val_24 = new System.Exception(message:  System.String.Format(format:  val_22, arg0:  val_21));
            label_28:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<string> LayerNames()
        {
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.String>(source:  this._Layers.Keys);
            if(val_2 != null)
            {
                    return val_2.AsReadOnly();
            }
            
            return val_2.AsReadOnly();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.VectorTile.VectorTileLayer GetLayer(string name)
        {
            if((this._Layers.ContainsKey(key:  name)) == false)
            {
                    return 0;
            }
            
            return this.getLayer(data:  this._Layers.Item[name]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.VectorTile.VectorTileLayer getLayer(byte[] data)
        {
            System.Byte[] val_35;
            var val_36;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_37;
            var val_39;
            val_35 = data;
            Mapbox.VectorTile.VectorTileLayer val_1 = new Mapbox.VectorTile.VectorTileLayer();
            .<Data>k__BackingField = val_35;
            if(val_1 == null)
            {
                    val_35 = (Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Data>k__BackingField;
            }
            
            Mapbox.VectorTile.PbfReader val_2 = new Mapbox.VectorTile.PbfReader(tileBuffer:  val_35);
            goto label_45;
            label_49:
            if(this._Validate == false)
            {
                goto label_4;
            }
            
            val_36 = null;
            val_36 = null;
            val_37 = Mapbox.VectorTile.Contants.ConstantsAsDictionary.LayerType;
            if((val_37.ContainsKey(key:  (Mapbox.VectorTile.PbfReader)[1152921519888786928].<Tag>k__BackingField)) == false)
            {
                goto label_8;
            }
            
            label_4:
            if((((Mapbox.VectorTile.PbfReader)[1152921519888786928].<Tag>k__BackingField) - 1) > 14)
            {
                goto label_9;
            }
            
            var val_35 = 52948600 + (((Mapbox.VectorTile.PbfReader)[1152921519888786928].<Tag>k__BackingField - 1)) << 2;
            val_35 = val_35 + 52948600;
            goto (52948600 + (((Mapbox.VectorTile.PbfReader)[1152921519888786928].<Tag>k__BackingField - 1)) << 2 + 52948600);
            label_9:
            ulong val_21 = val_2.Skip();
            label_45:
            if(val_2.NextByte() == true)
            {
                goto label_49;
            }
            
            if(this._Validate == false)
            {
                    return val_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  (Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Name>k__BackingField)) == true)
            {
                goto label_52;
            }
            
            if(((Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Version>k__BackingField) != 2)
            {
                goto label_53;
            }
            
            if(((Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Extent>k__BackingField) == 0)
            {
                goto label_54;
            }
            
            if(val_1.FeatureCount() == 0)
            {
                goto label_55;
            }
            
            if(((Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Values>k__BackingField.Count) != (System.Linq.Enumerable.Count<System.Object>(source:  System.Linq.Enumerable.Distinct<System.Object>(source:  (Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Values>k__BackingField))))
            {
                goto label_57;
            }
            
            return val_1;
            label_65:
            System.Exception val_31 = new System.Exception(message:  System.String.Format(provider:  System.Globalization.NumberFormatInfo.InvariantInfo, format:  "NOT IMPLEMENTED valueReader.Tag:{0} valueReader.WireType:{1}", arg0:  (Mapbox.VectorTile.PbfReader)[1152921519888913904].<Tag>k__BackingField, arg1:  (Mapbox.VectorTile.PbfReader)[1152921519888913904].<WireType>k__BackingField));
            label_59:
            label_8:
            label_64:
            string val_32 = System.String.Format(format:  "Unknown layer type: {0}", arg0:  null);
            goto label_65;
            label_52:
            System.Exception val_33 = new System.Exception(message:  "Layer has no name");
            goto label_59;
            label_53:
            if(((Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Version>k__BackingField) != 0)
            {
                goto label_60;
            }
            
            val_39 = "Layer [{0}] has invalid version. Only version 2.x of \'Mapbox Vector Tile Specification\' (https://github.com/mapbox/vector-tile-spec) is supported.";
            goto label_64;
            label_54:
            val_39 = "Layer [{0}] has no extent.";
            goto label_64;
            label_55:
            val_39 = "Layer [{0}] has no features.";
            goto label_64;
            label_57:
            val_39 = "Layer [{0}]: duplicate attribute values found";
            goto label_64;
            label_60:
            string val_34 = System.String.Format(format:  "Layer [{0}] has invalid version: {1}. Only version 2.x of \'Mapbox Vector Tile Specification\' (https://github.com/mapbox/vector-tile-spec) is supported.", arg0:  (Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Name>k__BackingField, arg1:  (Mapbox.VectorTile.VectorTileLayer)[1152921519888745968].<Version>k__BackingField);
            goto label_65;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.VectorTile.VectorTileFeature GetFeature(Mapbox.VectorTile.VectorTileLayer layer, byte[] data, bool validate = True, System.Nullable<uint> clipBuffer, float scale = 1)
        {
            bool val_28;
            System.Collections.Generic.List<System.Int32> val_29;
            Mapbox.VectorTile.VectorTileLayer val_30;
            var val_31;
            var val_32;
            var val_37;
            System.Func<System.Int32, System.Int32, System.Boolean> val_39;
            var val_40;
            System.Func<System.Int32, System.Int32, System.Boolean> val_42;
            val_28 = clipBuffer.HasValue;
            val_29 = validate;
            val_30 = layer;
            Mapbox.VectorTile.PbfReader val_1 = new Mapbox.VectorTile.PbfReader(tileBuffer:  data);
            val_31 = 0;
            goto label_21;
            label_29:
            val_28 = (Mapbox.VectorTile.PbfReader)[1152921519889374256].<Tag>k__BackingField;
            if(val_29 == false)
            {
                goto label_3;
            }
            
            val_32 = null;
            val_32 = null;
            if((Mapbox.VectorTile.Contants.ConstantsAsDictionary.FeatureType.ContainsKey(key:  val_28)) == false)
            {
                goto label_7;
            }
            
            label_3:
            if((val_28 - 1) > 3)
            {
                goto label_8;
            }
            
            var val_28 = 52948584 + (((Mapbox.VectorTile.PbfReader)[1152921519889374256].<Tag>k__BackingField - 1)) << 2;
            val_28 = val_28 + 52948584;
            goto (52948584 + (((Mapbox.VectorTile.PbfReader)[1152921519889374256].<Tag>k__BackingField - 1)) << 2 + 52948584);
            label_8:
            ulong val_6 = val_1.Skip();
            label_21:
            if(val_1.NextByte() == true)
            {
                goto label_29;
            }
            
            if(val_29 == false)
            {
                    return (Mapbox.VectorTile.VectorTileFeature)new Mapbox.VectorTile.VectorTileFeature(layer:  val_30, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = val_28}, scale:  scale);
            }
            
            if((( & 1) == 0) || (((Mapbox.VectorTile.VectorTileFeature)[1152921519889378352].<GeometryCommands>k__BackingField) == null))
            {
                goto label_58;
            }
            
            val_31 = 1152921517710430544;
            if((((Mapbox.VectorTile.VectorTileFeature)[1152921519889378352].<Tags>k__BackingField.Count) & 1) != 0)
            {
                goto label_58;
            }
            
            val_29 = (Mapbox.VectorTile.VectorTileFeature)[1152921519889378352].<Tags>k__BackingField;
            if(val_29.Count < 1)
            {
                    return (Mapbox.VectorTile.VectorTileFeature)new Mapbox.VectorTile.VectorTileFeature(layer:  val_30, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = val_28}, scale:  scale);
            }
            
            val_37 = null;
            val_37 = null;
            val_39 = VectorTileReader.<>c.<>9__7_1;
            if(val_39 == null)
            {
                    System.Func<System.Int32, System.Int32, System.Boolean> val_17 = null;
                val_39 = val_17;
                val_17 = new System.Func<System.Int32, System.Int32, System.Boolean>(object:  VectorTileReader.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean VectorTileReader.<>c::<GetFeature>b__7_1(int key, int idx));
                VectorTileReader.<>c.<>9__7_1 = val_39;
            }
            
            val_31 = 1152921519889219760;
            val_40 = null;
            val_40 = null;
            val_42 = VectorTileReader.<>c.<>9__7_2;
            if(val_42 == null)
            {
                    System.Func<System.Int32, System.Int32, System.Boolean> val_20 = null;
                val_42 = val_20;
                val_20 = new System.Func<System.Int32, System.Int32, System.Boolean>(object:  VectorTileReader.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean VectorTileReader.<>c::<GetFeature>b__7_2(int key, int idx));
                VectorTileReader.<>c.<>9__7_2 = val_42;
            }
            
            val_28 = mem[layer + 64];
            val_28 = layer + 64;
            if((System.Linq.Enumerable.Max(source:  System.Linq.Enumerable.Where<System.Int32>(source:  (Mapbox.VectorTile.VectorTileFeature)[1152921519889378352].<Tags>k__BackingField, predicate:  val_17))) >= val_28.Count)
            {
                goto label_58;
            }
            
            val_29 = mem[layer + 56];
            val_29 = layer + 56;
            if((System.Linq.Enumerable.Max(source:  System.Linq.Enumerable.Where<System.Int32>(source:  (Mapbox.VectorTile.VectorTileFeature)[1152921519889378352].<Tags>k__BackingField, predicate:  val_20))) >= val_29.Count)
            {
                goto label_58;
            }
            
            return (Mapbox.VectorTile.VectorTileFeature)new Mapbox.VectorTile.VectorTileFeature(layer:  val_30, clipBuffer:  new System.Nullable<System.UInt32>() {HasValue = val_28}, scale:  scale);
            label_7:
            string val_25 = System.String.Format(format:  "Layer [{0}] has unknown feature type: {1}", arg0:  layer.<Name>k__BackingField, arg1:  val_28);
            goto label_53;
            label_58:
            label_53:
            System.Exception val_27 = new System.Exception(message:  System.String.Format(format:  "Layer [{0}], feature already has a geometry", arg0:  layer.<Name>k__BackingField));
            goto label_58;
        }
    
    }

}
