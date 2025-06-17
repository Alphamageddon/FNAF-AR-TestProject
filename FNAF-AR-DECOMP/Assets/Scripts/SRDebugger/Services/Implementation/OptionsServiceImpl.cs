using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class OptionsServiceImpl : IOptionsService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.EventHandler OptionsUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> OptionsValueUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<object, System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition>> _optionContainerLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition> _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.IList<SRDebugger.Internal.OptionDefinition> _optionsReadonly;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> Options { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OptionsUpdated(System.EventHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OptionsUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OptionsUpdated != 1152921522990830032);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OptionsUpdated(System.EventHandler value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OptionsUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OptionsUpdated != 1152921522990966608);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OptionsValueUpdated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OptionsValueUpdated != 1152921522991103192);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OptionsValueUpdated(System.EventHandler<System.ComponentModel.PropertyChangedEventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OptionsValueUpdated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OptionsValueUpdated != 1152921522991239768);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> get_Options()
        {
            return (System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition>)this._optionsReadonly;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public OptionsServiceImpl()
        {
            this._optionContainerLookup = new System.Collections.Generic.Dictionary<System.Object, System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition>>();
            this._options = new System.Collections.Generic.List<SRDebugger.Internal.OptionDefinition>();
            this._optionsReadonly = new System.Collections.ObjectModel.ReadOnlyCollection<SRDebugger.Internal.OptionDefinition>(list:  this._options);
            this.AddContainer(obj:  SROptions.Current);
            SROptions.Current.add_PropertyChanged(value:  new SROptionsPropertyChanged(object:  this, method:  System.Void SRDebugger.Services.Implementation.OptionsServiceImpl::OnSROptionsPropertyChanged(object sender, string propertyName)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Scan(object obj)
        {
            this.AddContainer(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddContainer(object obj)
        {
            IntPtr val_8;
            if((this._optionContainerLookup.ContainsKey(key:  obj)) != true)
            {
                    System.Collections.Generic.ICollection<SRDebugger.Internal.OptionDefinition> val_2 = SRDebugger.Internal.SRDebuggerUtil.ScanForOptions(obj:  obj);
                this._optionContainerLookup.Add(key:  obj, value:  val_2);
                var val_8 = 0;
                val_8 = val_8 + 1;
                if(val_2.Count < 1)
            {
                    return;
            }
            
                this._options.AddRange(collection:  val_2);
                this.OnOptionsUpdated();
                if(obj == null)
            {
                    return;
            }
            
                System.ComponentModel.PropertyChangedEventHandler val_5 = null;
                val_8 = System.Void SRDebugger.Services.Implementation.OptionsServiceImpl::OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs);
                val_5 = new System.ComponentModel.PropertyChangedEventHandler(object:  this, method:  val_8);
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_8 = 0;
                obj.add_PropertyChanged(value:  val_5);
                return;
            }
            
            System.Exception val_7 = new System.Exception(message:  "An object should only be added once.");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveContainer(object obj)
        {
            System.ComponentModel.PropertyChangedEventHandler val_12;
            var val_15;
            var val_16;
            IntPtr val_18;
            if((this._optionContainerLookup.ContainsKey(key:  obj)) == false)
            {
                    return;
            }
            
            bool val_3 = this._optionContainerLookup.Remove(key:  obj);
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_12 = this._optionContainerLookup.Item[obj].GetEnumerator();
            label_22:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_12.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            bool val_10 = this._options.Remove(item:  val_12.Current);
            goto label_22;
            label_15:
            val_15 = 0;
            val_16 = 88;
            if(val_12 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_12.Dispose();
            }
            
            if(obj != null)
            {
                    System.ComponentModel.PropertyChangedEventHandler val_12 = null;
                val_12 = val_12;
                val_18 = System.Void SRDebugger.Services.Implementation.OptionsServiceImpl::OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs);
                val_12 = new System.ComponentModel.PropertyChangedEventHandler(object:  this, method:  val_18);
                var val_18 = 0;
                val_18 = val_18 + 1;
                val_18 = 1;
                obj.remove_PropertyChanged(value:  val_12);
            }
            
            this.OnOptionsUpdated();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if(this.OptionsValueUpdated == null)
            {
                    return;
            }
            
            this.OptionsValueUpdated.Invoke(sender:  this, e:  propertyChangedEventArgs);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSROptionsPropertyChanged(object sender, string propertyName)
        {
            this.OnPropertyChanged(sender:  propertyName, propertyChangedEventArgs:  new System.ComponentModel.PropertyChangedEventArgs(propertyName:  propertyName));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnOptionsUpdated()
        {
            var val_1;
            if(this.OptionsUpdated == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.OptionsUpdated.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
    
    }

}
