using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FadeToColorTransitionAnimator : CanvasControllerTransitioningAnimator, ICanvasControllerTransitioningAnimator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color color;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public P7.CanvasFlow.FadeToColorTransitionAnimator.FadeSetting preFadeSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public P7.CanvasFlow.FadeToColorTransitionAnimator.FadeSetting postFadeSettings;
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
            var val_4;
            FadeToColorTransitionAnimator.<>c__DisplayClass7_0 val_1 = new FadeToColorTransitionAnimator.<>c__DisplayClass7_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .transitionContext = transitionContext;
            mem[1152921525519807672] = this;
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
            
            val_4 = val_1;
            .destination = transitionContext.destinationCanvasController;
            goto label_4;
            label_1:
            mem[40] = this;
            mem[48] = transitionContext;
            if(mem[48] != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_4 = 16;
            mem[16] = transitionContext.destinationCanvasController;
            label_4:
            val_4.ContentActive = false;
            .imageOverlay = new FadeToColorTransitionAnimator.ImageOverlay();
            if(val_1 == null)
            {
                goto label_9;
            }
            
            label_16:
            (FadeToColorTransitionAnimator.ImageOverlay)[1152921525519815824].image.color = new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = 0f};
            .source = transitionContext.sourceCanvasController;
            (FadeToColorTransitionAnimator.<>c__DisplayClass7_0)[1152921525519807632].imageOverlay.SetParent(parent:  transitionContext.sourceCanvasController.content);
            this.PerformPreFade(imageOverlay:  (FadeToColorTransitionAnimator.<>c__DisplayClass7_0)[1152921525519807632].imageOverlay, completion:  new System.Action(object:  val_1, method:  System.Void FadeToColorTransitionAnimator.<>c__DisplayClass7_0::<AnimateTransition>b__0()));
            return;
            label_9:
            if(((FadeToColorTransitionAnimator.<>c__DisplayClass7_0)[1152921525519807632].imageOverlay) != null)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransitionForInitialCanvasController(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            var val_6;
            P7.CanvasFlow.CanvasController val_7;
            FadeToColorTransitionAnimator.<>c__DisplayClass8_0 val_1 = new FadeToColorTransitionAnimator.<>c__DisplayClass8_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            .transitionContext = transitionContext;
            FadeToColorTransitionAnimator.ImageOverlay val_2 = new FadeToColorTransitionAnimator.ImageOverlay();
            if(val_1 != null)
            {
                    val_6 = val_1;
                .imageOverlay = val_2;
            }
            else
            {
                    val_6 = 16;
                mem[16] = val_2;
            }
            
            if(((FadeToColorTransitionAnimator.<>c__DisplayClass8_0)[1152921525520051728].transitionContext.isUpstream) == false)
            {
                goto label_6;
            }
            
            FadeToColorTransitionAnimator.<>c__DisplayClass8_1 val_3 = new FadeToColorTransitionAnimator.<>c__DisplayClass8_1();
            .CS$<>8__locals1 = val_1;
            if(val_3 == null)
            {
                goto label_8;
            }
            
            if(val_1 != null)
            {
                goto label_23;
            }
            
            label_24:
            label_23:
            (FadeToColorTransitionAnimator.<>c__DisplayClass8_0)[1152921525520051728].imageOverlay.image.color = new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = 0f};
            val_7 = (FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].CS$<>8__locals1.transitionContext.sourceCanvasController;
            .source = val_7;
            if(((FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].CS$<>8__locals1) == null)
            {
                    val_7 = (FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].source;
            }
            
            (FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].CS$<>8__locals1.imageOverlay.SetParent(parent:  (FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].source.content);
            this.PerformPreFade(imageOverlay:  (FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].CS$<>8__locals1.imageOverlay, completion:  new System.Action(object:  val_3, method:  System.Void FadeToColorTransitionAnimator.<>c__DisplayClass8_1::<AnimateTransitionForInitialCanvasController>b__0()));
            return;
            label_6:
            val_2.SetParent(parent:  (FadeToColorTransitionAnimator.<>c__DisplayClass8_0)[1152921525520051728].transitionContext.destinationCanvasController.content);
            this.PerformPostFade(imageOverlay:  val_2, completion:  new System.Action(object:  (FadeToColorTransitionAnimator.<>c__DisplayClass8_0)[1152921525520051728].transitionContext, method:  public System.Void P7.CanvasFlow.CanvasControllerTransitionContext::CompleteTransition()));
            return;
            label_8:
            if(((FadeToColorTransitionAnimator.<>c__DisplayClass8_1)[1152921525520064016].CS$<>8__locals1) != null)
            {
                goto label_23;
            }
            
            goto label_24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PerformPreFade(P7.CanvasFlow.FadeToColorTransitionAnimator.ImageOverlay imageOverlay, System.Action completion)
        {
            UnityEngine.Color val_4;
            var val_8;
            FadeToColorTransitionAnimator.<>c__DisplayClass9_0 val_1 = new FadeToColorTransitionAnimator.<>c__DisplayClass9_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .imageOverlay = imageOverlay;
            val_4 = this.color;
            .targetColor = val_4;
            mem[1152921525520283588] = ???;
            mem[1152921525520283592] = ???;
            mem[1152921525520283596] = ???;
            if(val_1 != null)
            {
                    val_8 = 0;
            }
            else
            {
                    val_4 = (FadeToColorTransitionAnimator.<>c__DisplayClass9_0)[1152921525520283536].targetColor;
                val_8 = 1;
            }
            
            .targetColorTransparent = val_4;
            mem[1152921525520283572] = ???;
            mem[1152921525520283576] = ???;
            mem[1152921525520283580] = ???;
            mem[1152921525520283580] = 0;
            new P7.CanvasFlow.Routine(duration:  this.preFadeSettings, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  new System.Action<System.Single>(object:  val_1, method:  System.Void FadeToColorTransitionAnimator.<>c__DisplayClass9_0::<PerformPreFade>b__0(float progress01)), OnComplete:  completion);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PerformPostFade(P7.CanvasFlow.FadeToColorTransitionAnimator.ImageOverlay imageOverlay, System.Action completion)
        {
            UnityEngine.Color val_5;
            var val_9;
            FadeToColorTransitionAnimator.<>c__DisplayClass10_0 val_1 = new FadeToColorTransitionAnimator.<>c__DisplayClass10_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
                .imageOverlay = imageOverlay;
            }
            else
            {
                    mem[16] = this;
                mem[24] = imageOverlay;
            }
            
            .completion = completion;
            val_5 = this.color;
            .targetColor = val_5;
            mem[1152921525520442676] = imageOverlay;
            mem[1152921525520442680] = ???;
            mem[1152921525520442684] = ???;
            if(val_1 != null)
            {
                    val_9 = 0;
            }
            else
            {
                    val_5 = (FadeToColorTransitionAnimator.<>c__DisplayClass10_0)[1152921525520442640].targetColor;
                val_9 = 1;
            }
            
            .targetColorTransparent = val_5;
            mem[1152921525520442692] = imageOverlay;
            mem[1152921525520442696] = ???;
            mem[1152921525520442700] = ???;
            mem[1152921525520442700] = 0;
            new P7.CanvasFlow.Routine(duration:  this.postFadeSettings, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  new System.Action<System.Single>(object:  val_1, method:  System.Void FadeToColorTransitionAnimator.<>c__DisplayClass10_0::<PerformPostFade>b__0(float progress01)), OnComplete:  new System.Action(object:  val_1, method:  System.Void FadeToColorTransitionAnimator.<>c__DisplayClass10_0::<PerformPostFade>b__1()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Reset()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.black;
            this.color = val_1;
            mem[1152921525520547860] = val_1.g;
            mem[1152921525520547864] = val_1.b;
            mem[1152921525520547868] = val_1.a;
            this.preFadeSettings = new FadeSetting();
            mem[1152921525520547880] = UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f);
            this.postFadeSettings = new FadeSetting();
            mem[1152921525520547896] = UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f);
            mem[1152921525520547848] = "The \'fade to color\' transition animator creates a color fade transition between screens.\n\nIt will first fade from the source content to the specified color - the \'pre-fade\' - and then fade from the specified color to the destination content - the \'post-fade\'.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FadeToColorTransitionAnimator()
        {
        
        }
    
    }

}
