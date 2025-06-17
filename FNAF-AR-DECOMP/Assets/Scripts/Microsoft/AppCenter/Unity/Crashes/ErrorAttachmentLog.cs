using UnityEngine;

namespace Microsoft.AppCenter.Unity.Crashes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ErrorAttachmentLog
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Text>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private byte[] <Data>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <FileName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ContentType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog.AttachmentType <Type>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Text { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Data { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ContentType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog.AttachmentType Type { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Text()
        {
            return (string)this.<Text>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Text(string value)
        {
            this.<Text>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_Data()
        {
            return (System.Byte[])this.<Data>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Data(byte[] value)
        {
            this.<Data>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_FileName()
        {
            return (string)this.<FileName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_FileName(string value)
        {
            this.<FileName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ContentType()
        {
            return (string)this.<ContentType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ContentType(string value)
        {
            this.<ContentType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog.AttachmentType get_Type()
        {
            return (AttachmentType)this.<Type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Type(Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog.AttachmentType value)
        {
            this.<Type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog AttachmentWithText(string text, string fileName)
        {
            Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog val_1 = new Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog();
            if(val_1 != null)
            {
                    .<Text>k__BackingField = text;
                .<FileName>k__BackingField = fileName;
            }
            else
            {
                    mem[16] = text;
                mem[32] = fileName;
            }
            
            .<Type>k__BackingField = 0;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog AttachmentWithBinary(byte[] data, string fileName, string contentType)
        {
            Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog val_1 = new Microsoft.AppCenter.Unity.Crashes.ErrorAttachmentLog();
            if(val_1 != null)
            {
                    .<Data>k__BackingField = data;
                .<FileName>k__BackingField = fileName;
                .<ContentType>k__BackingField = contentType;
            }
            else
            {
                    mem[24] = data;
                mem[32] = fileName;
                mem[40] = contentType;
            }
            
            .<Type>k__BackingField = 1;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ErrorAttachmentLog()
        {
        
        }
    
    }

}
