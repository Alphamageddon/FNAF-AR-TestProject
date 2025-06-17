using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BugReportSheetController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject ButtonContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button CancelButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action CancelPressed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.InputField DescriptionField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.InputField EmailField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Slider ProgressBar;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text ResultMessageText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action ScreenshotComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button SubmitButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<bool, string> SubmitComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action TakingScreenshot;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsCancelButtonEnabled { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsCancelButtonEnabled()
        {
            UnityEngine.GameObject val_1 = this.CancelButton.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsCancelButtonEnabled(bool value)
        {
            this.CancelButton.gameObject.SetActive(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.SetLoadingSpinnerVisible(visible:  false);
            this.ClearErrorMessage();
            this.ClearForm();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Submit()
        {
            UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(selected:  0);
            this.ClearErrorMessage();
            this.SetLoadingSpinnerVisible(visible:  true);
            this.SetFormEnabled(e:  false);
            if((System.String.IsNullOrEmpty(value:  this.EmailField.text)) != true)
            {
                    string val_4 = this.EmailField.text;
                val_4.SetDefaultEmailFieldContents(value:  val_4);
            }
            
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.SubmitCo());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Cancel()
        {
            if(this.CancelPressed == null)
            {
                    return;
            }
            
            this.CancelPressed.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator SubmitCo()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new BugReportSheetController.<SubmitCo>d__18();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnBugReportProgress(float progress)
        {
            if(this.ProgressBar == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnBugReportComplete(bool didSucceed, string errorMessage)
        {
            string val_2;
            string val_3;
            if(didSucceed != false)
            {
                    this.ClearForm();
                val_2 = "Bug report submitted successfully";
                val_3 = 0;
            }
            else
            {
                    val_2 = "Error sending bug report";
                val_3 = errorMessage;
            }
            
            this.ShowErrorMessage(userMessage:  val_2, serverMessage:  val_3);
            this.SetLoadingSpinnerVisible(visible:  false);
            this.SetFormEnabled(e:  true);
            if(this.SubmitComplete == null)
            {
                    return;
            }
            
            this.SubmitComplete.Invoke(arg1:  didSucceed, arg2:  errorMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetLoadingSpinnerVisible(bool visible)
        {
            this.ProgressBar.gameObject.SetActive(value:  visible);
            this.ButtonContainer.SetActive(value:  (~visible) & 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ClearForm()
        {
            this.EmailField.text = this.GetDefaultEmailFieldContents();
            this.DescriptionField.text = "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ShowErrorMessage(string userMessage, string serverMessage)
        {
            string val_6 = userMessage;
            if((System.String.IsNullOrEmpty(value:  serverMessage)) != true)
            {
                    object[] val_2 = new object[1];
                val_2[0] = serverMessage;
                val_6 = val_6 + SRF.SRFStringExtensions.Fmt(formatString:  " (<b>{0}</b>)", args:  val_2)(SRF.SRFStringExtensions.Fmt(formatString:  " (<b>{0}</b>)", args:  val_2));
            }
            
            this.ResultMessageText.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ClearErrorMessage()
        {
            this.ResultMessageText.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetFormEnabled(bool e)
        {
            bool val_1 = e;
            this.SubmitButton.interactable = val_1;
            this.CancelButton.interactable = val_1;
            bool val_2 = e;
            this.EmailField.interactable = val_2;
            this.DescriptionField.interactable = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string GetDefaultEmailFieldContents()
        {
            return UnityEngine.PlayerPrefs.GetString(key:  "SRDEBUGGER_BUG_REPORT_LAST_EMAIL", defaultValue:  "");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetDefaultEmailFieldContents(string value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  "SRDEBUGGER_BUG_REPORT_LAST_EMAIL", value:  value);
            UnityEngine.PlayerPrefs.Save();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BugReportSheetController()
        {
        
        }
    
    }

}
