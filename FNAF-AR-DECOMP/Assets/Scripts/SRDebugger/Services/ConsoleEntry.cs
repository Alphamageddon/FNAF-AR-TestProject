using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConsoleEntry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int MessagePreviewLength = 180;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int StackTracePreviewLength = 120;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _messagePreview;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _stackTracePreview;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.LogType LogType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StackTrace;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MessagePreview { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string StackTracePreview { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleEntry()
        {
            this.Count = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleEntry(SRDebugger.Services.ConsoleEntry other)
        {
            this.Count = 1;
            if(other != null)
            {
                    this.Message = other.Message;
                this.StackTrace = other.StackTrace;
                this.LogType = other.LogType;
            }
            else
            {
                    this.Message = 69077560;
                this.StackTrace = 0;
                this.LogType = 0;
            }
            
            this.Count = other.Count;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MessagePreview()
        {
            string val_7 = this._messagePreview;
            if(val_7 != null)
            {
                    return val_6;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.Message)) != false)
            {
                    val_7 = "";
                return val_6;
            }
            
            char[] val_2 = new char[1];
            val_2[0] = '
            ';
            string val_7 = this.Message.Split(separator:  val_2)[0];
            this._messagePreview = val_7;
            string val_6 = val_7.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  val_7.Length, b:  180));
            this._messagePreview = val_6;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_StackTracePreview()
        {
            string val_7 = this._stackTracePreview;
            if(val_7 != null)
            {
                    return val_6;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.StackTrace)) != false)
            {
                    val_7 = "";
                return val_6;
            }
            
            char[] val_2 = new char[1];
            val_2[0] = '
            ';
            string val_7 = this.StackTrace.Split(separator:  val_2)[0];
            this._stackTracePreview = val_7;
            string val_6 = val_7.Substring(startIndex:  0, length:  UnityEngine.Mathf.Min(a:  val_7.Length, b:  120));
            this._stackTracePreview = val_6;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Matches(SRDebugger.Services.ConsoleEntry other)
        {
            var val_4;
            if(other == null)
            {
                goto label_3;
            }
            
            if(this == other)
            {
                goto label_1;
            }
            
            if((System.String.Equals(a:  this.Message, b:  other.Message)) != false)
            {
                    if((System.String.Equals(a:  this.StackTrace, b:  other.StackTrace)) != false)
            {
                    var val_3 = (this.LogType == other.LogType) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
            label_3:
            val_4 = 0;
            return (bool)val_4;
            label_1:
            val_4 = 1;
            return (bool)val_4;
        }
    
    }

}
