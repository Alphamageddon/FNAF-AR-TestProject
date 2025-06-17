using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Animation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimationEventDispatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnEffectEventReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnGameEventReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnSoundEventReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int EffectEventIdMin = 1000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int EffectEventIdMax = 1999;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int GameEventIdMin = 2000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int GameEventIdMax = 2999;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int SoundEventIdMin = 3000;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int SoundEventIdMax = 3999;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Animatronics.Animatronic3d.Model.Animation.AnimationEventListener _animationEventListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEffectEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEffectEventReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEffectEventReceived != 1152921525091540256);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEffectEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEffectEventReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEffectEventReceived != 1152921525091676832);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGameEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGameEventReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGameEventReceived != 1152921525091813416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGameEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGameEventReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGameEventReceived != 1152921525091949992);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSoundEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSoundEventReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSoundEventReceived != 1152921525092086576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSoundEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSoundEventReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSoundEventReceived != 1152921525092223152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AnimationEventReceived(UnityEngine.AnimationEvent animationEvent)
        {
            int val_6;
            var val_7;
            val_6 = animationEvent;
            int val_1 = val_6.intParameter;
            if((val_1 - 1000) <= 999)
            {
                goto label_2;
            }
            
            if((val_1 - 2000) <= 999)
            {
                goto label_3;
            }
            
            if((val_1 - 3000) <= 999)
            {
                goto label_4;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = Animatronics.Animatronic3d.Model.Animation.AnimationEventDispatcher.SoundEventIdMax;
            ConsoleLogger.LogError(className:  val_6, functionName:  "AnimationEventReceived", logString:  System.String.Format(format:  "Received an animation event with an unknown id \'{0}\'", arg0:  val_1));
            return;
            label_2:
            if(this.OnEffectEventReceived == null)
            {
                    return;
            }
            
            label_12:
            this.OnEffectEventReceived.Invoke(obj:  val_6);
            return;
            label_3:
            if(this.OnGameEventReceived != null)
            {
                goto label_12;
            }
            
            return;
            label_4:
            if(this.OnSoundEventReceived != null)
            {
                goto label_12;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Animatronics.Animatronic3d.Model.Animation.AnimationEventListener animationEventListener)
        {
            this._animationEventListener = animationEventListener;
            animationEventListener.add_OnAnimationEventReceived(value:  new System.Action<UnityEngine.AnimationEvent>(object:  this, method:  public System.Void Animatronics.Animatronic3d.Model.Animation.AnimationEventDispatcher::AnimationEventReceived(UnityEngine.AnimationEvent animationEvent)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._animationEventListener = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimationEventDispatcher()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AnimationEventDispatcher()
        {
            Animatronics.Animatronic3d.Model.Animation.AnimationEventDispatcher.SoundEventIdMax = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
