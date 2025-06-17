using UnityEngine;

namespace Microsoft.AppCenter.Unity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CustomProperties
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.AndroidJavaObject _rawObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal UnityEngine.AndroidJavaObject GetRawObject()
        {
            return (UnityEngine.AndroidJavaObject)this._rawObject;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CustomProperties()
        {
            this._rawObject = Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.Create();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, string val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetString(properties:  this._rawObject, key:  key, val:  val);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, System.DateTime val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetDate(properties:  this._rawObject, key:  key, val:  new System.DateTime() {dateData = val.dateData});
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, int val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetNumber(properties:  this._rawObject, key:  key, val:  val);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, long val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetNumber(properties:  this._rawObject, key:  key, val:  val);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, float val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetNumber(properties:  this._rawObject, key:  key, val:  val);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, double val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetNumber(properties:  this._rawObject, key:  key, val:  val);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Set(string key, bool val)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.SetBool(properties:  this._rawObject, key:  key, val:  val);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.CustomProperties Clear(string key)
        {
            Microsoft.AppCenter.Unity.Internal.CustomPropertiesInternal.Clear(properties:  this._rawObject, key:  key);
            return (Microsoft.AppCenter.Unity.CustomProperties)this;
        }
    
    }

}
