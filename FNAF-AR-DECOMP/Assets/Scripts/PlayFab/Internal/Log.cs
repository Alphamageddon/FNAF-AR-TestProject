using UnityEngine;

namespace PlayFab.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class Log
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Debug(string text, object[] args)
        {
            if((PlayFab.PlayFabSettings.LogLevel & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  PlayFab.Internal.PlayFabUtil.timeStamp + " DEBUG: "(" DEBUG: ") + PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)(PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Info(string text, object[] args)
        {
            if((PlayFab.PlayFabSettings.LogLevel & 2) == 0)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  PlayFab.Internal.PlayFabUtil.timeStamp + " INFO: "(" INFO: ") + PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)(PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Warning(string text, object[] args)
        {
            if((PlayFab.PlayFabSettings.LogLevel & 4) == 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  PlayFab.Internal.PlayFabUtil.timeStamp + " WARNING: "(" WARNING: ") + PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)(PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Error(string text, object[] args)
        {
            if((PlayFab.PlayFabSettings.LogLevel & 8) == 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  PlayFab.Internal.PlayFabUtil.timeStamp + " ERROR: "(" ERROR: ") + PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)(PlayFab.Internal.PlayFabUtil.Format(text:  text, args:  args)));
        }
    
    }

}
