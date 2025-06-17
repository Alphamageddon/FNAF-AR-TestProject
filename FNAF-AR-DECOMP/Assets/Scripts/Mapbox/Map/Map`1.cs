using UnityEngine;

namespace Mapbox.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class Map<T> : IObservable<T>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int TileMax = 256;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Mapbox.Platform.IFileSource fs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2dBounds latLngBounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int zoom;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string mapId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<T> tiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Mapbox.Utils.IObserver<T>> observers;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MapId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<T> Tiles { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds Vector2dBounds { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d Center { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Zoom { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Map<T>(Mapbox.Platform.IFileSource fs)
        {
            mem[1152921519982293496] = __RuntimeMethodHiddenParam + 24 + 192;
            mem[1152921519982293504] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem[1152921519982293440] = fs;
            mem[1152921519982293464] = 0;
            mem[1152921519982293448] = 0;
            mem[1152921519982293480] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_MapId()
        {
            return (string)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_MapId(string value)
        {
            var val_2;
            var val_3;
            string val_8;
            var val_9;
            var val_10;
            val_8 = value;
            if((System.String.op_Equality(a:  32152, b:  val_8)) == true)
            {
                    return;
            }
            
            mem[1152921519982529792] = val_8;
            label_5:
            if(((-1804198528) & 1) == 0)
            {
                goto label_3;
            }
            
            val_3.emailUIDataHandler.Cancel();
            goto label_5;
            label_3:
            val_8 = 0;
            val_9 = 78;
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 64;
            val_2 = val_3;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 64 + 286) == 0)
            {
                goto label_13;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 64 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_12:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 64 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 24 + 192 + 64 + 286))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_10 = ((__RuntimeMethodHiddenParam + 24 + 192 + 64) + (((__RuntimeMethodHiddenParam + 24 + 192 + 64 + 176 + 8)) << 4)) + 296;
            label_13:
            val_3.Dispose();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<T> get_Tiles()
        {
            return (System.Collections.Generic.HashSet<T>)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2dBounds get_Vector2dBounds()
        {
            Mapbox.Utils.Vector2dBounds val_0;
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Vector2dBounds(Mapbox.Utils.Vector2dBounds value)
        {
            mem[1152921519982886008] = ???;
            mem[1152921519982886016] = ???;
            mem[1152921519982886024] = ???;
            mem[1152921519982886032] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Utils.Vector2d get_Center()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Center(Mapbox.Utils.Vector2d value)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_Zoom()
        {
            return (int)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Zoom(int value)
        {
            mem[1152921519983338088] = System.Math.Max(val1:  0, val2:  System.Math.Min(val1:  20, val2:  value));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetVector2dBoundsZoom(Mapbox.Utils.Vector2dBounds bounds, int zoom)
        {
            mem[1152921519983454120] = ???;
            mem[1152921519983454128] = ???;
            mem[1152921519983454136] = ???;
            mem[1152921519983454144] = ???;
            mem[1152921519983454152] = bounds.SouthWest.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Subscribe(Mapbox.Utils.IObserver<T> observer)
        {
            if(X20 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Unsubscribe(Mapbox.Utils.IObserver<T> observer)
        {
            if(X20 == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NotifyNext(T next)
        {
            var val_1;
            var val_2;
            var val_7;
            var val_9;
            var val_10;
            var val_11;
            val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 96];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
            label_10:
            if(((-1802909504) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_3 = val_2.emailUIDataHandler;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = 0;
            goto label_10;
            label_3:
            val_9 = 0;
            val_10 = 57;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 136;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 136 + 286) == 0)
            {
                goto label_18;
            }
            
            var val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 136 + 176;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_17:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 136 + 176 + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (__RuntimeMethodHiddenParam + 24 + 192 + 136 + 286))
            {
                goto label_17;
            }
            
            goto label_18;
            label_16:
            val_11 = ((__RuntimeMethodHiddenParam + 24 + 192 + 136) + (((__RuntimeMethodHiddenParam + 24 + 192 + 136 + 176 + 8)) << 4)) + 296;
            label_18:
            val_2.Dispose();
            if( == 57)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            var val_4;
            var val_5;
            var val_9;
            var val_10;
            var val_11;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 144;
            mem2[0] = this;
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_1 = Mapbox.Map.TileCover.Get(bounds:  new Mapbox.Utils.Vector2dBounds() {SouthWest = new Mapbox.Utils.Vector2d(), NorthEast = new Mapbox.Utils.Vector2d()}, zoom:  0);
            if(val_10 == 0)
            {
                goto label_3;
            }
            
            mem2[0] = val_1;
            if(val_1 != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            if(val_1.Count > 256)
            {
                    return;
            }
            
            HashSet.Enumerator<T> val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 144 + 16.GetEnumerator();
            label_15:
            if(((-1802780096) & 1) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = val_10;
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 208;
            new System.Action() = new System.Action(object:  __RuntimeMethodHiddenParam + 24 + 192 + 192, method:  __RuntimeMethodHiddenParam + 24 + 192 + 216);
            __RuntimeMethodHiddenParam + 24 + 192 + 208.Initialize(param:  new Parameters() {Id = new Mapbox.Map.CanonicalTileId() {Z = -1802780096, X = 268435459, Y = public Mapbox.Map.CanonicalTileId HashSet.Enumerator<Mapbox.Map.CanonicalTileId>::get_Current()}, MapId = ???, Fs = ???}, callback:  new System.Action());
            if(as. 
               
               
              
            
            
            
             != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_3:
            mem[16] = val_1;
            if(mem[16] != 0)
            {
                goto label_16;
            }
            
            goto label_17;
            label_10:
            val_9 = 0;
            val_11 = 232;
            val_5 = val_4;
            val_4 = null;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_4.Dispose();
            if( == 232)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
    
    }

}
