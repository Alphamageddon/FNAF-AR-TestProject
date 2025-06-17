using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningQualityMaximum
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <MaximumGenerations>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <MaximumLightPercent>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <MaximumShadowPercent>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaximumGenerations { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaximumLightPercent { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaximumShadowPercent { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaximumGenerations()
        {
            return (int)this.<MaximumGenerations>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaximumGenerations(int value)
        {
            this.<MaximumGenerations>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MaximumLightPercent()
        {
            return (float)this.<MaximumLightPercent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaximumLightPercent(float value)
        {
            this.<MaximumLightPercent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_MaximumShadowPercent()
        {
            return (float)this.<MaximumShadowPercent>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MaximumShadowPercent(float value)
        {
            this.<MaximumShadowPercent>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningQualityMaximum()
        {
        
        }
    
    }

}
