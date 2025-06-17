using UnityEngine;

namespace Animatronics.Animatronic3d.Model.Animation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimationEventListener : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<UnityEngine.AnimationEvent> OnAnimationEventReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAnimationEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimationEventReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimationEventReceived != 1152921525092994760);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAnimationEventReceived(System.Action<UnityEngine.AnimationEvent> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimationEventReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimationEventReceived != 1152921525093131336);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RaiseAnimationEvent(UnityEngine.AnimationEvent animationEvent)
        {
            if(this.OnAnimationEventReceived == null)
            {
                    return;
            }
            
            this.OnAnimationEventReceived.Invoke(obj:  animationEvent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimationEventListener()
        {
        
        }
    
    }

}
