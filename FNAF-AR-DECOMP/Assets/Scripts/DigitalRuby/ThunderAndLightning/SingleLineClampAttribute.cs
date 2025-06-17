using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SingleLineClampAttribute : SingleLineAttribute
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <MinValue>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <MaxValue>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MinValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxValue { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SingleLineClampAttribute(string tooltip, double minValue, double maxValue)
        {
            val_1 = new UnityEngine.PropertyAttribute();
            mem[1152921528886575744] = tooltip;
            this.<MinValue>k__BackingField = minValue;
            this.<MaxValue>k__BackingField = maxValue;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_MinValue()
        {
            return (double)this.<MinValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MinValue(double value)
        {
            this.<MinValue>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_MaxValue()
        {
            return (double)this.<MaxValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MaxValue(double value)
        {
            this.<MaxValue>k__BackingField = value;
        }
    
    }

}
