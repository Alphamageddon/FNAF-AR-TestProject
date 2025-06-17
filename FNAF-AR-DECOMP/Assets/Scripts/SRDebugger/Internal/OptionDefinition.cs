using UnityEngine;

namespace SRDebugger.Internal
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class OptionDefinition
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Category>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <SortPriority>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.Helpers.MethodReference <Method>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.Helpers.PropertyReference <Property>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Category { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SortPriority { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.MethodReference Method { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.PropertyReference Property { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private OptionDefinition(string name, string category, int sortPriority)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<Category>k__BackingField = val_1;
            this.<SortPriority>k__BackingField = sortPriority;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OptionDefinition(string name, string category, int sortPriority, SRF.Helpers.MethodReference method)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<Category>k__BackingField = val_1;
            this.<SortPriority>k__BackingField = sortPriority;
            this.<Method>k__BackingField = method;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OptionDefinition(string name, string category, int sortPriority, SRF.Helpers.PropertyReference property)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<Category>k__BackingField = val_1;
            this.<SortPriority>k__BackingField = sortPriority;
            this.<Property>k__BackingField = property;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Category()
        {
            return (string)this.<Category>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Category(string value)
        {
            this.<Category>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_SortPriority()
        {
            return (int)this.<SortPriority>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_SortPriority(int value)
        {
            this.<SortPriority>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.MethodReference get_Method()
        {
            return (SRF.Helpers.MethodReference)this.<Method>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Method(SRF.Helpers.MethodReference value)
        {
            this.<Method>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.Helpers.PropertyReference get_Property()
        {
            return (SRF.Helpers.PropertyReference)this.<Property>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Property(SRF.Helpers.PropertyReference value)
        {
            this.<Property>k__BackingField = value;
        }
    
    }

}
