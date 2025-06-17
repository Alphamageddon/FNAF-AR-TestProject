using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseWaitForCamera : Phase
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
            var val_15;
            var val_19;
            var val_23;
            var val_24;
            Game.ItemDefinition.Data.DataDefinitions.FootstepConfigData val_26;
            bool val_23 = static_value_04281000;
            var val_20 = static_value_04281000 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_27 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_24 = X21 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_26 = val_24;
            val_26 = val_26 + 1;
            val_27 = val_27 + val_26;
            val_15 = val_27 + 296;
            label_12:
            string val_2 = X21.EntityId;
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  val_2);
            var val_28 = 0;
            val_28 = val_28 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_29 = 0;
            val_29 = val_29 + 1;
            Game.Audio.AudioEventName val_7 = ((val_2.IsExpressDelivery & true) != 0) ? (12 + 1) : 12;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_19 = 0;
            val_4.RaiseAudioEventGlobal(eventName:  val_7, useCpu:  false);
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_19 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_10 = val_4.Model;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_19 = 34;
            val_10.SetTransformOverrideMode(mode:  1);
            var val_33 = 0;
            val_33 = val_33 + 1;
            var val_37 = val_7;
            if(((val_6 & true)!=0 ? (12 + 1) : 12 + 286) == 0)
            {
                goto label_48;
            }
            
            var val_34 = (val_6 & true)!=0 ? (12 + 1) : 12 + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_47:
            if((((val_6 & true)!=0 ? (12 + 1) : 12 + 176 + 8) + -8) == null)
            {
                goto label_46;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < ((val_6 & true)!=0 ? (12 + 1) : 12 + 286))
            {
                goto label_47;
            }
            
            goto label_48;
            label_46:
            var val_36 = val_34;
            val_36 = val_36 + 6;
            val_37 = val_37 + val_36;
            val_23 = val_37 + 296;
            label_48:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_14 = val_7.AttackProfile;
            var val_41 = X22;
            if((X22 + 286) == 0)
            {
                goto label_55;
            }
            
            var val_38 = X22 + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_54:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_53;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (X22 + 286))
            {
                goto label_54;
            }
            
            goto label_55;
            label_53:
            var val_40 = val_38;
            val_40 = val_40 + 6;
            val_41 = val_41 + val_40;
            val_24 = val_41 + 296;
            label_55:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_15 = X22.AttackProfile;
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_26 = val_15.Footsteps.Run;
            val_10.Model.SetFootstepConfig(walkConfigData:  val_14.Footsteps.Walk, runConfigData:  val_26);
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_26 = 2;
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_26 = 39;
            this.Model.Teleport(angleFromCamera:  0f, distanceFromCamera:  10000f, faceCamera:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RunSharedExitPhase()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseWaitForCamera()
        {
            this.<AttackPhase>k__BackingField = 2;
            val_1 = new System.Object();
        }
    
    }

}
