using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class PlayFabUtil
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string _localSettingsFileName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string[] _defaultDateTimeFormats;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int DEFAULT_UTC_OUTPUT_INDEX = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int DEFAULT_LOCAL_OUTPUT_INDEX = 9;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Globalization.DateTimeStyles DateTimeStyles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Text.StringBuilder _sb;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string timeStamp { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string utcTimeStamp { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabUtil()
        {
            PlayFab.Internal.PlayFabUtil.DEFAULT_LOCAL_OUTPUT_INDEX = "playfab.local.settings.json";
            PlayFab.Internal.PlayFabUtil.DEFAULT_LOCAL_OUTPUT_INDEX.__il2cppRuntimeField_3 = 268435460;
            string[] val_1 = new string[15];
            val_1[0] = "yyyy-MM-ddTHH:mm:ss.FFFFFFZ";
            val_1[1] = "yyyy-MM-ddTHH:mm:ss.FFFFZ";
            val_1[2] = "yyyy-MM-ddTHH:mm:ss.FFFZ";
            val_1[3] = "yyyy-MM-ddTHH:mm:ss.FFZ";
            val_1[4] = "yyyy-MM-ddTHH:mm:ssZ";
            val_1[5] = "yyyy-MM-dd HH:mm:ssZ";
            val_1[6] = "yyyy-MM-dd HH:mm:ss.FFFFFF";
            val_1[7] = "yyyy-MM-dd HH:mm:ss.FFFF";
            val_1[8] = "yyyy-MM-dd HH:mm:ss.FFF";
            val_1[9] = "yyyy-MM-dd HH:mm:ss.FF";
            val_1[10] = "yyyy-MM-dd HH:mm:ss";
            val_1[11] = "yyyy-MM-dd HH:mm.ss.FFFF";
            val_1[12] = "yyyy-MM-dd HH:mm.ss.FFF";
            val_1[13] = "yyyy-MM-dd HH:mm.ss.FF";
            val_1[14] = "yyyy-MM-dd HH:mm.ss";
            PlayFab.Internal.PlayFabUtil._defaultDateTimeFormats = val_1;
            PlayFab.Internal.PlayFabUtil.DateTimeStyles = 128;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_timeStamp()
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.Now;
            val_2 = null;
            val_2 = null;
            if(PlayFab.Internal.PlayFabUtil._defaultDateTimeFormats.Length > 9)
            {
                    return -306493624;
            }
            
            return -306493624;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_utcTimeStamp()
        {
            var val_2;
            System.DateTime val_1 = System.DateTime.UtcNow;
            val_2 = null;
            val_2 = null;
            if(PlayFab.Internal.PlayFabUtil._defaultDateTimeFormats.Length > 2)
            {
                    return -306381624;
            }
            
            return -306381624;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Format(string text, object[] args)
        {
            if(args.Length == 0)
            {
                    return (string)text;
            }
            
            return System.String.Format(format:  text, args:  args);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ReadAllFileText(string filename)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_15;
            var val_17;
            if((System.IO.File.Exists(path:  filename)) == false)
            {
                    return (string)System.String.alignConst;
            }
            
            val_8 = null;
            val_8 = null;
            if((mem[-1]) == 0)
            {
                    val_9 = null;
                val_9 = null;
                mem2[-1] = new System.Text.StringBuilder();
            }
            
            val_10 = null;
            val_10 = null;
            mem[-1].Length = 0;
            System.IO.FileStream val_3 = new System.IO.FileStream(path:  filename, mode:  3);
            new System.IO.BinaryReader() = new System.IO.BinaryReader(input:  val_3);
            label_17:
            if(new System.IO.BinaryReader() == new System.IO.BinaryReader())
            {
                goto label_13;
            }
            
            val_11 = null;
            val_11 = null;
            System.Text.StringBuilder val_5 = mem[-1].Append(value:  '폠');
            goto label_17;
            label_13:
            val_12 = 0;
            val_13 = 122;
            var val_8 = 0;
            val_8 = val_8 + 1;
            new System.IO.BinaryReader().Dispose();
            if((null == null) || ( == 122))
            {
                goto label_34;
            }
            
            val_15 = 0;
            val_12 = 0;
            if(val_3 != null)
            {
                goto label_35;
            }
            
            goto label_39;
            label_34:
            if(val_3 == null)
            {
                goto label_39;
            }
            
            label_35:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_15 = public System.Void System.IDisposable::Dispose();
            val_3.Dispose();
            label_39:
            if(( != 122) && (null != null))
            {
                    val_15 = 0;
            }
            
            val_17 = null;
            val_17 = null;
            if((mem[-1]) == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T TryEnumParse<T>(string value, T defaultValue)
        {
            var val_4;
            object val_2 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), value:  value);
            if(val_2 != null)
            {
                    val_4 = val_2;
                if(val_4 != null)
            {
                    return (object)val_4;
            }
            
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static string GetLocalSettingsFileProperty(string propertyKey)
        {
            var val_12;
            string val_13;
            var val_14;
            string val_15;
            int val_16;
            object val_10 = 0;
            val_12 = null;
            val_12 = null;
            string val_2 = System.IO.Path.Combine(path1:  System.IO.Directory.GetCurrentDirectory(), path2:  PlayFab.Internal.PlayFabUtil.DEFAULT_LOCAL_OUTPUT_INDEX);
            val_13 = val_2;
            if((System.IO.File.Exists(path:  val_2)) == true)
            {
                goto label_5;
            }
            
            val_14 = null;
            val_14 = null;
            string val_5 = System.IO.Path.Combine(path1:  System.IO.Path.GetTempPath(), path2:  PlayFab.Internal.PlayFabUtil.DEFAULT_LOCAL_OUTPUT_INDEX);
            val_13 = val_5;
            val_15 = 0;
            if((System.IO.File.Exists(path:  val_5)) == false)
            {
                goto label_10;
            }
            
            label_5:
            val_15 = PlayFab.Internal.PlayFabUtil.ReadAllFileText(filename:  val_13);
            label_10:
            if((System.String.IsNullOrEmpty(value:  val_15)) != false)
            {
                    val_16 = System.String.alignConst;
                return (string)val_16;
            }
            
            if((PlayFab.Json.PlayFabSimpleJson.DeserializeObject<PlayFab.Json.JsonObject>(json:  val_15, jsonSerializerStrategy:  0).TryGetValue(key:  propertyKey, value: out  val_10)) != false)
            {
                    val_16 = val_10;
                if(val_16 == 0)
            {
                    return (string)val_16;
            }
            
                return (string)val_16;
            }
            
            val_16 = 0;
            return (string)val_16;
        }
    
    }

}
