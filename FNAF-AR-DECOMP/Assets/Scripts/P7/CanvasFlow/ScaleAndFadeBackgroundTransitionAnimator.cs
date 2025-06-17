using UnityEngine;

namespace P7.CanvasFlow
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScaleAndFadeBackgroundTransitionAnimator : CanvasControllerTransitioningAnimator, ICanvasControllerTransitioningAnimator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve scaleCurve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string contentToScalePropertyName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool reverseScaleCurveOnUpstream;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve fadeCurve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool reverseFadeCurveOnUpstream;
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
            object val_9;
            System.Action<System.Single> val_10;
            ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass9_0 val_1 = new ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass9_0();
            if(val_1 != null)
            {
                    val_9 = val_1;
                .transitionContext = transitionContext;
                mem[1152921525522878288] = this;
                mem[1152921525522878272] = val_1.FadeBackgroundAnimation(transitionContext:  transitionContext);
                val_10 = this.ScaleContentAnimation(transitionContext:  .transitionContext);
            }
            else
            {
                    val_9 = 24;
                mem[24] = transitionContext;
                mem[32] = this;
                mem[16] = this.FadeBackgroundAnimation(transitionContext:  mem[24]);
                val_10 = this.ScaleContentAnimation(transitionContext:  mem[24]);
            }
            
            .scaleContent = val_10;
            new P7.CanvasFlow.Routine(duration:  this.duration, delay:  0f, updateMode:  this.useScaledTime).Run(OnUpdate:  new System.Action<System.Single>(object:  val_1, method:  System.Void ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass9_0::<AnimateTransition>b__0(float progress01)), OnComplete:  new System.Action(object:  val_9, method:  public System.Void P7.CanvasFlow.CanvasControllerTransitionContext::CompleteTransition()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void AnimateTransitionForInitialCanvasController(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            goto typeof(P7.CanvasFlow.ScaleAndFadeBackgroundTransitionAnimator).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> ScaleContentAnimation(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            P7.CanvasFlow.CanvasController val_6;
            UnityEngine.RectTransform val_7;
            if(transitionContext == null)
            {
                goto label_1;
            }
            
            if(transitionContext.isUpstream == false)
            {
                goto label_2;
            }
            
            label_4:
            val_6 = transitionContext.sourceCanvasController;
            goto label_3;
            label_1:
            if(64 != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_6 = transitionContext.destinationCanvasController;
            label_3:
            .targetTransform = 0;
            if((System.String.IsNullOrEmpty(value:  this.contentToScalePropertyName)) != false)
            {
                    val_7 = (ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass11_0)[1152921525523178032].targetTransform;
            }
            else
            {
                    val_7 = P7.CanvasFlow.DynamicObjectExtensions.DynamicObjectExtensions.GetField<UnityEngine.RectTransform>(obj:  mem[transitionContext.destinationCanvasController], fieldName:  this.contentToScalePropertyName);
                .targetTransform = val_7;
            }
            
            if(val_7 != 0)
            {
                    return (System.Action<System.Single>)new System.Action<System.Single>(object:  new ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass11_0(), method:  System.Void ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass11_0::<ScaleContentAnimation>b__0(float progress01));
            }
            
            .targetTransform = mem[transitionContext.destinationCanvasController] + 48;
            return (System.Action<System.Single>)new System.Action<System.Single>(object:  new ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass11_0(), method:  System.Void ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass11_0::<ScaleContentAnimation>b__0(float progress01));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<float> FadeBackgroundAnimation(P7.CanvasFlow.CanvasControllerTransitionContext transitionContext)
        {
            ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_0 val_7;
            var val_8;
            P7.CanvasFlow.CanvasController val_9;
            UnityEngine.Object val_10;
            var val_11;
            var val_12;
            ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_0 val_1 = null;
            val_7 = val_1;
            val_1 = new ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_0();
            if(transitionContext == null)
            {
                goto label_1;
            }
            
            val_8 = transitionContext;
            if(transitionContext.isUpstream == false)
            {
                goto label_2;
            }
            
            label_4:
            val_9 = transitionContext.sourceCanvasController;
            goto label_3;
            label_1:
            val_8 = 32;
            if(64 != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_9 = transitionContext.destinationCanvasController;
            label_3:
            if(val_7 != null)
            {
                    val_10 = val_7;
                .backgroundImage = mem[transitionContext.destinationCanvasController] + 64;
            }
            else
            {
                    val_10 = 16;
                mem[16] = mem[transitionContext.destinationCanvasController] + 64;
            }
            
            val_11 = 0;
            if(val_10 == 0)
            {
                    return (System.Action<System.Single>)val_11;
            }
            
            ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_1 val_3 = new ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_1();
            if(val_3 != null)
            {
                    val_12 = val_3;
                .CS$<>8__locals1 = val_7;
            }
            else
            {
                    val_12 = 48;
                mem[48] = val_7;
            }
            
            val_7 = .backgroundImage;
            .startColor = V0.16B;
            mem[1152921525523340228] = V1.16B;
            mem[1152921525523340232] = V2.16B;
            mem[1152921525523340236] = (val_8 != 0) ? (V3.16B) : 0f;
            .endColor = V0.16B;
            mem[1152921525523340244] = V1.16B;
            mem[1152921525523340248] = V2.16B;
            mem[1152921525523340252] = (64 != 0) ? 0f : (V3.16B);
            System.Action<System.Single> val_6 = null;
            val_11 = val_6;
            val_6 = new System.Action<System.Single>(object:  val_3, method:  System.Void ScaleAndFadeBackgroundTransitionAnimator.<>c__DisplayClass12_1::<FadeBackgroundAnimation>b__0(float progress01));
            return (System.Action<System.Single>)val_11;
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
            this.scaleCurve = new UnityEngine.AnimationCurve(keys:  val_1);
            UnityEngine.Keyframe[] val_3 = new UnityEngine.Keyframe[2];
            val_3[0] = 0;
            val_3[0] = 0;
            val_3[1] = 0;
            val_3[1] = 0;
            this.fadeCurve = new UnityEngine.AnimationCurve(keys:  val_3);
            mem[1152921525523446424] = "The \'scale and fade background\' transition animator presents content by scaling it up from the center of the screen, whilst fading in the backgroundImage property. It dismisses content by performing the reverse - scaling content down and fading out the backgroundImage property.\n\nThe \'contentToScalePropertyName\' field allows you to specify what content gets scaled in your transition. You can set this to the name of any RectTransform property on your canvas controller. If none is specified or the property does not exist, the canvas controller\'s \'content\' transform will be scaled.\n\nThe reverseScaleCurveOnUpstream and reverseFadeCurveOnUpstream flags cause the relevant animation curves to be evaluated backwards on upstream transitions.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScaleAndFadeBackgroundTransitionAnimator()
        {
        
        }
    
    }

}
