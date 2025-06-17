using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SlideTransitionAnimator : CanvasControllerTransitioningAnimator, ICanvasControllerTransitioningAnimator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve curve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool useScaledTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public P7.CanvasFlow.SlideTransitionAnimator.OffScreenLocation presentedCanvasOffScreenLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool animatePresentingCanvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public P7.CanvasFlow.SlideTransitionAnimator.OffScreenLocation presentingCanvasOffScreenLocation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float presentingCanvasParallaxScalar;
        
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
            System.Action<System.Single> val_9;
            SlideTransitionAnimator.<>c__DisplayClass10_0 val_1 = new SlideTransitionAnimator.<>c__DisplayClass10_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .animatePresentedContent = this.MovePresentedContentAnimation(transitionContext:  transitionContext);
                val_9 = this.MovePresentingContentAnimation(transitionContext:  transitionContext);
            }
            else
            {
                    mem[16] = this;
                mem[24] = this.MovePresentedContentAnimation(transitionContext:  transitionContext);
                val_9 = this.MovePresentingContentAnimation(transitionContext:  transitionContext);
            }
            
            .animatePresentingContent = val_9;
            new P7.CanvasFlow.Routine(duration:  this.duration, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  new System.Action<System.Single>(object:  val_1, method:  System.Void SlideTransitionAnimator.<>c__DisplayClass10_0::<AnimateTransition>b__0(float progress01)), OnComplete:  new System.Action(object:  transitionContext, method:  public System.Void P7.CanvasFlow.CanvasControllerTransitionContext::CompleteTransition()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransitionForInitialCanvasController(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            goto typeof(P7.CanvasFlow.SlideTransitionAnimator).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> MovePresentedContentAnimation(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            var val_6;
            P7.CanvasFlow.CanvasController val_7;
            P7.CanvasFlow.CanvasController val_8;
            var val_9;
            var val_10;
            float val_11;
            float val_12;
            var val_13;
            float val_14;
            float val_15;
            SlideTransitionAnimator.<>c__DisplayClass12_0 val_1 = new SlideTransitionAnimator.<>c__DisplayClass12_0();
            if(transitionContext == null)
            {
                goto label_1;
            }
            
            val_6 = transitionContext;
            if(transitionContext.isUpstream == false)
            {
                goto label_2;
            }
            
            label_4:
            val_7 = transitionContext.sourceCanvasController;
            goto label_3;
            label_1:
            val_6 = 32;
            if(64 != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_7 = transitionContext.destinationCanvasController;
            label_3:
            val_8 = mem[transitionContext.destinationCanvasController];
            if(val_1 != null)
            {
                    val_9 = val_1;
                .presentedCanvasController = val_8;
            }
            else
            {
                    val_9 = val_1;
                .presentedCanvasController = val_8;
                val_8 = .presentedCanvasController;
            }
            
            UnityEngine.Vector3 val_2 = this.PositionForCanvasControllerAtLocation(canvasController:  val_8, location:  this.presentedCanvasOffScreenLocation);
            val_10 = val_2.x;
            val_11 = val_2.y;
            val_12 = val_2.z;
            val_13 = val_10;
            val_14 = val_11;
            val_15 = val_12;
            if(val_6 != 0)
            {
                    UnityEngine.Vector3 val_3 = P7.CanvasFlow.CanvasControllerExtensions.OnScreenContentPosition(canvasController:  .presentedCanvasController);
                val_13 = val_3.x;
                val_14 = val_3.y;
                val_15 = val_3.z;
            }
            
            .contentStartPosition = val_3;
            mem[1152921525526393676] = val_14;
            mem[1152921525526393680] = val_15;
            if(64 == 0)
            {
                    UnityEngine.Vector3 val_4 = P7.CanvasFlow.CanvasControllerExtensions.OnScreenContentPosition(canvasController:  .presentedCanvasController);
                val_10 = val_4.x;
                val_11 = val_4.y;
                val_12 = val_4.z;
            }
            
            .contentEndPosition = val_4;
            mem[1152921525526393688] = val_11;
            mem[1152921525526393692] = val_12;
            return (System.Action<System.Single>)new System.Action<System.Single>(object:  val_1, method:  System.Void SlideTransitionAnimator.<>c__DisplayClass12_0::<MovePresentedContentAnimation>b__0(float progress01));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> MovePresentingContentAnimation(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            SlideTransitionAnimator.<>c__DisplayClass13_0 val_14;
            var val_15;
            P7.CanvasFlow.CanvasController val_16;
            var val_17;
            P7.CanvasFlow.CanvasController val_18;
            var val_19;
            float val_20;
            if(this.animatePresentingCanvas == false)
            {
                goto label_1;
            }
            
            SlideTransitionAnimator.<>c__DisplayClass13_0 val_1 = null;
            val_14 = val_1;
            val_1 = new SlideTransitionAnimator.<>c__DisplayClass13_0();
            if(transitionContext == null)
            {
                goto label_2;
            }
            
            val_15 = transitionContext;
            if(transitionContext.isUpstream == false)
            {
                goto label_3;
            }
            
            label_6:
            val_16 = transitionContext.destinationCanvasController;
            goto label_4;
            label_1:
            val_17 = 0;
            return (System.Action<System.Single>)val_17;
            label_2:
            val_15 = 32;
            if(64 != 0)
            {
                goto label_6;
            }
            
            label_3:
            val_16 = transitionContext.sourceCanvasController;
            label_4:
            val_18 = mem[transitionContext.sourceCanvasController];
            if(val_14 != null)
            {
                    .presentingCanvasController = val_18;
            }
            else
            {
                    .presentingCanvasController = val_18;
                val_18 = (SlideTransitionAnimator.<>c__DisplayClass13_0)[1152921525526547632].presentingCanvasController;
            }
            
            val_17 = 0;
            if(val_18 == 0)
            {
                    return (System.Action<System.Single>)val_17;
            }
            
            SlideTransitionAnimator.<>c__DisplayClass13_1 val_3 = new SlideTransitionAnimator.<>c__DisplayClass13_1();
            if(val_3 != null)
            {
                    val_19 = val_3;
                .CS$<>8__locals1 = val_14;
            }
            else
            {
                    val_19 = 40;
                mem[40] = val_14;
            }
            
            UnityEngine.Vector3 val_4 = P7.CanvasFlow.CanvasControllerExtensions.OnScreenContentPosition(canvasController:  .presentingCanvasController);
            val_14 = mem[40];
            UnityEngine.Vector3 val_5 = this.PositionForCanvasControllerAtLocation(canvasController:  .presentingCanvasController, location:  this.presentingCanvasOffScreenLocation);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, t:  this.presentingCanvasParallaxScalar);
            val_20 = val_4.y;
            if(val_3 == null)
            {
                    val_20 = val_20;
            }
            
            .contentStartPosition = (val_15 != 0) ? val_6.x : val_4.x;
            mem[1152921525526555844] = (val_15 != 0) ? val_6.y : val_4.y;
            mem[1152921525526555848] = (val_15 != 0) ? val_6.z : val_4.z;
            .contentEndPosition = (64 != 0) ? val_4.x : val_6.x;
            mem[1152921525526555856] = (64 != 0) ? (val_20) : val_6.y;
            mem[1152921525526555860] = (64 != 0) ? val_4.z : val_6.z;
            System.Action<System.Single> val_13 = null;
            val_17 = val_13;
            val_13 = new System.Action<System.Single>(object:  val_3, method:  System.Void SlideTransitionAnimator.<>c__DisplayClass13_1::<MovePresentingContentAnimation>b__0(float progress01));
            return (System.Action<System.Single>)val_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 PositionForCanvasControllerAtLocation(P7.CanvasFlow.CanvasController canvasController, P7.CanvasFlow.SlideTransitionAnimator.OffScreenLocation location)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(location > 3)
            {
                    return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            }
            
            var val_6 = 52955620 + (location) << 2;
            val_6 = val_6 + 52955620;
            goto (52955620 + (location) << 2 + 52955620);
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
            this.presentedCanvasOffScreenLocation = 2;
            this.animatePresentingCanvas = true;
            this.presentingCanvasOffScreenLocation = 0;
            this.presentingCanvasParallaxScalar = 0.4f;
            mem[1152921525526786312] = "The slide transition animation presents content by sliding it in from an off-screen location. It dismisses content by performing the reverse - sliding it to an off-screen location.\n\nIn addition to the presented canvas controller, the presenting canvas controller can also be animated to and from an off-screen location. This gives the appearance of the content sliding out as the presented content slides in.\n\nWith the \'presentingCanvasParallaxScalar\' property, you can scale the amount by which the presenter moves, creating parallax effects. A value of 1 will animate fully to the off-screen location (no parallax), whilst 0.5 would animate halfway to the off-screen location.A value of 0 has the same effect as disabling \'animatePresentingCanvas\'.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SlideTransitionAnimator()
        {
        
        }
    
    }

}
