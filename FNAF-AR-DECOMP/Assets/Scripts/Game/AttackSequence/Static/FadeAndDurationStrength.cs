using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FadeAndDurationStrength
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float _fadeIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float _duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float _fadeOut;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _fadeInEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _durationEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _fadeOutEnd;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasEnded(float time)
        {
            if(this._start < 0)
            {
                    return true;
            }
            
            return (bool)(this._fadeOutEnd <= time) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start(float time)
        {
            float val_1 = this._fadeIn;
            val_1 = val_1 + time;
            this._start = time;
            this._fadeInEnd = val_1;
            time = val_1 + this._duration;
            val_1 = time + this._fadeOut;
            this._durationEnd = time;
            this._fadeOutEnd = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetStrength(float time)
        {
            float val_1;
            float val_2;
            if(this._start < 0)
            {
                    return (float)val_1;
            }
            
            if(this._fadeInEnd > time)
            {
                    val_1 = this._fadeIn;
                val_2 = time - this._start;
            }
            else
            {
                    if(this._durationEnd > time)
            {
                    return 1f;
            }
            
                if(this._fadeOutEnd <= time)
            {
                    return (float)val_1;
            }
            
                float val_1 = this._fadeIn;
                val_2 = time - this._start;
                val_1 = val_1 + this._duration;
                val_1 = val_1 + this._fadeOut;
            }
            
            val_1 = val_2 / val_1;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FadeAndDurationStrength(Game.AttackSequence.Static.StaticFadeSettings fadeSettings, Game.AttackSequence.Static.StaticValueRange durationRange)
        {
            float val_3;
            this._start = ;
            this._fadeInEnd = ;
            this._durationEnd = 3.402823E+38f;
            this._fadeOutEnd = 3.402823E+38f;
            val_1 = new System.Object();
            this._fadeIn = fadeSettings.FadeIn;
            if(val_1 != null)
            {
                    val_3 = durationRange.Min;
            }
            else
            {
                    val_3 = 1.68059E-38f;
            }
            
            this._duration = UnityEngine.Random.Range(min:  val_3, max:  durationRange.Max);
            this._fadeOut = fadeSettings.FadeOut;
        }
    
    }

}
