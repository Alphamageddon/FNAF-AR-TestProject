using UnityEngine;

namespace PaperPlaneTools
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertAndroid
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, PaperPlaneTools.AlertButton> buttons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action OnDismiss;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Message>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Cancelable>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Message { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Cancelable { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertAndroid(string title, string message)
        {
            this.buttons = new System.Collections.Generic.Dictionary<System.Int32, PaperPlaneTools.AlertButton>();
            val_2 = new System.Object();
            this.<Title>k__BackingField = title;
            this.<Message>k__BackingField = val_2;
            this.<Cancelable>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPositiveButton(string title, System.Action handler)
        {
            this.SetButton(whichButton:  0, title:  title, handler:  handler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetNegativeButton(string title, System.Action handler)
        {
            this.SetButton(whichButton:  -2, title:  title, handler:  handler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetNeutralButton(string title, System.Action handler)
        {
            this.SetButton(whichButton:  -3, title:  title, handler:  handler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetButton(PaperPlaneTools.AlertAndroid.ButtonType whichButton, string title, System.Action handler)
        {
            this.buttons.set_Item(key:  whichButton, value:  new PaperPlaneTools.AlertButton(title:  title, handler:  handler));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Title()
        {
            return (string)this.<Title>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Cancelable()
        {
            return (bool)this.<Cancelable>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Cancelable(bool value)
        {
            this.<Cancelable>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Show(string gameObjectName)
        {
            UnityEngine.XR.ARCore.ARCoreFaceRegion val_11;
            var val_23;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.paperplanetools.Alert");
            object[] val_2 = new object[1];
            val_2[0] = gameObjectName;
            int val_3 = val_1.CallStatic<System.Int32>(methodName:  "initBuilder", args:  val_2);
            if((this.<Title>k__BackingField) != null)
            {
                    object[] val_4 = new object[1];
                val_4[0] = this.<Title>k__BackingField;
                int val_5 = val_1.CallStatic<System.Int32>(methodName:  "setTitle", args:  val_4);
            }
            
            if((this.<Message>k__BackingField) != null)
            {
                    object[] val_6 = new object[1];
                val_6[0] = this.<Message>k__BackingField;
                int val_7 = val_1.CallStatic<System.Int32>(methodName:  "setMessage", args:  val_6);
            }
            
            Dictionary.Enumerator<TKey, TValue> val_8 = this.buttons.GetEnumerator();
            label_29:
            if((2004944240 & 1) == 0)
            {
                goto label_19;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_12 = val_11.trackableId;
            object[] val_13 = new object[2];
            val_11 = val_12.m_SubId1.region;
            val_13[0] = val_11;
            val_13[1] = val_12.m_SubId1.Title;
            int val_16 = val_1.CallStatic<System.Int32>(methodName:  "setButton", args:  val_13);
            goto label_29;
            label_19:
            long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519496693104});
            val_23 = 1152921519479829248;
            object[] val_19 = new object[1];
            val_11 = this.<Cancelable>k__BackingField;
            val_19[0] = val_11;
            int val_20 = val_1.CallStatic<System.Int32>(methodName:  "setCancelable", args:  val_19);
            int val_22 = val_1.CallStatic<System.Int32>(methodName:  "show", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Dismiss()
        {
            int val_3 = new UnityEngine.AndroidJavaClass(className:  "com.paperplanetools.Alert").CallStatic<System.Int32>(methodName:  "dismiss", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleButtonClick(int whichButton)
        {
            int val_5 = whichButton;
            PaperPlaneTools.AlertButton val_1 = 0;
            if((this.buttons.TryGetValue(key:  val_5 = whichButton, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_5 = val_1;
            if(val_5.Handler == null)
            {
                    return;
            }
            
            val_5 = val_1.Handler;
            val_5.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleCancel()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleDismiss()
        {
            if(this.OnDismiss == null)
            {
                    return;
            }
            
            this.OnDismiss.Invoke();
        }
    
    }

}
