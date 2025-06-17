using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TileErrorHandler : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _mapInstance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Map.TileErrorEvent OnTileError;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnEnable()
        {
            Mapbox.Unity.Map.AbstractMap val_4;
            if(this._mapInstance == 0)
            {
                    val_4 = this.GetComponent<Mapbox.Unity.Map.AbstractMap>();
                this._mapInstance = val_4;
            }
            else
            {
                    val_4 = this._mapInstance;
            }
            
            val_4.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.Map.TileErrorHandler::MapInstance_OnInitialized()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void MapInstance_OnInitialized()
        {
            this._mapInstance.remove_OnInitialized(value:  new System.Action(object:  this, method:  System.Void Mapbox.Unity.Map.TileErrorHandler::MapInstance_OnInitialized()));
            this._mapInstance._mapVisualizer.add_OnTileError(value:  new System.EventHandler<Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.TileErrorHandler::_OnTileErrorHandler(object sender, Mapbox.Map.TileErrorEventArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void _OnTileErrorHandler(object sender, Mapbox.Map.TileErrorEventArgs e)
        {
            System.Collections.Generic.List<System.Exception> val_8 = e.Exceptions;
            if(val_8.Count < 1)
            {
                goto label_14;
            }
            
            if((e.Exceptions.Item[0].Contains(value:  "Request aborted")) == true)
            {
                goto label_7;
            }
            
            bool val_5 = e.Exceptions.Item[0].Equals(value:  "Unable to write data");
            if(val_5 == false)
            {
                goto label_11;
            }
            
            label_7:
            val_8 = val_5.printMessage(exceptions:  e.Exceptions, e:  e);
            UnityEngine.Debug.LogWarning(message:  val_8);
            goto label_14;
            label_11:
            val_8 = val_5.printMessage(exceptions:  e.Exceptions, e:  e);
            UnityEngine.Debug.LogError(message:  val_8);
            label_14:
            if(this.OnTileError == null)
            {
                    return;
            }
            
            this.OnTileError.Invoke(arg0:  e);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string printMessage(System.Collections.Generic.List<System.Exception> exceptions, Mapbox.Map.TileErrorEventArgs e)
        {
            var val_10;
            System.Func<System.Exception, System.String> val_12;
            object[] val_1 = new object[5];
            val_1[0] = exceptions.Count;
            val_1[1] = e.TileId;
            val_1[2] = System.Environment.NewLine;
            val_10 = null;
            val_10 = null;
            val_12 = TileErrorHandler.<>c.<>9__5_0;
            if(val_12 == null)
            {
                    System.Func<System.Exception, System.String> val_5 = null;
                val_12 = val_5;
                val_5 = new System.Func<System.Exception, System.String>(object:  TileErrorHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.String TileErrorHandler.<>c::<printMessage>b__5_0(System.Exception ex));
                TileErrorHandler.<>c.<>9__5_0 = val_12;
            }
            
            val_1[3] = System.String.Join(separator:  System.Environment.NewLine, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Exception, System.String>(source:  exceptions, selector:  val_5)));
            val_1[4] = e.TileType;
            return (string)System.String.Format(format:  "{0} Exception(s) caused on the tile. Tile ID:{1} Tile Type:{4}{2}{3}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnDisable()
        {
            this._mapInstance._mapVisualizer.remove_OnTileError(value:  new System.EventHandler<Mapbox.Map.TileErrorEventArgs>(object:  this, method:  System.Void Mapbox.Unity.Map.TileErrorHandler::_OnTileErrorHandler(object sender, Mapbox.Map.TileErrorEventArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TileErrorHandler()
        {
        
        }
    
    }

}
