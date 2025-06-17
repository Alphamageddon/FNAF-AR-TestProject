using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BugReportApi
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _apiKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SRDebugger.Services.BugReport _bugReport;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isBusy;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.WWW _www;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsComplete>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <WasSuccessful>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ErrorMessage>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsComplete { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WasSuccessful { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ErrorMessage { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Progress { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BugReportApi(SRDebugger.Services.BugReport report, string apiKey)
        {
            val_1 = new System.Object();
            this._apiKey = val_1;
            this._bugReport = report;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsComplete()
        {
            return (bool)this.<IsComplete>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsComplete(bool value)
        {
            this.<IsComplete>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_WasSuccessful()
        {
            return (bool)this.<WasSuccessful>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_WasSuccessful(bool value)
        {
            this.<WasSuccessful>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ErrorMessage()
        {
            return (string)this.<ErrorMessage>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ErrorMessage(string value)
        {
            this.<ErrorMessage>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Progress()
        {
            if(this._www == null)
            {
                    return 0f;
            }
            
            float val_2 = this._www.uploadProgress;
            val_2 = this._www.progress + val_2;
            return UnityEngine.Mathf.Clamp01(value:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerator Submit()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new BugReportApi.<Submit>d__19();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCompletionState(bool wasSuccessful)
        {
            bool val_1 = wasSuccessful;
            this._bugReport.ScreenshotData = 0;
            this.<WasSuccessful>k__BackingField = val_1;
            this.<IsComplete>k__BackingField = true;
            this._isBusy = false;
            if(val_1 != false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "Bug Reporter Error: "("Bug Reporter Error: ") + this.<ErrorMessage>k__BackingField(this.<ErrorMessage>k__BackingField));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string BuildJsonRequest(SRDebugger.Services.BugReport report)
        {
            System.Collections.Generic.IList<System.Collections.Generic.IList<System.String>> val_2 = SRDebugger.Internal.BugReportApi.CreateConsoleDump();
            if(report.ScreenshotData == null)
            {
                    return SRF.Json.Serialize(obj:  new System.Collections.Hashtable());
            }
            
            string val_3 = System.Convert.ToBase64String(inArray:  report.ScreenshotData);
            return SRF.Json.Serialize(obj:  new System.Collections.Hashtable());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.IList<System.Collections.Generic.IList<string>> CreateConsoleDump()
        {
            var val_17;
            var val_18;
            var val_19;
            System.Collections.Generic.List<System.Collections.Generic.IList<System.String>> val_1 = new System.Collections.Generic.List<System.Collections.Generic.IList<System.String>>();
            var val_17 = 0;
            val_17 = val_17 + 1;
            var val_18 = 0;
            val_18 = val_18 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = SRDebugger.Internal.Service.Console.Entries.GetEnumerator();
            label_30:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
            T val_12 = val_6.Current + 36;
            mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_12});
            null.Add(item:  val_12.ToString());
            null.Add(item:  val_10 + 40);
            val_17 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            null.Add(item:  val_10 + 48);
            if((val_10 + 32) >= 2)
            {
                    val_17 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                null.Add(item:  val_10 + 32.ToString());
            }
            
            val_1.Add(item:  null);
            goto label_30;
            label_16:
            val_18 = 0;
            val_19 = 137;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_6.Dispose();
            }
            
            if( == 137)
            {
                    return (System.Collections.Generic.IList<System.Collections.Generic.IList<System.String>>)val_1;
            }
            
            if( == false)
            {
                    return (System.Collections.Generic.IList<System.Collections.Generic.IList<System.String>>)val_1;
            }
            
            return (System.Collections.Generic.IList<System.Collections.Generic.IList<System.String>>)val_1;
        }
    
    }

}
