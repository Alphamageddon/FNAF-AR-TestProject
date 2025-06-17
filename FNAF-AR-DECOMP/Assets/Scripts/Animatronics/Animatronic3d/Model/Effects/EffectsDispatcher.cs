using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Effects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EffectsDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private LightningFxController _lightningEffect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicMaterialController _materialController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private EyeGlowLightController _eyeGlowController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Movement.Footsteps _footsteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<Animatronics.Animatronic3d.Model.Effects.EyeColorMode, Game.ItemDefinition.Data.DataDefinitions.EyeColorData> _eyeOverrides;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EffectEventReceived(UnityEngine.AnimationEvent animationEvent)
        {
            LightningFxController val_12 = this;
            Animatronics.Animatronic3d.Model.Effects.EyeColorMode val_8 = 0;
            if((animationEvent.intParameter - 1000) > 7)
            {
                    return;
            }
            
            var val_12 = 52948972 + ((val_1 - 1000)) << 2;
            val_12 = val_12 + 52948972;
            goto (52948972 + ((val_1 - 1000)) << 2 + 52948972);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode)
        {
            Animatronics.Animatronic3d.Model.Effects.EyeColorMode val_9;
            var val_10;
            AnimatronicMaterialController val_12;
            float val_13;
            val_9 = mode;
            if((this._eyeOverrides.ContainsKey(key:  val_9)) != false)
            {
                    val_10 = this._eyeOverrides.Item[val_9];
            }
            else
            {
                    val_10 = 0;
                val_9 = 0;
            }
            
            if(this._materialController == 0)
            {
                goto label_7;
            }
            
            if((val_10 == 0) || (val_9 == 0))
            {
                goto label_9;
            }
            
            if(3 == 0)
            {
                goto label_10;
            }
            
            if(this._materialController == null)
            {
                goto label_11;
            }
            
            var val_4 = (0f < 0f) ? 1f : 0f;
            goto label_12;
            label_9:
            this._materialController.eyeGlowMultiplier = 1f;
            goto label_14;
            label_10:
            if(this._materialController == null)
            {
                goto label_15;
            }
            
            var val_5 = (0f < 0f) ? 1f : 0f;
            goto label_16;
            label_11:
            label_12:
            this._materialController.eyeGlowMultiplier = (0f < 0f) ? 1f : 0f;
            val_12 = this._materialController;
            this._materialController._eyeColorOverride = 1;
            mem2[0] = 15026800;
            mem2[0] = 0;
            mem2[0] = 64;
            this._materialController._hasEyeColorOverride = true;
            val_13 = 1f;
            goto label_18;
            label_15:
            label_16:
            this._materialController.eyeGlowMultiplier = (0f < 0f) ? 1f : 0f;
            label_14:
            val_12 = this._materialController;
            val_13 = 0f;
            this._materialController._hasEyeColorOverride = false;
            label_18:
            this._materialController._eyeOverrideSwitch = val_13;
            label_7:
            if(this._eyeGlowController == 0)
            {
                    return;
            }
            
            if(((val_10 != 0) && (val_9 != 0)) && (3 != 0))
            {
                    this._eyeGlowController.StartEyeColorOverride(color:  new UnityEngine.Color() {r = 1.401298E-45f, g = 2.105703E-38f, b = 0f, a = 8.96831E-44f});
                return;
            }
            
            this._eyeGlowController.EndEyeColorOverride();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEyeGlow(bool eyeGlowEnabled)
        {
            if(this._materialController != 0)
            {
                    if(this._materialController != null)
            {
                    var val_2 = (eyeGlowEnabled != true) ? 1f : 0f;
            }
            
                this._materialController._eyeGlowStrength = (eyeGlowEnabled != true) ? 1f : 0f;
            }
            
            if(this._eyeGlowController == 0)
            {
                    return;
            }
            
            this._eyeGlowController.SetEyeGlow(eyeGlowEnabled:  eyeGlowEnabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetWearAndTear(int value)
        {
            if(this._materialController == 0)
            {
                    return;
            }
            
            this._materialController.wearAndTearPercentage = (float)value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerRepairInterpolation()
        {
            this._materialController._shouldPerformRepairInterpolation = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Animatronics.Animatronic3d.Model.AnimatronicModelConfig modelConfig, Animatronics.Animatronic3d.Model.Movement.Footsteps footsteps, Game.ItemDefinition.Data.DataDefinitions.CPUData cpuData)
        {
            if(modelConfig != null)
            {
                    this._lightningEffect = modelConfig.ShockLightningEffect;
                this._materialController = modelConfig.AnimatronicMaterialController;
            }
            else
            {
                    this._lightningEffect = 0;
                this._materialController = 69077560;
            }
            
            this._eyeGlowController = modelConfig.EyeGlowLightController;
            this._footsteps = footsteps;
            this.SetEyeOverrides(cpuData:  cpuData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetEyeOverrides(Game.ItemDefinition.Data.DataDefinitions.CPUData cpuData)
        {
            Game.ItemDefinition.Data.DataDefinitions.EyeColorData val_1;
            if(cpuData == null)
            {
                    return;
            }
            
            if(cpuData.AttackEyes != null)
            {
                    this._eyeOverrides.Add(key:  1, value:  cpuData.AttackEyes);
            }
            
            val_1 = cpuData.LookAtEyes;
            if(val_1 != null)
            {
                    this._eyeOverrides.Add(key:  2, value:  val_1);
            }
            
            if(cpuData.LookAwayEyes == null)
            {
                    return;
            }
            
            this._eyeOverrides.Add(key:  3, value:  cpuData.LookAwayEyes);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._footsteps = 0;
            this._lightningEffect = 0;
            this._materialController = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EffectsDispatcher()
        {
            this._eyeOverrides = new System.Collections.Generic.Dictionary<Animatronics.Animatronic3d.Model.Effects.EyeColorMode, Game.ItemDefinition.Data.DataDefinitions.EyeColorData>();
        }
    
    }

}
