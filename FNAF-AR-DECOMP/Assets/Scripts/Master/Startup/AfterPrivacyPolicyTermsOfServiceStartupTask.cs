using UnityEngine;

namespace Master.Startup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AfterPrivacyPolicyTermsOfServiceStartupTask : IStartupTask
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.Startup.AfterPrivacyPolicyTermsOfServiceStartupTask Setup(Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
            return (Master.Startup.AfterPrivacyPolicyTermsOfServiceStartupTask)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Execute(Master.Startup.StartupSequencer parent)
        {
            this._masterDomain._afterTOSAccept.SetActive(value:  true);
            parent.CompleteTask(task:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetSize()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetName()
        {
            return "After Privacy Policy and Terms of Service task";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GetPartialProgress()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AfterPrivacyPolicyTermsOfServiceStartupTask()
        {
        
        }
    
    }

}
