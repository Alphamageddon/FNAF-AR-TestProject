using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConflictUser : PublicUser, IConvertableFromNative<GetSocialSdk.Core.ConflictUser>
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ConflictUser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ConflictUser(System.Collections.Generic.Dictionary<string, string> publicProperties, string id, string displayName, string avatarUrl, System.Collections.Generic.Dictionary<string, string> identities)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ConflictUser ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            GetSocialSdk.Core.PublicUser val_1 = this.ParseFromAJO(ajo:  ajo);
            if(ajo != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                ajo.Dispose();
            }
            
            if(22 == 22)
            {
                    return (GetSocialSdk.Core.ConflictUser)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.ConflictUser)this;
            }
            
            return (GetSocialSdk.Core.ConflictUser)this;
        }
    
    }

}
