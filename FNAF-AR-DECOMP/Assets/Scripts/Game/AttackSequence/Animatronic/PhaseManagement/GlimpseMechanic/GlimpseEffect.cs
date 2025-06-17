using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.GlimpseMechanic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GlimpseEffect
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _wasSeen;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _finished;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cloakDelayTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cloakDelayTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cloakTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cloakTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _expireTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFinished()
        {
            return (bool)this._finished;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SpawnGlimpse(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard, float angleFromCamera, float distance, float cloakDelayTime, float cloakTime, float expireTime)
        {
            var val_16;
            var val_19;
            var val_22;
            var val_25;
            var val_28;
            this.Reset();
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_16 = 2;
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_16 = 39;
            val_19 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera);
            blackboard.Model.Teleport(angleFromCamera:  angleFromCamera, distanceFromCamera:  distance, faceCamera:  true);
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_19 = 2;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_19 = 15;
            val_22 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            blackboard.Model.SetCloakState(cloakEnabled:  false);
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_22 = 2;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_22 = 18;
            val_25 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            blackboard.Model.SetEyeCloakState(eyeCloakEnabled:  false);
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_25 = 2;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_25 = 13;
            val_28 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            blackboard.Model.SetEyeColorMode(mode:  0);
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_28 = 2;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_28 = 14;
            blackboard.Model.SetEyeGlow(eyeGlowEnabled:  false);
            var val_33 = 0;
            val_33 = val_33 + 1;
            var val_34 = 0;
            val_34 = val_34 + 1;
            blackboard.Model.SetAnimationInt(animationInt:  2, value:  UnityEngine.Random.Range(min:  0, max:  3));
            var val_35 = 0;
            val_35 = val_35 + 1;
            var val_36 = 0;
            val_36 = val_36 + 1;
            blackboard.Model.SetAnimationBool(animationBool:  1, value:  true);
            this._cloakDelayTime = cloakDelayTime;
            this._cloakTime = cloakTime;
            this._expireTimer.StartTimer(time:  expireTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void EndGlimpse(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            var val_5 = 0;
            val_5 = val_5 + 1;
            blackboard.Model.SetAnimationBool(animationBool:  1, value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            if(this._cloakTimer.Started() != false)
            {
                    bool val_2 = this._cloakTimer.IsExpired();
                if(val_2 != false)
            {
                    val_2.EndGlimpse(blackboard:  blackboard);
                this._finished = true;
            }
            
            }
            
            if(this._finished == true)
            {
                    return;
            }
            
            if(this._cloakDelayTimer.Started() != false)
            {
                    if(this._cloakDelayTimer.IsExpired() == true)
            {
                goto label_9;
            }
            
            }
            
            if((this._expireTimer.Started() != false) && (this._expireTimer.IsExpired() != false))
            {
                    label_9:
                this.BeginCloak(blackboard:  blackboard);
            }
            
            if(this._wasSeen == true)
            {
                    return;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(blackboard.IsAABBOnScreen == false)
            {
                    return;
            }
            
            this.MarkSeen();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            this._wasSeen = false;
            this._finished = false;
            this._cloakDelayTime = 0f;
            this._cloakDelayTimer.Reset();
            this._cloakTime = 0f;
            this._cloakTimer.Reset();
            this._expireTimer.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MarkSeen()
        {
            this._wasSeen = true;
            this._cloakDelayTimer.StartTimer(time:  this._cloakDelayTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BeginCloak(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            var val_10;
            var val_12;
            var val_13;
            var val_15;
            var val_21;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_10 = 2;
            val_12 = blackboard.Model;
            if(this._wasSeen == false)
            {
                goto label_7;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = 9;
            goto label_11;
            label_7:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = 15;
            goto label_15;
            label_11:
            val_12.RaiseAudioEventFromPlushSuit(eventName:  3);
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_12 = blackboard.Model;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_12.BeginCloak();
            var val_19 = 0;
            val_19 = val_19 + 1;
            var val_20 = 0;
            val_20 = val_20 + 1;
            blackboard.Model.BeginEyeCloak();
            if(this._cloakTimer != null)
            {
                goto label_37;
            }
            
            goto label_37;
            label_15:
            val_21 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_12.SetCloakState(cloakEnabled:  true);
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_21 = 2;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_21 = 18;
            blackboard.Model.SetEyeCloakState(eyeCloakEnabled:  true);
            label_37:
            this._cloakTimer.StartTimer(time:  0f);
            this._cloakDelayTimer.Reset();
            this._expireTimer.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GlimpseEffect()
        {
            this._cloakDelayTimer = new SimpleTimer();
            this._cloakTimer = new SimpleTimer();
            this._expireTimer = new SimpleTimer();
        }
    
    }

}
