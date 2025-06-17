using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SentAnimatronicData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <timeElapsed>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2d <direction>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float timeElapsed { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d direction { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_timeElapsed()
        {
            return (float)this.<timeElapsed>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_timeElapsed(float value)
        {
            this.<timeElapsed>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_direction()
        {
            return new Mapbox.Utils.Vector2d() {x = this.<direction>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_direction(Mapbox.Utils.Vector2d value)
        {
            this.<direction>k__BackingField = value;
            mem[1152921525024035936] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SentAnimatronicData()
        {
            this.<timeElapsed>k__BackingField = 0f;
            Mapbox.Utils.Vector2d val_1 = Mapbox.Utils.Vector2d.zero;
            this.<direction>k__BackingField = val_1;
            mem[1152921525024147936] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)"Blink Time Elapsed: "("Blink Time Elapsed: ") + this.<timeElapsed>k__BackingField(this.<timeElapsed>k__BackingField);
        }
    
    }

}
