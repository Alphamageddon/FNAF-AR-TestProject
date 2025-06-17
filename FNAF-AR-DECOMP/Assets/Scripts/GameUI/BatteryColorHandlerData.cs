using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatteryColorHandlerData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SurgeMechanicUIHandler surgeMechanicUIHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Slider batterySlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Image batteryColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Image batteryBG;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI batteryText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.BatteryColorToValue> batteryColorToValues;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color batterySurgeColor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float batterySurgeBlinkDuration;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryColorHandlerData(GameUI.SurgeMechanicUIHandler surgeMechanicUIHandler, UnityEngine.UI.Slider batterySlider, UnityEngine.UI.Image batteryColor, UnityEngine.UI.Image batteryBG, TMPro.TextMeshProUGUI batteryText, System.Collections.Generic.List<GameUI.BatteryColorToValue> batteryColorToValues, UnityEngine.Color batterySurgeColor)
        {
            val_1 = new System.Object();
            this.surgeMechanicUIHandler = surgeMechanicUIHandler;
            this.batterySlider = batterySlider;
            this.batteryColor = batteryColor;
            this.batteryBG = batteryBG;
            this.batteryText = batteryText;
            this.batteryColorToValues = val_1;
            this.batterySurgeColor = batterySurgeColor;
            mem[1152921524772622164] = batterySurgeColor.g;
            mem[1152921524772622168] = batterySurgeColor.b;
            mem[1152921524772622172] = batterySurgeColor.a;
        }
    
    }

}
