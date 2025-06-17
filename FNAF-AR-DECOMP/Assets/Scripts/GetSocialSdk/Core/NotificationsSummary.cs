using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class NotificationsSummary : IConvertableFromNative<GetSocialSdk.Core.NotificationsSummary>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <SuccessfullySentCount>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SuccessfullySentCount { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_SuccessfullySentCount()
        {
            return (int)this.<SuccessfullySentCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_SuccessfullySentCount(int value)
        {
            this.<SuccessfullySentCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsSummary ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<SuccessfullySentCount>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getSuccessfullySentCount", args:  System.Array.Empty<System.Object>());
            return (GetSocialSdk.Core.NotificationsSummary)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NotificationsSummary()
        {
        
        }
    
    }

}
