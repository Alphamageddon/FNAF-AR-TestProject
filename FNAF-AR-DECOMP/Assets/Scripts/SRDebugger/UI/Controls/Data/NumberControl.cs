using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NumberControl : DataBoundControl
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Type[] IntegerTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Type[] DecimalTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly System.Collections.Generic.Dictionary<System.Type, SRDebugger.UI.Controls.Data.NumberControl.ValueRange> ValueRanges;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _lastValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Type _type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject[] DisableOnReadOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRNumberButton DownNumberButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRNumberSpinner NumberSpinner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRNumberButton UpNumberButton;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921522975860400] = 1;
            this.NumberSpinner.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void SRDebugger.UI.Controls.Data.NumberControl::OnValueChanged(string newValue)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnValueChanged(string newValue)
        {
            this.UpdateValue(newValue:  System.Convert.ChangeType(value:  newValue, conversionType:  this._type));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnBind(string propertyName, System.Type t)
        {
            SRF.UI.SRNumberSpinner val_15;
            ContentType val_16;
            double val_17;
            double val_18;
            var val_19;
            if((SRDebugger.UI.Controls.Data.NumberControl.IsIntegerType(t:  t)) == false)
            {
                goto label_4;
            }
            
            val_15 = this.NumberSpinner;
            val_16 = 2;
            goto label_6;
            label_4:
            if((SRDebugger.UI.Controls.Data.NumberControl.IsDecimalType(t:  t)) == false)
            {
                goto label_9;
            }
            
            val_15 = this.NumberSpinner;
            val_16 = 3;
            label_6:
            val_15.contentType = val_16;
            SROptions.NumberRangeAttribute val_3 = val_15.GetAttribute<SROptions.NumberRangeAttribute>();
            this.NumberSpinner.MaxValue = val_3.GetMaxValue(t:  t);
            val_17 = this.GetMinValue(t:  t);
            this.NumberSpinner.MinValue = val_17;
            if(val_3 != null)
            {
                    this.NumberSpinner.MaxValue = System.Math.Min(val1:  val_3.Max, val2:  this.NumberSpinner.MaxValue);
                if(this.NumberSpinner != null)
            {
                    val_18 = this.NumberSpinner.MinValue;
                val_17 = System.Math.Max(val1:  val_3.Min, val2:  this.NumberSpinner.MinValue);
            }
            else
            {
                    val_18 = this.NumberSpinner.MinValue;
                val_17 = System.Math.Max(val1:  val_3.Min, val2:  this.NumberSpinner.MinValue);
            }
            
                mem2[0] = val_17;
            }
            
            if((val_18.GetAttribute<SROptions.IncrementAttribute>()) != null)
            {
                    val_19 = 1152921504851574784;
                if(this.UpNumberButton != 0)
            {
                    this.UpNumberButton.Amount = val_9.Increment;
            }
            
                if(this.DownNumberButton != 0)
            {
                    val_17 = val_9.Increment;
                this.DownNumberButton.Amount = -val_17;
            }
            
            }
            
            this._type = t;
            this.NumberSpinner.interactable = (this.DownNumberButton == 0) ? 1 : 0;
            if(this.DisableOnReadOnly == null)
            {
                    return;
            }
            
            if(this.DisableOnReadOnly.Length < 1)
            {
                    return;
            }
            
            do
            {
                this.DisableOnReadOnly[0].SetActive(value:  (val_19 == 0) ? 1 : 0);
            }
            while((0 + 1) < this.DisableOnReadOnly.Length);
            
            return;
            label_9:
            System.ArgumentException val_15 = new System.ArgumentException(message:  "Type must be one of expected types", paramName:  "t");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnValueUpdated(object newValue)
        {
            decimal val_1 = System.Convert.ToDecimal(value:  newValue);
            string val_2 = val_1.flags.ToString();
            if((System.String.op_Inequality(a:  val_2, b:  this._lastValue)) != false)
            {
                    this.NumberSpinner.text = val_2;
            }
            
            this._lastValue = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            if((SRDebugger.UI.Controls.Data.NumberControl.IsDecimalType(t:  type)) == false)
            {
                    return SRDebugger.UI.Controls.Data.NumberControl.IsIntegerType(t:  type);
            }
            
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static bool IsIntegerType(System.Type t)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = 0;
            label_11:
            val_3 = null;
            val_3 = null;
            if(val_2 >= SRDebugger.UI.Controls.Data.NumberControl.IntegerTypes.Length)
            {
                goto label_4;
            }
            
            val_4 = null;
            val_4 = null;
            val_2 = val_2 + 1;
            if((System.Type.op_Equality(left:  SRDebugger.UI.Controls.Data.NumberControl.IntegerTypes.Length + 32, right:  t)) == false)
            {
                goto label_11;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_4:
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static bool IsDecimalType(System.Type t)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = 0;
            label_11:
            val_3 = null;
            val_3 = null;
            if(val_2 >= SRDebugger.UI.Controls.Data.NumberControl.DecimalTypes.Length)
            {
                goto label_4;
            }
            
            val_4 = null;
            val_4 = null;
            val_2 = val_2 + 1;
            if((System.Type.op_Equality(left:  SRDebugger.UI.Controls.Data.NumberControl.DecimalTypes.Length + 32, right:  t)) == false)
            {
                goto label_11;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_4:
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected double GetMaxValue(System.Type t)
        {
            System.Type val_4;
            var val_5;
            val_4 = t;
            val_5 = null;
            val_5 = null;
            if((SRDebugger.UI.Controls.Data.NumberControl.ValueRanges.TryGetValue(key:  val_4, value: out  new ValueRange())) != false)
            {
                    return 1.79769313486232E+308;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = val_4;
            val_4 = SRF.SRFStringExtensions.Fmt(formatString:  "[NumberControl] No MaxValue stored for type {0}", args:  val_2);
            UnityEngine.Debug.LogWarning(message:  val_4);
            return 1.79769313486232E+308;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected double GetMinValue(System.Type t)
        {
            System.Type val_4;
            var val_5;
            val_4 = t;
            val_5 = null;
            val_5 = null;
            if((SRDebugger.UI.Controls.Data.NumberControl.ValueRanges.TryGetValue(key:  val_4, value: out  new ValueRange())) != false)
            {
                    return -1.79769313486232E+308;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = val_4;
            val_4 = SRF.SRFStringExtensions.Fmt(formatString:  "[NumberControl] No MinValue stored for type {0}", args:  val_2);
            UnityEngine.Debug.LogWarning(message:  val_4);
            return -1.79769313486232E+308;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NumberControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static NumberControl()
        {
            System.Type[] val_1 = new System.Type[6];
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_1[0] = val_2;
            val_1[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[2] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[3] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[4] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_1[5] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            SRDebugger.UI.Controls.Data.NumberControl.IntegerTypes = val_1;
            System.Type[] val_8 = new System.Type[2];
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_8 == null)
            {
                goto label_24;
            }
            
            if(val_9 != null)
            {
                goto label_25;
            }
            
            goto label_28;
            label_24:
            if(val_9 == null)
            {
                goto label_28;
            }
            
            label_25:
            label_28:
            val_8[0] = val_9;
            val_8[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            SRDebugger.UI.Controls.Data.NumberControl.DecimalTypes = val_8;
            System.Collections.Generic.Dictionary<System.Type, ValueRange> val_11 = new System.Collections.Generic.Dictionary<System.Type, ValueRange>();
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 2147483647, MinValue = -2147483648});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 32767, MinValue = -32768});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 255});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 127, MinValue = -128});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 4294967295});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 65535});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 3.40282346638529E+38, MinValue = -3.40282346638529E+38});
            val_11.Add(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  new ValueRange() {MaxValue = 1.79769313486232E+308, MinValue = -1.79769313486232E+308});
            SRDebugger.UI.Controls.Data.NumberControl.ValueRanges = val_11;
        }
    
    }

}
