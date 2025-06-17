using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Effects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CloakController
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnShockWindowOpened;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Animatronics.Animatronic3d.Model.Effects.CloakSettings _settings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _distance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 _direction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Effects.CloakGroup _bodyCloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Effects.CloakGroup _eyeCloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasOpenedShockWindow;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnShockWindowOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnShockWindowOpened, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnShockWindowOpened != 1152921525086218368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnShockWindowOpened(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnShockWindowOpened, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnShockWindowOpened != 1152921525086354944);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCloakState(bool cloakEnabled)
        {
            this._bodyCloak.BeginTime = -1f;
            this._bodyCloak.Percent = (cloakEnabled != true) ? 1f : 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginCloak()
        {
            this._bodyCloak.BeginTime = UnityEngine.Time.time;
            this._bodyCloak.IsCloaking = true;
            this._hasOpenedShockWindow = false;
            if(this._settings.ShouldUpdateEveryTime == false)
            {
                    return;
            }
            
            this.CalculateDirectionAndDistance();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginDecloak()
        {
            this._bodyCloak.BeginTime = UnityEngine.Time.time;
            this._bodyCloak.IsCloaking = false;
            this._hasOpenedShockWindow = false;
            if(this._settings.ShouldUpdateEveryTime == false)
            {
                    return;
            }
            
            this.CalculateDirectionAndDistance();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetCloakPlanePosition()
        {
            this.UpdateCloakPercent();
            return this.CalculateCloakPlanePosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEyeCloakState(bool eyeCloakEnabled)
        {
            this._eyeCloak.BeginTime = -1f;
            this._eyeCloak.Percent = (eyeCloakEnabled != true) ? 1f : 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginEyeCloak()
        {
            this._eyeCloak.BeginTime = UnityEngine.Time.time;
            this._eyeCloak.IsCloaking = true;
            if(this._settings.ShouldUpdateEveryTime == false)
            {
                    return;
            }
            
            this.CalculateDirectionAndDistance();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void BeginEyeDecloak()
        {
            this._eyeCloak.BeginTime = UnityEngine.Time.time;
            this._eyeCloak.IsCloaking = false;
            if(this._settings.ShouldUpdateEveryTime == false)
            {
                    return;
            }
            
            this.CalculateDirectionAndDistance();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 GetEyeCloakPlanePosition()
        {
            return this.CalculateEyeCloakPlanePosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateDirectionAndDistance()
        {
            if(this._settings == null)
            {
                    this._settings = this._settings;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this._settings.CloakedRevealPlanePosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this._settings.DecloakedRevealPlanePosition, y = V11.16B, z = V12.16B});
            this._distance = val_1.x;
            this._direction = val_1;
            mem[1152921525087514520] = val_1.y;
            mem[1152921525087514524] = val_1.z;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCloakPercent()
        {
            if(this._settings.ShouldHideEyes != false)
            {
                    this.BeginEyeCloak();
                this._settings.ShouldHideEyes = false;
            }
            
            if(this._settings.ShouldShowEyes != false)
            {
                    this.BeginEyeDecloak();
                this._settings.ShouldShowEyes = false;
            }
            
            if(this._settings.ShouldCloak != false)
            {
                    this.BeginCloak();
                this._settings.ShouldCloak = false;
            }
            
            if(this._settings.ShouldDecloak != false)
            {
                    this.BeginDecloak();
                this._settings.ShouldDecloak = false;
            }
            
            this.UpdateBodyCloak();
            this.UpdateEyeCloak();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBodyCloak()
        {
            Animatronics.Animatronic3d.Model.Effects.CloakGroup val_6;
            float val_7;
            Animatronics.Animatronic3d.Model.Effects.CloakGroup val_8;
            float val_9;
            val_6 = this;
            val_7 = this._bodyCloak.BeginTime;
            if(val_7 < 0)
            {
                    return;
            }
            
            float val_1 = (this._bodyCloak.IsCloaking == false) ? this._settings.DecloakTime : this._settings.CloakTime;
            val_8 = this._bodyCloak;
            if(val_1 == 0f)
            {
                goto label_15;
            }
            
            if((this._bodyCloak.IsCloaking != true) && (this._hasOpenedShockWindow != true))
            {
                    val_7 = this._settings.ShockWindowOpenTime;
                if((UnityEngine.Time.time - this._bodyCloak.BeginTime) >= val_7)
            {
                    this._hasOpenedShockWindow = true;
                if(this.OnShockWindowOpened != null)
            {
                    this.OnShockWindowOpened.Invoke();
            }
            
            }
            
            }
            
            float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - this._bodyCloak.BeginTime;
            val_4 = val_4 / val_1;
            this._bodyCloak.Percent = val_4;
            val_8 = this._bodyCloak;
            if(this._bodyCloak == null)
            {
                    val_8 = this._bodyCloak;
            }
            
            if(this._bodyCloak.Percent >= 1f)
            {
                goto label_15;
            }
            
            if(this._bodyCloak.IsCloaking == true)
            {
                    return;
            }
            
            val_6 = this._bodyCloak;
            if(val_6 == null)
            {
                goto label_18;
            }
            
            val_9 = this._bodyCloak.Percent;
            goto label_19;
            label_15:
            Animatronics.Animatronic3d.Model.Effects.CloakController.CompleteCloakOrDecloak(cloakGroup:  val_8);
            return;
            label_18:
            val_6 = 16;
            val_9 = 1.68059E-38f;
            label_19:
            mem[16] = 1f - val_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEyeCloak()
        {
            Animatronics.Animatronic3d.Model.Effects.CloakGroup val_4;
            Animatronics.Animatronic3d.Model.Effects.CloakGroup val_5;
            float val_6;
            val_4 = this;
            if(this._eyeCloak.BeginTime < 0)
            {
                    return;
            }
            
            float val_1 = (this._eyeCloak.IsCloaking == false) ? this._settings.DecloakTime : this._settings.CloakTime;
            val_5 = this._eyeCloak;
            if(val_1 == 0f)
            {
                goto label_8;
            }
            
            float val_2 = UnityEngine.Time.time;
            val_2 = val_2 - this._eyeCloak.BeginTime;
            val_2 = val_2 / val_1;
            this._eyeCloak.Percent = val_2;
            val_5 = this._eyeCloak;
            if(this._eyeCloak == null)
            {
                    val_5 = this._eyeCloak;
            }
            
            if(this._eyeCloak.Percent >= 1f)
            {
                goto label_8;
            }
            
            if(this._eyeCloak.IsCloaking == true)
            {
                    return;
            }
            
            val_4 = this._eyeCloak;
            if(val_4 == null)
            {
                goto label_11;
            }
            
            val_6 = this._eyeCloak.Percent;
            goto label_12;
            label_8:
            Animatronics.Animatronic3d.Model.Effects.CloakController.CompleteCloakOrDecloak(cloakGroup:  val_5);
            return;
            label_11:
            val_4 = 16;
            val_6 = 1.68059E-38f;
            label_12:
            mem[16] = 1f - val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CompleteCloakOrDecloak(Animatronics.Animatronic3d.Model.Effects.CloakGroup cloakGroup)
        {
            if(cloakGroup != null)
            {
                    cloakGroup.BeginTime = -1f;
                var val_1 = (cloakGroup.IsCloaking == true) ? 1f : 0f;
            }
            else
            {
                    mem[20] = -1082130432;
            }
            
            cloakGroup.Percent = (cloakGroup.IsCloaking == true) ? 1f : 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 CalculateEyeCloakPlanePosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this._direction, y = V14.16B, z = V12.16B}, d:  this._distance);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this._eyeCloak.Percent);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._settings.DecloakedRevealPlanePosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 CalculateCloakPlanePosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this._direction, y = V14.16B, z = V12.16B}, d:  this._distance);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this._bodyCloak.Percent);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this._settings.DecloakedRevealPlanePosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CloakController(Animatronics.Animatronic3d.Model.Effects.CloakSettings settings)
        {
            this._bodyCloak = new Animatronics.Animatronic3d.Model.Effects.CloakGroup();
            this._eyeCloak = new Animatronics.Animatronic3d.Model.Effects.CloakGroup();
            this._settings = settings;
            this._bodyCloak.Percent = 0f;
            this._bodyCloak.BeginTime = -1f;
            this._eyeCloak.Percent = 0f;
            this._eyeCloak.BeginTime = -1f;
            this.CalculateDirectionAndDistance();
        }
    
    }

}
