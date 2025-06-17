using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class GetSocialDebugLogger
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void D(string message, object[] arguments)
        {
            string val_2;
            var val_3;
            val_2 = message;
            if((arguments != null) && (arguments.Length != 0))
            {
                    val_2 = System.String.Format(format:  val_2, args:  arguments);
                val_3 = null;
            }
            else
            {
                    val_3 = null;
            }
            
            UnityEngine.Debug.Log(message:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void I(string message, object[] arguments)
        {
            string val_2;
            var val_3;
            val_2 = message;
            if((arguments != null) && (arguments.Length != 0))
            {
                    val_2 = System.String.Format(format:  val_2, args:  arguments);
                val_3 = null;
            }
            else
            {
                    val_3 = null;
            }
            
            UnityEngine.Debug.Log(message:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void W(string message, object[] arguments)
        {
            string val_2;
            var val_3;
            val_2 = message;
            if((arguments != null) && (arguments.Length != 0))
            {
                    val_2 = System.String.Format(format:  val_2, args:  arguments);
                val_3 = null;
            }
            else
            {
                    val_3 = null;
            }
            
            UnityEngine.Debug.LogWarning(message:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void E(string message, object[] arguments)
        {
            string val_2;
            var val_3;
            val_2 = message;
            if((arguments != null) && (arguments.Length != 0))
            {
                    val_2 = System.String.Format(format:  val_2, args:  arguments);
                val_3 = null;
            }
            else
            {
                    val_3 = null;
            }
            
            UnityEngine.Debug.LogError(message:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Ex(System.Exception ex, string message, object[] arguments)
        {
            UnityEngine.Debug.LogException(exception:  ex);
        }
    
    }

}
