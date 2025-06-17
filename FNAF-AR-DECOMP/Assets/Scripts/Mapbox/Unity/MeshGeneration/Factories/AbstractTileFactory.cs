using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Factories
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class AbstractTileFactory : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Platform.IFileSource _fileSource;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Mapbox.Unity.Map.LayerProperties _options;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Data.UnityTile> _tilesWaitingResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Data.UnityTile> _tilesWaitingProcessing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.EventHandler<Mapbox.Map.TileErrorEventArgs> OnTileError;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerProperties Options { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.LayerProperties get_Options()
        {
            return (Mapbox.Unity.Map.LayerProperties)this._options;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void SetOptions(Mapbox.Unity.Map.LayerProperties options)
        {
            this._options = options;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Initialize(Mapbox.Platform.IFileSource fileSource)
        {
            this._fileSource = fileSource;
            this._tilesWaitingResponse = new System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            this._tilesWaitingProcessing = new System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Data.UnityTile>();
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory).__il2cppRuntimeField_1B8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Register(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory).__il2cppRuntimeField_1C8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void PostProcess(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory).__il2cppRuntimeField_1D8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Unregister(Mapbox.Unity.MeshGeneration.Data.UnityTile tile)
        {
            goto typeof(Mapbox.Unity.MeshGeneration.Factories.AbstractTileFactory).__il2cppRuntimeField_1E8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void OnInitialized(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void OnRegistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void OnPostProcess(Mapbox.Unity.MeshGeneration.Data.UnityTile tile); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void OnUnregistered(Mapbox.Unity.MeshGeneration.Data.UnityTile tile); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnTileError(System.EventHandler<Mapbox.Map.TileErrorEventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnTileError, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTileError != 1152921519737306600);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnTileError(System.EventHandler<Mapbox.Map.TileErrorEventArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnTileError, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTileError != 1152921519737443176);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnErrorOccurred(Mapbox.Map.TileErrorEventArgs e)
        {
            if(this.OnTileError == null)
            {
                    return;
            }
            
            this.OnTileError.Invoke(sender:  this, e:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected AbstractTileFactory()
        {
        
        }
    
    }

}
