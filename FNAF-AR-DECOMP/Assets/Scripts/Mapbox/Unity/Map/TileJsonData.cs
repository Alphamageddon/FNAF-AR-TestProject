using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class TileJsonData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string commonLayersKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string optionalPropertiesString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool tileJSONLoaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> LayerDisplayNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> PropertyDisplayNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> LayerPropertyDescriptionDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> LayerSourcesDictionary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> SourceLayersDictionary;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearData()
        {
            this.tileJSONLoaded = false;
            this.LayerPropertyDescriptionDictionary.Clear();
            this.LayerSourcesDictionary.Clear();
            this.SourceLayersDictionary.Clear();
            this.LayerDisplayNames.Clear();
            this.PropertyDisplayNames.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessTileJSONData(Mapbox.Platform.TilesetTileJSON.TileJSONResponse tjr)
        {
            var val_18;
            Mapbox.Platform.TilesetTileJSON.TileJSONResponse val_54;
            System.Collections.Generic.List<System.String> val_55;
            Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer[] val_56;
            var val_57;
            var val_58;
            var val_59;
            val_54 = tjr;
            val_55 = this;
            this.tileJSONLoaded = true;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            if(val_54 == null)
            {
                    return;
            }
            
            if((tjr.<VectorLayers>k__BackingField) == null)
            {
                    return;
            }
            
            if((tjr.<VectorLayers>k__BackingField.Length) == 0)
            {
                    return;
            }
            
            this.ClearData();
            val_56 = tjr.<VectorLayers>k__BackingField;
            val_57 = 1152921515834701216;
            val_58 = 0;
            goto label_4;
            label_130:
            Mapbox.Platform.TilesetTileJSON.TileJSONObjectVectorLayer val_53 = val_56[0];
            val_54 = tjr.<VectorLayers>k__BackingField[0x0][0].<Id>k__BackingField;
            if((this.LayerSourcesDictionary.ContainsKey(key:  val_54)) != false)
            {
                    this.LayerSourcesDictionary.Item[val_54].Add(item:  tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField);
            }
            else
            {
                    System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
                val_5.Add(item:  tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField);
                this.LayerSourcesDictionary.Add(key:  val_54, value:  val_5);
            }
            
            if((this.SourceLayersDictionary.ContainsKey(key:  tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField)) == false)
            {
                goto label_16;
            }
            
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
            bool val_8 = this.LayerSourcesDictionary.TryGetValue(key:  val_54, value: out  val_7);
            if((val_7.Count < 2) || ((val_7.Contains(item:  tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField)) == false))
            {
                goto label_21;
            }
            
            if((this.SourceLayersDictionary.ContainsKey(key:  this.commonLayersKey)) == false)
            {
                goto label_23;
            }
            
            this.SourceLayersDictionary.Item[this.commonLayersKey].Add(item:  val_54);
            goto label_26;
            label_16:
            System.Collections.Generic.List<System.String> val_13 = new System.Collections.Generic.List<System.String>();
            val_13.Add(item:  val_54);
            this.SourceLayersDictionary.Add(key:  tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField, value:  val_13);
            goto label_83;
            label_21:
            this.SourceLayersDictionary.Item[tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField].Add(item:  val_54);
            label_83:
            this.LayerDisplayNames.Add(item:  val_54);
            Dictionary.Enumerator<TKey, TValue> val_15 = tjr.<VectorLayers>k__BackingField[0x0][0].<Fields>k__BackingField.GetEnumerator();
            label_76:
            val_57 = 1152921515834701216;
            if(((-1983287824) & 1) == 0)
            {
                goto label_34;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_19 = val_18.trackableId;
            ulong val_20 = val_19.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            new System.Collections.Generic.List<System.String>().Add(item:  val_20);
            if((this.LayerPropertyDescriptionDictionary.ContainsKey(key:  val_54)) == false)
            {
                goto label_37;
            }
            
            if((this.LayerPropertyDescriptionDictionary.Item[val_54].ContainsKey(key:  val_20)) == true)
            {
                goto label_43;
            }
            
            this.LayerPropertyDescriptionDictionary.Item[val_54].Add(key:  val_20, value:  val_19.m_SubId1);
            goto label_43;
            label_37:
            System.Collections.Generic.Dictionary<System.String, System.String> val_25 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            null.Add(key:  val_20, value:  val_19.m_SubId1);
            this.LayerPropertyDescriptionDictionary.Add(key:  val_54, value:  null);
            label_43:
            if((this.PropertyDisplayNames.ContainsKey(key:  val_54)) == false)
            {
                goto label_47;
            }
            
            if((this.PropertyDisplayNames.Item[val_54].Contains(item:  val_20)) == true)
            {
                goto label_76;
            }
            
            this.PropertyDisplayNames.Item[val_54].Add(item:  val_20);
            if((this.LayerSourcesDictionary.Item[val_54].Count < 2) || ((System.String.IsNullOrEmpty(value:  tjr + 216)) == true))
            {
                goto label_76;
            }
            
            string[] val_33 = new string[1];
            val_33[0] = ",";
            if((System.String.op_Inequality(a:  tjr.<VectorLayers>k__BackingField[0x0][0].<Source>k__BackingField, b:  tjr + 216.Split(separator:  val_33, options:  0)[0].Trim())) == false)
            {
                goto label_76;
            }
            
            if((this.PropertyDisplayNames.Item[val_54].Contains(item:  val_20)) != false)
            {
                    bool val_40 = this.PropertyDisplayNames.Item[val_54].Remove(item:  val_20);
            }
            
            this.PropertyDisplayNames.Item[val_54].Add(item:  val_20);
            goto label_76;
            label_47:
            System.Collections.Generic.List<System.String> val_42 = new System.Collections.Generic.List<System.String>();
            null.Add(item:  val_20);
            this.PropertyDisplayNames.Add(key:  val_54, value:  null);
            goto label_76;
            label_34:
            val_59 = 0;
            goto label_77;
            label_23:
            System.Collections.Generic.List<System.String> val_43 = new System.Collections.Generic.List<System.String>();
            val_43.Add(item:  val_54);
            this.SourceLayersDictionary.Add(key:  this.commonLayersKey, value:  val_43);
            label_26:
            if((this.LayerDisplayNames.Contains(item:  val_54)) == false)
            {
                goto label_83;
            }
            
            goto label_83;
            label_77:
            long val_46 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519803428336});
            if(((0 == 0) ? 809 : 0) == 809)
            {
                
            }
            
            if((this.PropertyDisplayNames.ContainsKey(key:  val_54)) != false)
            {
                    if(this.PropertyDisplayNames.Item[val_54].Count >= 2)
            {
                    val_54 = this.PropertyDisplayNames.Item[val_54];
                val_54.Sort();
            }
            
            }
            
            val_56 = val_56;
            val_58 = 1;
            label_4:
            if(val_58 < (tjr.<VectorLayers>k__BackingField + 24))
            {
                goto label_130;
            }
            
            if(this.LayerDisplayNames.Count < 2)
            {
                    return;
            }
            
            val_55 = this.LayerDisplayNames;
            val_55.Sort();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileJsonData()
        {
            this.commonLayersKey = "(layer found in more than one data source)";
            this.optionalPropertiesString = "(may not appear across all locations)";
            this.LayerDisplayNames = new System.Collections.Generic.List<System.String>();
            this.PropertyDisplayNames = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
            this.LayerPropertyDescriptionDictionary = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>();
            this.LayerSourcesDictionary = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
            this.SourceLayersDictionary = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>();
        }
    
    }

}
