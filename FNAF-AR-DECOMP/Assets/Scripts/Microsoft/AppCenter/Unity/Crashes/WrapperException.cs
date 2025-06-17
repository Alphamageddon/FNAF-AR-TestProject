using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WrapperException
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
        public WrapperException()
        {
            this._rawObject = Microsoft.AppCenter.Unity.Crashes.Internal.WrapperExceptionInternal.Create();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetType(string type)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.WrapperExceptionInternal.SetType(exception:  this._rawObject, type:  type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetMessage(string message)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.WrapperExceptionInternal.SetMessage(exception:  this._rawObject, message:  message);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetStacktrace(string stacktrace)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.WrapperExceptionInternal.SetStacktrace(exception:  this._rawObject, stacktrace:  stacktrace);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetInnerException(UnityEngine.AndroidJavaObject innerException)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.WrapperExceptionInternal.SetInnerException(exception:  this._rawObject, innerException:  innerException);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWrapperSdkName(string sdkName)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.WrapperExceptionInternal.SetWrapperSdkName(exception:  this._rawObject, sdkName:  sdkName);
        }
    
    }

}
