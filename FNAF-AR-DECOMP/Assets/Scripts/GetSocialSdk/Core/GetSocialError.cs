using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class GetSocialError : IConvertableFromNative<GetSocialSdk.Core.GetSocialError>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <ErrorCode>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Message>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ErrorCode { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_ErrorCode()
        {
            return (int)this.<ErrorCode>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ErrorCode(int value)
        {
            this.<ErrorCode>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialError(int errorCode, string message)
        {
            val_1 = new System.Object();
            this.<ErrorCode>k__BackingField = errorCode;
            this.<Message>k__BackingField = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialError(string message)
        {
            this.<ErrorCode>k__BackingField = 0;
            this.<Message>k__BackingField = message;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialError()
        {
            this.<ErrorCode>k__BackingField = 0;
            this.<Message>k__BackingField = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "Error code: {0}. Message: {1}", arg0:  this.<ErrorCode>k__BackingField, arg1:  this.<Message>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialError ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<ErrorCode>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getErrorCode", args:  System.Array.Empty<System.Object>());
            this.<Message>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getMessage", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                ajo.Dispose();
            }
            
            if(58 == 58)
            {
                    return (GetSocialSdk.Core.GetSocialError)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.GetSocialError)this;
            }
            
            return (GetSocialSdk.Core.GetSocialError)this;
        }
    
    }

}
