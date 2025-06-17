using UnityEngine;

namespace PlayFab.Json
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabSimpleJson
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int BUILDER_INIT = 2000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly char[] EscapeTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly char[] EscapeCharacters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static readonly System.Collections.Generic.List<System.Type> NumberTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Text.StringBuilder _serializeObjectBuilder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Text.StringBuilder _parseStringBuilder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Json.IJsonSerializerStrategy _currentJsonSerializerStrategy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Json.PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.IJsonSerializerStrategy CurrentJsonSerializerStrategy { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.PocoJsonSerializerStrategy PocoJsonSerializerStrategy { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabSimpleJson()
        {
            PlayFab.Json.PlayFabSimpleJson.EscapeCharacters = new char[7];
            System.Collections.Generic.List<System.Type> val_2 = new System.Collections.Generic.List<System.Type>();
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PlayFab.Json.PlayFabSimpleJson.NumberTypes = val_2;
            PlayFab.Json.PlayFabSimpleJson.EscapeTable = new char[93];
            mem[1152921525710652820] = 34;
            mem[1152921525710652936] = 92;
            mem[1152921525710652768] = 98;
            mem[1152921525710652776] = 102;
            mem[1152921525710652772] = 110;
            mem[1152921525710652778] = 114;
            mem[1152921525710652770] = 116;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object DeserializeObject(string json)
        {
            object val_1 = 0;
            if((PlayFab.Json.PlayFabSimpleJson.TryDeserializeObject(json:  json, obj: out  val_1)) != false)
            {
                    return val_1;
            }
            
            System.Runtime.Serialization.SerializationException val_3 = new System.Runtime.Serialization.SerializationException(message:  "Invalid JSON string");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool TryDeserializeObject(string json, out object obj)
        {
            bool val_5;
            object val_6;
            val_5 = true;
            bool val_2 = val_5;
            if(json != null)
            {
                    val_6 = PlayFab.Json.PlayFabSimpleJson.ParseValue(json:  json, index: ref  0, success: ref  val_2);
                var val_4 = (val_2 != 0) ? 1 : 0;
            }
            else
            {
                    val_6 = 0;
            }
            
            obj = val_6;
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object DeserializeObject(string json, System.Type type, PlayFab.Json.IJsonSerializerStrategy jsonSerializerStrategy)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = jsonSerializerStrategy;
            object val_1 = PlayFab.Json.PlayFabSimpleJson.DeserializeObject(json:  json);
            if((System.Type.op_Equality(left:  type, right:  0)) == true)
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    if((PlayFab.Json.ReflectionUtils.IsAssignableFrom(type1:  val_1.GetType(), type2:  type)) != false)
            {
                    return val_1;
            }
            
            }
            
            if(val_7 != null)
            {
                    val_8 = val_7;
            }
            else
            {
                    val_8 = PlayFab.Json.PlayFabSimpleJson.CurrentJsonSerializerStrategy;
                if(val_8 != null)
            {
                    val_7 = val_8;
            }
            else
            {
                    val_7 = 0;
            }
            
            }
            
            if(mem[282584257676957] == 0)
            {
                    return val_8.DeserializeObject(value:  val_1, type:  type);
            }
            
            var val_6 = mem[282584257676847];
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_18:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_17;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < mem[282584257676957])
            {
                goto label_18;
            }
            
            return val_8.DeserializeObject(value:  val_1, type:  type);
            label_17:
            var val_8 = val_6;
            val_8 = val_8 + 1;
            val_7 = val_7 + val_8;
            val_9 = val_7 + 296;
            return val_8.DeserializeObject(value:  val_1, type:  type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T DeserializeObject<T>(string json, PlayFab.Json.IJsonSerializerStrategy jsonSerializerStrategy)
        {
            var val_4;
            object val_2 = PlayFab.Json.PlayFabSimpleJson.DeserializeObject(json:  json, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), jsonSerializerStrategy:  jsonSerializerStrategy);
            if(val_2 != null)
            {
                    val_4 = val_2;
                if(val_4 != null)
            {
                    return (PlayFab.Json.JsonObject)val_4;
            }
            
            }
            
            val_4 = 0;
            return (PlayFab.Json.JsonObject)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string SerializeObject(object json, PlayFab.Json.IJsonSerializerStrategy jsonSerializerStrategy)
        {
            PlayFab.Json.IJsonSerializerStrategy val_10;
            object val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = jsonSerializerStrategy;
            val_11 = json;
            val_12 = null;
            val_12 = null;
            if((mem[-1]) == 0)
            {
                    val_13 = null;
                val_13 = null;
                mem2[-1] = new System.Text.StringBuilder(capacity:  208);
            }
            
            val_14 = null;
            val_14 = null;
            val_15 = mem[-1];
            val_15.Length = 0;
            if(val_10 == null)
            {
                    val_10 = PlayFab.Json.PlayFabSimpleJson.CurrentJsonSerializerStrategy;
            }
            
            val_16 = null;
            val_16 = null;
            if((PlayFab.Json.PlayFabSimpleJson.SerializeValue(jsonSerializerStrategy:  val_10, value:  val_11, builder:  mem[-1])) == false)
            {
                    return 0;
            }
            
            val_17 = null;
            val_17 = null;
            val_11 = ???;
            val_15 = ???;
            goto mem[-1] + 344;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string EscapeToJavascriptString(string jsonString)
        {
            int val_16;
            var val_17;
            if((System.String.IsNullOrEmpty(value:  jsonString)) != false)
            {
                    return (string)jsonString;
            }
            
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            val_16 = 0;
            goto label_22;
            label_29:
            val_16 = W21 + 1;
            char val_3 = jsonString.Chars[W21];
            if((val_3 & 65535) != '\')
            {
                goto label_4;
            }
            
            if((jsonString.Length - val_16) < 2)
            {
                goto label_22;
            }
            
            char val_8 = jsonString.Chars[val_16] & 65535;
            if(val_8 > 'm')
            {
                goto label_8;
            }
            
            if(val_8 == '"')
            {
                goto label_9;
            }
            
            if(val_8 == '\')
            {
                goto label_10;
            }
            
            if(val_8 != 'b')
            {
                goto label_22;
            }
            
            val_17 = 8;
            goto label_26;
            label_4:
            System.Text.StringBuilder val_9 = val_2.Append(value:  val_3);
            goto label_22;
            label_8:
            if(val_8 == 'n')
            {
                goto label_16;
            }
            
            if(val_8 == 'r')
            {
                goto label_17;
            }
            
            if(val_8 != 't')
            {
                goto label_22;
            }
            
            val_17 = 9;
            goto label_26;
            label_9:
            System.Text.StringBuilder val_10 = val_2.Append(value:  "\"");
            val_16 = W21 + 2;
            goto label_22;
            label_10:
            val_17 = 92;
            goto label_26;
            label_16:
            val_17 = 10;
            goto label_26;
            label_17:
            val_17 = 13;
            label_26:
            System.Text.StringBuilder val_11 = val_2.Append(value:  '');
            val_16 = W21 + 2;
            label_22:
            if(val_16 < jsonString.Length)
            {
                goto label_29;
            }
            
            if(val_2 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.IDictionary<string, object> ParseObject(string json, ref int index, ref bool success)
        {
            var val_20;
            int val_21;
            PlayFab.Json.JsonObject val_1 = null;
            val_20 = val_1;
            val_1 = new PlayFab.Json.JsonObject();
            TokenType val_3 = PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711688112);
            goto label_20;
            label_25:
            val_21 = PlayFab.Json.PlayFabSimpleJson.ParseString(json:  json, index: ref  1152921525711688112, success: ref  true);
            if((success == false) || (((PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711688112)) & 255) != 5))
            {
                goto label_12;
            }
            
            object val_12 = PlayFab.Json.PlayFabSimpleJson.ParseValue(json:  json, index: ref  1152921525711688112, success: ref  true);
            if(success == false)
            {
                goto label_12;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_17;
            label_23:
            TokenType val_14 = PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711688112);
            goto label_20;
            label_17:
            val_1.set_Item(key:  ???, value:  ???);
            label_20:
            val_21 = index;
            TokenType val_17 = (PlayFab.Json.PlayFabSimpleJson.LookAhead(json:  json, index:  val_21)) & 255;
            if(val_17 == 6)
            {
                goto label_23;
            }
            
            if(val_17 == 2)
            {
                goto label_24;
            }
            
            if(val_17 != 0)
            {
                goto label_25;
            }
            
            label_12:
            val_20 = 0;
            success = false;
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_20;
            label_24:
            TokenType val_19 = PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711688112);
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Json.JsonArray ParseArray(string json, ref int index, ref bool success)
        {
            var val_13;
            object val_14;
            PlayFab.Json.JsonArray val_1 = null;
            val_13 = val_1;
            val_1 = new PlayFab.Json.JsonArray();
            TokenType val_3 = PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711881792);
            goto label_8;
            label_15:
            val_14 = PlayFab.Json.PlayFabSimpleJson.ParseValue(json:  json, index: ref  1152921525711881792, success: ref  true);
            if(success == false)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_14);
            goto label_8;
            label_13:
            TokenType val_8 = PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711881792);
            label_8:
            val_14 = index;
            TokenType val_10 = (PlayFab.Json.PlayFabSimpleJson.LookAhead(json:  json, index:  val_14)) & 255;
            if(val_10 == 6)
            {
                goto label_13;
            }
            
            if(val_10 == 4)
            {
                goto label_14;
            }
            
            if(val_10 != 0)
            {
                goto label_15;
            }
            
            val_13 = 0;
            success = false;
            return (PlayFab.Json.JsonArray)val_13;
            label_14:
            TokenType val_12 = PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  1152921525711881792);
            return (PlayFab.Json.JsonArray)val_13;
            label_6:
            val_13 = 0;
            return (PlayFab.Json.JsonArray)val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object ParseValue(string json, ref int index, ref bool success)
        {
            var val_26;
            TokenType val_2 = (PlayFab.Json.PlayFabSimpleJson.LookAhead(json:  json, index:  index)) & 255;
            val_2 = val_2 - 1;
            if(val_2 <= 10)
            {
                    var val_26 = 49756200 + (((val_1 & 255) - 1)) << 2;
                val_26 = val_26 + 49756200;
            }
            else
            {
                    val_26 = 0;
                success = false;
                return (object);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string ParseString(string json, ref int index, ref bool success)
        {
            System.Text.StringBuilder val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            System.Text.StringBuilder val_37;
            var val_38;
            var val_39;
            System.Text.StringBuilder val_40;
            var val_42;
            var val_43;
            var val_44;
            var val_49;
            var val_51;
            var val_52;
            val_32 = 1152921525712287488;
            uint val_16 = 0;
            val_33 = null;
            val_33 = null;
            if(0 == 0)
            {
                    System.Text.StringBuilder val_1 = new System.Text.StringBuilder(capacity:  208);
                val_34 = null;
                val_34 = null;
                mem[7] = val_1;
            }
            
            val_35 = null;
            val_35 = null;
            val_1.Length = 0;
            PlayFab.Json.PlayFabSimpleJson.EatWhitespace(json:  json, index: ref  1152921525712283456);
            int val_3 = index + 1;
            index = val_3;
            char val_4 = json.Chars[index];
            goto label_80;
            label_85:
            val_3 = index + 1;
            index = val_3;
            char val_5 = json.Chars[index];
            char val_6 = val_5 & 65535;
            if(val_6 == '\')
            {
                goto label_12;
            }
            
            if(val_6 == '"')
            {
                goto label_13;
            }
            
            val_36 = null;
            val_36 = null;
            val_37 = mem[7];
            val_38 = val_5;
            goto label_17;
            label_12:
            if(index == json.Length)
            {
                goto label_57;
            }
            
            index = index + 1;
            char val_10 = json.Chars[index] & 65535;
            if(val_10 > 'a')
            {
                goto label_21;
            }
            
            if(val_10 == '"')
            {
                goto label_22;
            }
            
            if(val_10 == ('/'))
            {
                goto label_23;
            }
            
            if(val_10 != '\')
            {
                goto label_80;
            }
            
            val_39 = null;
            val_39 = null;
            val_40 = mem[7];
            val_38 = 92;
            goto label_55;
            label_21:
            if((val_10 - 110) > '')
            {
                goto label_29;
            }
            
            var val_32 = 49756344 + (((val_9 & 65535) - 110)) << 2;
            val_32 = val_32 + 49756344;
            goto (49756344 + (((val_9 & 65535) - 110)) << 2 + 49756344);
            label_29:
            if(val_10 == 'b')
            {
                goto label_34;
            }
            
            if(val_10 != 'f')
            {
                goto label_80;
            }
            
            val_42 = null;
            val_42 = null;
            val_40 = mem[7];
            val_38 = 12;
            goto label_55;
            label_22:
            val_43 = null;
            val_43 = null;
            val_40 = mem[7];
            val_38 = 34;
            goto label_55;
            label_23:
            val_44 = null;
            val_44 = null;
            val_40 = mem[7];
            val_38 = 47;
            goto label_55;
            label_34:
            val_49 = null;
            val_49 = null;
            val_40 = mem[7];
            val_38 = 8;
            label_55:
            label_17:
            System.Text.StringBuilder val_28 = val_1.Append(value:  '');
            label_80:
            if( != json.Length)
            {
                goto label_85;
            }
            
            label_57:
            val_51 = 0;
            success = false;
            return (string)val_51;
            label_13:
            val_52 = null;
            val_52 = null;
            val_32 = mem[7];
            val_51 = val_32;
            return (string)val_51;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string ConvertFromUtf32(int utf32)
        {
            int val_6;
            string val_8;
            string val_9;
            if(utf32 >= 1114112)
            {
                goto label_1;
            }
            
            int val_1 = utf32 >> 11;
            if(val_1 == 27)
            {
                goto label_2;
            }
            
            if(val_1 < 27)
            {
                    return 0.CreateString(c:  utf32, count:  1);
            }
            
            char[] val_3 = new char[2];
            val_6 = val_3.Length;
            if(val_6 == 0)
            {
                    val_6 = val_3.Length;
            }
            
            val_3[0] = 55296 + ((utf32 - 65536) >> 10);
            val_3[0] = '�';
            return 0.CreateString(val:  val_3);
            label_1:
            val_8 = "utf32";
            val_9 = "The argument must be from 0 to 0x10FFFF.";
            goto label_7;
            label_2:
            val_8 = "utf32";
            val_9 = "The argument must not be in surrogate pair range.";
            label_7:
            null = new System.ArgumentOutOfRangeException(paramName:  val_8, message:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object ParseNumber(string json, ref int index, ref bool success)
        {
            var val_24;
            PlayFab.Json.PlayFabSimpleJson.EatWhitespace(json:  json, index: ref  1152921525712632160);
            int val_2 = PlayFab.Json.PlayFabSimpleJson.GetLastIndexOfNumber(json:  json, index:  index);
            int val_4 = (val_2 - index) + 1;
            string val_5 = json.Substring(startIndex:  index, length:  val_4);
            if((val_5.IndexOf(value:  ".", comparisonType:  5)) == 1)
            {
                    if((val_5.IndexOf(value:  "e", comparisonType:  5)) == 1)
            {
                goto label_7;
            }
            
            }
            
            success = System.Double.TryParse(s:  json.Substring(startIndex:  index, length:  val_4), style:  511, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  double val_10 = 1.28823579109872E-231);
            label_21:
            index = val_2 + 1;
            return (object)0;
            label_7:
            string val_15 = json.Substring(startIndex:  index, length:  val_4);
            if((val_5.IndexOf(value:  "-", comparisonType:  5)) == 1)
            {
                goto label_15;
            }
            
            success = System.Int64.TryParse(s:  val_15, style:  511, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0);
            val_24 = 1152921504621117440;
            goto label_21;
            label_15:
            success = System.UInt64.TryParse(s:  val_15, style:  511, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0);
            val_24 = 1152921504624738304;
            goto label_21;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int GetLastIndexOfNumber(string json, int index)
        {
            char val_5;
            int val_6;
            var val_7;
            val_6 = index;
            goto label_1;
            label_6:
            val_5 = json.Chars[val_6];
            val_7 = "0123456789+-.eE";
            if(("0123456789+-.eE") == null)
            {
                    val_7 = "0123456789+-.eE";
            }
            
            if((IndexOf(value:  val_5)) == 1)
            {
                    return (int)val_6 - 1;
            }
            
            val_6 = val_6 + 1;
            label_1:
            if(val_6 < json.Length)
            {
                goto label_6;
            }
            
            return (int)val_6 - 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void EatWhitespace(string json, ref int index)
        {
            int val_5;
            var val_6;
            val_5 = index;
            goto label_1;
            label_6:
            val_6 = " \t\n\r\b\f";
            val_5 = json.Chars[index];
            if(" \t\n\r\b\f" == null)
            {
                    val_6 = " \t\n\r\b\f";
            }
            
            if((IndexOf(value:  val_5)) == 1)
            {
                    return;
            }
            
            val_5 = index + 1;
            index = val_5;
            label_1:
            if(val_5 < json.Length)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Json.PlayFabSimpleJson.TokenType LookAhead(string json, int index)
        {
            return (TokenType)PlayFab.Json.PlayFabSimpleJson.NextToken(json:  json, index: ref  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Json.PlayFabSimpleJson.TokenType NextToken(string json, ref int index)
        {
            var val_44;
            int val_45;
            PlayFab.Json.PlayFabSimpleJson.EatWhitespace(json:  json, index: ref  1152921525713170928);
            if(index != json.Length)
            {
                goto label_4;
            }
            
            label_49:
            val_44 = 0;
            return 5;
            label_4:
            int val_45 = index;
            char val_4 = json.Chars[index] & 65535;
            index = val_45 + 1;
            if(val_4 > '[')
            {
                goto label_7;
            }
            
            if((val_4 - 34) > '')
            {
                goto label_8;
            }
            
            var val_44 = 49756244;
            val_44 = (49756244 + (((val_3 & 65535) - 34)) << 2) + val_44;
            goto (49756244 + (((val_3 & 65535) - 34)) << 2 + 49756244);
            label_7:
            if(val_4 == ']')
            {
                goto label_10;
            }
            
            if(val_4 == '{')
            {
                goto label_11;
            }
            
            if(val_4 != '}')
            {
                goto label_16;
            }
            
            val_44 = 2;
            return 5;
            label_10:
            val_44 = 4;
            return 5;
            label_11:
            val_44 = 1;
            return 5;
            label_8:
            if(val_4 == '[')
            {
                    val_44 = 3;
                return 5;
            }
            
            label_16:
            index = val_45;
            val_45 = json.Length - index;
            if(val_45 >= 5)
            {
                goto label_19;
            }
            
            if(val_45 != 4)
            {
                goto label_49;
            }
            
            goto label_31;
            label_19:
            if(((((json.Chars[index] & 65535) == 'f') && (((json.Chars[index + 1]) & 65535) == 'a')) && (((json.Chars[index + 2]) & 65535) == 'l')) && (((json.Chars[index + 3]) & 65535) == 's'))
            {
                    if(((json.Chars[index + 4]) & 65535) == 'e')
            {
                    int val_46 = index;
                val_44 = 10;
                val_46 = val_46 + 5;
                index = val_46;
                return 5;
            }
            
            }
            
            label_31:
            if(((((json.Chars[index] & 65535) != 't') || (((json.Chars[index + 1]) & 65535) != 'r')) || (((json.Chars[index + 2]) & 65535) != 'u')) || (((json.Chars[index + 3]) & 65535) != 'e'))
            {
                goto label_40;
            }
            
            val_45 = index;
            val_44 = 9;
            goto label_41;
            label_40:
            if(((((json.Chars[index] & 65535) != 'n') || (((json.Chars[index + 1]) & 65535) != 'u')) || (((json.Chars[index + 2]) & 65535) != 'l')) || (((json.Chars[index + 3]) & 65535) != 'l'))
            {
                goto label_49;
            }
            
            val_45 = index;
            val_44 = 11;
            label_41:
            val_45 = val_45 + 4;
            index = val_45;
            return 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeValue(PlayFab.Json.IJsonSerializerStrategy jsonSerializerStrategy, object value, System.Text.StringBuilder builder)
        {
            System.Collections.IEnumerable val_22;
            PlayFab.Json.IJsonSerializerStrategy val_23;
            var val_24;
            System.Type val_25;
            IntPtr val_26;
            var val_31;
            var val_32;
            val_22 = value;
            if(val_22 == null)
            {
                goto label_1;
            }
            
            string val_1 = (null == null) ? (val_22) : 0;
            if(val_1 == 0)
            {
                goto label_2;
            }
            
            bool val_2 = PlayFab.Json.PlayFabSimpleJson.SerializeString(aString:  val_1, builder:  builder);
            goto label_76;
            label_1:
            label_71:
            System.Text.StringBuilder val_3 = builder.Append(value:  "null");
            label_76:
            val_23 = 1;
            return (bool)PlayFab.Json.PlayFabSimpleJson.SerializeObject(jsonSerializerStrategy:  val_23 = jsonSerializerStrategy, keys:  val_22 = val_24.Keys, values:  val_24.Values, builder:  builder);
            label_2:
            val_24 = val_22;
            System.Type val_4 = val_22.GetType();
            val_25 = val_4;
            val_26 = PlayFab.WsaReflectionExtensions.GetTypeInfo(type:  val_4);
            if((val_26 & 1) == 0)
            {
                goto label_20;
            }
            
            val_26 = null;
            if(((System.Type.op_Equality(left:  val_4, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_26}))) == false) || ((System.Type.op_Equality(left:  val_25, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false))
            {
                goto label_20;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            goto label_25;
            label_20:
            if(val_24 == null)
            {
                goto label_26;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            goto label_30;
            label_26:
            val_25 = 1152921504689381376;
            val_24 = val_22;
            if(val_24 == null)
            {
                goto label_31;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            goto label_35;
            label_30:
            val_31 = null;
            var val_32 = 0;
            val_32 = 1152921504627703816;
            val_32 = val_32 + 1;
            goto label_47;
            label_31:
            val_25 = 1152921505288208384;
            if(val_22 == null)
            {
                goto label_40;
            }
            
            val_23 = jsonSerializerStrategy;
            bool val_12 = PlayFab.Json.PlayFabSimpleJson.SerializeArray(jsonSerializerStrategy:  val_23, anArray:  val_22, builder:  builder);
            return (bool)PlayFab.Json.PlayFabSimpleJson.SerializeObject(jsonSerializerStrategy:  val_23, keys:  val_22, values:  val_24.Values, builder:  builder);
            label_35:
            val_31 = null;
            val_22 = val_24.Keys;
            var val_33 = 0;
            val_32 = 1152921504627703816;
            val_33 = val_33 + 1;
            label_47:
            return (bool)PlayFab.Json.PlayFabSimpleJson.SerializeObject(jsonSerializerStrategy:  val_23, keys:  val_22, values:  val_24.Values, builder:  builder);
            label_40:
            if((PlayFab.Json.PlayFabSimpleJson.IsNumeric(value:  val_22)) == false)
            {
                goto label_52;
            }
            
            bool val_20 = PlayFab.Json.PlayFabSimpleJson.SerializeNumber(number:  val_22, builder:  builder);
            goto label_76;
            label_25:
            System.Collections.ICollection val_22 = val_22.Keys;
            var val_34 = 0;
            val_34 = val_34 + 1;
            System.Collections.ICollection val_24 = val_22.Values;
            return (bool)PlayFab.Json.PlayFabSimpleJson.SerializeObject(jsonSerializerStrategy:  val_23, keys:  val_22, values:  val_24.Values, builder:  builder);
            label_52:
            if(null == null)
            {
                goto label_64;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            goto label_69;
            label_64:
            var val_25 = (null == 0) ? "false" : "true";
            if(builder != null)
            {
                goto label_71;
            }
            
            goto label_71;
            label_69:
            if((jsonSerializerStrategy.TrySerializeNonPrimitiveObject(input:  val_22, output: out  0)) == false)
            {
                    return (bool)PlayFab.Json.PlayFabSimpleJson.SerializeObject(jsonSerializerStrategy:  val_23, keys:  val_22, values:  val_24.Values, builder:  builder);
            }
            
            goto label_76;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeObject(PlayFab.Json.IJsonSerializerStrategy jsonSerializerStrategy, System.Collections.IEnumerable keys, System.Collections.IEnumerable values, System.Text.StringBuilder builder)
        {
            string val_14;
            var val_20;
            System.Text.StringBuilder val_1 = builder.Append(value:  "{");
            val_14 = 1152921504685121536;
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Collections.IEnumerator val_3 = keys.GetEnumerator();
            var val_21 = 0;
            val_21 = val_21 + 1;
            System.Collections.IEnumerator val_5 = values.GetEnumerator();
            goto label_39;
            label_50:
            var val_22 = 0;
            val_22 = val_22 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_14 = val_3.Current;
            var val_24 = 0;
            val_24 = val_24 + 1;
            object val_11 = val_5.Current;
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_12 = builder.Append(value:  ",");
            }
            
            if(val_14 != null)
            {
                    if(null == null)
            {
                goto label_32;
            }
            
            }
            
            if((PlayFab.Json.PlayFabSimpleJson.SerializeValue(jsonSerializerStrategy:  jsonSerializerStrategy, value:  val_11, builder:  builder)) == false)
            {
                goto label_35;
            }
            
            if(builder != null)
            {
                goto label_43;
            }
            
            label_44:
            label_43:
            System.Text.StringBuilder val_14 = builder.Append(value:  ":");
            val_20 = 0;
            if((PlayFab.Json.PlayFabSimpleJson.SerializeValue(jsonSerializerStrategy:  jsonSerializerStrategy, value:  val_11, builder:  builder)) == true)
            {
                goto label_39;
            }
            
            return (bool)val_20;
            label_32:
            bool val_16 = PlayFab.Json.PlayFabSimpleJson.SerializeString(aString:  val_14, builder:  builder);
            if(builder != null)
            {
                goto label_43;
            }
            
            goto label_44;
            label_39:
            var val_25 = 0;
            val_25 = val_25 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_50;
            }
            
            label_18:
            System.Text.StringBuilder val_19 = builder.Append(value:  "}");
            val_20 = 1;
            return (bool)val_20;
            label_35:
            val_20 = 0;
            return (bool)val_20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeArray(PlayFab.Json.IJsonSerializerStrategy jsonSerializerStrategy, System.Collections.IEnumerable anArray, System.Text.StringBuilder builder)
        {
            var val_12;
            var val_13;
            var val_15;
            System.Text.StringBuilder val_1 = builder.Append(value:  "[");
            var val_12 = 0;
            val_12 = val_12 + 1;
            System.Collections.IEnumerator val_3 = anArray.GetEnumerator();
            label_22:
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            if((1 & 1) == 0)
            {
                    System.Text.StringBuilder val_8 = builder.Append(value:  ",");
            }
            
            if((PlayFab.Json.PlayFabSimpleJson.SerializeValue(jsonSerializerStrategy:  jsonSerializerStrategy, value:  val_3.Current, builder:  builder)) == true)
            {
                goto label_22;
            }
            
            val_12 = 0;
            val_13 = 105;
            goto label_24;
            label_12:
            val_12 = 0;
            val_13 = 91;
            label_24:
            if(val_3 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_3.Dispose();
            }
            
            if( != 91)
            {
                    if( == 105)
            {
                    val_15 = 0;
                return (bool)val_15;
            }
            
            }
            
            System.Text.StringBuilder val_11 = builder.Append(value:  "]");
            val_15 = 1;
            return (bool)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeString(string aString, System.Text.StringBuilder builder)
        {
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_20;
            val_14 = null;
            val_14 = null;
            val_15 = aString.IndexOfAny(anyOf:  PlayFab.Json.PlayFabSimpleJson.EscapeCharacters);
            System.Text.StringBuilder val_2 = builder.Append(value:  '"');
            if(val_15 == 1)
            {
                goto label_5;
            }
            
            System.Char[] val_3 = aString.ToCharArray();
            val_16 = 0;
            val_15 = 0;
            goto label_7;
            label_28:
            val_17 = null;
            val_17 = null;
            if(val_3[0] >= PlayFab.Json.PlayFabSimpleJson.EscapeTable.Length)
            {
                goto label_17;
            }
            
            val_18 = null;
            val_18 = null;
            System.Char[] val_4 = PlayFab.Json.PlayFabSimpleJson.EscapeTable + ((val_3[0x0][0]) << 1);
            if(((PlayFab.Json.PlayFabSimpleJson.EscapeTable + (val_3[0x0][0]) << 1) + 32) == 0)
            {
                goto label_17;
            }
            
            if(val_15 >= 1)
            {
                    System.Text.StringBuilder val_5 = builder.Append(value:  val_3, startIndex:  0, charCount:  0);
                val_15 = 0;
            }
            
            System.Text.StringBuilder val_6 = builder.Append(value:  '\');
            val_19 = null;
            val_19 = null;
            System.Char[] val_7 = PlayFab.Json.PlayFabSimpleJson.EscapeTable + ((val_3[0x0][0]) << 1);
            System.Text.StringBuilder val_8 = builder.Append(value:  (PlayFab.Json.PlayFabSimpleJson.EscapeTable + (val_3[0x0][0]) << 1) + 32);
            goto label_26;
            label_17:
            val_15 = 1;
            label_26:
            val_16 = 1;
            label_7:
            val_20 = val_3.Length;
            if(val_16 < val_20)
            {
                goto label_28;
            }
            
            if(val_15 >= 1)
            {
                    if(builder == null)
            {
                    val_20 = val_3.Length;
            }
            
                System.Text.StringBuilder val_10 = builder.Append(value:  val_3, startIndex:  val_20 - val_15, charCount:  1);
            }
            
            if(builder != null)
            {
                goto label_34;
            }
            
            goto label_32;
            label_5:
            if(builder == null)
            {
                goto label_33;
            }
            
            System.Text.StringBuilder val_11 = builder.Append(value:  aString);
            goto label_34;
            label_33:
            System.Text.StringBuilder val_12 = 0.Append(value:  aString);
            label_32:
            label_34:
            System.Text.StringBuilder val_13 = builder.Append(value:  '"');
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeNumber(object number, System.Text.StringBuilder builder)
        {
            System.Collections.Generic.List<System.Type> val_11;
            var val_12;
            if(number == null)
            {
                goto label_1;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            if(null == null)
            {
                goto label_4;
            }
            
            label_1:
            val_12 = null;
            val_12 = null;
            val_11 = PlayFab.Json.PlayFabSimpleJson.NumberTypes;
            if((val_11.IndexOf(item:  number.GetType())) == 1)
            {
                    return true;
            }
            
            System.Text.StringBuilder val_3 = builder.Append(value:  number);
            return true;
            label_2:
            string val_5 = null.ToString(format:  "R", provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_17;
            label_3:
            string val_7 = null.ToString(format:  "R", provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_17;
            label_4:
            label_17:
            System.Text.StringBuilder val_10 = builder.Append(value:  null.ToString(format:  "R", provider:  System.Globalization.CultureInfo.InvariantCulture));
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool IsNumeric(object value)
        {
            var val_2;
            if(value != null)
            {
                    val_2 = 1;
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                if(null == null)
            {
                    return (bool)val_2;
            }
            
                var val_1 = (null == null) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.IJsonSerializerStrategy get_CurrentJsonSerializerStrategy()
        {
            var val_2;
            PlayFab.Json.IJsonSerializerStrategy val_3;
            val_2 = null;
            val_2 = null;
            val_3 = PlayFab.Json.PlayFabSimpleJson._currentJsonSerializerStrategy;
            if(val_3 != null)
            {
                    return (PlayFab.Json.IJsonSerializerStrategy)val_3;
            }
            
            val_3 = PlayFab.Json.PlayFabSimpleJson.PocoJsonSerializerStrategy;
            PlayFab.Json.PlayFabSimpleJson._currentJsonSerializerStrategy = val_3;
            return (PlayFab.Json.IJsonSerializerStrategy)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_CurrentJsonSerializerStrategy(PlayFab.Json.IJsonSerializerStrategy value)
        {
            null = null;
            PlayFab.Json.PlayFabSimpleJson._currentJsonSerializerStrategy = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Json.PocoJsonSerializerStrategy get_PocoJsonSerializerStrategy()
        {
            var val_2;
            PlayFab.Json.PocoJsonSerializerStrategy val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PlayFab.Json.PlayFabSimpleJson._pocoJsonSerializerStrategy;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PlayFab.Json.PocoJsonSerializerStrategy val_1 = null;
            val_3 = val_1;
            val_1 = new PlayFab.Json.PocoJsonSerializerStrategy();
            val_4 = null;
            val_4 = null;
            PlayFab.Json.PlayFabSimpleJson._pocoJsonSerializerStrategy = val_3;
            return val_3;
        }
    
    }

}
