using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileErrorEventArgs : EventArgs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId TileId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<System.Exception> Exceptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.UnityTile UnityTileInstance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Type TileType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileErrorEventArgs(Mapbox.Map.CanonicalTileId TileId, System.Type TileType, Mapbox.Unity.MeshGeneration.Data.UnityTile UnityTileInstance, System.Collections.Generic.List<System.Exception> Exceptions)
        {
            this.TileId = TileId;
            mem[1152921519989051416] = TileId.Y;
            this.Exceptions = Exceptions;
            this.UnityTileInstance = UnityTileInstance;
            this.TileType = TileType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileErrorEventArgs(Mapbox.Map.CanonicalTileId TileId, System.Type TileType, Mapbox.Unity.MeshGeneration.Data.UnityTile UnityTileInstance, System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> Exceptions)
        {
            var val_8;
            var val_9;
            this.TileId = TileId;
            mem[1152921519989196232] = TileId.Y;
            System.Collections.Generic.List<System.Exception> val_1 = new System.Collections.Generic.List<System.Exception>();
            System.Collections.Generic.IEnumerator<T> val_2 = Exceptions.GetEnumerator();
            label_16:
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_1.Add(item:  val_2.Current);
            goto label_16;
            label_9:
            val_8 = 0;
            val_9 = 63;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_2.Dispose();
            }
            
            this.Exceptions = val_1;
            this.UnityTileInstance = UnityTileInstance;
            this.TileType = TileType;
        }
    
    }

}
