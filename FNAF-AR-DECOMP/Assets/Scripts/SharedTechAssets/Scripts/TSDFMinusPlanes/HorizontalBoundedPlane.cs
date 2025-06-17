using UnityEngine;

namespace SharedTechAssets.Scripts.TSDFMinusPlanes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HorizontalBoundedPlane
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Height;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> Boundary;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int discretizedHeight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float resolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<UnityEngine.Vector3> tiles;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HorizontalBoundedPlane(float height, System.Collections.Generic.List<UnityEngine.Vector3> boundary, int id)
        {
            this.resolution = 0.05f;
            this.Height = height;
            this.Boundary = boundary;
            this.Id = id;
            this.tiles = new System.Collections.Generic.HashSet<UnityEngine.Vector3>();
            this.discretizedHeight = this.DiscretizeVal(val:  height);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Update(float height, System.Collections.Generic.List<UnityEngine.Vector3> boundary)
        {
            var val_2;
            int val_1 = this.DiscretizeVal(val:  height);
            this.Boundary = boundary;
            if(val_1 == this.discretizedHeight)
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            this.discretizedHeight = val_1;
            val_2 = 1;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int DiscretizeVal(float val)
        {
            float val_5 = this.resolution;
            val_5 = System.Math.Abs(val) / val_5;
            int val_6 = (int)val_5;
            val_5 = val_5 - (float)val_6;
            val_6 = ((val_5 > 0.5f) ? 1 : 0) + val_6;
            return (int)((val < 0) ? (-val_6) : (val_6)) << 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool PointWithinHorizontalPolygon(UnityEngine.Vector3 point)
        {
            float val_13;
            var val_14;
            System.Collections.Generic.List<UnityEngine.Vector3> val_15;
            float val_16;
            float val_17;
            float val_18;
            var val_19;
            val_13 = point.z;
            UnityEngine.Vector3 val_1 = this.Boundary.Item[0];
            float val_2 = point.x - val_1.x;
            val_14 = 2;
            goto label_2;
            label_15:
            UnityEngine.Vector3 val_4 = this.Boundary.Item[W21];
            val_15 = this.Boundary;
            val_13 = val_4.x;
            UnityEngine.Vector3 val_5 = val_15.Item[2];
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
            if(val_15 < (this.Boundary.Count - 1))
            {
                goto label_15;
            }
            
            val_19 = 0;
            return (bool)val_19;
            label_13:
            val_19 = 1;
            return (bool)val_19;
        }
    
    }

}
