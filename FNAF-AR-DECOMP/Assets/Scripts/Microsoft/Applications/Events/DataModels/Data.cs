using UnityEngine;

namespace Microsoft.Applications.Events.DataModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Data
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Microsoft.Applications.Events.DataModels.Value> <properties>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Microsoft.Applications.Events.DataModels.Value> properties { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Microsoft.Applications.Events.DataModels.Value> get_properties()
        {
            return (System.Collections.Generic.Dictionary<System.String, Microsoft.Applications.Events.DataModels.Value>)this.<properties>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_properties(System.Collections.Generic.Dictionary<string, Microsoft.Applications.Events.DataModels.Value> value)
        {
            this.<properties>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Data()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Data(string fullName, string name)
        {
            val_1 = new System.Object();
            this.<properties>k__BackingField = new System.Collections.Generic.Dictionary<System.String, Microsoft.Applications.Events.DataModels.Value>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Release()
        {
            if((this.<properties>k__BackingField) == null)
            {
                goto label_10;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.<properties>k__BackingField.GetEnumerator();
            label_4:
            if((105311320 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            val_2.m_SubId1.Release();
            goto label_4;
            label_2:
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526186994776});
            if((this.<properties>k__BackingField) != null)
            {
                    this.<properties>k__BackingField.Clear();
            }
            
            label_10:
            this.<properties>k__BackingField = 0;
        }
    
    }

}
