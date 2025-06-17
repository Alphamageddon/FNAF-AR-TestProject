using UnityEngine;

namespace SimpleJson2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class SimpleJson2
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_NONE = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_CURLY_OPEN = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_CURLY_CLOSE = 2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_SQUARED_OPEN = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_SQUARED_CLOSE = 4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_COLON = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_COMMA = 6;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_STRING = 7;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_NUMBER = 8;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_TRUE = 9;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_FALSE = 10;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int TOKEN_NULL = 11;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int BUILDER_CAPACITY = 2000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly char[] EscapeTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly char[] EscapeCharacters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SimpleJson2.IJsonSerializerStrategy _currentJsonSerializerStrategy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SimpleJson2.PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.IJsonSerializerStrategy CurrentJsonSerializerStrategy { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.PocoJsonSerializerStrategy PocoJsonSerializerStrategy { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SimpleJson2()
        {
            SimpleJson2.SimpleJson2.EscapeCharacters = new char[7];
            SimpleJson2.SimpleJson2.EscapeTable = new char[93];
            mem[1152921520056130948] = 34;
            mem[1152921520056131064] = 92;
            mem[1152921520056130896] = 98;
            mem[1152921520056130904] = 102;
            mem[1152921520056130900] = 110;
            mem[1152921520056130906] = 114;
            mem[1152921520056130898] = 116;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object DeserializeObject(string json)
        {
            object val_1 = 0;
            if((SimpleJson2.SimpleJson2.TryDeserializeObject(json:  json, obj: out  val_1)) != false)
            {
                    return val_1;
            }
            
            System.Runtime.Serialization.SerializationException val_3 = new System.Runtime.Serialization.SerializationException(message:  "Invalid JSON string");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool TryDeserializeObject(string json, out object obj)
        {
            bool val_6;
            object val_7;
            val_6 = true;
            bool val_3 = val_6;
            if(json != null)
            {
                    val_7 = SimpleJson2.SimpleJson2.ParseValue(json:  json.ToCharArray(), index: ref  0, success: ref  val_3);
                var val_5 = (val_3 != 0) ? 1 : 0;
            }
            else
            {
                    val_7 = 0;
            }
            
            obj = val_7;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object DeserializeObject(string json, System.Type type, SimpleJson2.IJsonSerializerStrategy jsonSerializerStrategy)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = jsonSerializerStrategy;
            object val_1 = SimpleJson2.SimpleJson2.DeserializeObject(json:  json);
            if((System.Type.op_Equality(left:  type, right:  0)) == true)
            {
                    return val_1;
            }
            
            if(val_1 != null)
            {
                    if((SimpleJson2.Reflection.ReflectionUtils.IsAssignableFrom(type1:  val_1.GetType(), type2:  type)) != false)
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
                    val_8 = SimpleJson2.SimpleJson2.CurrentJsonSerializerStrategy;
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
        public static object DeserializeObject(string json, System.Type type)
        {
            return SimpleJson2.SimpleJson2.DeserializeObject(json:  json, type:  type, jsonSerializerStrategy:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static T DeserializeObject<T>(string json, SimpleJson2.IJsonSerializerStrategy jsonSerializerStrategy)
        {
            var val_4;
            object val_2 = SimpleJson2.SimpleJson2.DeserializeObject(json:  json, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), jsonSerializerStrategy:  jsonSerializerStrategy);
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
        public static T DeserializeObject<T>(string json)
        {
            var val_4;
            object val_2 = SimpleJson2.SimpleJson2.DeserializeObject(json:  json, type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), jsonSerializerStrategy:  0);
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
        public static string SerializeObject(object json, SimpleJson2.IJsonSerializerStrategy jsonSerializerStrategy)
        {
            SimpleJson2.IJsonSerializerStrategy val_8 = jsonSerializerStrategy;
            if((SimpleJson2.SimpleJson2.SerializeValue(jsonSerializerStrategy:  val_8 = jsonSerializerStrategy, value:  json, builder:  new System.Text.StringBuilder(capacity:  208))) == false)
            {
                    return 0;
            }
            
            val_8 = ???;
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_158;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string SerializeObject(object json)
        {
            return SimpleJson2.SimpleJson2.SerializeObject(json:  json, jsonSerializerStrategy:  SimpleJson2.SimpleJson2.CurrentJsonSerializerStrategy);
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
        private static System.Collections.Generic.IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
        {
            var val_18;
            int val_19;
            SimpleJson2.JsonObject val_1 = null;
            val_18 = val_1;
            val_1 = new SimpleJson2.JsonObject();
            int val_3 = SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057670288);
            goto label_20;
            label_25:
            val_19 = SimpleJson2.SimpleJson2.ParseString(json:  json, index: ref  1152921520057670288, success: ref  true);
            if((success == false) || ((SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057670288)) != 5))
            {
                goto label_12;
            }
            
            object val_11 = SimpleJson2.SimpleJson2.ParseValue(json:  json, index: ref  1152921520057670288, success: ref  true);
            if(success == false)
            {
                goto label_12;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_17;
            label_23:
            int val_13 = SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057670288);
            goto label_20;
            label_17:
            val_1.set_Item(key:  ???, value:  ???);
            label_20:
            val_19 = index;
            int val_15 = SimpleJson2.SimpleJson2.LookAhead(json:  json, index:  val_19);
            if(val_15 == 6)
            {
                goto label_23;
            }
            
            if(val_15 == 2)
            {
                goto label_24;
            }
            
            if(val_15 != 0)
            {
                goto label_25;
            }
            
            label_12:
            val_18 = 0;
            success = false;
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_18;
            label_24:
            int val_17 = SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057670288);
            return (System.Collections.Generic.IDictionary<System.String, System.Object>)val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SimpleJson2.JsonArray ParseArray(char[] json, ref int index, ref bool success)
        {
            var val_12;
            object val_13;
            SimpleJson2.JsonArray val_1 = null;
            val_12 = val_1;
            val_1 = new SimpleJson2.JsonArray();
            int val_3 = SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057892640);
            goto label_8;
            label_15:
            val_13 = SimpleJson2.SimpleJson2.ParseValue(json:  json, index: ref  1152921520057892640, success: ref  true);
            if(success == false)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_13);
            goto label_8;
            label_13:
            int val_8 = SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057892640);
            label_8:
            val_13 = index;
            int val_9 = SimpleJson2.SimpleJson2.LookAhead(json:  json, index:  val_13);
            if(val_9 == 6)
            {
                goto label_13;
            }
            
            if(val_9 == 4)
            {
                goto label_14;
            }
            
            if(val_9 != 0)
            {
                goto label_15;
            }
            
            val_12 = 0;
            success = false;
            return (SimpleJson2.JsonArray)val_12;
            label_14:
            int val_11 = SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  1152921520057892640);
            return (SimpleJson2.JsonArray)val_12;
            label_6:
            val_12 = 0;
            return (SimpleJson2.JsonArray)val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object ParseValue(char[] json, ref int index, ref bool success)
        {
            var val_26;
            if(((SimpleJson2.SimpleJson2.LookAhead(json:  json, index:  index)) - 1) <= 10)
            {
                    var val_26 = 52950368 + ((val_1 - 1)) << 2;
                val_26 = val_26 + 52950368;
            }
            else
            {
                    val_26 = 0;
                success = false;
                return (object);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string ParseString(char[] json, ref int index, ref bool success)
        {
            int val_25;
            int val_26;
            int val_27;
            int val_28;
            var val_30;
            uint val_7 = 0;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder(capacity:  208);
            val_25 = 1152921520058380320;
            SimpleJson2.SimpleJson2.EatWhitespace(json:  json, index: ref  val_25);
            val_26 = index;
            index = val_26 + 1;
            val_27 = json.Length;
            if(val_26 >= val_27)
            {
                    val_25 = 0;
                val_27 = json.Length;
            }
            
            val_28 = index;
            if(val_28 == val_27)
            {
                goto label_47;
            }
            
            goto label_46;
            label_55:
            val_25 = val_26;
            goto label_8;
            label_54:
            val_26 = index;
            if(val_26 == json.Length)
            {
                goto label_47;
            }
            
            index = val_26 + 1;
            if(val_26 >= json.Length)
            {
                    val_25 = 0;
            }
            
            char val_24 = json[((index + 1)) << 1];
            if(val_24 > 'a')
            {
                goto label_11;
            }
            
            if(val_24 == '"')
            {
                goto label_12;
            }
            
            if(val_24 == ('/'))
            {
                goto label_13;
            }
            
            if(val_24 != '\')
            {
                goto label_52;
            }
            
            val_25 = 92;
            goto label_31;
            label_11:
            if((val_24 - 110) > '')
            {
                goto label_17;
            }
            
            var val_25 = 52950512 + ((json[((index + 1)) << 1][0] - 110)) << 2;
            val_25 = val_25 + 52950512;
            goto (52950512 + ((json[((index + 1)) << 1][0] - 110)) << 2 + 52950512);
            label_12:
            val_25 = 34;
            goto label_31;
            label_13:
            val_25 = 47;
            goto label_31;
            label_17:
            if(val_24 == 'b')
            {
                goto label_24;
            }
            
            if(val_24 != 'f')
            {
                goto label_52;
            }
            
            val_25 = 12;
            goto label_31;
            label_24:
            val_25 = 8;
            label_31:
            label_8:
            System.Text.StringBuilder val_18 = val_1.Append(value:  '');
            label_52:
            val_28 = ;
            if(val_28 != json.Length)
            {
                goto label_46;
            }
            
            goto label_47;
            label_46:
            index = val_28 + 1;
            if(val_28 >= json.Length)
            {
                    val_25 = 0;
            }
            
            val_26 = json[((long)(int)((index + 1))) << 1];
            if(val_26 == '\')
            {
                goto label_54;
            }
            
            if(val_26 != '"')
            {
                goto label_55;
            }
            
            val_30 = val_1;
            return (string)val_30;
            label_47:
            val_30 = 0;
            success = false;
            return (string)val_30;
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
        private static object ParseNumber(char[] json, ref int index, ref bool success)
        {
            SimpleJson2.SimpleJson2.EatWhitespace(json:  json, index: ref  1152921520058794976);
            int val_2 = SimpleJson2.SimpleJson2.GetLastIndexOfNumber(json:  json, index:  index);
            int val_4 = (val_2 - index) + 1;
            string val_5 = 0.CreateString(val:  json, startIndex:  index, length:  val_4);
            if((val_5.IndexOf(value:  ".", comparisonType:  5)) == 1)
            {
                    if((val_5.IndexOf(value:  "e", comparisonType:  5)) == 1)
            {
                goto label_6;
            }
            
            }
            
            success = System.Double.TryParse(s:  0.CreateString(val:  json, startIndex:  index, length:  val_4), style:  511, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  double val_10 = 1.2882341738405E-231);
            label_13:
            index = val_2 + 1;
            return (object)0;
            label_6:
            success = System.Int64.TryParse(s:  0.CreateString(val:  json, startIndex:  index, length:  val_4), style:  511, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0);
            goto label_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int GetLastIndexOfNumber(char[] json, int index)
        {
            char val_3;
            var val_4;
            var val_5;
            val_4 = index;
            goto label_1;
            label_6:
            val_3 = json[((long)(int)(index)) << 1];
            val_5 = "0123456789+-.eE";
            if(("0123456789+-.eE") == null)
            {
                    val_5 = "0123456789+-.eE";
            }
            
            if((IndexOf(value:  val_3)) == 1)
            {
                    return (int)val_4 - 1;
            }
            
            val_4 = val_4 + 1;
            label_1:
            if(val_4 < json.Length)
            {
                goto label_6;
            }
            
            return (int)val_4 - 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void EatWhitespace(char[] json, ref int index)
        {
            int val_3;
            var val_4;
            val_3 = index;
            goto label_1;
            label_6:
            val_4 = " \t\n\r\b\f";
            val_3 = json[(index) << 1];
            if(" \t\n\r\b\f" == null)
            {
                    val_4 = " \t\n\r\b\f";
            }
            
            if((IndexOf(value:  val_3)) == 1)
            {
                    return;
            }
            
            val_3 = index + 1;
            index = val_3;
            label_1:
            if(val_3 < json.Length)
            {
                goto label_6;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int LookAhead(char[] json, int index)
        {
            return (int)SimpleJson2.SimpleJson2.NextToken(json:  json, index: ref  index);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int NextToken(char[] json, ref int index)
        {
            var val_5;
            int val_6;
            int val_7;
            SimpleJson2.SimpleJson2.EatWhitespace(json:  json, index: ref  1152921520059583808);
            if(index != json.Length)
            {
                goto label_4;
            }
            
            label_48:
            val_5 = 0;
            return 5;
            label_4:
            val_6 = index;
            if(val_6 >= json.Length)
            {
                    val_6 = index;
            }
            
            char val_5 = json[((long)(int)(index)) << 1];
            index = val_6 + 1;
            if(val_5 > '[')
            {
                goto label_7;
            }
            
            if((val_5 - 34) > '')
            {
                goto label_8;
            }
            
            var val_6 = 52950412;
            val_6 = (52950412 + ((json[((long)(int)(index)) << 1][0] - 34)) << 2) + val_6;
            goto (52950412 + ((json[((long)(int)(index)) << 1][0] - 34)) << 2 + 52950412);
            label_7:
            if(val_5 == ']')
            {
                goto label_10;
            }
            
            if(val_5 == '{')
            {
                goto label_11;
            }
            
            if(val_5 != '}')
            {
                goto label_16;
            }
            
            val_5 = 2;
            return 5;
            label_10:
            val_5 = 4;
            return 5;
            label_11:
            val_5 = 1;
            return 5;
            label_8:
            if(val_5 == '[')
            {
                    val_5 = 3;
                return 5;
            }
            
            label_16:
            index = val_6;
            int val_4 = json.Length - val_6;
            if(val_4 >= 5)
            {
                goto label_18;
            }
            
            if(val_4 != 4)
            {
                goto label_48;
            }
            
            goto label_30;
            label_18:
            if((json[((long)(int)(index)) << 1]) == 'f')
            {
                    int val_8 = index;
                val_8 = val_8 + 1;
                if((json[((long)(int)((index + 1))) << 1]) == 'a')
            {
                    int val_10 = index;
                val_10 = val_10 + 2;
                if((json[((long)(int)((index + 2))) << 1]) == 'l')
            {
                    int val_12 = index;
                val_12 = val_12 + 3;
                if((json[((long)(int)((index + 3))) << 1]) == 's')
            {
                    int val_14 = index;
                val_14 = val_14 + 4;
                if((json[((long)(int)((index + 4))) << 1]) == 'e')
            {
                    int val_16 = index;
                val_5 = 10;
                val_16 = val_16 + 5;
                index = val_16;
                return 5;
            }
            
            }
            
            }
            
            }
            
            }
            
            label_30:
            if((json[((index + 5)) << 1]) != 't')
            {
                goto label_39;
            }
            
            int val_18 = index;
            val_18 = val_18 + 1;
            if((json[((long)(int)(((index + 5) + 1))) << 1]) != 'r')
            {
                goto label_39;
            }
            
            int val_20 = index;
            val_20 = val_20 + 2;
            if((json[((long)(int)(((index + 5) + 2))) << 1]) != 'u')
            {
                goto label_39;
            }
            
            int val_22 = index;
            val_22 = val_22 + 3;
            if((json[((long)(int)(((index + 5) + 3))) << 1]) != 'e')
            {
                goto label_39;
            }
            
            val_7 = index;
            val_5 = 9;
            goto label_40;
            label_39:
            if((json[((index + 5)) << 1]) != 'n')
            {
                goto label_48;
            }
            
            int val_25 = index;
            val_25 = val_25 + 1;
            if((json[((long)(int)(((index + 5) + 1))) << 1]) != 'u')
            {
                goto label_48;
            }
            
            int val_27 = index;
            val_27 = val_27 + 2;
            if((json[((long)(int)(((index + 5) + 2))) << 1]) != 'l')
            {
                goto label_48;
            }
            
            int val_29 = index;
            val_29 = val_29 + 3;
            if((json[((long)(int)(((index + 5) + 3))) << 1]) != 'l')
            {
                goto label_48;
            }
            
            val_7 = index;
            val_5 = 11;
            label_40:
            val_7 = val_7 + 4;
            index = val_7;
            return 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeValue(SimpleJson2.IJsonSerializerStrategy jsonSerializerStrategy, object value, System.Text.StringBuilder builder)
        {
            string val_13;
            var val_14;
            SimpleJson2.IJsonSerializerStrategy val_17;
            var val_19;
            var val_20;
            string val_23;
            val_13 = value;
            if(val_13 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_14 = val_13;
            if(val_14 == null)
            {
                goto label_3;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_7;
            label_3:
            val_14 = val_13;
            if(val_14 == null)
            {
                goto label_8;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            goto label_12;
            label_2:
            bool val_1 = SimpleJson2.SimpleJson2.SerializeString(aString:  val_13, builder:  builder);
            label_51:
            val_17 = 1;
            return (bool)SimpleJson2.SimpleJson2.SerializeObject(jsonSerializerStrategy:  val_17 = jsonSerializerStrategy, keys:  val_13 = val_14.Keys, values:  val_14.Values, builder:  builder);
            label_7:
            val_19 = null;
            var val_20 = 0;
            val_20 = 1152921504627703816;
            val_20 = val_20 + 1;
            goto label_27;
            label_8:
            if(val_13 == null)
            {
                goto label_20;
            }
            
            val_17 = jsonSerializerStrategy;
            bool val_4 = SimpleJson2.SimpleJson2.SerializeArray(jsonSerializerStrategy:  val_17, anArray:  val_13, builder:  builder);
            return (bool)SimpleJson2.SimpleJson2.SerializeObject(jsonSerializerStrategy:  val_17, keys:  val_13, values:  val_14.Values, builder:  builder);
            label_12:
            val_19 = null;
            val_13 = val_14.Keys;
            var val_21 = 0;
            val_20 = 1152921504627703816;
            val_21 = val_21 + 1;
            label_27:
            return (bool)SimpleJson2.SimpleJson2.SerializeObject(jsonSerializerStrategy:  val_17, keys:  val_13, values:  val_14.Values, builder:  builder);
            label_20:
            if((SimpleJson2.SimpleJson2.IsNumeric(value:  val_13)) == false)
            {
                goto label_32;
            }
            
            bool val_12 = SimpleJson2.SimpleJson2.SerializeNumber(number:  val_13, builder:  builder);
            goto label_51;
            label_32:
            if(val_13 == null)
            {
                goto label_36;
            }
            
            if(null == null)
            {
                goto label_37;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_42;
            label_36:
            val_23 = "null";
            goto label_44;
            label_37:
            val_23 = (null == 0) ? "false" : "true";
            label_44:
            System.Text.StringBuilder val_14 = builder.Append(value:  val_23);
            goto label_51;
            label_42:
            if((jsonSerializerStrategy.TrySerializeNonPrimitiveObject(input:  val_13, output: out  0)) == false)
            {
                    return (bool)SimpleJson2.SimpleJson2.SerializeObject(jsonSerializerStrategy:  val_17, keys:  val_13, values:  val_14.Values, builder:  builder);
            }
            
            goto label_51;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool SerializeObject(SimpleJson2.IJsonSerializerStrategy jsonSerializerStrategy, System.Collections.IEnumerable keys, System.Collections.IEnumerable values, System.Text.StringBuilder builder)
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
            
            if((SimpleJson2.SimpleJson2.SerializeValue(jsonSerializerStrategy:  jsonSerializerStrategy, value:  val_11, builder:  builder)) == false)
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
            if((SimpleJson2.SimpleJson2.SerializeValue(jsonSerializerStrategy:  jsonSerializerStrategy, value:  val_11, builder:  builder)) == true)
            {
                goto label_39;
            }
            
            return (bool)val_20;
            label_32:
            bool val_16 = SimpleJson2.SimpleJson2.SerializeString(aString:  val_14, builder:  builder);
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
        private static bool SerializeArray(SimpleJson2.IJsonSerializerStrategy jsonSerializerStrategy, System.Collections.IEnumerable anArray, System.Text.StringBuilder builder)
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
            
            if((SimpleJson2.SimpleJson2.SerializeValue(jsonSerializerStrategy:  jsonSerializerStrategy, value:  val_3.Current, builder:  builder)) == true)
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
            val_15 = aString.IndexOfAny(anyOf:  SimpleJson2.SimpleJson2.EscapeCharacters);
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
            if(val_3[0] >= SimpleJson2.SimpleJson2.EscapeTable.Length)
            {
                goto label_17;
            }
            
            val_18 = null;
            val_18 = null;
            System.Char[] val_4 = SimpleJson2.SimpleJson2.EscapeTable + ((val_3[0x0][0]) << 1);
            if(((SimpleJson2.SimpleJson2.EscapeTable + (val_3[0x0][0]) << 1) + 32) == 0)
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
            System.Char[] val_7 = SimpleJson2.SimpleJson2.EscapeTable + ((val_3[0x0][0]) << 1);
            System.Text.StringBuilder val_8 = builder.Append(value:  (SimpleJson2.SimpleJson2.EscapeTable + (val_3[0x0][0]) << 1) + 32);
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
            
            if(null == null)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                goto label_6;
            }
            
            if(null == null)
            {
                goto label_7;
            }
            
            label_1:
            string val_4 = System.Convert.ToDouble(value:  number, provider:  System.Globalization.CultureInfo.InvariantCulture).ToString(format:  "r", provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_27;
            label_2:
            string val_6 = null.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_27;
            label_3:
            string val_8 = null.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_27;
            label_4:
            string val_10 = null.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_27;
            label_5:
            string val_12 = null.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_27;
            label_6:
            string val_14 = null.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            goto label_27;
            label_7:
            label_27:
            System.Text.StringBuilder val_17 = builder.Append(value:  null.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
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
        public static SimpleJson2.IJsonSerializerStrategy get_CurrentJsonSerializerStrategy()
        {
            var val_2;
            SimpleJson2.IJsonSerializerStrategy val_3;
            val_2 = null;
            val_2 = null;
            val_3 = SimpleJson2.SimpleJson2._currentJsonSerializerStrategy;
            if(val_3 != null)
            {
                    return (SimpleJson2.IJsonSerializerStrategy)val_3;
            }
            
            val_3 = SimpleJson2.SimpleJson2.PocoJsonSerializerStrategy;
            SimpleJson2.SimpleJson2._currentJsonSerializerStrategy = val_3;
            return (SimpleJson2.IJsonSerializerStrategy)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_CurrentJsonSerializerStrategy(SimpleJson2.IJsonSerializerStrategy value)
        {
            null = null;
            SimpleJson2.SimpleJson2._currentJsonSerializerStrategy = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SimpleJson2.PocoJsonSerializerStrategy get_PocoJsonSerializerStrategy()
        {
            var val_2;
            SimpleJson2.PocoJsonSerializerStrategy val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = SimpleJson2.SimpleJson2._pocoJsonSerializerStrategy;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            SimpleJson2.PocoJsonSerializerStrategy val_1 = null;
            val_3 = val_1;
            val_1 = new SimpleJson2.PocoJsonSerializerStrategy();
            val_4 = null;
            val_4 = null;
            SimpleJson2.SimpleJson2._pocoJsonSerializerStrategy = val_3;
            return val_3;
        }
    
    }

}
