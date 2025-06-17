using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class WsaReflectionExtensions
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Delegate CreateDelegate(System.Reflection.MethodInfo methodInfo, System.Type delegateType, object instance)
        {
            return System.Delegate.CreateDelegate(type:  delegateType, firstArgument:  instance, method:  methodInfo);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type GetTypeInfo(System.Type type)
        {
            return (System.Type)type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static System.Type AsType(System.Type type)
        {
            return (System.Type)type;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetDelegateName(System.Delegate delegateInstance)
        {
            if(delegateInstance.Method == null)
            {
                
            }
        
        }
    
    }

}
