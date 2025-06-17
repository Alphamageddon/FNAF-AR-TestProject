using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatteryColorHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BatteryColorHandlerData _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float EPSILON = 0.05;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryColorHandler(GameUI.BatteryColorHandlerData batteryColorHandlerData)
        {
            this._data = batteryColorHandlerData;
            batteryColorHandlerData.batteryColorToValues.Sort(comparison:  new System.Comparison<GameUI.BatteryColorToValue>(object:  this, method:  System.Int32 GameUI.BatteryColorHandler::SortByValueLowToHigh(GameUI.BatteryColorToValue p1, GameUI.BatteryColorToValue p2)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.UpdateBatteryColor(blinkState:  this._data.surgeMechanicUIHandler.BlinkState);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBatteryColor(bool blinkState)
        {
            GameUI.BatteryColorHandlerData val_3;
            UnityEngine.Color val_4;
            var val_5;
            var val_6;
            var val_7;
            GameUI.BatteryColorHandlerData val_8;
            UnityEngine.Color val_9;
            var val_10;
            var val_11;
            var val_12;
            val_3 = this;
            UnityEngine.Color val_1 = this.GetBlendedFillColor();
            val_4 = val_1.r;
            val_5 = val_1.g;
            val_6 = val_1.b;
            val_7 = val_1.a;
            if(blinkState != false)
            {
                    val_8 = this._data;
                if(this._data == null)
            {
                    val_8 = this._data;
            }
            
                val_4 = this._data.batterySurgeColor;
                val_9 = this._data.batterySurgeColor;
            }
            else
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.white;
                val_9 = val_2.r;
                val_10 = val_2.g;
                val_11 = val_2.b;
                val_12 = val_2.a;
                val_3 = this._data;
            }
            
            if((mem[this._data] + 48) == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color GetBlendedFillColor()
        {
            float val_3;
            var val_14;
            var val_15;
            UnityEngine.UI.Slider val_16;
            float val_17;
            Master.MasterDomain val_18;
            float val_19;
            GameUI.ServerGameUIDataModel val_20;
            float val_21;
            float val_26;
            val_14 = this;
            List.Enumerator<T> val_1 = this._data.batteryColorToValues.GetEnumerator();
            float val_15 = val_3;
            label_14:
            if(((-1262752240) & 1) == 0)
            {
                goto label_5;
            }
            
            val_15 = val_15.emailUIDataHandler;
            val_16 = this._data.batterySlider;
            val_15 = val_4._emailDatas - val_15;
            val_17 = System.Math.Abs(val_15);
            if(val_17 < 0)
            {
                goto label_11;
            }
            
            val_16 = this._data.batterySlider;
            if(val_4._emailDatas < 0)
            {
                goto label_14;
            }
            
            goto label_15;
            label_5:
            val_15 = 0;
            label_15:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524818931216});
            goto label_16;
            label_11:
            val_18 = val_4._masterDomain;
            val_20 = val_4._serverGameUIDataModel;
            return new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21};
            label_16:
            if(( | 0) != 0)
            {
                goto label_26;
            }
            
            UnityEngine.Color val_9 = UnityEngine.Color.clear;
            goto label_27;
            label_26:
            if(0 == 0)
            {
                goto label_28;
            }
            
            if( == 0)
            {
                goto label_29;
            }
            
            val_26 = 8.96831E-44f;
            val_26 = 8.96831E-44f;
            val_26 = 8.96831E-44f;
            val_18 = (System.Math.Abs(val_18 - val_26)) / (System.Math.Abs((8.96831E-44f) - (8.96831E-44f)));
            float val_18 = 1f;
            val_18 = val_18 - val_18;
            UnityEngine.Color val_12 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 1.68059E-38f, g = 1.401298E-45f, b = 2.105703E-38f, a = 0f}, b:  val_18);
            UnityEngine.Color val_13 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = 1.68059E-38f, g = 1.401298E-45f, b = 2.105703E-38f, a = 0f}, b:  val_18);
            val_17 = val_12.r;
            UnityEngine.Color val_14 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = val_17, g = val_12.g, b = val_12.b, a = val_12.a}, b:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a});
            label_27:
            val_18 = val_14.r;
            val_19 = val_14.g;
            val_20 = val_14.b;
            val_21 = val_14.a;
            return new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21};
            label_28:
            val_18 = 1.68059E-38f;
            val_19 = 1.401298E-45f;
            val_20 = 2.105703E-38f;
            val_21 = 0f;
            return new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21};
            label_29:
            val_18 = 1.68059E-38f;
            val_19 = 1.401298E-45f;
            val_20 = 2.105703E-38f;
            val_21 = 0f;
            return new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int SortByValueLowToHigh(GameUI.BatteryColorToValue p1, GameUI.BatteryColorToValue p2)
        {
        
        }
    
    }

}
