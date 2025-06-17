using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Mention : IConvertableFromNative<GetSocialSdk.Core.Mention>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <UserId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <StartIndex>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <EndIndex>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Type>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StartIndex { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int EndIndex { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_UserId()
        {
            return (string)this.<UserId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_UserId(string value)
        {
            this.<UserId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_StartIndex()
        {
            return (int)this.<StartIndex>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_StartIndex(int value)
        {
            this.<StartIndex>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_EndIndex()
        {
            return (int)this.<EndIndex>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_EndIndex(int value)
        {
            this.<EndIndex>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Type()
        {
            return (string)this.<Type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Type(string value)
        {
            this.<Type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<UserId>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<UserId>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<UserId>k__BackingField;
            val_1[1] = this.<StartIndex>k__BackingField;
            val_1[2] = this.<EndIndex>k__BackingField;
            val_1[3] = this.<Type>k__BackingField;
            return (string)System.String.Format(format:  "{0} ({1}, {2}) - {3}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mention()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal Mention(string userId, int startIndex, int endIndex, string type)
        {
            val_1 = new System.Object();
            this.<UserId>k__BackingField = userId;
            this.<StartIndex>k__BackingField = startIndex;
            this.<EndIndex>k__BackingField = endIndex;
            this.<Type>k__BackingField = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool Equals(GetSocialSdk.Core.Mention other)
        {
            if((System.String.Equals(a:  this.<UserId>k__BackingField, b:  other.<UserId>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((this.<StartIndex>k__BackingField) != (other.<StartIndex>k__BackingField))
            {
                    return false;
            }
            
            if((this.<EndIndex>k__BackingField) != (other.<EndIndex>k__BackingField))
            {
                    return false;
            }
            
            return System.String.Equals(a:  this.<Type>k__BackingField, b:  other.<Type>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            System.Type val_8;
            GetSocialSdk.Core.Mention val_9;
            var val_10;
            val_9 = obj;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if(this == val_9)
            {
                goto label_2;
            }
            
            val_8 = val_9.GetType();
            if((System.Type.op_Inequality(left:  val_8, right:  this.GetType())) == false)
            {
                goto label_5;
            }
            
            label_1:
            val_10 = 0;
            return (bool)this.Equals(other:  val_9 = 0);
            label_2:
            val_10 = 1;
            return (bool)this.Equals(other:  val_9);
            label_5:
            val_10 = this;
            return (bool)this.Equals(other:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            var val_3;
            if((this.<UserId>k__BackingField) != null)
            {
                    val_3 = (this.<UserId>k__BackingField) * 397;
            }
            else
            {
                    val_3 = 0;
            }
            
            string val_2 = this.<Type>k__BackingField;
            val_3 = (this.<StartIndex>k__BackingField) ^ val_3;
            val_3 = val_3 * 397;
            val_3 = val_3 ^ (this.<EndIndex>k__BackingField);
            val_2 = val_2 ^ (val_3 * 397);
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.Mention ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<UserId>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getUserId", args:  System.Array.Empty<System.Object>());
            this.<StartIndex>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getStartIndex", args:  System.Array.Empty<System.Object>());
            this.<EndIndex>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getEndIndex", args:  System.Array.Empty<System.Object>());
            this.<Type>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getType", args:  System.Array.Empty<System.Object>());
            return (GetSocialSdk.Core.Mention)this;
        }
    
    }

}
