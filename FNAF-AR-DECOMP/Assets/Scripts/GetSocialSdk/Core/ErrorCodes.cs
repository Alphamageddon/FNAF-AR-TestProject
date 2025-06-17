using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class ErrorCodes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int Unknown = -1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int CompositeException = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int ActionDenied = 201;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int SdkNotInitialized = 202;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int SdkInitializationFailed = 203;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int IllegalArgument = 204;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int IllegalState = 205;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int NullPointer = 206;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int NotFound = 207;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int UserIsBanned = 208;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int PlatformDisabled = 209;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int AppSignatureMismatch = 210;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int UserIdTokenMismatch = 211;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int InviteCancelled = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int UserConflict = 101;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int NoReferrerMatch = 102;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int OOM = 103;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int ConnectionTimeout = 701;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int NoInternet = 702;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int TransportClosed = 703;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int MediaUploadFailed = 800;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int MediaUploadResourceNotReady = 801;
        
    
    }

}
