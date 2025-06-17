using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScaleTransitionAnimator : CanvasControllerTransitioningAnimator, ICanvasControllerTransitioningAnimator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve curve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool reverseCurveOnUpstream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useScaledTime;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private P7.CanvasFlow.RoutineUpdateMode UpdateMode { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private P7.CanvasFlow.RoutineUpdateMode get_UpdateMode()
        {
            return (P7.CanvasFlow.RoutineUpdateMode)this.useScaledTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransition(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            object val_7;
            System.Action<System.Single> val_8;
            ScaleTransitionAnimator.<>c__DisplayClass6_0 val_1 = new ScaleTransitionAnimator.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    val_7 = val_1;
                .transitionContext = transitionContext;
                mem[1152921525524804280] = this;
                val_8 = val_1.ScaleContentAnimation(transitionContext:  transitionContext);
            }
            else
            {
                    val_7 = 16;
                mem[16] = transitionContext;
                mem[24] = this;
                val_8 = this.ScaleContentAnimation(transitionContext:  mem[16]);
            }
            
            .animateContent = val_8;
            new P7.CanvasFlow.Routine(duration:  this.duration, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  new System.Action<System.Single>(object:  val_1, method:  System.Void ScaleTransitionAnimator.<>c__DisplayClass6_0::<AnimateTransition>b__0(float progress01)), OnComplete:  new System.Action(object:  val_7, method:  public System.Void P7.CanvasFlow.CanvasControllerTransitionContext::CompleteTransition()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransitionForInitialCanvasController(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            goto typeof(P7.CanvasFlow.ScaleTransitionAnimator).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> ScaleContentAnimation(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            P7.CanvasFlow.CanvasController val_3;
            if(transitionContext == null)
            {
                goto label_1;
            }
            
            if(transitionContext.isUpstream == false)
            {
                goto label_2;
            }
            
            label_4:
            val_3 = transitionContext.sourceCanvasController;
            goto label_3;
            label_1:
            if(64 != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_3 = transitionContext.destinationCanvasController;
            label_3:
            .targetCanvasController = mem[transitionContext.destinationCanvasController];
            return (System.Action<System.Single>)new System.Action<System.Single>(object:  new ScaleTransitionAnimator.<>c__DisplayClass8_0(), method:  System.Void ScaleTransitionAnimator.<>c__DisplayClass8_0::<ScaleContentAnimation>b__0(float progress01));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            this.duration = 0.4f;
            UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[2];
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            this.curve = new UnityEngine.AnimationCurve(keys:  val_1);
            mem[1152921525525175480] = "The scale transition animator presents content by scaling it up from the center of the screen. It dismisses content by performing the reverse - scaling content down.\n\nThe reverseCurveOnUpstream flag causes the animation curve to be evaluated backwards on upstream transitions.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScaleTransitionAnimator()
        {
        
        }
    
    }

}
