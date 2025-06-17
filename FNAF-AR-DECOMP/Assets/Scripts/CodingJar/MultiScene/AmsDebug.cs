using UnityEngine;

namespace CodingJar.MultiScene
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AmsDebug
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static void EditorConditionalRestoreAllCrossSceneReferences()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Log(UnityEngine.Object context, string message, object[] parms)
        {
            UnityEngine.Debug.LogFormat(context:  context, format:  "Ams Plugin: "("Ams Plugin: ") + message, args:  parms);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LogWarning(UnityEngine.Object context, string message, object[] parms)
        {
            UnityEngine.Debug.LogWarningFormat(context:  context, format:  "Ams Plugin: "("Ams Plugin: ") + message, args:  parms);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LogError(UnityEngine.Object context, string message, object[] parms)
        {
            UnityEngine.Debug.LogErrorFormat(context:  context, format:  "Ams Plugin: "("Ams Plugin: ") + message, args:  parms);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LogPerf(UnityEngine.Object context, string message, object[] parms)
        {
            UnityEngine.Debug.LogFormat(context:  context, format:  "Ams Perf: "("Ams Perf: ") + message, args:  parms);
        }
    
    }

}
