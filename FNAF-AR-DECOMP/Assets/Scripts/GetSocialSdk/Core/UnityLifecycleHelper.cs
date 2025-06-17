using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UnityLifecycleHelper : Singleton<GetSocialSdk.Core.UnityLifecycleHelper>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void Init()
        {
            GetSocialSdk.Core.Singleton<GetSocialSdk.Core.UnityLifecycleHelper>.LoadInstance();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocialFactory.Instance.HandleOnStartUnityEvent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityLifecycleHelper()
        {
        
        }
    
    }

}
