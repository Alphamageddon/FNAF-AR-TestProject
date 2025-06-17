using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SuggestedFriend : PublicUser, IConvertableFromNative<GetSocialSdk.Core.SuggestedFriend>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <MutualFriendsCount>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MutualFriendsCount { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MutualFriendsCount()
        {
            return (int)this.<MutualFriendsCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MutualFriendsCount(int value)
        {
            this.<MutualFriendsCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(X21 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(X21 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = null;
            val_1[1] = null;
            val_1[2] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  X21);
            val_1[3] = this.<MutualFriendsCount>k__BackingField;
            return (string)System.String.Format(format:  "[SuggestedFriend: Id={0}, DisplayName={1}, Identities={2}, MutualFriendsCount={3}]", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.SuggestedFriend ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            GetSocialSdk.Core.PublicUser val_1 = this.ParseFromAJO(ajo:  ajo);
            this.<MutualFriendsCount>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getMutualFriendsCount", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                ajo.Dispose();
            }
            
            if(44 == 44)
            {
                    return (GetSocialSdk.Core.SuggestedFriend)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.SuggestedFriend)this;
            }
            
            return (GetSocialSdk.Core.SuggestedFriend)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SuggestedFriend()
        {
            val_1 = new System.Object();
        }
    
    }

}
