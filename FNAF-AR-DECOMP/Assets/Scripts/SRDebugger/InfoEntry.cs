using UnityEngine;

namespace SRDebugger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class InfoEntry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsPrivate>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<object> _valueGetter;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object Value { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsPrivate { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Title()
        {
            return (string)this.<Title>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object get_Value()
        {
            return (object)this._valueGetter.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsPrivate()
        {
            return (bool)this.<IsPrivate>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsPrivate(bool value)
        {
            this.<IsPrivate>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.InfoEntry Create(string name, System.Func<object> getter, bool isPrivate = False)
        {
            SRDebugger.InfoEntry val_1 = new SRDebugger.InfoEntry();
            if(val_1 != null)
            {
                    .<Title>k__BackingField = name;
                ._valueGetter = getter;
            }
            else
            {
                    mem[16] = name;
                mem[32] = getter;
            }
            
            .<IsPrivate>k__BackingField = isPrivate;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static SRDebugger.InfoEntry Create(string name, object value, bool isPrivate = False)
        {
            .value = value;
            SRDebugger.InfoEntry val_2 = new SRDebugger.InfoEntry();
            .<Title>k__BackingField = name;
            System.Func<System.Object> val_3 = new System.Func<System.Object>(object:  new InfoEntry.<>c__DisplayClass12_0(), method:  System.Object InfoEntry.<>c__DisplayClass12_0::<Create>b__0());
            if(val_2 != null)
            {
                    ._valueGetter = val_3;
            }
            else
            {
                    mem[32] = val_3;
            }
            
            .<IsPrivate>k__BackingField = isPrivate;
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InfoEntry()
        {
        
        }
    
    }

}
