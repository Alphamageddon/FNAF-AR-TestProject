using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Animation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatorDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Animator _animator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationMode(Animatronics.Animatronic3d.Model.Animation.AnimationMode animationMode)
        {
            this.SetAnimationInt(animationInt:  1, value:  animationMode);
            this.SetAnimationTrigger(animationTrigger:  10, shouldSet:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag)
        {
            UnityEngine.AnimatorStateInfo val_1 = this._animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            string val_5 = animationTag.ToString();
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = animationTag});
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationBool(Animatronics.Animatronic3d.Model.Animation.AnimationBool animationBool, bool value)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = animationBool});
            value = value;
            this._animator.SetBool(name:  animationBool.ToString(), value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationInt(Animatronics.Animatronic3d.Model.Animation.AnimationInt animationInt, int value)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = animationInt});
            this._animator.SetInteger(name:  animationInt.ToString(), value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationFloat(Animatronics.Animatronic3d.Model.Animation.AnimationFloat animationFloat, float value)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = animationFloat});
            this._animator.SetFloat(name:  animationFloat.ToString(), value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAnimationTrigger(Animatronics.Animatronic3d.Model.Animation.AnimationTrigger animationTrigger, bool shouldSet)
        {
            string val_1 = animationTrigger.ToString();
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = animationTrigger});
            if(this._animator == null)
            {
                goto label_3;
            }
            
            if(shouldSet == false)
            {
                goto label_4;
            }
            
            label_6:
            this._animator.SetTrigger(name:  val_1);
            return;
            label_3:
            if(shouldSet == true)
            {
                goto label_6;
            }
            
            label_4:
            this._animator.ResetTrigger(name:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(UnityEngine.Animator animator)
        {
            this._animator = animator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animator = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatorDispatcher()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimatorDispatcher()
        {
            Animatronics.Animatronic3d.Model.Animation.AnimatorDispatcher.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
