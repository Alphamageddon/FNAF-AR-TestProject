using UnityEngine;

namespace GetSocialSdk.MiniJSON
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GSJson
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Globalization.NumberFormatInfo numberFormat;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static object Deserialize(string json)
        {
            if(json == null)
            {
                    return (object)json;
            }
            
            return GSJson.Parser.Parse(jsonString:  json);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string Serialize(object obj)
        {
            return GSJson.Serializer.Serialize(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string TextureToBase64(UnityEngine.Texture2D obj)
        {
            if(obj != 0)
            {
                    return System.Convert.ToBase64String(inArray:  UnityEngine.ImageConversion.EncodeToPNG(tex:  obj));
            }
            
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static UnityEngine.Texture2D FromBase64(string base64Image)
        {
            string val_5;
            UnityEngine.Texture2D val_6;
            val_5 = base64Image;
            val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  val_5)) == true)
            {
                    return val_6;
            }
            
            val_5 = System.Convert.FromBase64String(s:  val_5);
            UnityEngine.Texture2D val_3 = null;
            val_6 = val_3;
            val_3 = new UnityEngine.Texture2D(width:  1, height:  1);
            bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  val_3, data:  val_5);
            val_3.Apply();
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string ByteArrayToBase64(byte[] byteArray)
        {
            if(byteArray == null)
            {
                    return "";
            }
            
            return System.Convert.ToBase64String(inArray:  byteArray);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GSJson()
        {
            GetSocialSdk.MiniJSON.GSJson.numberFormat = new System.Globalization.CultureInfo(name:  "en-US");
        }
    
    }

}
