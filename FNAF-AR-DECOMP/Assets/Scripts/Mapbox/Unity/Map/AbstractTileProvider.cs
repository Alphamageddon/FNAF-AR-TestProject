using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AbstractTileProvider : MonoBehaviour, ITileProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.EventHandler<Mapbox.Unity.Map.ExtentArgs> ExtentChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.IMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.ExtentArgs _currentExtent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.ITileProviderOptions _options;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ITileProviderOptions Options { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_ExtentChanged(System.EventHandler<Mapbox.Unity.Map.ExtentArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.ExtentChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ExtentChanged != 1152921519822795752);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_ExtentChanged(System.EventHandler<Mapbox.Unity.Map.ExtentArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.ExtentChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.ExtentChanged != 1152921519822932328);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.ITileProviderOptions get_Options()
        {
            return (Mapbox.Unity.Map.ITileProviderOptions)this._options;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize(Mapbox.Unity.Map.IMap map)
        {
            this._map = map;
            goto typeof(Mapbox.Unity.Map.AbstractTileProvider).__il2cppRuntimeField_1D8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void OnExtentChanged()
        {
            this.ExtentChanged.Invoke(sender:  this, e:  this._currentExtent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void OnInitialized(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void UpdateTileExtent(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void SetOptions(Mapbox.Unity.Map.ITileProviderOptions options)
        {
            this._options = options;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AbstractTileProvider()
        {
            this._currentExtent = new Mapbox.Unity.Map.ExtentArgs();
        }
    
    }

}
