using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltSegmentGroup
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LineWidth;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StartIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Generation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Delay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PeakStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float PeakEnd;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LifeTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float EndWidthMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color32 Color;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegment> Segments;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.List<UnityEngine.Light> Lights;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningLightParameters LightParameters;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SegmentCount { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_SegmentCount()
        {
            int val_1 = this.Segments.Count;
            val_1 = val_1 - this.StartIndex;
            return (int)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.LightParameters = 0;
            this.Segments.Clear();
            this.Lights.Clear();
            this.StartIndex = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltSegmentGroup()
        {
            this.Segments = new System.Collections.Generic.List<DigitalRuby.ThunderAndLightning.LightningBoltSegment>();
            this.Lights = new System.Collections.Generic.List<UnityEngine.Light>();
        }
    
    }

}
