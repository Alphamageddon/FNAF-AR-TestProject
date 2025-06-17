using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimationWatcher
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Playables.PlayableDirector> animations;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimationWatcher(UnityEngine.GameObject gameObject)
        {
            this.animations = System.Linq.Enumerable.ToList<UnityEngine.Playables.PlayableDirector>(source:  gameObject.GetComponentsInChildren<UnityEngine.Playables.PlayableDirector>());
            UnityEngine.Playables.PlayableDirector val_3 = gameObject.GetComponent<UnityEngine.Playables.PlayableDirector>();
            if(val_3 == 0)
            {
                    return;
            }
            
            this.animations.Add(item:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AllAnimationsComplete()
        {
            var val_7;
            var val_8;
            List.Enumerator<T> val_1 = this.animations.GetEnumerator();
            val_7 = 1152921524910980544;
            label_4:
            if(((-1170675608) & 1) == 0)
            {
                goto label_2;
            }
            
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            if((val_2 == null) || (val_2.state != 1))
            {
                goto label_4;
            }
            
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524911007848});
            val_8 = 0;
            return (bool)val_8;
            label_2:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524911007848});
            val_8 = 1;
            return (bool)val_8;
        }
    
    }

}
