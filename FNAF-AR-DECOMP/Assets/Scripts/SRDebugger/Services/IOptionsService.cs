using UnityEngine;

namespace SRDebugger.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IOptionsService
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> Options { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OptionsUpdated(System.EventHandler value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OptionsUpdated(System.EventHandler value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void add_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void remove_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> get_Options(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Scan(object obj); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddContainer(object obj); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveContainer(object obj); // 0
    
    }

}
