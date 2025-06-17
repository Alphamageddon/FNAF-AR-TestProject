using UnityEngine;

namespace Mapbox.Unity.Map
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class QuadTreeTileProvider : AbstractTileProvider
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Plane _groundPlane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.CameraBoundsTileProviderOptions _cbtpOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2dBounds _viewPortWebMercBounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> _tiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> _canonicalTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Ray _ray00;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Ray _ray01;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Ray _ray10;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Ray _ray11;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _hitPnt;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isFirstLoad;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnInitialized()
        {
            var val_9;
            this._tiles = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>();
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_2 = null;
            val_9 = public System.Void System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId>::.ctor();
            val_2 = new System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId>();
            this._canonicalTiles = val_2;
            if((public System.Void System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId>::.ctor()) != 0)
            {
                    this._cbtpOptions = 1152921519825993616;
                if((public System.Void System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId>::Clear()) == 0)
            {
                    this._cbtpOptions.camera = UnityEngine.Camera.main;
            }
            
                this._cbtpOptions.camera.transform.hasChanged = false;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
                this._shouldUpdate = true;
                this._groundPlane = 0;
                mem2[0] = new System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>();
                return;
            }
            
            this._cbtpOptions = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void UpdateTileExtent()
        {
            if(this._shouldUpdate == false)
            {
                    return;
            }
            
            Mapbox.Utils.Vector2dBounds val_1 = this.getcurrentViewPortWebMerc(useGroundPlane:  true);
            this._viewPortWebMercBounds = V0.16B;
            mem[1152921519826197264] = V1.16B;
            mem[1152921519826197272] = V2.16B;
            mem[1152921519826197280] = V3.16B;
            bool val_7 = static_value_04282000;
            var val_4 = static_value_04282000 + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            int val_2 = AbsoluteZoom;
            mem2[0] = this.GetWithWebMerc(bounds:  new Mapbox.Utils.Vector2dBounds() {SouthWest = new Mapbox.Utils.Vector2d() {x = val_2, y = val_2}, NorthEast = new Mapbox.Utils.Vector2d() {x = val_2, y = val_2}}, zoom:  0);
            this.OnExtentChanged();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId> GetWithWebMerc(Mapbox.Utils.Vector2dBounds bounds, int zoom)
        {
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_13;
            System.Collections.Generic.HashSet<Mapbox.Map.CanonicalTileId> val_14;
            var val_15;
            this._tiles.Clear();
            val_13 = this._canonicalTiles;
            val_13.Clear();
            if(((-1960379280) & 1) != 0)
            {
                    return (System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>)this._tiles;
            }
            
            Mapbox.Utils.Vector2d val_3 = new Mapbox.Utils.Vector2d(x:  System.Math.Max(val1:  ???, val2:  -20037508.3427892), y:  System.Math.Max(val1:  ???, val2:  -20037508.3427892));
            Mapbox.Map.UnwrappedTileId val_7 = new Mapbox.Utils.Vector2d(x:  System.Math.Min(val1:  ???, val2:  20037508.3427892), y:  System.Math.Min(val1:  ???, val2:  20037508.3427892)).WebMercatorToTileId(webMerc:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, zoom:  -1960335136);
            val_13 = val_7.Y;
            int val_15 = val_7.Z;
            Mapbox.Map.UnwrappedTileId val_8 = val_7.Z.WebMercatorToTileId(webMerc:  new Mapbox.Utils.Vector2d() {x = val_6.x, y = val_6.y}, zoom:  -1960335136);
            val_15 = val_15 >> 32;
            int val_9 = val_8.Z >> 32;
            if(val_15 > val_9)
            {
                    return (System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>)this._tiles;
            }
            
            do
            {
                int val_16 = val_8.Y;
                if(val_8.Y <= val_13)
            {
                    do
            {
                val_14 = this._canonicalTiles;
                val_15 = 0;
                if((val_14.Contains(item:  new Mapbox.Map.CanonicalTileId() {Z = -1960379328, X = 268435459, Y = val_15 & 4294967295})) != true)
            {
                    bool val_12 = this._tiles.Add(item:  new Mapbox.Map.UnwrappedTileId());
                val_14 = this._canonicalTiles;
                val_15 = 0;
                bool val_14 = val_14.Add(item:  new Mapbox.Map.CanonicalTileId() {Z = -1960379328, X = 268435459, Y = val_15 & 4294967295});
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 <= val_13);
            
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 <= val_9);
            
            return (System.Collections.Generic.HashSet<Mapbox.Map.UnwrappedTileId>)this._tiles;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Map.UnwrappedTileId WebMercatorToTileId(Mapbox.Utils.Vector2d webMerc, int zoom)
        {
            double val_3 = 1;
            double val_2 = 20037508.3427892;
            double val_1 = webMerc.x / val_2;
            val_2 = webMerc.y / val_2;
            val_1 = val_1 + 1;
            val_2 = 1 - val_2;
            val_1 = val_1 * 0.5;
            val_2 = val_2 * 0.5;
            val_1 = val_1 * val_3;
            val_3 = val_2 * val_3;
            return new Mapbox.Map.UnwrappedTileId();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Utils.Vector2dBounds getcurrentViewPortWebMerc(bool useGroundPlane = True)
        {
            var val_2;
            UnityEngine.Ray val_3;
            var val_5;
            UnityEngine.Ray val_6;
            var val_8;
            UnityEngine.Ray val_9;
            var val_11;
            UnityEngine.Ray val_12;
            UnityEngine.Vector3[] val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            var val_34;
            Mapbox.Utils.Vector2dBounds val_0;
            if(useGroundPlane != false)
            {
                    UnityEngine.Ray val_1 = this._cbtpOptions.camera.ViewportPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                mem[1152921519826802312] = val_2;
                this._ray00 = val_3;
                UnityEngine.Ray val_4 = this._cbtpOptions.camera.ViewportPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                mem[1152921519826802336] = val_5;
                this._ray01 = val_6;
                UnityEngine.Ray val_7 = this._cbtpOptions.camera.ViewportPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                mem[1152921519826802360] = val_8;
                this._ray10 = val_9;
                UnityEngine.Ray val_10 = this._cbtpOptions.camera.ViewportPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_29 = this;
                mem[1152921519826802384] = val_11;
                this._ray11 = val_12;
                UnityEngine.Vector3 val_13 = this.getGroundPlaneHitPoint(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = this._ray00.m_Origin, y = this._ray00.m_Origin, z = this._ray00.m_Origin}, m_Direction = new UnityEngine.Vector3() {x = this._ray00.m_Origin, y = mem[this._ray00 + 16], z = mem[this._ray00 + 16]}});
                this._hitPnt[0] = val_13;
                this._hitPnt[0] = val_13.y;
                this._hitPnt[0] = val_13.z;
                UnityEngine.Vector3 val_14 = this.getGroundPlaneHitPoint(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = this._ray01.m_Origin, y = this._ray01.m_Origin, z = this._ray01.m_Origin}, m_Direction = new UnityEngine.Vector3() {x = this._ray01.m_Origin, y = mem[this._ray01 + 16], z = mem[this._ray01 + 16]}});
                this._hitPnt[1] = val_14;
                this._hitPnt[1] = val_14.y;
                this._hitPnt[1] = val_14.z;
                UnityEngine.Vector3 val_15 = this.getGroundPlaneHitPoint(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = this._ray10.m_Origin, y = this._ray10.m_Origin, z = this._ray10.m_Origin}, m_Direction = new UnityEngine.Vector3() {x = this._ray10.m_Origin, y = mem[this._ray10 + 16], z = mem[this._ray10 + 16]}});
                this._hitPnt[2] = val_15;
                this._hitPnt[2] = val_15.y;
                this._hitPnt[2] = val_15.z;
                UnityEngine.Vector3 val_16 = this.getGroundPlaneHitPoint(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = this._ray11.m_Origin, y = this._ray11.m_Origin, z = this._ray11.m_Origin}, m_Direction = new UnityEngine.Vector3() {x = this._ray11.m_Origin, y = mem[this._ray11 + 16], z = mem[this._ray11 + 16]}});
                this._hitPnt[3] = val_16;
                this._hitPnt[3] = val_16.y;
                this._hitPnt[3] = val_16.z;
            }
            else
            {
                    val_29 = this._hitPnt;
            }
            
            val_30 = -3.402823E+38f;
            val_31 = 3.402823E+38f;
            var val_30 = 0;
            val_32 = val_31;
            val_33 = val_30;
            do
            {
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = (mem[this._hitPnt] + 40) + -8, y = (mem[this._hitPnt] + 40) + -8 + 4, z = mem[this._hitPnt] + 40}, rhs:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z})) != true)
            {
                    var val_20 = mem[this._hitPnt] + 40;
                if(val_31 > ((mem[this._hitPnt] + 40) + -8))
            {
                    var val_21 = mem[this._hitPnt] + 40;
                val_31 = (mem[this._hitPnt] + 40) + -8;
            }
            
                if(val_32 > (mem[this._hitPnt] + 40))
            {
                    val_32 = mem[mem[this._hitPnt] + 40];
                val_32 = mem[this._hitPnt] + 40;
            }
            
                var val_22 = mem[this._hitPnt] + 40;
                if(val_30 < 0)
            {
                    var val_23 = mem[this._hitPnt] + 40;
                val_30 = (mem[this._hitPnt] + 40) + -8;
            }
            
                if(val_33 < 0)
            {
                    val_33 = mem[mem[this._hitPnt] + 40];
                val_33 = mem[this._hitPnt] + 40;
            }
            
            }
            
                val_30 = val_30 + 1;
            }
            while((40 + 12) != 88);
            
            var val_34 = mem[this._hitPnt];
            if((mem[this._hitPnt] + 286) == 0)
            {
                goto label_49;
            }
            
            var val_31 = mem[this._hitPnt] + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_48:
            if(((mem[this._hitPnt] + 176 + 8) + -8) == null)
            {
                goto label_47;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (mem[this._hitPnt] + 286))
            {
                goto label_48;
            }
            
            goto label_49;
            label_47:
            var val_33 = val_31;
            val_33 = val_33 + 13;
            val_34 = val_34 + val_33;
            val_34 = val_34 + 296;
            label_49:
            Mapbox.Utils.Vector2d val_25 = val_29.WorldToGeoPosition(realworldPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            var val_35 = 0;
            val_35 = val_35 + 1;
            Mapbox.Utils.Vector2d val_27 = this.WorldToGeoPosition(realworldPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Mapbox.Utils.Vector2d val_28 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_25.x, y = val_25.y});
            Mapbox.Utils.Vector2d val_29 = Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_27.x, y = val_27.y});
            return val_0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 getGroundPlaneHitPoint(UnityEngine.Ray ray)
        {
            if((this._groundPlane & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual void Update()
        {
            if(this._cbtpOptions == null)
            {
                    return;
            }
            
            if(this._cbtpOptions.camera == 0)
            {
                    return;
            }
            
            if(this._cbtpOptions.camera.transform.hasChanged == false)
            {
                    return;
            }
            
            this._cbtpOptions.camera.transform.hasChanged = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public QuadTreeTileProvider()
        {
            this._hitPnt = new UnityEngine.Vector3[4];
        }
    
    }

}
