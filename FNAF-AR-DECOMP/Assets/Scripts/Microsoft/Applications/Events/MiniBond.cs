using UnityEngine;

namespace Microsoft.Applications.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class MiniBond
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Ingest value, bool isBase)
        {
            string val_13;
            long val_14;
            long val_15;
            long val_16;
            long val_17;
            val_13 = value;
            if(writer == null)
            {
                goto label_0;
            }
            
            label_6:
            if((value.<time>k__BackingField) == 0)
            {
                goto label_7;
            }
            
            if(writer == null)
            {
                goto label_3;
            }
            
            writer.WriteFieldBegin(type:  17, id:  1);
            val_14 = value.<time>k__BackingField;
            goto label_4;
            label_0:
            if(val_13 != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            0.WriteFieldBegin(type:  17, id:  1);
            val_14 = value.<time>k__BackingField;
            label_4:
            writer.writeVarint(value:  (val_14 << 1) ^ (val_14 >> 63));
            label_7:
            if((System.String.IsNullOrEmpty(value:  value.<clientIp>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value.<clientIp>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<clientIp>k__BackingField);
            }
            
            }
            
            if((value.<auth>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  17, id:  3);
                val_15 = value.<auth>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  17, id:  3);
                val_15 = value.<auth>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_15 << 1) ^ (val_15 >> 63));
            }
            
            if((value.<quality>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  17, id:  4);
                val_16 = value.<quality>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  17, id:  4);
                val_16 = value.<quality>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_16 << 1) ^ (val_16 >> 63));
            }
            
            if((value.<uploadTime>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  17, id:  5);
                val_17 = value.<uploadTime>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  17, id:  5);
                val_17 = value.<uploadTime>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_17 << 1) ^ (val_17 >> 63));
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<userAgent>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  6);
                writer.WriteString(value:  value.<userAgent>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  6);
                0.WriteString(value:  value.<userAgent>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<client>k__BackingField)) == false)
            {
                goto label_26;
            }
            
            if(writer != null)
            {
                goto label_30;
            }
            
            goto label_28;
            label_26:
            if(writer == null)
            {
                goto label_29;
            }
            
            writer.WriteFieldBegin(type:  9, id:  7);
            writer.WriteString(value:  value.<client>k__BackingField);
            goto label_30;
            label_29:
            0.WriteFieldBegin(type:  9, id:  7);
            val_13 = value.<client>k__BackingField;
            0.WriteString(value:  val_13);
            label_28:
            label_30:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.User value, bool isBase)
        {
            if((System.String.IsNullOrEmpty(value:  value.<id>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  1);
                writer.WriteString(value:  value.<id>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  1);
                0.WriteString(value:  value.<id>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<localId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value.<localId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<localId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<authId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  3);
                writer.WriteString(value:  value.<authId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  3);
                0.WriteString(value:  value.<authId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<locale>k__BackingField)) == false)
            {
                goto label_10;
            }
            
            if(writer != null)
            {
                goto label_14;
            }
            
            goto label_12;
            label_10:
            if(writer == null)
            {
                goto label_13;
            }
            
            writer.WriteFieldBegin(type:  9, id:  4);
            writer.WriteString(value:  value.<locale>k__BackingField);
            goto label_14;
            label_13:
            0.WriteFieldBegin(type:  9, id:  4);
            value = value.<locale>k__BackingField;
            0.WriteString(value:  value);
            label_12:
            label_14:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Device value, bool isBase)
        {
            if((System.String.IsNullOrEmpty(value:  value.<id>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  1);
                writer.WriteString(value:  value.<id>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  1);
                0.WriteString(value:  value.<id>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<localId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value.<localId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<localId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<authId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  3);
                writer.WriteString(value:  value.<authId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  3);
                0.WriteString(value:  value.<authId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<authSecId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  4);
                writer.WriteString(value:  value.<authSecId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  4);
                0.WriteString(value:  value.<authSecId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<deviceClass>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  5);
                writer.WriteString(value:  value.<deviceClass>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  5);
                0.WriteString(value:  value.<deviceClass>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<orgId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  6);
                writer.WriteString(value:  value.<orgId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  6);
                0.WriteString(value:  value.<orgId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<orgAuthId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  7);
                writer.WriteString(value:  value.<orgAuthId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  7);
                0.WriteString(value:  value.<orgAuthId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<make>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  8);
                writer.WriteString(value:  value.<make>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  8);
                0.WriteString(value:  value.<make>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<model>k__BackingField)) == false)
            {
                goto label_25;
            }
            
            if(writer != null)
            {
                goto label_29;
            }
            
            goto label_27;
            label_25:
            if(writer == null)
            {
                goto label_28;
            }
            
            writer.WriteFieldBegin(type:  9, id:  9);
            writer.WriteString(value:  value.<model>k__BackingField);
            goto label_29;
            label_28:
            0.WriteFieldBegin(type:  9, id:  9);
            value = value.<model>k__BackingField;
            0.WriteString(value:  value);
            label_27:
            label_29:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Os value, bool isBase)
        {
            string val_8;
            int val_9;
            val_8 = value;
            if((System.String.IsNullOrEmpty(value:  value.<locale>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  1);
                writer.WriteString(value:  value.<locale>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  1);
                0.WriteString(value:  value.<locale>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<expId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value.<expId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<expId>k__BackingField);
            }
            
            }
            
            if((value.<bootId>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  16, id:  3);
                val_9 = value.<bootId>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  16, id:  3);
                val_9 = value.<bootId>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_9 << 1) ^ (val_9 >> 31));
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<name>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  4);
                writer.WriteString(value:  value.<name>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  4);
                0.WriteString(value:  value.<name>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<ver>k__BackingField)) == false)
            {
                goto label_14;
            }
            
            if(writer != null)
            {
                goto label_18;
            }
            
            goto label_16;
            label_14:
            if(writer == null)
            {
                goto label_17;
            }
            
            writer.WriteFieldBegin(type:  9, id:  5);
            writer.WriteString(value:  value.<ver>k__BackingField);
            goto label_18;
            label_17:
            0.WriteFieldBegin(type:  9, id:  5);
            val_8 = value.<ver>k__BackingField;
            0.WriteString(value:  val_8);
            label_16:
            label_18:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.App value, bool isBase)
        {
            string val_11;
            int val_12;
            val_11 = value;
            if((System.String.IsNullOrEmpty(value:  value.<expId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  1);
                writer.WriteString(value:  value.<expId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  1);
                0.WriteString(value:  value.<expId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<userId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value.<userId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<userId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<env>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  3);
                writer.WriteString(value:  value.<env>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  3);
                0.WriteString(value:  value.<env>k__BackingField);
            }
            
            }
            
            if((value.<asId>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  16, id:  4);
                val_12 = value.<asId>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  16, id:  4);
                val_12 = value.<asId>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_12 << 1) ^ (val_12 >> 31));
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<id>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  5);
                writer.WriteString(value:  value.<id>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  5);
                0.WriteString(value:  value.<id>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<ver>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  6);
                writer.WriteString(value:  value.<ver>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  6);
                0.WriteString(value:  value.<ver>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<locale>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  7);
                writer.WriteString(value:  value.<locale>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  7);
                0.WriteString(value:  value.<locale>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<name>k__BackingField)) == false)
            {
                goto label_23;
            }
            
            if(writer != null)
            {
                goto label_27;
            }
            
            goto label_25;
            label_23:
            if(writer == null)
            {
                goto label_26;
            }
            
            writer.WriteFieldBegin(type:  9, id:  8);
            writer.WriteString(value:  value.<name>k__BackingField);
            goto label_27;
            label_26:
            0.WriteFieldBegin(type:  9, id:  8);
            val_11 = value.<name>k__BackingField;
            0.WriteString(value:  val_11);
            label_25:
            label_27:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Utc value, bool isBase)
        {
            long val_18;
            long val_19;
            long val_20;
            int val_21;
            val_18 = value;
            if((System.String.IsNullOrEmpty(value:  value.<stId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  1);
                writer.WriteString(value:  value.<stId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  1);
                0.WriteString(value:  value.<stId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<aId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value.<aId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<aId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<raId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  3);
                writer.WriteString(value:  value.<raId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  3);
                0.WriteString(value:  value.<raId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<op>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  4);
                writer.WriteString(value:  value.<op>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  4);
                0.WriteString(value:  value.<op>k__BackingField);
            }
            
            }
            
            if((value.<cat>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  17, id:  5);
                val_19 = value.<cat>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  17, id:  5);
                val_19 = value.<cat>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_19 << 1) ^ (val_19 >> 63));
            }
            
            if((value.<flags>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  17, id:  6);
                val_20 = value.<flags>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  17, id:  6);
                val_20 = value.<flags>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_20 << 1) ^ (val_20 >> 63));
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<sqmId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  7);
                writer.WriteString(value:  value.<sqmId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  7);
                0.WriteString(value:  value.<sqmId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<mon>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  9);
                writer.WriteString(value:  value.<mon>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  9);
                0.WriteString(value:  value.<mon>k__BackingField);
            }
            
            }
            
            if((value.<cpId>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  16, id:  10);
                val_21 = value.<cpId>k__BackingField;
            }
            else
            {
                    0.WriteFieldBegin(type:  16, id:  10);
                val_21 = value.<cpId>k__BackingField;
            }
            
                writer.writeVarint(value:  (val_21 << 1) ^ (val_21 >> 31));
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<bSeq>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  11);
                writer.WriteString(value:  value.<bSeq>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  11);
                0.WriteString(value:  value.<bSeq>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<epoch>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  12);
                writer.WriteString(value:  value.<epoch>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  12);
                0.WriteString(value:  value.<epoch>k__BackingField);
            }
            
            }
            
            if((value.<seq>k__BackingField) == 0)
            {
                goto label_37;
            }
            
            if(writer == null)
            {
                goto label_38;
            }
            
            writer.WriteFieldBegin(type:  17, id:  13);
            val_18 = value.<seq>k__BackingField;
            goto label_39;
            label_37:
            if(writer != null)
            {
                goto label_42;
            }
            
            goto label_41;
            label_38:
            0.WriteFieldBegin(type:  17, id:  13);
            val_18 = value.<seq>k__BackingField;
            label_39:
            writer.writeVarint(value:  (val_18 << 1) ^ (val_18 >> 63));
            if(writer != null)
            {
                goto label_42;
            }
            
            label_41:
            label_42:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Xbl value, bool isBase)
        {
            var val_6;
            string val_25;
            var val_26;
            var val_27;
            val_25 = value;
            if((value.<claims>k__BackingField) == null)
            {
                goto label_3;
            }
            
            val_26 = 1152921526153450976;
            if((value.<claims>k__BackingField.Count) == 0)
            {
                goto label_3;
            }
            
            writer.WriteFieldBegin(type:  13, id:  5);
            writer.WriteMapContainerBegin(size:  value.<claims>k__BackingField.Count, keyType:  9, valueType:  9);
            Dictionary.Enumerator<TKey, TValue> val_3 = value.<claims>k__BackingField.GetEnumerator();
            label_11:
            if((71940160 & 1) == 0)
            {
                goto label_8;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_7 = val_6.trackableId;
            writer.WriteString(value:  val_7.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()));
            writer.WriteString(value:  val_7.m_SubId1);
            goto label_11;
            label_8:
            val_27 = 0;
            val_26 = 1;
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526153623616});
            if(writer == null)
            {
                goto label_20;
            }
            
            label_3:
            if(val_25 != null)
            {
                goto label_71;
            }
            
            label_72:
            label_71:
            if((System.String.IsNullOrEmpty(value:  value.<nbf>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  10);
                writer.WriteString(value:  value.<nbf>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  10);
                0.WriteString(value:  value.<nbf>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<exp>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  20);
                writer.WriteString(value:  value.<exp>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  20);
                0.WriteString(value:  value.<exp>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<sbx>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  30);
                writer.WriteString(value:  value.<sbx>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  30);
                0.WriteString(value:  value.<sbx>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<dty>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  40);
                writer.WriteString(value:  value.<dty>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  40);
                0.WriteString(value:  value.<dty>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<did>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  50);
                writer.WriteString(value:  value.<did>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  50);
                0.WriteString(value:  value.<did>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<xid>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  60);
                writer.WriteString(value:  value.<xid>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  60);
                0.WriteString(value:  value.<xid>k__BackingField);
            }
            
            }
            
            if((value.<uts>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  6, id:  70);
                writer.writeVarint(value:  value.<uts>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  6, id:  70);
                0.writeVarint(value:  value.<uts>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<pid>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  80);
                writer.WriteString(value:  value.<pid>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  80);
                0.WriteString(value:  value.<pid>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<dvr>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  90);
                writer.WriteString(value:  value.<dvr>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  90);
                0.WriteString(value:  value.<dvr>k__BackingField);
            }
            
            }
            
            if((value.<tid>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  5, id:  100);
                writer.writeVarint(value:  value.<tid>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  5, id:  100);
                0.writeVarint(value:  value.<tid>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<tvr>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  110);
                writer.WriteString(value:  value.<tvr>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  110);
                0.WriteString(value:  value.<tvr>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<sty>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  120);
                writer.WriteString(value:  value.<sty>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  120);
                0.WriteString(value:  value.<sty>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<sid>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  130);
                writer.WriteString(value:  value.<sid>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  130);
                0.WriteString(value:  value.<sid>k__BackingField);
            }
            
            }
            
            if((value.<eid>k__BackingField.emailUIDataHandler) == null)
            {
                    if((71940128 & 1) != 0)
            {
                goto label_65;
            }
            
            }
            
            writer.WriteFieldBegin(type:  17, id:  140);
            if(writer != null)
            {
                    writer.writeVarint(value:  2305843052307247168);
            }
            else
            {
                    0.writeVarint(value:  2305843052307247168);
            }
            
            label_65:
            if((System.String.IsNullOrEmpty(value:  value.<ip>k__BackingField)) == false)
            {
                goto label_66;
            }
            
            if(writer != null)
            {
                goto label_70;
            }
            
            goto label_68;
            label_66:
            if(writer == null)
            {
                goto label_69;
            }
            
            writer.WriteFieldBegin(type:  9, id:  150);
            writer.WriteString(value:  value.<ip>k__BackingField);
            goto label_70;
            label_69:
            0.WriteFieldBegin(type:  9, id:  150);
            val_25 = value.<ip>k__BackingField;
            0.WriteString(value:  val_25);
            label_68:
            label_70:
            writer.WriteStructEnd(isBase:  isBase);
            return;
            label_20:
            if(val_25 != null)
            {
                goto label_71;
            }
            
            goto label_72;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Javascript value, bool isBase)
        {
            if((System.String.IsNullOrEmpty(value:  value.<libVer>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  10);
                writer.WriteString(value:  value.<libVer>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  10);
                0.WriteString(value:  value.<libVer>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<osName>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  15);
                writer.WriteString(value:  value.<osName>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  15);
                0.WriteString(value:  value.<osName>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<browser>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  20);
                writer.WriteString(value:  value.<browser>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  20);
                0.WriteString(value:  value.<browser>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<browserVersion>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  21);
                writer.WriteString(value:  value.<browserVersion>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  21);
                0.WriteString(value:  value.<browserVersion>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<platform>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  25);
                writer.WriteString(value:  value.<platform>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  25);
                0.WriteString(value:  value.<platform>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<make>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  30);
                writer.WriteString(value:  value.<make>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  30);
                0.WriteString(value:  value.<make>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<model>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  35);
                writer.WriteString(value:  value.<model>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  35);
                0.WriteString(value:  value.<model>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<screenSize>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  40);
                writer.WriteString(value:  value.<screenSize>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  40);
                0.WriteString(value:  value.<screenSize>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<mc1Id>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  50);
                writer.WriteString(value:  value.<mc1Id>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  50);
                0.WriteString(value:  value.<mc1Id>k__BackingField);
            }
            
            }
            
            if((value.<mc1Lu>k__BackingField) != 0)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  6, id:  60);
                writer.writeVarint(value:  value.<mc1Lu>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  6, id:  60);
                0.writeVarint(value:  value.<mc1Lu>k__BackingField);
            }
            
            }
            
            if((value.<isMc1New>k__BackingField) != false)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  2, id:  70);
                writer.WriteBool(value:  value.<isMc1New>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  2, id:  70);
                0.WriteBool(value:  value.<isMc1New>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<ms0>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  80);
                writer.WriteString(value:  value.<ms0>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  80);
                0.WriteString(value:  value.<ms0>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<anid>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  90);
                writer.WriteString(value:  value.<anid>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  90);
                0.WriteString(value:  value.<anid>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<a>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  100);
                writer.WriteString(value:  value.<a>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  100);
                0.WriteString(value:  value.<a>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<msResearch>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  110);
                writer.WriteString(value:  value.<msResearch>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  110);
                0.WriteString(value:  value.<msResearch>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<csrvc>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  120);
                writer.WriteString(value:  value.<csrvc>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  120);
                0.WriteString(value:  value.<csrvc>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<rtCell>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  130);
                writer.WriteString(value:  value.<rtCell>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  130);
                0.WriteString(value:  value.<rtCell>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<rtEndAction>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  140);
                writer.WriteString(value:  value.<rtEndAction>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  140);
                0.WriteString(value:  value.<rtEndAction>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<rtPermId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  150);
                writer.WriteString(value:  value.<rtPermId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  150);
                0.WriteString(value:  value.<rtPermId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<r>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  160);
                writer.WriteString(value:  value.<r>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  160);
                0.WriteString(value:  value.<r>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<wtFpc>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  170);
                writer.WriteString(value:  value.<wtFpc>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  170);
                0.WriteString(value:  value.<wtFpc>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<omniId>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  180);
                writer.WriteString(value:  value.<omniId>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  180);
                0.WriteString(value:  value.<omniId>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<gsfxSession>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  190);
                writer.WriteString(value:  value.<gsfxSession>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  190);
                0.WriteString(value:  value.<gsfxSession>k__BackingField);
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<domain>k__BackingField)) != true)
            {
                    if(writer != null)
            {
                    writer.WriteFieldBegin(type:  9, id:  200);
                writer.WriteString(value:  value.<domain>k__BackingField);
            }
            else
            {
                    0.WriteFieldBegin(type:  9, id:  200);
                0.WriteString(value:  value.<domain>k__BackingField);
            }
            
            }
            
            bool val_23 = System.String.IsNullOrEmpty(value:  value.<dnt>k__BackingField);
            if(writer == null)
            {
                goto label_73;
            }
            
            if(val_23 == false)
            {
                goto label_74;
            }
            
            label_77:
            if(writer != null)
            {
                goto label_79;
            }
            
            goto label_76;
            label_73:
            if(val_23 == true)
            {
                goto label_77;
            }
            
            label_74:
            writer.WriteFieldBegin(type:  9, id:  999);
            value = value.<dnt>k__BackingField;
            if(writer == null)
            {
                goto label_78;
            }
            
            writer.WriteString(value:  value);
            goto label_79;
            label_78:
            0.WriteString(value:  value);
            label_76:
            label_79:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Protocol value, bool isBase)
        {
            var val_10;
            var val_21;
            var val_22;
            val_21 = value;
            if((value.<metadataCrc>k__BackingField) != 0)
            {
                    writer.WriteFieldBegin(type:  16, id:  1);
                if(writer != null)
            {
                    writer.writeVarint(value:  ((value.<metadataCrc>k__BackingField) << 1) ^ ((value.<metadataCrc>k__BackingField) >> 31));
            }
            else
            {
                    0.writeVarint(value:  ((value.<metadataCrc>k__BackingField) << 1) ^ ((value.<metadataCrc>k__BackingField) >> 31));
            }
            
            }
            
            if(((value.<ticketKeys>k__BackingField) == null) || ((value.<ticketKeys>k__BackingField.Count) == 0))
            {
                goto label_7;
            }
            
            writer.WriteFieldBegin(type:  11, id:  2);
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  (value.<ticketKeys>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_8 = value.<ticketKeys>k__BackingField.GetEnumerator();
            val_21 = 0;
            val_22 = 0;
            label_29:
            if((72943424 & 1) == 0)
            {
                goto label_32;
            }
            
            GameUI.EmailUIDataHandler val_11 = val_10.emailUIDataHandler;
            writer.WriteUInt8(value:  9);
            writer.writeVarint(value:  val_11.Count & 65535);
            List.Enumerator<T> val_14 = val_11.GetEnumerator();
            label_18:
            if((72943392 & 1) == 0)
            {
                goto label_19;
            }
            
            writer.WriteString(value:  val_10.emailUIDataHandler);
            goto label_18;
            label_19:
            long val_16 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526154626848});
            if(((188 == 0) ? 188 : 188) != 188)
            {
                goto label_22;
            }
            
            if(writer != null)
            {
                goto label_29;
            }
            
            goto label_29;
            label_22:
            if( == 0)
            {
                goto label_25;
            }
            
            if(writer != null)
            {
                goto label_29;
            }
            
            goto label_29;
            label_25:
            if(writer != null)
            {
                goto label_29;
            }
            
            goto label_29;
            label_7:
            if(writer != null)
            {
                goto label_42;
            }
            
            goto label_31;
            label_32:
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526154626880});
            if(writer != null)
            {
                goto label_42;
            }
            
            label_31:
            label_42:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Receipts value, bool isBase)
        {
            var val_8;
            long val_9;
            val_8 = value;
            if(writer == null)
            {
                goto label_1;
            }
            
            if((value.<originalTime>k__BackingField) == 0)
            {
                goto label_2;
            }
            
            label_6:
            writer.WriteFieldBegin(type:  17, id:  1);
            if(writer == null)
            {
                goto label_3;
            }
            
            writer.writeVarint(value:  ((value.<originalTime>k__BackingField) << 1) ^ ((value.<originalTime>k__BackingField) >> 63));
            if((value.<uploadTime>k__BackingField) != 0)
            {
                goto label_4;
            }
            
            goto label_11;
            label_1:
            if((value.<originalTime>k__BackingField) != 0)
            {
                goto label_6;
            }
            
            label_2:
            val_9 = value.<uploadTime>k__BackingField;
            if(writer == null)
            {
                goto label_7;
            }
            
            if(val_9 == 0)
            {
                goto label_11;
            }
            
            label_4:
            writer.WriteFieldBegin(type:  17, id:  2);
            val_8 = mem[value + 24];
            val_8 = value + 24;
            goto label_9;
            label_3:
            0.writeVarint(value:  ((value.<originalTime>k__BackingField) << 1) ^ ((value.<originalTime>k__BackingField) >> 63));
            val_9 = value.<uploadTime>k__BackingField;
            label_7:
            if(val_9 == 0)
            {
                goto label_10;
            }
            
            writer.WriteFieldBegin(type:  17, id:  2);
            val_8 = mem[value + 24];
            val_8 = value + 24;
            label_9:
            writer.writeVarint(value:  (val_8 << 1) ^ (val_8 >> 63));
            if(writer != null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Net value, bool isBase)
        {
            string val_8;
            var val_9;
            var val_10;
            val_8 = value;
            bool val_1 = System.String.IsNullOrEmpty(value:  value.<provider>k__BackingField);
            if(writer == null)
            {
                goto label_1;
            }
            
            if(val_1 == false)
            {
                goto label_2;
            }
            
            label_7:
            val_9 = val_8;
            val_10 = System.String.IsNullOrEmpty(value:  value.<cost>k__BackingField);
            if(writer == null)
            {
                goto label_3;
            }
            
            if(val_10 == true)
            {
                goto label_10;
            }
            
            label_9:
            writer.WriteFieldBegin(type:  9, id:  2);
            writer.WriteString(value:  value + 24);
            label_10:
            if((System.String.IsNullOrEmpty(value:  value.<type>k__BackingField)) == true)
            {
                goto label_6;
            }
            
            writer.WriteFieldBegin(type:  9, id:  3);
            writer.WriteString(value:  value.<type>k__BackingField);
            goto label_6;
            label_1:
            if(val_1 == true)
            {
                goto label_7;
            }
            
            label_2:
            writer.WriteFieldBegin(type:  9, id:  1);
            if(writer == null)
            {
                goto label_8;
            }
            
            writer.WriteString(value:  value.<provider>k__BackingField);
            if((System.String.IsNullOrEmpty(value:  value.<cost>k__BackingField)) == false)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            0.WriteString(value:  value.<provider>k__BackingField);
            val_9 = val_8;
            val_10 = System.String.IsNullOrEmpty(value:  value.<cost>k__BackingField);
            label_3:
            if(val_10 != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value + 24);
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<type>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  3);
                val_8 = value.<type>k__BackingField;
                0.WriteString(value:  val_8);
            }
            
            label_6:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Loc value, bool isBase)
        {
            string val_8;
            var val_9;
            var val_10;
            val_8 = value;
            bool val_1 = System.String.IsNullOrEmpty(value:  value.<id>k__BackingField);
            if(writer == null)
            {
                goto label_1;
            }
            
            if(val_1 == false)
            {
                goto label_2;
            }
            
            label_7:
            val_9 = val_8;
            val_10 = System.String.IsNullOrEmpty(value:  value.<country>k__BackingField);
            if(writer == null)
            {
                goto label_3;
            }
            
            if(val_10 == true)
            {
                goto label_10;
            }
            
            label_9:
            writer.WriteFieldBegin(type:  9, id:  2);
            writer.WriteString(value:  value + 24);
            label_10:
            if((System.String.IsNullOrEmpty(value:  value.<timezone>k__BackingField)) == true)
            {
                goto label_6;
            }
            
            writer.WriteFieldBegin(type:  9, id:  3);
            writer.WriteString(value:  value.<timezone>k__BackingField);
            goto label_6;
            label_1:
            if(val_1 == true)
            {
                goto label_7;
            }
            
            label_2:
            writer.WriteFieldBegin(type:  9, id:  1);
            if(writer == null)
            {
                goto label_8;
            }
            
            writer.WriteString(value:  value.<id>k__BackingField);
            if((System.String.IsNullOrEmpty(value:  value.<country>k__BackingField)) == false)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            0.WriteString(value:  value.<id>k__BackingField);
            val_9 = val_8;
            val_10 = System.String.IsNullOrEmpty(value:  value.<country>k__BackingField);
            label_3:
            if(val_10 != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value + 24);
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<timezone>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  3);
                val_8 = value.<timezone>k__BackingField;
                0.WriteString(value:  val_8);
            }
            
            label_6:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Sdk value, bool isBase)
        {
            string val_10;
            var val_11;
            var val_12;
            val_10 = value;
            bool val_1 = System.String.IsNullOrEmpty(value:  value.<libVer>k__BackingField);
            if(writer == null)
            {
                goto label_1;
            }
            
            if(val_1 == false)
            {
                goto label_2;
            }
            
            label_6:
            val_11 = System.String.IsNullOrEmpty(value:  value.<epoch>k__BackingField);
            if(writer == null)
            {
                goto label_3;
            }
            
            if(val_11 == false)
            {
                goto label_4;
            }
            
            goto label_8;
            label_1:
            if(val_1 == true)
            {
                goto label_6;
            }
            
            label_2:
            writer.WriteFieldBegin(type:  9, id:  1);
            if(writer == null)
            {
                goto label_7;
            }
            
            writer.WriteString(value:  value.<libVer>k__BackingField);
            if((System.String.IsNullOrEmpty(value:  value.<epoch>k__BackingField)) == true)
            {
                goto label_8;
            }
            
            label_4:
            writer.WriteFieldBegin(type:  9, id:  2);
            writer.WriteString(value:  value.<epoch>k__BackingField);
            label_8:
            if((value.<seq>k__BackingField) == 0)
            {
                goto label_9;
            }
            
            writer.WriteFieldBegin(type:  17, id:  3);
            val_12 = mem[value + 32];
            val_12 = value + 32;
            goto label_10;
            label_7:
            0.WriteString(value:  value.<libVer>k__BackingField);
            val_11 = System.String.IsNullOrEmpty(value:  value.<epoch>k__BackingField);
            label_3:
            if(val_11 != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                0.WriteString(value:  value.<epoch>k__BackingField);
            }
            
            if((value.<seq>k__BackingField) == 0)
            {
                goto label_12;
            }
            
            writer.WriteFieldBegin(type:  17, id:  3);
            val_12 = mem[value + 32];
            val_12 = value + 32;
            label_10:
            writer.writeVarint(value:  (val_12 << 1) ^ (val_12 >> 63));
            if(writer == null)
            {
                goto label_13;
            }
            
            label_9:
            if((System.String.IsNullOrEmpty(value:  value.<installId>k__BackingField)) == true)
            {
                goto label_15;
            }
            
            writer.WriteFieldBegin(type:  9, id:  4);
            writer.WriteString(value:  value.<installId>k__BackingField);
            goto label_15;
            label_13:
            label_12:
            if((System.String.IsNullOrEmpty(value:  value.<installId>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  4);
                val_10 = value.<installId>k__BackingField;
                0.WriteString(value:  val_10);
            }
            
            label_15:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.PII value, bool isBase)
        {
            if(writer == null)
            {
                goto label_1;
            }
            
            if((value.<Kind>k__BackingField) == 0)
            {
                goto label_2;
            }
            
            label_5:
            writer.WriteFieldBegin(type:  16, id:  1);
            value = value.<Kind>k__BackingField;
            if(writer == null)
            {
                goto label_3;
            }
            
            writer.writeVarint(value:  (value << 1) ^ (value >> 31));
            goto label_6;
            label_1:
            if((value.<Kind>k__BackingField) != 0)
            {
                goto label_5;
            }
            
            label_2:
            if(writer != null)
            {
                goto label_6;
            }
            
            goto label_7;
            label_3:
            0.writeVarint(value:  (value << 1) ^ (value >> 31));
            label_7:
            label_6:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.CustomerContent value, bool isBase)
        {
            if(writer == null)
            {
                goto label_1;
            }
            
            if((value.<Kind>k__BackingField) == 0)
            {
                goto label_2;
            }
            
            label_5:
            writer.WriteFieldBegin(type:  16, id:  1);
            value = value.<Kind>k__BackingField;
            if(writer == null)
            {
                goto label_3;
            }
            
            writer.writeVarint(value:  (value << 1) ^ (value >> 31));
            goto label_6;
            label_1:
            if((value.<Kind>k__BackingField) != 0)
            {
                goto label_5;
            }
            
            label_2:
            if(writer != null)
            {
                goto label_6;
            }
            
            goto label_7;
            label_3:
            0.writeVarint(value:  (value << 1) ^ (value >> 31));
            label_7:
            label_6:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Attributes value, bool isBase)
        {
            var val_5;
            Microsoft.Applications.Events.DataModels.Attributes val_17 = value;
            if(writer == null)
            {
                goto label_2;
            }
            
            if((value.<pii>k__BackingField) == null)
            {
                goto label_3;
            }
            
            label_9:
            writer.WriteFieldBegin(type:  11, id:  1);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<pii>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_3 = value.<pii>k__BackingField.GetEnumerator();
            label_8:
            if((74180064 & 1) == 0)
            {
                goto label_7;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_5.emailUIDataHandler, isBase:  false);
            goto label_8;
            label_2:
            if((value.<pii>k__BackingField) != null)
            {
                goto label_9;
            }
            
            label_3:
            if(val_17 != null)
            {
                goto label_29;
            }
            
            goto label_30;
            label_7:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526155863520});
            if(writer != null)
            {
                goto label_12;
            }
            
            goto label_17;
            label_12:
            if(val_17 != null)
            {
                goto label_29;
            }
            
            label_30:
            label_29:
            if(writer == null)
            {
                goto label_19;
            }
            
            if((value.<customerContent>k__BackingField) == null)
            {
                goto label_20;
            }
            
            label_26:
            writer.WriteFieldBegin(type:  11, id:  2);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<customerContent>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_11 = value.<customerContent>k__BackingField.GetEnumerator();
            val_17 = 1152921526155840352;
            label_25:
            if((74180040 & 1) == 0)
            {
                goto label_24;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  0.emailUIDataHandler, isBase:  false);
            goto label_25;
            label_19:
            if((value.<customerContent>k__BackingField) != null)
            {
                goto label_26;
            }
            
            label_20:
            if(writer != null)
            {
                goto label_37;
            }
            
            goto label_28;
            label_17:
            if(val_17 != null)
            {
                goto label_29;
            }
            
            goto label_30;
            label_24:
            long val_13 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526155863496});
            if(writer != null)
            {
                goto label_37;
            }
            
            label_28:
            label_37:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Value value, bool isBase)
        {
            var val_9;
            var val_34;
            var val_49;
            var val_66;
            var val_81;
            var val_91;
            bool val_102;
            System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<System.Int64>>> val_103;
            var val_104;
            System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Attributes> val_105;
            var val_106;
            long val_107;
            var val_108;
            var val_109;
            var val_110;
            double val_111;
            var val_112;
            var val_113;
            var val_115;
            var val_116;
            var val_118;
            var val_120;
            var val_122;
            bool val_125;
            val_102 = isBase;
            val_103 = value;
            if((value.<type>k__BackingField) != 5)
            {
                goto label_3;
            }
            
            val_104 = val_103;
            val_105 = value.<attributes>k__BackingField;
            if(writer == null)
            {
                goto label_4;
            }
            
            if(val_105 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_3:
            writer.WriteFieldBegin(type:  16, id:  1);
            if(writer == null)
            {
                goto label_7;
            }
            
            writer.writeVarint(value:  ((value.<type>k__BackingField) << 1) ^ ((value.<type>k__BackingField) >> 31));
            val_104 = val_103;
            if((value.<attributes>k__BackingField) != null)
            {
                goto label_8;
            }
            
            label_11:
            if(val_103 != null)
            {
                goto label_33;
            }
            
            goto label_34;
            label_7:
            0.writeVarint(value:  ((value.<type>k__BackingField) << 1) ^ ((value.<type>k__BackingField) >> 31));
            val_104 = val_103;
            val_105 = value.<attributes>k__BackingField;
            label_4:
            if(val_105 == null)
            {
                goto label_11;
            }
            
            label_8:
            writer.WriteFieldBegin(type:  11, id:  2);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value + 24.Count) & 65535);
            List.Enumerator<T> val_7 = value + 24.GetEnumerator();
            label_16:
            if((74512176 & 1) == 0)
            {
                goto label_15;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_9.emailUIDataHandler, isBase:  false);
            goto label_16;
            label_15:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195632});
            if(writer != null)
            {
                goto label_17;
            }
            
            goto label_22;
            label_17:
            if(val_103 != null)
            {
                goto label_33;
            }
            
            label_34:
            label_33:
            bool val_13 = System.String.IsNullOrEmpty(value:  value.<stringValue>k__BackingField);
            if(writer == null)
            {
                goto label_24;
            }
            
            if(val_13 == false)
            {
                goto label_25;
            }
            
            label_29:
            val_106 = val_103;
            val_107 = value.<longValue>k__BackingField;
            if(writer == null)
            {
                goto label_26;
            }
            
            if(val_107 != 0)
            {
                goto label_27;
            }
            
            goto label_31;
            label_24:
            if(val_13 == true)
            {
                goto label_29;
            }
            
            label_25:
            writer.WriteFieldBegin(type:  9, id:  3);
            if(writer == null)
            {
                goto label_30;
            }
            
            writer.WriteString(value:  value.<stringValue>k__BackingField);
            val_108 = val_103;
            if((value.<longValue>k__BackingField) == 0)
            {
                goto label_31;
            }
            
            label_27:
            writer.WriteFieldBegin(type:  17, id:  4);
            val_109 = mem[value + 40];
            val_109 = value + 40;
            goto label_32;
            label_22:
            if(val_103 != null)
            {
                goto label_33;
            }
            
            goto label_34;
            label_30:
            0.WriteString(value:  value.<stringValue>k__BackingField);
            val_110 = val_103;
            val_107 = value.<longValue>k__BackingField;
            label_26:
            if(val_107 == 0)
            {
                goto label_35;
            }
            
            writer.WriteFieldBegin(type:  17, id:  4);
            val_109 = mem[value + 40];
            val_109 = value + 40;
            label_32:
            writer.writeVarint(value:  (val_109 << 1) ^ (val_109 >> 63));
            if(writer == null)
            {
                goto label_36;
            }
            
            label_31:
            val_111 = value.<doubleValue>k__BackingField;
            if(val_111 == 0f)
            {
                goto label_39;
            }
            
            writer.WriteFieldBegin(type:  8, id:  5);
            val_111 = value.<doubleValue>k__BackingField;
            writer.WriteDouble(value:  val_111);
            goto label_39;
            label_36:
            label_35:
            if((value.<doubleValue>k__BackingField) != 0f)
            {
                    writer.WriteFieldBegin(type:  8, id:  5);
                val_111 = value.<doubleValue>k__BackingField;
                writer.WriteDouble(value:  val_111);
            }
            
            label_39:
            if(((value.<guidValue>k__BackingField) == null) || ((value.<guidValue>k__BackingField.Count) == 0))
            {
                goto label_41;
            }
            
            writer.WriteFieldBegin(type:  11, id:  6);
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  (value.<guidValue>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_19 = value.<guidValue>k__BackingField.GetEnumerator();
            val_112 = 1152921526156071136;
            val_102 = 0;
            val_113 = 0;
            label_63:
            if((74512144 & 1) == 0)
            {
                goto label_67;
            }
            
            GameUI.EmailUIDataHandler val_20 = val_9.emailUIDataHandler;
            writer.WriteUInt8(value:  3);
            writer.writeVarint(value:  val_20.Count & 65535);
            List.Enumerator<T> val_23 = val_20.GetEnumerator();
            label_52:
            if((74512112 & 1) == 0)
            {
                goto label_53;
            }
            
            writer.WriteUInt8(value:  val_9.Current);
            goto label_52;
            label_53:
            long val_25 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195568});
            if(((456 == 0) ? 456 : 456) != 456)
            {
                goto label_56;
            }
            
            if(writer != null)
            {
                goto label_63;
            }
            
            goto label_63;
            label_56:
            if( == 0)
            {
                goto label_59;
            }
            
            if(writer != null)
            {
                goto label_63;
            }
            
            goto label_63;
            label_59:
            if(writer != null)
            {
                goto label_63;
            }
            
            goto label_63;
            label_41:
            val_115 = 0;
            if(val_103 != null)
            {
                goto label_104;
            }
            
            goto label_105;
            label_67:
            long val_27 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195600});
            if(((456 == 0) ? 487 : 456) != 487)
            {
                goto label_74;
            }
            
            if(writer != null)
            {
                goto label_75;
            }
            
            goto label_78;
            label_74:
            if( != 0)
            {
                    val_115 = 0;
            }
            
            if(writer == null)
            {
                goto label_78;
            }
            
            label_75:
            if(val_103 != null)
            {
                goto label_104;
            }
            
            label_105:
            label_104:
            if(((value.<stringArray>k__BackingField) == null) || ((value.<stringArray>k__BackingField.Count) == 0))
            {
                goto label_81;
            }
            
            writer.WriteFieldBegin(type:  11, id:  10);
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  (value.<stringArray>k__BackingField.Count) & 65535);
            val_102 = value.<stringArray>k__BackingField;
            List.Enumerator<T> val_32 = val_102.GetEnumerator();
            val_116 = 1152921526154604768;
            val_112 = 1152921517654221184;
            label_101:
            if((74512080 & 1) == 0)
            {
                goto label_106;
            }
            
            GameUI.EmailUIDataHandler val_35 = val_34.emailUIDataHandler;
            writer.WriteUInt8(value:  9);
            writer.writeVarint(value:  val_35.Count & 65535);
            List.Enumerator<T> val_38 = val_35.GetEnumerator();
            label_92:
            if((74512048 & 1) == 0)
            {
                goto label_93;
            }
            
            writer.WriteString(value:  val_34.emailUIDataHandler);
            goto label_92;
            label_93:
            long val_40 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195504});
            if(((660 == 0) ? 660 : 660) != 660)
            {
                goto label_96;
            }
            
            if(writer != null)
            {
                goto label_101;
            }
            
            goto label_101;
            label_96:
            if(writer != null)
            {
                goto label_101;
            }
            
            goto label_101;
            label_81:
            if(writer != null)
            {
                goto label_117;
            }
            
            goto label_103;
            label_78:
            if(val_103 != null)
            {
                goto label_104;
            }
            
            goto label_105;
            label_106:
            long val_42 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195536});
            if(((660 == 0) ? 691 : 660) != 691)
            {
                goto label_113;
            }
            
            if(writer != null)
            {
                goto label_117;
            }
            
            goto label_115;
            label_113:
            if( != 0)
            {
                    val_118 = 0;
            }
            
            if(writer != null)
            {
                goto label_117;
            }
            
            label_115:
            label_103:
            label_117:
            if(((value.<longArray>k__BackingField) == null) || ((value.<longArray>k__BackingField.Count) == 0))
            {
                goto label_120;
            }
            
            writer.WriteFieldBegin(type:  11, id:  11);
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  (value.<longArray>k__BackingField.Count) & 65535);
            val_102 = value.<longArray>k__BackingField;
            List.Enumerator<T> val_47 = val_102.GetEnumerator();
            val_116 = 1152921526156116192;
            val_112 = 1152921517655148256;
            label_140:
            if((74512016 & 1) == 0)
            {
                goto label_143;
            }
            
            GameUI.EmailUIDataHandler val_50 = val_49.emailUIDataHandler;
            writer.WriteUInt8(value:  17);
            writer.writeVarint(value:  val_50.Count & 65535);
            List.Enumerator<T> val_53 = val_50.GetEnumerator();
            label_131:
            if((74511984 & 1) == 0)
            {
                goto label_132;
            }
            
            GameUI.EmailUIDataHandler val_54 = val_49.emailUIDataHandler;
            writer.writeVarint(value:  (val_54 << 1) ^ (val_54 >> 63));
            goto label_131;
            label_132:
            long val_57 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195440});
            if(((865 == 0) ? 865 : 865) != 865)
            {
                goto label_135;
            }
            
            if(writer != null)
            {
                goto label_140;
            }
            
            goto label_140;
            label_135:
            if(writer != null)
            {
                goto label_140;
            }
            
            goto label_140;
            label_120:
            if(writer != null)
            {
                goto label_154;
            }
            
            goto label_142;
            label_143:
            long val_59 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195472});
            if(((865 == 0) ? 896 : 865) != 896)
            {
                goto label_150;
            }
            
            if(writer != null)
            {
                goto label_154;
            }
            
            goto label_152;
            label_150:
            if( != 0)
            {
                    val_120 = 0;
            }
            
            if(writer != null)
            {
                goto label_154;
            }
            
            label_152:
            label_142:
            label_154:
            if(((value.<doubleArray>k__BackingField) == null) || ((value.<doubleArray>k__BackingField.Count) == 0))
            {
                goto label_157;
            }
            
            writer.WriteFieldBegin(type:  11, id:  12);
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  (value.<doubleArray>k__BackingField.Count) & 65535);
            val_102 = value.<doubleArray>k__BackingField;
            List.Enumerator<T> val_64 = val_102.GetEnumerator();
            val_116 = 1152921526156142816;
            val_112 = 1152921517654588736;
            label_177:
            if((74511952 & 1) == 0)
            {
                goto label_180;
            }
            
            GameUI.EmailUIDataHandler val_67 = val_66.emailUIDataHandler;
            writer.WriteUInt8(value:  8);
            writer.writeVarint(value:  val_67.Count & 65535);
            List.Enumerator<T> val_70 = val_67.GetEnumerator();
            label_168:
            if((74511920 & 1) == 0)
            {
                goto label_169;
            }
            
            writer.WriteDouble(value:  val_66.South);
            goto label_168;
            label_169:
            long val_72 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195376});
            if(((1069 == 0) ? 1069 : 1069) != 1069)
            {
                goto label_172;
            }
            
            if(writer != null)
            {
                goto label_177;
            }
            
            goto label_177;
            label_172:
            if(writer != null)
            {
                goto label_177;
            }
            
            goto label_177;
            label_157:
            if(writer != null)
            {
                goto label_191;
            }
            
            goto label_179;
            label_180:
            long val_74 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195408});
            if(((1069 == 0) ? 1100 : 1069) != 1100)
            {
                goto label_187;
            }
            
            if(writer != null)
            {
                goto label_191;
            }
            
            goto label_189;
            label_187:
            if( != 0)
            {
                    val_122 = 0;
            }
            
            if(writer != null)
            {
                goto label_191;
            }
            
            label_189:
            label_179:
            label_191:
            if(((value.<guidArray>k__BackingField) == null) || ((value.<guidArray>k__BackingField.Count) == 0))
            {
                goto label_194;
            }
            
            writer.WriteFieldBegin(type:  11, id:  13);
            val_102 = value.<guidArray>k__BackingField.Count;
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  val_102 & 65535);
            val_103 = value.<guidArray>k__BackingField;
            List.Enumerator<T> val_79 = val_103.GetEnumerator();
            val_112 = 1152921526156121312;
            val_116 = 1152921517655148256;
            label_231:
            if((74511888 & 1) == 0)
            {
                goto label_234;
            }
            
            GameUI.EmailUIDataHandler val_82 = val_81.emailUIDataHandler;
            writer.WriteUInt8(value:  11);
            writer.writeVarint(value:  val_82.Count & 65535);
            List.Enumerator<T> val_85 = val_82.GetEnumerator();
            label_218:
            if((74512016 & 1) == 0)
            {
                goto label_219;
            }
            
            GameUI.EmailUIDataHandler val_86 = val_81.emailUIDataHandler;
            writer.WriteUInt8(value:  17);
            writer.writeVarint(value:  val_86.Count & 65535);
            List.Enumerator<T> val_89 = val_86.GetEnumerator();
            label_209:
            if((74511984 & 1) == 0)
            {
                goto label_210;
            }
            
            GameUI.EmailUIDataHandler val_92 = val_91.emailUIDataHandler;
            writer.writeVarint(value:  (val_92 << 1) ^ (val_92 >> 63));
            goto label_209;
            label_210:
            long val_95 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195440});
            if(((1313 == 0) ? 1313 : 1313) != 1313)
            {
                goto label_213;
            }
            
            if(writer != null)
            {
                goto label_218;
            }
            
            goto label_218;
            label_213:
            if(writer != null)
            {
                goto label_218;
            }
            
            goto label_218;
            label_219:
            long val_97 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195472});
            if(((1313 == 0) ? 1344 : 1313) != 1344)
            {
                goto label_226;
            }
            
            if(writer != null)
            {
                goto label_231;
            }
            
            goto label_231;
            label_226:
            if(writer != null)
            {
                goto label_231;
            }
            
            goto label_231;
            label_194:
            val_125 = val_102;
            if(writer != null)
            {
                goto label_244;
            }
            
            goto label_233;
            label_234:
            long val_99 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526156195344});
            val_125 = val_102;
            if(writer != null)
            {
                goto label_244;
            }
            
            label_233:
            label_244:
            writer.WriteStructEnd(isBase:  val_125);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.Data value, bool isBase)
        {
            System.Collections.Generic.Dictionary<System.String, Microsoft.Applications.Events.DataModels.Value> val_9;
            var val_10;
            val_9 = value;
            if((value.<properties>k__BackingField) == null)
            {
                goto label_3;
            }
            
            val_10 = 1152921526156451424;
            if((value.<properties>k__BackingField.Count) == 0)
            {
                goto label_3;
            }
            
            writer.WriteFieldBegin(type:  13, id:  1);
            writer.WriteMapContainerBegin(size:  value.<properties>k__BackingField.Count, keyType:  9, valueType:  10);
            val_9 = value.<properties>k__BackingField;
            Dictionary.Enumerator<TKey, TValue> val_3 = val_9.GetEnumerator();
            val_10 = 1152921526156462688;
            label_10:
            if((74799304 & 1) == 0)
            {
                goto label_8;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_4 = 0.trackableId;
            writer.WriteString(value:  val_4.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, Microsoft.Applications.Events.DataModels.Value>::get_Key()));
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_4.m_SubId1, isBase:  false);
            goto label_10;
            label_3:
            if(writer != null)
            {
                goto label_21;
            }
            
            goto label_12;
            label_8:
            if(writer != null)
            {
                goto label_21;
            }
            
            label_12:
            label_21:
            writer.WriteStructEnd(isBase:  isBase);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Serialize(Microsoft.Applications.Events.CompactBinaryProtocolWriter writer, Microsoft.Applications.Events.DataModels.CsEvent value, bool isBase)
        {
            var val_18;
            var val_136;
            var val_137;
            System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Protocol> val_138;
            string val_139;
            val_136 = value;
            bool val_1 = System.String.IsNullOrEmpty(value:  value.<ver>k__BackingField);
            if(writer == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_8:
            if(writer == null)
            {
                goto label_4;
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<name>k__BackingField)) == true)
            {
                goto label_11;
            }
            
            label_10:
            writer.WriteFieldBegin(type:  9, id:  2);
            writer.WriteString(value:  value + 24);
            label_11:
            if((value.<time>k__BackingField) == 0)
            {
                goto label_6;
            }
            
            writer.WriteFieldBegin(type:  17, id:  3);
            goto label_7;
            label_2:
            if(val_1 == true)
            {
                goto label_8;
            }
            
            label_3:
            writer.WriteFieldBegin(type:  9, id:  1);
            if(writer == null)
            {
                goto label_9;
            }
            
            writer.WriteString(value:  value.<ver>k__BackingField);
            if((System.String.IsNullOrEmpty(value:  value.<name>k__BackingField)) == false)
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            0.WriteString(value:  value.<ver>k__BackingField);
            label_4:
            if((System.String.IsNullOrEmpty(value:  value.<name>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  2);
                writer.WriteString(value:  value + 24);
            }
            
            if((value.<time>k__BackingField) == 0)
            {
                goto label_13;
            }
            
            writer.WriteFieldBegin(type:  17, id:  3);
            label_7:
            writer.writeVarint(value:  ((value.<time>k__BackingField) << 1) ^ ((value.<time>k__BackingField) >> 63));
            if(writer == null)
            {
                goto label_14;
            }
            
            label_6:
            if((value.<popSample>k__BackingField) != 100)
            {
                    writer.WriteFieldBegin(type:  8, id:  4);
                writer.WriteDouble(value:  value.<popSample>k__BackingField);
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<iKey>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  5);
                writer.WriteString(value:  value.<iKey>k__BackingField);
            }
            
            if((value.<flags>k__BackingField) == 0)
            {
                goto label_17;
            }
            
            writer.WriteFieldBegin(type:  17, id:  6);
            goto label_18;
            label_14:
            label_13:
            if((value.<popSample>k__BackingField) != 100)
            {
                    writer.WriteFieldBegin(type:  8, id:  4);
                writer.WriteDouble(value:  value.<popSample>k__BackingField);
            }
            
            if((System.String.IsNullOrEmpty(value:  value.<iKey>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  5);
                writer.WriteString(value:  value.<iKey>k__BackingField);
            }
            
            if((value.<flags>k__BackingField) == 0)
            {
                goto label_21;
            }
            
            writer.WriteFieldBegin(type:  17, id:  6);
            label_18:
            writer.writeVarint(value:  ((value.<flags>k__BackingField) << 1) ^ ((value.<flags>k__BackingField) >> 63));
            if(writer == null)
            {
                goto label_22;
            }
            
            label_17:
            if((System.String.IsNullOrEmpty(value:  value.<cV>k__BackingField)) == true)
            {
                goto label_25;
            }
            
            writer.WriteFieldBegin(type:  9, id:  7);
            writer.WriteString(value:  value.<cV>k__BackingField);
            goto label_25;
            label_22:
            label_21:
            if((System.String.IsNullOrEmpty(value:  value.<cV>k__BackingField)) != true)
            {
                    writer.WriteFieldBegin(type:  9, id:  7);
                writer.WriteString(value:  value.<cV>k__BackingField);
            }
            
            label_25:
            if(((value.<extIngest>k__BackingField) == null) || ((value.<extIngest>k__BackingField.Count) == 0))
            {
                goto label_27;
            }
            
            writer.WriteFieldBegin(type:  11, id:  20);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extIngest>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_16 = value.<extIngest>k__BackingField.GetEnumerator();
            label_33:
            if((75355696 & 1) == 0)
            {
                goto label_32;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_33;
            label_27:
            if(val_136 != null)
            {
                goto label_43;
            }
            
            goto label_36;
            label_32:
            long val_20 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157039152});
            if(val_136 != null)
            {
                goto label_43;
            }
            
            label_36:
            label_43:
            val_138 = value.<extProtocol>k__BackingField;
            if(writer == null)
            {
                goto label_44;
            }
            
            if(val_138 != null)
            {
                goto label_45;
            }
            
            goto label_57;
            label_44:
            if(val_138 == null)
            {
                goto label_57;
            }
            
            label_45:
            writer.WriteFieldBegin(type:  11, id:  21);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extProtocol>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_24 = value.<extProtocol>k__BackingField.GetEnumerator();
            label_52:
            if((75355664 & 1) == 0)
            {
                goto label_51;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_52;
            label_51:
            val_138 = 0;
            long val_26 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157039120});
            if(((572 == 0) ? 572 : 572) != 572)
            {
                goto label_56;
            }
            
            if(writer != null)
            {
                goto label_57;
            }
            
            goto label_60;
            label_56:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer == null)
            {
                goto label_60;
            }
            
            label_57:
            if(val_136 != null)
            {
                goto label_72;
            }
            
            label_73:
            label_72:
            if(((value.<extUser>k__BackingField) == null) || ((value.<extUser>k__BackingField.Count) == 0))
            {
                goto label_63;
            }
            
            writer.WriteFieldBegin(type:  11, id:  22);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extUser>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_31 = value.<extUser>k__BackingField.GetEnumerator();
            label_69:
            if((75355632 & 1) == 0)
            {
                goto label_74;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_69;
            label_63:
            if(writer != null)
            {
                goto label_81;
            }
            
            goto label_71;
            label_60:
            if(val_136 != null)
            {
                goto label_72;
            }
            
            goto label_73;
            label_74:
            long val_33 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157039088});
            if(((705 == 0) ? 705 : 705) != 705)
            {
                goto label_77;
            }
            
            if(writer != null)
            {
                goto label_81;
            }
            
            goto label_79;
            label_77:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_81;
            }
            
            label_79:
            label_71:
            label_81:
            if(((value.<extDevice>k__BackingField) == null) || ((value.<extDevice>k__BackingField.Count) == 0))
            {
                goto label_84;
            }
            
            writer.WriteFieldBegin(type:  11, id:  23);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extDevice>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_38 = value.<extDevice>k__BackingField.GetEnumerator();
            label_90:
            if((75355600 & 1) == 0)
            {
                goto label_93;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_90;
            label_84:
            if(writer != null)
            {
                goto label_100;
            }
            
            goto label_92;
            label_93:
            long val_40 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157039056});
            if(((838 == 0) ? 838 : 838) != 838)
            {
                goto label_96;
            }
            
            if(writer != null)
            {
                goto label_100;
            }
            
            goto label_98;
            label_96:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_100;
            }
            
            label_98:
            label_92:
            label_100:
            if(((value.<extOs>k__BackingField) == null) || ((value.<extOs>k__BackingField.Count) == 0))
            {
                goto label_103;
            }
            
            writer.WriteFieldBegin(type:  11, id:  24);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extOs>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_45 = value.<extOs>k__BackingField.GetEnumerator();
            label_109:
            if((75355568 & 1) == 0)
            {
                goto label_112;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_109;
            label_103:
            if(writer != null)
            {
                goto label_119;
            }
            
            goto label_111;
            label_112:
            long val_47 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157039024});
            if(((971 == 0) ? 971 : 971) != 971)
            {
                goto label_115;
            }
            
            if(writer != null)
            {
                goto label_119;
            }
            
            goto label_117;
            label_115:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_119;
            }
            
            label_117:
            label_111:
            label_119:
            if(((value.<extApp>k__BackingField) == null) || ((value.<extApp>k__BackingField.Count) == 0))
            {
                goto label_122;
            }
            
            writer.WriteFieldBegin(type:  11, id:  25);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extApp>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_52 = value.<extApp>k__BackingField.GetEnumerator();
            label_128:
            if((75355536 & 1) == 0)
            {
                goto label_131;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_128;
            label_122:
            if(writer != null)
            {
                goto label_138;
            }
            
            goto label_130;
            label_131:
            long val_54 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038992});
            if(((1104 == 0) ? 1104 : 1104) != 1104)
            {
                goto label_134;
            }
            
            if(writer != null)
            {
                goto label_138;
            }
            
            goto label_136;
            label_134:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_138;
            }
            
            label_136:
            label_130:
            label_138:
            if(((value.<extUtc>k__BackingField) == null) || ((value.<extUtc>k__BackingField.Count) == 0))
            {
                goto label_141;
            }
            
            writer.WriteFieldBegin(type:  11, id:  26);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extUtc>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_59 = value.<extUtc>k__BackingField.GetEnumerator();
            label_147:
            if((75355504 & 1) == 0)
            {
                goto label_150;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_147;
            label_141:
            if(writer != null)
            {
                goto label_157;
            }
            
            goto label_149;
            label_150:
            long val_61 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038960});
            if(((1237 == 0) ? 1237 : 1237) != 1237)
            {
                goto label_153;
            }
            
            if(writer != null)
            {
                goto label_157;
            }
            
            goto label_155;
            label_153:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_157;
            }
            
            label_155:
            label_149:
            label_157:
            if(((value.<extXbl>k__BackingField) == null) || ((value.<extXbl>k__BackingField.Count) == 0))
            {
                goto label_160;
            }
            
            writer.WriteFieldBegin(type:  11, id:  27);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extXbl>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_66 = value.<extXbl>k__BackingField.GetEnumerator();
            label_166:
            if((75355472 & 1) == 0)
            {
                goto label_169;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_166;
            label_160:
            if(writer != null)
            {
                goto label_176;
            }
            
            goto label_168;
            label_169:
            long val_68 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038928});
            if(((1370 == 0) ? 1370 : 1370) != 1370)
            {
                goto label_172;
            }
            
            if(writer != null)
            {
                goto label_176;
            }
            
            goto label_174;
            label_172:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_176;
            }
            
            label_174:
            label_168:
            label_176:
            if(((value.<extJavascript>k__BackingField) == null) || ((value.<extJavascript>k__BackingField.Count) == 0))
            {
                goto label_179;
            }
            
            writer.WriteFieldBegin(type:  11, id:  28);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extJavascript>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_73 = value.<extJavascript>k__BackingField.GetEnumerator();
            label_185:
            if((75355440 & 1) == 0)
            {
                goto label_188;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_185;
            label_179:
            if(writer != null)
            {
                goto label_195;
            }
            
            goto label_187;
            label_188:
            long val_75 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038896});
            if(((1503 == 0) ? 1503 : 1503) != 1503)
            {
                goto label_191;
            }
            
            if(writer != null)
            {
                goto label_195;
            }
            
            goto label_193;
            label_191:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_195;
            }
            
            label_193:
            label_187:
            label_195:
            if(((value.<extReceipts>k__BackingField) == null) || ((value.<extReceipts>k__BackingField.Count) == 0))
            {
                goto label_198;
            }
            
            writer.WriteFieldBegin(type:  11, id:  29);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extReceipts>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_80 = value.<extReceipts>k__BackingField.GetEnumerator();
            label_204:
            if((75355408 & 1) == 0)
            {
                goto label_207;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_204;
            label_198:
            if(writer != null)
            {
                goto label_214;
            }
            
            goto label_206;
            label_207:
            long val_82 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038864});
            if(((1636 == 0) ? 1636 : 1636) != 1636)
            {
                goto label_210;
            }
            
            if(writer != null)
            {
                goto label_214;
            }
            
            goto label_212;
            label_210:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_214;
            }
            
            label_212:
            label_206:
            label_214:
            if(((value.<extNet>k__BackingField) == null) || ((value.<extNet>k__BackingField.Count) == 0))
            {
                goto label_217;
            }
            
            writer.WriteFieldBegin(type:  11, id:  31);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extNet>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_87 = value.<extNet>k__BackingField.GetEnumerator();
            label_223:
            if((75355376 & 1) == 0)
            {
                goto label_226;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_223;
            label_217:
            if(writer != null)
            {
                goto label_233;
            }
            
            goto label_225;
            label_226:
            long val_89 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038832});
            if(((1769 == 0) ? 1769 : 1769) != 1769)
            {
                goto label_229;
            }
            
            if(writer != null)
            {
                goto label_233;
            }
            
            goto label_231;
            label_229:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_233;
            }
            
            label_231:
            label_225:
            label_233:
            if(((value.<extSdk>k__BackingField) == null) || ((value.<extSdk>k__BackingField.Count) == 0))
            {
                goto label_236;
            }
            
            writer.WriteFieldBegin(type:  11, id:  32);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extSdk>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_94 = value.<extSdk>k__BackingField.GetEnumerator();
            label_242:
            if((75355344 & 1) == 0)
            {
                goto label_245;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_242;
            label_236:
            if(writer != null)
            {
                goto label_252;
            }
            
            goto label_244;
            label_245:
            long val_96 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038800});
            if(((1902 == 0) ? 1902 : 1902) != 1902)
            {
                goto label_248;
            }
            
            if(writer != null)
            {
                goto label_252;
            }
            
            goto label_250;
            label_248:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_252;
            }
            
            label_250:
            label_244:
            label_252:
            if(((value.<extLoc>k__BackingField) == null) || ((value.<extLoc>k__BackingField.Count) == 0))
            {
                goto label_255;
            }
            
            writer.WriteFieldBegin(type:  11, id:  33);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<extLoc>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_101 = value.<extLoc>k__BackingField.GetEnumerator();
            val_137 = 1152921526156942304;
            label_261:
            if((75355312 & 1) == 0)
            {
                goto label_264;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_261;
            label_255:
            if(writer != null)
            {
                goto label_271;
            }
            
            goto label_263;
            label_264:
            long val_103 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038768});
            if(((2035 == 0) ? 2035 : 2035) != 2035)
            {
                goto label_267;
            }
            
            if(writer != null)
            {
                goto label_271;
            }
            
            goto label_269;
            label_267:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_271;
            }
            
            label_269:
            label_263:
            label_271:
            if((value.<ext>k__BackingField) == null)
            {
                goto label_274;
            }
            
            val_137 = 1152921526156952544;
            if((value.<ext>k__BackingField.Count) == 0)
            {
                goto label_274;
            }
            
            writer.WriteFieldBegin(type:  11, id:  41);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<ext>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_108 = value.<ext>k__BackingField.GetEnumerator();
            val_137 = 1152921526156963808;
            label_280:
            if((75355280 & 1) == 0)
            {
                goto label_283;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_280;
            label_274:
            if(writer != null)
            {
                goto label_290;
            }
            
            goto label_282;
            label_283:
            long val_110 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038736});
            if(((2168 == 0) ? 2168 : 2168) != 2168)
            {
                goto label_286;
            }
            
            if(writer != null)
            {
                goto label_290;
            }
            
            goto label_288;
            label_286:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_290;
            }
            
            label_288:
            label_282:
            label_290:
            if((value.<tags>k__BackingField) == null)
            {
                goto label_293;
            }
            
            val_137 = 1152921526153450976;
            if((value.<tags>k__BackingField.Count) == 0)
            {
                goto label_293;
            }
            
            writer.WriteFieldBegin(type:  13, id:  51);
            writer.WriteMapContainerBegin(size:  value.<tags>k__BackingField.Count, keyType:  9, valueType:  9);
            Dictionary.Enumerator<TKey, TValue> val_114 = value.<tags>k__BackingField.GetEnumerator();
            val_137 = 1152921515881767536;
            label_301:
            if((75355232 & 1) == 0)
            {
                goto label_304;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_116 = val_18.trackableId;
            writer.WriteString(value:  val_116.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()));
            writer.WriteString(value:  val_116.m_SubId1);
            goto label_301;
            label_293:
            if(writer != null)
            {
                goto label_314;
            }
            
            goto label_303;
            label_304:
            long val_118 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038688});
            if(((2323 == 0) ? 2323 : 2323) != 2323)
            {
                goto label_310;
            }
            
            if(writer != null)
            {
                goto label_314;
            }
            
            goto label_312;
            label_310:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_314;
            }
            
            label_312:
            label_303:
            label_314:
            val_139 = System.String.IsNullOrEmpty(value:  value.<baseType>k__BackingField);
            if(writer == null)
            {
                goto label_316;
            }
            
            if(val_139 == false)
            {
                goto label_317;
            }
            
            goto label_321;
            label_316:
            if(val_139 == true)
            {
                goto label_321;
            }
            
            label_317:
            writer.WriteFieldBegin(type:  9, id:  60);
            val_139 = value.<baseType>k__BackingField;
            if(writer != null)
            {
                    writer.WriteString(value:  val_139);
            }
            else
            {
                    0.WriteString(value:  val_139);
            }
            
            label_321:
            if((value.<baseData>k__BackingField) == null)
            {
                goto label_323;
            }
            
            val_137 = 1152921526156952544;
            if((value.<baseData>k__BackingField.Count) == 0)
            {
                goto label_323;
            }
            
            writer.WriteFieldBegin(type:  11, id:  61);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<baseData>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_124 = value.<baseData>k__BackingField.GetEnumerator();
            val_139 = 1152921526156962784;
            val_137 = 1152921526156963808;
            label_329:
            if((75355280 & 1) == 0)
            {
                goto label_332;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_329;
            label_323:
            if(writer != null)
            {
                goto label_339;
            }
            
            goto label_331;
            label_332:
            long val_126 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038736});
            if(((2509 == 0) ? 2509 : 2509) != 2509)
            {
                goto label_335;
            }
            
            if(writer != null)
            {
                goto label_339;
            }
            
            goto label_337;
            label_335:
            if( != 0)
            {
                    val_138 = 0;
            }
            
            if(writer != null)
            {
                goto label_339;
            }
            
            label_337:
            label_331:
            label_339:
            if((value.<data>k__BackingField) == null)
            {
                goto label_342;
            }
            
            val_137 = 1152921526156952544;
            if((value.<data>k__BackingField.Count) == 0)
            {
                goto label_342;
            }
            
            writer.WriteFieldBegin(type:  11, id:  70);
            writer.WriteUInt8(value:  10);
            writer.writeVarint(value:  (value.<data>k__BackingField.Count) & 65535);
            List.Enumerator<T> val_131 = value.<data>k__BackingField.GetEnumerator();
            val_136 = 1152921526156962784;
            val_139 = 1152921526156963808;
            label_348:
            if((75355280 & 1) == 0)
            {
                goto label_351;
            }
            
            Microsoft.Applications.Events.MiniBond.Serialize(writer:  writer, value:  val_18.emailUIDataHandler, isBase:  false);
            goto label_348;
            label_342:
            if(writer != null)
            {
                goto label_357;
            }
            
            goto label_350;
            label_351:
            long val_133 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526157038736});
            if(writer != null)
            {
                goto label_357;
            }
            
            label_350:
            label_357:
            writer.WriteStructEnd(isBase:  isBase);
        }
    
    }

}
