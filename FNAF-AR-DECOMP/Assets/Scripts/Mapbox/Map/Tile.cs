using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class Tile : IAsyncRequest
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.CanonicalTileId _id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<System.Exception> _exceptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Map.Tile.State _state;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Platform.IAsyncRequest _request;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _callback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> ids;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasError { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> Exceptions { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ExceptionsAsString { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.Tile.State CurrentState { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Utilities.HttpRequestType RequestType { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsCompleted { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.CanonicalTileId get_Id()
        {
            return new Mapbox.Map.CanonicalTileId() {Z = this._id, X = this._id};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Id(Mapbox.Map.CanonicalTileId value)
        {
            this._id = value;
            mem[1152921519986053112] = value.Y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasError()
        {
            if(this._exceptions == null)
            {
                    return (bool)(this._exceptions.Count > 0) ? 1 : 0;
            }
            
            return (bool)(this._exceptions.Count > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Exception> get_Exceptions()
        {
            if(this._exceptions == null)
            {
                    return (System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>)this._exceptions.AsReadOnly();
            }
            
            return (System.Collections.ObjectModel.ReadOnlyCollection<System.Exception>)this._exceptions.AsReadOnly();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ExceptionsAsString()
        {
            var val_6;
            System.Func<System.Exception, System.String> val_8;
            if(this._exceptions == null)
            {
                    return (string)System.String.alignConst;
            }
            
            if(this._exceptions.Count == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = Tile.<>c.<>9__14_0;
            if(val_8 != null)
            {
                    return System.String.Join(separator:  System.Environment.NewLine, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Exception, System.String>(source:  this._exceptions, selector:  System.Func<System.Exception, System.String> val_3 = null)));
            }
            
            val_8 = val_3;
            val_3 = new System.Func<System.Exception, System.String>(object:  Tile.<>c.__il2cppRuntimeField_static_fields, method:  System.String Tile.<>c::<get_ExceptionsAsString>b__14_0(System.Exception e));
            Tile.<>c.<>9__14_0 = val_8;
            return System.String.Join(separator:  System.Environment.NewLine, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Exception, System.String>(source:  this._exceptions, selector:  val_3)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void AddException(System.Exception ex)
        {
            System.Collections.Generic.List<System.Exception> val_2 = this._exceptions;
            if(val_2 == null)
            {
                    System.Collections.Generic.List<System.Exception> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.List<System.Exception>();
                this._exceptions = val_2;
            }
            
            val_1.Add(item:  ex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.Tile.State get_CurrentState()
        {
            return (State)this._state;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.Utilities.HttpRequestType get_RequestType()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this._request.RequestType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsCompleted()
        {
            return (bool)(this._state == 2) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(Mapbox.Map.Tile.Parameters param, System.Action callback)
        {
            this.Cancel();
            this._state = 1;
            this._callback = callback;
            this._id = param.Id.Z;
            mem[1152921519987164168] = param.Id.Y;
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._request = param.Fs.Request(uri:  this.GetUrl(), callback:  new System.Action<Mapbox.Platform.Response>(object:  this, method:  System.Void Mapbox.Map.Tile::HandleTileResponse(Mapbox.Platform.Response response)), timeout:  10, tileId:  new Mapbox.Map.CanonicalTileId() {Z = this._id, X = this._id, Y = X24}, mapId:  param.MapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void Initialize(Mapbox.Platform.IFileSource fileSource, Mapbox.Map.CanonicalTileId canonicalTileId, string mapId, System.Action p)
        {
            this.Cancel();
            this._id = canonicalTileId;
            mem[1152921519987325320] = canonicalTileId.Y;
            this._callback = p;
            this._state = 1;
            var val_5 = 0;
            val_5 = val_5 + 1;
            this._request = fileSource.Request(uri:  this.GetUrl(), callback:  new System.Action<Mapbox.Platform.Response>(object:  this, method:  System.Void Mapbox.Map.Tile::HandleTileResponse(Mapbox.Platform.Response response)), timeout:  10, tileId:  new Mapbox.Map.CanonicalTileId() {Z = this._id, X = this._id, Y = 69734400}, mapId:  mapId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Cancel()
        {
            if(this._request != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this._request.Cancel();
                this._request = 0;
            }
            
            this._state = 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal abstract Mapbox.Map.TileResource MakeTileResource(string mapid); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal abstract bool ParseTileData(byte[] data); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HandleTileResponse(Mapbox.Platform.Response response)
        {
            var val_7;
            if(response.HasError == false)
            {
                goto label_2;
            }
            
            if((this.ids.Contains(item:  this._id)) == false)
            {
                goto label_4;
            }
            
            return;
            label_2:
            if(response != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            this.ids.Add(item:  this._id);
            val_7 = System.Linq.Enumerable.ToList<System.Exception>(source:  response.Exceptions);
            val_7.ForEach(action:  new System.Action<System.Exception>(object:  this, method:  System.Void Mapbox.Map.Tile::<HandleTileResponse>b__29_0(System.Exception e)));
            label_6:
            if(this._state != 3)
            {
                    this._state = (response.IsUpdate == true) ? 4 : 2;
            }
            
            this._callback.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Tile()
        {
            this.ids = new System.Collections.Generic.List<System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <HandleTileResponse>b__29_0(System.Exception e)
        {
            this.AddException(ex:  e);
        }
    
    }

}
