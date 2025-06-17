using UnityEngine;

namespace Mapbox.Unity.Location
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TransformLocationProvider : AbstractEditorLocationProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _targetTransform;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_TargetTransform(UnityEngine.Transform value)
        {
            this._targetTransform = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void SetLocation()
        {
            double val_5;
            double val_6;
            UnityEngine.Vector3 val_1 = this._targetTransform.eulerAngles;
            mem[1152921519792202744] = val_1.y;
            if(null != 0)
            {
                
            }
            else
            {
                    val_5 = 3.0924050981274E-316;
                val_6 = 3.09564300674398E-316;
            }
            
            Mapbox.Utils.Vector2d val_2 = Mapbox.Unity.Utilities.VectorExtensions.GetGeoPosition(t:  this._targetTransform, refPoint:  new Mapbox.Utils.Vector2d() {x = val_5, y = val_6}, scale:  Mapbox.Unity.Map.AbstractMap.__il2cppRuntimeField_properties);
            mem[1152921519792202728] = val_2.x;
            mem[1152921519792202736] = val_2.y;
            mem[1152921519792202768] = 1.152922E+18f;
            System.DateTime val_3 = System.DateTime.UtcNow;
            mem[1152921519792202752] = Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime() {dateData = val_3.dateData});
            mem[1152921519792202774] = 1;
            mem[1152921519792202824] = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TransformLocationProvider()
        {
        
        }
    
    }

}
