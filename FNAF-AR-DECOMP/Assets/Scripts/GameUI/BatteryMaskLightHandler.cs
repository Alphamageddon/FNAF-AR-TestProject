using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatteryMaskLightHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.BatteryMaskLightHandlerData _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SurgeLightController _surgeLightController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _surgeLightStrength;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SurgeLightController SurgeLightController { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatteryMaskLightHandler(GameUI.BatteryMaskLightHandlerData batteryMaskLightHandlerData)
        {
            this._data = batteryMaskLightHandlerData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            float val_7;
            float val_1 = this._data.surgeMechanicUIHandler.BatterySurgeMaskLightFadeTime;
            float val_3 = UnityEngine.Time.deltaTime;
            if(this._data.surgeMechanicUIHandler.BlinkState != false)
            {
                    val_3 = val_3 / val_1;
                val_7 = this._surgeLightStrength + val_3;
                float val_4 = UnityEngine.Mathf.Min(a:  val_7, b:  1f);
            }
            else
            {
                    val_3 = val_3 / val_1;
                val_7 = this._surgeLightStrength - val_3;
            }
            
            this._surgeLightStrength = UnityEngine.Mathf.Max(a:  val_7, b:  0f);
            SurgeLightController val_6 = this.SurgeLightController;
            if(val_6 == null)
            {
                    return;
            }
            
            val_6.SetSurgeLightStrength(value:  this._surgeLightStrength);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SurgeLightController get_SurgeLightController()
        {
            SurgeLightController val_3;
            if(this._surgeLightController == 0)
            {
                    this._surgeLightController = UnityEngine.Object.FindObjectOfType<SurgeLightController>();
                return val_3;
            }
            
            val_3 = this._surgeLightController;
            return val_3;
        }
    
    }

}
