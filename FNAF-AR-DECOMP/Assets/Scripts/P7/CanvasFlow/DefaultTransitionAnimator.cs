using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DefaultTransitionAnimator : CanvasControllerTransitioningAnimator, ICanvasControllerTransitioningAnimator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve curve;
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
            System.Action<System.Single> val_7;
            DefaultTransitionAnimator.<>c__DisplayClass5_0 val_1 = new DefaultTransitionAnimator.<>c__DisplayClass5_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                val_7 = val_1.MoveContentAnimation(transitionContext:  transitionContext);
            }
            else
            {
                    mem[16] = this;
                val_7 = this.MoveContentAnimation(transitionContext:  transitionContext);
            }
            
            .animateContent = val_7;
            new P7.CanvasFlow.Routine(duration:  this.duration, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  new System.Action<System.Single>(object:  val_1, method:  System.Void DefaultTransitionAnimator.<>c__DisplayClass5_0::<AnimateTransition>b__0(float progress01)), OnComplete:  new System.Action(object:  transitionContext, method:  public System.Void P7.CanvasFlow.CanvasControllerTransitionContext::CompleteTransition()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransitionForInitialCanvasController(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            goto typeof(P7.CanvasFlow.DefaultTransitionAnimator).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> MoveContentAnimation(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            var val_7;
            P7.CanvasFlow.CanvasController val_8;
            P7.CanvasFlow.CanvasController val_9;
            var val_10;
            DefaultTransitionAnimator.<>c__DisplayClass7_0 val_1 = new DefaultTransitionAnimator.<>c__DisplayClass7_0();
            if(transitionContext == null)
            {
                goto label_1;
            }
            
            val_7 = transitionContext;
            if(transitionContext.isUpstream == false)
            {
                goto label_2;
            }
            
            label_4:
            val_8 = transitionContext.sourceCanvasController;
            goto label_3;
            label_1:
            val_7 = 32;
            if(64 != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_8 = transitionContext.destinationCanvasController;
            label_3:
            val_9 = mem[transitionContext.destinationCanvasController];
            if(val_1 == null)
            {
                goto label_5;
            }
            
            val_10 = val_1;
            .targetCanvasController = val_9;
            if(val_7 == 0)
            {
                goto label_6;
            }
            
            label_8:
            UnityEngine.Vector3 val_2 = P7.CanvasFlow.CanvasControllerExtensions.OnScreenContentPosition(canvasController:  val_9);
            goto label_7;
            label_5:
            val_10 = val_1;
            .targetCanvasController = val_9;
            val_9 = .targetCanvasController;
            if(64 != 0)
            {
                goto label_8;
            }
            
            label_6:
            UnityEngine.Vector3 val_3 = P7.CanvasFlow.CanvasControllerExtensions.OffScreenBottomContentPosition(canvasController:  val_9);
            label_7:
            .contentStartPosition = val_3;
            mem[1152921525518811852] = val_3.y;
            mem[1152921525518811856] = val_3.z;
            if(64 != 0)
            {
                    UnityEngine.Vector3 val_4 = P7.CanvasFlow.CanvasControllerExtensions.OffScreenBottomContentPosition(canvasController:  .targetCanvasController);
            }
            else
            {
                    UnityEngine.Vector3 val_5 = P7.CanvasFlow.CanvasControllerExtensions.OnScreenContentPosition(canvasController:  .targetCanvasController);
            }
            
            .contentEndPosition = val_5;
            mem[1152921525518811864] = val_5.y;
            mem[1152921525518811868] = val_5.z;
            return (System.Action<System.Single>)new System.Action<System.Single>(object:  val_1, method:  System.Void DefaultTransitionAnimator.<>c__DisplayClass7_0::<MoveContentAnimation>b__0(float progress01));
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
            mem[1152921525518908696] = "The default transition animator presents content from the bottom of the screen, sliding it upwards. It dismisses content by performing the reverse - animating onscreen content downwards.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DefaultTransitionAnimator()
        {
        
        }
    
    }

}
