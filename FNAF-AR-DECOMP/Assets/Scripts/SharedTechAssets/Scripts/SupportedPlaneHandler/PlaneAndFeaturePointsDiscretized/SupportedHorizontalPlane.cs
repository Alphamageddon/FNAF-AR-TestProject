using UnityEngine;

namespace SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SupportedHorizontalPlane : SupportedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<UnityEngine.Vector2> SupportingPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <Height>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 <discretizedCenter>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _heightAtLastChange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig.Horizontal _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector2, SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlane.Tile> _tiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.Vector2 _origin;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Height { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 discretizedCenter { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_Height()
        {
            return (float)this.<Height>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Height(float value)
        {
            this.<Height>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 get_discretizedCenter()
        {
            return new UnityEngine.Vector2() {x = this.<discretizedCenter>k__BackingField};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_discretizedCenter(UnityEngine.Vector2 value)
        {
            this.<discretizedCenter>k__BackingField = value;
            mem[1152921523068387648] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SupportedHorizontalPlane(SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlaneConfig.Horizontal config, int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center)
        {
            this._tiles = new System.Collections.Generic.Dictionary<UnityEngine.Vector2, Tile>();
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this._origin = val_2.x;
            mem[1152921523068514020] = val_2.y;
            val_3 = new System.Object();
            mem[1152921523068513952] = id;
            mem[1152921523068513960] = val_3;
            this._config = config.resolution;
            mem[1152921523068514000] = config.pointAddTolerance;
            mem[1152921523068514004] = config.heightTolerance;
            this.<Height>k__BackingField = center.y;
            this._heightAtLastChange = center.y;
            UnityEngine.Vector2 val_4 = this.DiscretizePoint(x:  center.x, y:  center.z);
            this.<discretizedCenter>k__BackingField = val_4;
            mem[1152921523068513984] = val_4.y;
            this.SupportingPoints = new System.Collections.Generic.HashSet<UnityEngine.Vector2>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Update(float height, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            this.<Height>k__BackingField = height;
            mem[1152921523068642344] = boundary;
            float val_3 = System.Math.Abs(this._heightAtLastChange - height);
            if(val_3 <= height)
            {
                    return (bool)(val_3 > height) ? 1 : 0;
            }
            
            this._heightAtLastChange = height;
            return (bool)(val_3 > height) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PointWithinHorizontalPolygon(UnityEngine.Vector3 point)
        {
            float val_13;
            var val_14;
            var val_15;
            float val_16;
            float val_17;
            float val_18;
            var val_19;
            val_13 = point.z;
            UnityEngine.Vector3 val_1 = Item[0];
            float val_2 = point.x - val_1.x;
            val_14 = 2;
            goto label_2;
            label_15:
            UnityEngine.Vector3 val_4 = X22.Item[W21];
            val_13 = val_4.x;
            UnityEngine.Vector3 val_5 = X21.Item[2];
            float val_6 = val_13 - val_1.x;
            float val_7 = val_5.x - val_1.x;
            val_16 = val_4.z - val_1.z;
            val_5.z = val_5.z - val_1.z;
            if(val_6 != 0f)
            {
                goto label_5;
            }
            
            val_17 = val_2 / val_7;
            if((val_17 < 0f) || (val_17 > 1f))
            {
                goto label_12;
            }
            
            val_18 = val_5.z * val_17;
            goto label_8;
            label_5:
            float val_8 = (val_13 - val_1.z) * val_6;
            val_5.z = val_6 * val_5.z;
            val_16 = val_16 * val_7;
            val_8 = val_8 - (val_2 * val_16);
            val_16 = val_5.z - val_16;
            val_17 = val_8 / val_16;
            if((val_17 < 0f) || (val_17 > 1f))
            {
                goto label_12;
            }
            
            val_18 = val_7 * val_17;
            val_16 = val_6;
            label_8:
            val_18 = val_2 - val_18;
            val_16 = val_18 / val_16;
            if((val_16 < 0f) || (val_17 < 0f))
            {
                goto label_12;
            }
            
            val_17 = val_16 + val_17;
            if(val_17 <= 1f)
            {
                goto label_13;
            }
            
            label_12:
            val_14 = 3;
            label_2:
            val_15 = val_14 - 1;
            if(val_15 < (X22.Count - 1))
            {
                goto label_15;
            }
            
            val_19 = 0;
            return (bool)val_19;
            label_13:
            val_19 = 1;
            return (bool)val_19;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float DiscretizeVal(float val)
        {
            Horizontal val_5 = this._config;
            float val_3 = System.Math.Abs(val);
            val_3 = val_3 / val_5;
            int val_4 = (int)val_3;
            val_3 = val_3 - (float)val_4;
            val_4 = ((val_3 > 0.5f) ? 1 : 0) + val_4;
            val_5 = val_5 * ((float)(val < 0) ? (-val_4) : (val_4));
            return (float)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 DiscretizePoint(float x, float y)
        {
            UnityEngine.Vector2 val_5 = this.<discretizedCenter>k__BackingField;
            x = x - val_5;
            float val_1 = this.DiscretizeVal(val:  x);
            val_1 = y - val_1;
            val_5 = (this.DiscretizeVal(val:  val_1)) + val_5;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_1 + (this.<discretizedCenter>k__BackingField), y:  val_5);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetTileVal(float val)
        {
            float val_1;
            double val_7;
            float val_8;
            double val_9;
            float val_10;
            double val_11;
            Horizontal val_6 = this._config;
            if(val >= 0f)
            {
                goto label_1;
            }
            
            val_6 = val / val_6;
            val_7 = (double)val_6;
            if(val_6 >= 0f)
            {
                goto label_4;
            }
            
            if(val_7 != (-0.5))
            {
                goto label_5;
            }
            
            val_8 = val_1;
            val_9 = -1;
            goto label_6;
            label_1:
            val_6 = val / val_6;
            val_7 = (double)val_6;
            if(val_6 >= 0f)
            {
                goto label_9;
            }
            
            if(val_7 != (-0.5))
            {
                goto label_10;
            }
            
            val_10 = val_1;
            val_11 = -1;
            goto label_11;
            label_4:
            if(val_7 != 0.5)
            {
                goto label_12;
            }
            
            val_8 = val_1;
            val_9 = 1;
            label_6:
            val_9 = val_8 + val_9;
            val_8 = (((long)val_8 & 1) != 0) ? (val_8) : (val_9);
            goto label_16;
            label_9:
            if(val_7 != 0.5)
            {
                goto label_14;
            }
            
            val_10 = val_1;
            val_11 = 1;
            label_11:
            val_11 = val_10 + val_11;
            val_10 = (((long)val_10 & 1) != 0) ? (val_10) : (val_11);
            goto label_17;
            label_5:
            double val_2 = val_7 + (-0.5);
            goto label_16;
            label_10:
            double val_3 = val_7 + (-0.5);
            goto label_17;
            label_12:
            double val_4 = val_7 + 0.5;
            label_16:
            val_4 = val_4 + 1;
            goto label_18;
            label_14:
            double val_5 = val_7 + 0.5;
            label_17:
            label_18:
            Horizontal val_8 = this._config;
            float val_7 = (float)(((val / this._config) + 0.5) / System.Math.__il2cppRuntimeField_cctor_finished);
            val_7 = val_8 * val_7;
            val_8 = val_8 * ((float)(System.Math.__il2cppRuntimeField_cctor_finished - 1));
            val_7 = val_7 * (float)System.Math.__il2cppRuntimeField_cctor_finished;
            val_8 = val_8 * 0.5f;
            val_8 = val_7 + val_8;
            return (float)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 GetTileKey(UnityEngine.Vector2 point)
        {
            UnityEngine.Vector2 val_5 = this.<discretizedCenter>k__BackingField;
            point.x = point.x - val_5;
            float val_1 = this.GetTileVal(val:  point.x);
            val_1 = point.y - val_1;
            val_5 = (this.GetTileVal(val:  val_1)) + val_5;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_1 + (this.<discretizedCenter>k__BackingField), y:  val_5);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.SupportedPlaneHandler.PlaneAndFeaturePointsDiscretized.SupportedPlane.Tile AddToTiles(UnityEngine.Vector2 point)
        {
            var val_5;
            int val_6;
            UnityEngine.Vector2 val_1 = this.GetTileKey(point:  new UnityEngine.Vector2() {x = point.x, y = point.y});
            if((this._tiles.ContainsKey(key:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y})) != true)
            {
                    .center = val_1;
                mem[1152921523069382180] = val_1.y;
                this._tiles.set_Item(key:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, value:  new SupportedPlane.Tile(tileSize:  W22));
            }
            
            Tile val_4 = this._tiles.Item[new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}];
            if(val_4 != null)
            {
                    val_5 = val_4;
                val_6 = val_4.count;
            }
            else
            {
                    val_5 = 32;
                val_6 = 64;
            }
            
            mem[32] = 65;
            return val_4;
        }
    
    }

}
