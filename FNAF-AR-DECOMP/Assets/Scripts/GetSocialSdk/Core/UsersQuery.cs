using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UsersQuery : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DefaultLimit = 20;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _query;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _limit;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UsersQuery(string query)
        {
            this._query = query;
            this._limit = 20;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.UsersQuery UsersByDisplayName(string query)
        {
            ._query = query;
            ._limit = 20;
            return (GetSocialSdk.Core.UsersQuery)new GetSocialSdk.Core.UsersQuery();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.UsersQuery WithLimit(int limit)
        {
            this._limit = limit;
            return (GetSocialSdk.Core.UsersQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(this._query != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this._query == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = this._query;
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_7;
            }
            
            if(this._limit != 0)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(this._limit == 0)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_4[0] = this._limit;
            return (UnityEngine.AndroidJavaObject)GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.usermanagement.UsersQuery"), methodName:  "usersByDisplayName", args:  val_2), methodName:  "withLimit", args:  val_4);
        }
    
    }

}
