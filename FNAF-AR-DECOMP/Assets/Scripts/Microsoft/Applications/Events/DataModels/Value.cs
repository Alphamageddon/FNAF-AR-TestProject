using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Value
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Microsoft.Applications.Events.DataModels.ValueKind <type>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Attributes> <attributes>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <stringValue>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <longValue>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double <doubleValue>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<byte>> <guidValue>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<string>> <stringArray>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<long>> <longArray>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<double>> <doubleArray>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<long>>> <guidArray>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.Applications.Events.DataModels.ValueKind type { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Attributes> attributes { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string stringValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long longValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double doubleValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<byte>> guidValue { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> stringArray { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<long>> longArray { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<double>> doubleArray { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<long>>> guidArray { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Microsoft.Applications.Events.DataModels.ValueKind get_type()
        {
            return (Microsoft.Applications.Events.DataModels.ValueKind)this.<type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_type(Microsoft.Applications.Events.DataModels.ValueKind value)
        {
            this.<type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Attributes> get_attributes()
        {
            return (System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Attributes>)this.<attributes>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_attributes(System.Collections.Generic.List<Microsoft.Applications.Events.DataModels.Attributes> value)
        {
            this.<attributes>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_stringValue()
        {
            return (string)this.<stringValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_stringValue(string value)
        {
            this.<stringValue>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_longValue()
        {
            return (long)this.<longValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_longValue(long value)
        {
            this.<longValue>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double get_doubleValue()
        {
            return (double)this.<doubleValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_doubleValue(double value)
        {
            this.<doubleValue>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<byte>> get_guidValue()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<System.Byte>>)this.<guidValue>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_guidValue(System.Collections.Generic.List<System.Collections.Generic.List<byte>> value)
        {
            this.<guidValue>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<string>> get_stringArray()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<System.String>>)this.<stringArray>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_stringArray(System.Collections.Generic.List<System.Collections.Generic.List<string>> value)
        {
            this.<stringArray>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<long>> get_longArray()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<System.Int64>>)this.<longArray>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_longArray(System.Collections.Generic.List<System.Collections.Generic.List<long>> value)
        {
            this.<longArray>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<double>> get_doubleArray()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<System.Double>>)this.<doubleArray>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_doubleArray(System.Collections.Generic.List<System.Collections.Generic.List<double>> value)
        {
            this.<doubleArray>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<long>>> get_guidArray()
        {
            return (System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<System.Int64>>>)this.<guidArray>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_guidArray(System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<long>>> value)
        {
            this.<guidArray>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Value()
        {
            this.<type>k__BackingField = 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Value(string fullName, string name)
        {
            val_1 = new System.Object();
            this.<type>k__BackingField = 5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Release()
        {
            if((this.<attributes>k__BackingField) == null)
            {
                goto label_8;
            }
            
            List.Enumerator<T> val_1 = this.<attributes>k__BackingField.GetEnumerator();
            goto label_2;
            label_4:
            GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            val_2._serverGameUIDataModel = 0;
            label_2:
            if((104683768 & 1) != 0)
            {
                goto label_4;
            }
            
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526186367224});
            label_8:
            this.<attributes>k__BackingField = 0;
            this.<guidArray>k__BackingField = 0;
            this.<longArray>k__BackingField = 0;
            this.<guidValue>k__BackingField = 0;
        }
    
    }

}
