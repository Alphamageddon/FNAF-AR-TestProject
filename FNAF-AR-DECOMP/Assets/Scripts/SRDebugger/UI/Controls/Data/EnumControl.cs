using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EnumControl : DataBoundControl
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private object _lastValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _names;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Array _values;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.LayoutElement ContentLayoutElement;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject[] DisableOnReadOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRSpinner Spinner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Value;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921522974344688] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnBind(string propertyName, System.Type t)
        {
            UnityEngine.UI.LayoutElement val_11;
            var val_12;
            var val_13;
            string val_14;
            System.String[] val_15;
            val_11 = this;
            this.Spinner.interactable = (this.Title == 0) ? 1 : 0;
            if((this.DisableOnReadOnly != null) && (this.DisableOnReadOnly.Length >= 1))
            {
                    do
            {
                val_12 = 0;
                this.DisableOnReadOnly[val_12].SetActive(value:  (W24 == 0) ? 1 : 0);
                var val_3 = val_12 + 1;
            }
            while(val_3 < this.DisableOnReadOnly.Length);
            
            }
            
            this._names = System.Enum.GetNames(enumType:  t);
            this._values = System.Enum.GetValues(enumType:  t);
            val_13 = 0;
            val_14 = "";
            goto label_10;
            label_19:
            if(this._names == null)
            {
                goto label_11;
            }
            
            val_15 = this._names;
            if(val_13 >= val_3)
            {
                goto label_12;
            }
            
            label_20:
            val_12 = 0;
            if(val_15[val_12].Length > Length)
            {
                    val_14 = this._names[val_12];
            }
            
            val_13 = 1;
            label_10:
            val_15 = this._names;
            if(val_15 == null)
            {
                goto label_19;
            }
            
            if(val_13 < this._names.Length)
            {
                goto label_20;
            }
            
            label_12:
            if(this._names.Length == 0)
            {
                    return;
            }
            
            val_15 = this.Value.cachedTextGeneratorForLayout;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  3.402823E+38f, y:  V0.16B);
            UnityEngine.TextGenerationSettings val_10 = this.Value.GetGenerationSettings(extents:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            float val_11 = val_15.GetPreferredWidth(str:  val_14, settings:  new UnityEngine.TextGenerationSettings() {color = new UnityEngine.Color(), richText = false, alignByGeometry = false, resizeTextForBestFit = false, updateBounds = false, generationExtents = new UnityEngine.Vector2(), pivot = new UnityEngine.Vector2(), generateOutOfBounds = false});
            val_11 = this.ContentLayoutElement;
            return;
            label_11:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnValueUpdated(object newValue)
        {
            this._lastValue = newValue;
            if(this.Value == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            if(type == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetIndex(int i)
        {
            this.UpdateValue(newValue:  this._values.GetValue(index:  i));
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToNext()
        {
            this.SetIndex(i:  SRMath.Wrap(max:  this._values.Length, value:  (System.Array.IndexOf(array:  this._values, value:  this._lastValue)) + 1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GoToPrevious()
        {
            this.SetIndex(i:  SRMath.Wrap(max:  this._values.Length, value:  (System.Array.IndexOf(array:  this._values, value:  this._lastValue)) - 1));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EnumControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
