using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class Check
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void IfTrue(GetSocialSdk.Core.Check.Condition condition, string message = "")
        {
            if(condition.Invoke() != false)
            {
                    return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  message);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void IfTrue(bool condition, string message = "")
        {
            if(condition != false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  message);
        }
    
    }

}
