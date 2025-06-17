using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseJumpscare : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase AttackPhase { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase get_AttackPhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)this.<AttackPhase>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RunSharedEnterPhase()
        {
            Game.AttackSequence.Static.PhaseStaticSettings val_21;
            var val_23;
            var val_24;
            var val_25;
            var val_29;
            var val_32;
            var val_34;
            var val_36;
            var val_41;
            bool val_37 = static_value_04281000;
            var val_34 = static_value_04281000 + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            val_21 = 3;
            if(Systems == null)
            {
                goto label_6;
            }
            
            var val_41 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_38 = X21 + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_40 = val_38;
            val_40 = val_40 + 1;
            val_41 = val_41 + val_40;
            val_23 = val_41 + 296;
            label_12:
            string val_2 = X21.EntityId;
            var val_45 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_42 = X22 + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_44 = val_42;
            val_44 = val_44 + 5;
            val_45 = val_45 + val_44;
            val_24 = val_45 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_49 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_46 = X23 + 176;
            var val_47 = 0;
            val_46 = val_46 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_47 = val_47 + 1;
            val_46 = val_46 + 16;
            if(val_47 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_48 = val_46;
            val_48 = val_48 + 6;
            val_49 = val_49 + val_48;
            val_25 = val_49 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_21 = val_3.Jumpscare;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  val_2, settings:  val_21, shearModifier:  val_4.ShearModifier);
            label_6:
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_21 = 3;
            if((val_1.AttackStatic.<Container>k__BackingField.Systems) != null)
            {
                    val_6.AttackDisruption.StopDisruption();
            }
            
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_21 = 3;
            if(val_6.AttackDisruption.Systems != null)
            {
                    val_8.AttackSurge.StopSurgeEffect();
                val_8.AttackSurge._settings = 0;
            }
            
            var val_52 = 0;
            val_52 = val_52 + 1;
            val_21 = 3;
            if(val_8.AttackSurge.Systems != null)
            {
                    var val_53 = 0;
                val_53 = val_53 + 1;
                val_29 = 1;
                var val_54 = 0;
                val_54 = val_54 + 1;
                val_29 = 6;
                val_32 = public System.Void Game.CameraEquipment.Battery.IBattery::RemoveBatteryDrain(string id);
                val_10.Battery.RemoveBatteryDrain(id:  val_2.EntityId);
            }
            
            var val_55 = 0;
            val_55 = val_55 + 1;
            val_32 = 3;
            if(val_10.Battery.Systems != null)
            {
                    var val_56 = 0;
                val_56 = val_56 + 1;
                val_34 = 4;
                val_36 = public System.Void Game.CameraEquipment.Battery.IBattery::SetExtraBatteryBlocker(bool isBlocked);
                val_15.Battery.SetExtraBatteryBlocker(isBlocked:  true);
            }
            
            var val_57 = 0;
            val_57 = val_57 + 1;
            val_36 = 3;
            if(val_15.Battery.Systems != null)
            {
                    var val_58 = 0;
                val_58 = val_58 + 1;
                val_36 = 0;
                val_18.Flashlight.SetFlashlightState(setOn:  false, shouldPlayAudio:  false);
            }
            
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_36 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_21 = val_18.Flashlight.Model;
            var val_60 = 0;
            val_60 = val_60 + 1;
            val_36 = 39;
            val_41 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera);
            val_21.Teleport(angleFromCamera:  0f, distanceFromCamera:  0f, faceCamera:  false);
            var val_61 = 0;
            val_61 = val_61 + 1;
            val_41 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_24 = val_21.Model;
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_41 = 34;
            val_24.SetTransformOverrideMode(mode:  2);
            if(VibrationSettings.VibrationIsEnabled() != false)
            {
                    var val_63 = 0;
                val_63 = val_63 + 1;
                Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_28 = val_24.AttackProfile;
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  val_28.Jumpscare.VibrationType, defaultToRegularVibrate:  true);
            }
            
            var val_64 = 0;
            val_64 = val_64 + 1;
            if(val_28.Jumpscare.VibrationType.Systems != null)
            {
                    val_30.Encounter.EncounterLost();
            }
            
            var val_65 = 0;
            val_65 = val_65 + 1;
            var val_66 = 0;
            val_66 = val_66 + 1;
            this.Model.RaiseAudioEventCamera(eventName:  4, useCpu:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RunSharedExitPhase()
        {
            var val_5;
            var val_7;
            bool val_9 = static_value_04281000;
            var val_6 = static_value_04281000 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            val_5 = 3;
            if(Systems == null)
            {
                goto label_6;
            }
            
            var val_13 = X21;
            if((X21 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_10 = X21 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (X21 + 286))
            {
                goto label_11;
            }
            
            label_9:
            val_5 = 1;
            goto label_12;
            label_10:
            var val_12 = val_10;
            val_12 = val_12 + 1;
            val_13 = val_13 + val_12;
            val_7 = val_13 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            label_6:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_5 = 3;
            if(this.Systems == null)
            {
                    return;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_5 = 4;
            val_4.Mask.SetMaskAvailable(shouldMaskBeAvailable:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseJumpscare()
        {
            this.<AttackPhase>k__BackingField = 9;
            val_1 = new System.Object();
        }
    
    }

}
