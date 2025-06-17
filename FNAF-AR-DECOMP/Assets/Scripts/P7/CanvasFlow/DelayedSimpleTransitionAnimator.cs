using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DelayedSimpleTransitionAnimator : CanvasControllerTransitioningAnimator, ICanvasControllerTransitioningAnimator
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
            var val_5;
            var val_6;
            System.Action<System.Single> val_8;
            DelayedSimpleTransitionAnimator.<>c__DisplayClass5_0 val_1 = new DelayedSimpleTransitionAnimator.<>c__DisplayClass5_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .transitionContext = transitionContext;
            if(transitionContext != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            if(val_1 == null)
            {
                goto label_3;
            }
            
            .source = transitionContext.sourceCanvasController;
            goto label_4;
            label_1:
            mem[32] = transitionContext;
            if(mem[32] != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            mem[16] = transitionContext.sourceCanvasController;
            label_4:
            if(val_1 != null)
            {
                    val_5 = val_1;
                .destination = transitionContext.destinationCanvasController;
            }
            else
            {
                    val_5 = 24;
                mem[24] = transitionContext.destinationCanvasController;
            }
            
            val_5.ContentActive = false;
            val_6 = null;
            val_6 = null;
            val_8 = DelayedSimpleTransitionAnimator.<>c.<>9__5_0;
            if(val_8 == null)
            {
                    System.Action<System.Single> val_3 = null;
                val_8 = val_3;
                val_3 = new System.Action<System.Single>(object:  DelayedSimpleTransitionAnimator.<>c.__il2cppRuntimeField_static_fields, method:  System.Void DelayedSimpleTransitionAnimator.<>c::<AnimateTransition>b__5_0(float x));
                DelayedSimpleTransitionAnimator.<>c.<>9__5_0 = val_8;
            }
            
            new P7.CanvasFlow.Routine(duration:  this.duration, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  val_3, OnComplete:  new System.Action(object:  val_1, method:  System.Void DelayedSimpleTransitionAnimator.<>c__DisplayClass5_0::<AnimateTransition>b__1()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransitionForInitialCanvasController(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            goto typeof(P7.CanvasFlow.DelayedSimpleTransitionAnimator).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DelayedSimpleTransitionAnimator()
        {
        
        }
    
    }

}
