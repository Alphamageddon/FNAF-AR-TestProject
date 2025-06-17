using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PinEntryControl : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isVisible;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<int> _numbers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Image Background;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanCancel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button CancelButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text CancelButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.CanvasGroup CanvasGroup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Animator DotAnimator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button[] NumberButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Toggle[] NumberDots;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text PromptText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Controls.PinEntryControlCallback Complete;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.Complete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Complete != 1152921522964365920);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.Complete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Complete != 1152921522964502496);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            int val_6;
            this.Awake();
            val_6 = 0;
            goto label_1;
            label_9:
            PinEntryControl.<>c__DisplayClass14_0 val_1 = new PinEntryControl.<>c__DisplayClass14_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            .number = val_6;
            this.NumberButtons[0].onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void PinEntryControl.<>c__DisplayClass14_0::<Awake>b__0()));
            val_6 = 1;
            label_1:
            if(val_6 < this.NumberButtons.Length)
            {
                goto label_9;
            }
            
            this.CancelButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SRDebugger.UI.Controls.PinEntryControl::CancelButtonPressed()));
            this.RefreshState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Update()
        {
            var val_9;
            this.Update();
            if(this._isVisible == false)
            {
                    return;
            }
            
            if(this._numbers.Count >= 1)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  8)) != true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  127)) == false)
            {
                goto label_5;
            }
            
            }
            
                int val_4 = SRF.SRFIListExtensions.PopLast<System.Int32>(list:  this._numbers);
                this.RefreshState();
            }
            
            label_5:
            string val_5 = UnityEngine.Input.inputString;
            val_9 = 0;
            goto label_6;
            label_14:
            if((System.Char.IsNumber(s:  val_5, index:  0)) != false)
            {
                    if(((int)System.Char.GetNumericValue(s:  val_5, index:  0)) <= (4.44659081257122E-323))
            {
                    this.PushNumber(number:  (int)System.Char.GetNumericValue(s:  val_5, index:  0));
            }
            
            }
            
            val_9 = 1;
            label_6:
            if(val_9 < val_5.Length)
            {
                goto label_14;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Show()
        {
            this.CanvasGroup.alpha = 1f;
            if(this.CanvasGroup != null)
            {
                    this.CanvasGroup.interactable = true;
            }
            else
            {
                    0.interactable = true;
            }
            
            this.CanvasGroup.blocksRaycasts = true;
            this._isVisible = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Hide()
        {
            this.CanvasGroup.alpha = 0f;
            if(this.CanvasGroup != null)
            {
                    this.CanvasGroup.interactable = false;
            }
            else
            {
                    0.interactable = false;
            }
            
            this.CanvasGroup.blocksRaycasts = false;
            this._isVisible = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Clear()
        {
            this._numbers.Clear();
            this.RefreshState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PlayInvalidCodeAnimation()
        {
            this.DotAnimator.SetTrigger(name:  "Invalid");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnComplete()
        {
            if(this.Complete == null)
            {
                    return;
            }
            
            this.Complete.Invoke(result:  new System.Collections.ObjectModel.ReadOnlyCollection<System.Int32>(list:  this._numbers), didCancel:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void OnCancel()
        {
            if(this.Complete == null)
            {
                    return;
            }
            
            this.Complete.Invoke(result:  new int[0], didCancel:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CancelButtonPressed()
        {
            if(this._numbers.Count >= 1)
            {
                    int val_2 = SRF.SRFIListExtensions.PopLast<System.Int32>(list:  this._numbers);
            }
            else
            {
                    this.OnCancel();
            }
            
            this.RefreshState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PushNumber(int number)
        {
            if(this._numbers.Count >= 4)
            {
                    UnityEngine.Debug.LogWarning(message:  "[PinEntry] Expected 4 numbers");
                return;
            }
            
            this._numbers.Add(item:  number);
            if(this._numbers.Count >= 4)
            {
                    this.OnComplete();
            }
            
            this.RefreshState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshState()
        {
            var val_5;
            var val_6;
            val_5 = this;
            val_6 = 0;
            goto label_1;
            label_7:
            this.NumberDots[0].isOn = (val_6 < this._numbers.Count) ? 1 : 0;
            val_6 = 1;
            label_1:
            if(val_6 < this.NumberDots.Length)
            {
                goto label_7;
            }
            
            if(this._numbers.Count >= 1)
            {
                    if(this.CancelButtonText != null)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_5B8;
            }
            
            }
            else
            {
                    val_5 = mem[this.CanCancel == true ? "Cancel" : ""];
                val_5 = (this.CanCancel == true) ? "Cancel" : "";
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PinEntryControl()
        {
            this._isVisible = true;
            this._numbers = new System.Collections.Generic.List<System.Int32>(capacity:  4);
            this.CanCancel = true;
        }
    
    }

}
