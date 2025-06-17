using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CrashesDelegate : AndroidJavaProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.Crashes.SendingErrorReportHandler SendingErrorReport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.Crashes.SentErrorReportHandler SentErrorReport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.Crashes.FailedToSendErrorReportHandler FailedToSendErrorReport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.Crashes.GetErrorAttachmentsHandler GetErrorAttachments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.Crashes.UserConfirmationHandler shouldAwaitUserConfirmationHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static Microsoft.AppCenter.Unity.Crashes.Crashes.ShouldProcessErrorReportHandler shouldProcessErrorReportHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaClass _errorAttachmentLog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate instance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_SendingErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SendingErrorReportHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SendingErrorReport, b:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_SendingErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SendingErrorReportHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SendingErrorReport, value:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_SentErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SentErrorReportHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SentErrorReport, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SentErrorReport != 1152921505335603208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_SentErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.SentErrorReportHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SentErrorReport, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SentErrorReport != 1152921505335603208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_FailedToSendErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.FailedToSendErrorReportHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.FailedToSendErrorReport, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.FailedToSendErrorReport != 1152921505335603216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_FailedToSendErrorReport(Microsoft.AppCenter.Unity.Crashes.Crashes.FailedToSendErrorReportHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.FailedToSendErrorReport, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.FailedToSendErrorReport != 1152921505335603216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void add_GetErrorAttachments(Microsoft.AppCenter.Unity.Crashes.Crashes.GetErrorAttachmentsHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.GetErrorAttachments, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.GetErrorAttachments != 1152921505335603224);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void remove_GetErrorAttachments(Microsoft.AppCenter.Unity.Crashes.Crashes.GetErrorAttachmentsHandler value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.GetErrorAttachments, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.GetErrorAttachments != 1152921505335603224);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CrashesDelegate()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetDelegate()
        {
            var val_3;
            object[] val_2 = new object[1];
            val_3 = null;
            val_3 = null;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.instance != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.instance == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.instance;
            new UnityEngine.AndroidJavaClass(className:  "com.microsoft.appcenter.crashes.Crashes").CallStatic(methodName:  "setListener", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void onBeforeSending(UnityEngine.AndroidJavaObject report)
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SendingErrorReport == null)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SendingErrorReport.Invoke(errorReport:  JavaObjectsConverter.ConvertErrorReport(errorReport:  report));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void onSendingFailed(UnityEngine.AndroidJavaObject report, UnityEngine.AndroidJavaObject exception)
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.FailedToSendErrorReport == null)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.FailedToSendErrorReport.Invoke(errorReport:  JavaObjectsConverter.ConvertErrorReport(errorReport:  report), exception:  JavaObjectsConverter.ConvertException(throwable:  exception));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void onSendingSucceeded(UnityEngine.AndroidJavaObject report)
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SentErrorReport == null)
            {
                    return;
            }
            
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.SentErrorReport.Invoke(errorReport:  JavaObjectsConverter.ConvertErrorReport(errorReport:  report));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool shouldProcess(UnityEngine.AndroidJavaObject report)
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldProcessErrorReportHandler == null)
            {
                    return true;
            }
            
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldProcessErrorReportHandler.Invoke(errorReport:  JavaObjectsConverter.ConvertErrorReport(errorReport:  report));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool shouldAwaitUserConfirmation()
        {
            null = null;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldAwaitUserConfirmationHandler == null)
            {
                    return (bool)Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldAwaitUserConfirmationHandler;
            }
            
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldAwaitUserConfirmationHandler.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject AttachmentWithText(string text, string fileName)
        {
            null = null;
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(text != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(text == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = text;
            val_1[1] = fileName;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog != null)
            {
                    return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "attachmentWithText", args:  val_1);
            }
            
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "attachmentWithText", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject AttachmentWithBinary(byte[] text, string fileName, string contentType)
        {
            null = null;
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(text != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(text == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = text;
            val_1[1] = fileName;
            val_1[2] = contentType;
            if(Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog != null)
            {
                    return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "attachmentWithBinary", args:  val_1);
            }
            
            return Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "attachmentWithBinary", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject getErrorAttachments(UnityEngine.AndroidJavaObject report)
        {
            UnityEngine.AndroidJavaObject val_15;
            System.Object[] val_16;
            var val_17;
            Crashes.GetErrorAttachmentsHandler val_18;
            var val_19;
            System.Byte[] val_20;
            string val_21;
            string val_23;
            val_15 = report;
            val_16 = 1152921505335599104;
            val_17 = null;
            val_17 = null;
            val_18 = Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.GetErrorAttachments;
            if(val_18 == null)
            {
                    return (UnityEngine.AndroidJavaObject)val_18;
            }
            
            System.Collections.Generic.List<UnityEngine.AndroidJavaObject> val_3 = null;
            val_15 = val_3;
            val_3 = new System.Collections.Generic.List<UnityEngine.AndroidJavaObject>();
            val_19 = 0;
            goto label_6;
            label_16:
            if((val_18.Invoke(errorReport:  JavaObjectsConverter.ConvertErrorReport(errorReport:  val_15))[0]) == null)
            {
                goto label_8;
            }
            
            if((val_2[0x0][0].<Type>k__BackingField) == 0)
            {
                goto label_9;
            }
            
            val_20 = val_2[0x0][0].<Data>k__BackingField;
            val_21 = val_2[0x0][0].<FileName>k__BackingField;
            goto label_10;
            label_8:
            if(0 == 0)
            {
                goto label_11;
            }
            
            val_20 = 15026800;
            val_21 = 64;
            label_10:
            UnityEngine.AndroidJavaObject val_4 = this.AttachmentWithBinary(text:  val_20, fileName:  val_21, contentType:  val_2[0x0][0].<ContentType>k__BackingField);
            goto label_12;
            label_9:
            val_23 = val_2[0x0][0].<Text>k__BackingField;
            goto label_13;
            label_11:
            val_23 = 11993091;
            label_13:
            label_12:
            val_3.Add(item:  this.AttachmentWithText(text:  val_23, fileName:  val_2[0x0][0].<FileName>k__BackingField));
            val_19 = 1;
            label_6:
            if(val_19 < val_2.Length)
            {
                goto label_16;
            }
            
            val_16 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_7 = null;
            val_18 = val_7;
            val_7 = new UnityEngine.AndroidJavaObject(className:  "java.util.LinkedList", args:  val_16);
            if(val_3.Count >= 1)
            {
                    object[] val_9 = new object[1];
                val_16 = val_9;
                val_16[0] = val_3.Item[0];
                val_7.Call(methodName:  "addLast", args:  val_9);
            }
            
            if(val_3.Count < 2)
            {
                    return (UnityEngine.AndroidJavaObject)val_18;
            }
            
            object[] val_12 = new object[1];
            val_16 = val_12;
            val_15 = val_3.Item[1];
            val_16[0] = val_15;
            val_7.Call(methodName:  "addLast", args:  val_12);
            return (UnityEngine.AndroidJavaObject)val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetShouldAwaitUserConfirmationHandler(Microsoft.AppCenter.Unity.Crashes.Crashes.UserConfirmationHandler handler)
        {
            null = null;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldAwaitUserConfirmationHandler = handler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetShouldProcessErrorReportHandler(Microsoft.AppCenter.Unity.Crashes.Crashes.ShouldProcessErrorReportHandler handler)
        {
            null = null;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldProcessErrorReportHandler = handler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetGetErrorAttachmentsHandler(Microsoft.AppCenter.Unity.Crashes.Crashes.GetErrorAttachmentsHandler handler)
        {
            null = null;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.GetErrorAttachments = handler;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static CrashesDelegate()
        {
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldAwaitUserConfirmationHandler = 0;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.shouldProcessErrorReportHandler = 0;
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate._errorAttachmentLog = new UnityEngine.AndroidJavaClass(className:  "com.microsoft.appcenter.crashes.ingestion.models.ErrorAttachmentLog");
            Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate.instance = new Microsoft.AppCenter.Unity.Crashes.Internal.CrashesDelegate();
        }
    
    }

}
