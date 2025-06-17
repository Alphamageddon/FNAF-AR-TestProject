using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ProfilerTabController : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDirty;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle PinToggle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.PinToggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void SRDebugger.UI.Tabs.ProfilerTabController::PinToggleValueChanged(bool isOn)));
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PinToggleValueChanged(bool isOn)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            SRDebug.Instance.IsProfilerDocked = isOn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnEnable()
        {
            this.OnEnable();
            this._isDirty = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            this.Update();
            if(this._isDirty == false)
            {
                    return;
            }
            
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.PinToggle.isOn = SRDebug.Instance.IsProfilerDocked;
            this._isDirty = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProfilerTabController()
        {
        
        }
    
    }

}
