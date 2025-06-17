using UnityEngine;

namespace Microsoft.AppCenter.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class WrapperSdk
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string _wrapperRuntimeVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _hasAttemptedToGetRuntimeVersion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string Name = "appcenter.unity";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string WrapperSdkVersion = "2.3.0";
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static string WrapperRuntimeVersion { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static string get_WrapperRuntimeVersion()
        {
            string val_2;
            if(Microsoft.AppCenter.Unity.WrapperSdk._hasAttemptedToGetRuntimeVersion != false)
            {
                    val_2 = Microsoft.AppCenter.Unity.WrapperSdk.WrapperSdkVersion;
                return val_1;
            }
            
            string val_1 = Microsoft.AppCenter.Unity.WrapperSdk.GetWrapperRuntimeVersion();
            Microsoft.AppCenter.Unity.WrapperSdk.WrapperSdkVersion = val_1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetWrapperRuntimeVersion()
        {
            System.Type val_8;
            var val_9;
            Microsoft.AppCenter.Unity.WrapperSdk._hasAttemptedToGetRuntimeVersion = true;
            val_8 = System.Type.GetType(typeName:  "Mono.Runtime");
            if(val_8 == null)
            {
                    val_8 = System.Type.GetType(typeName:  "Mono.Runtime");
            }
            
            val_9 = 0;
            if((System.Type.op_Inequality(left:  val_8, right:  0)) == false)
            {
                    return (string)val_9;
            }
            
            System.Reflection.MethodInfo val_4 = val_8.GetMethod(name:  "GetDisplayName", bindingAttr:  40);
            val_8 = val_4;
            val_9 = 0;
            if((System.Reflection.MethodInfo.op_Inequality(left:  val_4, right:  0)) == false)
            {
                    return (string)val_9;
            }
            
            if((val_8.Invoke(obj:  0, parameters:  0)) == null)
            {
                    return (string)val_9;
            }
            
            if(null == null)
            {
                    return (string)val_9;
            }
            
            val_9 = 0;
            return (string)val_9;
        }
    
    }

}
