using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AngleStrength
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float _angleMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float _angleMax;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetAngleStrength(float angle)
        {
            return Game.AttackSequence.Static.AngleStrength.CalculateStrength(min:  this._angleMin, max:  this._angleMax, actual:  angle);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float CalculateStrength(float min, float max, float actual)
        {
            float val_5 = actual;
            float val_4 = max;
            max = min - val_4;
            if(System.Math.Abs(max) < 0)
            {
                    return (float)(val_5 <= min) ? 1f : 0f;
            }
            
            val_4 = val_4 - min;
            val_5 = val_5 - min;
            float val_2 = val_5 / val_4;
            val_2 = 1f - val_2;
            return UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AngleStrength(Game.AttackSequence.Static.StaticValueRange angleRange)
        {
            if(angleRange != null)
            {
                    this._angleMin = angleRange.Min;
            }
            else
            {
                    this._angleMin = 1.68059E-38f;
            }
            
            this._angleMax = angleRange.Max;
        }
    
    }

}
