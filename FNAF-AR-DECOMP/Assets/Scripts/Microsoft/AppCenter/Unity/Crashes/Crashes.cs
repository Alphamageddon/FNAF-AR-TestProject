using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Crashes
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string CrashesSDKVersion = "2.3.0";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _reportUnhandledExceptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly object _objectLock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Queue<System.Exception> _unhandledExceptions;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.Crashes.Crashes.UserConfirmationHandler ShouldAwaitUserConfirmation { set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.Crashes.Crashes.ShouldProcessErrorReportHandler ShouldProcessErrorReport { set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.Crashes.Crashes.GetErrorAttachmentsHandler GetErrorAttachments { set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PrepareEventHandlers()
        {
            AppCenterBehavior.add_InitializingServices(value:  new System.Action(object:  0, method:  public static System.Void Microsoft.AppCenter.Unity.Crashes.Crashes::Initialize()));
            AppCenterBehavior.add_InitializedAppCenterAndServices(value:  new System.Action(object:  0, method:  static System.Void Microsoft.AppCenter.Unity.Crashes.Crashes::HandleAppCenterInitialized()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Initialize()
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SetDelegate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddNativeType(System.Collections.Generic.List<IntPtr> nativeTypes)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.AddNativeType(nativeTypes:  nativeTypes);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void TrackError(System.Exception exception, System.Collections.Generic.IDictionary<string, string> properties)
        {
            if(exception == null)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.WrapperException val_1 = Microsoft.AppCenter.Unity.Crashes.Crashes.CreateWrapperException(exception:  exception);
            if(properties != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                if(properties.Count != 0)
            {
                    Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.TrackException(exception:  val_1.GetRawObject(), properties:  properties);
                return;
            }
            
            }
            
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.TrackException(exception:  val_1.GetRawObject());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnHandleLog(string logString, string stackTrace, UnityEngine.LogType type)
        {
            if(type > 4)
            {
                    return;
            }
            
            var val_3 = 1;
            val_3 = val_3 << type;
            val_3 = val_3 & 19;
            if(val_3 == 0)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.TrackException(exception:  Microsoft.AppCenter.Unity.Crashes.Crashes.CreateWrapperException(logString:  logString, stackTrace:  stackTrace, type:  type).GetRawObject());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OnHandleUnresolvedException(object sender, System.UnhandledExceptionEventArgs args)
        {
            string val_6;
            var val_7;
            var val_8;
            val_6 = args;
            if(val_6 == null)
            {
                    return;
            }
            
            if(val_6.ExceptionObject == null)
            {
                    return;
            }
            
            object val_2 = val_6.ExceptionObject;
            if(val_2 == null)
            {
                    return;
            }
            
            val_6 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Exception.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            UnityEngine.Debug.Log(message:  "Unhandled exception: "("Unhandled exception: ") + val_6);
            val_7 = null;
            val_7 = null;
            bool val_4 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions, lockTaken: ref  val_4);
            val_8 = null;
            val_8 = null;
            Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions.Enqueue(item:  val_6);
            if(val_4 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions);
            }
            
            System.Func<System.Collections.IEnumerator> val_5 = null;
            val_6 = val_5;
            val_5 = new System.Func<System.Collections.IEnumerator>(object:  0, method:  static System.Collections.IEnumerator Microsoft.AppCenter.Unity.Crashes.Crashes::SendUnhandledExceptionReports());
            Microsoft.AppCenter.Unity.Internal.Utils.UnityCoroutineHelper.StartCoroutine(coroutine:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<string> GetMinidumpDirectoryAsync()
        {
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.GetMinidumpDirectoryAsync();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> HasReceivedMemoryWarningInLastSessionAsync()
        {
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.HasReceivedMemoryWarningInLastSessionAsync();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> IsEnabledAsync()
        {
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.IsEnabledAsync();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask SetEnabledAsync(bool enabled)
        {
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.SetEnabledAsync(isEnabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GenerateTestCrash()
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.GenerateTestCrash();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<bool> HasCrashedInLastSessionAsync()
        {
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.HasCrashedInLastSessionAsync();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DisableMachExceptionHandler()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.AppCenterTask<Microsoft.AppCenter.Unity.Crashes.ErrorReport> GetLastSessionCrashReportAsync()
        {
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.GetLastSessionCrashReportAsync();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReportUnhandledExceptions(bool enabled)
        {
            var val_3 = null;
            var val_1 = (Microsoft.AppCenter.Unity.Crashes.Crashes._reportUnhandledExceptions == true) ? 1 : 0;
            val_1 = val_1 ^ enabled;
            if(val_1 == false)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Crashes._reportUnhandledExceptions = enabled;
            if(enabled != false)
            {
                    Microsoft.AppCenter.Unity.Crashes.Crashes.SubscribeToUnhandledExceptions();
                return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Crashes.UnsubscribeFromUnhandledExceptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsReportingUnhandledExceptions()
        {
            null = null;
            return (bool)Microsoft.AppCenter.Unity.Crashes.Crashes._reportUnhandledExceptions;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_ShouldAwaitUserConfirmation(Microsoft.AppCenter.Unity.Crashes.Crashes.UserConfirmationHandler value)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.SetUserConfirmationHandler(handler:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NotifyUserConfirmation(Microsoft.AppCenter.Unity.Crashes.Crashes.ConfirmationResult answer)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.NotifyWithUserConfirmation(answer:  answer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_ShouldProcessErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.ShouldProcessErrorReportHandler value)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SetShouldProcessErrorReportHandler(handler:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void set_GetErrorAttachments(Microsoft.AppCenter.Unity.Crashes.Crashes.GetErrorAttachmentsHandler value)
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SetGetErrorAttachmentsHandler(handler:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_SendingErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SendingErrorReportHandler value)
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock, lockTaken: ref  val_1);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.add_SendingErrorReport(value:  value);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock);
            }
            
            if(34 == 34)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_SendingErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SendingErrorReportHandler value)
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock, lockTaken: ref  val_1);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.remove_SendingErrorReport(value:  value);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock);
            }
            
            if(34 == 34)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_SentErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SentErrorReportHandler value)
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock, lockTaken: ref  val_1);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.add_SentErrorReport(value:  value);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock);
            }
            
            if(34 == 34)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_SentErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SentErrorReportHandler value)
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock, lockTaken: ref  val_1);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.remove_SentErrorReport(value:  value);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock);
            }
            
            if(34 == 34)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_FailedToSendErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.FailedToSendErrorReportHandler value)
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock, lockTaken: ref  val_1);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.add_FailedToSendErrorReport(value:  value);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock);
            }
            
            if(34 == 34)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_FailedToSendErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.FailedToSendErrorReportHandler value)
        {
            null = null;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock, lockTaken: ref  val_1);
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.remove_FailedToSendErrorReport(value:  value);
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock);
            }
            
            if(34 == 34)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartCrashes()
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesInternal.StartCrashes();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SubscribeToUnhandledExceptions()
        {
            UnityEngine.Application.add_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  public static System.Void Microsoft.AppCenter.Unity.Crashes.Crashes::OnHandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
            System.AppDomain.CurrentDomain.add_UnhandledException(value:  new System.UnhandledExceptionEventHandler(object:  0, method:  public static System.Void Microsoft.AppCenter.Unity.Crashes.Crashes::OnHandleUnresolvedException(object sender, System.UnhandledExceptionEventArgs args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void UnsubscribeFromUnhandledExceptions()
        {
            UnityEngine.Application.remove_logMessageReceived(value:  new Application.LogCallback(object:  0, method:  public static System.Void Microsoft.AppCenter.Unity.Crashes.Crashes::OnHandleLog(string logString, string stackTrace, UnityEngine.LogType type)));
            System.AppDomain.CurrentDomain.remove_UnhandledException(value:  new System.UnhandledExceptionEventHandler(object:  0, method:  public static System.Void Microsoft.AppCenter.Unity.Crashes.Crashes::OnHandleUnresolvedException(object sender, System.UnhandledExceptionEventArgs args)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void HandleAppCenterInitialized()
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Crashes.Crashes._reportUnhandledExceptions == false)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Crashes.SubscribeToUnhandledExceptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.IEnumerator SendUnhandledExceptionReports()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new Crashes.<SendUnhandledExceptionReports>d__47();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.WrapperException CreateWrapperException(System.Exception exception)
        {
            Microsoft.AppCenter.Unity.Crashes.WrapperException val_1 = new Microsoft.AppCenter.Unity.Crashes.WrapperException();
            val_1.SetWrapperSdkName(sdkName:  "appcenter.xamarin");
            val_1.SetStacktrace(stacktrace:  exception);
            val_1.SetMessage(message:  exception);
            val_1.SetType(type:  exception.GetType());
            if(exception.InnerException == null)
            {
                    return val_1;
            }
            
            val_1.SetInnerException(innerException:  exception.InnerException.GetRawObject());
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.WrapperException CreateWrapperException(string logString, string stackTrace, UnityEngine.LogType type)
        {
            var val_9;
            string val_10;
            Microsoft.AppCenter.Unity.Crashes.WrapperException val_1 = new Microsoft.AppCenter.Unity.Crashes.WrapperException();
            val_1.SetWrapperSdkName(sdkName:  "appcenter.xamarin");
            val_1.SetMessage(message:  logString.Replace(oldValue:  "\n", newValue:  " "));
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = type});
            val_1.SetType(type:  type.ToString());
            char[] val_5 = new char[1];
            val_5[0] = '
            ';
            val_9 = 0;
            val_10 = "";
            goto label_13;
            label_18:
            string val_9 = stackTrace.Split(separator:  val_5)[0];
            if(val_9.Length >= 1)
            {
                    val_10 = val_10 + "at " + val_9 + "\n";
            }
            
            val_9 = 1;
            label_13:
            if(val_9 < val_6.Length)
            {
                goto label_18;
            }
            
            val_1.SetStacktrace(stacktrace:  val_10);
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetExceptionWrapperSdkName()
        {
            return "appcenter.xamarin";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Crashes()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Crashes()
        {
            Microsoft.AppCenter.Unity.Crashes.Crashes._reportUnhandledExceptions = false;
            Microsoft.AppCenter.Unity.Crashes.Crashes._objectLock = new System.Object();
            Microsoft.AppCenter.Unity.Crashes.Crashes._unhandledExceptions = new System.Collections.Generic.Queue<System.Exception>();
        }
    
    }

}
