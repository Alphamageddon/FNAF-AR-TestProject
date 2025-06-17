using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal.Utils
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnityCoroutineHelper : MonoBehaviour
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper Instance { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper get_Instance()
        {
            var val_4 = null;
            object val_1 = UnityEngine.Object.FindObjectOfType<System.Object>();
            if(val_1 != 0)
            {
                    return (Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper)val_1;
            }
            
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "App Center Helper");
            val_3.hideFlags = 61;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_3);
            if(val_3 != null)
            {
                    return val_3.AddComponent<Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper>();
            }
            
            return val_3.AddComponent<Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartCoroutine(System.Func<System.Collections.IEnumerator> coroutine)
        {
            UnityEngine.Coroutine val_3 = Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper.Instance.StartCoroutine(routine:  coroutine.Invoke());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityCoroutineHelper()
        {
        
        }
    
    }

}
